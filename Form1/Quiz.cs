using Form1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Data;

namespace Form1
{
    public partial class Quiz : Form
    {
        double CompLabFee = 0;
        double SAPFee = 2000.00;
        double CISCOLabFee = 4500.00;
        double ExamBookletFee = 450.00;

        
        String connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;

        public Quiz()
        {
            connectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=quizDb; Integrated Security=True; TrustServerCertificate=True;";
            connection = new SqlConnection(connectionString);
            
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            // extra
            StudYearLevel.Items.Add("1st Year");
            StudYearLevel.Items.Add("2nd Year");
            StudYearLevel.Items.Add("3rd Year");
            StudYearLevel.Items.Add("4th Year");

            StudScholar.Items.Add("Academic Scholar");
            StudScholar.Items.Add("None");

            // question 2 a.
            StudProgram.Items.Add("BS Information Technology");
            StudProgram.Items.Add("BS Computer Engineering");
            StudProgram.Items.Add("BS Electrical Engineering");
            StudProgram.Items.Add("BS Computer Science");
            StudProgram.Items.Add("BS Mechanical Engineering");
            StudProgram.Items.Add("BS Industrial Engineering");


            // set other school fees
            textBox6.Text = CompLabFee.ToString();
            textBox5.Text = SAPFee.ToString();
            textBox3.Text = CISCOLabFee.ToString();
            textBox7.Text = ExamBookletFee.ToString();

            // m.
            StudMode.Items.Add("Installment");
            textBox13.Text = "Installment";
            textBox11.Text = "8000";
        }

        private void LecU1_TextChanged(object sender, EventArgs e)
        {
            if (LecU1.Text != "" && LabU1.Text != "")
            {
                CU1.Text = (Convert.ToInt32(LecU1.Text) + Convert.ToInt32(LabU1.Text)).ToString();
            }
        }

        private void LecU2_TextChanged(object sender, EventArgs e)
        {
            if (LecU2.Text != "" && LabU2.Text != "")
            {
                CU2.Text = (Convert.ToInt32(LecU2.Text) + Convert.ToInt32(LabU2.Text)).ToString();
            }
        }

        private void LecU3_TextChanged(object sender, EventArgs e)
        {
            if (LecU3.Text != "" && LabU3.Text != "")
            {
                CU3.Text = (Convert.ToInt32(LecU3.Text) + Convert.ToInt32(LabU3.Text)).ToString();
            }
        }

        private void LecU4_TextChanged(object sender, EventArgs e)
        {
            if (LecU4.Text != "" && LabU4.Text != "")
            {
                CU4.Text = (Convert.ToInt32(LecU4.Text) + Convert.ToInt32(LabU4.Text)).ToString();
            }
        }

        private void LecU5_TextChanged(object sender, EventArgs e)
        {
            if (LecU5.Text != "" && LabU5.Text != "")
            {
                CU5.Text = (Convert.ToInt32(LecU5.Text) + Convert.ToInt32(LabU5.Text)).ToString();
            }
        }

        private void LecU6_TextChanged(object sender, EventArgs e)
        {
            if (LecU6.Text != "" && LabU6.Text != "")
            {
                CU6.Text = (Convert.ToInt32(LecU6.Text) + Convert.ToInt32(LabU6.Text)).ToString();
            }
        }

        private void LecU7_TextChanged(object sender, EventArgs e)
        {
            if (LecU7.Text != "" && LabU7.Text != "")
            {
                CU7.Text = (Convert.ToInt32(LecU7.Text) + Convert.ToInt32(LabU7.Text)).ToString();
            }
        }

        private void LabU1_TextChanged(object sender, EventArgs e)
        {
            if (LecU1.Text != "" && LabU1.Text != "")
            {
                CU1.Text = (Convert.ToInt32(LecU1.Text) + Convert.ToInt32(LabU1.Text)).ToString();
            }
        }

        private void LabU2_TextChanged(object sender, EventArgs e)
        {
            if (LecU2.Text != "" && LabU2.Text != "")
            {
                CU2.Text = (Convert.ToInt32(LecU2.Text) + Convert.ToInt32(LabU2.Text)).ToString();
            }
        }

        private void LabU3_TextChanged(object sender, EventArgs e)
        {
            if (LecU3.Text != "" && LabU3.Text != "")
            {
                CU3.Text = (Convert.ToInt32(LecU3.Text) + Convert.ToInt32(LabU3.Text)).ToString();
            }
        }

