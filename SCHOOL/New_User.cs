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


namespace SCHOOL
{
    public partial class New_User : Form
    {
        Class_Student std = new Class_Student();
        DBAccess objDBAccess = new DBAccess();
        public New_User()
        {
            InitializeComponent();
        }
        public void showTable()
        {
            DgvReg.DataSource = std.GetStudentlist(new SQLiteCommand("Select * FROM Sign_in"));
           
        }
        public void hide()
        {
            lblname.Hide();
            LblPassword.Hide();
            LblUsername.Hide();
        }
        private void New_User_Load(object sender, EventArgs e)
        {
            hide();
            showTable();
        }

        private void DgvReg_Click(object sender, EventArgs e)
        {
            TxtName.Text = DgvReg.CurrentRow.Cells[1].Value.ToString();
            TxtUsername.Text = DgvReg.CurrentRow.Cells[2].Value.ToString();
            TxtPassword.Text = DgvReg.CurrentRow.Cells[3].Value.ToString();
        }
        public void clear()
        {
            TxtName.Text = "";
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtName.Text == "")
                    lblname.Show();
                else if (TxtUsername.Text == "")
                    LblUsername.Show();
                else if (TxtPassword.Text == "")
                    LblPassword.Show();
                else
                {
                    string query = "insert into  Sign_in (Name,Username, Password) values(@name,@uname, @pword)";
                    SQLiteCommand insertCommand = new SQLiteCommand(query);

                    insertCommand.Parameters.AddWithValue("@name", TxtName.Text);
                    insertCommand.Parameters.AddWithValue("@uname", TxtUsername.Text);
                    insertCommand.Parameters.AddWithValue("@pword", TxtPassword.Text);

                    int row = objDBAccess.executeQuery(insertCommand);
                    if (row == 1)
                    {
                        MessageBox.Show("Record inserted Successfully...", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showTable();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Error Occured, Please try again...", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected record...", "Delete Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {


                    string query = "Delete from Sign_in Where ID=@id";
                    SQLiteCommand DeleteCommand = new SQLiteCommand(query);
                    DeleteCommand.Parameters.AddWithValue("@id", DgvReg.CurrentRow.Cells[0].Value.ToString());

                    int row = objDBAccess.executeQuery(DeleteCommand);
                    if (row == 1)
                    {
                        MessageBox.Show("Record Deleted Successfully...", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showTable();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Error Occured, Please try again...", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtName.Text == "")
                    lblname.Show();
                else if (TxtUsername.Text == "")
                    LblUsername.Show();
                else if (TxtPassword.Text == "")
                    LblPassword.Show();
                else
                {
                    string query = "update  Sign_in set Name=@name, Username=@uname, Password=@pword where ID=@id";
                    SQLiteCommand UpdateCommand = new SQLiteCommand(query);

                    UpdateCommand.Parameters.AddWithValue("@id", DgvReg.CurrentRow.Cells[0].Value.ToString());
                    UpdateCommand.Parameters.AddWithValue("@name", TxtName.Text);
                    UpdateCommand.Parameters.AddWithValue("@uname", TxtUsername.Text);
                    UpdateCommand.Parameters.AddWithValue("@pword", TxtPassword.Text);
                   
                    int row = objDBAccess.executeQuery(UpdateCommand);
                    if (row == 1)
                    {
                        MessageBox.Show("Record Updated Successfully...", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showTable();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Error Occured, Please try again...", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
