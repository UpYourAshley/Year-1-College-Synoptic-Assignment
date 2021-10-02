using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SynopticApplication.Enum;

namespace SynopticApplication
{
    public partial class UserInputsTwo : UserControl
    {
        //Used later on to check for non numerical and numerical values in inputs
        //Private as it only needs to be accessed from this class/file
        private char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public UserInputsTwo()
        {
            InitializeComponent();
        }

        private void UserInputsTwo_Load(object sender, EventArgs e)
        {
            //sets up date and stuff
            for(int x = 1900; x !=2020; x++)
            {
                DOFTYearInputBox.Items.Add(x);
            }

            //Will run through all drug types and add them tothe drop down for 
            //User input
            foreach(var v in System.Enum.GetValues(typeof(DrugClass)))
            {
                //Stores the value with the _ and none alphabetical values
                string preFormat = v.ToString();
                //rempves the charactore '_' whic was used to seperate words
                string formatted = preFormat.Replace('_', ' ');
                
                //Adds the valuesto the user input
                drugTypeInputBox.Items.Add(formatted);
            }

            //Does the same as above but for sideeffects 
            foreach(var x in System.Enum.GetValues(typeof(SideEffect)))
            {
                string sideEffect = x.ToString();

                //Adds to all 3 inputs this time
                sideEffectOneInputBox.Items.Add(x);
                sideEffectTwoInputBox.Items.Add(x);
                sideEffectThreeInputBox.Items.Add(x);
            }

            //Adds the dose option
            doseInputBox.Items.Add("20");
            doseInputBox.Items.Add("30");
            doseInputBox.Items.Add("40");
            doseInputBox.Items.Add("50");
        }

        //Will run upon the selected drug type being changed
        private void drugTypeInputBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Allows the user to now pick a drug name by enablingt that input
            drugNameInputBox.Enabled = true;
            //also clears that input
            drugNameInputBox.Text = string.Empty;
            //Analgesics
            if(drugTypeInputBox.SelectedIndex == 0)
            {
                drugNameInputBox.Items.Clear();

                foreach(Drug d in Program.analgesicsDrugs)
                {
                    drugNameInputBox.Items.Add(d.Name);
                }
            }

            //Anti Hypertensive Drugs
            else if(drugTypeInputBox.SelectedIndex == 1)
            {
                drugNameInputBox.Items.Clear();
                foreach(Drug d in Program.antiHypertensivesDrugs)
                {
                    drugNameInputBox.Items.Add(d.Name);
                }
            }

            //Cholerteroal Lowering Drugs
            else if(drugTypeInputBox.SelectedIndex == 2)
            {
                drugNameInputBox.Items.Clear();
                foreach(Drug d in Program.cholesterolLoweringDrugs)
                {
                    drugNameInputBox.Items.Add(d.Name);
                }
            }

