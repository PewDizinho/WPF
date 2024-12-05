using Desafio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Desafio
{
    /// <summary>
    /// Interação lógica para InfoPage.xam
    /// </summary>
    public partial class InfoPage : Page
    {
        private MainWindow _mainWindow;
        private User user = new();
        private Contact contact = new();
        private Address adr = new();
        public InfoPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;


            name.Content += user.GetName();
            cpf.Content += user.GetCpf();
            age.Content += user.GetAge();
            genre.Content += user.GetGenre();
            job.Content += user.GetJob();
            education.Content += user.GetEducation();
            //-------------------------
            DDD.Content += contact.GetFullNumber();
            operadora.Content += contact.GetOperadora();
            //-------------------------

            address.Text += adr.GetFullAddress();
        }

        public void RemoveAll(object sender, RoutedEventArgs e)
        {
            user.Delete();
            adr.Delete();
            contact.Delete();
            MessageBox.Show("Database inteira deletada", "Anteção", MessageBoxButton.OK, MessageBoxImage.Information);
            _mainWindow.ChangePage(new InfoPage(_mainWindow));
        }

        public void ChangePage(object sender, RoutedEventArgs e)
        {
            _mainWindow.ChangePage(new MainMenu(_mainWindow));
        }
    }
}
