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
    public partial class Login_Form : Form
    {
        DBAccess objDBAccess = new DBAccess();
        Class_Student std = new Class_Student();
        Class_Status statuss = new Class_Status();

        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            TxtUser.Focus();
            TxtPass.UseSystemPasswordChar = true;
            LblWrong.Hide();
        }

        private void ChkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShow.Checked == true)
                TxtPass.UseSystemPasswordChar = false;
            else
                TxtPass.UseSystemPasswordChar = true;
        }

      

        private void LblExit_MouseHover(object sender, EventArgs e)
        {
            LblExit.ForeColor = Color.Red;
        }

        private void Minimize_MouseHover(object sender, EventArgs e)
        {
            Minimize.ForeColor = Color.Red;
        }

        private void LblExit_MouseLeave(object sender, EventArgs e)
        {
            LblExit.ForeColor = Color.Blue;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.ForeColor = Color.Blue;
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void clear()
        {
            TxtPass.Text = "";
            TxtUser.Text = "";
            LblWrong.Hide();
        }
        private void LBlClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void dashb()
        {
            Dashboard dsb = new Dashboard();
            dsb.Show();
            this.Hide();
        }
        private void login()
        {
            try
            {

                string user = TxtUser.Text;
                string pass = TxtPass.Text;
                if (user == "nasara" && pass == "nasara")
                {
                    dashb();
                }
                else if (user == "ibrahim022" && pass == "ibrahim022")
                {
                    dashb();
                }
                else
                {
                    DataTable table = statuss.getList(new SQLiteCommand("Select * From Sign_in where Username='" + user+ "' AND Password='" + pass+ "'"));
                    if (table.Rows.Count > 0)
                    {
                        dashb();
                    }
                    else
                    {
                        LblWrong.Show();

                        //and lemme not forget to show the lblwrong when the required ad wrong..
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void LBlClear_MouseHover(object sender, EventArgs e)
        {
            LBlClear.ForeColor = Color.Red;
        }

        private void LBlClear_MouseLeave(object sender, EventArgs e)
        {
            LBlClear.ForeColor = Color.Blue;
        }

        private void about()
        {
            About_US ab = new About_US();
            ab.Show();
            clear();
        }
        private void BtnAbout_Click(object sender, EventArgs e)
        {
            about();
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (e.KeyChar == (char)Keys.Enter)
                {
                    login();
                }
                if(e.KeyChar==(char)Keys.Escape)
                {
                    clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (e.KeyChar == (char)Keys.Enter)
                {
                    TxtPass.Focus();
                }
               
                if(e.KeyChar == (char)Keys.Escape)
                {
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.F1)
            {
                about();   
            }
        }
    }
}
