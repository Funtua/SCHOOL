using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;


namespace SCHOOL
{
    public partial class Print_Students : Form
    {
        Class_Student std = new Class_Student();
        DGVPrinter printer = new DGVPrinter();

        public Print_Students()
        {
            InitializeComponent();
        }
        public void showdata(SQLiteCommand cmd)
        {
            try
            {

                DgvReg.ReadOnly = true;
                DataGridViewImageColumn imagecolumn = new DataGridViewImageColumn();
                //DgvReg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                
                DgvReg.DataSource = std.getList(cmd);


                imagecolumn = (DataGridViewImageColumn)DgvReg.Columns[6];
                imagecolumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Print_Students_Load(object sender, EventArgs e)
        {

            showdata(new SQLiteCommand("SELECT row_number() over (order by StdID) as SNo, Surname||' '|| Other_Names as Full_Name, DOB,Gender,Phone,Address,Photo from Student_Registration"));
        }

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            string selectQuery;


            if (RadioAll.Checked == true)
            {
                selectQuery = "SELECT row_number() over (order by StdID) as SNo, Surname||' '|| Other_Names as Full_Name, DOB,Gender,Phone,Address,Photo from Student_Registration";
            }
            else if (RadioMale.Checked == true)
            {
                selectQuery = "SELECT row_number() over (order by StdID) as SNo, Surname||' '|| Other_Names as Full_Name, DOB,Gender,Phone,Address,Photo from Student_Registration WHERE Gender='Male'";
            }
            else if (RadioFemale.Checked == true) 
            {
                selectQuery = "SELECT row_number() over (order by StdID) as SNo, Surname||' '|| Other_Names as Full_Name, DOB,Gender,Phone,Address,Photo from Student_Registration WHERE Gender='Female'";
            }
            else
            {
                selectQuery = "SELECT row_number() over (order by StdID) as SNo, Surname||' '|| Other_Names as Full_Name, DOB,Gender,Phone,Address,Photo from Student_Registration WHERE Gender='Female'";
            }
            showdata(new SQLiteCommand(selectQuery));
        }

     

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printer.Title = "Nasara Nursery and Primary School";
            printer.SubTitle = string.Format("List of Student in the School as at", DateTime.Now.Date);
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
