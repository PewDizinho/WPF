using SQLite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows;

namespace Desafio.Classes
{
    internal class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Birthdate { get; set; }
        public string Job { get; set; }
        public string Education { get; set; }

        public void Delete()
        {
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.databasepath))
            {
                connection.CreateTable<User>();
                connection.DeleteAll<User>();

            }

        }
        public void Save()
        {

            Delete();//<-- É um unico User por vez, não tem pq não deletar antes de salvar
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.databasepath))
            {
                connection.CreateTable<User>();
                connection.Insert(this);
            }
        }

        public User ReadDatabase()
        {
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.databasepath))
            {
                connection.CreateTable<User>();
                var users = connection.Table<User>().ToList();
               

                return users[0];
                
            }
        }
    }
}
