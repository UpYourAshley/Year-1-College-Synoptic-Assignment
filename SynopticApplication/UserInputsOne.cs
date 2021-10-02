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
    public partial class UserInputsOne : UserControl
    {
        //Used to check user inputs later on
        //only visable to methods within this class as it is private
        private char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public UserInputsOne()
        {
            InitializeComponent();
        }


        private void UserInputsOne_Load(object sender, EventArgs e)
        {
            for(int i = 1900; i != 2019; i++)
            {
                DOBYearUserInput.Items.Add(i);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dontButton_Click(object sender, EventArgs e)
        {
            //Calls ValidateData to check if the data is valid
            bool dataValid = ValidateData();
            //Checks the return value
            if (!dataValid)
            {
                //if the data was not valid it will return out of the method and will not continue 
                
                return;
            }
           
            //Sets the values of the paitent to the inputed values 
            Program.paitent.Name = nameInputBox.Text;
            Program.paitent.PostCode = postcodeInputBox.Text;

            Program.paitent.DOB = new DateStruct
            {
                day = Convert.ToInt16(DOBDateUserInput.Text),
                month = Convert.ToInt16(DOBMonthUserInput.Text),
                year = Convert.ToInt16(DOBYearUserInput.Text)
            };

            Program.paitent.Address = new Address
            {
                addressLineOne = textBox4.Text,
                addressLineTwo = addressL2InputBox.Text,
                addressLineThree = addressL3InputBox.Text,
                postcode = postcodeInputBox.Text
            };

            Program.paitent.PhoneNumber = Convert.ToInt64(phoneNumberInputBox.Text);
            Program.paitent.NHSNumber = Convert.ToInt32(nhsNumberInputBox.Text);

            //Enables the middle button on the top part of the form UI 
            Form1.Instance.InfoTwoButton.Enabled = true;
            //Calls the method on the form that will switch what UI and inputs are being shown to the user
            Form1.Instance.SwitchToInfoTwo();
        }

        /// <summary>
        /// Used to validate all inputs for this section
        /// If any data is invalid it returns null
        /// </summary>
        /// <returns>Retuns a bool depending on if any of the data is invalid or if all data is valid</returns>
        private bool ValidateData()
        {
            if (nameInputBox.Text == null || nameInputBox.Text == string.Empty)
            {
                nameInputBox.BackColor = Color.Red;
                MessageBox.Show("Name can not be left empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameInputBox.BackColor = Color.White;
                return false;
            }

            if(phoneNumberInputBox.Text == string.Empty || phoneNumberInputBox.Text == null)
            {
                phoneNumberInputBox.BackColor = Color.Red;
                MessageBox.Show("Phone number can not be left empty!", "Invalid Inputs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneNumberInputBox.BackColor = Color.White;
                return false;
            }

            #region Date Of Birth
            foreach (char c in DOBDateUserInput.Text)
            {
                //Checks if its not a number
                if (!numbers.Contains<char>(c))
                {
                    DOBDateUserInput.BackColor = Color.Red;
                    MessageBox.Show("Only numbers are valid", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DOBDateUserInput.BackColor = Color.White;
                    return false;
                }
            }

            foreach (char c in DOBMonthUserInput.Text)
            {
                if (!numbers.Contains<char>(c))
                {
                    DOBMonthUserInput.BackColor = Color.Red;
                    MessageBox.Show("Only numbers are valid", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DOBMonthUserInput.BackColor = Color.White;
                    return false;
                }
            }

            foreach (char c in DOBYearUserInput.Text)
            {
                if (!numbers.Contains<char>(c))
                {
                    DOBYearUserInput.BackColor = Color.Red;
                    MessageBox.Show("Only numbers are valid", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DOBYearUserInput.BackColor = Color.White;
                    return false;
                }
            }
            #endregion

            #region Address 
            if (postcodeInputBox.Text == null || postcodeInputBox.Text == string.Empty)
            {
                postcodeInputBox.BackColor = Color.Red;
                MessageBox.Show("Postcode must be filled out.", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                postcodeInputBox.BackColor = Color.White;
                return false;
            }

            if (textBox4.Text == null || textBox4.Text == string.Empty)
            {
                textBox4.BackColor = Color.Red;
                MessageBox.Show("Address line one must be filled out.", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.BackColor = Color.White;
                return false;
            }
            #endregion

            if (nhsNumberInputBox.Text == null || nhsNumberInputBox.Text == string.Empty)
            {
                nhsNumberInputBox.BackColor = Color.Red;
                MessageBox.Show("NHS number can not be left empty.", "Invalid Inputs.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nhsNumberInputBox.BackColor = Color.White;
                return false;
            }

            if(nhsNumberInputBox.Text.Length != 9)
            {
                nhsNumberInputBox.BackColor = Color.Red;
                MessageBox.Show("NHS number is 9 digits long.", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nhsNumberInputBox.BackColor = Color.White;
                return false;
            }

            foreach (char c in nhsNumberInputBox.Text)
            {
                if (!numbers.Contains<char>(c))
                {
                    nhsNumberInputBox.BackColor = Color.Red;
                    MessageBox.Show("Only Numbers are valid.", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nhsNumberInputBox.BackColor = Color.White;
                    return false;
                    if (Char.IsNumber(c))
                    {

                    }
                }
            }

            return true;
        }

        private void phoneNumberInputBox_TextChanged(object sender, EventArgs e)
        {
            foreach(char c in phoneNumberInputBox.Text)
            {
                if (!numbers.Contains<char>(c))
                {
                    phoneNumberInputBox.BackColor = Color.Red;
                    MessageBox.Show("Only Numbers are vali!", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    phoneNumberInputBox.BackColor = Color.White;
                    phoneNumberInputBox.Text = null;
                    return;
                }
            }
        }
    }
}
