using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    class Database
    {
        private string stringConnection = @"provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Programming\\VS_Progects\\C#\\Library\\Assets\\MADatabase.accdb";

        public string CheckConnection()
        {
            using(OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                try
                {
                    connection.Open();
                    return "All is good.";
                }
                catch (OleDbException ex)
                {
                    return ex.Message;
                }
            }
        }

        public void AddBook(int userId, string image, string title, string author, string textFile)
        {
            using (OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                connection.Open();

                //command text
                string query = "INSERT INTO books (userId, image, title, author, text) " +
                    $"VALUES ({userId}, {image}, {title}, {author}, {textFile});";

                OleDbCommand command = new OleDbCommand(query, connection);//create command
                OleDbDataReader reader = command.ExecuteReader();//execute command
            }
        }

        public void AddUser(string name, string password, string e_mail)
        {
            using (OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                connection.Open();

                //command text
                string query = "INSERT INTO users (name, password, e-mail) " +
                    $"VALUES ({name}, {password}, {e_mail});";

                OleDbCommand command = new OleDbCommand(query, connection);//create command
                OleDbDataReader reader = command.ExecuteReader();//execute command
            }
        }

        public bool CheckName(string name)
        {
            using (OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                connection.Open();

                //command text
                string query = $"SELECT * FROM users WHERE name = '{name}'";
                
                //create command
                OleDbCommand command = new OleDbCommand(query, connection);
                //execute command
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public bool CheckUser(string name, string password)
        {
            using (OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                connection.Open();

                //command text
                string query = $"SELECT * FROM users WHERE name = '{name}' AND password = '{password}'";
                
                //create command
                OleDbCommand command = new OleDbCommand(query, connection);
                //execute command
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
