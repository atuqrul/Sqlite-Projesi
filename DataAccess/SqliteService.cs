using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SqliteService
    {
        static SqliteService sqliteService;

        readonly string connectionString = ConfigurationManager.ConnectionStrings["SqliteConnection"].ConnectionString;
        SqliteConnection connection;

        public SqliteService()
        {
            connection = new SqliteConnection();
            connection.ConnectionString = connectionString;
            CreateTables();
        }

        void CreateTables()
        {
            string studentsTable = "Create Table If Not Exists STUDENTS (" +
                "ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                "NAME VARCHAR(50)," +
                "LESSON VARCHAR(50)," +
                "NOTE1 INTEGER," +
                "NOTE2 INTEGER" +
                ")";
            string branchesTable = "Create Table If Not Exists BRANCHES(" +
                "ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                "NAME VARCHAR(50)," +
                "STUDENT_ID INTEGER" +
                ")";

            Execute(studentsTable);
            Execute(branchesTable);
            string insert = "insert into BRANCHES (NAME,STUDENT_ID) values ('SOSYAL MEDYA',2)";
            string insert2 = "insert into BRANCHES (NAME,STUDENT_ID) values ('TASARIM',3)";
            string insert3 = "insert into BRANCHES (NAME,STUDENT_ID) values ('YAZILIM',4)";
            string insert4 = "insert into BRANCHES (NAME,STUDENT_ID) values ('SOSYOLOJİ',2)";

            /*Execute(insert);
            Execute(insert2);
            Execute(insert3);
            Execute(insert4);*/
        }

        SqliteConnection OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        void CloseConnection()
        {
            connection.Close();
        }


        public SqliteCommand Execute(string commandText, params SqliteParameter[] parameters)
        {
            using (SqliteCommand command = new SqliteCommand())
            {
                command.CommandText = commandText;
                command.Connection = OpenConnection();
                command.CommandType = CommandType.Text;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                command.ExecuteNonQuery();
                CloseConnection();
                return command;
            }
        }

        public SqliteDataReader Reader(string commandText, params SqliteParameter[] parameters)
        {
            SqliteCommand command = new SqliteCommand();
            command.CommandText = commandText;
            command.Connection = OpenConnection();
            command.CommandType = CommandType.Text;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            SqliteDataReader dataReader = command.ExecuteReader();
            return dataReader;
        }

        public static SqliteService GetInstance()
        {
            if (sqliteService == null)
            {
                sqliteService = new SqliteService();
            }
            return sqliteService;
        }

    }
}
