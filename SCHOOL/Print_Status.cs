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
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using DGVPrinterHelper;

namespace SCHOOL
{
    public partial class Print_Status : Form
    {
        DBAccess objDBAccess = new DBAccess();
        Class_Student std = new Class_Student();
        Class_Status statuss = new Class_Status();
        DGVPrinter printer = new DGVPrinter();

        public Print_Status()
        {
            InitializeComponent();
        }
        public void showstatus()
        {
            DgvReg.DataSource = std.GetStudentlist(new SQLiteCommand("SELECT  Row_Number() over (order by Status) as SNo, Surname ||' ' || Other_Names as Full_Names, Status as Class,Term, Session FROM Student_Registration INNER JOIN Status_Registration ON Status_Registration.StdID=Student_Registration.StdID"));

            ComboSession.DataSource = statuss.getList(new SQLiteCommand("Select distinct Session FROM Status_Registration"));
            ComboSession.DisplayMember = "Session";
            ComboSession.ValueMember = "Session";
            ComboSession.SelectedIndex = -1;
        }

        private void Btn_Search_Load(object sender, EventArgs e)
        {

            showstatus();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                DgvReg.DataSource = statuss.getList(new SQLiteCommand("SELECT  Row_Number() over (order by Status) as SNo, Surname ||' ' || Other_Names as Full_Names, Status as Class,Term, Session FROM Student_Registration INNER JOIN Status_Registration ON Status_Registration.StdID=Student_Registration.StdID WHERE Status='" + ComboStatus.Text + "' AND Term='" + ComboTerm.Text + "' AND Session='" + ComboSession.Text + "' "));
                ComboSession.SelectedIndex = -1;
                ComboTerm.SelectedIndex = -1;
                ComboStatus.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printer.Title = "Nasara Nursery and Primary School";
            printer.SubTitle = string.Format("Class Enrolment");
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
                                worksheet.Cells[1, i].Font.NAME = "Calibri";
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
