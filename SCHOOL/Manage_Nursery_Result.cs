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
    public partial class Manage_Nursery_Result : Form
    {
        DBAccess objDBAccess = new DBAccess();
        Class_Status statuss = new Class_Status();

        public Manage_Nursery_Result()
        {
            InitializeComponent();
        }

        private void Manage_Nursery_Result_Load(object sender, EventArgs e)
        {
            DgvReg.DataSource = statuss.searchNursery(TxtSearch.Text);
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
            if (EngT.Text != "" && MathT.Text != "" && SosT.Text != "" && CivicT.Text != "" && HealthT.Text != "" && CompT.Text != "" && AgricT.Text != "" && BasicT.Text != "")
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



        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DgvReg.DataSource = statuss.searchNursery(TxtSearch.Text);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
            

        }
        private void DgvReg_Click(object sender, EventArgs e)
        {
            // i have to send everything to the appropiate text box bro ...
            // this are what to send...
            /*
            string query = "SELECT RID, Status_Registration.StatusID, Student_Registration.StdID, Student_Registration.Surname, " +
                "Student_Registration.Other_Names, Status_Registration.Status, Status_Registration.Term,Status_Registration.Session, Eng1,Eng2,EngE,EngG,EngT, Math1, Math2, MathE, MathG,MathT, Sos1, Sos2,SosE,SosG,SosT, Civic1, " +
                "Civic2,CivicE,CivicG,CivicT,Health1,Health2,HealthE,HealthG,HealthT, Comp1,Comp2,CompE,CompG,CompT, Agric1,Agric2,AgricE,AgricG,AgricT, Basic1,Basic2,BasicE, BasicG,BasicT, Quan1, Quan2, QuanE,QuanG,QuanT," +
                "Ver1, Ver2,VerE,VerT,VerG,CCA1,CCA2,CCAE,CCAT,CCAG, Home1,Home2,HomeE,HomeT,HomeG FROM Primary_Result" +
                " inner Join Status_Registration on Status_Registration.StatusID = Primary_Result.StatusID" +
                " inner join Student_Registration on Student_Registration.StdID = Primary_Result.StdID Where Surname ||Other_Names||Status||Session LIKE '%" + searchdata + "%'";
            */
            TxtStatusID.Text = DgvReg.CurrentRow.Cells[1].Value.ToString();
            TxtID.Text = DgvReg.CurrentRow.Cells[2].Value.ToString();
            TxtSurname.Text = DgvReg.CurrentRow.Cells[3].Value.ToString();
            TxtOthers.Text = DgvReg.CurrentRow.Cells[4].Value.ToString();
            TxtClass.Text = DgvReg.CurrentRow.Cells[5].Value.ToString();
            TxtTerm.Text = DgvReg.CurrentRow.Cells[6].Value.ToString();
            TxtSession.Text = DgvReg.CurrentRow.Cells[7].Value.ToString();

            Eng1.Text = DgvReg.CurrentRow.Cells[8].Value.ToString();
            Eng2.Text = DgvReg.CurrentRow.Cells[9].Value.ToString();
            EngE.Text = DgvReg.CurrentRow.Cells[10].Value.ToString();
            EngT.Text = DgvReg.CurrentRow.Cells[11].Value.ToString();
            EngG.Text = DgvReg.CurrentRow.Cells[12].Value.ToString();
            Math1.Text = DgvReg.CurrentRow.Cells[13].Value.ToString();
            Math2.Text = DgvReg.CurrentRow.Cells[14].Value.ToString();
            MathE.Text = DgvReg.CurrentRow.Cells[15].Value.ToString();
            MathT.Text = DgvReg.CurrentRow.Cells[16].Value.ToString();
            MathG.Text = DgvReg.CurrentRow.Cells[17].Value.ToString();
            Sos1.Text = DgvReg.CurrentRow.Cells[18].Value.ToString();
            Sos2.Text = DgvReg.CurrentRow.Cells[19].Value.ToString();
            SosE.Text = DgvReg.CurrentRow.Cells[20].Value.ToString();
            SosT.Text = DgvReg.CurrentRow.Cells[21].Value.ToString();
            SosG.Text = DgvReg.CurrentRow.Cells[22].Value.ToString();
            Civic1.Text = DgvReg.CurrentRow.Cells[23].Value.ToString();
            Civic2.Text = DgvReg.CurrentRow.Cells[24].Value.ToString();
            CivicE.Text = DgvReg.CurrentRow.Cells[25].Value.ToString();
            CivicT.Text = DgvReg.CurrentRow.Cells[26].Value.ToString();
            CivicG.Text = DgvReg.CurrentRow.Cells[27].Value.ToString();
            Health1.Text = DgvReg.CurrentRow.Cells[28].Value.ToString();
            Health2.Text = DgvReg.CurrentRow.Cells[29].Value.ToString();
            HealthE.Text = DgvReg.CurrentRow.Cells[30].Value.ToString();
            HealthT.Text = DgvReg.CurrentRow.Cells[31].Value.ToString();
            HealthG.Text = DgvReg.CurrentRow.Cells[32].Value.ToString();
            Comp1.Text = DgvReg.CurrentRow.Cells[33].Value.ToString();
            Comp2.Text = DgvReg.CurrentRow.Cells[34].Value.ToString();
            CompE.Text = DgvReg.CurrentRow.Cells[35].Value.ToString();
            CompT.Text = DgvReg.CurrentRow.Cells[36].Value.ToString();
            CompG.Text = DgvReg.CurrentRow.Cells[37].Value.ToString();
            Agric1.Text = DgvReg.CurrentRow.Cells[38].Value.ToString();
            Agric2.Text = DgvReg.CurrentRow.Cells[39].Value.ToString();
            AgricE.Text = DgvReg.CurrentRow.Cells[40].Value.ToString();
            AgricT.Text = DgvReg.CurrentRow.Cells[41].Value.ToString();
            AgricG.Text = DgvReg.CurrentRow.Cells[42].Value.ToString();
            Basic1.Text = DgvReg.CurrentRow.Cells[43].Value.ToString();
            Basic2.Text = DgvReg.CurrentRow.Cells[44].Value.ToString();
            BasicE.Text = DgvReg.CurrentRow.Cells[45].Value.ToString();
            BasicT.Text = DgvReg.CurrentRow.Cells[46].Value.ToString();
            BasicG.Text = DgvReg.CurrentRow.Cells[47].Value.ToString();
         
            TxtTotal.Text = DgvReg.CurrentRow.Cells[48].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtID.Equals(""))
            {
                MessageBox.Show("Select a record from the table...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtTotal.Text == "")
            {
                MessageBox.Show("Whats the total Score?...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TxtID.Equals(""))
                {
                    MessageBox.Show("Select a record from the table...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TxtTotal.Text == "")
                {
                    MessageBox.Show("Whats the total Score?...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    
                    string query = "update Nursery_Result set  No_Work1=@Eng1, No_Work2=@Eng2, No_WorkE=@EngE, No_WorkG=@EngG, No_WorkT=@EngT, " +
                        "Pre_Reading1=@Math1, Pre_Reading2=@Math2, Pre_ReadingE=@MathE, Pre_ReadingG=@MathG, Pre_ReadingT=@MathT, " +
                        "Rhymes1=@Sos1, Rhymes2=@Sos2, RhymesE=@SosE, RhymesG=@SosG, RhymesT=@SosT," +
                      "Writing1=@Civic1, Writing2=@Civic2, WritingE=@CivicE, WritingG=@CivicG, WritingT=@CivicT, " +
                      "CCA1=@Health1, CCA2=@Health2, CCAE=@HealthE, CCAG=@HealthG, CCAT=@HealthT," +
                      " Science1=@Comp1, Science2=@Comp2, ScienceE=@CompE, ScienceG=@CompG, ScienceT=@CompT," +
                      "Social_H1=@Agric1, Social_H2=@Agric2, Social_HE=@AgricE, Social_HG=@AgricG, Social_HT=@AgricT," +
                      " Health_H1=@BAsic1, Health_H2=@Basic2, Health_HE=@BasicE, Health_HG=@BasicG, Health_HT=@BasicT, GTOTAL=@GTOTAL where RID=@rid";

                    SQLiteCommand UpdateCommand = new SQLiteCommand(query);

                    UpdateCommand.Parameters.AddWithValue("@rid", DgvReg.CurrentRow.Cells[0].Value.ToString());

                    UpdateCommand.Parameters.AddWithValue("@Eng1", Eng1.Text);
                    UpdateCommand.Parameters.AddWithValue("@Eng2", Eng2.Text);
                    UpdateCommand.Parameters.AddWithValue("@EngE", EngE.Text);
                    UpdateCommand.Parameters.AddWithValue("@EngT", EngT.Text);
                    UpdateCommand.Parameters.AddWithValue("@EngG", EngG.Text);

                    UpdateCommand.Parameters.AddWithValue("@Math1", Math1.Text);
                    UpdateCommand.Parameters.AddWithValue("@Math2", Math2.Text);
                    UpdateCommand.Parameters.AddWithValue("@MathE", MathE.Text);
                    UpdateCommand.Parameters.AddWithValue("@MathT", MathT.Text);
                    UpdateCommand.Parameters.AddWithValue("@MathG", MathG.Text);

                    UpdateCommand.Parameters.AddWithValue("@Sos1", Sos1.Text);
                    UpdateCommand.Parameters.AddWithValue("@Sos2", Sos2.Text);
                    UpdateCommand.Parameters.AddWithValue("@SosE", SosE.Text);
                    UpdateCommand.Parameters.AddWithValue("@SosT", SosT.Text);
                    UpdateCommand.Parameters.AddWithValue("@SosG", SosG.Text);

                    UpdateCommand.Parameters.AddWithValue("@Civic1", Civic1.Text);
                    UpdateCommand.Parameters.AddWithValue("@Civic2", Civic2.Text);
                    UpdateCommand.Parameters.AddWithValue("@CivicE", CivicE.Text);
                    UpdateCommand.Parameters.AddWithValue("@CivicT", CivicT.Text);
                    UpdateCommand.Parameters.AddWithValue("@CivicG", CivicG.Text);

                    UpdateCommand.Parameters.AddWithValue("@Health1", Health1.Text);
                    UpdateCommand.Parameters.AddWithValue("@Health2", Health2.Text);
                    UpdateCommand.Parameters.AddWithValue("@HealthE", HealthE.Text);
                    UpdateCommand.Parameters.AddWithValue("@HealthT", HealthT.Text);
                    UpdateCommand.Parameters.AddWithValue("@HealthG", HealthG.Text);

                    UpdateCommand.Parameters.AddWithValue("@Comp1", Comp1.Text);
                    UpdateCommand.Parameters.AddWithValue("@Comp2", Comp2.Text);
                    UpdateCommand.Parameters.AddWithValue("@CompE", CompE.Text);
                    UpdateCommand.Parameters.AddWithValue("@CompT", CompT.Text);
                    UpdateCommand.Parameters.AddWithValue("@CompG", CompG.Text);

                    UpdateCommand.Parameters.AddWithValue("@Agric1", Agric1.Text);
                    UpdateCommand.Parameters.AddWithValue("@Agric2", Agric2.Text);
                    UpdateCommand.Parameters.AddWithValue("@AgricE", AgricE.Text);
                    UpdateCommand.Parameters.AddWithValue("@AgricT", AgricT.Text);
                    UpdateCommand.Parameters.AddWithValue("@AgricG", AgricG.Text);

                    UpdateCommand.Parameters.AddWithValue("@Basic1", Basic1.Text);
                    UpdateCommand.Parameters.AddWithValue("@Basic2", Basic2.Text);
                    UpdateCommand.Parameters.AddWithValue("@BasicE", BasicE.Text);
                    UpdateCommand.Parameters.AddWithValue("@BasicT", BasicT.Text);
                    UpdateCommand.Parameters.AddWithValue("@BasicG", BasicG.Text);


                    UpdateCommand.Parameters.AddWithValue("@GTOTAL", TxtTotal.Text);

                    int row = objDBAccess.executeQuery(UpdateCommand);
                    if (row == 1)
                    {
                        MessageBox.Show("Record Updated Successfully...", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DgvReg.DataSource = statuss.searchNursery(TxtSearch.Text);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Error Occured, Please try again...", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Delete the selected record...", "Delete Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {


                string query = "Delete from Nursery_Result Where RID=@id";
                SQLiteCommand DeleteCommand = new SQLiteCommand(query);
                DeleteCommand.Parameters.AddWithValue("@id", DgvReg.CurrentRow.Cells[0].Value.ToString());

                int row = objDBAccess.executeQuery(DeleteCommand);
                if (row == 1)
                {
                    MessageBox.Show("Record Deleted Successfully...", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DgvReg.DataSource = statuss.searchNursery(TxtSearch.Text);
                    clear();
                }
                else
                {
                    MessageBox.Show("Error Occured, Please try again...", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}
