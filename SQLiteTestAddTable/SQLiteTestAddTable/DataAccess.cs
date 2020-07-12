using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTestAddTable
{
    class DataAccess
    {
        //Add Method for Create Table Data base
        public static void InitializeDatabase() //method static Type don't Create Object Instance Can call method
        {
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db")) //Create object: db for index path
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                     "EXISTS MyCustomers (CustID NVARCHAR(50) PRIMARY KEY, " +
                     "first_Name NVARCHAR(50) NOT NULL," +
                     "last_Name NVARCHAR(50) NOT NULL," +
                     "email NVARCHAR(60) NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db); // Create object : createTable for keep  SQL command and  conection

                createTable.ExecuteReader();
            }
        }
        // Method Add DataBase
        public static void AddData(string CustID, string firstName, string lastName, string email)
        {
            using (SqliteConnection db =
              new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks //ป้องกันการโจมตีฐานข้อมูล ข้อมูลต้องไม่เป็น SQL command
                insertCommand.CommandText = "INSERT INTO MyCustomers VALUES ('" + CustID + "', @firstName, @lastName, @email);";
                insertCommand.Parameters.AddWithValue("@firstName", firstName);
                insertCommand.Parameters.AddWithValue("@lastName", lastName);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.ExecuteReader();

                db.Close();
            }
        }
    }
}
