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
    public partial class New_Nursery_Result : Form
    {
        DBAccess objDBAccess = new DBAccess();
        Class_Status statuss = new Class_Status();

        public New_Nursery_Result()
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

        private void New_Nursery_Result_Load(object sender, EventArgs e)
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
            ComboTerm.SelectedIndex = -1;
            ComboClass.SelectedIndex = -1;
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
                    else if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DataTable table = statuss.getList(new SQLiteCommand("SELECT * from Nursery_Result WHERE StatusID='" + TxtStatusID.Text + "'"));
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This record already exist... You Can Edit it in the Manage Primary Student's Result Tab", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                if (TxtID.Text=="")
                {
                    MessageBox.Show("Select the student you want to add result to...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TxtTotal.Text == "")
                {
                    MessageBox.Show("Whats the total Score?...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    SQLiteCommand inserCommand = new SQLiteCommand("insert into Nursery_Result" +
                      "(StdID, StatusID, No_Work1, No_Work2, No_WorkE,No_WorkT,No_WorkG, Pre_Reading1, Pre_Reading2, Pre_ReadingE, Pre_ReadingT, Pre_ReadingG, Rhymes1, Rhymes2, RhymesE, RhymesT, RhymesG, Writing1, Writing2, WritingE, WritingT, WritingG, CCA1, CCA2" +
                      ", CCAE, CCAT, CCAG, Science1, Science2, ScienceE, ScienceT, ScienceG, Social_H1, Social_H2, Social_HE, Social_HT, Social_HG, Health_H1, Health_H2, Health_HE, Health_HT, Health_HG, GTOTAL)" +

                      "values(@stdid,@statusid, @Eng1,@Eng2,@EngE,@EngT,@EngG, @Math1, @Math2, @MathE, @MathT,@MathG, @Sos1, @Sos2,@SosE,@SosT,@SosG," +
                      "@Civic1, @Civic2, @CivicE, @CivicT, @CivicG, @Health1, @Health2, @HealthE, @HealthT, @HealthG, @Comp1, @Comp2, @CompE, @CompT, @CompG," +
                      "@Agric1, @Agric2, @AgricE, @AgricT, @AgricG, @Basic1, @Basic2, @BasicE, @BasicT, @BasicG, @tot) ");

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
        private void BasicT_TextChanged(object sender, EventArgs e)
        {
            double[] grade = new double[4];

            if (BasicT.Text != "")
            {
                grade[0] = Convert.ToDouble(BasicT.Text);

                GTOTAL();

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
        public void GTOTAL()
        {
            if (EngT.Text != "" && MathT.Text != "" && SosT.Text != "" && CivicT.Text != "" && HealthT.Text != "" && CompT.Text != "" && AgricT.Text != "" && BasicT.Text != "" )
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


                S[8] = S[0] + S[1] + S[2] + S[3] + S[4] + S[5] + S[6] + S[7];

                String sum = Convert.ToString(S[8]);

                TxtTotal.Text = sum;
            }
            else
                TxtTotal.Text = "";
        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            GTOTAL();
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        // now all what remain is my Update, delete and coo
    }//not to temper with


}
