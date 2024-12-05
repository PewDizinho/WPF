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
    /// Interação lógica para NumberPage.xam
    /// </summary>
    public partial class NumberPage : Page
    {
        private MainWindow _mainWindow;
        public NumberPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void ContinueButton(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(number.Text))
            {
                MessageBox.Show("Por favor, insira um número válido.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

      
            Contact contact = new()
            {
                DDD = ddd.Text,
                Number = number.Text,
                Operadora = operadora.Text

            };

            contact.Save();
           

            _mainWindow.MainFrame.Content = new UserPage(_mainWindow);

        }
    }
}
