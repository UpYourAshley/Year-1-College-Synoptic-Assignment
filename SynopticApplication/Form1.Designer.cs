namespace SynopticApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topBar = new System.Windows.Forms.Panel();
            this.showingIndicator = new System.Windows.Forms.Panel();
            this.finishButton = new System.Windows.Forms.Button();
            this.infoTwoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.staffLogin1 = new SynopticApplication.StaffLogin();
            this.userInputsOne1 = new SynopticApplication.UserInputsOne();
            this.userInputsTwo1 = new SynopticApplication.UserInputsTwo();
            this.userData1 = new SynopticApplication.UserData();
            this.topBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.topBar.Controls.Add(this.showingIndicator);
            this.topBar.Controls.Add(this.finishButton);
            this.topBar.Controls.Add(this.infoTwoButton);
            this.topBar.Controls.Add(this.button1);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(300, 55);
            this.topBar.TabIndex = 0;
            // 
            // showingIndicator
            // 
            this.showingIndicator.BackColor = System.Drawing.Color.Fuchsia;
            this.showingIndicator.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.showingIndicator.Location = new System.Drawing.Point(12, 12);
            this.showingIndicator.Name = "showingIndicator";
            this.showingIndicator.Size = new System.Drawing.Size(77, 5);
            this.showingIndicator.TabIndex = 1;
            // 
            // finishButton
            // 
            this.finishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.ForeColor = System.Drawing.Color.White;
            this.finishButton.Location = new System.Drawing.Point(211, 12);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(77, 33);
            this.finishButton.TabIndex = 0;
            this.finishButton.Text = "Staff";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // infoTwoButton
            // 
            this.infoTwoButton.Enabled = false;
            this.infoTwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoTwoButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTwoButton.ForeColor = System.Drawing.Color.White;
            this.infoTwoButton.Location = new System.Drawing.Point(112, 12);
            this.infoTwoButton.Name = "infoTwoButton";
            this.infoTwoButton.Size = new System.Drawing.Size(77, 33);
            this.infoTwoButton.TabIndex = 0;
            this.infoTwoButton.Text = "Info 2";
            this.infoTwoButton.UseVisualStyleBackColor = true;
            this.infoTwoButton.Click += new System.EventHandler(this.infoTwoButton_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Info 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // staffLogin1
            // 
            this.staffLogin1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLogin1.Location = new System.Drawing.Point(0, 61);
            this.staffLogin1.Name = "staffLogin1";
            this.staffLogin1.Size = new System.Drawing.Size(300, 521);
            this.staffLogin1.TabIndex = 3;
            // 
            // userInputsOne1
            // 
            this.userInputsOne1.Location = new System.Drawing.Point(0, 61);
            this.userInputsOne1.Name = "userInputsOne1";
            this.userInputsOne1.Size = new System.Drawing.Size(300, 490);
            this.userInputsOne1.TabIndex = 2;
            // 
            // userInputsTwo1
            // 
            this.userInputsTwo1.Location = new System.Drawing.Point(0, 61);
            this.userInputsTwo1.Name = "userInputsTwo1";
            this.userInputsTwo1.Size = new System.Drawing.Size(300, 490);
            this.userInputsTwo1.TabIndex = 1;
            // 
            // userData1
            // 
            this.userData1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userData1.Location = new System.Drawing.Point(0, 61);
            this.userData1.Name = "userData1";
            this.userData1.Size = new System.Drawing.Size(300, 521);
            this.userData1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(300, 550);
            this.Controls.Add(this.userData1);
            this.Controls.Add(this.staffLogin1);
            this.Controls.Add(this.userInputsOne1);
            this.Controls.Add(this.userInputsTwo1);
            this.Controls.Add(this.topBar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button infoTwoButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel showingIndicator;
        private UserInputsTwo userInputsTwo1;
        private UserInputsOne userInputsOne1;
        private StaffLogin staffLogin1;
        private UserData userData1;
    }
}

