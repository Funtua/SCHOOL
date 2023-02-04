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
    public partial class Session_Finished : Form
    {
        public Session_Finished()
        {
            InitializeComponent();
        }

        private void Btn_Restore_Backup_Click(object sender, EventArgs e)
        {
            Backup_Restore b = new Backup_Restore();
            b.Show();
        }
    }
}
