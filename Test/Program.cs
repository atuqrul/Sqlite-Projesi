
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
           /* SqliteConnection connection = new SqliteConnection("Data Source=MYDATABASE.db;");
            connection.Open();

            SqliteCommand command = new SqliteCommand("Create Table If Not Exists PERSONELLER (" +
                "ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                "NAME VARCHAR(50)" +
                ")", connection);

            command.ExecuteNonQuery();


            /*command = new SqliteCommand("insert into PERSONELLER (NAME) values (@name)", connection);
            command.Parameters.AddWithValue("@name", "Merve KIZIL");
            command.ExecuteNonQuery();*/

            /*command = new SqliteCommand("update PERSONELLER set NAME=@name where ID=@id", connection);
            command.Parameters.AddWithValue("@id", 4);
            command.Parameters.AddWithValue("@name", "Adem Saman_2");
            command.ExecuteNonQuery();*/


            /*command = new SqliteCommand("delete from PERSONELLER where ID=@id", connection);
            command.Parameters.AddWithValue("@id", 4);            
            command.ExecuteNonQuery();*/

            /*List<Personnel> personnels = new List<Personnel>();
            command = new SqliteCommand("select * from PERSONELLER", connection);

            SqliteDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                personnels.Add(new Personnel(
                    Convert.ToInt32(dataReader["ID"]),
                    dataReader["NAME"].ToString()
                    ));
            }

            connection.Close();

            foreach (Personnel item in personnels)
            {
                Console.WriteLine($"Id : {item.Id} Name : {item.Name}");
            }


            Console.WriteLine();
            Console.WriteLine("İşlem Tamamlandı");
            Console.Read();*/
        }
        class Personnel
        {
            int id; string name;

            public int Id { get => id; set => id = value; }
            public string Name { get => name; set => name = value; }

            public Personnel(int id, string name)
            {
                this.id = id;
                this.name = name;
            }
        }
    }
}
