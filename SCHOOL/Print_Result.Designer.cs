namespace SCHOOL
{
    partial class Print_Result
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
            this.BtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboTerm = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ComboClass = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboSession = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BtnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.DgvReg = new System.Windows.Forms.DataGridView();
            this.ExportExcel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReg)).BeginInit();
            this.SuspendLayout();
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
            this.BtnSearch.Location = new System.Drawing.Point(1018, 12);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(139, 29);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(438, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 77;
            this.label6.Text = "Session:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(216, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 73;
            this.label5.Text = "Class:";
            // 
            // ComboTerm
            // 
            this.ComboTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboTerm.AutoRoundedCorners = true;
            this.ComboTerm.BackColor = System.Drawing.Color.Transparent;
            this.ComboTerm.BorderColor = System.Drawing.Color.White;
            this.ComboTerm.BorderRadius = 17;
            this.ComboTerm.BorderThickness = 5;
            this.ComboTerm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTerm.FillColor = System.Drawing.Color.Gainsboro;
            this.ComboTerm.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboTerm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboTerm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboTerm.ItemHeight = 30;
            this.ComboTerm.Items.AddRange(new object[] {
            "1st Term",
            "2nd Term",
            "3rd Term"});
            this.ComboTerm.Location = new System.Drawing.Point(811, 8);
            this.ComboTerm.Name = "ComboTerm";
            this.ComboTerm.Size = new System.Drawing.Size(190, 36);
            this.ComboTerm.TabIndex = 2;
            this.ComboTerm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboTerm_KeyPress);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(727, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 19);
            this.label20.TabIndex = 78;
            this.label20.Text = "Term:";
            // 
            // ComboClass
            // 
            this.ComboClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboClass.AutoRoundedCorners = true;
            this.ComboClass.BackColor = System.Drawing.Color.Transparent;
            this.ComboClass.BorderColor = System.Drawing.Color.White;
            this.ComboClass.BorderRadius = 17;
            this.ComboClass.BorderThickness = 5;
            this.ComboClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboClass.FillColor = System.Drawing.Color.Gainsboro;
            this.ComboClass.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboClass.ItemHeight = 30;
            this.ComboClass.Items.AddRange(new object[] {
            "K.G.",
            "Nursery One",
            "Nursery Two",
            "Primary One",
            "Primary Two",
            "Primary Three",
            "Primary Four",
            "Primary Five",
            "Primary Six"});
            this.ComboClass.Location = new System.Drawing.Point(294, 8);
            this.ComboClass.Name = "ComboClass";
            this.ComboClass.Size = new System.Drawing.Size(140, 36);
            this.ComboClass.TabIndex = 0;
            // 
            // ComboSession
            // 
            this.ComboSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboSession.AutoRoundedCorners = true;
            this.ComboSession.BackColor = System.Drawing.Color.Transparent;
            this.ComboSession.BorderColor = System.Drawing.Color.White;
            this.ComboSession.BorderRadius = 17;
            this.ComboSession.BorderThickness = 5;
            this.ComboSession.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSession.FillColor = System.Drawing.Color.Gainsboro;
            this.ComboSession.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboSession.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboSession.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ComboSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboSession.ItemHeight = 30;
            this.ComboSession.Location = new System.Drawing.Point(524, 8);
            this.ComboSession.Name = "ComboSession";
            this.ComboSession.Size = new System.Drawing.Size(189, 36);
            this.ComboSession.TabIndex = 1;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrint.BorderRadius = 18;
            this.BtnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPrint.FillColor = System.Drawing.Color.Chocolate;
            this.BtnPrint.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.Location = new System.Drawing.Point(1034, 597);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(123, 29);
            this.BtnPrint.TabIndex = 79;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // DgvReg
            // 
            this.DgvReg.AllowUserToAddRows = false;
            this.DgvReg.AllowUserToDeleteRows = false;
            this.DgvReg.AllowUserToOrderColumns = true;
            this.DgvReg.AllowUserToResizeColumns = false;
            this.DgvReg.AllowUserToResizeRows = false;
            this.DgvReg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvReg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvReg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReg.Location = new System.Drawing.Point(12, 61);
            this.DgvReg.Name = "DgvReg";
            this.DgvReg.Size = new System.Drawing.Size(1145, 530);
            this.DgvReg.TabIndex = 80;
            this.DgvReg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvReg_CellDoubleClick);
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
            this.ExportExcel.Location = new System.Drawing.Point(781, 597);
            this.ExportExcel.Name = "ExportExcel";
            this.ExportExcel.Size = new System.Drawing.Size(187, 29);
            this.ExportExcel.TabIndex = 81;
            this.ExportExcel.Text = "Export to Excel";
            this.ExportExcel.Click += new System.EventHandler(this.ExportExcel_Click);
            // 
            // Print_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1169, 631);
            this.Controls.Add(this.ExportExcel);
            this.Controls.Add(this.DgvReg);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboTerm);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.ComboClass);
            this.Controls.Add(this.ComboSession);
            this.Name = "Print_Result";
            this.Text = "Print_Result";
            this.Load += new System.EventHandler(this.Print_Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button BtnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox ComboTerm;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2ComboBox ComboClass;
        private Guna.UI2.WinForms.Guna2ComboBox ComboSession;
        private Guna.UI2.WinForms.Guna2Button BtnPrint;
        private System.Windows.Forms.DataGridView DgvReg;
        private Guna.UI2.WinForms.Guna2Button ExportExcel;
    }
}