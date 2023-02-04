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
using DGVPrinterHelper;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace SCHOOL
{
    public partial class Print_Result : Form
    {
        DGVPrinter printer = new DGVPrinter();
        Class_Status statuss = new Class_Status();

        public Print_Result()
        {
            InitializeComponent();
        }

        public void search()
        {
            //if (DgvReg.DataSource != null)
            //{
            if (ComboClass.SelectedIndex == 0 || ComboClass.SelectedIndex == 1 || ComboClass.SelectedIndex == 2)
            {
                //Call For Nursery
                DgvReg.DataSource = statuss.getList(new SQLiteCommand("SELECT Row_Number() over ( order by RID) as SN, Student_Registration.Surname|| ' ' || Student_Registration.Other_Names AS Full_Name, " +
                " No_Work1, No_Work2, No_WorkE,No_WorkT," +
                "No_WorkG, Pre_Reading1, Pre_Reading2, Pre_ReadingE, Pre_ReadingT," +
                " Pre_ReadingG, Rhymes1, Rhymes2, RhymesE, RhymesT, RhymesG, Writing1, Writing2, WritingE, WritingT, " +
                "WritingG, CCA1, CCA2" +
                 ", CCAE, CCAT, CCAG, Science1, Science2, ScienceE, ScienceT, ScienceG, Social_H1, Social_H2," +
                 " Social_HE, Social_HT, Social_HG, Health_H1, Health_H2, Health_HE, Health_HT, Health_HG, GTOTAL,  rank () over ( ORDER by GTotal) as Position  " +
                 "" +
                 "FROM Nursery_Result" +
                " inner Join Status_Registration on Status_Registration.StatusID = Nursery_Result.StatusID" +
                " inner join Student_Registration on Student_Registration.StdID = Nursery_Result.StdID Where Status='" + ComboClass.Text + "' AND Term='" + ComboTerm.Text + "' AND Session='" + ComboSession.Text + "' "));

                /*
                 *  DgvReg.DataSource = statuss.getList(new SQLiteCommand("SELECT Row_Number() over ( order by RID) as SN,Student_Registration.StdID, Student_Registration.Surname|| ' ' || Student_Registration.Other_Names AS Full_Name, Status_Registration.Status, Status_Registration.Term,Status_Registration.Session," +
                    " No_Work1, No_Work2, No_WorkE,No_WorkT," +
                    "No_WorkG, Pre_Reading1, Pre_Reading2, Pre_ReadingE, Pre_ReadingT," +
                    " Pre_ReadingG, Rhymes1, Rhymes2, RhymesE, RhymesT, RhymesG, Writing1, Writing2, WritingE, WritingT, " +
                    "WritingG, CCA1, CCA2" +
                     ", CCAE, CCAT, CCAG, Science1, Science2, ScienceE, ScienceT, ScienceG, Social_H1, Social_H2," +
                     " Social_HE, Social_HT, Social_HG, Health_H1, Health_H2, Health_HE, Health_HT, Health_HG, GTOTAL,  rank () over ( ORDER by GTotal) as Position  " +
                     "" +
                     "FROM Nursery_Result" +
                    " inner Join Status_Registration on Status_Registration.StatusID = Nursery_Result.StatusID" +
                    " inner join Student_Registration on Student_Registration.StdID = Nursery_Result.StdID Where Status='" + ComboClass.Text + "' AND Term='" + ComboTerm.Text + "' AND Session='" + ComboSession.Text + "' "));
                     
                 * 
                 * 
                 */

            }
            else
            {
                //call for primary

                DgvReg.DataSource = statuss.getList(new SQLiteCommand("SELECT Row_Number() over ( order by RID) as SN, Student_Registration.Surname|| ' ' || Student_Registration.Other_Names AS Full_Name, Eng1,Eng2,EngE,EngT,EngG,  Math1, Math2, MathE, MathT,MathG, Sos1, Sos2,SosE,SosT,SosG, Civic1, " +
                "Civic2,CivicE,CivicT,CivicG,Health1,Health2,HealthE,HealthT, HealthG, Comp1,Comp2,CompE,CompT, CompG, Agric1,Agric2,AgricE,AgricT,AgricG, Basic1,Basic2,BasicE, BasicT,BasicG, Quan1, Quan2, QuanE,QuanT,QuanG," +
                "Ver1, Ver2,VerE,VerT,VerG,CCA1,CCA2,CCAE,CCAT,CCAG, Home1,Home2,HomeE,HomeT, HomeG, GTotal, rank () over ( ORDER by GTotal) as Position FROM Primary_Result" +
                " inner Join Status_Registration on Status_Registration.StatusID = Primary_Result.StatusID" +
                " inner join Student_Registration on Student_Registration.StdID = Primary_Result.StdID  WHERE Status='" + ComboClass.Text + "' AND Term='" + ComboTerm.Text + "' AND Session='" + ComboSession.Text + "' "));
                // DgvReg.Columns("Full_Name").Width = 500;
                /* this one has stdid, class and sesssion and its like i dont need thier grades here
                 * DgvReg.DataSource = statuss.getList(new SQLiteCommand("SELECT Row_Number() over ( order by RID) as SN, Student_Registration.Surname|| ' ' || Student_Registration.Other_Names AS Full_Name, Status_Registration.Status, Status_Registration.Term,Status_Registration.Session, Eng1,Eng2,EngE,EngG,EngT, Math1, Math2, MathE, MathG,MathT, Sos1, Sos2,SosE,SosG,SosT, Civic1, " +
                    "Civic2,CivicE,CivicG,CivicT,Health1,Health2,HealthE,HealthG,HealthT, Comp1,Comp2,CompE,CompG,CompT, Agric1,Agric2,AgricE,AgricG,AgricT, Basic1,Basic2,BasicE, BasicG,BasicT, Quan1, Quan2, QuanE,QuanG,QuanT," +
                    "Ver1, Ver2,VerE,VerT,VerG,CCA1,CCA2,CCAE,CCAT,CCAG, Home1,Home2,HomeE,HomeT,HomeG, GTotal, rank () over ( ORDER by GTotal) as Position FROM Primary_Result" +
                    " inner Join Status_Registration on Status_Registration.StatusID = Primary_Result.StatusID" +
                    " inner join Student_Registration on Student_Registration.StdID = Primary_Result.StdID  WHERE Status='" + ComboClass.Text + "' AND Term='" + ComboTerm.Text + "' AND Session='" + ComboSession.Text + "' "));
                 * 
                 */

            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            
            search();
        }
        private void ComboTerm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //need some key press conditions here
            if (e.KeyChar == (Char)Keys.Enter)
            {
                search();
            }
        }
        public void showData()
        {
            DgvReg.ReadOnly = true;
            // this is to insert data into datagridview, and combosession
            ComboSession.DataSource = statuss.getList(new SQLiteCommand("Select distinct Session FROM Status_Registration"));
            ComboSession.DisplayMember = "Session";
            ComboSession.ValueMember = "Session";
        }
        public static string name, clas, term, session, grade, noinclass, aver,
          Eng1, Eng2, EngE, EngT, EngG, Math1, Math2, MathE, MathG, MathT, Sos1, Sos2, SosE, SosG, SosT, Civic1,
          Civic2, CivicE, CivicG, CivicT, Health1, Health2, HealthE, HealthG, HealthT, Comp1, Comp2, CompE, CompG, CompT, Agric1, Agric2, AgricE, AgricG, AgricT, Basic1, Basic2, BasicE, BasicG, BasicT, Quan1, Quan2, QuanE, QuanG, QuanT,
          Ver1, Ver2, VerE, VerT, VerG, CCA1, CCA2, CCAE, CCAT, CCAG, Home1, Home2, HomeE, HomeT, HomeG, GTotal, position;

        public static int noofRows;

        private void DgvReg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ComboClass.SelectedIndex == 0 || ComboClass.SelectedIndex == 1 || ComboClass.SelectedIndex == 2)
            {
                //Call for nursery which is comming soon!!!
                clas = ComboClass.Text;
                term = ComboTerm.Text;
                session = ComboSession.Text;

                name = DgvReg.CurrentRow.Cells[1].Value.ToString();

                Eng1 = DgvReg.CurrentRow.Cells[2].Value.ToString();
                Eng2 = DgvReg.CurrentRow.Cells[3].Value.ToString();
                EngE = DgvReg.CurrentRow.Cells[4].Value.ToString();
                EngT = DgvReg.CurrentRow.Cells[5].Value.ToString();
                EngG = DgvReg.CurrentRow.Cells[6].Value.ToString();

                Math1 = DgvReg.CurrentRow.Cells[7].Value.ToString();
                Math2 = DgvReg.CurrentRow.Cells[8].Value.ToString();
                MathE = DgvReg.CurrentRow.Cells[9].Value.ToString();
                MathG = DgvReg.CurrentRow.Cells[11].Value.ToString();
                MathT = DgvReg.CurrentRow.Cells[10].Value.ToString();

                Sos1 = DgvReg.CurrentRow.Cells[12].Value.ToString();
                Sos2 = DgvReg.CurrentRow.Cells[13].Value.ToString();
                SosE = DgvReg.CurrentRow.Cells[14].Value.ToString();
                SosG = DgvReg.CurrentRow.Cells[16].Value.ToString();
                SosT = DgvReg.CurrentRow.Cells[15].Value.ToString();

               

                Civic1 = DgvReg.CurrentRow.Cells[17].Value.ToString();
                Civic2 = DgvReg.CurrentRow.Cells[18].Value.ToString();
                CivicE = DgvReg.CurrentRow.Cells[19].Value.ToString();
                CivicG = DgvReg.CurrentRow.Cells[21].Value.ToString();
                CivicT = DgvReg.CurrentRow.Cells[20].Value.ToString();

                Home1 = DgvReg.CurrentRow.Cells[22].Value.ToString();
                Home2 = DgvReg.CurrentRow.Cells[23].Value.ToString();
                HomeE = DgvReg.CurrentRow.Cells[24].Value.ToString();
                HomeT = DgvReg.CurrentRow.Cells[25].Value.ToString();
                HomeG = DgvReg.CurrentRow.Cells[26].Value.ToString();


                Health1 = DgvReg.CurrentRow.Cells[27].Value.ToString();
                Health2 = DgvReg.CurrentRow.Cells[28].Value.ToString();
                HealthE = DgvReg.CurrentRow.Cells[29].Value.ToString();
                HealthG = DgvReg.CurrentRow.Cells[31].Value.ToString();
                HealthT = DgvReg.CurrentRow.Cells[30].Value.ToString();

                Comp1 = DgvReg.CurrentRow.Cells[32].Value.ToString();
                Comp2 = DgvReg.CurrentRow.Cells[33].Value.ToString();
                CompE = DgvReg.CurrentRow.Cells[34].Value.ToString();
                CompG = DgvReg.CurrentRow.Cells[36].Value.ToString();
                CompT = DgvReg.CurrentRow.Cells[35].Value.ToString();

                Agric1 = DgvReg.CurrentRow.Cells[37].Value.ToString();
                Agric2 = DgvReg.CurrentRow.Cells[38].Value.ToString();
                AgricE = DgvReg.CurrentRow.Cells[39].Value.ToString();
                AgricG = DgvReg.CurrentRow.Cells[41].Value.ToString();
                AgricT = DgvReg.CurrentRow.Cells[40].Value.ToString();

             

                noofRows = DgvReg.Rows.Count;

                GTotal = DgvReg.CurrentRow.Cells[42].Value.ToString();

                //lemee try something for position
                if (DgvReg.CurrentRow.Cells[43].Value.ToString() == "1" || DgvReg.CurrentRow.Cells[43].Value.ToString() == "21" || DgvReg.CurrentRow.Cells[43].Value.ToString() == "31")
                    position = DgvReg.CurrentRow.Cells[43].Value.ToString() + "st";
                else if (DgvReg.CurrentRow.Cells[43].Value.ToString() == "2" || DgvReg.CurrentRow.Cells[43].Value.ToString() == "22" || DgvReg.CurrentRow.Cells[43].Value.ToString() == "32")
                    position = DgvReg.CurrentRow.Cells[43].Value.ToString() + "nd";
                else if (DgvReg.CurrentRow.Cells[43].Value.ToString() == "3" || DgvReg.CurrentRow.Cells[43].Value.ToString() == "23" || DgvReg.CurrentRow.Cells[43].Value.ToString() == "33")
                    position = DgvReg.CurrentRow.Cells[43].Value.ToString() + "rd";
                else
                    position = DgvReg.CurrentRow.Cells[43].Value.ToString() + "th";

                try
                {
                    Print_Report_Sheet_Nursery pr = new Print_Report_Sheet_Nursery();
                    pr.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Possible because" + ex.Message);
                }
            }
            else
            {
                //call for primary
                clas = ComboClass.Text;
                term = ComboTerm.Text;
                session = ComboSession.Text;

                name = DgvReg.CurrentRow.Cells[1].Value.ToString();

                Eng1 = DgvReg.CurrentRow.Cells[2].Value.ToString();
                Eng2 = DgvReg.CurrentRow.Cells[3].Value.ToString();
                EngE = DgvReg.CurrentRow.Cells[4].Value.ToString();
                EngT = DgvReg.CurrentRow.Cells[5].Value.ToString();
                EngG = DgvReg.CurrentRow.Cells[6].Value.ToString();

                Math1 = DgvReg.CurrentRow.Cells[7].Value.ToString();
                Math2 = DgvReg.CurrentRow.Cells[8].Value.ToString();
                MathE = DgvReg.CurrentRow.Cells[9].Value.ToString();
                MathG = DgvReg.CurrentRow.Cells[11].Value.ToString();
                MathT = DgvReg.CurrentRow.Cells[10].Value.ToString();

                Sos1 = DgvReg.CurrentRow.Cells[12].Value.ToString();
                Sos2 = DgvReg.CurrentRow.Cells[13].Value.ToString();
                SosE = DgvReg.CurrentRow.Cells[14].Value.ToString();
                SosG = DgvReg.CurrentRow.Cells[16].Value.ToString();
                SosT = DgvReg.CurrentRow.Cells[15].Value.ToString();

                Civic1 = DgvReg.CurrentRow.Cells[17].Value.ToString();
                Civic2 = DgvReg.CurrentRow.Cells[18].Value.ToString();
                CivicE = DgvReg.CurrentRow.Cells[19].Value.ToString();
                CivicG = DgvReg.CurrentRow.Cells[21].Value.ToString();
                CivicT = DgvReg.CurrentRow.Cells[20].Value.ToString();

                Health1 = DgvReg.CurrentRow.Cells[22].Value.ToString();
                Health2 = DgvReg.CurrentRow.Cells[23].Value.ToString();
                HealthE = DgvReg.CurrentRow.Cells[24].Value.ToString();
                HealthG = DgvReg.CurrentRow.Cells[26].Value.ToString();
                HealthT = DgvReg.CurrentRow.Cells[25].Value.ToString();

                Comp1 = DgvReg.CurrentRow.Cells[27].Value.ToString();
                Comp2 = DgvReg.CurrentRow.Cells[28].Value.ToString();
                CompE = DgvReg.CurrentRow.Cells[29].Value.ToString();
                CompG = DgvReg.CurrentRow.Cells[31].Value.ToString();
                CompT = DgvReg.CurrentRow.Cells[30].Value.ToString();

                Agric1 = DgvReg.CurrentRow.Cells[32].Value.ToString();
                Agric2 = DgvReg.CurrentRow.Cells[33].Value.ToString();
                AgricE = DgvReg.CurrentRow.Cells[34].Value.ToString();
                AgricG = DgvReg.CurrentRow.Cells[36].Value.ToString();
                AgricT = DgvReg.CurrentRow.Cells[35].Value.ToString();

                Basic1 = DgvReg.CurrentRow.Cells[37].Value.ToString();
                Basic2 = DgvReg.CurrentRow.Cells[38].Value.ToString();
                BasicE = DgvReg.CurrentRow.Cells[39].Value.ToString();
                BasicG = DgvReg.CurrentRow.Cells[41].Value.ToString();
                BasicT = DgvReg.CurrentRow.Cells[40].Value.ToString();

                Quan1 = DgvReg.CurrentRow.Cells[42].Value.ToString();
                Quan2 = DgvReg.CurrentRow.Cells[43].Value.ToString();
                QuanE = DgvReg.CurrentRow.Cells[44].Value.ToString();
                QuanG = DgvReg.CurrentRow.Cells[46].Value.ToString();
                QuanT = DgvReg.CurrentRow.Cells[45].Value.ToString();

                Ver1 = DgvReg.CurrentRow.Cells[47].Value.ToString();
                Ver2 = DgvReg.CurrentRow.Cells[48].Value.ToString();
                VerE = DgvReg.CurrentRow.Cells[49].Value.ToString();
                VerT = DgvReg.CurrentRow.Cells[50].Value.ToString();
                VerG = DgvReg.CurrentRow.Cells[51].Value.ToString();

                CCA1 = DgvReg.CurrentRow.Cells[52].Value.ToString();
                CCA2 = DgvReg.CurrentRow.Cells[53].Value.ToString();
                CCAE = DgvReg.CurrentRow.Cells[54].Value.ToString();
                CCAT = DgvReg.CurrentRow.Cells[55].Value.ToString();
                CCAG = DgvReg.CurrentRow.Cells[56].Value.ToString();

                Home1 = DgvReg.CurrentRow.Cells[57].Value.ToString();
                Home2 = DgvReg.CurrentRow.Cells[58].Value.ToString();
                HomeE = DgvReg.CurrentRow.Cells[59].Value.ToString();
                HomeT = DgvReg.CurrentRow.Cells[60].Value.ToString();
                HomeG = DgvReg.CurrentRow.Cells[61].Value.ToString();

                noofRows = DgvReg.Rows.Count;

                GTotal = DgvReg.CurrentRow.Cells[62].Value.ToString();

                //lemee try something for position
                if (DgvReg.CurrentRow.Cells[63].Value.ToString() == "1" || DgvReg.CurrentRow.Cells[63].Value.ToString() == "21" || DgvReg.CurrentRow.Cells[63].Value.ToString() == "31")
                    position = DgvReg.CurrentRow.Cells[63].Value.ToString() + "st";
                else if (DgvReg.CurrentRow.Cells[63].Value.ToString() == "2" || DgvReg.CurrentRow.Cells[63].Value.ToString() == "22" || DgvReg.CurrentRow.Cells[63].Value.ToString() == "32")
                    position = DgvReg.CurrentRow.Cells[63].Value.ToString() + "nd";
                else if (DgvReg.CurrentRow.Cells[63].Value.ToString() == "3" || DgvReg.CurrentRow.Cells[63].Value.ToString() == "23" || DgvReg.CurrentRow.Cells[63].Value.ToString() == "33")
                    position = DgvReg.CurrentRow.Cells[63].Value.ToString() + "rd";
                else
                    position = DgvReg.CurrentRow.Cells[63].Value.ToString() + "th";

                try
                {
                    Print_Result_Sheet pr = new Print_Result_Sheet();
                    pr.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Possible because" + ex.Message);
                }
            }

        }

        


        private void Print_Result_Load(object sender, EventArgs e)
        {
            ComboClass.Focus();
            // Enable me See the sessions registered
            showData();
            ComboSession.SelectedIndex = -1;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printer.Title = "NASARA NURSERY AND PRIMARY SCHOOL";
            printer.SubTitle = string.Format("BROAD SHEET FOR CLASS:'"+ComboClass.Text+" TERM:'"+ComboTerm.Text+"' SESSION:'"+ComboSession.Text+"");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Nasara School";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DgvReg);
            

        }
        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object" + ex.Message, "Error");
            }
            finally
            {
                GC.Collect();
            }
        }
        private void ExportExcel_Click(object sender, EventArgs e)
        {
            if (DgvReg.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel (.xlsx)| *.xlsx";
                sfd.FileName = "";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It was'nt possible to write data to the disk..." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            Excel.Application XcelApp = new Excel.Application();
                            Excel._Workbook workbook = XcelApp.Workbooks.Add(Type.Missing);
                            Excel._Worksheet worksheet = null;

                            worksheet = workbook.Sheets["Sheet1"];
                            worksheet = workbook.ActiveSheet;
                            worksheet.Name = "Output";
                            worksheet.Application.ActiveWindow.SplitRow = 1;
                            worksheet.Application.ActiveWindow.FreezePanes = true;

                            for (int i = 1; i < DgvReg.Columns.Count + 1; i++)
                            {
                                worksheet.Cells[1, i] = DgvReg.Columns[i - 1].HeaderText;
                                worksheet.Cells[1,i].Font.NAME = "Calibri";
                                worksheet.Cells[1, i].Font.Bold = true;
                                worksheet.Cells[1, i].Interior.Color = Color.Wheat;
                                worksheet.Cells[1, i].Font.Size = 10;
                            }
                            for (int i = 0; i < DgvReg.Rows.Count; i++)
                            {
                                for (int j = 0; j < DgvReg.Columns.Count; j++)
                                {
                                    worksheet.Cells[i + 2, j + 1] = DgvReg.Rows[i].Cells[j].Value.ToString();
                                }
                            }
                            worksheet.Columns.AutoFit();
                            workbook.SaveAs(sfd.FileName);
                            XcelApp.Quit();

                            ReleaseObject(worksheet);
                            ReleaseObject(workbook);
                            ReleaseObject(XcelApp);

                            MessageBox.Show("Data Exported Successfully...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error:" + ex.Message);
                        }

                    }
                }

            }
            else
            {
                MessageBox.Show("No Record To Export...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
