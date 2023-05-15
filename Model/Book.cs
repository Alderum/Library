using Library.cs_files;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library
{
    internal partial class Book : Database, IDatabaseObject
    {
        public SortedSet<Book> booksList = new SortedSet<Book>(new BookComparer());
        public Book() { }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            ImagePath = Get(title, author).image;
            ID = Get(title, author).id;
            TextPath = Get(title, author).textFile;
        }
        //Initialising constructor
        public Book(string title, string author, string imagePath, string textPath)
        {
            Title = title;
            Author = author;
            ImagePath = imagePath;
            TextPath = textPath;
            ID = GetHash(title, author);
        }
        //Add book (only after initialising by non standart constuktor)
        public void Add()
        {
            using (OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                try
                {
                    if(!ThereIsTheBook(Title, Author))
                    {
                        connection.Open();
                        //command text
                        string query = "INSERT INTO books ([id], [userId], [image], [title], [author], [textFile]) " +
                            $"VALUES ({ID}, {User.ID}, '{ImagePath}', '{Title}', '{Author}', '{TextPath}')";

                        OleDbCommand command = new OleDbCommand(query, connection);//create command
                        OleDbDataReader reader = command.ExecuteReader();//execute command
                    }
                    else
                    {
                        throw new DuplicateValueException("There is a book with the title and author.");
                    }
                }
                catch (OleDbException e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
        public void Update(string parametr, string value)
        {
            if (value != null)
            {
                using (OleDbConnection connection = new OleDbConnection(stringConnection))
                {
                    try
                    {
                        connection.Open();

                        //command text
                        string query = $"UPDATE users SET [{parametr}] = '{value}'" +
                            $"WHERE [id] = {ID}";

                        OleDbCommand command = new OleDbCommand(query, connection);//create command
                        OleDbDataReader reader = command.ExecuteReader();//execute command
                    }
                    catch (OleDbException e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
            }
        }
        public void Delete()
        {
            using (OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                connection.Open();

                //command text
                string query = $"DELETE * FROM books WHERE [id] = {ID}";

                //create command
                OleDbCommand command = new OleDbCommand(query, connection);
                //execute command
                OleDbDataReader reader = command.ExecuteReader();
            }
        }

        private (int id, string image, string textFile) Get(string title, string author)
        {
            //Value to return
            int id = GetHash(title, author);
            string image = "";
            string textFile = "";

            using (OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                connection.Open();

                //command text
                string query = $"SELECT * FROM books WHERE [titile] = '{title}' AND [author] = '{author}' AND [userId] = {User.ID}";

                //create command
                OleDbCommand command = new OleDbCommand(query, connection);
                //execute command
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    image = reader["image"].ToString();
                    textFile = reader["textFile"].ToString();
                    id = (int)reader["id"];
                }
            }

            return (id, image, textFile);
        }
        //Get full books list from database
        public SortedSet<Book> GetAllBooksList()
        {
            booksList.Clear();

            using (OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                connection.Open();

                //command text
                string query = $"SELECT * FROM books WHERE [userId] = {User.ID}";

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
                    booksList.Add(book);
                }
            }

            return booksList;
        }
        //Get books list from database by parametr
        public SortedSet<Book> GetBooksList(string parametr, string text)
        {
            booksList.Clear();

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
                    booksList.Add(book);
                }
            }

            return booksList;
        }

        public override string ToString()
        {
            return $"[ID: {ID}, Title: {Title}, Author: {Author}, Image path: {ImagePath}, Text path: {TextPath}]";
        }
    }

    internal partial class Book
    {
        int id;
        string author, title, imagePath, textPath;
        public int ID
        {
            get { return id; }
            set { id = GetHash(Title, Author); }
        }
        public string Author
        {
            get { return author; }
            set 
            {
                if (value.Length < 50)
                    author = value;
            }
        }
        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length < 20)
                    title = value;
            }
        }
        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath =  value; }
        }
        public string TextPath
        {
            get { return textPath; }
            set { textPath = value; }
        }
    }
}
