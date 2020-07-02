using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace POS_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection();

        private void Form2_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users/Fatima/Desktop/Fatima and Areesha - Copy/POS Management System/smsystem.accdb;";
            connection.Open();
            connection.Close();
            string[] s = new string[3] { "Men", "Women", "Kids" };
            selectionComboBox.Items.AddRange(s);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string clothingName = txt_clothingName.Text;     
            int price = Convert.ToInt32(txt_price.Text);

            if (selectionComboBox.Text == "Women")
            {
                OleDbCommand cmd = new OleDbCommand("INSERT INTO Women (clothingName, price) VALUES (' " +txt_clothingName.Text + " ',' " +txt_price.Text + " ')", connection);
                cmd.Parameters.AddWithValue("@clothingName", clothingName);
                cmd.Parameters.AddWithValue("@price", price);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("One record has been added");
            }
            if (selectionComboBox.Text == "Men")
            {
                OleDbCommand cmd = new OleDbCommand("INSERT INTO Men (clothingName, price) VALUES (' " + txt_clothingName.Text + " ',' " + txt_price.Text + " ')", connection);
                cmd.Parameters.AddWithValue("@clothingName", clothingName);
                cmd.Parameters.AddWithValue("@price", price);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("One record has been added");
            }
            if (selectionComboBox.Text == "Kids")
            {
                OleDbCommand cmd = new OleDbCommand("INSERT INTO Kids (clothingName, price) VALUES (' " + txt_clothingName.Text + " ',' " + txt_price.Text + " ')", connection);
                cmd.Parameters.AddWithValue("@clothingName", clothingName);
                cmd.Parameters.AddWithValue("@price", price);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("One record has been added");
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }
    }
}
