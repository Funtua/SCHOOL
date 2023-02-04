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
    public partial class New_Student : Form
    {
        DBAccess objDBAccess = new DBAccess();
        Class_Student std = new Class_Student();

        public New_Student()
        {
            InitializeComponent();
        }

        //to clear all data's wriiten 
        public void clear()
        {
            TxtSurname.Clear();
            TxtOthers.Clear();
            TxtPhone.Clear();
            TxtAddress.Clear();
            PictureReg.Image = null;
            RadioFemale.Checked = false;
            RadioMale.Checked = true;
            DateDOB.Value = DateTime.Today;
        }
        //to upload pictue in the picturebox
        public void Upload()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "(*.jpG;*.png;*.Gif;*.bmp)|*.jpG;*.png;*.Gif;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                PictureReg.Image = Image.FromFile(open.FileName);
            }
        }
        //to show list in the datagridview
        public void showTable()
        {
            DgvReg.DataSource = std.GetStudentlist(new SQLiteCommand("Select * FROM Student_Registration"));
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            ImageColumn = (DataGridViewImageColumn)DgvReg.Columns[7];
            ImageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        private void BtnUpdload_Click(object sender, EventArgs e)
        {
            Upload();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
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
                SQLiteCommand inserCommand = new SQLiteCommand("insert into Student_Registration" +
                  "(Surname,Other_Names,DOB,Gender,Phone,Address, Photo) " +
                  "values(@surname, @Others,@dob, @gender,@phone, @address,@photo) ");

                inserCommand.Parameters.AddWithValue("@surname", surname);
                inserCommand.Parameters.AddWithValue("@Others", others);
                inserCommand.Parameters.AddWithValue("@dob", DateDOB.Value.ToString("dd/MM/yyyy"));
                inserCommand.Parameters.AddWithValue("@gender", gender);
                inserCommand.Parameters.AddWithValue("@phone", Phone);
                inserCommand.Parameters.AddWithValue("@address", address);

                MemoryStream menstr = new MemoryStream();

                PictureReg.Image.Save(menstr, PictureReg.Image.RawFormat);
                inserCommand.Parameters.AddWithValue("@photo", menstr.ToArray());

                int row = objDBAccess.executeQuery(inserCommand);
                if (row == 1)
                {
                    MessageBox.Show("Entry Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtSurname.Focus();
                    showTable();
                    clear();

                }
                else
                {
                    MessageBox.Show("Error occured please try again...", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Clear();
                    TxtSurname.Focus();
                }

            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void New_Student_Load(object sender, EventArgs e)
        {
            showTable();
        }
    }
}
