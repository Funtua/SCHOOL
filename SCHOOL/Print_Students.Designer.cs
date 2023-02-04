namespace SCHOOL
{
    partial class Print_Students
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblUser = new System.Windows.Forms.Label();
            this.DgvReg = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExportExcel = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.RadioFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RadioMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RadioAll = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.ComboSelectClass = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReg)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.White;
            this.LblUser.Location = new System.Drawing.Point(384, 4);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(89, 23);
            this.LblUser.TabIndex = 3;
            this.LblUser.Text = "To Print...";
            // 
            // DgvReg
            // 
            this.DgvReg.AllowUserToAddRows = false;
            this.DgvReg.AllowUserToDeleteRows = false;
            this.DgvReg.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvReg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvReg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvReg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvReg.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvReg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvReg.Location = new System.Drawing.Point(0, 72);
            this.DgvReg.Name = "DgvReg";
            this.DgvReg.RowHeadersVisible = false;
            this.DgvReg.Size = new System.Drawing.Size(857, 401);
            this.DgvReg.TabIndex = 55;
            this.DgvReg.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvReg.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvReg.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvReg.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvReg.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvReg.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvReg.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvReg.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvReg.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvReg.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.DgvReg.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvReg.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvReg.ThemeStyle.HeaderStyle.Height = 23;
            this.DgvReg.ThemeStyle.ReadOnly = false;
            this.DgvReg.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvReg.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvReg.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.DgvReg.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvReg.ThemeStyle.RowsStyle.Height = 22;
            this.DgvReg.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvReg.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.LblUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 32);
            this.panel1.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ExportExcel);
            this.panel2.Controls.Add(this.BtnPrint);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.RadioFemale);
            this.panel2.Controls.Add(this.RadioMale);
            this.panel2.Controls.Add(this.RadioAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 83);
            this.panel2.TabIndex = 50;
            // 
            // ExportExcel
            // 
            this.ExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportExcel.BorderRadius = 18;
            this.ExportExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExportExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExportExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExportExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExportExcel.FillColor = System.Drawing.Color.Chocolate;
            this.ExportExcel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportExcel.ForeColor = System.Drawing.Color.White;
            this.ExportExcel.Location = new System.Drawing.Point(475, 42);
            this.ExportExcel.Name = "ExportExcel";
            this.ExportExcel.Size = new System.Drawing.Size(187, 35);
            this.ExportExcel.TabIndex = 82;
            this.ExportExcel.Text = "Export to Excel";
            this.ExportExcel.Click += new System.EventHandler(this.ExportExcel_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrint.BorderRadius = 18;
            this.BtnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPrint.FillColor = System.Drawing.Color.Red;
            this.BtnPrint.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.Location = new System.Drawing.Point(744, 39);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(101, 35);
            this.BtnPrint.TabIndex = 10;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Location = new System.Drawing.Point(12, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(834, 10);
            this.panel3.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Gender:";
            // 
            // RadioFemale
            // 
            this.RadioFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RadioFemale.AutoSize = true;
            this.RadioFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioFemale.CheckedState.BorderThickness = 0;
            this.RadioFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioFemale.CheckedState.InnerOffset = -4;
            this.RadioFemale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioFemale.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.RadioFemale.Location = new System.Drawing.Point(238, 45);
            this.RadioFemale.Name = "RadioFemale";
            this.RadioFemale.Size = new System.Drawing.Size(86, 23);
            this.RadioFemale.TabIndex = 5;
            this.RadioFemale.Text = "Female";
            this.RadioFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioFemale.UncheckedState.BorderThickness = 2;
            this.RadioFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // RadioMale
            // 
            this.RadioMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RadioMale.AutoSize = true;
            this.RadioMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioMale.CheckedState.BorderThickness = 0;
            this.RadioMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioMale.CheckedState.InnerOffset = -4;
            this.RadioMale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioMale.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.RadioMale.Location = new System.Drawing.Point(166, 45);
            this.RadioMale.Name = "RadioMale";
            this.RadioMale.Size = new System.Drawing.Size(66, 23);
            this.RadioMale.TabIndex = 5;
            this.RadioMale.Text = "Male";
            this.RadioMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioMale.UncheckedState.BorderThickness = 2;
            this.RadioMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // RadioAll
            // 
            this.RadioAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RadioAll.AutoSize = true;
            this.RadioAll.Checked = true;
            this.RadioAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioAll.CheckedState.BorderThickness = 0;
            this.RadioAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioAll.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioAll.CheckedState.InnerOffset = -4;
            this.RadioAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAll.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.RadioAll.Location = new System.Drawing.Point(94, 45);
            this.RadioAll.Name = "RadioAll";
            this.RadioAll.Size = new System.Drawing.Size(47, 23);
            this.RadioAll.TabIndex = 4;
            this.RadioAll.TabStop = true;
            this.RadioAll.Text = "All";
            this.RadioAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioAll.UncheckedState.BorderThickness = 2;
            this.RadioAll.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioAll.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label8.Location = new System.Drawing.Point(398, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 19);
            this.label8.TabIndex = 53;
            this.label8.Text = "Select Class:";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.BorderRadius = 18;
            this.BtnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSearch.FillColor = System.Drawing.Color.Olive;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Image = global::SCHOOL.Properties.Resources.download__9_;
            this.BtnSearch.Location = new System.Drawing.Point(744, 34);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(101, 29);
            this.BtnSearch.TabIndex = 56;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click_1);
            // 
            // ComboSelectClass
            // 
            this.ComboSelectClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboSelectClass.AutoRoundedCorners = true;
            this.ComboSelectClass.BackColor = System.Drawing.Color.Transparent;
            this.ComboSelectClass.BorderColor = System.Drawing.Color.White;
            this.ComboSelectClass.BorderRadius = 17;
            this.ComboSelectClass.BorderThickness = 5;
            this.ComboSelectClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboSelectClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSelectClass.FillColor = System.Drawing.Color.Gainsboro;
            this.ComboSelectClass.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboSelectClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboSelectClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboSelectClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboSelectClass.ItemHeight = 30;
            this.ComboSelectClass.Items.AddRange(new object[] {
            "K.G.",
            "Nursery One",
            "Nursery Two",
            "Primary One",
            "Primary Two",
            "Primary Three",
            "Primary Four",
            "Primary Five",
            "Primary Six",
            "Graduated",
            "Withdrawn",
            "Rusticated"});
            this.ComboSelectClass.Location = new System.Drawing.Point(519, 33);
            this.ComboSelectClass.Name = "ComboSelectClass";
            this.ComboSelectClass.Size = new System.Drawing.Size(219, 36);
            this.ComboSelectClass.TabIndex = 75;
            // 
            // Print_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 559);
            this.Controls.Add(this.ComboSelectClass);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DgvReg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Name = "Print_Students";
            this.Text = "Print_Students";
            this.Load += new System.EventHandler(this.Print_Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUser;
        private Guna.UI2.WinForms.Guna2DataGridView DgvReg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2RadioButton RadioFemale;
        private Guna.UI2.WinForms.Guna2RadioButton RadioMale;
        private Guna.UI2.WinForms.Guna2RadioButton RadioAll;
        private Guna.UI2.WinForms.Guna2Button ExportExcel;
        private Guna.UI2.WinForms.Guna2Button BtnPrint;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button BtnSearch;
        private Guna.UI2.WinForms.Guna2ComboBox ComboSelectClass;
    }
}