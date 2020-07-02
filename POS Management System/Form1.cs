using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Text.RegularExpressions;



namespace POS_Management_System
{
    public partial class Form1_POS : MetroFramework.Forms.MetroForm
    {
        public Form1_POS()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection();
        public string category;
        public string date = DateTime.Now.ToString();
        public string memoNo = ((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds).ToString();
        private void POS_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users/Fatima/Desktop/Fatima and Areesha - Copy/POS Management System/smsystem.accdb;";

            this.remove_Ready = false;
        }
        

        private void comboBox_Description_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceData(category);
        }
        #region print
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            String cloumn0 = ListView_Memo.Columns[0].Text;
            String cloumn1 = ListView_Memo.Columns[1].Text;
            String cloumn2 = ListView_Memo.Columns[2].Text;
            String cloumn3 = ListView_Memo.Columns[3].Text;

            StringBuilder sb = new StringBuilder();
            sb.Append("PEAKY BLINDERS\n");
            sb.Append("Plot # SB-19&20 Block 7 Gulistan-E-Jauher, Karachi.\n\n");
            sb.Append("ORIGINAL BILL\n");
            sb.Append("Memo #: " + memoNo + "\t\t\tDate: " + DateTime.Now + "\n");
            sb.Append("Cashier: Thomas Shellby\t\t\t\t POS: SYS-32 \n\n");

            sb.Append("===========================================================\n");
            sb.AppendFormat("{0}{1,16}{2,15}{3,16}", cloumn0, cloumn1, cloumn2, cloumn3 + "\n");
            sb.Append("===========================================================\n");

            for (int c = 0; c < ListView_Memo.Items.Count; c++)
            {
                sb.AppendFormat("{0,-22}{1,-15}{2,-15}{3,-15}", this.ListView_Memo.Items[c].SubItems[0].Text, this.ListView_Memo.Items[c].SubItems[1].Text, this.ListView_Memo.Items[c].SubItems[2].Text, this.ListView_Memo.Items[c].SubItems[3].Text);
                sb.Append("\n");
            }
            sb.Append("-----------------------------------------------------------\n");

            sb.AppendFormat("SubTotal:{0,-10}Discount:{1,-10}Net Amount:{2,-10}", this.txt_SubTotal.Text, this.txt_Discount.Text, this.txt_NetAmount.Text);
            sb.Append("\n\nContact #: 747849349\nHAVE A GOOD DAY!");
            sb.ToString();

            //Draws the specified text string at the specified location with the specified Brush and Font objects using the formatting attributes of the specified StringFormat.
            e.Graphics.DrawString(sb.ToString(), new Font("Courier New", 14, FontStyle.Italic), Brushes.Black, new PointF(100, 100));
        }
