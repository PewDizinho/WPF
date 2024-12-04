using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Desafio.Classes
{
    internal class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string DDD { get; set; }
        public string Number { get; set; }
        public string Operadora { get; set; }


        private static string databasename = "Contact.db";//User.db Contact.db e Address.db
        private static string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string databasepath = System.IO.Path.Combine(folderpath, databasename);

        public void Delete()
        {
            using (SQLite.SQLiteConnection connection = new(databasepath))
            {
                connection.CreateTable<Contact>();
                connection.DeleteAll<Contact>();

            }
        }
        public void Save()
        {

            Delete();
            using (SQLite.SQLiteConnection connection = new(databasepath))
            {
                connection.CreateTable<Contact>();
                connection.Insert(this);
            }
        }
        public Contact Read()
        {
            using (SQLite.SQLiteConnection connection = new(databasepath))
            {
                connection.CreateTable<Contact>();
                /*  var address = connection.Table<Contact>().ToList();
                  return address[0];*/
                return connection.Table<Contact>().ToList()[0];

            }
        }
    }


}