        private void LabU4_TextChanged(object sender, EventArgs e)
        {
            if (LecU4.Text != "" && LabU4.Text != "")
            {
                CU4.Text = (Convert.ToInt32(LecU4.Text) + Convert.ToInt32(LabU4.Text)).ToString();
            }
        }

        private void LabU5_TextChanged(object sender, EventArgs e)
        {
            if (LecU5.Text != "" && LabU5.Text != "")
            {
                CU5.Text = (Convert.ToInt32(LecU5.Text) + Convert.ToInt32(LabU5.Text)).ToString();
            }
        }

        private void LabU6_TextChanged(object sender, EventArgs e)
        {
            if (LecU6.Text != "" && LabU6.Text != "")
            {
                CU6.Text = (Convert.ToInt32(LecU6.Text) + Convert.ToInt32(LabU6.Text)).ToString();
            }
        }

        private void LabU7_TextChanged(object sender, EventArgs e)
        {
            if (LecU7.Text != "" && LabU7.Text != "")
            {
                CU7.Text = (Convert.ToInt32(LecU7.Text) + Convert.ToInt32(LabU7.Text)).ToString();
            }
        }

        private void CU1_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU2_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU3_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU4_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU5_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU6_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU7_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void btn_CalculateFees_Click(object sender, EventArgs e)
        {
            // i. total tuition
            double total_lecunits = Convert.ToInt32(LecU1.Text) + Convert.ToInt32(LecU2.Text) + Convert.ToInt32(LecU3.Text) + Convert.ToInt32(LecU4.Text) + Convert.ToInt32(LecU5.Text) + Convert.ToInt32(LecU6.Text) + Convert.ToInt32(LecU7.Text);
            double totalTuition = Convert.ToInt32(txtbox_totalcreditunit.Text) * 1500;
            textBox3.Text = totalTuition.ToString();

            // j total misc = 
            double total_labunits = Convert.ToInt32(LabU1.Text) + Convert.ToInt32(LabU2.Text) + Convert.ToInt32(LabU3.Text) + Convert.ToInt32(LabU4.Text) + Convert.ToInt32(LabU5.Text) + Convert.ToInt32(LabU6.Text) + Convert.ToInt32(LabU7.Text);
            CompLabFee = 2500 * (total_labunits);
            textBox6.Text = CompLabFee.ToString();
            double totalMisc = CompLabFee + SAPFee + CISCOLabFee + ExamBookletFee;

            // same as total others fee
            textBox4.Text = totalMisc.ToString();
            textBox9.Text = totalMisc.ToString();

            // k. computer laboratory fee
            CompLabFee = (Convert.ToDouble(LabU1.Text) + Convert.ToDouble(LabU2.Text) + Convert.ToDouble(LabU3.Text) + Convert.ToDouble(LabU4.Text) + Convert.ToDouble(LabU5.Text) + Convert.ToDouble(LabU6.Text) + Convert.ToDouble(LabU7.Text)) * 2500;

            // final
            double total_tuition_and_fees = totalTuition + totalMisc;
            textBox14.Text = total_tuition_and_fees.ToString();

            double installment_fee = (total_tuition_and_fees - 8000) / 3;
            textBox16.Text = installment_fee.ToString("C");
            textBox15.Text = installment_fee.ToString("C");
            textBox10.Text = installment_fee.ToString("C");
        }

        private void btn_clrstudentinfo_Click(object sender, EventArgs e)
        {
            StudName.Clear();
            StudNo.Clear();
            StudProgram.SelectedIndex = -1;
            StudYearLevel.SelectedIndex = -1;
            StudProgram.SelectedIndex = -1;
            StudScholar.SelectedIndex = -1;
        }

