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
    public partial class Manage_Student : Form
    {
        Class_Student std = new Class_Student();
        DBAccess objDBAccess = new DBAccess();

        public Manage_Student()
        {
            InitializeComponent();
        }
        public void showTable()
        {
            DgvReg.DataSource = std.GetStudentlist(new SQLiteCommand("Select * FROM Student_Registration"));
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            ImageColumn = (DataGridViewImageColumn)DgvReg.Columns[7];
            ImageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void Manage_Student_Load(object sender, EventArgs e)
        {
            showTable();
        }
        public void Upload()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "(*.jpG;*.png;*.Gif;*.bmp)|*.jpG;*.png;*.Gif;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                PictureReg.Image = Image.FromFile(open.FileName);
            }
        }

        private void DgvReg_Click(object sender, EventArgs e)
        {
            TxtID.Text = DgvReg.CurrentRow.Cells[0].Value.ToString();
            TxtSurname.Text = DgvReg.CurrentRow.Cells[1].Value.ToString();
            TxtOthers.Text = DgvReg.CurrentRow.Cells[2].Value.ToString();
            DateDOB.Value = DateTime.ParseExact(DgvReg.CurrentRow.Cells[3].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //DateDOB.Value.ToString("dd/MM/yyyy"));
            //DateDOB.Value = DgvReg.CurrentRow.Cells[3].Value;
            if (DgvReg.CurrentRow.Cells[4].Value.ToString() == "Male")
                RadioMale.Checked = true;
            else if (DgvReg.CurrentRow.Cells[4].Value.ToString() == "Female")
                RadioFemale.Checked = true;
            else
            {
                //Do nothing...
            }
            TxtPhone.Text = DgvReg.CurrentRow.Cells[5].Value.ToString();

            TxtAddress.Text = DgvReg.CurrentRow.Cells[6].Value.ToString();

            //Saura PicureBox
            MemoryStream ms = new MemoryStream((byte[])DgvReg.CurrentRow.Cells[7].Value);
            PictureReg.Image = Image.FromStream(ms);
        }

        private void BtnUpdload_Click(object sender, EventArgs e)
        {
            Upload();
        }
        public void clear()
        {
            DgvReg.ClearSelection();
            TxtSearch.Clear();
            TxtSurname.Clear();
            TxtOthers.Clear();
            TxtPhone.Clear();
            TxtAddress.Clear();
            PictureReg.Image = null;
            RadioFemale.Checked = false;
            RadioMale.Checked = true;
            DateDOB.Value = DateTime.Today;
            TxtID.Text = "";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected record...", "Delete Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {


                string query = "Delete from Student_Registration Where StdID=@id";
                SQLiteCommand DeleteCommand = new SQLiteCommand(query);
                DeleteCommand.Parameters.AddWithValue("@id", TxtID.Text);

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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DgvReg.DataSource = std.searchStudent(TxtSearch.Text);
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            ImageColumn = (DataGridViewImageColumn)DgvReg.Columns[7];
            ImageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            TxtSearch.Clear();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtID.Text);
            string surname = TxtSurname.Text;
            string others = TxtOthers.Text;
            string date = DateDOB.Text;
            string address = TxtAddress.Text;
            string Phone = TxtPhone.Text;

            string gender = "";
            bool isChecked = RadioMale.Checked;
            if (isChecked)
                gender = RadioMale.Text;
            else
                gender = RadioFemale.Text;


            if (surname.Equals(""))
            {
                MessageBox.Show("Please enter Student's Surname..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (others.Equals(""))
            {
                MessageBox.Show("Please enter Student's Othernames..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (date.Equals(""))
            {
                MessageBox.Show("Please Select Student's Birth Date..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (gender.Equals(""))
            {
                MessageBox.Show("Please Select Student's Gender..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (id.Equals(""))
            {
                MessageBox.Show("Select the student you want to edit..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (address.Equals(""))
            {
                MessageBox.Show("Please enter Student's Home Address..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PictureReg.Image == null)
            {
                MessageBox.Show("Please Select Students Passport", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "update Student_Registration set Surname=@surname , Other_Names=@Others, DOB=@dob, Gender=@Gender, Phone=@phone, Address=@address, Photo=@photo where StdId=@id";
                SQLiteCommand UpdateCommand = new SQLiteCommand(query);

                UpdateCommand.Parameters.AddWithValue("@id", id);
                UpdateCommand.Parameters.AddWithValue("@surname", surname);
                UpdateCommand.Parameters.AddWithValue("@Others", others);
                UpdateCommand.Parameters.AddWithValue("@dob", DateDOB.Value.ToString("dd/MM/yyyy"));
                UpdateCommand.Parameters.AddWithValue("@Gender", gender);
                UpdateCommand.Parameters.AddWithValue("@phone", Phone);
                UpdateCommand.Parameters.AddWithValue("@address", address);
                MemoryStream msm = new MemoryStream();
                PictureReg.Image.Save(msm, PictureReg.Image.RawFormat);
                UpdateCommand.Parameters.AddWithValue("@photo", msm.ToArray());

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
    }
}
