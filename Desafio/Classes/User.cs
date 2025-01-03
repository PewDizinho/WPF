﻿using SQLite;
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



        private static string databasename = "User.db";//User.db Contact.db e Address.db
        private static string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string databasepath = System.IO.Path.Combine(folderpath, databasename);

        public void Delete()
        {
            using (SQLite.SQLiteConnection connection = new(databasepath))
            {
                connection.CreateTable<User>();
                connection.DeleteAll<User>();

            }
        }
        public void Save()
        {

            Delete();
            using (SQLite.SQLiteConnection connection = new(databasepath))
            {
                connection.CreateTable<User>();
                connection.Insert(this);
            }
        }
        public User Read()
        {
            using (SQLite.SQLiteConnection connection = new(databasepath))
            {
                connection.CreateTable<User>();
                var users = connection.Table<User>().ToList();
                return users[0];

            }
        }


    }
}
