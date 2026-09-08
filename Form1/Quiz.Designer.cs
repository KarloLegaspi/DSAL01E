using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Form1
{
    partial class Quiz
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ClearScheduleOfCourses = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_clrstudentinfo = new System.Windows.Forms.Button();
            this.btn_CalculateFees = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbox_totalcreditunit = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CU7 = new System.Windows.Forms.TextBox();
            this.CU6 = new System.Windows.Forms.TextBox();
            this.CU5 = new System.Windows.Forms.TextBox();
            this.CU4 = new System.Windows.Forms.TextBox();
            this.CU3 = new System.Windows.Forms.TextBox();
            this.CU2 = new System.Windows.Forms.TextBox();
            this.CU1 = new System.Windows.Forms.TextBox();
            this.Room7 = new System.Windows.Forms.TextBox();
            this.Day7 = new System.Windows.Forms.TextBox();
            this.Time7 = new System.Windows.Forms.TextBox();
            this.LabU7 = new System.Windows.Forms.TextBox();
            this.LecU7 = new System.Windows.Forms.TextBox();
            this.Desc7 = new System.Windows.Forms.TextBox();
            this.Sec7 = new System.Windows.Forms.TextBox();
            this.CC7 = new System.Windows.Forms.TextBox();
            this.Room6 = new System.Windows.Forms.TextBox();
            this.Day6 = new System.Windows.Forms.TextBox();
            this.Time6 = new System.Windows.Forms.TextBox();
            this.LabU6 = new System.Windows.Forms.TextBox();
            this.LecU6 = new System.Windows.Forms.TextBox();
            this.Desc6 = new System.Windows.Forms.TextBox();
            this.Sec6 = new System.Windows.Forms.TextBox();
            this.CC6 = new System.Windows.Forms.TextBox();
            this.Room5 = new System.Windows.Forms.TextBox();
            this.Day5 = new System.Windows.Forms.TextBox();
            this.Time5 = new System.Windows.Forms.TextBox();
            this.LabU5 = new System.Windows.Forms.TextBox();
            this.LecU5 = new System.Windows.Forms.TextBox();
            this.Desc5 = new System.Windows.Forms.TextBox();
            this.Sec5 = new System.Windows.Forms.TextBox();
            this.CC5 = new System.Windows.Forms.TextBox();
            this.Room4 = new System.Windows.Forms.TextBox();
            this.Day4 = new System.Windows.Forms.TextBox();
            this.Time4 = new System.Windows.Forms.TextBox();
            this.LabU4 = new System.Windows.Forms.TextBox();
            this.LecU4 = new System.Windows.Forms.TextBox();
            this.Desc4 = new System.Windows.Forms.TextBox();
            this.Sec4 = new System.Windows.Forms.TextBox();
            this.CC4 = new System.Windows.Forms.TextBox();
            this.Room3 = new System.Windows.Forms.TextBox();
            this.Day3 = new System.Windows.Forms.TextBox();
            this.Time3 = new System.Windows.Forms.TextBox();
            this.LabU3 = new System.Windows.Forms.TextBox();
            this.LecU3 = new System.Windows.Forms.TextBox();
            this.Desc3 = new System.Windows.Forms.TextBox();
            this.Sec3 = new System.Windows.Forms.TextBox();
            this.CC3 = new System.Windows.Forms.TextBox();
            this.Room2 = new System.Windows.Forms.TextBox();
            this.Day2 = new System.Windows.Forms.TextBox();
            this.Time2 = new System.Windows.Forms.TextBox();
            this.LabU2 = new System.Windows.Forms.TextBox();
            this.LecU2 = new System.Windows.Forms.TextBox();
            this.Desc2 = new System.Windows.Forms.TextBox();
            this.Sec2 = new System.Windows.Forms.TextBox();
            this.CC2 = new System.Windows.Forms.TextBox();
            this.Room1 = new System.Windows.Forms.TextBox();
            this.Day1 = new System.Windows.Forms.TextBox();
            this.Time1 = new System.Windows.Forms.TextBox();
            this.LabU1 = new System.Windows.Forms.TextBox();
            this.LecU1 = new System.Windows.Forms.TextBox();
            this.Desc1 = new System.Windows.Forms.TextBox();
            this.Sec1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.CC1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StudMode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StudScholar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StudYearLevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StudNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StudDateEnrolled = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.StudProgram = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ClearScheduleOfCourses);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btn_clrstudentinfo);
            this.groupBox1.Controls.Add(this.btn_CalculateFees);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.StudMode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.StudScholar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.StudYearLevel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.StudNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.StudDateEnrolled);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.StudProgram);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StudName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 691);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_ClearScheduleOfCourses
            // 
            this.btn_ClearScheduleOfCourses.Location = new System.Drawing.Point(152, 653);
            this.btn_ClearScheduleOfCourses.Name = "btn_ClearScheduleOfCourses";
            this.btn_ClearScheduleOfCourses.Size = new System.Drawing.Size(148, 33);
            this.btn_ClearScheduleOfCourses.TabIndex = 36;
            this.btn_ClearScheduleOfCourses.Text = "CLEAR SCHEDULE OF COURSES";
            this.btn_ClearScheduleOfCourses.UseVisualStyleBackColor = true;
            this.btn_ClearScheduleOfCourses.Click += new System.EventHandler(this.btn_ClearScheduleOfCourses_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(36, 653);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 33);
            this.button4.TabIndex = 35;
            this.button4.Text = "EXIT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // btn_clrstudentinfo
            // 
            this.btn_clrstudentinfo.Location = new System.Drawing.Point(152, 615);
            this.btn_clrstudentinfo.Name = "btn_clrstudentinfo";
            this.btn_clrstudentinfo.Size = new System.Drawing.Size(148, 33);
            this.btn_clrstudentinfo.TabIndex = 34;
            this.btn_clrstudentinfo.Text = "CLEAR STUDENT INFORMATION";
            this.btn_clrstudentinfo.UseVisualStyleBackColor = true;
            this.btn_clrstudentinfo.Click += new System.EventHandler(this.btn_clrstudentinfo_Click_1);
            // 
            // btn_CalculateFees
            // 
            this.btn_CalculateFees.Location = new System.Drawing.Point(36, 615);
            this.btn_CalculateFees.Name = "btn_CalculateFees";
            this.btn_CalculateFees.Size = new System.Drawing.Size(111, 33);
            this.btn_CalculateFees.TabIndex = 33;
            this.btn_CalculateFees.Text = "COMPUTE FEES";
            this.btn_CalculateFees.UseVisualStyleBackColor = true;
            this.btn_CalculateFees.Click += new System.EventHandler(this.btn_CalculateFees_Click_2);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox17);
            this.groupBox6.Controls.Add(this.textBox18);
            this.groupBox6.Controls.Add(this.label41);
            this.groupBox6.Controls.Add(this.textBox19);
            this.groupBox6.Controls.Add(this.label40);
            this.groupBox6.Controls.Add(this.label36);
            this.groupBox6.Location = new System.Drawing.Point(322, 591);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(355, 87);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(124, 37);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(226, 20);
            this.textBox17.TabIndex = 59;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(124, 12);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(226, 20);
            this.textBox18.TabIndex = 57;
            this.textBox18.TextChanged += new System.EventHandler(this.textBox18_TextChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(32, 40);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(87, 13);
            this.label41.TabIndex = 58;
            this.label41.Text = "GRAND TOTAL:";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(124, 62);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(226, 20);
            this.textBox19.TabIndex = 61;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(57, 64);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(52, 13);
            this.label40.TabIndex = 60;
            this.label40.Text = "Discount:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(32, 15);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(83, 13);
            this.label36.TabIndex = 56;
            this.label36.Text = "AMOUNT DUE:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox15);
            this.groupBox5.Controls.Add(this.textBox16);
            this.groupBox5.Controls.Add(this.textBox10);
            this.groupBox5.Controls.Add(this.label37);
            this.groupBox5.Controls.Add(this.label38);
            this.groupBox5.Controls.Add(this.label39);
            this.groupBox5.Controls.Add(this.textBox11);
            this.groupBox5.Controls.Add(this.textBox13);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.textBox14);
            this.groupBox5.Controls.Add(this.textBox12);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.label34);
            this.groupBox5.Location = new System.Drawing.Point(322, 388);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(355, 198);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(189, 144);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(161, 20);
            this.textBox15.TabIndex = 53;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(189, 119);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(161, 20);
            this.textBox16.TabIndex = 51;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(189, 168);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(161, 20);
            this.textBox10.TabIndex = 55;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(76, 121);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(77, 13);
            this.label37.TabIndex = 50;
            this.label37.Text = "1st Installment:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(76, 171);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(78, 13);
            this.label38.TabIndex = 54;
            this.label38.Text = "3rd Installment:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(76, 146);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(81, 13);
            this.label39.TabIndex = 52;
            this.label39.Text = "2nd Installment:";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(189, 89);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(161, 20);
            this.textBox11.TabIndex = 49;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(189, 40);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(161, 20);
            this.textBox13.TabIndex = 45;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(76, 92);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(78, 13);
            this.label32.TabIndex = 48;
            this.label32.Text = "Downpayment:";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(189, 15);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(161, 20);
            this.textBox14.TabIndex = 43;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(189, 64);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(161, 20);
            this.textBox12.TabIndex = 47;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(20, 17);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(148, 13);
            this.label35.TabIndex = 42;
            this.label35.Text = "TOTAL TUITION AND FEES:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(53, 67);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(97, 13);
            this.label33.TabIndex = 46;
            this.label33.Text = "Installment Charge:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(53, 42);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(93, 13);
            this.label34.TabIndex = 44;
            this.label34.Text = "Mode of Payment:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.label42);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Location = new System.Drawing.Point(14, 465);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(303, 145);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Other School Fees:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(110, 116);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(189, 20);
            this.textBox9.TabIndex = 43;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(22, 119);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(75, 13);
            this.label42.TabIndex = 42;
            this.label42.Text = "Total Oth Fee:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(138, 91);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(161, 20);
            this.textBox7.TabIndex = 41;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(44, 94);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(96, 13);
            this.label30.TabIndex = 40;
            this.label30.Text = "Exam Booklet Fee:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(138, 66);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(161, 20);
            this.textBox8.TabIndex = 39;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(44, 68);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(84, 13);
            this.label31.TabIndex = 38;
            this.label31.Text = "CISCO Lab Fee:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(138, 42);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(161, 20);
            this.textBox5.TabIndex = 37;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(44, 44);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(52, 13);
            this.label28.TabIndex = 36;
            this.label28.Text = "SAP Fee:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(44, 19);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(73, 13);
            this.label29.TabIndex = 34;
            this.label29.Text = "Com Lab Fee:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(138, 16);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(161, 20);
            this.textBox6.TabIndex = 35;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Location = new System.Drawing.Point(14, 388);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 72);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(138, 44);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 20);
            this.textBox4.TabIndex = 33;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(22, 47);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(103, 13);
            this.label27.TabIndex = 32;
            this.label27.Text = "Miscellaneous Fees:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 20);
            this.textBox3.TabIndex = 31;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(22, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 13);
            this.label26.TabIndex = 30;
            this.label26.Text = "Total Tuition Fee:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbox_totalcreditunit);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(5, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 285);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schedule of Course(s)";
            // 
            // txtbox_totalcreditunit
            // 
            this.txtbox_totalcreditunit.Location = new System.Drawing.Point(392, 261);
            this.txtbox_totalcreditunit.Name = "txtbox_totalcreditunit";
            this.txtbox_totalcreditunit.Size = new System.Drawing.Size(57, 20);
            this.txtbox_totalcreditunit.TabIndex = 30;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(307, 263);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(86, 13);
            this.label25.TabIndex = 29;
            this.label25.Text = "Total Cred Units:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.Controls.Add(this.CU7, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.CU6, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.CU5, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.CU4, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.CU3, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.CU2, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.CU1, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.Room7, 9, 7);
            this.tableLayoutPanel1.Controls.Add(this.Day7, 8, 7);
            this.tableLayoutPanel1.Controls.Add(this.Time7, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.LabU7, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.LecU7, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.Desc7, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.Sec7, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.CC7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.Room6, 9, 6);
            this.tableLayoutPanel1.Controls.Add(this.Day6, 8, 6);
            this.tableLayoutPanel1.Controls.Add(this.Time6, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.LabU6, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.LecU6, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.Desc6, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.Sec6, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.CC6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Room5, 9, 5);
            this.tableLayoutPanel1.Controls.Add(this.Day5, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.Time5, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.LabU5, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.LecU5, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.Desc5, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.Sec5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.CC5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Room4, 9, 4);
            this.tableLayoutPanel1.Controls.Add(this.Day4, 8, 4);
            this.tableLayoutPanel1.Controls.Add(this.Time4, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.LabU4, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.LecU4, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.Desc4, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Sec4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.CC4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Room3, 9, 3);
            this.tableLayoutPanel1.Controls.Add(this.Day3, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.Time3, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.LabU3, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.LecU3, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.Desc3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Sec3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.CC3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Room2, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.Day2, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.Time2, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabU2, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.LecU2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.Desc2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Sec2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.CC2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Room1, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.Day1, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.Time1, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabU1, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.LecU1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Desc1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Sec1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label17, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.label16, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.label15, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label24, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.CC1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 237);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CU7
            // 
            this.CU7.Location = new System.Drawing.Point(387, 207);
            this.CU7.Name = "CU7";
            this.CU7.Size = new System.Drawing.Size(48, 20);
            this.CU7.TabIndex = 114;
            this.CU7.TextChanged += new System.EventHandler(this.CU7_TextChanged_1);
            // 
            // CU6
            // 
            this.CU6.Location = new System.Drawing.Point(387, 178);
            this.CU6.Name = "CU6";
            this.CU6.Size = new System.Drawing.Size(48, 20);
            this.CU6.TabIndex = 113;
            this.CU6.TextChanged += new System.EventHandler(this.CU6_TextChanged_1);
            // 
            // CU5
            // 
            this.CU5.Location = new System.Drawing.Point(387, 149);
            this.CU5.Name = "CU5";
            this.CU5.Size = new System.Drawing.Size(48, 20);
            this.CU5.TabIndex = 112;
            this.CU5.TextChanged += new System.EventHandler(this.CU5_TextChanged_1);
            // 
            // CU4
            // 
            this.CU4.Location = new System.Drawing.Point(387, 120);
            this.CU4.Name = "CU4";
            this.CU4.Size = new System.Drawing.Size(48, 20);
            this.CU4.TabIndex = 111;
            this.CU4.TextChanged += new System.EventHandler(this.CU4_TextChanged_1);
            // 
            // CU3
            // 
            this.CU3.Location = new System.Drawing.Point(387, 91);
            this.CU3.Name = "CU3";
            this.CU3.Size = new System.Drawing.Size(48, 20);
            this.CU3.TabIndex = 110;
            this.CU3.TextChanged += new System.EventHandler(this.CU3_TextChanged_1);
            // 
            // CU2
            // 
            this.CU2.Location = new System.Drawing.Point(387, 62);
            this.CU2.Name = "CU2";
            this.CU2.Size = new System.Drawing.Size(48, 20);
            this.CU2.TabIndex = 109;
            this.CU2.TextChanged += new System.EventHandler(this.CU2_TextChanged_1);
            // 
            // CU1
            // 
            this.CU1.Location = new System.Drawing.Point(387, 33);
            this.CU1.Name = "CU1";
            this.CU1.Size = new System.Drawing.Size(48, 20);
            this.CU1.TabIndex = 108;
            this.CU1.TextChanged += new System.EventHandler(this.CU1_TextChanged_1);
            // 
            // Room7
            // 
            this.Room7.Location = new System.Drawing.Point(594, 207);
            this.Room7.Name = "Room7";
            this.Room7.Size = new System.Drawing.Size(69, 20);
            this.Room7.TabIndex = 107;
            // 
            // Day7
            // 
            this.Day7.Location = new System.Drawing.Point(535, 207);
            this.Day7.Name = "Day7";
            this.Day7.Size = new System.Drawing.Size(52, 20);
            this.Day7.TabIndex = 106;
            // 
            // Time7
            // 
            this.Time7.Location = new System.Drawing.Point(446, 207);
            this.Time7.Name = "Time7";
            this.Time7.Size = new System.Drawing.Size(82, 20);
            this.Time7.TabIndex = 105;
            // 
            // LabU7
            // 
            this.LabU7.Location = new System.Drawing.Point(332, 207);
            this.LabU7.Name = "LabU7";
            this.LabU7.Size = new System.Drawing.Size(48, 20);
            this.LabU7.TabIndex = 103;
            this.LabU7.TextChanged += new System.EventHandler(this.LabU7_TextChanged_1);
            // 
            // LecU7
            // 
            this.LecU7.Location = new System.Drawing.Point(279, 207);
            this.LecU7.Name = "LecU7";
            this.LecU7.Size = new System.Drawing.Size(46, 20);
            this.LecU7.TabIndex = 102;
            this.LecU7.TextChanged += new System.EventHandler(this.LecU7_TextChanged_1);
            // 
            // Desc7
            // 
            this.Desc7.Location = new System.Drawing.Point(142, 207);
            this.Desc7.Name = "Desc7";
            this.Desc7.Size = new System.Drawing.Size(130, 20);
            this.Desc7.TabIndex = 101;
            // 
            // Sec7
            // 
            this.Sec7.Location = new System.Drawing.Point(79, 207);
            this.Sec7.Name = "Sec7";
            this.Sec7.Size = new System.Drawing.Size(56, 20);
            this.Sec7.TabIndex = 100;
            // 
            // CC7
            // 
            this.CC7.Location = new System.Drawing.Point(26, 207);
            this.CC7.Name = "CC7";
            this.CC7.Size = new System.Drawing.Size(46, 20);
            this.CC7.TabIndex = 99;
            // 
            // Room6
            // 
            this.Room6.Location = new System.Drawing.Point(594, 178);
            this.Room6.Name = "Room6";
            this.Room6.Size = new System.Drawing.Size(69, 20);
            this.Room6.TabIndex = 98;
            // 
            // Day6
            // 
            this.Day6.Location = new System.Drawing.Point(535, 178);
            this.Day6.Name = "Day6";
            this.Day6.Size = new System.Drawing.Size(52, 20);
            this.Day6.TabIndex = 97;
            // 
            // Time6
            // 
            this.Time6.Location = new System.Drawing.Point(446, 178);
            this.Time6.Name = "Time6";
            this.Time6.Size = new System.Drawing.Size(82, 20);
            this.Time6.TabIndex = 96;
            // 
            // LabU6
            // 
            this.LabU6.Location = new System.Drawing.Point(332, 178);
            this.LabU6.Name = "LabU6";
            this.LabU6.Size = new System.Drawing.Size(48, 20);
            this.LabU6.TabIndex = 94;
            this.LabU6.TextChanged += new System.EventHandler(this.LabU6_TextChanged_1);
            // 
            // LecU6
            // 
            this.LecU6.Location = new System.Drawing.Point(279, 178);
            this.LecU6.Name = "LecU6";
            this.LecU6.Size = new System.Drawing.Size(46, 20);
            this.LecU6.TabIndex = 93;
            this.LecU6.TextChanged += new System.EventHandler(this.LecU6_TextChanged_1);
            // 
            // Desc6
            // 
            this.Desc6.Location = new System.Drawing.Point(142, 178);
            this.Desc6.Name = "Desc6";
            this.Desc6.Size = new System.Drawing.Size(130, 20);
            this.Desc6.TabIndex = 92;
            // 
            // Sec6
            // 
            this.Sec6.Location = new System.Drawing.Point(79, 178);
            this.Sec6.Name = "Sec6";
            this.Sec6.Size = new System.Drawing.Size(56, 20);
            this.Sec6.TabIndex = 91;
            // 
            // CC6
            // 
            this.CC6.Location = new System.Drawing.Point(26, 178);
            this.CC6.Name = "CC6";
            this.CC6.Size = new System.Drawing.Size(46, 20);
            this.CC6.TabIndex = 90;
            // 
            // Room5
            // 
            this.Room5.Location = new System.Drawing.Point(594, 149);
            this.Room5.Name = "Room5";
            this.Room5.Size = new System.Drawing.Size(69, 20);
            this.Room5.TabIndex = 89;
            // 
            // Day5
            // 
            this.Day5.Location = new System.Drawing.Point(535, 149);
            this.Day5.Name = "Day5";
            this.Day5.Size = new System.Drawing.Size(52, 20);
            this.Day5.TabIndex = 88;
            // 
            // Time5
            // 
            this.Time5.Location = new System.Drawing.Point(446, 149);
            this.Time5.Name = "Time5";
            this.Time5.Size = new System.Drawing.Size(82, 20);
            this.Time5.TabIndex = 87;
            // 
            // LabU5
            // 
            this.LabU5.Location = new System.Drawing.Point(332, 149);
            this.LabU5.Name = "LabU5";
            this.LabU5.Size = new System.Drawing.Size(48, 20);
            this.LabU5.TabIndex = 85;
            this.LabU5.TextChanged += new System.EventHandler(this.LabU5_TextChanged_1);
            // 
            // LecU5
            // 
            this.LecU5.Location = new System.Drawing.Point(279, 149);
            this.LecU5.Name = "LecU5";
            this.LecU5.Size = new System.Drawing.Size(46, 20);
            this.LecU5.TabIndex = 84;
            this.LecU5.TextChanged += new System.EventHandler(this.LecU5_TextChanged_1);
            // 
            // Desc5
            // 
            this.Desc5.Location = new System.Drawing.Point(142, 149);
            this.Desc5.Name = "Desc5";
            this.Desc5.Size = new System.Drawing.Size(130, 20);
            this.Desc5.TabIndex = 83;
            // 
            // Sec5
            // 
            this.Sec5.Location = new System.Drawing.Point(79, 149);
            this.Sec5.Name = "Sec5";
            this.Sec5.Size = new System.Drawing.Size(56, 20);
            this.Sec5.TabIndex = 82;
            // 
            // CC5
            // 
            this.CC5.Location = new System.Drawing.Point(26, 149);
            this.CC5.Name = "CC5";
            this.CC5.Size = new System.Drawing.Size(46, 20);
            this.CC5.TabIndex = 81;
            // 
            // Room4
            // 
            this.Room4.Location = new System.Drawing.Point(594, 120);
            this.Room4.Name = "Room4";
            this.Room4.Size = new System.Drawing.Size(69, 20);
            this.Room4.TabIndex = 80;
            // 
            // Day4
            // 
            this.Day4.Location = new System.Drawing.Point(535, 120);
            this.Day4.Name = "Day4";
            this.Day4.Size = new System.Drawing.Size(52, 20);
            this.Day4.TabIndex = 79;
            // 
            // Time4
            // 
            this.Time4.Location = new System.Drawing.Point(446, 120);
            this.Time4.Name = "Time4";
            this.Time4.Size = new System.Drawing.Size(82, 20);
            this.Time4.TabIndex = 78;
            // 
            // LabU4
            // 
            this.LabU4.Location = new System.Drawing.Point(332, 120);
            this.LabU4.Name = "LabU4";
            this.LabU4.Size = new System.Drawing.Size(48, 20);
            this.LabU4.TabIndex = 76;
            this.LabU4.TextChanged += new System.EventHandler(this.LabU4_TextChanged_1);
            // 
            // LecU4
            // 
            this.LecU4.Location = new System.Drawing.Point(279, 120);
            this.LecU4.Name = "LecU4";
            this.LecU4.Size = new System.Drawing.Size(46, 20);
            this.LecU4.TabIndex = 75;
            this.LecU4.TextChanged += new System.EventHandler(this.LecU4_TextChanged_1);
            // 
            // Desc4
            // 
            this.Desc4.Location = new System.Drawing.Point(142, 120);
            this.Desc4.Name = "Desc4";
            this.Desc4.Size = new System.Drawing.Size(130, 20);
            this.Desc4.TabIndex = 74;
            // 
            // Sec4
            // 
            this.Sec4.Location = new System.Drawing.Point(79, 120);
            this.Sec4.Name = "Sec4";
            this.Sec4.Size = new System.Drawing.Size(56, 20);
            this.Sec4.TabIndex = 73;
            // 
            // CC4
            // 
            this.CC4.Location = new System.Drawing.Point(26, 120);
            this.CC4.Name = "CC4";
            this.CC4.Size = new System.Drawing.Size(46, 20);
            this.CC4.TabIndex = 72;
            // 
            // Room3
            // 
            this.Room3.Location = new System.Drawing.Point(594, 91);
            this.Room3.Name = "Room3";
            this.Room3.Size = new System.Drawing.Size(69, 20);
            this.Room3.TabIndex = 71;
            // 
            // Day3
            // 
            this.Day3.Location = new System.Drawing.Point(535, 91);
            this.Day3.Name = "Day3";
            this.Day3.Size = new System.Drawing.Size(52, 20);
            this.Day3.TabIndex = 70;
            // 
            // Time3
            // 
            this.Time3.Location = new System.Drawing.Point(446, 91);
            this.Time3.Name = "Time3";
            this.Time3.Size = new System.Drawing.Size(82, 20);
            this.Time3.TabIndex = 69;
            // 
            // LabU3
            // 
            this.LabU3.Location = new System.Drawing.Point(332, 91);
            this.LabU3.Name = "LabU3";
            this.LabU3.Size = new System.Drawing.Size(48, 20);
            this.LabU3.TabIndex = 67;
            this.LabU3.TextChanged += new System.EventHandler(this.LabU3_TextChanged_1);
            // 
            // LecU3
            // 
            this.LecU3.Location = new System.Drawing.Point(279, 91);
            this.LecU3.Name = "LecU3";
            this.LecU3.Size = new System.Drawing.Size(46, 20);
            this.LecU3.TabIndex = 66;
            this.LecU3.TextChanged += new System.EventHandler(this.LecU3_TextChanged_1);
            // 
            // Desc3
            // 
            this.Desc3.Location = new System.Drawing.Point(142, 91);
            this.Desc3.Name = "Desc3";
            this.Desc3.Size = new System.Drawing.Size(130, 20);
            this.Desc3.TabIndex = 65;
            // 
            // Sec3
            // 
            this.Sec3.Location = new System.Drawing.Point(79, 91);
            this.Sec3.Name = "Sec3";
            this.Sec3.Size = new System.Drawing.Size(56, 20);
            this.Sec3.TabIndex = 64;
            // 
            // CC3
            // 
            this.CC3.Location = new System.Drawing.Point(26, 91);
            this.CC3.Name = "CC3";
            this.CC3.Size = new System.Drawing.Size(46, 20);
            this.CC3.TabIndex = 63;
            // 
            // Room2
            // 
            this.Room2.Location = new System.Drawing.Point(594, 62);
            this.Room2.Name = "Room2";
            this.Room2.Size = new System.Drawing.Size(69, 20);
            this.Room2.TabIndex = 62;
            // 
            // Day2
            // 
            this.Day2.Location = new System.Drawing.Point(535, 62);
            this.Day2.Name = "Day2";
            this.Day2.Size = new System.Drawing.Size(52, 20);
            this.Day2.TabIndex = 61;
            // 
            // Time2
            // 
            this.Time2.Location = new System.Drawing.Point(446, 62);
            this.Time2.Name = "Time2";
            this.Time2.Size = new System.Drawing.Size(82, 20);
            this.Time2.TabIndex = 60;
            // 
            // LabU2
            // 
            this.LabU2.Location = new System.Drawing.Point(332, 62);
            this.LabU2.Name = "LabU2";
            this.LabU2.Size = new System.Drawing.Size(48, 20);
            this.LabU2.TabIndex = 58;
            this.LabU2.TextChanged += new System.EventHandler(this.LabU2_TextChanged_1);
            // 
            // LecU2
            // 
            this.LecU2.Location = new System.Drawing.Point(279, 62);
            this.LecU2.Name = "LecU2";
            this.LecU2.Size = new System.Drawing.Size(46, 20);
            this.LecU2.TabIndex = 57;
            this.LecU2.TextChanged += new System.EventHandler(this.LecU2_TextChanged_1);
            // 
            // Desc2
            // 
            this.Desc2.Location = new System.Drawing.Point(142, 62);
            this.Desc2.Name = "Desc2";
            this.Desc2.Size = new System.Drawing.Size(130, 20);
            this.Desc2.TabIndex = 56;
            // 
            // Sec2
            // 
            this.Sec2.Location = new System.Drawing.Point(79, 62);
            this.Sec2.Name = "Sec2";
            this.Sec2.Size = new System.Drawing.Size(56, 20);
            this.Sec2.TabIndex = 55;
            // 
            // CC2
            // 
            this.CC2.Location = new System.Drawing.Point(26, 62);
            this.CC2.Name = "CC2";
            this.CC2.Size = new System.Drawing.Size(46, 20);
            this.CC2.TabIndex = 54;
            // 
            // Room1
            // 
            this.Room1.Location = new System.Drawing.Point(594, 33);
            this.Room1.Name = "Room1";
            this.Room1.Size = new System.Drawing.Size(69, 20);
            this.Room1.TabIndex = 53;
            // 
            // Day1
            // 
            this.Day1.Location = new System.Drawing.Point(535, 33);
            this.Day1.Name = "Day1";
            this.Day1.Size = new System.Drawing.Size(52, 20);
            this.Day1.TabIndex = 52;
            // 
            // Time1
            // 
            this.Time1.Location = new System.Drawing.Point(446, 33);
            this.Time1.Name = "Time1";
            this.Time1.Size = new System.Drawing.Size(82, 20);
            this.Time1.TabIndex = 51;
            this.Time1.TextChanged += new System.EventHandler(this.Time1_TextChanged);
            // 
            // LabU1
            // 
            this.LabU1.Location = new System.Drawing.Point(332, 33);
            this.LabU1.Name = "LabU1";
            this.LabU1.Size = new System.Drawing.Size(48, 20);
            this.LabU1.TabIndex = 49;
            this.LabU1.TextChanged += new System.EventHandler(this.LabU1_TextChanged_1);
            // 
            // LecU1
            // 
            this.LecU1.Location = new System.Drawing.Point(279, 33);
            this.LecU1.Name = "LecU1";
            this.LecU1.Size = new System.Drawing.Size(46, 20);
            this.LecU1.TabIndex = 48;
            this.LecU1.TextChanged += new System.EventHandler(this.LecU1_TextChanged_1);
            // 
            // Desc1
            // 
            this.Desc1.Location = new System.Drawing.Point(142, 33);
            this.Desc1.Name = "Desc1";
            this.Desc1.Size = new System.Drawing.Size(130, 20);
            this.Desc1.TabIndex = 47;
            // 
            // Sec1
            // 
            this.Sec1.Location = new System.Drawing.Point(79, 33);
            this.Sec1.Name = "Sec1";
            this.Sec1.Size = new System.Drawing.Size(56, 20);
            this.Sec1.TabIndex = 46;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(594, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Room:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(535, 1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Day:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(446, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Time:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(387, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 26);
            this.label14.TabIndex = 34;
            this.label14.Text = "Cred Units:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(332, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 26);
            this.label13.TabIndex = 33;
            this.label13.Text = "Lab Units:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(279, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 26);
            this.label12.TabIndex = 32;
            this.label12.Text = "Lec Units:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(142, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Description:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Section:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 26);
            this.label9.TabIndex = 29;
            this.label9.Text = "Course Code:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "2";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "3";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 117);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 13);
            this.label21.TabIndex = 41;
            this.label21.Text = "4";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 146);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 13);
            this.label22.TabIndex = 42;
            this.label22.Text = "5";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 175);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 13);
            this.label23.TabIndex = 43;
            this.label23.Text = "6";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(4, 204);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 44;
            this.label24.Text = "7";
            // 
            // CC1
            // 
            this.CC1.Location = new System.Drawing.Point(26, 33);
            this.CC1.Name = "CC1";
            this.CC1.Size = new System.Drawing.Size(46, 20);
            this.CC1.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "#:";
            // 
            // StudMode
            // 
            this.StudMode.FormattingEnabled = true;
            this.StudMode.Location = new System.Drawing.Point(604, 73);
            this.StudMode.Name = "StudMode";
            this.StudMode.Size = new System.Drawing.Size(61, 21);
            this.StudMode.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mode:";
            // 
            // StudScholar
            // 
            this.StudScholar.FormattingEnabled = true;
            this.StudScholar.Location = new System.Drawing.Point(354, 73);
            this.StudScholar.Name = "StudScholar";
            this.StudScholar.Size = new System.Drawing.Size(172, 21);
            this.StudScholar.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Scholar:";
            // 
            // StudYearLevel
            // 
            this.StudYearLevel.FormattingEnabled = true;
            this.StudYearLevel.Location = new System.Drawing.Point(354, 48);
            this.StudYearLevel.Name = "StudYearLevel";
            this.StudYearLevel.Size = new System.Drawing.Size(172, 21);
            this.StudYearLevel.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Year Level:";
            // 
            // StudNo
            // 
            this.StudNo.Location = new System.Drawing.Point(354, 23);
            this.StudNo.Name = "StudNo";
            this.StudNo.Size = new System.Drawing.Size(172, 20);
            this.StudNo.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Student No:";
            // 
            // StudDateEnrolled
            // 
            this.StudDateEnrolled.Location = new System.Drawing.Point(88, 73);
            this.StudDateEnrolled.Name = "StudDateEnrolled";
            this.StudDateEnrolled.Size = new System.Drawing.Size(172, 20);
            this.StudDateEnrolled.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Date Enrolled:";
            // 
            // StudProgram
            // 
            this.StudProgram.FormattingEnabled = true;
            this.StudProgram.Location = new System.Drawing.Point(88, 48);
            this.StudProgram.Name = "StudProgram";
            this.StudProgram.Size = new System.Drawing.Size(172, 21);
            this.StudProgram.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Program:";
            // 
            // StudName
            // 
            this.StudName.Location = new System.Drawing.Point(88, 23);
            this.StudName.Name = "StudName";
            this.StudName.Size = new System.Drawing.Size(172, 20);
            this.StudName.TabIndex = 15;
            this.StudName.TextChanged += new System.EventHandler(this.StudName_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Student Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 707);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 757);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Quiz";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load_2);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox StudMode;
        private Label label7;
        private ComboBox StudScholar;
        private Label label6;
        private ComboBox StudYearLevel;
        private Label label5;
        private TextBox StudNo;
        private Label label4;
        private DateTimePicker StudDateEnrolled;
        private Label label3;
        private ComboBox StudProgram;
        private Label label2;
        private TextBox StudName;
        private Label label1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label8;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private TextBox LecU7;
        private TextBox Desc7;
        private TextBox Sec7;
        private TextBox CC7;
        private TextBox Room6;
        private TextBox Day6;
        private TextBox Time6;
        private TextBox LabU6;
        private TextBox LecU6;
        private TextBox Desc6;
        private TextBox Sec6;
        private TextBox CC6;
        private TextBox Room5;
        private TextBox Day5;
        private TextBox Time5;
        private TextBox LabU5;
        private TextBox LecU5;
        private TextBox Desc5;
        private TextBox Sec5;
        private TextBox CC5;
        private TextBox Room4;
        private TextBox Day4;
        private TextBox Time4;
        private TextBox LabU4;
        private TextBox LecU4;
        private TextBox Desc4;
        private TextBox Sec4;
        private TextBox CC4;
        private TextBox Room3;
        private TextBox Day3;
        private TextBox Time3;
        private TextBox LabU3;
        private TextBox LecU3;
        private TextBox Desc3;
        private TextBox Sec3;
        private TextBox CC3;
        private TextBox Room2;
        private TextBox Day2;
        private TextBox Time2;
        private TextBox LabU2;
        private TextBox LecU2;
        private TextBox Desc2;
        private TextBox Sec2;
        private TextBox CC2;
        private TextBox Room1;
        private TextBox Day1;
        private TextBox Time1;
        private TextBox LabU1;
        private TextBox LecU1;
        private TextBox Desc1;
        private TextBox Sec1;
        private TextBox CC1;
        private TextBox txtbox_totalcreditunit;
        private Label label25;
        private TextBox Room7;
        private TextBox Day7;
        private TextBox Time7;
        private TextBox LabU7;
        private GroupBox groupBox4;
        private TextBox textBox7;
        private Label label30;
        private TextBox textBox8;
        private Label label31;
        private TextBox textBox5;
        private Label label28;
        private Label label29;
        private TextBox textBox6;
        private GroupBox groupBox3;
        private TextBox textBox4;
        private Label label27;
        private TextBox textBox3;
        private Label label26;
        private GroupBox groupBox5;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox10;
        private Label label37;
        private Label label38;
        private Label label39;
        private TextBox textBox11;
        private TextBox textBox13;
        private Label label32;
        private TextBox textBox14;
        private TextBox textBox12;
        private Label label35;
        private Label label33;
        private Label label34;
        private Button btn_CalculateFees;
        private GroupBox groupBox6;
        private TextBox textBox17;
        private TextBox textBox18;
        private Label label41;
        private TextBox textBox19;
        private Label label40;
        private Label label36;
        private TextBox textBox9;
        private Label label42;
        private Button btn_ClearScheduleOfCourses;
        private Button button4;
        private Button btn_clrstudentinfo;
        private TextBox CU7;
        private TextBox CU6;
        private TextBox CU5;
        private TextBox CU4;
        private TextBox CU3;
        private TextBox CU2;
        private TextBox CU1;
        private Button button1;
    }
}