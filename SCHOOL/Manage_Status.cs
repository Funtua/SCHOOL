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
    public partial class Manage_Status : Form
    {

        DBAccess objDBAccess = new DBAccess();
        Class_Student std = new Class_Student();
        Class_Status statuss = new Class_Status();

        public Manage_Status()
        {
            InitializeComponent();
        }
        // In this all i need is the status table kawai
        public void showstatus()
        {
            DgvReg.DataSource = std.GetStudentlist(new SQLiteCommand("SELECT StatusID, Student_Registration.StdID, Surname, Other_Names, Status,Term, Session FROM Student_Registration INNER JOIN Status_Registration ON Status_Registration.StdID=Student_Registration.StdID"));
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
            DgvReg.DataSource = statuss.searchStatus(TxtSearch.Text);
            TxtSearch.Text = "";
        }

        private void Manage_Status_Load(object sender, EventArgs e)
        {
            showstatus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Delete the selected record...", "Delete Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {


                string query = "Delete from Status_Registration Where StatusID=@id";
                SQLiteCommand DeleteCommand = new SQLiteCommand(query);
                DeleteCommand.Parameters.AddWithValue("@id", TxtStatusID.Text);

                int row = objDBAccess.executeQuery(DeleteCommand);
                if (row == 1)
                {
                    MessageBox.Show("Record Deleted Successfully...", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showstatus();
                    clear();
                }
                else
                {
                    MessageBox.Show("Error Occured, Please try again...", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void DgvReg_Click(object sender, EventArgs e)
        {
            // i am having problem with the combo box and will fix it later Insha Allahu Rabbi
            TxtStatusID.Text = DgvReg.CurrentRow.Cells[0].Value.ToString();
            TxtID.Text = DgvReg.CurrentRow.Cells[1].Value.ToString();
            TxtSurname.Text = DgvReg.CurrentRow.Cells[2].Value.ToString();
            TxtOthers.Text = DgvReg.CurrentRow.Cells[3].Value.ToString();
            ComboStatus.SelectedIndex = ComboStatus.FindString(this.DgvReg.CurrentRow.Cells[4].Value.ToString());
            ComboTerm.SelectedIndex=ComboTerm.FindString(this.DgvReg.CurrentRow.Cells[5].Value.ToString());
            TxtSession.Text = DgvReg.CurrentRow.Cells[6].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DataTable table = statuss.getList(new SQLiteCommand("Select * From Status_Registration where StdId='" + TxtID.Text + "' AND Term='" + ComboTerm.Text + "' AND Status='" + ComboStatus.Text + "'" +
          "AND Session='" + TxtSession.Text + "'"));
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This record already exist...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TxtStatusID.Equals(""))
                {
                    MessageBox.Show("Select a record from the table...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ComboStatus.Equals(""))
                {
                    MessageBox.Show("Select Student's status...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ComboTerm.Equals(""))
                {
                    MessageBox.Show("Select the term for the record you update...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TxtSession.Equals(""))
                {
                    MessageBox.Show("Enter the session to which the status will reflect...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "update Status_Registration set StdID=@id , Status=@status, Term=@term, Session=@session where StatusID=@sid";
                    SQLiteCommand UpdateCommand = new SQLiteCommand(query);

                    UpdateCommand.Parameters.AddWithValue("@sid", TxtStatusID.Text);
                    UpdateCommand.Parameters.AddWithValue("@id", TxtID.Text);
                    UpdateCommand.Parameters.AddWithValue("@status", ComboStatus.Text);
                    UpdateCommand.Parameters.AddWithValue("@term", ComboTerm.Text);
                    UpdateCommand.Parameters.AddWithValue("@session", TxtSession.Text);

                    int row = objDBAccess.executeQuery(UpdateCommand);
                    if (row == 1)
                    {
                        MessageBox.Show("Record Updated Successfully...", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showstatus();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Error Occured, Please try again...", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
