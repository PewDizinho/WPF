using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Classes
{
    internal class Address
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Addres { get; set; }
        public int? Number { get; set; }
        public string? Complemento { get; set; }
        public string? Neighborhood { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }


        private static string databasename = "Address.db";//User.db Contact.db e Address.db
        private static string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string databasepath = System.IO.Path.Combine(folderpath, databasename);

        public void Delete()
        {
            using (SQLite.SQLiteConnection connection = new(databasepath))
            {
                connection.CreateTable<Address>();
                connection.DeleteAll<Address>();

            }
        }
        public void Save()
        {

            Delete();
            using (SQLite.SQLiteConnection connection = new(databasepath))
            {
                connection.CreateTable<Address>();
                connection.Insert(this);
            }
        }
        public Address Read()
        {
            using (SQLite.SQLiteConnection connection = new(databasepath))
            {
                connection.CreateTable<Address>();
                /*  var address = connection.Table<Address>().ToList();
                  return address[0];*/
                return connection.Table<Address>().ToList()[0];

            }
        }
    }
}

