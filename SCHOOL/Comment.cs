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
    public partial class Comment : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtCommsH = new DataTable();
        DataTable dtCommsC = new DataTable();
        public Comment()
        {
            InitializeComponent();
        }
        public void clearH()
        {
            Txt70.Text = "";
            Txt60.Text = "";
            Txt50.Text = "";
            Txt40.Text = "";
            Txt0.Text = "";
        }
        public void ClearC()
        {
            Txt70C.Text = "";
            Txt60C.Text = "";
            Txt50C.Text = "";
            Txt40C.Text = "";
            Txt0C.Text = "";
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
             
            string query = "update Comms set Com1='"+Txt70.Text+"', Com2='"+Txt60.Text+"', Com3='"+Txt50.Text+"', Com4='"+Txt40.Text+"', Com5='"+Txt0.Text+"' where SNo='"+TxtHeadmaster.Text+"'";
            SQLiteCommand UpdateCommand = new SQLiteCommand(query);

            int row = objDBAccess.executeQuery(UpdateCommand);
            if (row == 1)
            {
                MessageBox.Show("Record Updated Successfully...", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
            }
            else
            {
                MessageBox.Show("Error Occured, Please try again...", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void UpdateClassTeacher_Click(object sender, EventArgs e)
        {
            // Class Teacher
            string query = "update Comms set Com1='" + Txt70C.Text + "', Com2='" + Txt60C.Text + "', Com3='" + Txt50C.Text + "', Com4='" + Txt40C.Text + "', Com5='" + Txt0C.Text + "' where SNo='" + TxtClassTeacher.Text + "'";
            SQLiteCommand UpdateCommand = new SQLiteCommand(query);

            int row = objDBAccess.executeQuery(UpdateCommand);
            if (row == 1)
            {
                MessageBox.Show("Record Updated Successfully...", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Error Occured, Please try again...", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearH();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ClearC();
        }
        public void readHeadmaster()
        {
            
            string query = "SELECT * from Comms where SNo='1'";
            objDBAccess.readDatathroughAdapter(query, dtCommsH);

            if (dtCommsH.Rows.Count == 1)
            {
                //2nd November 2000

                Txt70.Text = dtCommsH.Rows[0]["Com1"].ToString();
                Txt60.Text = dtCommsH.Rows[0]["Com2"].ToString();
                Txt50.Text = dtCommsH.Rows[0]["Com3"].ToString();
                Txt40.Text = dtCommsH.Rows[0]["Com4"].ToString();
                Txt0.Text = dtCommsH.Rows[0]["Com5"].ToString();
            }

        }

        public void readClassMaster()
        {
            
            string query = "Select * FROM Comms WHERE SNo='" + TxtClassTeacher.Text + "'";
            objDBAccess.readDatathroughAdapter(query, dtCommsC);

            if (dtCommsC.Rows.Count == 1)
            {
                Txt70C.Text = dtCommsC.Rows[0]["Com1"].ToString();
                Txt60C.Text = dtCommsC.Rows[0]["Com2"].ToString();
                Txt50C.Text = dtCommsC.Rows[0]["Com3"].ToString();
                Txt40C.Text = dtCommsC.Rows[0]["Com4"].ToString();
                Txt0C.Text = dtCommsC.Rows[0]["Com5"].ToString();
            }

        }
        private void Comment_Load(object sender, EventArgs e)
        {
            readHeadmaster();
            readClassMaster();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
          // readHeadmaster();
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
           // readClassMaster();
        }
    }
}
