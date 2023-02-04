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
    public partial class New_Primary_Result : Form
    {
        DBAccess objDBAccess = new DBAccess();
        Class_Status statuss = new Class_Status();

        public New_Primary_Result()
        {
            InitializeComponent();
        }

        public void showData()
        {
            // this is to insert data into datagridview, and combosession
            ComboSession.DataSource = statuss.getList(new SQLiteCommand("Select distinct Session FROM Status_Registration"));
            ComboSession.DisplayMember = "Session";
            ComboSession.ValueMember = "Session";
        }

        private void New_Primary_Result_Load(object sender, EventArgs e)
        {
            showData();
            
            Eng1.Focus();

            ComboSession.SelectedIndex = -1;
            ComboTerm.SelectedIndex = -1;
            ComboClass.SelectedIndex = -1;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DgvReg.DataSource = statuss.getList(new SQLiteCommand("SELECT StatusID, Student_Registration.StdID, Surname, Other_Names, Status, Term, Session FROM Student_Registration INNER JOIN Status_Registration ON Status_Registration.StdID=Student_Registration.StdID WHERE Status='" + ComboClass.Text + "' AND Term='" + ComboTerm.Text + "' AND Session='" + ComboSession.Text + "' "));
            ComboSession.SelectedIndex = -1;
            ComboTerm.SelectedIndex= -1;
            ComboClass.SelectedIndex= -1;
        }
        private void DgvReg_Click(object sender, EventArgs e)
        {
            if (DgvReg.DataSource != null)
            {
                TxtStatusID.Text = DgvReg.CurrentRow.Cells[0].Value.ToString();
                TxtID.Text = DgvReg.CurrentRow.Cells[1].Value.ToString();
                TxtSurname.Text = DgvReg.CurrentRow.Cells[2].Value.ToString();
                TxtOthers.Text = DgvReg.CurrentRow.Cells[3].Value.ToString();
                TxtClass.Text = DgvReg.CurrentRow.Cells[4].Value.ToString();
                TxtTerm.Text = DgvReg.CurrentRow.Cells[5].Value.ToString();
                TxtSession.Text = DgvReg.CurrentRow.Cells[6].Value.ToString();
            }
        }
        public void clear()
        {

            //tired of clearing each textbox and i found this...
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                else if(control is ComboBox)
                        (control as ComboBox).SelectedIndex=-1;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            // my adding is on a problem e no won work a no no was up... e don do now i forgot to put coma... the next thing is my condition to save
            // and the condition supposed to be for it to check if a Statusid Already
            // that one to don do Alhamdulillahi Rabil Alameen...

           
            DataTable table = statuss.getList(new SQLiteCommand("SELECT * from Primary_Result WHERE StatusID='"+TxtStatusID.Text+"'"));
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This record already exist... You Can Edit it in the Manage Primary Student's Result Tab", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                 
                if (TxtID.Equals(""))
                {
                    MessageBox.Show("Select the student you want to add result to...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TxtTotal.Text=="")
                {
                    MessageBox.Show("Whats the total Score?...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    SQLiteCommand inserCommand = new SQLiteCommand("insert into Primary_Result" +
                      "(StdID, StatusID, Eng1, Eng2, EngE, EngG, EngT, Math1, Math2, MathE, MathG, MathT, Sos1, Sos2, SosE, SosG, SosT," +
                      "Civic1, Civic2, CivicE, CivicG, CivicT, Health1, Health2, HealthE, HealthG, HealthT, Comp1, Comp2, CompE, CompG, CompT," +
                      "Agric1, Agric2, AgricE, AgricG, AgricT, Basic1, Basic2, BasicE, BasicG, BasicT, Quan1, Quan2, QuanE, QuanG, QuanT," +
                      "Ver1, Ver2, VerE, VerT, VerG, CCA1, CCA2, CCAE, CCAT, CCAG, Home1, Home2, HomeE, HomeT, HomeG,GTOTAL)" +
                     
                      "values(@stdid,@statusid, @Eng1,@Eng2,@EngE,@EngG,@EngT, @Math1, @Math2, @MathE, @MathG,@MathT, @Sos1, @Sos2,@SosE,@SosG,@SosT," +
                      "@Civic1, @Civic2, @CivicE, @CivicG, @CivicT, @Health1, @Health2, @HealthE, @HealthG, @HealthT, @Comp1, @Comp2, @CompE, @CompG, @CompT," +
                      "@Agric1, @Agric2, @AgricE, @AgricG, @AgricT, @Basic1, @Basic2, @BasicE, @BasicG, @BasicT, @Quan1, @Quan2, @QuanE, @QuanG, @QuanT," +
                      "@Ver1, @Ver2, @VerE, @VerT, @VerG, @CCA1, @CCA2, @CCAE, @CCAT, @CCAG, @Home1, @Home2, @HomeE, @HomeT, @HomeG,@tot) ");

                    inserCommand.Parameters.AddWithValue("@stdid", TxtID.Text);
                    inserCommand.Parameters.AddWithValue("@statusid", TxtStatusID.Text);

                    inserCommand.Parameters.AddWithValue("@Eng1", Eng1.Text);
                    inserCommand.Parameters.AddWithValue("@Eng2", Eng2.Text);
                    inserCommand.Parameters.AddWithValue("@EngE", EngE.Text);
                    inserCommand.Parameters.AddWithValue("@EngT", EngT.Text);
                    inserCommand.Parameters.AddWithValue("@EngG", EngG.Text);

                    inserCommand.Parameters.AddWithValue("@Math1", Math1.Text);
                    inserCommand.Parameters.AddWithValue("@Math2", Math2.Text);
                    inserCommand.Parameters.AddWithValue("@MathE", MathE.Text);
                    inserCommand.Parameters.AddWithValue("@MathT", MathT.Text);
                    inserCommand.Parameters.AddWithValue("@MathG", MathG.Text);

                    inserCommand.Parameters.AddWithValue("@Sos1", Sos1.Text);
                    inserCommand.Parameters.AddWithValue("@Sos2", Sos2.Text);
                    inserCommand.Parameters.AddWithValue("@SosE", SosE.Text);
                    inserCommand.Parameters.AddWithValue("@SosT", SosT.Text);
                    inserCommand.Parameters.AddWithValue("@SosG", SosG.Text);

                    inserCommand.Parameters.AddWithValue("@Civic1", Civic1.Text);
                    inserCommand.Parameters.AddWithValue("@Civic2", Civic2.Text);
                    inserCommand.Parameters.AddWithValue("@CivicE", CivicE.Text);
                    inserCommand.Parameters.AddWithValue("@CivicT", CivicT.Text);
                    inserCommand.Parameters.AddWithValue("@CivicG", CivicG.Text);

                    inserCommand.Parameters.AddWithValue("@Health1", Health1.Text);
                    inserCommand.Parameters.AddWithValue("@Health2", Health2.Text);
                    inserCommand.Parameters.AddWithValue("@HealthE", HealthE.Text);
                    inserCommand.Parameters.AddWithValue("@HealthT", HealthT.Text);
                    inserCommand.Parameters.AddWithValue("@HealthG", HealthG.Text);

                    inserCommand.Parameters.AddWithValue("@Comp1", Comp1.Text);
                    inserCommand.Parameters.AddWithValue("@Comp2", Comp2.Text);
                    inserCommand.Parameters.AddWithValue("@CompE", CompE.Text);
                    inserCommand.Parameters.AddWithValue("@CompT", CompT.Text);
                    inserCommand.Parameters.AddWithValue("@CompG", CompG.Text);

                    inserCommand.Parameters.AddWithValue("@Agric1", Agric1.Text);
                    inserCommand.Parameters.AddWithValue("@Agric2", Agric2.Text);
                    inserCommand.Parameters.AddWithValue("@AgricE", AgricE.Text);
                    inserCommand.Parameters.AddWithValue("@AgricT", AgricT.Text);
                    inserCommand.Parameters.AddWithValue("@AgricG", AgricG.Text);

                    inserCommand.Parameters.AddWithValue("@Basic1", Basic1.Text);
                    inserCommand.Parameters.AddWithValue("@Basic2", Basic2.Text);
                    inserCommand.Parameters.AddWithValue("@BasicE", BasicE.Text);
                    inserCommand.Parameters.AddWithValue("@BasicT", BasicT.Text);
                    inserCommand.Parameters.AddWithValue("@BasicG", BasicG.Text);

                    inserCommand.Parameters.AddWithValue("@Quan1", Quan1.Text);
                    inserCommand.Parameters.AddWithValue("@Quan2", Quan2.Text);
                    inserCommand.Parameters.AddWithValue("@QuanE", QuanE.Text);
                    inserCommand.Parameters.AddWithValue("@QuanT", QuanT.Text);
                    inserCommand.Parameters.AddWithValue("@QuanG", QuanG.Text);

                    inserCommand.Parameters.AddWithValue("@Ver1", Ver1.Text);
                    inserCommand.Parameters.AddWithValue("@Ver2", Ver2.Text);
                    inserCommand.Parameters.AddWithValue("@VerE", VerE.Text);
                    inserCommand.Parameters.AddWithValue("@VerT", VerT.Text);
                    inserCommand.Parameters.AddWithValue("@VerG", VerG.Text);

               
                    inserCommand.Parameters.AddWithValue("@CCA1", CCA1.Text);
                    inserCommand.Parameters.AddWithValue("@CCA2", CCA2.Text);
                    inserCommand.Parameters.AddWithValue("@CCAE", CCAE.Text);
                    inserCommand.Parameters.AddWithValue("@CCAT", CCAT.Text);
                    inserCommand.Parameters.AddWithValue("@CCAG", CCAG.Text);

                    inserCommand.Parameters.AddWithValue("@Home1", Home1.Text);
                    inserCommand.Parameters.AddWithValue("@Home2", Home2.Text);
                    inserCommand.Parameters.AddWithValue("@HomeE", HomeE.Text);
                    inserCommand.Parameters.AddWithValue("@HomeT", HomeT.Text);
                    inserCommand.Parameters.AddWithValue("@HomeG", HomeG.Text);

                    inserCommand.Parameters.AddWithValue("@tot", TxtTotal.Text);

                    int row = objDBAccess.executeQuery(inserCommand);
                    if (row == 1)
                    {
                        MessageBox.Show("Entry Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Eng1.Focus();

                        clear();

                    }
                    else
                    {
                        MessageBox.Show("Error occured please try again...", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Clear();
                        Eng1.Focus();
                    }
                    
                }
             }
        }

        private void Numbers_Only(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            TxtTotal.Text = "";
        }
 
        private void EngT_TextChanged(object sender, EventArgs e)
        {
            double[] grade = new double[4];

            if (EngT.Text != "")
            {
                grade[0] = Convert.ToDouble(EngT.Text);


               
                if (grade[0] >= 70)
                {
                    EngG.Text = "A";
                }
                else if (grade[0] >= 60)
                {
                    EngG.Text = "B";
                }
                else if (grade[0] >= 50)
                {
                    EngG.Text = "C";
                }
                else if (grade[0] >= 45)
                {
                    EngG.Text = "D";
                }
                else if (grade[0] >= 40)
                {
                    EngG.Text = "E";
                }
                else
                {
                    EngG.Text = "F";
                }
            }
            else
            {
                EngG.Text = "";
            }
        }

        private void MathT_TextChanged(object sender, EventArgs e)
        {
            double[] grade = new double[4];

            if (MathT.Text != "")
            {
                grade[0] = Convert.ToDouble(MathT.Text);


                
                if (grade[0] >= 70)
                {
                    MathG.Text = "A";
                }
                else if (grade[0] >= 60)
                {
                    MathG.Text = "B";
                }
                else if (grade[0] >= 50)
                {
                    MathG.Text = "C";
                }
                else if (grade[0] >= 45)
                {
                    MathG.Text = "D";
                }
                else if (grade[0] >= 40)
                {
                    MathG.Text = "E";
                }
                else
                {
                    MathG.Text = "F";
                }
            }
            else
            {
                MathG.Text = "";
            }
        }

        private void SosT_TextChanged(object sender, EventArgs e)
        {
            double[] grade = new double[4];

            if (SosT.Text != "")
            {
                grade[0] = Convert.ToDouble(SosT.Text);


                
                if (grade[0] >= 70)
                {
                    SosG.Text = "A";
                }
                else if (grade[0] >= 60)
                {
                    SosG.Text = "B";
                }
                else if (grade[0] >= 50)
                {
                    SosG.Text = "C";
                }
                else if (grade[0] >= 45)
                {
                    SosG.Text = "D";
                }
                else if (grade[0] >= 40)
                {
                    SosG.Text = "E";
                }
                else
                {
                    SosG.Text = "F";
                }
            }
            else
            {
                SosG.Text = "";
            }
        }

        private void CivicT_TextChanged(object sender, EventArgs e)
        {
            double[] grade = new double[4];

            if (CivicT.Text != "")
            {
                grade[0] = Convert.ToDouble(CivicT.Text);


                 
                if (grade[0] >= 70)
                {
                    CivicG.Text = "A";
                }
                else if (grade[0] >= 60)
                {
                    CivicG.Text = "B";
                }
                else if (grade[0] >= 50)
                {
                    CivicG.Text = "C";
                }
                else if (grade[0] >= 45)
                {
                    CivicG.Text = "D";
                }
                else if (grade[0] >= 40)
                {
                    CivicG.Text = "E";
                }
                else
                {
                    CivicG.Text = "F";
                }
            }
            else
            {
                CivicG.Text = "";
            }
        }

        private void HealthT_TextChanged(object sender, EventArgs e)
        {
            double[] grade = new double[4];

            if (HealthT.Text != "")
            {
                grade[0] = Convert.ToDouble(HealthT.Text);


                
                if (grade[0] >= 70)
                {
                    HealthG.Text = "A";
                }
                else if (grade[0] >= 60)
                {
                    HealthG.Text = "B";
                }
                else if (grade[0] >= 50)
                {
                    HealthG.Text = "C";
                }
                else if (grade[0] >= 45)
                {
                    HealthG.Text = "D";
                }
                else if (grade[0] >= 40)
                {
                    HealthG.Text = "E";
                }
                else
                {
                    HealthG.Text = "F";
                }
            }
            else
            {
                HealthG.Text = "";
            }
        }

        private void CompT_TextChanged(object sender, EventArgs e)
        {
            double[] grade = new double[4];

            if (CompT.Text != "")
            {
                grade[0] = Convert.ToDouble(CompT.Text);


                 
                if (grade[0] >= 70)
                {
                    CompG.Text = "A";
                }
                else if (grade[0] >= 60)
                {
                    CompG.Text = "B";
                }
                else if (grade[0] >= 50)
                {
                    CompG.Text = "C";
                }
                else if (grade[0] >= 45)
                {
                    CompG.Text = "D";
                }
                else if (grade[0] >= 40)
                {
                    CompG.Text = "E";
                }
                else
                {
                    CompG.Text = "F";
                }
            }
            else
            {
                CompG.Text = "";
            }
        }

        private void AgricT_TextChanged(object sender, EventArgs e)
        {
            double[] grade = new double[4];

            if (AgricT.Text != "")
            {
                grade[0] = Convert.ToDouble(AgricT.Text);


                
                if (grade[0] >= 70)
                {
                    AgricG.Text = "A";
                }
                else if (grade[0] >= 60)
                {
                    AgricG.Text = "B";
                }
                else if (grade[0] >= 50)
                {
                    AgricG.Text = "C";
                }
                else if (grade[0] >= 45)
                {
                    AgricG.Text = "D";
                }
                else if (grade[0] >= 40)
                {
                    AgricG.Text = "E";
                }
                else
                {
                    AgricG.Text = "F";
                }
            }
            else
            {
                AgricG.Text = "";
            }
        }

        private void BasicT_TextChanged(object sender, EventArgs e)
        {
            double[] grade = new double[4];

            if (BasicT.Text != "")
            {
                grade[0] = Convert.ToDouble(BasicT.Text);
 
                if (grade[0] >= 70)
                {
                    BasicG.Text = "A";
                }
                else if (grade[0] >= 60)
                {
                    BasicG.Text = "B";
                }
                else if (grade[0] >= 50)
                {
                    BasicG.Text = "C";
                }
                else if (grade[0] >= 45)
                {
                    BasicG.Text = "D";
                }
                else if (grade[0] >= 40)
                {
                    BasicG.Text = "E";
                }
                else
                {
                    BasicG.Text = "F";
                }
            }
            else
            {
                BasicG.Text = "";
            }
        }

        private void QuanT_TextChanged(object sender, EventArgs e)
        {
            double[] grade = new double[4];

            if (QuanT.Text != "")
            {
                grade[0] = Convert.ToDouble(QuanT.Text);
 
                if (grade[0] >= 70)
                {
                    QuanG.Text = "A";
                }
                else if (grade[0] >= 60)
                {
                    QuanG.Text = "B";
                }
                else if (grade[0] >= 50)
                {
                    QuanG.Text = "C";
                }
                else if (grade[0] >= 45)
                {
                    QuanG.Text = "D";
                }
                else if (grade[0] >= 40)
                {
                    QuanG.Text = "E";
                }
                else
                {
                    QuanG.Text = "F";
                }
            }
            else
            {
                QuanG.Text = "";
            }
        }

        private void VerT_TextChanged(object sender, EventArgs e)
        {
            double[] grade = new double[4];

            if (VerT.Text != "")
            {
                grade[0] = Convert.ToDouble(VerT.Text);
 
                if (grade[0] >= 70)
                {
                    VerG.Text = "A";
                }
                else if (grade[0] >= 60)
                {
                    VerG.Text = "B";
                }
                else if (grade[0] >= 50)
                {
                    VerG.Text = "C";
                }
                else if (grade[0] >= 45)
                {
                    VerG.Text = "D";
                }
                else if (grade[0] >= 40)
                {
                    VerG.Text = "E";
                }
                else
                {
                    VerG.Text = "F";
                }
            }
            else
            {
                VerG.Text = "";
            }
        }

        private void CCAT_TextChanged(object sender, EventArgs e)
        {
            double[] grade = new double[4];

            if (CCAT.Text != "")
            {
                grade[0] = Convert.ToDouble(CCAT.Text);
                 
                if (grade[0] >= 70)
                {
                    CCAG.Text = "A";
                }
                else if (grade[0] >= 60)
                {
                    CCAG.Text = "B";
                }
                else if (grade[0] >= 50)
                {
                    CCAG.Text = "C";
                }
                else if (grade[0] >= 45)
                {
                    CCAG.Text = "D";
                }
                else if (grade[0] >= 40)
                {
                    CCAG.Text = "E";
                }
                else
                {
                    CCAG.Text = "F";
                }
            }
            else
            {
                CCAG.Text = "";
            }
        }

        private void HomeT_TextChanged(object sender, EventArgs e)
        {
            double[] grade = new double[4];

            if (HomeT.Text != "")
            {
                grade[0] = Convert.ToDouble(HomeT.Text);

                GTOTAL();
                 
                if (grade[0] >= 70)
                {
                    HomeG.Text = "A";
                }
                else if (grade[0] >= 60)
                {
                    HomeG.Text = "B";
                }
                else if (grade[0] >= 50)
                {
                    HomeG.Text = "C";
                }
                else if (grade[0] >= 45)
                {
                    HomeG.Text = "D";
                }
                else if (grade[0] >= 40)
                {
                    HomeG.Text = "E";
                }
                else
                {
                    HomeG.Text = "F";
                }
            }
            else
            {
                HomeG.Text = "";
            }
        }
        public void GTOTAL()
        {
            if (EngT.Text != "" && MathT.Text != "" && SosT.Text != "" && CivicT.Text != "" && HealthT.Text != "" && CompT.Text != "" && AgricT.Text != "" && BasicT.Text != "" && QuanT.Text != "" && VerT.Text != "" && CCAT.Text != "" && HomeT.Text != "")
            {
                double[] S = new double[14];

                S[0] = Convert.ToDouble(EngT.Text);
                S[1] = Convert.ToDouble(MathT.Text);
                S[2] = Convert.ToDouble(SosT.Text);
                S[3] = Convert.ToDouble(CivicT.Text);
                S[4] = Convert.ToDouble(HealthT.Text);
                S[5] = Convert.ToDouble(CompT.Text);
                S[6] = Convert.ToDouble(AgricT.Text);
                S[7] = Convert.ToDouble(BasicT.Text);
                S[8] = Convert.ToDouble(QuanT.Text);
                S[9] = Convert.ToDouble(VerT.Text);
                S[10] = Convert.ToDouble(CCAT.Text);
                S[11] = Convert.ToDouble(HomeT.Text);

                S[12] = S[0] + S[1] + S[2] + S[3] + S[4] + S[5] + S[6] + S[7] + S[8] + S[9] + S[10] + S[11];

                String sum = Convert.ToString(S[12]);

                TxtTotal.Text = sum;
            }
            else
                TxtTotal.Text = "";
        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            GTOTAL();
        }

        private void EngE_TextChanged(object sender, EventArgs e)
        {
            if (Eng1.Text != "" && Eng2.Text != "" && EngE.Text != "")
            {
                double[] t = new double[4];
                t[0] = Convert.ToDouble(Eng1.Text);
                t[1] = Convert.ToDouble(Eng2.Text);
                t[2] = Convert.ToDouble(EngE.Text);

                t[3] = t[0] + t[1] + t[2];
                string tot = Convert.ToString(t[3]);

                EngT.Text = tot;
            }
            else
                EngT.Text = "";
        }

        private void MathE_TextChanged(object sender, EventArgs e)
        {
            if (Math1.Text != "" && Math2.Text != "" && MathE.Text != "")
            {
                double[] t = new double[4];
                t[0] = Convert.ToDouble(Math1.Text);
                t[1] = Convert.ToDouble(Math2.Text);
                t[2] = Convert.ToDouble(MathE.Text);

                t[3] = t[0] + t[1] + t[2];
                string tot = Convert.ToString(t[3]);

                MathT.Text = tot;
            }
            else
                MathT.Text = "";
        }

        private void SosE_TextChanged(object sender, EventArgs e)
        {
            if (Sos1.Text != "" && Sos2.Text != "" && SosE.Text != "")
            {
                double[] t = new double[4];
                t[0] = Convert.ToDouble(Sos1.Text);
                t[1] = Convert.ToDouble(Sos2.Text);
                t[2] = Convert.ToDouble(SosE.Text);

                t[3] = t[0] + t[1] + t[2];
                string tot = Convert.ToString(t[3]);

                SosT.Text = tot;
            }
            else
                SosT.Text = "";
        }

        private void CivicE_TextChanged(object sender, EventArgs e)
        {
            if (Civic1.Text != "" && Civic2.Text != "" && CivicE.Text != "")
            {
                double[] t = new double[4];
                t[0] = Convert.ToDouble(Civic1.Text);
                t[1] = Convert.ToDouble(Civic2.Text);
                t[2] = Convert.ToDouble(CivicE.Text);

                t[3] = t[0] + t[1] + t[2];
                string tot = Convert.ToString(t[3]);

                CivicT.Text = tot;
            }
            else
                CivicT.Text = "";
        }

        private void HealthE_TextChanged(object sender, EventArgs e)
        {
            if (Health1.Text != "" && Health2.Text != "" && HealthE.Text != "")
            {
                double[] t = new double[4];
                t[0] = Convert.ToDouble(Health1.Text);
                t[1] = Convert.ToDouble(Health2.Text);
                t[2] = Convert.ToDouble(HealthE.Text);

                t[3] = t[0] + t[1] + t[2];
                string tot = Convert.ToString(t[3]);

                HealthT.Text = tot;
            }
            else
                HealthT.Text = "";
        }

        private void CompE_TextChanged(object sender, EventArgs e)
        {
            if (Comp1.Text != "" && Comp2.Text != "" && CompE.Text != "")
            {
                double[] t = new double[4];
                t[0] = Convert.ToDouble(Comp1.Text);
                t[1] = Convert.ToDouble(Comp2.Text);
                t[2] = Convert.ToDouble(CompE.Text);

                t[3] = t[0] + t[1] + t[2];
                string tot = Convert.ToString(t[3]);

                CompT.Text = tot;
            }
            else
                CompT.Text = "";
        }

        private void AgricE_TextChanged(object sender, EventArgs e)
        {
            if (Agric1.Text != "" && Agric2.Text != "" && AgricE.Text != "")
            {
                double[] t = new double[4];
                t[0] = Convert.ToDouble(Agric1.Text);
                t[1] = Convert.ToDouble(Agric2.Text);
                t[2] = Convert.ToDouble(AgricE.Text);

                t[3] = t[0] + t[1] + t[2];
                string tot = Convert.ToString(t[3]);

                AgricT.Text = tot;
            }
            else
                AgricT.Text = "";
        }

        private void BasicE_TextChanged(object sender, EventArgs e)
        {
            if (Basic1.Text != "" && Basic2.Text != "" && BasicE.Text != "")
            {
                double[] t = new double[4];
                t[0] = Convert.ToDouble(Basic1.Text);
                t[1] = Convert.ToDouble(Basic2.Text);
                t[2] = Convert.ToDouble(BasicE.Text);

                t[3] = t[0] + t[1] + t[2];
                string tot = Convert.ToString(t[3]);

                BasicT.Text = tot;
            }
            else
                BasicT.Text = "";
        }

        private void QuanE_TextChanged(object sender, EventArgs e)
        {
            if (Quan1.Text != "" && Quan2.Text != "" && QuanE.Text != "")
            {
                double[] t = new double[4];
                t[0] = Convert.ToDouble(Quan1.Text);
                t[1] = Convert.ToDouble(Quan2.Text);
                t[2] = Convert.ToDouble(QuanE.Text);

                t[3] = t[0] + t[1] + t[2];
                string tot = Convert.ToString(t[3]);

                QuanT.Text = tot;
            }
            else
                QuanT.Text = "";
        }

        private void VerE_TextChanged(object sender, EventArgs e)
        {
            if (Ver1.Text != "" && Ver2.Text != "" && VerE.Text != "")
            {
                double[] t = new double[4];
                t[0] = Convert.ToDouble(Ver1.Text);
                t[1] = Convert.ToDouble(Ver2.Text);
                t[2] = Convert.ToDouble(VerE.Text);

                t[3] = t[0] + t[1] + t[2];
                string tot = Convert.ToString(t[3]);

                VerT.Text = tot;
            }
            else
                VerT.Text = "";
        }

        private void CCAE_TextChanged(object sender, EventArgs e)
        {
            if (CCA1.Text != "" && CCA2.Text != "" && CCAE.Text != "")
            {
                double[] t = new double[4];
                t[0] = Convert.ToDouble(CCA1.Text);
                t[1] = Convert.ToDouble(CCA2.Text);
                t[2] = Convert.ToDouble(CCAE.Text);

                t[3] = t[0] + t[1] + t[2];
                string tot = Convert.ToString(t[3]);

                CCAT.Text = tot;
            }
            else
                CCAT.Text = "";
        }

        private void HomeE_TextChanged(object sender, EventArgs e)
        {
            if (Home1.Text != "" && Home2.Text != "" && HomeE.Text != "")
            {
                double[] t = new double[4];
                t[0] = Convert.ToDouble(Home1.Text);
                t[1] = Convert.ToDouble(Home2.Text);
                t[2] = Convert.ToDouble(HomeE.Text);

                t[3] = t[0] + t[1] + t[2];
                string tot = Convert.ToString(t[3]);

                HomeT.Text = tot;
            }
            else
                HomeT.Text = "";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

       
    }
}
