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
    public partial class Preview : Form
    {
        DataTable table = new DataTable();
        String connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;
        public Preview()
        {
            connectionString = "Data Source = C203-07; Initial Catalog = createDb; user id = sa; password = B1Admin123@";
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void Preview_Load(object sender, EventArgs e)
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
            dataGridView1.DataSource = dset.Tables[0];
            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();
            bool found = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow) continue;

                string studentName = dataGridView1.Rows[i].Cells["Firstname"].Value?.ToString() ?? "";

                if (studentName.Equals(searchValue,
                    StringComparison.OrdinalIgnoreCase))

                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;

                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells["Firstname"];

                    MessageBox.Show(
                        "Record found at row" + (i + 1),
                        "Sequential Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show(
                    "Record not found.",
                    "Sequential Search",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchProduct = txtSearch.Text.Trim();
            bool found = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;
                string id =
                dataGridView1.Rows[i].Cells["Middlename"].Value?.ToString() ?? "";

                if (id.Equals(searchProduct,
                StringComparison.OrdinalIgnoreCase))
                {
                    string lastname =
                    dataGridView1.Rows[i].Cells["Lastname"].Value?.ToString() ?? "";

                    string jobtitle =
                    dataGridView1.Rows[i].Cells["Job_Title"].Value?.ToString() ?? "";

                    string department =
                    dataGridView1.Rows[i].Cells["Department"].Value?.ToString() ?? "";



                    MessageBox.Show(
                        "employee found!\n\n" +
                        "Last Name: " + lastname +
                        "\nJob Title: " + jobtitle +
                        "\nDepartment: " + department
                    );

                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;

                    found = true;
                    break;
                }
            }
            if (!found)
                MessageBox.Show("Product not found.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string searchProduct = txtSearch.Text.Trim();
            bool found = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;
                string id =
                dataGridView1.Rows[i].Cells["Lastname"].Value?.ToString() ?? "";

                if (id.Equals(searchProduct,
                StringComparison.OrdinalIgnoreCase))
                {
                    string lastname =
                    dataGridView1.Rows[i].Cells["Firstname"].Value?.ToString() ?? "";

                    string jobtitle =
                    dataGridView1.Rows[i].Cells["Middlename"].Value?.ToString() ?? "";

                    string department =
                    dataGridView1.Rows[i].Cells["Lastname"].Value?.ToString() ?? "";



                    MessageBox.Show(
                        "employee found!\n\n" +
                        "First Name: " + lastname +
                        "\nMiddle Name: " + jobtitle +
                        "\nLast Name: " + department
                    );

                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;

                    found = true;
                    break;
                }
            }
            if (!found)
                MessageBox.Show("Product not found.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();
            bool found = false;

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                if (dataGridView1.Rows[row].IsNewRow)
                    continue;

                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                    string value =
                    dataGridView1.Rows[row].Cells[col].Value?.ToString() ?? "";

                    if (value.Equals(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        dataGridView1.ClearSelection();

                        dataGridView1.Rows[row].Selected = true;
                        dataGridView1.CurrentCell =
                            dataGridView1.Rows[row].Cells[col];

                        MessageBox.Show("Record found at row " + (row + 1));

                        found = true;
                        break;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string searchCourse = txtSearch.Text.Trim();
            int count = 0;

            dataGridView1.ClearSelection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;

                string course =
                dataGridView1.Rows[i].Cells["Department"].Value?.ToString() ?? "";

                if (course.Equals(searchCourse,
                 StringComparison.OrdinalIgnoreCase))
                {
                    dataGridView1.Rows[i].Selected = true;
                    count++;


                }
            }
            if (count > 0)
            {
                MessageBox.Show(count + "matching record(s) found.");


            }
            else
            {
                MessageBox.Show(count + "No matching record(s) found.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();
            bool found = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow) continue;

                string studentName = dataGridView1.Rows[i].Cells["Employee_id"].Value?.ToString() ?? "";

                if (studentName.Equals(searchValue,
                    StringComparison.OrdinalIgnoreCase))

                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;

                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells["Employee_id"];

                    MessageBox.Show(
                        "Record found at row" + (i + 1),
                        "Sequential Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show(
                    "Record not found.",
                    "Sequential Search",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string target = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(target))
            {
                MessageBox.Show("Please enter a data");
                return;
            }

            bool found = false;

            txtSearch.Clear();


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        string cellValue = cell.Value.ToString().Trim();

                        if (cellValue.ToLower().Contains(target.ToLower()))
                        {
                            dataGridView1.ClearSelection();
                            row.Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;

                            MessageBox.Show("Employee found at record" + (row.Index + 1));
                            found = true; break;
                        }
                    }
                }
            }
        }
                  
    }
}
    
