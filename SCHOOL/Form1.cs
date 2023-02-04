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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private Form activeform = null;

        private void openchildform(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.None;
            Panel_Main.Controls.Add(childform);
            Panel_Main.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void hideSubMenu()
        {
            if (PanelStudent.Visible == true)
                PanelStudent.Visible = false;
            if (PanelProgress.Visible == true)
                PanelProgress.Visible = false;
            if (Panel_Result_Entry.Visible == true)
                Panel_Result_Entry.Visible = false;
            if (PanelManagement.Visible == true)
                PanelManagement.Visible = false;
        }
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            hideSubMenu();
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildform(new New_Student());
        }

        private void BtnManageStd_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildform(new Manage_Student());
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelStudent);
        }
        private void BtnProgress_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelProgress);
        }

        private void TTime_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("ddd,d,M,yyyy, (hh:mm)");
        }

        private void BtnNewStudentStatus_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildform(new New_Status());
        }

        private void BtnManageStudentStatus_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildform(new Manage_Status());
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            showSubMenu(Panel_Result_Entry);
        }

        private void BtnPrimary_Classes_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildform(new New_Primary_Result());
        }

        private void BtnManage_Primary_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildform(new Manage_Primary_Result());
        }

        private void BtnNur_Classes_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildform(new New_Nursery_Result());

        }

        private void BtnManage_Nur_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildform(new Manage_Nursery_Result());
        }

        private void BtnPrintResult_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildform(new Print_Result());
        }

        private void BtnScore_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelManagement);
        }

        private void BtnPrintStd_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildform(new Print_Students());
        }

        private void BtnPrintStatus_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildform(new Print_Status());
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildform(new Backup_Restore());
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            if(activeform!=null)
                activeform.Close();
//            Panel_Main.Controls.Add(Panel_Main);
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildform(new Enter());
        }

        private void Comments_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildform(new Comment());

        }

        private void OpenAndClosure_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildform(new Next_Term_Begins());
        }
    }
}
