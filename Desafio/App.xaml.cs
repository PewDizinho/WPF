using System.Configuration;
using System.Data;
using System.Windows;

namespace Desafio
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string databasename = "User.db";
        public static string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string databasepath = System.IO.Path.Combine(folderpath, databasename);

    }

}
