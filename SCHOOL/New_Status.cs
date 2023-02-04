using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace SCHOOL
{
    public partial class New_Status : Form
    {
        DBAccess objDBAccess = new DBAccess();
        Class_Student std = new Class_Student();
        Class_Status statuss = new Class_Status();


        public New_Status()
        {
            InitializeComponent();
        }

        private void New_Status_Load(object sender, EventArgs e)
        {
            showstd();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DataTable table = statuss.getList(new SQLiteCommand("Select * From Status_Registration where StdId='" + TxtID.Text + "' AND Term='" + ComboTerm.Text + "' AND Status='" + ComboStatus.Text + "'" +
               "AND Session='" + TxtSession.Text + "'"));
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This record already exist... You Can Edit it in the Manage Status Tab", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TxtID.Text == "")
                {
                    MessageBox.Show("Select the student you want to add status to ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TxtSession.Text == "")
                {
                    MessageBox.Show("Enter the session for the record you entered...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ComboTerm.Equals(""))
                {
                    MessageBox.Show("Select the term for the record you update...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ComboStatus.Text == "")
                {
                    MessageBox.Show("Select students status...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLiteCommand inserCommand = new SQLiteCommand("insert into Status_Registration" +
                      "( StdID, Status,Term, Session) " +
                      "values(@id, @status,@term, @session) ");


                    inserCommand.Parameters.AddWithValue("@id", TxtID.Text);
                    inserCommand.Parameters.AddWithValue("@status", ComboStatus.Text);
                    inserCommand.Parameters.AddWithValue("@term", ComboTerm.Text);
                    inserCommand.Parameters.AddWithValue("@session", TxtSession.Text);

                    int row = objDBAccess.executeQuery(inserCommand);
                    if (row == 1)
                    {
                        MessageBox.Show("Entry Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtSurname.Focus();

                        clear();

                    }
                    else
                    {
                        MessageBox.Show("Error occured please try again...", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtSurname.Focus();
                    }
                }
            }
        }
        // In this Form all i need is to show student list kawai....
        public void showstd()
        {
            DgvReg.DataSource = std.GetStudentlist(new SQLiteCommand("Select Stdid, Surname,Other_Names FROM Student_Registration"));
        }

        public void clear()
        {
            TxtSurname.Text = "";
            TxtOthers.Text = "";
            TxtSession.Text = "";
            ComboStatus.SelectedIndex = -1;
            ComboTerm.SelectedIndex = -1;
            TxtID.Text = "";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DgvReg.DataSource = std.searchStudent(TxtSearch.Text); 
        }

        private void DgvReg_Click(object sender, EventArgs e)
        {
            TxtID.Text = DgvReg.CurrentRow.Cells[0].Value.ToString();
            TxtSurname.Text = DgvReg.CurrentRow.Cells[1].Value.ToString();
            TxtOthers.Text = DgvReg.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}