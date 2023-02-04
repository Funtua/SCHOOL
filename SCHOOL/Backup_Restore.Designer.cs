namespace SCHOOL
{
    partial class Backup_Restore
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
            this.BtnRestore = new System.Windows.Forms.Button();
            this.TxtSHow = new Guna.UI2.WinForms.Guna2TextBox();
            this.Show = new System.Windows.Forms.Button();
            this.BtnBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRestore
            // 
            this.BtnRestore.BackColor = System.Drawing.Color.Red;
            this.BtnRestore.Font = new System.Drawing.Font("Lucida Bright", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestore.ForeColor = System.Drawing.Color.Black;
            this.BtnRestore.Image = global::SCHOOL.Properties.Resources.download__11_;
            this.BtnRestore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRestore.Location = new System.Drawing.Point(449, 168);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Size = new System.Drawing.Size(341, 97);
            this.BtnRestore.TabIndex = 1;
            this.BtnRestore.Text = "Restore";
            this.BtnRestore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRestore.UseVisualStyleBackColor = false;
            this.BtnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            this.BtnRestore.MouseLeave += new System.EventHandler(this.BtnRestore_MouseLeave);
            this.BtnRestore.MouseHover += new System.EventHandler(this.BtnRestore_MouseHover);
            // 
            // TxtSHow
            // 
            this.TxtSHow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSHow.DefaultText = "Write Something...";
            this.TxtSHow.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSHow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSHow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSHow.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSHow.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSHow.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.TxtSHow.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSHow.Location = new System.Drawing.Point(101, 12);
            this.TxtSHow.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtSHow.Name = "TxtSHow";
            this.TxtSHow.PasswordChar = '\0';
            this.TxtSHow.PlaceholderText = "";
            this.TxtSHow.SelectedText = "";
            this.TxtSHow.Size = new System.Drawing.Size(325, 62);
            this.TxtSHow.TabIndex = 2;
            this.TxtSHow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSHow.Click += new System.EventHandler(this.TxtSHow_Click);
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Show.Font = new System.Drawing.Font("Lucida Bright", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Show.Image = global::SCHOOL.Properties.Resources.download__8_;
            this.Show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Show.Location = new System.Drawing.Point(460, 12);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(264, 49);
            this.Show.TabIndex = 3;
            this.Show.Text = "Show!!!";
            this.Show.UseVisualStyleBackColor = false;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // BtnBackup
            // 
            this.BtnBackup.BackColor = System.Drawing.Color.Red;
            this.BtnBackup.Font = new System.Drawing.Font("Lucida Bright", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackup.ForeColor = System.Drawing.Color.Black;
            this.BtnBackup.Image = global::SCHOOL.Properties.Resources.download__10_;
            this.BtnBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBackup.Location = new System.Drawing.Point(74, 168);
            this.BtnBackup.Name = "BtnBackup";
            this.BtnBackup.Size = new System.Drawing.Size(341, 97);
            this.BtnBackup.TabIndex = 0;
            this.BtnBackup.Text = "Backup";
            this.BtnBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBackup.UseVisualStyleBackColor = false;
            this.BtnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            this.BtnBackup.MouseLeave += new System.EventHandler(this.BtnBackup_MouseLeave);
            this.BtnBackup.MouseHover += new System.EventHandler(this.BtnBackup_MouseHover);
            // 
            // Backup_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1169, 644);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.TxtSHow);
            this.Controls.Add(this.BtnRestore);
            this.Controls.Add(this.BtnBackup);
            this.Name = "Backup_Restore";
            this.Text = "Backup_Restore";
            this.Load += new System.EventHandler(this.Backup_Restore_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnRestore;
        private System.Windows.Forms.Button BtnBackup;
        private Guna.UI2.WinForms.Guna2TextBox TxtSHow;
        private System.Windows.Forms.Button Show;
    }
}