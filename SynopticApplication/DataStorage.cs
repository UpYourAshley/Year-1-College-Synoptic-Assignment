using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SynopticApplication
{
    public static class DataStorage
    {
        //Fix this - Keeps the file in use.
        public static bool SetUp(string folderPath, string filePath)
        {
            if (!DirectoryExsits(folderPath))
            {
                try
                {
                    Directory.CreateDirectory(folderPath);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Failed to create dataFile : {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (!FileExists(filePath))
            {
                try
                {
                    File.Create(folderPath + "/" + filePath);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Failed to create data file. Message : {e.Message}");
                    return false;
                }
            }

            return true;
        }

        //Load current file that has the data stored
        //add current paintent to it 
        //save it over the old one
        public static void SaveData(List<Paitent> paintent, string filePath)
        {
            string json = JsonConvert.SerializeObject(paintent, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static void SaveData(List<Drug> paintent, string filePath)
        {
            string json = JsonConvert.SerializeObject(paintent, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }


        public static IEnumerable<Paitent> LoadPaitentData(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Paitent>>(json);
        }

        public static IEnumerable<Drug> LoadDrugData(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Drug>>(json);
        }


        public static bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        public static bool DirectoryExsits(string path)
        {
            return Directory.Exists(path);
        }
    }
}
