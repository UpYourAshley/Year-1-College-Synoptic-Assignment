using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynopticApplication
{
    public partial class Form1 : Form
    {
        static Form1 obj;

        public static Form1 Instance
        {
            get
            {
                if(obj == null)
                {
                    obj = new Form1();
                }
                return obj; 
            }
        }

        public Button InfoTwoButton
        {
            get
            {
                return infoTwoButton;
            }
        }

        public UserControl InfoOne
        {
            get
            {
                return userInputsOne1;
            }
        }

        public UserControl InfoTwo
        {
            get
            {
                return userInputsTwo1;
            }
        }

        public UserData UserData
        {
            get
            {
                return userData1;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void SwitchToInfoOne()
        {
            showingIndicator.Width = button1.Width;
            showingIndicator.Left = button1.Left;
            userInputsOne1.BringToFront();
        }

        public void SwitchToInfoTwo()
        {
            showingIndicator.Width = infoTwoButton.Width;
            showingIndicator.Left = infoTwoButton.Left;
            userInputsTwo1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obj = this;
            topBar.Width = button1.Width;
            userInputsOne1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showingIndicator.Width = button1.Width;
            showingIndicator.Left = button1.Left;
            userInputsOne1.BringToFront();
        }

        private void infoTwoButton_Click(object sender, EventArgs e)
        {
            showingIndicator.Width = infoTwoButton.Width;
            showingIndicator.Left = infoTwoButton.Left;
            userInputsTwo1.BringToFront();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            showingIndicator.Width = finishButton.Width;
            showingIndicator.Left = finishButton.Left;
            staffLogin1.BringToFront();
        }
    }
}
