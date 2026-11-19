using Form1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;
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
        String picturepath;
        String connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;

        DataTable table = new DataTable();
        public Maynilad()
        {
            connectionString = "Data Source=C203-07; Initial Catalog=WaterBillDB; user id=SA; password=B1Admin123@; TrustServerCertificate=True";
            connection = new SqlConnection(connectionString);

            InitializeComponent();


        }
        private void BubbleSort(IList records, Comparison<object> compare)
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

        private void SelectionSort(IList records, Comparison<object> compare)
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
        private void InsertionSort(IList records, Comparison<object> compare)
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

        private void MergeSort(IList records, int left, int right, Comparison<object> compare)
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
        private void QuickSort(IList records, int low, int high, Comparison<object> compare)
        {
            if (low >= high)
                return;

            int pivotIndex = Partition(
                records, low, high, compare);

            QuickSort(records, low, pivotIndex - 1, compare);
            QuickSort(records, pivotIndex + 1, high, compare);
        }

        private int Partition(IList records, int low, int high, Comparison<object> compare)
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
        // Your columns are VARCHAR, so this compares numbers as numbers and dates as dates
        // (otherwise "9" would sort after "100").
        private static int SmartCompare(object x, object y)
        {
            if (x == null || x == DBNull.Value)
                return (y == null || y == DBNull.Value) ? 0 : -1;

            if (y == null || y == DBNull.Value)
                return 1;

            if (x is string && y is string)
            {
                string sx = ((string)x).Trim();
                string sy = ((string)y).Trim();

                decimal dx, dy;
                if (decimal.TryParse(sx, NumberStyles.Any, CultureInfo.InvariantCulture, out dx) &&
                    decimal.TryParse(sy, NumberStyles.Any, CultureInfo.InvariantCulture, out dy))
                    return dx.CompareTo(dy);

                DateTime tx, ty;
                if (DateTime.TryParse(sx, CultureInfo.InvariantCulture, DateTimeStyles.None, out tx) &&
                    DateTime.TryParse(sy, CultureInfo.InvariantCulture, DateTimeStyles.None, out ty))
                    return tx.CompareTo(ty);

                return string.Compare(sx, sy, StringComparison.OrdinalIgnoreCase);
            }

            return Comparer.DefaultInvariant.Compare(x, y);
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

            comboBox1.Items.Add("Bubble Sort");
            comboBox1.Items.Add("Selection Sort");
            comboBox1.Items.Add("Insertion Sort");
            comboBox1.Items.Add("Merge Sort");
            comboBox1.Items.Add("Quick Sort");

            comboBox2.Items.Add("Ascending");
            comboBox2.Items.Add("Descending");

            comboBox3.Items.Add("Statement of Account");
            comboBox3.Items.Add("Account Name");
            comboBox3.Items.Add("Service Address");
            comboBox3.Items.Add("Meter No.");
            comboBox3.Items.Add("Read Date");
            comboBox3.Items.Add("Consumption");
            comboBox3.Items.Add("Bill Period Input");
            comboBox3.Items.Add("Bill Period Output");
            comboBox3.Items.Add("Total Amount Due");

        }

        private void MSC_TextChanged(object sender, EventArgs e)
        {

        }
        private double rate = 23.52, msc = 1.53;
        private void button1_Click(object sender, EventArgs e)
        {
            double cons = Convert.ToDouble(Present.Text) - Convert.ToDouble(Previous.Text);
            double basic = Math.Round(rate * cons, 2);
            double env = Math.Round(basic * 0.20, 2);
            double before = basic + env + msc;
            double tax = Math.Round(before * 0.025, 2);
            double total = before + tax;

            Consumption.Text = cons.ToString();
            Basic.Text = basic.ToString("n");
            Env.Text = env.ToString("n");
            MSC.Text = msc.ToString("n");
            Beforetax.Text = before.ToString("n");
            GovTax.Text = tax.ToString("n");
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

        private void button7_Click(object sender, EventArgs e)
        {
            // 1. Get the DataTable behind the grid
            object source = dataGridView1.DataSource;
            DataTable dt = null;

            if (source is DataTable)
            {
                dt = (DataTable)source;
            }
            else if (source is BindingSource)
            {
                BindingSource b = (BindingSource)source;
                dt = b.DataSource as DataTable;
                if (dt == null && b.List is DataView)
                    dt = ((DataView)b.List).Table;
            }
            else if (source is DataView)
            {
                dt = ((DataView)source).Table;
            }

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No records found.");
                return;
            }

            // 2. Pick which column to sort by.
            //    Try BOTH the raw DB name AND the alias used by waterbillview.
            string[] candidates;
            switch (comboBox3.Text)                          // ✅ was comboBox2
            {
                case "Statement of Account": candidates = new[] { "soa_number", "SOA Number" }; break;
                case "Account Name": candidates = new[] { "account_name", "Customer Name" }; break;
                case "Service Address": candidates = new[] { "service_address", "Customer Address" }; break;
                case "Meter No.": candidates = new[] { "meter_no", "Meter No." }; break;
                case "Read Date": candidates = new[] { "reading_date", "Reading Date" }; break;
                case "Consumption": candidates = new[] { "consumption", "Consumption" }; break;
                case "Bill Period Input": candidates = new[] { "billing_period", "Billing Period" }; break;
                case "Bill Period Output": candidates = new[] { "billing_period", "Billing Period" }; break;
                case "Total Amount Due": candidates = new[] { "total_amount_due", "Total Amount Due" }; break;
                default:
                    MessageBox.Show("Please select a valid sort field.");
                    return;
            }

            // 3. Find the first candidate that actually exists
            string column = null;
            foreach (string c in candidates)
                if (dt.Columns.Contains(c)) { column = c; break; }

            if (column == null)
            {
                string names = string.Join(", ", dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName));
                MessageBox.Show("Column '" + candidates[0] + "' not found.\nAvailable:\n" + names);
                return;
            }

            // 4. Ascending / Descending
            bool descending = comboBox2.Text == "Descending";          // ✅ was comboBox3

            // 5. Comparison (uses your existing SmartCompare)
            Comparison<object> compare = (a, b) =>
            {
                object x = ((DataRow)a)[column];
                object y = ((DataRow)b)[column];
                int result = SmartCompare(x, y);
                return descending ? -result : result;
            };

            // 6. Copy to a List<DataRow> so we can swap by index
            List<DataRow> rows = new List<DataRow>(dt.Rows.Count);
            foreach (DataRow r in dt.Rows) rows.Add(r);

            // 7. Run the chosen algorithm
            switch (comboBox1.Text)
            {
                case "Bubble Sort": BubbleSort(rows, compare); break;
                case "Selection Sort": SelectionSort(rows, compare); break;
                case "Insertion Sort": InsertionSort(rows, compare); break;
                case "Merge Sort": MergeSort(rows, 0, rows.Count - 1, compare); break;
                case "Quick Sort": QuickSort(rows, 0, rows.Count - 1, compare); break;
                default:
                    MessageBox.Show("Please select a sorting algorithm.");
                    return;
            }

            // 8. Rebuild a fresh DataTable in sorted order and rebind
            DataTable sorted = dt.Clone();
            foreach (DataRow r in rows) sorted.ImportRow(r);
            dataGridView1.DataSource = sorted;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
