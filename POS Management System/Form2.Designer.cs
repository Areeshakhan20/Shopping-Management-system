namespace POS_Management_System
{
    partial class Form2
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
            this.btn_add = new MetroFramework.Controls.MetroTile();
            this.selectionComboBox = new MetroFramework.Controls.MetroComboBox();
            this.txt_clothingName = new MetroFramework.Controls.MetroTextBox();
            this.txt_price = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.ActiveControl = null;
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add.Location = new System.Drawing.Point(181, 267);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(235, 49);
            this.btn_add.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add Record";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // selectionComboBox
            // 
            this.selectionComboBox.FormattingEnabled = true;
            this.selectionComboBox.ItemHeight = 23;
            this.selectionComboBox.Location = new System.Drawing.Point(181, 96);
            this.selectionComboBox.Name = "selectionComboBox";
            this.selectionComboBox.Size = new System.Drawing.Size(236, 29);
            this.selectionComboBox.TabIndex = 1;
            this.selectionComboBox.UseSelectable = true;
            // 
            // txt_clothingName
            // 
            // 
            // 
            // 
            this.txt_clothingName.CustomButton.Image = null;
            this.txt_clothingName.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.txt_clothingName.CustomButton.Name = "";
            this.txt_clothingName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_clothingName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_clothingName.CustomButton.TabIndex = 1;
            this.txt_clothingName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_clothingName.CustomButton.UseSelectable = true;
            this.txt_clothingName.CustomButton.Visible = false;
            this.txt_clothingName.Lines = new string[0];
            this.txt_clothingName.Location = new System.Drawing.Point(181, 159);
            this.txt_clothingName.MaxLength = 32767;
            this.txt_clothingName.Name = "txt_clothingName";
            this.txt_clothingName.PasswordChar = '\0';
            this.txt_clothingName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_clothingName.SelectedText = "";
            this.txt_clothingName.SelectionLength = 0;
            this.txt_clothingName.SelectionStart = 0;
            this.txt_clothingName.ShortcutsEnabled = true;
            this.txt_clothingName.Size = new System.Drawing.Size(235, 23);
            this.txt_clothingName.TabIndex = 2;
            this.txt_clothingName.UseSelectable = true;
            this.txt_clothingName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_clothingName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_price
            // 
            // 
            // 
            // 
            this.txt_price.CustomButton.Image = null;
            this.txt_price.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.txt_price.CustomButton.Name = "";
            this.txt_price.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_price.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_price.CustomButton.TabIndex = 1;
            this.txt_price.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_price.CustomButton.UseSelectable = true;
            this.txt_price.CustomButton.Visible = false;
            this.txt_price.Lines = new string[0];
            this.txt_price.Location = new System.Drawing.Point(181, 207);
            this.txt_price.MaxLength = 32767;
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_price.SelectedText = "";
            this.txt_price.SelectionLength = 0;
            this.txt_price.SelectionStart = 0;
            this.txt_price.ShortcutsEnabled = true;
            this.txt_price.Size = new System.Drawing.Size(235, 23);
            this.txt_price.TabIndex = 3;
            this.txt_price.UseSelectable = true;
            this.txt_price.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_price.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clothing Item:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(33, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price:";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(7, 12);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(461, 40);
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Tag = "Enter New Record:";
            this.metroTile1.Text = "Enter New Record:";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(474, 336);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_clothingName);
            this.Controls.Add(this.selectionComboBox);
            this.Controls.Add(this.btn_add);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_add;
        private MetroFramework.Controls.MetroComboBox selectionComboBox;
        private MetroFramework.Controls.MetroTextBox txt_clothingName;
        private MetroFramework.Controls.MetroTextBox txt_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}