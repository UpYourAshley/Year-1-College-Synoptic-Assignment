using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SynopticApplication.Enum;
using Newtonsoft.Json;

namespace SynopticApplication
{
    static class Program
    {
        private const string DataFolder = "Resources";

        private static List<Paitent> allPaitents = new List<Paitent>();
        public static List<Paitent> AllPaitents
        {
            get { return allPaitents; }
        }
        private const string PaintentDataFile = "PaintentData.json";

        public static List<Drug> allDrugs = new List<Drug>();

        public static Drug drug = new Drug() { Class = DrugClass.Analgesics, ID = 0, Name = "yes" };

        
        private const string DrugDataFile = "DrugData.json";

        public static List<Drug> analgesicsDrugs = new List<Drug>();
        public static List<Drug> antiHypertensivesDrugs = new List<Drug>();
        public static List<Drug> cholesterolLoweringDrugs = new List<Drug>();
        public static List<Drug> diabetesDrugs = new List<Drug>();

        public static Paitent paitent = new Paitent() {SideEffects = new SideEffect[3] };


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                allDrugs = DataStorage.LoadDrugData(DataFolder + "/" + DrugDataFile).ToList<Drug>();
               
            }
            catch (Exception e)
            {
                
                //Shows error and closes application
                MessageBox.Show($"Error while loading data \r\n{e.Message}", "Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                Application.Exit();
            }

            try
            {
                allPaitents = DataStorage.LoadPaitentData(DataFolder + "/" + PaintentDataFile).ToList<Paitent>();
            }
            catch(Exception e)
            {

            }

            if(allDrugs.Count() == 0)
            {
                MessageBox.Show("No drug data was loaded.", "Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            SortDrugs(allDrugs);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        /// <summary>
        /// Adds a paitent object to the curent list of all paitents 
        /// then saves the data by calling the "SaveData" fucntion in the DataStorage class
        /// </summary>
        /// <param name="toAdd">the paitent object that is to added to the list</param>
        public static void AddPaitent(Paitent toAdd)
        {
            //Adds the object to the list
            allPaitents.Add(toAdd);

            //Saves the data - Gives the list and the path in which the data is to be saved at 
            DataStorage.SaveData(allPaitents, DataFolder + "/" + PaintentDataFile);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="drugs"></param>
        public static void SortDrugs(List<Drug> drugs)
        {
            foreach (Drug d in drugs)
            {
                switch (d.Class)
                {
                    case DrugClass.Analgesics:
                        analgesicsDrugs.Add(d);
                        break;
                    case DrugClass.Anti_Hypertensive:
                        antiHypertensivesDrugs.Add(d);
                        break;
                    case DrugClass.Cholesterol_Lowering:
                        cholesterolLoweringDrugs.Add(d);
                        break;
                    case DrugClass.Diabetes:
                        diabetesDrugs.Add(d);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Will return a drug object that matches 
        /// the given ID
        /// </summary>
        /// <param name="ID">ID to match</param>
        /// <returns>Will return the drug object that has the matching ID</returns>
        public static Drug GetDrug(int ID)
        {
            var result = from a in allDrugs
                         where a.ID == ID
                         select a;

            ///If multiple are found that match it will set drug to the first one(this shouldn't happen anyways but just incase)
            ///if no matching drugs were found it will set drug to null
            var drug = result.FirstOrDefault();

            if (drug == null)
            {
                //shows error and retunrs null
                return null;
            }

            return drug;
        }

        /// <summary>
        /// This will return a drug object that matches 
        /// a given name.
        /// </summary>
        /// <param name="name">The name of the drug that is being requested</param>
        /// <returns>Returns the drug object with the matching name</returns>
        public static Drug GetDrug(string name)
        {
            var result = from a in allDrugs
                         where a.Name == name
                         select a;

            var drug = result.FirstOrDefault();

            if (drug == null)
            {
                //shows error and retunrs null
                return null;
            }

            return drug;
        }

        //public static T ToEnum<T>(this string value, T defaultValue)
        //{
        //    if (string.IsNullOrEmpty(value))
        //    {
        //        return defaultValue;
        //    }

        //    T result;
        //    return System.Enum.TryParse<T>(value, true, out result) ? result : defaultValue;
        //}
    }
}