            //Diabetes Drugs
            else if(drugTypeInputBox.SelectedIndex == 3)
            {
                drugNameInputBox.Items.Clear();
                foreach(Drug d in Program.diabetesDrugs)
                {
                    drugNameInputBox.Items.Add(d.Name);
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }


            Program.paitent.DrugTaken = Program.GetDrug(drugNameInputBox.Text);

            //Side effect one
            if(sideEffectOneInputBox.Text == "Diarrhoea")
            {
                Program.paitent.SideEffects[0] = SideEffect.Diarrhoea;
            }
            else if (sideEffectOneInputBox.Text == "Drowsiness")
            {
                Program.paitent.SideEffects[0] = SideEffect.Drowsiness;
            }
            else if(sideEffectOneInputBox.Text == "Flatulence")
            {
                Program.paitent.SideEffects[0] = SideEffect.Flatulence;
            }
            else if (sideEffectOneInputBox.Text == "Headache")
            {
                Program.paitent.SideEffects[0] = SideEffect.Headache;
            }
            else if (sideEffectOneInputBox.Text == "MusclePain")
            {
                Program.paitent.SideEffects[0] = SideEffect.MusclePain;
            }
            else if (sideEffectOneInputBox.Text == "MuscleCramps")
            {
                Program.paitent.SideEffects[0] = SideEffect.MuscleCramps;
            }
            else if (sideEffectOneInputBox.Text == "Nausea")
            {
                Program.paitent.SideEffects[0] = SideEffect.Nausea;
            }
            else if (sideEffectOneInputBox.Text == "StomachCramps")
            {
                Program.paitent.SideEffects[0] = SideEffect.StomachCramps;
            }
            else if (sideEffectOneInputBox.Text == "Vomiting")
            {
                Program.paitent.SideEffects[0] = SideEffect.Vomiting;
            }

            //Side effect two
            if (sideEffectTwoInputBox.Text == "Diarrhoea")
            {
                Program.paitent.SideEffects[1] = SideEffect.Diarrhoea;
            }
            else if (sideEffectTwoInputBox.Text == "Drowsiness")
            {
                Program.paitent.SideEffects[1] = SideEffect.Drowsiness;
            }
            else if (sideEffectTwoInputBox.Text == "Flatulence")
            {
                Program.paitent.SideEffects[1] = SideEffect.Flatulence;
            }
            else if (sideEffectTwoInputBox.Text == "Headache")
            {
                Program.paitent.SideEffects[1] = SideEffect.Headache;
            }
            else if (sideEffectTwoInputBox.Text == "MusclePain")
            {
                Program.paitent.SideEffects[1] = SideEffect.MusclePain;
            }
            else if (sideEffectTwoInputBox.Text == "MuscleCramps")
            {
                Program.paitent.SideEffects[1] = SideEffect.MuscleCramps;
            }
            else if (sideEffectTwoInputBox.Text == "Nausea")
            {
                Program.paitent.SideEffects[1] = SideEffect.Nausea;
            }
            else if (sideEffectTwoInputBox.Text == "StomachCramps")
            {
                Program.paitent.SideEffects[1] = SideEffect.StomachCramps;
            }
            else if (sideEffectTwoInputBox.Text == "Vomiting")
            {
                Program.paitent.SideEffects[1] = SideEffect.Vomiting;
            }

            //Side effect three
            if (sideEffectThreeInputBox.Text == "Diarrhoea")
            {
                Program.paitent.SideEffects[2] = SideEffect.Diarrhoea;
            }
            else if (sideEffectThreeInputBox.Text == "Drowsiness")
            {
                Program.paitent.SideEffects[2] = SideEffect.Drowsiness;
            }
            else if (sideEffectThreeInputBox.Text == "Flatulence")
            {
                Program.paitent.SideEffects[2] = SideEffect.Flatulence;
            }
            else if (sideEffectThreeInputBox.Text == "Headache")
            {
                Program.paitent.SideEffects[2] = SideEffect.Headache;
            }
            else if (sideEffectThreeInputBox.Text == "MusclePain")
            {
                Program.paitent.SideEffects[2] = SideEffect.MusclePain;
            }
            else if (sideEffectThreeInputBox.Text == "MuscleCramps")
            {
                Program.paitent.SideEffects[2] = SideEffect.MuscleCramps;
            }
            else if (sideEffectThreeInputBox.Text == "Nausea")
            {
                Program.paitent.SideEffects[2] = SideEffect.Nausea;
            }
            else if (sideEffectThreeInputBox.Text == "StomachCramps")
            {
                Program.paitent.SideEffects[2] = SideEffect.StomachCramps;
            }
            else if (sideEffectThreeInputBox.Text == "Vomiting")
            {
                Program.paitent.SideEffects[2] = SideEffect.Vomiting;
            }

            Program.paitent.Dose = Convert.ToInt32(doseInputBox.Text);

            Program.paitent.FirtTakenDate = new DateStruct { day = Convert.ToInt32(DOFTDateInputBox.Text), month = Convert.ToInt32(DOFTMonthInputBox.Text), year = Convert.ToInt32(DOFTYearInputBox.Text) };

            //Will run certain code based on the check state
            switch (stillTakingINputBox.CheckState)
            {
                case CheckState.Unchecked:
                    Program.paitent.ContinuedToTake = false;
                    break;
                case CheckState.Checked:
                    Program.paitent.ContinuedToTake = true;
                    break;
                case CheckState.Indeterminate:
                    break;
                default:
                    break;
            }


            

            Program.AddPaitent(Program.paitent);

            MessageBox.Show("Thank you for submitting.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //will ensure that all data is valid and that no erros will happen when values are converted or saved
        private bool ValidateData()
        {
            //Drug Type
            foreach (var v in System.Enum.GetValues(typeof(DrugClass)))
            {
                //Analgesics
                if (drugTypeInputBox.SelectedIndex == 0)
                {
                    break;
                }

                //Anti Hypertensive Drugs
                else if (drugTypeInputBox.SelectedIndex == 1)
                {
                    break;
                }

                //Cholerteroal Lowering Drugs
                else if (drugTypeInputBox.SelectedIndex == 2)
                {
                    break;
                }

                //Diabetes Drugs
                else if (drugTypeInputBox.SelectedIndex == 3)
                {
                    break;
                }

                else
                {
                    drugTypeInputBox.BackColor = Color.Red;
                    MessageBox.Show("Select a valid drug tpye.", "Invalid Inputs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    drugTypeInputBox.BackColor = Color.White;
                    return false;
                }
            }

            //Drug
            if(drugNameInputBox.Text == null || drugNameInputBox.Text == string.Empty)
            {
                drugNameInputBox.BackColor = Color.Red;
                MessageBox.Show("You must pick a drug.", "Invalid Inputs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                drugNameInputBox.BackColor = Color.White;
                return false;
            }

            bool isDrugValid = false;
            foreach(Drug d in Program.allDrugs)
            {
                if (drugNameInputBox.Text == d.Name)
                {
                    isDrugValid = true;
                    break;
                }
            }

            if (!isDrugValid)
            {
                drugNameInputBox.BackColor = Color.Red;
                MessageBox.Show("Pick a valid drug.", "Invalid Inputs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                drugNameInputBox.BackColor = Color.White;
                return false;
            }

            //sideeffects
            if(sideEffectOneInputBox.Text == null || sideEffectOneInputBox.Text == string.Empty)
            {
                sideEffectOneInputBox.BackColor = Color.Red;
                MessageBox.Show("You must select at least one side-effect.", "Invalid Inputs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sideEffectOneInputBox.BackColor = Color.White;
                return false;
            }



            bool isSideEffectOneValid = false;
            foreach (var x in System.Enum.GetValues(typeof(SideEffect)))
            {
                string sideEffect = x.ToString();

                if(sideEffectOneInputBox.Text == sideEffect)
                {
                    isSideEffectOneValid = true;
                    break;
                }
            }

            if (!isSideEffectOneValid)
            {
                sideEffectOneInputBox.BackColor = Color.Red;
                MessageBox.Show("Pick one of the listed sideeffects.", "Invalid Inputs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sideEffectOneInputBox.BackColor = Color.White;
                return false;
            }

            //drug dose 
            if(doseInputBox.Text == null || doseInputBox.Text == string.Empty)
            {
                doseInputBox.BackColor = Color.Red;
                MessageBox.Show("You must select a dose ammoun.", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                doseInputBox.BackColor = Color.White;
                return false;
            }

            //Date of first taking
            if(DOFTDateInputBox.Text == null || DOFTDateInputBox.Text == string.Empty)
            {
                DOFTDateInputBox.BackColor = Color.Red;
                MessageBox.Show("Invalid Date given.", "Invalid Inputs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DOFTDateInputBox.BackColor = Color.White;
                return false; 
            }
            foreach(char c in DOFTDateInputBox.Text)
            {
                if (!numbers.Contains<char>(c))
                {
                    DOFTDateInputBox.BackColor = Color.Red;
                    MessageBox.Show("Only numbers are valid.", "Invalid Inputs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DOFTDateInputBox.BackColor = Color.White;
                    return false;
                }
            }

            if (DOFTMonthInputBox.Text == null || DOFTMonthInputBox.Text == string.Empty)
            {
                DOFTMonthInputBox.BackColor = Color.Red;
                MessageBox.Show("Invalid Date given.", "Invalid Inputs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DOFTMonthInputBox.BackColor = Color.White;
                return false;
            }
            foreach (char c in DOFTMonthInputBox.Text)
            {
                if (!numbers.Contains<char>(c))
                {
                    DOFTMonthInputBox.BackColor = Color.Red;
                    MessageBox.Show("Only numbers are valid.", "Invalid Inputs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DOFTMonthInputBox.BackColor = Color.White;
                    return false;
                }
            }

            if (DOFTYearInputBox.Text == null || DOFTYearInputBox.Text == string.Empty)
            {
                DOFTYearInputBox.BackColor = Color.Red;
                MessageBox.Show("Invalid Date given.", "Invalid Inputs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DOFTYearInputBox.BackColor = Color.White;
                return false;
            }
            foreach (char c in DOFTYearInputBox.Text)
            {
                if (!numbers.Contains<char>(c))
                {
                    DOFTYearInputBox.BackColor = Color.Red;
                    MessageBox.Show("Only numbers are valid.", "Invalid Inputs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DOFTYearInputBox.BackColor = Color.White;
                    return false;
                }
            }

            return true;
        }

        private void doseLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
