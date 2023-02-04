using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.Data.SQLite;

namespace SCHOOL
{
    public partial class Print_Report_Sheet_Nursery : Form
    {
        DBAccess objDBAccess = new DBAccess();
        public Print_Report_Sheet_Nursery()
        {
            InitializeComponent();
        }
        //declare event handler for printing in constructor
        Panel pannel = null;


        //Rest of the code
        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panel2.Width / 2),
            this.panel2.Location.Y);
        }
        public void Print(Panel pnl)
        {
            pannel = pnl;
            GetPrintArea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Print(this.panel2);
        }
        public string HE, HVG, HG, HFair, HFail, CE, CVG, CG, CFair, CFail;

        private void Print_Report_Sheet_Nursery_Load(object sender, EventArgs e)
        {
            try
            {
                TxtName.Text = Print_Result.name; TxtClass.Text = Print_Result.clas; TxtTerm.Text = Print_Result.term;
                TxtSession.Text = Print_Result.session; TxtGrade.Text = Print_Result.position;// TxtNoinClass.Text = Print_Result.noinclass;
                //aver,
                TxtEng1.Text = Print_Result.Eng1; TxtEng2.Text = Print_Result.Eng2; TxtEngE.Text = Print_Result.EngE;
                TxtEngT.Text = Print_Result.EngT; TxtEngG.Text = Print_Result.EngG; TxtMath1.Text = Print_Result.Math1;
                TxtMath2.Text = Print_Result.Math2; TxtMathE.Text = Print_Result.MathE; TxtMathG.Text = Print_Result.MathG;
                TxtMathT.Text = Print_Result.MathT; TxtSos1.Text = Print_Result.Sos1;
                TxtSos2.Text = Print_Result.Sos2; TxtSosE.Text = Print_Result.SosE; TxtSosG.Text = Print_Result.SosG; TxtSosT.Text = Print_Result.SosT;
                TxtCivic1.Text = Print_Result.Civic1; TxtCivic2.Text = Print_Result.Civic2; TxtCivicE.Text = Print_Result.CivicE; TxtCivicG.Text = Print_Result.CivicG;
                TxtCivicT.Text = Print_Result.CivicT; TxtHealth1.Text = Print_Result.Health1; TxtHealth2.Text = Print_Result.Health2;
                TxtHealthE.Text = Print_Result.HealthE; TxtHealthG.Text = Print_Result.HealthG; TxtHealthT.Text = Print_Result.HealthT;
                TxtCom1.Text = Print_Result.Comp1; TxtCom2.Text = Print_Result.Comp2; TxtComE.Text = Print_Result.CompE;
                TxtComG.Text = Print_Result.CompG; TxtComT.Text = Print_Result.CompT; TxtAgric1.Text = Print_Result.Agric1;
                TxtAgric2.Text = Print_Result.Agric2; TxtAgricE.Text = Print_Result.AgricE; TxtAgricG.Text = Print_Result.AgricG;
                TxtAgricT.Text = Print_Result.AgricT; 
                TxtHome1.Text = Print_Result.Home1; TxtHome2.Text = Print_Result.Home2; TxtHomeE.Text = Print_Result.HomeE; TxtHomeT.Text = Print_Result.HomeT;
                TxtHomeG.Text = Print_Result.HomeG; TxtGTotal.Text = Print_Result.GTotal;

                

                //Eng
                if (TxtEngG.Text == "A")
                    TxtEngRemark.Text = "Distinction";
                else if (TxtEngG.Text == "B")
                    TxtEngRemark.Text = "Very Good";
                else if (TxtEngG.Text == "C")
                    TxtEngRemark.Text = " Good";
                else if (TxtEngG.Text == "D" || TxtEngG.Text == "E")
                    TxtEngRemark.Text = "Fair";
                else
                    TxtEngRemark.Text = "Fail";

                //math
                if (TxtMathG.Text == "A")
                    TxtMathRemark.Text = "Distinction";
                else if (TxtMathG.Text == "B")
                    TxtMathRemark.Text = "Very Good";
                else if (TxtMathG.Text == "C")
                    TxtMathRemark.Text = " Good";
                else if (TxtMathG.Text == "D" || TxtMathG.Text == "E")
                    TxtMathRemark.Text = "Fair";
                else
                    TxtMathRemark.Text = "Fail";

                //sos
                if (TxtSosG.Text == "A")
                    TxtSosRemark.Text = "Distinction";
                else if (TxtSosG.Text == "B")
                    TxtSosRemark.Text = "Very Good";
                else if (TxtSosG.Text == "C")
                    TxtSosRemark.Text = " Good";
                else if (TxtSosG.Text == "D" || TxtSosG.Text == "E")
                    TxtSosRemark.Text = "Fair";
                else
                    TxtSosRemark.Text = "Fail";


                //Civic
                if (TxtCivicG.Text == "A")
                    TxtCivicRemark.Text = "Distinction";
                else if (TxtCivicG.Text == "B")
                    TxtCivicRemark.Text = "Very Good";
                else if (TxtCivicG.Text == "C")
                    TxtCivicRemark.Text = " Good";
                else if (TxtCivicG.Text == "D" || TxtCivicG.Text == "E")
                    TxtCivicRemark.Text = "Fair";
                else
                    TxtCivicRemark.Text = "Fail";

                //home
                if (TxtHomeG.Text == "A")
                    TxtHomeRemark.Text = "Distinction";
                else if (TxtHomeG.Text == "B")
                    TxtHomeRemark.Text = "Very Good";
                else if (TxtHomeG.Text == "C")
                    TxtHomeRemark.Text = " Good";
                else if (TxtHomeG.Text == "D" || TxtHomeG.Text == "E")
                    TxtHomeRemark.Text = "Fair";
                else
                    TxtHomeRemark.Text = "Fail";

                //health
                if (TxtHealthG.Text == "A")
                    TxtHealthremark.Text = "Distinction";
                else if (TxtHealthG.Text == "B")
                    TxtHealthremark.Text = "Very Good";
                else if (TxtHealthG.Text == "C")
                    TxtHealthremark.Text = " Good";
                else if (TxtHealthG.Text == "D" || TxtHealthG.Text == "E")
                    TxtHealthremark.Text = "Fair";
                else
                    TxtHealthremark.Text = "Fail";

                //comp
                if (TxtComG.Text == "A")
                    TxtComRemark.Text = "Distinction";
                else if (TxtComG.Text == "B")
                    TxtComRemark.Text = "Very Good";
                else if (TxtComG.Text == "C")
                    TxtComRemark.Text = " Good";
                else if (TxtComG.Text == "D" || TxtComG.Text == "E")
                    TxtComRemark.Text = "Fair";
                else
                    TxtComRemark.Text = "Fail";
                //agric
                if (TxtAgricG.Text == "A")
                    TxtAgricRemark.Text = "Distinction";
                else if (TxtAgricG.Text == "B")
                    TxtAgricRemark.Text = "Very Good";
                else if (TxtAgricG.Text == "C")
                    TxtAgricRemark.Text = " Good";
                else if (TxtAgricG.Text == "D" || TxtAgricG.Text == "E")
                    TxtAgricRemark.Text = "Fair";
                else
                    TxtAgricRemark.Text = "Fail";

                

                // no of student
                TxtNoinClass.Text = Print_Result.noofRows.ToString();

                //average

                double avr = Convert.ToInt32(TxtGTotal.Text);
                double myav = Math.Round(avr / 8, 2);
                TxtAverage.Text = myav.ToString();

                //Now I want to Add Some Preminaries

                //for School open and close
                DataTable dtNext = new DataTable();
                string query = "Select * FROM nextterm WHERE NSNo='1'";
                objDBAccess.readDatathroughAdapter(query, dtNext);


                if (dtNext.Rows.Count == 1)
                {
                    SchCloses.Text = dtNext.Rows[0]["clos"].ToString();
                    SchoolOpens.Text = dtNext.Rows[0]["opeen"].ToString();

                }

                //For Headmasters' Comment
                DataTable dtCommsH = new DataTable();
                string query2 = "SELECT * from Comms where SNo='1'";
                objDBAccess.readDatathroughAdapter(query2, dtCommsH);

                if (dtCommsH.Rows.Count == 1)
                {
                    //2nd November 2000

                    HE = dtCommsH.Rows[0]["Com1"].ToString();
                    HVG = dtCommsH.Rows[0]["Com2"].ToString();
                    HG = dtCommsH.Rows[0]["Com3"].ToString();
                    HFair = dtCommsH.Rows[0]["Com4"].ToString();
                    HFail = dtCommsH.Rows[0]["Com5"].ToString();
                }

                //And Lastly for Classteacher's Comment
                DataTable dtCommsC = new DataTable();
                string query3 = "Select * FROM Comms WHERE SNo='2'";
                objDBAccess.readDatathroughAdapter(query3, dtCommsC);

                if (dtCommsC.Rows.Count == 1)
                {
                    CE = dtCommsC.Rows[0]["Com1"].ToString();
                    CVG = dtCommsC.Rows[0]["Com2"].ToString();
                    CG = dtCommsC.Rows[0]["Com3"].ToString();
                    CFair = dtCommsC.Rows[0]["Com4"].ToString();
                    CFail = dtCommsC.Rows[0]["Com5"].ToString();
                }
                // now start passing info
                if (myav >= 70)
                {
                    HeadComments.Text = HE;
                    TeacherComment.Text = CE;
                }
                else if (myav >= 60)
                {
                    HeadComments.Text = HVG;
                    TeacherComment.Text = CVG;
                }
                else if (myav >= 50)
                {
                    HeadComments.Text = HG;
                    TeacherComment.Text = CG;
                }
                else if (myav >= 40)
                {
                    HeadComments.Text = HFair;
                    TeacherComment.Text = CFair;
                }
                else
                {
                    HeadComments.Text = HFail;
                    TeacherComment.Text = CFail;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
