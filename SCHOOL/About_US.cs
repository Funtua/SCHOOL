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
    public partial class About_US : Form
    {
        public About_US()
        {
            InitializeComponent();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LblExit_MouseHover(object sender, EventArgs e)
        {
            LblExit.ForeColor = Color.Red;
        }

        private void LblExit_MouseLeave(object sender, EventArgs e)
        {
            LblExit.ForeColor = Color.Brown;
        }

        private void Minimize_MouseHover(object sender, EventArgs e)
        {
            Minimize.ForeColor = Color.Red;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.ForeColor = Color.Brown;
        }
    }
}
