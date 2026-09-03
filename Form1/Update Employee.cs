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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form1
{
    public partial class Form2 : Form
    {
        String picturepath;
        String connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;

        public Form2()
        {
            connectionString = "Data Source = C203-07; Initial Catalog = createDb; user id = sa; password = B1Admin123@";
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
           
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "UPDATE employeeTbl SET Firstname = '" + firstnameTxtbox.Text + "', Middlename = '" + middlenameTxtbox.Text + "', Lastname = '" + lastnameTxtbox.Text + "', Suffix = '" + suffixTxtbox.Text + "', Address = '" + addressTxtbox.Text + "', Brgy = '" + brgyTxtbox.Text + "', City = '" + cityTxtbox.Text + "', Province = '" + provinceTxtbox.Text + "', Zip = '" + zipTxtbox.Text + "', Birthday = '" + birthdayTxtbox.Text + "', Nationality = '" + nationalityTxtbox.Text + "', Phone_No = '" + phone_noTxtbox.Text + "', Email = '" + emailTxtbox.Text + "', Job_Title = '" + jobtitleCombobox.Text + "', Department = '" + departmentCombobox.Text + "', Status = '" + statusCombobox.Text + "' picturepath = '" + picturpathTxtbox.Text + "' WHERE employeeid = '" + employeeidTxtbox.Text + " ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT *FROM employeeTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "employeeTbl");

            
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "DELETE FROM employeeTbl WHERE Employee_id = '" + employeeidTxtbox.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.DeleteCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM employeeTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();
            dset = new DataSet();
            adaptersql.Fill(dset, "employeeTbl");

            connection.Close();

            employeeidTxtbox.Clear();
            firstnameTxtbox.Clear();
            middlenameTxtbox.Clear();
            lastnameTxtbox.Clear();
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

            picturpathTxtbox.Text = "C:\\Users\\C203-07\\Downloads\\user.png";
            pictureBox1.Image = Image.FromFile(picturpathTxtbox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";

            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            picturepath = openFileDialog1.FileName;
            picturpathTxtbox.Text = picturepath;
        }
    }
}
