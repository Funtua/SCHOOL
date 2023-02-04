using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using Dapper;

namespace SCHOOL
{
    public partial class Backup_Restore : Form
    {
        public Backup_Restore()
        {
            InitializeComponent();
        }
        public static void BackupDB(string filePath, string srcFilename, string destFileName)
        {
            var srcfile = Path.Combine(filePath, srcFilename);
            var destfile = Path.Combine(filePath, destFileName);

            if (File.Exists(destfile)) File.Delete(destfile);

            File.Copy(srcfile, destfile);
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string picDatabaseFrom = Environment.CurrentDirectory;

                var databaseName = "SchoolDB.db";

                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        var backupDatabaseTo = fbd.SelectedPath + "\\" + (Path.GetFileNameWithoutExtension(databaseName) + ".db");

                        BackupDB(picDatabaseFrom, databaseName, backupDatabaseTo);

                        MessageBox.Show("Success");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void RestoreDB(string filePath, string srcFilename, string destFileName, bool IsCopy = false)
        {
            var srcfile = Path.Combine(filePath, srcFilename);
            var destfile = Path.Combine(filePath, destFileName);

            if (File.Exists(destfile)) File.Delete(destfile);

            if (IsCopy)
                BackupDB(filePath, srcFilename, destFileName);
            else
                File.Move(srcfile, destfile);

        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            try
            {



                string restoreDatabaseFrom = string.Empty;

                var databaseName = "SchoolDB.db";

                OpenFileDialog openDialog = new OpenFileDialog();

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    restoreDatabaseFrom = Path.GetDirectoryName(openDialog.FileName);

                    var restoreDatabseTo = Environment.CurrentDirectory + "\\" + databaseName;

                    RestoreDB(restoreDatabaseFrom, databaseName, restoreDatabseTo, true);

                    MessageBox.Show("Restored Successfuly");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnBackup_MouseHover(object sender, EventArgs e)
        {
            BtnBackup.BackColor= Color.IndianRed;
        }

        private void BtnRestore_MouseHover(object sender, EventArgs e)
        {
            BtnRestore.BackColor = Color.IndianRed;
        }

        private void BtnRestore_MouseLeave(object sender, EventArgs e)
        {
            BtnBackup.BackColor = Color.Blue;
        }

        private void BtnBackup_MouseLeave(object sender, EventArgs e)
        {
            BtnRestore.BackColor = Color.Blue;
        }

        private void Backup_Restore_Load(object sender, EventArgs e)
        {
            BtnBackup.Hide();
            BtnRestore.Hide();
        }

        private void Show_Click(object sender, EventArgs e)
        {

            string shw = TxtSHow.Text;
            if (shw == "nasara" || shw=="ibrahim022")
            {
                try
                {
                    BtnBackup.Show();
                    BtnRestore.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Information not correct please think again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void TxtSHow_Click(object sender, EventArgs e)
        {
            if (TxtSHow.Text == "Write Something...")
                TxtSHow.Text = "";
        }
    }
    
}
