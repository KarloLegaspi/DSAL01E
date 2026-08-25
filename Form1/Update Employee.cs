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
        pos_dbconnection posdb_connect = new pos_dbconnection();
        private string picpath;
        private Image pic;
        public Form2()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // UPDATE Button Logic
            try
            {
                // Update Name Table
                posdb_connect.pos_sql = "UPDATE Employee_Tbl SET name1 = '" + textBox1.Text + "', name2 = '" + textBox2.Text + "', name3 = '" + textBox2.Text + "', name4 = '" + textBox2.Text + "', name5 = '" + textBox2.Text + "', name6 = '" + textBox2.Text + "', name7 = '" + textBox2.Text + "', name8 = '" + textBox2.Text + "', name9 = '" + textBox2.Text + "', name10 = '" + textBox2.Text + "', name11 = '" + textBox2.Text + "', name12 = '" + textBox2.Text + "', name13 = '" + textBox2.Text + "', name14 = '" + textBox1.Text + "', name15 = '" + textBox1.Text + "', name16 = '" + textBox1.Text + "', name17 = '" + textBox1.Text + "', name18 = '" + textBox1.Text + "', name19 = '" + textBox1.Text + "', name20 = '" + textBox1.Text + "' WHERE pos_id = '" + comboBox1.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();
                

                MessageBox.Show("Record updated successfully!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error during update. Please check database connection.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
