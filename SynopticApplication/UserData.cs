using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynopticApplication
{
    public partial class UserData : UserControl
    {
        public UserData()
        {
            InitializeComponent();
        }

        private void UserData_Load(object sender, EventArgs e)
        {
            string info = "";
            foreach (Paitent p in Program.AllPaitents)
            {
                string effect1  = "Not Provided";
                string effect2= "Not Provided";
                string effect3= "Not Provided";

                //Getting effect1
                try
                {

                    switch (p.SideEffects[0])
                    {
                        case Enum.SideEffect.Diarrhoea:
                            effect1 = "Diarrhoea";
                            break;
                        case Enum.SideEffect.Drowsiness:
                            effect1 = "Drowsiness";
                            break;
                        case Enum.SideEffect.Flatulence:
                            effect1 = "Flatulence";
                            break;
                        case Enum.SideEffect.Headache:
                            effect1 = "Headache";
                            break;
                        case Enum.SideEffect.MusclePain:
                            effect1 = "MusclePain";
                            break;
                        case Enum.SideEffect.MuscleCramps:
                            effect1 = "MuscleCramps";
                            break;
                        case Enum.SideEffect.Nausea:
                            effect1 = "Nausea";
                            break;
                        case Enum.SideEffect.StomachCramps:
                            effect1 = "StomachCramps";
                            break;
                        case Enum.SideEffect.Vomiting:
                            effect1 = "Vomiting";
                            break;
                        case Enum.SideEffect.Other:
                            effect1 = "Other";
                            break;
                        default:
                            break;
                    }
                }
                catch
                {

                }

                try
                {

                    //Getting effect2
                    switch (p.SideEffects[1])
                    {
                        case Enum.SideEffect.Diarrhoea:
                            effect2 = "Diarrhoea";
                            break;
                        case Enum.SideEffect.Drowsiness:
                            effect2 = "Drowsiness";
                            break;
                        case Enum.SideEffect.Flatulence:
                            effect2 = "Flatulence";
                            break;
                        case Enum.SideEffect.Headache:
                            effect2 = "Headache";
                            break;
                        case Enum.SideEffect.MusclePain:
                            effect2 = "MusclePain";
                            break;
                        case Enum.SideEffect.MuscleCramps:
                            effect2 = "MuscleCramps";
                            break;
                        case Enum.SideEffect.Nausea:
                            effect2 = "Nausea";
                            break;
                        case Enum.SideEffect.StomachCramps:
                            effect2 = "StomachCramps";
                            break;
                        case Enum.SideEffect.Vomiting:
                            effect2 = "Vomiting";
                            break;
                        case Enum.SideEffect.Other:
                            effect2 = "Other";
                            break;
                        default:
                            break;
                    }
                }
                catch
                {

                }

                try
                {

                    //Getting effect3
                    switch (p.SideEffects[2])
                    {
                        case Enum.SideEffect.Diarrhoea:
                            effect3 = "Diarrhoea";
                            break;
                        case Enum.SideEffect.Drowsiness:
                            effect3 = "Drowsiness";
                            break;
                        case Enum.SideEffect.Flatulence:
                            effect3 = "Flatulence";
                            break;
                        case Enum.SideEffect.Headache:
                            effect3 = "Headache";
                            break;
                        case Enum.SideEffect.MusclePain:
                            effect3 = "MusclePain";
                            break;
                        case Enum.SideEffect.MuscleCramps:
                            effect3 = "MuscleCramps";
                            break;
                        case Enum.SideEffect.Nausea:
                            effect3 = "Nausea";
                            break;
                        case Enum.SideEffect.StomachCramps:
                            effect3 = "StomachCramps";
                            break;
                        case Enum.SideEffect.Vomiting:
                            effect3 = "Vomiting";
                            break;
                        case Enum.SideEffect.Other:
                            effect3 = "Other";
                            break;
                        default:
                            break;
                    }
                }
                catch
                {

                }


                info = info + $"\r\n \r\nName: {p.Name}" +
                    $"\r\nPhone Number: {p.PhoneNumber}" +
                    $"\r\nDate of Birth: {p.DOB.day}/{p.DOB.month}/{p.DOB.year}" +
                    $"\r\nAddress Line One: {p.Address.addressLineOne}" +
                    $"\r\nAddress Line Two: {p.Address.addressLineTwo}" +
                    $"\r\nAddress Line Three: {p.Address.addressLineThree}" +
                    $"\r\nPostCode: {p.PostCode}" +
                    $"\r\nNHS Number: {p.NHSNumber}" +
                    $"\r\nDrug Type: = {p.DrugTaken.Class.ToString()}" +
                    $"\r\nDrug Name: {p.DrugTaken.Name}" +
                    $"\r\nSide Effect One: {effect1}" +
                    $"\r\nSide Effect Two: {effect2}" +
                    $"\r\nSide Effect Three: {effect3}" +
                    $"\r\nDose (MG): {p.Dose}" +
                    $"\r\nDate of Firt Taking: {p.FirtTakenDate.day}/{p.FirtTakenDate.month}/{p.FirtTakenDate.year}" +
                    $"\r\nStill Taking: {p.ContinuedToTake.ToString()}";

                richTextBox1.Text = String.Join(richTextBox1.Text, info);
            }
        }

        private void dataTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
