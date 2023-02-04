using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Library
{
    class Database
    {
        FormBooks formBooks;
        public readonly static string assetsPath = Environment.CurrentDirectory + "\\Assets\\";
        public Database () { }
        public Database (FormBooks formBooks)
        {
            this.formBooks = formBooks;
        }

        protected string stringConnection = String.Format("provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}\\MADatabase.accdb", assetsPath);

        public virtual void Add() { }
        public virtual void Update(string parametr, string value) { }
        public virtual bool Check(string parametr, string value) { return false; }
        protected int GetHash(params string[] text)
        {
            int hash = default;
            foreach(string bitText in text)
            {
                MD5 md5Hasher = MD5.Create();
                byte[] hashed = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(bitText));
                hash += Math.Abs((int)BitConverter.ToUInt32(hashed, 0));
            }
            return hash;
        }
        public void View()
        {
            using (OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                connection.Open();

                //command text
                string query = $"SELECT * FROM books";

                //create command
                OleDbCommand command = new OleDbCommand(query, connection);
                //execute command
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string title, author, imagePath, textPath;
                    imagePath = reader["image"].ToString();
                    textPath = reader["textFile"].ToString();
                    title = reader["title"].ToString();
                    author = reader["author"].ToString();

                    Book book = new Book(title, author, imagePath, textPath);
                    formBooks.OpenChildForm(new BookViewer(book, formBooks));
                }
            }
        }
        public void View(string title, string author)
        {
            using (OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                connection.Open();

                //command text
                string query = $"SELECT * FROM books WHERE [title] = '{title}' AND [author] = '{author}'";

                //create command
                OleDbCommand command = new OleDbCommand(query, connection);
                //execute command
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string imagePath, textPath;
                    imagePath = reader["image"].ToString();
                    textPath = reader["textFile"].ToString();

                    Book book = new Book(title, author, imagePath, textPath);
                    formBooks.OpenChildForm(new BookViewer(book, formBooks));
                }
            }
        }
        public void ViewWithParametr(string parametr, string text)
        {
            using (OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                connection.Open();

                //command text
                string query = $"SELECT * FROM books WHERE {parametr} = '{text}'";

                //create command
                OleDbCommand command = new OleDbCommand(query, connection);
                //execute command
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string title, author, imagePath, textPath;
                    imagePath = reader["image"].ToString();
                    textPath = reader["textFile"].ToString();
                    title = reader["title"].ToString();
                    author = reader["author"].ToString();

                    Book book = new Book(title, author, imagePath, textPath);
                    formBooks.OpenChildForm(new BookViewer(book, formBooks));
                }
            }
        }
        public void DeleteBook(Book book)
        {
            using (OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                connection.Open();

                //command text
                string query = $"DELETE * FROM books WHERE author = '{book.Author}' AND title = '{book.Title}'";

                //create command
                OleDbCommand command = new OleDbCommand(query, connection);
                //execute command
                OleDbDataReader reader = command.ExecuteReader();
            }
        }
        public bool CheckUser(string name, string password)
        {
            using (OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                connection.Open();

                //command text
                string query = $"SELECT * FROM users WHERE [name] = '{name}' AND password = '{password}'";

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
