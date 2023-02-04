using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHOOL
{
    public partial class Next_Term_Begins : Form
    {
        DBAccess objDBAccess = new DBAccess();
        public Next_Term_Begins()
        {
            InitializeComponent();
        }
        
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBegins.Text = "";
            TxtCloses.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string query = "update nextterm set clos='" + TxtCloses.Text + "', opeen='" + TxtBegins.Text + "' where NSNo='" + TxtHeadmaster.Text + "'";
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

        private void Next_Term_Begins_Load(object sender, EventArgs e)
        {
            DataTable dtCommsH = new DataTable();
            string query = "Select * FROM nextterm WHERE NSNo='" + TxtHeadmaster.Text + "'";
            objDBAccess.readDatathroughAdapter(query, dtCommsH);

            if (dtCommsH.Rows.Count == 1)
            {
                TxtCloses.Text = dtCommsH.Rows[0]["clos"].ToString();
                TxtBegins.Text = dtCommsH.Rows[0]["opeen"].ToString();
                
            }
        }
    }
}
