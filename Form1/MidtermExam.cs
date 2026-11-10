using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class MidtermExam : Form
    {
        
        String connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;

        private double EnvironmentalCharges, MSC, basiccharge, totalchargesbeforetax, governmenttax, totalamountdue, currentcharges, ratecumeter = 23.52
            , consumption;

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();

            sql = "INSERT INTO customerInfoTbl (SOA_No, Statement_of_Monthly_Account, Contact_Account_No, Account_Name, Service_Address, TIN, Rate_Class, Business_Area) VALUES('" + SOAtxt.Text + "','" + SOMAtxt.Text + "','" + txtContract.Text + "','" + txtAccountName.Text + "','" + txtAddress.Text + "','" + txtTIN.Text + "','" + txtRateClass.Text + "','" + txtBusiness.Text + "') ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            //command.ExecuteNonQuery();

            sql = "SELECT * from customerInfoTbl ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "customerInfoTbl");

            SOAtxt.Clear();
            SOMAtxt.Clear();
            txtContract.Clear();
            txtAccountName.Clear();
            txtAddress.Clear();
            txtTIN.Clear();
            txtRateClass.Clear();
            txtBusiness.Clear();

            //connection.Close();

            //connection.Open();

            sql = "INSERT INTO meterTbl (Contact_Account_No, Meter_No, MRU_No, Seq_No, Reading_Date, Present_Reading, Previous_Reading, Consumption) VALUES('" + txtContract.Text + "','" + txtMeterNo.Text + "','" + txtMRU.Text + "','" + txtSeq.Text + "','" + dateTimePicker1.Text + "','" + txtPresent.Text + "','" + txtPrevious.Text + "','" + txtConsumption.Text + "') ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            //command.ExecuteNonQuery();

            sql = "SELECT * from meterTbl ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "meterTbl");

            txtContract.Clear();
            txtMeterNo.Clear();
            txtMRU.Clear();
            txtSeq.Clear();
            txtPresent.Clear();
            txtPrevious.Clear();
            txtConsumption.Clear();

            //connection.Close();

            //connection.Open();

            sql = "INSERT INTO paymentTbl (Contact_Account_No, BILLING_PERIOD, Current_Charges, Basic_Charge, Environmental_Charges, MSC, Total_Current_Charges_Before_Taxes, GovernmentTaxes, Total_Amount_Due, Payment_Due_Date) VALUES('" + txtContract.Text + "','" + dateTimePicker2.Text + "','" + currentchargestxtbox.Text + "','" + basicchargetxtbox.Text + "','" + environmentchargetxtbox.Text + "','" + msctxtbox.Text + "','" + totalchargestaxtxtbox.Text + "','" + governmenttaxtxtbox.Text + "','" + totalamounttxtbox.Text + "','" + txtDueDate + "') ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            //command.ExecuteNonQuery();

            sql = "SELECT * from paymentTbl ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "paymentTbl");

            txtContract.Clear();
            currentchargestxtbox.Clear();
            basicchargetxtbox.Clear();
            environmentchargetxtbox.Clear();
            msctxtbox.Clear();
            totalchargestaxtxtbox.Clear();
            governmenttaxtxtbox.Clear();
            totalamounttxtbox.Clear();
            txtDueDate.Clear();

            //connection.Close();
            //connection.Open();

            sql = "INSERT INTO SaveTbl (Contact_Account_No, Customer_SOA_No, Customer_Name, Customer_Address, Meter_No, Reading_Date, Consumption, Billing_Period, Total_Amount_Due, Payment_Due_Date) VALUES('" + txtContract.Text + "','" + SOAtxt.Text + "','" + txtAccountName.Text + "','" + txtAddress.Text + "','" + txtMeterNo.Text + "','" + dateTimePicker1.Text + "','" + txtConsumption.Text + "','" + dateTimePicker2.Text + "','" + totalamounttxtbox.Text + "','" + txtDueDate + "') ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * from SaveTbl ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "SaveTbl");

            txtContract.Clear();
            SOAtxt.Clear();
            txtAccountName.Clear();
            txtAddress.Clear();
            txtMeterNo.Clear();
            txtConsumption.Clear();
            totalamounttxtbox.Clear();
            txtDueDate.Clear();

            connection.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void txtMSC_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //basiccharge = Convert.ToDouble(basicchargetxtbox.Text);
            //EnvironmentalCharges = Convert.ToDouble(environmentchargetxtbox.Text);
            MSC = Convert.ToDouble(msctxtbox.Text);
            consumption = Convert.ToDouble(txtConsumption.Text);

            basiccharge = (ratecumeter * consumption);
            basicchargetxtbox.Text = basiccharge.ToString("n");

            EnvironmentalCharges = (basiccharge * 0.20);
            environmentchargetxtbox.Text = EnvironmentalCharges.ToString("n");

            totalchargesbeforetax = (basiccharge + EnvironmentalCharges + MSC);
            totalchargestaxtxtbox.Text = totalchargesbeforetax.ToString("n");

            totalchargesbeforetax = Convert.ToDouble(totalchargestaxtxtbox.Text);
            governmenttax = (totalchargesbeforetax * 0.025);
            governmenttaxtxtbox.Text = governmenttax.ToString("n");

            governmenttax = Convert.ToDouble(governmenttaxtxtbox.Text);
            totalamountdue = (totalchargesbeforetax + governmenttax);
            totalamounttxtbox.Text = totalamountdue.ToString("n");

            currentcharges = totalamountdue;
            currentchargestxtbox.Text = currentcharges.ToString("n");

        }

        public MidtermExam()
        {
            connectionString = "Data Source = C203-07; Initial Catalog = WaterBillDB; user id = sa; password = B1Admin123@";
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void Lab7_Maynilad_Load(object sender, EventArgs e)
        {
            MSC = 1.53;
            msctxtbox.Text = MSC.ToString("n");

            connection.Open();
            sql = "SELECT * FROM customerInfoTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();
            dset = new DataSet();
            adaptersql.Fill(dset, "customerInfoTbl");
            //dataGridView1.DataSource = dset.Tables[0];
            //connection.Close();

            //connection.Open();
            sql = "SELECT * FROM meterTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();
            dset = new DataSet();
            adaptersql.Fill(dset, "meterTbl");
            //dataGridView1.DataSource = dset.Tables[0];
            //connection.Close();

            //connection.Open();
            sql = "SELECT * FROM paymentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();
            dset = new DataSet();
            adaptersql.Fill(dset, "paymentTbl");
            //dataGridView1.DataSource = dset.Tables[0];
            //connection.Close();

            //connection.Open();
            sql = "SELECT * FROM SaveTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();
            dset = new DataSet();
            adaptersql.Fill(dset, "SaveTbl");
            //dataGridView1.DataSource = dset.Tables[0];
            connection.Close();
        }
    }
}
