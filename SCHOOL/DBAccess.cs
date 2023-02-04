using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace SCHOOL
{
    class DBAccess
    {
        private static SQLiteConnection connection = new SQLiteConnection();
        private static SQLiteCommand command = new SQLiteCommand();
        private static SQLiteDataReader DbReader;
        private static SQLiteDataAdapter adapter = new SQLiteDataAdapter();
        public SQLiteTransaction DbTran;

        private static string strConnString = "Data Source=SchoolDB.db";

        // A KO DA YAUSHE INA KARI ANAN

        SQLiteConnection ConnString = new SQLiteConnection("Data Source=SchoolDB.db");
        public SQLiteConnection GetConnection
        {
            get
            {
                return ConnString;
            }
        }
        public void openconnect()
        {
            if (ConnString.State == System.Data.ConnectionState.Closed)
                ConnString.Open();
        }
        public void closeconnect()
        {
            if (ConnString.State == System.Data.ConnectionState.Open)
                ConnString.Close();
        }


        //ZUWA NAN

        public void createConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = strConnString;
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void closeConn()
        {
            connection.Close();
        }


        public int executeDataAdapter(DataTable tblName, string strSelectSql)
        {
            try
            {
                if (connection.State == 0)
                {
                    createConn();
                }

                adapter.SelectCommand.CommandText = strSelectSql;
                adapter.SelectCommand.CommandType = CommandType.Text;
                SQLiteCommandBuilder DbCommandBuilder = new SQLiteCommandBuilder(adapter);


                string insert = DbCommandBuilder.GetInsertCommand().CommandText.ToString();
                string update = DbCommandBuilder.GetUpdateCommand().CommandText.ToString();
                string delete = DbCommandBuilder.GetDeleteCommand().CommandText.ToString();


                return adapter.Update(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void readDatathroughAdapter(string query, DataTable tblName)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                adapter = new SQLiteDataAdapter(command);
                adapter.Fill(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public SQLiteDataReader readDatathroughReader(string query)
        {
            //DataReader used to sequentially read data from a data source
            SQLiteDataReader reader;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int executeQuery(SQLiteCommand dbCommand)
        {
            try
            {
                if (connection.State == 0)
                {
                    createConn();
                }

                dbCommand.Connection = connection;
                dbCommand.CommandType = CommandType.Text;


                return dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
