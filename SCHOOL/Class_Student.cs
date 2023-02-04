using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace SCHOOL
{

    internal class Class_Student
    {
        DBAccess objDBAccess = new DBAccess();

        public DataTable GetStudentlist(SQLiteCommand command)
        {
            command.Connection = objDBAccess.GetConnection;
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        /*
        public DataTable GetStudentlist(SqlCommand command)
        {
            string query = "Select * FROM Student_Registration";

            DataTable DtReg = new DataTable();
            objDBAccess.readDatathroughAdapter(query, DtReg);

            return DtReg;

        }*/

        //this is a try to my count coding...
        public string exeCount(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, objDBAccess.GetConnection);
            objDBAccess.openconnect();
            string count = command.ExecuteScalar().ToString();
            objDBAccess.closeconnect();

            return count;
        }

        public string totalStudents()
        {
            return exeCount("Select count(*) FROM Student_Registration");

        }

        public string maleStudents()
        {
            return exeCount("Select count(*) FROM Student_Registration WHERE Gender='Male'");

        }

        public string femaleStudents()
        {
            return exeCount("Select count(*) FROM Student_Registration WHERE Gender='Female'");

        }

        //this is for my search coding...
        public DataTable searchStudent(string searchdata)
        {

            string query = "Select * FROM Student_Registration Where Surname || Other_Names || Address || Gender || DOB || Phone LIKE '%" + searchdata + "%'";
            SQLiteCommand cmd = new SQLiteCommand(query, objDBAccess.GetConnection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable searchtable = new DataTable();
            da.Fill(searchtable);

            return searchtable;
        }
        public DataTable getList(SQLiteCommand cmd)
        {
            cmd.Connection = objDBAccess.GetConnection;
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable searchtable = new DataTable();
            da.Fill(searchtable);

            return searchtable;
        }
    }
}
