using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Library
{
    internal partial class User : Database, IDatabaseObject
    {
        //Initialise user values
        public void Initialise(string name, string password)
        {
            if(CheckUser(name, password))
            {
                ID = Math.Abs(GetHash(name));
                Name = name;
                Password = password;
                Image = Get(name, password).image;
                Email = Get(name, password).email;
                ABY = Get(name, password).aby;
                ABYRB = Get(name, password).abyrb;
            }
            else
            {
                throw new DuplicateValueException("The user isn't registreted.");
            }
        }
        public void Initialise(string name, string password, string email)
        {
            if (!CheckUser(name, password))
            {
                ID = Math.Abs(GetHash(name));
                Name = name;
                Password = password;
                Image = Get(name, password).image;
                Email = email;
                ABY = Get(name, password).aby;
                ABYRB = Get(name, password).abyrb;
            }
            else
            {
                throw new DuplicateValueException("The user is registreted.");
            }
        }
        //Add new account to database
        public void Add()
        {
            using (OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                try
                {
                    // Checks has been added name yet or no
                    if (CheckName("name", name))
                    {
                        MessageBox.Show("User has been added yet.");
                    }

                    connection.Open();

                    //Get hesh from name
                    int id = GetHash(name);
                    //command text
                    string query = "INSERT INTO users ([id], [name], [password], [email]) " +
                        $"VALUES ({ID}, '{Name}', '{Password}', '{Email}')";

                    OleDbCommand command = new OleDbCommand(query, connection);//create command
                    OleDbDataReader reader = command.ExecuteReader();//execute command
                }
                catch (OleDbException e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
        //Update values by its name
        public void Update(string parametr, string value)
        {
            if(value != null)
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
                string query = $"DELETE * FROM users WHERE [id] = {ID}";

                //create command
                OleDbCommand command = new OleDbCommand(query, connection);
                //execute command
                OleDbDataReader reader = command.ExecuteReader();
            }
        }
        //Check value by its name
        public bool CheckName(string parametr, string value)
        {
            using (OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                connection.Open();

                //command text
                string query = $"SELECT * FROM users WHERE [{parametr}] = '{value}'";

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
        //Return values without initialised object
        public (int id, string name, string password, string image, string email, string aby, string abyrb, string userString) Get(string name, string password)
        {
            //Value to return
            int id = GetHash(name);
            string email = default;
            string image = assetsPath + "DefaultImage.jpg";
            string aby = "";
            string abyrb = "";

            using (OleDbConnection connection = new OleDbConnection(stringConnection))
            {
                connection.Open();

                //command text
                string query = $"SELECT * FROM users WHERE name = '{name}' AND password = '{password}'";

                //create command
                OleDbCommand command = new OleDbCommand(query, connection);
                //execute command
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    name = reader["name"].ToString();
                    password = reader["password"].ToString();
                    if (reader["image"].ToString() != "DefaultImage.jpg")
                        image = reader["image"].ToString();
                    email = reader["email"].ToString();
                    aby = reader["aby"].ToString();
                    abyrb = reader["abyrb"].ToString();
                }
            }

            return (id, name, password, image, email, aby, abyrb, ToString());
        }

        public override string ToString()
        {
            return $"[Id: {ID}, Name: {Name}, Password: {Password}, Email: {Email}, Image: {Image}, ABY: {ABY}, ABYRB: {ABYRB}]";
        }
    }
    internal partial class User
    {
        private static string name, password, image, email, aby, abyrb;
        private static int id;


        //User id (hash)
        public static int ID
        {
            get { return id; }
            set
            {
                if(value > 999999)
                    id = value % 1000000;
            }
        }
        //User name
        public static string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 15)
                    name = value;
            }
        }
        //User password
        public static string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 30)
                    password = value;
            }
        }
        //User e-mail
        public static string Email
        {
            get { return email; }
            set
            {
                if (value.Length < 50)
                    email = value;
            }
        }
        //Users profile image
        public static string Image
        {
            get { return image; }
            set { image = value; }
        }
        //Information about user (About you)
        public static string ABY
        {
            get { return aby; }
            set
            {
                if (value.Length < 255)
                    aby = value;
            }
        }
        //Information about users books (About your books)
        public static string ABYRB
        {
            get { return abyrb; }
            set
            {
                if (value.Length < 500)
                    abyrb = value;
            }
        }
    }
}