#endregion

        #region Functions
        public void priceData(string Category)
        {
            connection.Open();
            DataSet dt = new DataSet(Category);
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT* FROM " + Category, connection);
            adapter.Fill(dt, Category);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            bs.DataMember = Category;

            txt_Price.DataBindings.Clear();
            txt_Price.DataBindings.Add(new Binding("Text", bs[comboBox_Description.SelectedIndex], @"price", true));
            connection.Close();

        }

        public void clothingName(string Category)
        {
            comboBox_Description.Items.Clear();
            connection.Open();
            OleDbCommand com = new OleDbCommand("select clothingName from " + Category, connection);
            OleDbDataReader d1 = com.ExecuteReader();

            while (d1.Read())
            {
                string a = d1["clothingName"].ToString();
                comboBox_Description.Items.Add(a);
            }

            connection.Close();
        }

        public void reset_Values(int x)
        {
            if (x == 1)
            {
                this.txt_Price.Text = "0";
                this.txt_Qty.Text = "0";
                this.txt_Total.Text = "0";
                this.comboBox_Description.Text = "";
            }

            if (x == 2)
            {
                this.ListView_Memo.Items.Clear();
                this.ListView_Memo.Refresh();
                this.txt_Price.Text = "0";
                this.txt_Qty.Text = "0";
                this.txt_Total.Text = "0";
                this.txt_SubTotal.Text = "0";
                this.txt_Discount.Text = "0";
                this.txt_NetAmount.Text = "0";
                this.txt_AmountPaid.Text = "0";
                this.txt_Balance.Text = "0";
                this.comboBox_Description.Text = "";
                this.radio_btn_Men.Checked = true;

            }
        }

        #endregion

        #region KeyPressEvent
        private void txt_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_AmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region RadioButton
        private void radio_btn_Men_CheckedChanged(object sender, EventArgs e)
        {
            reset_Values(1);
            category = "Men";
            clothingName(category);
        }

        private void radio_btn_Women_CheckedChanged(object sender, EventArgs e)
        {
            reset_Values(1);
            category = "Women";
            clothingName(category);

        }

        private void radio_btn_Kids_CheckedChanged(object sender, EventArgs e)
        {
            reset_Values(1);
            category = "Kids";
            clothingName(category);

        }
        #endregion

        #region TextChanged
        private void txt_Discount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Discount.Text) && double.Parse(txt_Discount.Text) > -1)
            {
                txt_NetAmount.Text = (double.Parse(txt_SubTotal.Text) - double.Parse(txt_Discount.Text)).ToString();
            }
        }

        private void txt_AmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_AmountPaid.Text) && double.Parse(txt_NetAmount.Text) > -1)
                txt_Balance.Text = (double.Parse(txt_AmountPaid.Text) - double.Parse(txt_NetAmount.Text)).ToString();

        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Price.Text) && !string.IsNullOrWhiteSpace(txt_Qty.Text))
            {
                txt_Total.Text = (double.Parse(txt_Price.Text) * double.Parse(txt_Qty.Text)).ToString();
               
            }
           
        }

        private void txt_SubTotal_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_SubTotal.Text) && double.Parse(txt_SubTotal.Text) > -1)
                txt_NetAmount.Text = (double.Parse(txt_SubTotal.Text) - double.Parse(txt_Discount.Text)).ToString();

        }

        private void txt_NetAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_NetAmount.Text) && double.Parse(txt_NetAmount.Text) > -1)
            {
                txt_Balance.Text = (double.Parse(txt_AmountPaid.Text) - double.Parse(txt_NetAmount.Text)).ToString();
            }

        }

        #endregion

        #region ClickEvent
        private void btn_add_Item_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Price.Text) && double.Parse(txt_Price.Text) > 0 && !string.IsNullOrWhiteSpace(txt_Qty.Text) && double.Parse(txt_Qty.Text) > 0)
            {
                string[] list = new string[4];
                list[0] = comboBox_Description.SelectedItem.ToString();
                list[1] = txt_Price.Text;
                list[2] = txt_Qty.Text;
                list[3] = txt_Total.Text;
                ListViewItem lvi = new ListViewItem(list);
                ListView_Memo.Items.Add(lvi);

                txt_SubTotal.Text = (double.Parse(txt_Total.Text) + double.Parse(txt_SubTotal.Text)).ToString();

                remove_Ready = true;
                this.reset_Values(1);
            }

        }
        private void txt_Qty_Click(object sender, EventArgs e)
        {
            txt_Qty.Text = "1";
        }
        private void btn_Remove_Item_Click(object sender, EventArgs e)
        {
            if (ListView_Memo.SelectedItems.Count > 0)
            {
                for (int i = 0; i < ListView_Memo.Items.Count; i++)
                {
                    if (ListView_Memo.Items[i].Selected)
                    {
                        txt_SubTotal.Text = (double.Parse(txt_SubTotal.Text) - double.Parse(ListView_Memo.Items[i].SubItems[3].Text)).ToString();
                        ListView_Memo.Items[i].Remove();

                    }
                }
            }
        }
        private void btn_Print_Click(object sender, EventArgs e)
        {

           
            int namount = Convert.ToInt32(txt_NetAmount.Text);

            OleDbCommand cmd = new OleDbCommand("INSERT INTO Records (Memono, Netamount) VALUES ('"+memoNo+ "','" + txt_NetAmount.Text + " ')", connection);

            cmd.Parameters.AddWithValue("@Memono", memoNo);
            cmd.Parameters.AddWithValue("@Netamount", namount);
            
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Record has been saved");


            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();


        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.reset_Values(2);
        }


        private void txt_Discount_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region SetBooleanValue
       
        private bool remove_Ready
        {
            set
            {
                this.btn_Remove_Item.Enabled = value;
            }

        }
        #endregion

        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

    }

}