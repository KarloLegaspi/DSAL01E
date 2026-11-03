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
    public partial class Lab7_Maynilad : Form
    {
        
        String connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;

        private double EnvironmentalCharges, MSC, basiccharge, totalchargesbeforetax, governmenttax, totalamountdue, currentcharges, ratecumeter = 23.52
            , consumption;

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

        public Lab7_Maynilad()
        {
            connectionString = "Data Source = C203-07; Initial Catalog = MayniladDb; user id = sa; password = B1Admin123@";
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void Lab7_Maynilad_Load(object sender, EventArgs e)
        {
            MSC = 1.53;
            msctxtbox.Text = MSC.ToString("n");
        }
    }
}
