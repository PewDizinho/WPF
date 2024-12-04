using Desafio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Interação lógica para StartPage.xam
    /// </summary>
    public partial class StartPage : Page
    {
        private MainWindow _mainWindow;
        public StartPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SaveButton(object sender, RoutedEventArgs e)
        {


            //var address = new Address(endereco.Text, Convert.ToInt32(number.Text), city.Text, state.Text, neighborhood.Text);
            User Usr = new()
            {
                
            };


            //Usr.Save();

            MessageBox.Show(Usr.ReadDatabase().Name);
            //Close();

            /*

             user.Save();
             user.Show();



             /*MessageBox.Show(map.Width.ToString());
             string textBlockContent = address.Text;
             MessageBox.Show(textBlockContent);*/
        }

        private void ShowButton(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show(Address.toJson().ToString());
        }
    }


}
