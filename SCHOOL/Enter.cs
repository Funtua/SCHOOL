using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHOOL
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }
        public void open()
        {
            New_User user = new New_User();
            user.Show();
            TxtEnter.Text = "";
            lblname.Hide();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtEnter.Text == "ibrahim022")
                {
                    open();
                }
                else if (TxtEnter.Text == "Nasara")
                {
                    open();
                }
                else
                    lblname.Show();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Enter_Load(object sender, EventArgs e)
        {
            TxtEnter.Focus();
            lblname.Hide();
        }
    }
}
