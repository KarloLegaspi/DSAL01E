namespace Form1
{
    partial class create
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
            this.label1 = new System.Windows.Forms.Label();
            this.employeeidTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstnameTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.birthdayTxtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.middlenameTxtbox = new System.Windows.Forms.TextBox();
            this.lastnameTxtbox = new System.Windows.Forms.TextBox();
            this.salutationCombobox = new System.Windows.Forms.ComboBox();
            this.zipTxtbox = new System.Windows.Forms.TextBox();
            this.provinceTxtbox = new System.Windows.Forms.TextBox();
            this.cityTxtbox = new System.Windows.Forms.TextBox();
            this.brgyTxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nationalityTxtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phone_noTxtbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.emailTxtbox = new System.Windows.Forms.TextBox();
            this.jobtitleCombobox = new System.Windows.Forms.ComboBox();
            this.departmentCombobox = new System.Windows.Forms.ComboBox();
            this.statusCombobox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picturpathTxtbox = new System.Windows.Forms.TextBox();
            this.suffixCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee id:";
            // 
            // employeeidTxtbox
            // 
            this.employeeidTxtbox.Location = new System.Drawing.Point(105, 6);
            this.employeeidTxtbox.Name = "employeeidTxtbox";
            this.employeeidTxtbox.Size = new System.Drawing.Size(100, 20);
            this.employeeidTxtbox.TabIndex = 0;
            this.employeeidTxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Name:";
            // 
            // firstnameTxtbox
            // 
            this.firstnameTxtbox.Location = new System.Drawing.Point(105, 32);
            this.firstnameTxtbox.Name = "firstnameTxtbox";
            this.firstnameTxtbox.Size = new System.Drawing.Size(100, 20);
            this.firstnameTxtbox.TabIndex = 3;
            this.firstnameTxtbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address:";
            // 
            // addressTxtbox
            // 
            this.addressTxtbox.Location = new System.Drawing.Point(106, 58);
            this.addressTxtbox.Name = "addressTxtbox";
            this.addressTxtbox.Size = new System.Drawing.Size(354, 20);
            this.addressTxtbox.TabIndex = 5;
            this.addressTxtbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birthday:";
            // 
            // birthdayTxtbox
            // 
            this.birthdayTxtbox.Location = new System.Drawing.Point(106, 110);
            this.birthdayTxtbox.Name = "birthdayTxtbox";
            this.birthdayTxtbox.Size = new System.Drawing.Size(354, 20);
            this.birthdayTxtbox.TabIndex = 9;
            this.birthdayTxtbox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Salutation";
            // 
            // middlenameTxtbox
            // 
            this.middlenameTxtbox.Location = new System.Drawing.Point(211, 32);
            this.middlenameTxtbox.Name = "middlenameTxtbox";
            this.middlenameTxtbox.Size = new System.Drawing.Size(100, 20);
            this.middlenameTxtbox.TabIndex = 12;
            // 
            // lastnameTxtbox
            // 
            this.lastnameTxtbox.Location = new System.Drawing.Point(317, 32);
            this.lastnameTxtbox.Name = "lastnameTxtbox";
            this.lastnameTxtbox.Size = new System.Drawing.Size(100, 20);
            this.lastnameTxtbox.TabIndex = 13;
            // 
            // salutationCombobox
            // 
            this.salutationCombobox.FormattingEnabled = true;
            this.salutationCombobox.Location = new System.Drawing.Point(272, 5);
            this.salutationCombobox.Name = "salutationCombobox";
            this.salutationCombobox.Size = new System.Drawing.Size(189, 21);
            this.salutationCombobox.TabIndex = 15;
            this.salutationCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // zipTxtbox
            // 
            this.zipTxtbox.Location = new System.Drawing.Point(424, 84);
            this.zipTxtbox.Name = "zipTxtbox";
            this.zipTxtbox.Size = new System.Drawing.Size(36, 20);
            this.zipTxtbox.TabIndex = 19;
            // 
            // provinceTxtbox
            // 
            this.provinceTxtbox.Location = new System.Drawing.Point(317, 84);
            this.provinceTxtbox.Name = "provinceTxtbox";
            this.provinceTxtbox.Size = new System.Drawing.Size(100, 20);
            this.provinceTxtbox.TabIndex = 18;
            // 
            // cityTxtbox
            // 
            this.cityTxtbox.Location = new System.Drawing.Point(211, 84);
            this.cityTxtbox.Name = "cityTxtbox";
            this.cityTxtbox.Size = new System.Drawing.Size(100, 20);
            this.cityTxtbox.TabIndex = 17;
            // 
            // brgyTxtbox
            // 
            this.brgyTxtbox.Location = new System.Drawing.Point(105, 84);
            this.brgyTxtbox.Name = "brgyTxtbox";
            this.brgyTxtbox.Size = new System.Drawing.Size(100, 20);
            this.brgyTxtbox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nationality:";
            // 
            // nationalityTxtbox
            // 
            this.nationalityTxtbox.Location = new System.Drawing.Point(106, 136);
            this.nationalityTxtbox.Name = "nationalityTxtbox";
            this.nationalityTxtbox.Size = new System.Drawing.Size(355, 20);
            this.nationalityTxtbox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Contact info:";
            // 
            // phone_noTxtbox
            // 
            this.phone_noTxtbox.Location = new System.Drawing.Point(106, 162);
            this.phone_noTxtbox.Name = "phone_noTxtbox";
            this.phone_noTxtbox.Size = new System.Drawing.Size(205, 20);
            this.phone_noTxtbox.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Job Title:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Department:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Status:";
            // 
            // emailTxtbox
            // 
            this.emailTxtbox.Location = new System.Drawing.Point(317, 162);
            this.emailTxtbox.Name = "emailTxtbox";
            this.emailTxtbox.Size = new System.Drawing.Size(144, 20);
            this.emailTxtbox.TabIndex = 30;
            // 
            // jobtitleCombobox
            // 
            this.jobtitleCombobox.FormattingEnabled = true;
            this.jobtitleCombobox.Location = new System.Drawing.Point(105, 187);
            this.jobtitleCombobox.Name = "jobtitleCombobox";
            this.jobtitleCombobox.Size = new System.Drawing.Size(356, 21);
            this.jobtitleCombobox.TabIndex = 31;
            this.jobtitleCombobox.SelectedIndexChanged += new System.EventHandler(this.jobtitleTxtbox_SelectedIndexChanged);
            // 
            // departmentCombobox
            // 
            this.departmentCombobox.FormattingEnabled = true;
            this.departmentCombobox.Location = new System.Drawing.Point(105, 214);
            this.departmentCombobox.Name = "departmentCombobox";
            this.departmentCombobox.Size = new System.Drawing.Size(356, 21);
            this.departmentCombobox.TabIndex = 32;
            // 
            // statusCombobox
            // 
            this.statusCombobox.FormattingEnabled = true;
            this.statusCombobox.Location = new System.Drawing.Point(105, 241);
            this.statusCombobox.Name = "statusCombobox";
            this.statusCombobox.Size = new System.Drawing.Size(356, 21);
            this.statusCombobox.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(467, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 125);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picturpathTxtbox
            // 
            this.picturpathTxtbox.Location = new System.Drawing.Point(483, 84);
            this.picturpathTxtbox.Name = "picturpathTxtbox";
            this.picturpathTxtbox.Size = new System.Drawing.Size(100, 20);
            this.picturpathTxtbox.TabIndex = 37;
            this.picturpathTxtbox.TextChanged += new System.EventHandler(this.picturpathTxtbox_TextChanged);
            // 
            // suffixCombobox
            // 
            this.suffixCombobox.FormattingEnabled = true;
            this.suffixCombobox.Location = new System.Drawing.Point(423, 32);
            this.suffixCombobox.Name = "suffixCombobox";
            this.suffixCombobox.Size = new System.Drawing.Size(38, 21);
            this.suffixCombobox.TabIndex = 38;
            // 
            // create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.suffixCombobox);
            this.Controls.Add(this.picturpathTxtbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusCombobox);
            this.Controls.Add(this.departmentCombobox);
            this.Controls.Add(this.jobtitleCombobox);
            this.Controls.Add(this.emailTxtbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phone_noTxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nationalityTxtbox);
            this.Controls.Add(this.zipTxtbox);
            this.Controls.Add(this.provinceTxtbox);
            this.Controls.Add(this.cityTxtbox);
            this.Controls.Add(this.brgyTxtbox);
            this.Controls.Add(this.salutationCombobox);
            this.Controls.Add(this.lastnameTxtbox);
            this.Controls.Add(this.middlenameTxtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.birthdayTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressTxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstnameTxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeidTxtbox);
            this.Name = "create";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employeeidTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstnameTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox birthdayTxtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox middlenameTxtbox;
        private System.Windows.Forms.TextBox lastnameTxtbox;
        private System.Windows.Forms.ComboBox salutationCombobox;
        private System.Windows.Forms.TextBox zipTxtbox;
        private System.Windows.Forms.TextBox provinceTxtbox;
        private System.Windows.Forms.TextBox cityTxtbox;
        private System.Windows.Forms.TextBox brgyTxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nationalityTxtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phone_noTxtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox emailTxtbox;
        private System.Windows.Forms.ComboBox jobtitleCombobox;
        private System.Windows.Forms.ComboBox departmentCombobox;
        private System.Windows.Forms.ComboBox statusCombobox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox picturpathTxtbox;
        private System.Windows.Forms.ComboBox suffixCombobox;
    }
}

