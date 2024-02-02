using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Invoice
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection("Server=localhost; Port=5432; Database=invoice; User Id=postgres; Password=123");
            npgsqlConnection.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand();
            npgsqlCommand.Connection = npgsqlConnection;
            npgsqlCommand.CommandType = CommandType.Text;
            npgsqlCommand.CommandText = "select * from product_list";
            NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();
            if (npgsqlDataReader != null )
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(npgsqlDataReader);
                dataGridView2.DataSource = dataTable;

                //dataGridView2.Columns["Name"].Width = 300;
            }
            npgsqlCommand.Dispose();
            npgsqlConnection.Close();
        }

        string warehouse_name = "";
        private string sender_company_name = "";
        private string sender_phone_number = "";
        private string sender_adress = "";
        private string sender_email = "";
        private string recipient_company_name = "";
        private string recipient_phone_number = "";
        private string recipient_adress = "";
        private string recipient_email = "";

        private void warehouse_name_label_TextChanged(object sender, EventArgs e)
        {
            warehouse_name = warehouse_name_label.Text;
        }

        private void sender_company_name_label_TextChanged(object sender, EventArgs e)
        {
            sender_company_name = sender_company_name_label.Text;
        }

        private void sender_phone_number_label_TextChanged(object sender, EventArgs e)
        {
            sender_phone_number = sender_phone_number_label.Text;
        }

        private void sender_adress_label_TextChanged(object sender, EventArgs e)
        {
            sender_adress = sender_adress_label.Text;
        }

        private void sender_email_label_TextChanged(object sender, EventArgs e)
        {
            sender_email = sender_email_label.Text;
        }

        private void recipient_company_name_label_TextChanged(object sender, EventArgs e)
        {
            recipient_company_name = recipient_company_name_label.Text;
        }

        private void recipient_phone_number_label_TextChanged(object sender, EventArgs e)
        {
            recipient_phone_number = recipient_phone_number_label.Text;
        }

        private void recipient_adress_label_TextChanged(object sender, EventArgs e)
        {
            recipient_adress = recipient_adress_label.Text;
        }

        private void recipient_email_label_TextChanged(object sender, EventArgs e)
        {
            recipient_email = recipient_email_label.Text;
        }

        private void warehouse_name_label_Enter(object sender, EventArgs e)
        {
            warehouse_name_label.Clear();
        }

        private void sender_company_name_label_Enter(object sender, EventArgs e)
        {
            sender_company_name_label.Clear();
        }

        private void sender_phone_number_label_Enter(object sender, EventArgs e)
        {
            sender_phone_number_label.Clear();
        }

        private void sender_adress_label_Enter(object sender, EventArgs e)
        {
            sender_adress_label.Clear();
        }

        private void sender_email_label_Enter(object sender, EventArgs e)
        {
            sender_email_label.Clear();
        }

        private void recipient_company_name_label_Enter(object sender, EventArgs e)
        {
            recipient_company_name_label.Clear();
        }

        private void recipient_phone_number_label_Enter(object sender, EventArgs e)
        {
            recipient_phone_number_label.Clear();
        }

        private void recipient_adress_label_Enter(object sender, EventArgs e)
        {
            recipient_adress_label.Clear();
        }

        private void recipient_email_label_Enter(object sender, EventArgs e)
        {
            recipient_email_label.Clear();
        }

        private void warehouse_name_label_Leave(object sender, EventArgs e)
        {
            warehouse_name_label.Text = "Назва складу";
        }

        private void save_table_Click(object sender, EventArgs e)
        {
            // Создаем двумерный список
            List<List<string>> data = new List<List<string>>();

            // Заполняем список данными из DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                List<string> rowData = new List<string>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    rowData.Add((string)cell.Value);
                }
                data.Add(rowData);
            }
        }

        private void add_row_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void delete_row_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);
            }
        }
    }
}