        private void btn_ClearScheduleOfCourses_Click(object sender, EventArgs e)
        {
            // clear all course code
            CC1.Clear();
            CC2.Clear();
            CC3.Clear();
            CC4.Clear();
            CC5.Clear();
            CC6.Clear();
            CC7.Clear();

            // Clear all section
            Sec1.Clear();
            Sec2.Clear();
            Sec3.Clear();
            Sec4.Clear();
            Sec5.Clear();
            Sec6.Clear();
            Sec7.Clear();

            // clear all desc
            Desc1.Clear();
            Desc2.Clear();
            Desc3.Clear();
            Desc4.Clear();
            Desc5.Clear();
            Desc6.Clear();
            Desc7.Clear();

            // clear all lec
            LecU1.Clear();
            LecU2.Clear();
            LecU3.Clear();
            LecU4.Clear();
            LecU5.Clear();
            LecU6.Clear();
            LecU7.Clear();

            // clear all lab
            LabU1.Clear();
            LabU2.Clear();
            LabU3.Clear();
            LabU4.Clear();
            LabU5.Clear();
            LabU6.Clear();
            LabU7.Clear();

            // Clear all credit unit
            CU1.Clear();
            CU2.Clear();
            CU3.Clear();
            CU4.Clear();
            CU5.Clear();
            CU6.Clear();
            CU7.Clear();
            txtbox_totalcreditunit.Clear();

            // clear all time
            Time1.Clear();
            Time2.Clear();
            Time3.Clear();
            Time4.Clear();
            Time5.Clear();
            Time6.Clear();
            Time7.Clear();

            // clear all day
            Day1.Clear();
            Day2.Clear();
            Day3.Clear();
            Day4.Clear();
            Day5.Clear();
            Day6.Clear();
            Day7.Clear();

            // clear all room
            Room1.Clear();
            Room2.Clear();
            Room3.Clear();
            Room4.Clear();
            Room5.Clear();
            Room6.Clear();
            Room7.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Quiz_Load_1(object sender, EventArgs e)
        {
            connection.Open();
            sql = "SELECT * FROM assessmentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();
            dset = new DataSet();
            adaptersql.Fill(dset, "assessmentTbl");

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "UPDATE assessmentTbl SET StudentName = '" + StudName.Text + "', StudentProgram = '" + StudProgram.Text + "', DateEnrolled = '" + StudDateEnrolled.Text + "', StudentNo = '" + StudNo.Text + "', YearLevel = '" + StudYearLevel.Text + "', Scholar = '" + StudScholar.Text + "', TotalCredUnits = '" + txtbox_totalcreditunit.Text + "', TotalTuitionFee = '" + textBox3.Text + "', MiscellaneousFee = '" + textBox4.Text + "', TotalOtherFee = '" + textBox9.Text + " ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT *FROM assessmentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "assessmentTbl");


            connection.Close();
        }

        private void StudName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CalculateFees_Click_1(object sender, EventArgs e)
        {
            // Helper function to safely parse integer inputs from textboxes
            int ParseInt(string text) => int.TryParse(text, out int val) ? val : 0;

            // 1. Calculate Total Lecture Units & Total Laboratory Units
            int totalLecUnits = ParseInt(LecU1.Text) + ParseInt(LecU2.Text) + ParseInt(LecU3.Text) +
                                ParseInt(LecU4.Text) + ParseInt(LecU5.Text) + ParseInt(LecU6.Text) + ParseInt(LecU7.Text);

            int totalLabUnits = ParseInt(LabU1.Text) + ParseInt(LabU2.Text) + ParseInt(LabU3.Text) +
                                ParseInt(LabU4.Text) + ParseInt(LabU5.Text) + ParseInt(LabU6.Text) + ParseInt(LabU7.Text);

            // Rule i: Total Tuition Fee = Total Lecture Units * Lecture Fee (1500.00)
            double totalTuition = totalLecUnits * 1500.00;
            textBox3.Text = totalTuition.ToString("F2"); // Total Tuition Fee

            // Rule k: Computer Laboratory Fee = Total Laboratory Units * Laboratory Fee (2500.00)
            CompLabFee = totalLabUnits * 2500.00;
            textBox6.Text = CompLabFee.ToString("F2"); // Computer Lab Fee

            // Rule j: Total Miscellaneous Fees = Sum of Computer Lab Fee, CISCO Lab Fee, SAP Fee, Exam Booklet Fee
            double totalMisc = CompLabFee + CISCOLabFee + SAPFee + ExamBookletFee;
            textBox4.Text = totalMisc.ToString("F2"); // Miscellaneous Fees
            textBox9.Text = totalMisc.ToString("F2"); // Total Other Fees

            // Rule l: Total Tuition and Fees = Total Tuition Fee + Miscellaneous Fees
            double totalTuitionAndFees = totalTuition + totalMisc;
            textBox14.Text = totalTuitionAndFees.ToString("F2"); // TOTAL TUITION AND FEES

            // Rule m: Mode of Payment = Installment
            // Downpayment = 8000.00, Remaining balance divided into 3 installments
            double downpayment = 8000.00;
            double remainingBalance = totalTuitionAndFees - downpayment;
            double installmentAmount = remainingBalance > 0 ? remainingBalance / 3.0 : 0.0;

            // Map calculated values to UI fields:
            // Update these textbox control names if they differ in your form layout
            textBox11.Text = downpayment.ToString("F2");          // Downpayment
            textBox10.Text = installmentAmount.ToString("F2");     // 1st Installment
            textBox15.Text = installmentAmount.ToString("F2");     // 2nd Installment
            textBox16.Text = installmentAmount.ToString("F2");     // 3rd Installment
        }

        private void StudProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudProgram.Items.Add("BS Information Technology");
            StudProgram.Items.Add("BS Computer Engineering");
            StudProgram.Items.Add("BS Electrical Engineering");
            StudProgram.Items.Add("BS Computer Science");
            StudProgram.Items.Add("BS Mechanical Engineering");
            StudProgram.Items.Add("BS Industrial Engineering");
        }

