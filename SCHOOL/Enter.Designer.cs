namespace SCHOOL
{
    partial class Enter
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
            this.TxtEnter = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnEnter = new Guna.UI2.WinForms.Guna2Button();
            this.lblname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtEnter
            // 
            this.TxtEnter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEnter.DefaultText = "";
            this.TxtEnter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtEnter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtEnter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEnter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEnter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEnter.Font = new System.Drawing.Font("Courier New", 40F);
            this.TxtEnter.ForeColor = System.Drawing.Color.Red;
            this.TxtEnter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEnter.Location = new System.Drawing.Point(225, 91);
            this.TxtEnter.Margin = new System.Windows.Forms.Padding(12, 14, 12, 14);
            this.TxtEnter.Name = "TxtEnter";
            this.TxtEnter.PasswordChar = '\0';
            this.TxtEnter.PlaceholderText = "";
            this.TxtEnter.SelectedText = "";
            this.TxtEnter.Size = new System.Drawing.Size(532, 215);
            this.TxtEnter.TabIndex = 0;
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.DimGray;
            this.BtnEnter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEnter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEnter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEnter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEnter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnEnter.Font = new System.Drawing.Font("Segoe UI Black", 40F, System.Drawing.FontStyle.Bold);
            this.BtnEnter.ForeColor = System.Drawing.Color.White;
            this.BtnEnter.Image = global::SCHOOL.Properties.Resources.Accept_icon;
            this.BtnEnter.Location = new System.Drawing.Point(332, 323);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(350, 127);
            this.BtnEnter.TabIndex = 1;
            this.BtnEnter.Text = "OPEN";
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Red;
            this.lblname.Location = new System.Drawing.Point(373, 52);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(221, 25);
            this.lblname.TabIndex = 62;
            this.lblname.Text = "This field can\'t be empty";
            // 
            // Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1169, 657);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.TxtEnter);
            this.Name = "Enter";
            this.Text = "Enter";
            this.Load += new System.EventHandler(this.Enter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TxtEnter;
        private Guna.UI2.WinForms.Guna2Button BtnEnter;
        private System.Windows.Forms.Label lblname;
    }
}