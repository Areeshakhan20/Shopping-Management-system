namespace POS_Management_System
{
    partial class Form1_POS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_POS));
            this.btn_add_Item = new MetroFramework.Controls.MetroTile();
            this.ListView_Memo = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smsystemDataSet = new POS_Management_System.smsystemDataSet();
            this.btn_Remove_Item = new MetroFramework.Controls.MetroTile();
            this.btn_Print = new MetroFramework.Controls.MetroTile();
            this.radio_btn_Women = new MetroFramework.Controls.MetroRadioButton();
            this.radio_btn_Men = new MetroFramework.Controls.MetroRadioButton();
            this.radio_btn_Kids = new MetroFramework.Controls.MetroRadioButton();
            this.lbl_NetAmount = new MetroFramework.Controls.MetroLabel();
            this.lbl_AmountPaid = new MetroFramework.Controls.MetroLabel();
            this.lbl_SubTotal = new MetroFramework.Controls.MetroLabel();
            this.lbl_Balance = new MetroFramework.Controls.MetroLabel();
            this.lbl_Discount = new MetroFramework.Controls.MetroLabel();
            this.txt_AmountPaid = new MetroFramework.Controls.MetroTextBox();
            this.txt_Balance = new MetroFramework.Controls.MetroTextBox();
            this.txt_SubTotal = new MetroFramework.Controls.MetroTextBox();
            this.txt_Discount = new MetroFramework.Controls.MetroTextBox();
            this.txt_NetAmount = new MetroFramework.Controls.MetroTextBox();
            this.txt_Price = new MetroFramework.Controls.MetroTextBox();
            this.lbl_Price = new MetroFramework.Controls.MetroLabel();
            this.txt_Qty = new MetroFramework.Controls.MetroTextBox();
            this.txt_Total = new MetroFramework.Controls.MetroTextBox();
            this.lbl_Quantity = new MetroFramework.Controls.MetroLabel();
            this.lbl_Total = new MetroFramework.Controls.MetroLabel();
            this.comboBox_Description = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_Clear = new MetroFramework.Controls.MetroTile();
            this.btn_Add_Product = new MetroFramework.Controls.MetroTile();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.smsystemDataSet)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add_Item
            // 
            this.btn_add_Item.ActiveControl = null;
            this.btn_add_Item.Location = new System.Drawing.Point(18, 264);
            this.btn_add_Item.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_Item.Name = "btn_add_Item";
            this.btn_add_Item.Size = new System.Drawing.Size(176, 41);
            this.btn_add_Item.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_add_Item.TabIndex = 5;
            this.btn_add_Item.Text = "Add";
            this.btn_add_Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_Item.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_add_Item.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_add_Item.UseSelectable = true;
            this.btn_add_Item.Click += new System.EventHandler(this.btn_add_Item_Click);
            // 
            // ListView_Memo
            // 
            this.ListView_Memo.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListView_Memo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_Memo.BackColor = System.Drawing.Color.White;
            this.ListView_Memo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView_Memo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListView_Memo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ListView_Memo.FullRowSelect = true;
            this.ListView_Memo.GridLines = true;
            this.ListView_Memo.HideSelection = false;
            this.ListView_Memo.HoverSelection = true;
            this.ListView_Memo.Location = new System.Drawing.Point(652, 143);
            this.ListView_Memo.Margin = new System.Windows.Forms.Padding(2);
            this.ListView_Memo.Name = "ListView_Memo";
            this.ListView_Memo.OwnerDraw = true;
            this.ListView_Memo.Size = new System.Drawing.Size(468, 438);
            this.ListView_Memo.Style = MetroFramework.MetroColorStyle.Silver;
            this.ListView_Memo.TabIndex = 18;
            this.ListView_Memo.UseCompatibleStateImageBehavior = false;
            this.ListView_Memo.UseSelectable = true;
            this.ListView_Memo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description";
            this.columnHeader1.Width = 414;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // smsystemDataSet
            // 
            this.smsystemDataSet.DataSetName = "smsystemDataSet";
            this.smsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Remove_Item
            // 
            this.btn_Remove_Item.ActiveControl = null;
            this.btn_Remove_Item.Location = new System.Drawing.Point(246, 264);
            this.btn_Remove_Item.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Remove_Item.Name = "btn_Remove_Item";
            this.btn_Remove_Item.Size = new System.Drawing.Size(176, 41);
            this.btn_Remove_Item.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Remove_Item.TabIndex = 7;
            this.btn_Remove_Item.Text = "Remove";
            this.btn_Remove_Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Remove_Item.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_Remove_Item.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Remove_Item.UseSelectable = true;
            this.btn_Remove_Item.Click += new System.EventHandler(this.btn_Remove_Item_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.ActiveControl = null;
            this.btn_Print.Location = new System.Drawing.Point(476, 540);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(171, 41);
            this.btn_Print.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Print.TabIndex = 8;
            this.btn_Print.Text = "Print";
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Print.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_Print.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Print.UseSelectable = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // radio_btn_Women
            // 
            this.radio_btn_Women.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radio_btn_Women.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.radio_btn_Women.Location = new System.Drawing.Point(125, 100);
            this.radio_btn_Women.Margin = new System.Windows.Forms.Padding(2);
            this.radio_btn_Women.Name = "radio_btn_Women";
            this.radio_btn_Women.Size = new System.Drawing.Size(86, 20);
            this.radio_btn_Women.TabIndex = 1;
            this.radio_btn_Women.TabStop = true;
            this.radio_btn_Women.Text = "Women";
            this.radio_btn_Women.UseSelectable = true;
            this.radio_btn_Women.CheckedChanged += new System.EventHandler(this.radio_btn_Women_CheckedChanged);
            // 
            // radio_btn_Men
            // 
            this.radio_btn_Men.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radio_btn_Men.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.radio_btn_Men.Location = new System.Drawing.Point(18, 100);
            this.radio_btn_Men.Margin = new System.Windows.Forms.Padding(2);
            this.radio_btn_Men.Name = "radio_btn_Men";
            this.radio_btn_Men.Size = new System.Drawing.Size(86, 20);
            this.radio_btn_Men.TabIndex = 0;
            this.radio_btn_Men.TabStop = true;
            this.radio_btn_Men.Text = "Men";
            this.radio_btn_Men.UseSelectable = true;
            this.radio_btn_Men.CheckedChanged += new System.EventHandler(this.radio_btn_Men_CheckedChanged);
            // 
            // radio_btn_Kids
            // 
            this.radio_btn_Kids.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radio_btn_Kids.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.radio_btn_Kids.Location = new System.Drawing.Point(231, 100);
            this.radio_btn_Kids.Margin = new System.Windows.Forms.Padding(2);
            this.radio_btn_Kids.Name = "radio_btn_Kids";
            this.radio_btn_Kids.Size = new System.Drawing.Size(86, 20);
            this.radio_btn_Kids.TabIndex = 2;
            this.radio_btn_Kids.TabStop = true;
            this.radio_btn_Kids.Text = "Kids";
            this.radio_btn_Kids.UseSelectable = true;
            this.radio_btn_Kids.CheckedChanged += new System.EventHandler(this.radio_btn_Kids_CheckedChanged);
            // 
            // lbl_NetAmount
            // 
            this.lbl_NetAmount.AutoSize = true;
            this.lbl_NetAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NetAmount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_NetAmount.Location = new System.Drawing.Point(526, 365);
            this.lbl_NetAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NetAmount.Name = "lbl_NetAmount";
            this.lbl_NetAmount.Size = new System.Drawing.Size(105, 25);
            this.lbl_NetAmount.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_NetAmount.TabIndex = 16;
            this.lbl_NetAmount.Text = "Net Amount";
            this.lbl_NetAmount.UseCustomBackColor = true;
            this.lbl_NetAmount.UseStyleColors = true;
            // 
            // lbl_AmountPaid
            // 
            this.lbl_AmountPaid.AutoSize = true;
            this.lbl_AmountPaid.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AmountPaid.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_AmountPaid.Location = new System.Drawing.Point(363, 436);
            this.lbl_AmountPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AmountPaid.Name = "lbl_AmountPaid";
            this.lbl_AmountPaid.Size = new System.Drawing.Size(114, 25);
            this.lbl_AmountPaid.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_AmountPaid.TabIndex = 21;
            this.lbl_AmountPaid.Text = "Amount Paid:";
            this.lbl_AmountPaid.UseCustomBackColor = true;
            this.lbl_AmountPaid.UseStyleColors = true;
            // 
            // lbl_SubTotal
            // 
            this.lbl_SubTotal.AutoSize = true;
            this.lbl_SubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SubTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_SubTotal.Location = new System.Drawing.Point(76, 365);
            this.lbl_SubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SubTotal.Name = "lbl_SubTotal";
            this.lbl_SubTotal.Size = new System.Drawing.Size(80, 25);
            this.lbl_SubTotal.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_SubTotal.TabIndex = 13;
            this.lbl_SubTotal.Text = "Sub Total";
            this.lbl_SubTotal.UseCustomBackColor = true;
            this.lbl_SubTotal.UseStyleColors = true;
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Balance.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_Balance.Location = new System.Drawing.Point(395, 496);
            this.lbl_Balance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(75, 25);
            this.lbl_Balance.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_Balance.TabIndex = 22;
            this.lbl_Balance.Text = "Balance:";
            this.lbl_Balance.UseCustomBackColor = true;
            this.lbl_Balance.UseStyleColors = true;
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Discount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_Discount.Location = new System.Drawing.Point(304, 365);
            this.lbl_Discount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(78, 25);
            this.lbl_Discount.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_Discount.TabIndex = 14;
            this.lbl_Discount.Text = "Discount";
            this.lbl_Discount.UseCustomBackColor = true;
            this.lbl_Discount.UseStyleColors = true;
            // 
            // txt_AmountPaid
            // 
            // 
            // 
            // 
            this.txt_AmountPaid.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txt_AmountPaid.CustomButton.Image = null;
            this.txt_AmountPaid.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.txt_AmountPaid.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_AmountPaid.CustomButton.Name = "";
            this.txt_AmountPaid.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_AmountPaid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_AmountPaid.CustomButton.TabIndex = 1;
            this.txt_AmountPaid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_AmountPaid.CustomButton.UseSelectable = true;
            this.txt_AmountPaid.CustomButton.Visible = false;
            this.txt_AmountPaid.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_AmountPaid.Lines = new string[] {
        "0"};
            this.txt_AmountPaid.Location = new System.Drawing.Point(476, 431);
            this.txt_AmountPaid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_AmountPaid.MaxLength = 32767;
            this.txt_AmountPaid.Name = "txt_AmountPaid";
            this.txt_AmountPaid.PasswordChar = '\0';
            this.txt_AmountPaid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_AmountPaid.SelectedText = "";
            this.txt_AmountPaid.SelectionLength = 0;
            this.txt_AmountPaid.SelectionStart = 0;
            this.txt_AmountPaid.ShortcutsEnabled = true;
            this.txt_AmountPaid.Size = new System.Drawing.Size(171, 28);
            this.txt_AmountPaid.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_AmountPaid.TabIndex = 7;
            this.txt_AmountPaid.Text = "0";
            this.txt_AmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_AmountPaid.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_AmountPaid.UseSelectable = true;
            this.txt_AmountPaid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_AmountPaid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_AmountPaid.TextChanged += new System.EventHandler(this.txt_AmountPaid_TextChanged);
            this.txt_AmountPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AmountPaid_KeyPress);
            // 
            // txt_Balance
            // 
            // 
            // 
            // 
            this.txt_Balance.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txt_Balance.CustomButton.Image = null;
            this.txt_Balance.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.txt_Balance.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Balance.CustomButton.Name = "";
            this.txt_Balance.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Balance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Balance.CustomButton.TabIndex = 1;
            this.txt_Balance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Balance.CustomButton.UseSelectable = true;
            this.txt_Balance.CustomButton.Visible = false;
            this.txt_Balance.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_Balance.Lines = new string[] {
        "0"};
            this.txt_Balance.Location = new System.Drawing.Point(476, 489);
            this.txt_Balance.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Balance.MaxLength = 32767;
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.PasswordChar = '\0';
            this.txt_Balance.ReadOnly = true;
            this.txt_Balance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Balance.SelectedText = "";
            this.txt_Balance.SelectionLength = 0;
            this.txt_Balance.SelectionStart = 0;
            this.txt_Balance.ShortcutsEnabled = true;
            this.txt_Balance.Size = new System.Drawing.Size(171, 28);
            this.txt_Balance.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Balance.TabIndex = 20;
            this.txt_Balance.Text = "0";
            this.txt_Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Balance.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Balance.UseSelectable = true;
            this.txt_Balance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Balance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_SubTotal
            // 
            // 
            // 
            // 
            this.txt_SubTotal.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txt_SubTotal.CustomButton.Image = null;
            this.txt_SubTotal.CustomButton.Location = new System.Drawing.Point(150, 2);
            this.txt_SubTotal.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SubTotal.CustomButton.Name = "";
            this.txt_SubTotal.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_SubTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_SubTotal.CustomButton.TabIndex = 1;
            this.txt_SubTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_SubTotal.CustomButton.UseSelectable = true;
            this.txt_SubTotal.CustomButton.Visible = false;
            this.txt_SubTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_SubTotal.Lines = new string[] {
        "0"};
            this.txt_SubTotal.Location = new System.Drawing.Point(18, 335);
            this.txt_SubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SubTotal.MaxLength = 32767;
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.PasswordChar = '\0';
            this.txt_SubTotal.ReadOnly = true;
            this.txt_SubTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_SubTotal.SelectedText = "";
            this.txt_SubTotal.SelectionLength = 0;
            this.txt_SubTotal.SelectionStart = 0;
            this.txt_SubTotal.ShortcutsEnabled = true;
            this.txt_SubTotal.Size = new System.Drawing.Size(176, 28);
            this.txt_SubTotal.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_SubTotal.TabIndex = 12;
            this.txt_SubTotal.Text = "0";
            this.txt_SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SubTotal.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_SubTotal.UseSelectable = true;
            this.txt_SubTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_SubTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_SubTotal.TextChanged += new System.EventHandler(this.txt_SubTotal_TextChanged);
            // 
            // txt_Discount
            // 
            // 
            // 
            // 
            this.txt_Discount.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txt_Discount.CustomButton.Image = null;
            this.txt_Discount.CustomButton.Location = new System.Drawing.Point(150, 2);
            this.txt_Discount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Discount.CustomButton.Name = "";
            this.txt_Discount.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Discount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Discount.CustomButton.TabIndex = 1;
            this.txt_Discount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Discount.CustomButton.UseSelectable = true;
            this.txt_Discount.CustomButton.Visible = false;
            this.txt_Discount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_Discount.Lines = new string[] {
        "0"};
            this.txt_Discount.Location = new System.Drawing.Point(246, 335);
            this.txt_Discount.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Discount.MaxLength = 32767;
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.PasswordChar = '\0';
            this.txt_Discount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Discount.SelectedText = "";
            this.txt_Discount.SelectionLength = 0;
            this.txt_Discount.SelectionStart = 0;
            this.txt_Discount.ShortcutsEnabled = true;
            this.txt_Discount.Size = new System.Drawing.Size(176, 28);
            this.txt_Discount.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Discount.TabIndex = 6;
            this.txt_Discount.Text = "0";
            this.txt_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Discount.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Discount.UseSelectable = true;
            this.txt_Discount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Discount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Discount.TextChanged += new System.EventHandler(this.txt_Discount_TextChanged);
            this.txt_Discount.Click += new System.EventHandler(this.txt_Discount_Click);
            this.txt_Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Discount_KeyPress);
            // 
            // txt_NetAmount
            // 
            // 
            // 
            // 
            this.txt_NetAmount.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txt_NetAmount.CustomButton.Image = null;
            this.txt_NetAmount.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.txt_NetAmount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NetAmount.CustomButton.Name = "";
            this.txt_NetAmount.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_NetAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_NetAmount.CustomButton.TabIndex = 1;
            this.txt_NetAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_NetAmount.CustomButton.UseSelectable = true;
            this.txt_NetAmount.CustomButton.Visible = false;
            this.txt_NetAmount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_NetAmount.Lines = new string[] {
        "0"};
            this.txt_NetAmount.Location = new System.Drawing.Point(476, 335);
            this.txt_NetAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NetAmount.MaxLength = 32767;
            this.txt_NetAmount.Name = "txt_NetAmount";
            this.txt_NetAmount.PasswordChar = '\0';
            this.txt_NetAmount.ReadOnly = true;
            this.txt_NetAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_NetAmount.SelectedText = "";
            this.txt_NetAmount.SelectionLength = 0;
            this.txt_NetAmount.SelectionStart = 0;
            this.txt_NetAmount.ShortcutsEnabled = true;
            this.txt_NetAmount.Size = new System.Drawing.Size(171, 28);
            this.txt_NetAmount.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_NetAmount.TabIndex = 15;
            this.txt_NetAmount.Text = "0";
            this.txt_NetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_NetAmount.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_NetAmount.UseSelectable = true;
            this.txt_NetAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_NetAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_NetAmount.TextChanged += new System.EventHandler(this.txt_NetAmount_TextChanged);
            // 
            // txt_Price
            // 
            // 
            // 
            // 
            this.txt_Price.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txt_Price.CustomButton.Image = null;
            this.txt_Price.CustomButton.Location = new System.Drawing.Point(150, 2);
            this.txt_Price.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Price.CustomButton.Name = "";
            this.txt_Price.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Price.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Price.CustomButton.TabIndex = 1;
            this.txt_Price.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Price.CustomButton.UseSelectable = true;
            this.txt_Price.CustomButton.Visible = false;
            this.txt_Price.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_Price.Lines = new string[0];
            this.txt_Price.Location = new System.Drawing.Point(18, 200);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Price.MaxLength = 32767;
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.PasswordChar = '\0';
            this.txt_Price.ReadOnly = true;
            this.txt_Price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Price.SelectedText = "";
            this.txt_Price.SelectionLength = 0;
            this.txt_Price.SelectionStart = 0;
            this.txt_Price.ShortcutsEnabled = true;
            this.txt_Price.Size = new System.Drawing.Size(176, 28);
            this.txt_Price.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Price.TabIndex = 8;
            this.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Price.UseSelectable = true;
            this.txt_Price.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Price.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Price.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_Price.Location = new System.Drawing.Point(86, 230);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(49, 25);
            this.lbl_Price.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_Price.TabIndex = 9;
            this.lbl_Price.Text = "Price";
            this.lbl_Price.UseCustomBackColor = true;
            this.lbl_Price.UseStyleColors = true;
            // 
            // txt_Qty
            // 
            // 
            // 
            // 
            this.txt_Qty.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txt_Qty.CustomButton.Image = null;
            this.txt_Qty.CustomButton.Location = new System.Drawing.Point(150, 2);
            this.txt_Qty.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Qty.CustomButton.Name = "";
            this.txt_Qty.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Qty.CustomButton.TabIndex = 1;
            this.txt_Qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Qty.CustomButton.UseSelectable = true;
            this.txt_Qty.CustomButton.Visible = false;
            this.txt_Qty.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_Qty.Lines = new string[0];
            this.txt_Qty.Location = new System.Drawing.Point(246, 200);
            this.txt_Qty.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Qty.MaxLength = 32767;
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.PasswordChar = '\0';
            this.txt_Qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Qty.SelectedText = "";
            this.txt_Qty.SelectionLength = 0;
            this.txt_Qty.SelectionStart = 0;
            this.txt_Qty.ShortcutsEnabled = true;
            this.txt_Qty.Size = new System.Drawing.Size(176, 28);
            this.txt_Qty.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Qty.TabIndex = 4;
            this.txt_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Qty.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Qty.UseSelectable = true;
            this.txt_Qty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Qty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Qty.TextChanged += new System.EventHandler(this.txt_Qty_TextChanged);
            this.txt_Qty.Click += new System.EventHandler(this.txt_Qty_Click);
            this.txt_Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qty_KeyPress);
            // 
            // txt_Total
            // 
            // 
            // 
            // 
            this.txt_Total.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txt_Total.CustomButton.Image = null;
            this.txt_Total.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.txt_Total.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Total.CustomButton.Name = "";
            this.txt_Total.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Total.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Total.CustomButton.TabIndex = 1;
            this.txt_Total.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Total.CustomButton.UseSelectable = true;
            this.txt_Total.CustomButton.Visible = false;
            this.txt_Total.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_Total.Lines = new string[] {
        "0"};
            this.txt_Total.Location = new System.Drawing.Point(476, 200);
            this.txt_Total.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Total.MaxLength = 32767;
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.PasswordChar = '\0';
            this.txt_Total.ReadOnly = true;
            this.txt_Total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Total.SelectedText = "";
            this.txt_Total.SelectionLength = 0;
            this.txt_Total.SelectionStart = 0;
            this.txt_Total.ShortcutsEnabled = true;
            this.txt_Total.Size = new System.Drawing.Size(171, 28);
            this.txt_Total.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Total.TabIndex = 10;
            this.txt_Total.Text = "0";
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Total.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Total.UseSelectable = true;
            this.txt_Total.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Total.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Quantity.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_Quantity.Location = new System.Drawing.Point(306, 230);
            this.lbl_Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(77, 25);
            this.lbl_Quantity.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_Quantity.TabIndex = 10;
            this.lbl_Quantity.Text = "Quantity";
            this.lbl_Quantity.UseCustomBackColor = true;
            this.lbl_Quantity.UseStyleColors = true;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_Total.Location = new System.Drawing.Point(546, 230);
            this.lbl_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(46, 25);
            this.lbl_Total.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_Total.TabIndex = 11;
            this.lbl_Total.Text = "Total";
            this.lbl_Total.UseCustomBackColor = true;
            this.lbl_Total.UseStyleColors = true;
            // 
            // comboBox_Description
            // 
            this.comboBox_Description.BackColor = System.Drawing.Color.White;
            this.comboBox_Description.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Description.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox_Description.FormattingEnabled = true;
            this.comboBox_Description.ItemHeight = 26;
            this.comboBox_Description.Location = new System.Drawing.Point(18, 143);
            this.comboBox_Description.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Description.Name = "comboBox_Description";
            this.comboBox_Description.Size = new System.Drawing.Size(630, 34);
            this.comboBox_Description.TabIndex = 3;
            this.comboBox_Description.SelectedIndexChanged += new System.EventHandler(this.comboBox_Description_SelectedIndexChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // btn_Clear
            // 
            this.btn_Clear.ActiveControl = null;
            this.btn_Clear.Location = new System.Drawing.Point(246, 540);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(171, 41);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Clear.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_Clear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Clear.UseSelectable = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Add_Product
            // 
            this.btn_Add_Product.ActiveControl = null;
            this.btn_Add_Product.Location = new System.Drawing.Point(18, 540);
            this.btn_Add_Product.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add_Product.Name = "btn_Add_Product";
            this.btn_Add_Product.Size = new System.Drawing.Size(170, 41);
            this.btn_Add_Product.TabIndex = 8;
            this.btn_Add_Product.Text = "Add Product";
            this.btn_Add_Product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add_Product.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add_Product.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_Add_Product.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Add_Product.UseSelectable = true;
            this.btn_Add_Product.Click += new System.EventHandler(this.btn_Add_Product_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroPanel2.Controls.Add(this.label1);
            this.metroPanel2.Controls.Add(this.metroDateTime1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 8;
            this.metroPanel2.Location = new System.Drawing.Point(2, 26);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1118, 46);
            this.metroPanel2.TabIndex = 24;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Peaky Blinders Shopping Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroDateTime1.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.metroDateTime1.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.metroDateTime1.Location = new System.Drawing.Point(851, 5);
            this.metroDateTime1.Margin = new System.Windows.Forms.Padding(2);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 35);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(266, 35);
            this.metroDateTime1.TabIndex = 2;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.BackgroundImage = global::POS_Management_System.Properties.Resources.fabric_cloth_textile_clothing_christmas_pattern_design_material_750917__1_;
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.ForeColor = System.Drawing.Color.Black;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(2, 598);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1266, 149);
            this.metroPanel1.TabIndex = 25;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            // 
            // Form1_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1126, 601);
            this.Controls.Add(this.btn_Add_Product);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.comboBox_Description);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_NetAmount);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_AmountPaid);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_SubTotal);
            this.Controls.Add(this.lbl_Balance);
            this.Controls.Add(this.radio_btn_Kids);
            this.Controls.Add(this.lbl_Discount);
            this.Controls.Add(this.radio_btn_Men);
            this.Controls.Add(this.txt_AmountPaid);
            this.Controls.Add(this.radio_btn_Women);
            this.Controls.Add(this.txt_Balance);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.txt_SubTotal);
            this.Controls.Add(this.txt_Discount);
            this.Controls.Add(this.txt_Qty);
            this.Controls.Add(this.txt_NetAmount);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.ListView_Memo);
            this.Controls.Add(this.btn_Remove_Item);
            this.Controls.Add(this.btn_add_Item);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1_POS";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.POS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smsystemDataSet)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_add_Item;
        private MetroFramework.Controls.MetroListView ListView_Memo;
        private MetroFramework.Controls.MetroTile btn_Remove_Item;
        private MetroFramework.Controls.MetroTile btn_Print;
        private MetroFramework.Controls.MetroRadioButton radio_btn_Women;
        private MetroFramework.Controls.MetroRadioButton radio_btn_Men;
        private MetroFramework.Controls.MetroRadioButton radio_btn_Kids;
        private MetroFramework.Controls.MetroTextBox txt_Price;
        private MetroFramework.Controls.MetroLabel lbl_Price;
        private MetroFramework.Controls.MetroTextBox txt_Qty;
        private MetroFramework.Controls.MetroTextBox txt_Total;
        private MetroFramework.Controls.MetroLabel lbl_Quantity;
        private MetroFramework.Controls.MetroLabel lbl_Total;
        private MetroFramework.Controls.MetroLabel lbl_NetAmount;
        private MetroFramework.Controls.MetroLabel lbl_AmountPaid;
        private MetroFramework.Controls.MetroLabel lbl_SubTotal;
        private MetroFramework.Controls.MetroLabel lbl_Balance;
        private MetroFramework.Controls.MetroLabel lbl_Discount;
        private MetroFramework.Controls.MetroTextBox txt_AmountPaid;
        private MetroFramework.Controls.MetroTextBox txt_Balance;
        private MetroFramework.Controls.MetroTextBox txt_SubTotal;
        private MetroFramework.Controls.MetroTextBox txt_Discount;
        private MetroFramework.Controls.MetroTextBox txt_NetAmount;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private smsystemDataSet smsystemDataSet;
        private System.Windows.Forms.ComboBox comboBox_Description;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private MetroFramework.Controls.MetroTile btn_Clear;
        private MetroFramework.Controls.MetroTile btn_Add_Product;
        private System.Windows.Forms.Label label1;




    }
}

