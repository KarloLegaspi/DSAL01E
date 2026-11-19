using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Form1
{
    public partial class Maynilad : Form
    {
        private double present, previous, rate = 23.52, consumption, basic, env, msc = 1.53, beforetax, govtax, total;
        String picturepath;
        String connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;

        private void button7_Click(object sender, EventArgs e)
        {
            object source = dataGridView1.DataSource;

            if (source == null)
            {
                MessageBox.Show("No records found.");
                return;
            }

            BindingSource bs = source as BindingSource;

            if (bs == null)
            {
                bs = new BindingSource();
                bs.DataSource = source;
                dataGridView1.DataSource = bs;
            }

            IList records = bs.List;

            if (records.Count == 0 ||
        records.IsReadOnly ||
        records.IsFixedSize)
            {
                MessageBox.Show("DataSource cannot be sorted directly.");
                return;
            }

            string column = "Grade";
            PropertyDescriptor property = TypeDescriptor.GetProperties(records[0]).Find(column, true);

            if (property == null)
            {
                MessageBox.Show("Sorting field not found.");
                return;
            }

            Comparison<object> compare = (a, b) =>
            {
                object x = property.GetValue(a);
                object y = property.GetValue(b);

                if (x == null || x == DBNull.Value)
                    return y == null || y == DBNull.Value ? 0 : -1;

                if (y == null || y == DBNull.Value)
                    return 1;

                return Comparer.DefaultInvariant.Compare(x, y);
            };

            // Apply the selected algorithm
            bool previous = bs.RaiseListChangedEvents;
            bs.RaiseListChangedEvents = false;

            try
            {
                switch (comboBox1.Text)
                {
                    case "Bubble Sort":
                        BubbleSort(records, compare);
                        break;

                    case "Selection Sort":
                        SelectionSort(records, compare);
                        break;

                    case "Insertion Sort":
                        InsertionSort(records, compare);
                        break;

                    case "Merge Sort":
                        MergeSort(records, 0,
                            records.Count - 1, compare);
                        break;

                    case "Quick Sort":
                        QuickSort(records, 0,
                            records.Count - 1, compare);
                        break;
                }
            }
            finally
            {
                bs.RaiseListChangedEvents = previous;

                if (previous)
                    bs.ResetBindings(false);
            }
        }
    

       

        SqlDataAdapter adaptersql;
        string sql = null;

        DataTable table = new DataTable();
        public Maynilad()
        {
            connectionString = "Data Source=C203-07; Initial Catalog=WaterBillDB; user id=SA; password=B1Admin123@; TrustServerCertificate=True";
            connection = new SqlConnection(connectionString);

            InitializeComponent();

        }

        private void Maynilad_Load(object sender, EventArgs e)
        {
            connection.Open();
            sql = "SELECT * FROM customerInfoTbl c " +
                  "INNER JOIN meterTbl m ON c.soa_number = m.soa_number " +
                  "INNER JOIN paymentTbl p ON c.soa_number = p.soa_number";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();
            dset = new DataSet();
            adaptersql.Fill(dset, "waterbillall");
            dataGridView1.DataSource = dset.Tables["waterbillall"];
            connection.Close();

            //sorting algorithm
            comboBox1.Items.Add("Bubble Sort");
            comboBox1.Items.Add("Selection Sort");
            comboBox1.Items.Add("Insertion Sort");
            comboBox1.Items.Add("Merge Sort");
            comboBox1.Items.Add("Quick Sort");
            //sort by
            comboBox2.Items.Add("Statement of Account");
            comboBox2.Items.Add("Account Name");
            comboBox2.Items.Add("Service Address");
            comboBox2.Items.Add("Meter No.");
            comboBox2.Items.Add("Read Date");
            comboBox2.Items.Add("Consumption");
            comboBox2.Items.Add("Bill Period Input");
            comboBox2.Items.Add("Bill Period Output");
            comboBox2.Items.Add("Total Amount Due");
            //sorting order
            comboBox3.Items.Add("Ascending");
            comboBox3.Items.Add("Descending");
        }

        private void BubbleSort(
        IList records,
        Comparison<object> compare)
        {
            int n = records.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (compare(records[j], records[j + 1]) > 0)
                    {
                        object temp = records[j];
                        records[j] = records[j + 1];
                        records[j + 1] = temp;
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SelectionSort(
        IList records,
        Comparison<object> compare)
        {
            int n = records.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (compare(records[j], records[min]) < 0)
                    {
                        min = j;
                    }
                }

                object temp = records[i];
                records[i] = records[min];
                records[min] = temp;
            }
        }

        private void InsertionSort(
        IList records,
        Comparison<object> compare)
        {
            for (int i = 1; i < records.Count; i++)
            {
                object key = records[i];

                int j = i - 1;

                while (j >= 0 &&
                    compare(records[j], key) > 0)
                {
                    records[j + 1] = records[j];
                    j--;
                }

                records[j + 1] = key;
            }
        }

        private void MergeSort(
        IList records,
        int left,
        int right,
        Comparison<object> compare)
        {
            if (left >= right)
                return;

            int mid = left + (right - left) / 2;

            MergeSort(records, left, mid, compare);
            MergeSort(records, mid + 1, right, compare);

            object[] temp = new object[right - left + 1];

            int i = left;
            int j = mid + 1;
            int k = 0;

            while (i <= mid && j <= right)
            {
                if (compare(records[i], records[j]) <= 0)
                    temp[k++] = records[i++];
                else
                    temp[k++] = records[j++];
            }

            while (i <= mid)
                temp[k++] = records[i++];

            while (j <= right)
                temp[k++] = records[j++];

            for (int x = 0; x < temp.Length; x++)
            {
                records[left + x] = temp[x];
            }
        }
        private void QuickSort(
        IList records,
        int low,
        int high,
        Comparison<object> compare)
        {
            if (low >= high)
                return;

            int pivotIndex = Partition(
                records, low, high, compare);

            QuickSort(records, low, pivotIndex - 1, compare);
            QuickSort(records, pivotIndex + 1, high, compare);
        }

        private int Partition(
            IList records,
            int low,
            int high,
            Comparison<object> compare)
        {
            object pivot = records[high];

            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (compare(records[j], pivot) <= 0)
                {
                    i++;

                    object temp = records[i];
                    records[i] = records[j];
                    records[j] = temp;
                }
            }

            object swap = records[i + 1];
            records[i + 1] = records[high];
            records[high] = swap;

            return i + 1;
        }
        private void MSC_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            present = Convert.ToDouble(Present.Text);
            previous = Convert.ToDouble(Previous.Text);

            consumption = present - previous;

            basic = rate * consumption;
            env = basic * 0.20;
            beforetax = basic + env + msc;
            govtax = beforetax * 0.025;
            total = beforetax + govtax;

            Consumption.Text = consumption.ToString();
            Basic.Text = basic.ToString("n");
            Env.Text = env.ToString("n");
            MSC.Text = msc.ToString("n");
            Beforetax.Text = beforetax.ToString("n");
            GovTax.Text = govtax.ToString("n");
            Total.Text = total.ToString("n");
            Current.Text = total.ToString("n");

            Mayniladreceipt receipt = new Mayniladreceipt(new string[] {
                textBox1.Text,
                textBox2.Text,
                Contract.Text,
                AccountName.Text,
                Address.Text,
                TIN.Text,
                RateClass.Text,
                Business.Text,
                MeterNo.Text,
                MRU.Text,
                Seq.Text,
                ReadingDate.Text,
                Present.Text,
                Previous.Text,
                Consumption.Text,
                BillingPeriod.Text,
                Current.Text,
                Basic.Text,
                Env.Text,
                MSC.Text,
                Beforetax.Text,
                GovTax.Text,
                Total.Text,
                DueDate.Text
            });
            receipt.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();

            sql = "INSERT INTO customerInfoTbl (soa_number, statement_account, contract_account_no, account_name, service_address, tin, rate_class, business_area) " +

                  "VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + Contract.Text + "', '" + AccountName.Text + "', '" + Address.Text + "', '" + TIN.Text + "', '" + RateClass.Text + "', '" + Business.Text + "') ";

            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            sql = "INSERT INTO meterTbl (soa_number, meter_no, mru_no, seq_no, reading_date, present_reading, previous_reading, consumption) " +

                  "VALUES('" + textBox1.Text + "', '" + MeterNo.Text + "', '" + MRU.Text + "', '" + Seq.Text + "', '" + ReadingDate.Text + "', '" + Present.Text + "', '" + Previous.Text + "', '" + Consumption.Text + "') ";

            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            sql = "INSERT INTO paymentTbl (soa_number, billing_period, current_charges, basic_charge, environmental_charge, maintenance_charge, total_before_tax, government_taxes, total_amount_due, payment_due_date) " +

                  "VALUES('" + textBox1.Text + "', '" + BillingPeriod.Text + "', '" + Current.Text + "', '" + Basic.Text + "', '" + Env.Text + "', '" + MSC.Text + "', '" + Beforetax.Text + "', '" + GovTax.Text + "', '" + Total.Text + "', '" + DueDate.Text + "') ";

            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM waterbillview ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "waterbillview");
            dataGridView1.DataSource = dset.Tables["waterbillview"];

            textBox1.Clear();
            textBox2.Clear();
            Contract.Clear();
            AccountName.Clear();
            Address.Clear();
            TIN.Clear();
            RateClass.Clear();
            Business.Clear();
            MeterNo.Clear();
            MRU.Clear();
            Seq.Clear();
            ReadingDate.Clear();
            Present.Clear();
            Previous.Clear();
            Consumption.Clear();
            BillingPeriod.Clear();
            Current.Clear();
            Basic.Clear();
            Env.Clear();
            MSC.Clear();
            Beforetax.Clear();
            GovTax.Clear();
            Total.Clear();
            DueDate.Clear();

            connection.Close();
        }
    }
}