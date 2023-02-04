using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace SCHOOL
{
    internal class Class_Status
    {
        DBAccess objDBAccess = new DBAccess();

        public DataTable getList(SQLiteCommand command)
        {
            command.Connection = objDBAccess.GetConnection;
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable searchStatus(string searchdata)
        {

            string query = "SELECT StatusID, Student_Registration.StdID, Surname, Other_Names, Status, Term, Session FROM Student_Registration INNER JOIN Status_Registration ON Status_Registration.StdID=Student_Registration.StdID Where Surname||Other_Names||Status||Session LIKE '%" + searchdata + "%'";
            SQLiteCommand cmd = new SQLiteCommand(query, objDBAccess.GetConnection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable searchtable = new DataTable();
            da.Fill(searchtable);

            return searchtable;
        }
        public DataTable searchPrimary(string searchdata)
        {

            string query = "SELECT RID, Status_Registration.StatusID, Student_Registration.StdID, Student_Registration.Surname, " +
                "Student_Registration.Other_Names, Status_Registration.Status, Status_Registration.Term,Status_Registration.Session, Eng1,Eng2,EngE,EngG,EngT, Math1, Math2, MathE, MathG,MathT, Sos1, Sos2,SosE,SosG,SosT, Civic1, " +
                "Civic2,CivicE,CivicG,CivicT,Health1,Health2,HealthE,HealthG,HealthT, Comp1,Comp2,CompE,CompG,CompT, Agric1,Agric2,AgricE,AgricG,AgricT, Basic1,Basic2,BasicE, BasicG,BasicT, Quan1, Quan2, QuanE,QuanG,QuanT," +
                "Ver1, Ver2,VerE,VerT,VerG,CCA1,CCA2,CCAE,CCAT,CCAG, Home1,Home2,HomeE,HomeT,HomeG, GTotal FROM Primary_Result" +
                " inner Join Status_Registration on Status_Registration.StatusID = Primary_Result.StatusID" +
                " inner join Student_Registration on Student_Registration.StdID = Primary_Result.StdID Where Surname ||Other_Names||Status||Session LIKE '%" + searchdata + "%'";
            SQLiteCommand cmd = new SQLiteCommand(query, objDBAccess.GetConnection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable searchtable = new DataTable();
            da.Fill(searchtable);

            return searchtable;
        }
   
        public DataTable searchNursery(string searchdata)
        {

            string query = "SELECT RID, Status_Registration.StatusID, Student_Registration.StdID, Student_Registration.Surname, " +
                "Student_Registration.Other_Names, Status_Registration.Status, Status_Registration.Term,Status_Registration.Session," +
                " No_Work1, No_Work2, No_WorkE,No_WorkT," +
                "No_WorkG, Pre_Reading1, Pre_Reading2, Pre_ReadingE, Pre_ReadingT," +
                " Pre_ReadingG, Rhymes1, Rhymes2, RhymesE, RhymesT, RhymesG, Writing1, Writing2, WritingE, WritingT, " +
                "WritingG, CCA1, CCA2" +
                 ", CCAE, CCAT, CCAG, Science1, Science2, ScienceE, ScienceT, ScienceG, Social_H1, Social_H2," +
                 " Social_HE, Social_HT, Social_HG, Health_H1, Health_H2, Health_HE, Health_HT, Health_HG, GTOTAL " +
                 "" +
                 "FROM Nursery_Result" +
                " inner Join Status_Registration on Status_Registration.StatusID = Nursery_Result.StatusID" +
                " inner join Student_Registration on Student_Registration.StdID = Nursery_Result.StdID Where Surname ||Other_Names||Status||Session LIKE '%" + searchdata + "%'";
            SQLiteCommand cmd = new SQLiteCommand(query, objDBAccess.GetConnection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable searchtable = new DataTable();
            da.Fill(searchtable);

            return searchtable;
        }
    
    }
}
