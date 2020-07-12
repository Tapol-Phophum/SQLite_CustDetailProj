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
    }
}