        private void StudYearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudYearLevel.Items.Add("1st Year");
            StudYearLevel.Items.Add("2nd Year");
            StudYearLevel.Items.Add("3rd Year");
            StudYearLevel.Items.Add("4th Year");
        }

        private void StudScholar_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudScholar.Items.Add("Academic Scholar");
            StudScholar.Items.Add("None");
        }

        private void StudMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudMode.Items.Add("Installment");
        }

        private void btn_CalculateFees_Click_2(object sender, EventArgs e)
        {
            // 1. Calculate Total Lecture Units and Total Laboratory Units
            int totalLecUnits = (int.TryParse(LecU1.Text, out int l1) ? l1 : 0) +
                                (int.TryParse(LecU2.Text, out int l2) ? l2 : 0) +
                                (int.TryParse(LecU3.Text, out int l3) ? l3 : 0) +
                                (int.TryParse(LecU4.Text, out int l4) ? l4 : 0) +
                                (int.TryParse(LecU5.Text, out int l5) ? l5 : 0) +
                                (int.TryParse(LecU6.Text, out int l6) ? l6 : 0) +
                                (int.TryParse(LecU7.Text, out int l7) ? l7 : 0);

            int totalLabUnits = (int.TryParse(LabU1.Text, out int b1) ? b1 : 0) +
                                (int.TryParse(LabU2.Text, out int b2) ? b2 : 0) +
                                (int.TryParse(LabU3.Text, out int b3) ? b3 : 0) +
                                (int.TryParse(LabU4.Text, out int b4) ? b4 : 0) +
                                (int.TryParse(LabU5.Text, out int b5) ? b5 : 0) +
                                (int.TryParse(LabU6.Text, out int b6) ? b6 : 0) +
                                (int.TryParse(LabU7.Text, out int b7) ? b7 : 0);

            // Rule i: Total Tuition Fee = Total Lecture Units * Lecture Fee (1500.00)
            double totalTuitionFee = totalLecUnits * 1500.00;
            textBox3.Text = totalTuitionFee.ToString("F2");

            // Rule k: Computer Laboratory Fee = Total Laboratory Units * Laboratory Fee (2500.00)
            double compLabFee = totalLabUnits * 2500.00;
            textBox6.Text = compLabFee.ToString("F2");

            // Rule j: Total Misc Fees = Computer Lab Fee + CISCO Lab Fee (4500) + SAP Fee (2000) + Exam Booklet Fee (450)
            double totalMiscFee = compLabFee + 4500.00 + 2000.00 + 450.00;
            textBox4.Text = totalMiscFee.ToString("F2"); // Miscellaneous Fees
            textBox9.Text = totalMiscFee.ToString("F2"); // Total Other Fees

            // Rule l: Total Tuition and Fees = Total Tuition Fee + Miscellaneous Fees
            double totalTuitionAndFees = totalTuitionFee + totalMiscFee;
            textBox14.Text = totalTuitionAndFees.ToString("F2");

            // Rule m: Installment Calculations (Downpayment = 8000.00, remaining balance divided by 3)
            double downpayment = 8000.00;
            double remainingBalance = totalTuitionAndFees - downpayment;
            double installmentAmount = remainingBalance > 0 ? remainingBalance / 3.0 : 0.0;

            textBox11.Text = downpayment.ToString("F2");         // Downpayment
            textBox10.Text = installmentAmount.ToString("F2");  // 1st Installment
            textBox15.Text = installmentAmount.ToString("F2");  // 2nd Installment
            textBox16.Text = installmentAmount.ToString("F2");  // 3rd Installment
        }

        private void LecU1_TextChanged_1(object sender, EventArgs e)
        {
            if (LecU1.Text != "" && LabU1.Text != "")
            {
                CU1.Text = (Convert.ToInt32(LecU1.Text) + Convert.ToInt32(LabU1.Text)).ToString();
            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Quiz_Load_2(object sender, EventArgs e)
        {
            connection.Open();
            sql = "SELECT * FROM assessmentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();
            dset = new DataSet();
            adaptersql.Fill(dset, "assessmentTbl");

            connection.Close();

            // extra
            StudYearLevel.Items.Add("1st Year");
            StudYearLevel.Items.Add("2nd Year");
            StudYearLevel.Items.Add("3rd Year");
            StudYearLevel.Items.Add("4th Year");

            StudScholar.Items.Add("Academic Scholar");
            StudScholar.Items.Add("None");

            // question 2 a.
            StudProgram.Items.Add("BS Information Technology");
            StudProgram.Items.Add("BS Computer Engineering");
            StudProgram.Items.Add("BS Electrical Engineering");
            StudProgram.Items.Add("BS Computer Science");
            StudProgram.Items.Add("BS Mechanical Engineering");
            StudProgram.Items.Add("BS Industrial Engineering");


            // set other school fees
            textBox6.Text = CompLabFee.ToString();
            textBox5.Text = SAPFee.ToString();
            textBox3.Text = CISCOLabFee.ToString();
            textBox7.Text = ExamBookletFee.ToString();

            // m.
            StudMode.Items.Add("Installment");
            textBox13.Text = "Installment";
            textBox11.Text = "8000";
        }

        private void StudName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_clrstudentinfo_Click_1(object sender, EventArgs e)
        {
            StudName.Clear();
            StudNo.Clear();
            StudProgram.SelectedIndex = -1;
            StudYearLevel.SelectedIndex = -1;
            StudProgram.SelectedIndex = -1;
            StudScholar.SelectedIndex = -1;
        }

        private void btn_ClearScheduleOfCourses_Click_1(object sender, EventArgs e)
        {
            // clear all course code
            CC1.Clear();
            CC2.Clear();
            CC3.Clear();
            CC4.Clear();
            CC5.Clear();
            CC6.Clear();
            CC7.Clear();

            // Clear all section
            Sec1.Clear();
            Sec2.Clear();
            Sec3.Clear();
            Sec4.Clear();
            Sec5.Clear();
            Sec6.Clear();
            Sec7.Clear();

            // clear all desc
            Desc1.Clear();
            Desc2.Clear();
            Desc3.Clear();
            Desc4.Clear();
            Desc5.Clear();
            Desc6.Clear();
            Desc7.Clear();

            // clear all lec
            LecU1.Clear();
            LecU2.Clear();
            LecU3.Clear();
            LecU4.Clear();
            LecU5.Clear();
            LecU6.Clear();
            LecU7.Clear();

            // clear all lab
            LabU1.Clear();
            LabU2.Clear();
            LabU3.Clear();
            LabU4.Clear();
            LabU5.Clear();
            LabU6.Clear();
            LabU7.Clear();

            // Clear all credit unit
            CU1.Clear();
            CU2.Clear();
            CU3.Clear();
            CU4.Clear();
            CU5.Clear();
            CU6.Clear();
            CU7.Clear();
            txtbox_totalcreditunit.Clear();

            // clear all time
            Time1.Clear();
            Time2.Clear();
            Time3.Clear();
            Time4.Clear();
            Time5.Clear();
            Time6.Clear();
            Time7.Clear();

            // clear all day
            Day1.Clear();
            Day2.Clear();
            Day3.Clear();
            Day4.Clear();
            Day5.Clear();
            Day6.Clear();
            Day7.Clear();

            // clear all room
            Room1.Clear();
            Room2.Clear();
            Room3.Clear();
            Room4.Clear();
            Room5.Clear();
            Room6.Clear();
            Room7.Clear();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            sql = "UPDATE assessmentTbl SET StudentName = '" + StudName.Text + "', StudentProgram = '" + StudProgram.Text + "', DateEnrolled = '" + StudDateEnrolled.Text + "', StudentNo = '" + StudNo.Text + "', YearLevel = '" + StudYearLevel.Text + "', Scholar = '" + StudScholar.Text + "', TotalCredUnits = '" + txtbox_totalcreditunit.Text + "', TotalTuitionFee = '" + textBox3.Text + "', MiscellaneousFee = '" + textBox4.Text + "', TotalOtherFee = '" + textBox9.Text + " ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT *FROM assessmentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "assessmentTbl");

            connection.Close();
        }

        private void LecU2_TextChanged_1(object sender, EventArgs e)
        {
            if (LecU2.Text != "" && LabU2.Text != "")
            {
                CU2.Text = (Convert.ToInt32(LecU2.Text) + Convert.ToInt32(LabU2.Text)).ToString();
            }
        }

        private void LecU3_TextChanged_1(object sender, EventArgs e)
        {
            if (LecU3.Text != "" && LabU3.Text != "")
            {
                CU3.Text = (Convert.ToInt32(LecU3.Text) + Convert.ToInt32(LabU3.Text)).ToString();
            }
        }

        private void LecU4_TextChanged_1(object sender, EventArgs e)
        {
            if (LecU4.Text != "" && LabU4.Text != "")
            {
                CU4.Text = (Convert.ToInt32(LecU4.Text) + Convert.ToInt32(LabU4.Text)).ToString();
            }
        }

        private void LecU5_TextChanged_1(object sender, EventArgs e)
        {
            if (LecU5.Text != "" && LabU5.Text != "")
            {
                CU5.Text = (Convert.ToInt32(LecU5.Text) + Convert.ToInt32(LabU5.Text)).ToString();
            }
        }

        private void LecU6_TextChanged_1(object sender, EventArgs e)
        {
            if (LecU6.Text != "" && LabU6.Text != "")
            {
                CU6.Text = (Convert.ToInt32(LecU6.Text) + Convert.ToInt32(LabU6.Text)).ToString();
            }
        }

        private void LecU7_TextChanged_1(object sender, EventArgs e)
        {
            if (LecU7.Text != "" && LabU7.Text != "")
            {
                CU7.Text = (Convert.ToInt32(LecU7.Text) + Convert.ToInt32(LabU7.Text)).ToString();
            }
        }

        private void LabU1_TextChanged_1(object sender, EventArgs e)
        {
            if (LecU1.Text != "" && LabU1.Text != "")
            {
                CU1.Text = (Convert.ToInt32(LecU1.Text) + Convert.ToInt32(LabU1.Text)).ToString();
            }
        }

        private void LabU2_TextChanged_1(object sender, EventArgs e)
        {
            if (LecU2.Text != "" && LabU2.Text != "")
            {
                CU2.Text = (Convert.ToInt32(LecU2.Text) + Convert.ToInt32(LabU2.Text)).ToString();
            }
        }

        private void LabU3_TextChanged_1(object sender, EventArgs e)
        {
            if (LecU3.Text != "" && LabU3.Text != "")
            {
                CU3.Text = (Convert.ToInt32(LecU3.Text) + Convert.ToInt32(LabU3.Text)).ToString();
            }
        }

        private void LabU4_TextChanged_1(object sender, EventArgs e)
        {
            if (LecU4.Text != "" && LabU4.Text != "")
            {
                CU4.Text = (Convert.ToInt32(LecU4.Text) + Convert.ToInt32(LabU4.Text)).ToString();
            }
        }

        private void LabU5_TextChanged_1(object sender, EventArgs e)
        {
            if (LecU5.Text != "" && LabU5.Text != "")
            {
                CU5.Text = (Convert.ToInt32(LecU5.Text) + Convert.ToInt32(LabU5.Text)).ToString();
            }
        }

        private void LabU6_TextChanged_1(object sender, EventArgs e)
        {
            if (LecU6.Text != "" && LabU6.Text != "")
            {
                CU6.Text = (Convert.ToInt32(LecU6.Text) + Convert.ToInt32(LabU6.Text)).ToString();
            }
        }

        private void LabU7_TextChanged_1(object sender, EventArgs e)
        {
            if (LecU7.Text != "" && LabU7.Text != "")
            {
                CU7.Text = (Convert.ToInt32(LecU7.Text) + Convert.ToInt32(LabU7.Text)).ToString();
            }
        }

        private void CU1_TextChanged_1(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU2_TextChanged_1(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU3_TextChanged_1(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU4_TextChanged_1(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU5_TextChanged_1(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU6_TextChanged_1(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU7_TextChanged_1(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void Time1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//create database quizDb

//use quizDb

//Go

//create table assessmentTbl (
//Student_Name varchar(max),
//Student_Program varchar(max),
//Date_Enrolled date,
//Student_No INT primary key,
//Year_Level varchar(max),
//Scholar varchar(max),
//Total_Cred_Units varchar(max),
//Total_Tuition_Fee varchar(max),
//Miscellaneous_Fee varchar(max),
//Total_Other_Fee varchar(max),
//);