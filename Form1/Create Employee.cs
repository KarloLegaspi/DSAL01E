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
    public partial class create : Form
    {
        String picturepath;
        String connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;

        public create()
        {
            connectionString = "Data Source = C203-07; Initial Catalog = createDb; user id = sa; password = B1Admin123@";
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            sql = "SELECT * FROM employeeTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();
            dset = new DataSet();
            adaptersql.Fill(dset, "employeeTbl");

            suffixCombobox.Items.Add("Jr.");
            suffixCombobox.Items.Add("Sr.");

            salutationCombobox.Items.Add("Mr.");
            salutationCombobox.Items.Add("Ms.");
            salutationCombobox.Items.Add("Mrs.");

            jobtitleCombobox.Items.Add("Software Engineer");
            jobtitleCombobox.Items.Add("HR Officer");
            jobtitleCombobox.Items.Add("Accountant");
            jobtitleCombobox.Items.Add("Marketing Specialist");
            jobtitleCombobox.Items.Add("Nurse");
            jobtitleCombobox.Items.Add("Project Manager");
            jobtitleCombobox.Items.Add("Teacher");
            jobtitleCombobox.Items.Add("Civil Engineer");

            departmentCombobox.Items.Add("IT");
            departmentCombobox.Items.Add("HR");
            departmentCombobox.Items.Add("Finance");
            departmentCombobox.Items.Add("Marketing");
            departmentCombobox.Items.Add("Medical");
            departmentCombobox.Items.Add("Operations");
            departmentCombobox.Items.Add("Sales");
            departmentCombobox.Items.Add("Academics");
            departmentCombobox.Items.Add("Engineering");
            departmentCombobox.Items.Add("Customer Service");
            departmentCombobox.Items.Add("Business");

            statusCombobox.Items.Add("Active");
            statusCombobox.Items.Add("Probation");

            connection.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            sql = "INSERT INTO employeeTbl (Employee_id, Firstname, Middlename, Lastname, Suffix, Address, Salutation, Brgy, City, Province, Zip, Birthday, Nationality, Email, Phone_No, Job_Title, Department, Status) VALUES('" + employeeidTxtbox.Text + "','" + firstnameTxtbox.Text + "','" + middlenameTxtbox.Text + "','" + lastnameTxtbox.Text + "','" + suffixCombobox.Text + "','" + addressTxtbox.Text + "','" + salutationCombobox.Text + "','" + brgyTxtbox.Text + "','" + cityTxtbox.Text + "','" + provinceTxtbox.Text + "','" + zipTxtbox.Text + "','" + birthdayTxtbox.Text + "','" + nationalityTxtbox.Text + "','" + emailTxtbox.Text + "','" + phone_noTxtbox.Text + "','" + jobtitleCombobox.Text + "','" + departmentCombobox.Text + "','" + statusCombobox.Text + "') ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * from employeeTbl ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "employeeTbl");

            pictureBox1.Image = Image.FromFile("C:\\Users\\C203-07\\Downloads\\user.png");

            employeeidTxtbox.Clear();
            firstnameTxtbox.Clear();
            middlenameTxtbox.Clear();
            lastnameTxtbox.Clear();
            suffixCombobox.Items.Clear();
            addressTxtbox.Clear();
            brgyTxtbox.Clear();
            cityTxtbox.Clear();
            provinceTxtbox.Clear();
            zipTxtbox.Clear();
            birthdayTxtbox.Clear();
            nationalityTxtbox.Clear();
            phone_noTxtbox.Clear();
            emailTxtbox.Clear();
            salutationCombobox.Items.Clear();
            jobtitleCombobox.Items.Clear();
            departmentCombobox.Items.Clear();
            statusCombobox.Items.Clear();

            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";

            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            picturepath = openFileDialog1.FileName;
            picturpathTxtbox.Text = picturepath;
        }

        private void jobtitleTxtbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void picturpathTxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
