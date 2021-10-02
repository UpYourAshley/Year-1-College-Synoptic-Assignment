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
    public partial class StaffLogin : UserControl
    {

        private Dictionary<string, string> logInValues = new Dictionary<string, string>();

        public StaffLogin()
        {
            InitializeComponent();
            logInValues.Add("TempLogin1", "TempPassword1"); //Obviously I wouldnt store login information in code ofc cos thats dumb for security 
        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                return;
            }

            if (!logInValues.ContainsKey(usernameInputBox.Text))
            {
                usernameInputBox.BackColor = Color.Red;
                MessageBox.Show("Invalid Username.", "Invalid Inputs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameInputBox.BackColor = Color.White;
                return;
            }
            else
            {
                string password = logInValues[usernameInputBox.Text].ToString();
                if(!(password == passwordInpitBox.Text))
                {
                    passwordInpitBox.BackColor = Color.Red;
                    MessageBox.Show("Incorrect Password.", "Invalid Inputs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordInpitBox.BackColor = Color.White;
                    return;
                }
                else
                {
                    //Has logged in.
                    Form1.Instance.UserData.BringToFront();
                }
            }
        }

        private bool ValidateData()
        {
            if(usernameInputBox.Text == null || usernameInputBox.Text == string.Empty)
            {
                usernameInputBox.BackColor = Color.Red;
                MessageBox.Show("Please entter a username.", "Invalid Inputs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameInputBox.BackColor = Color.Red;
                return false;
            }

            if(passwordInpitBox.Text == null || passwordInpitBox.Text == string.Empty)
            {
                passwordInpitBox.BackColor = Color.Red;
                MessageBox.Show("Enter a password.", "Invalid Inputs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordInpitBox.BackColor = Color.White;
                return false;
            }

            return true;
        }
    }
}
