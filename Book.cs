using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library
{
    internal partial class Book : Database
    {
        public Book(string title, string author, string imagePath, string textPath)
        {
            //Initialise fields
            Title = title;
            Author = author;
            ImagePath = imagePath;
            TextPath = textPath;
            ID = GetHash(title, author);
        }
        public override void Add()
        {
            using (OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                try
                {
                    connection.Open();
                    //command text
                    string query = "INSERT INTO books ([id], [userId], [image], [title], [author], [textFile]) " +
                        $"VALUES ({ID}, {User.ID}, '{ImagePath}', '{Title}', '{Author}', '{TextPath}')";

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
