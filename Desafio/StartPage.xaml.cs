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
using static System.Net.Mime.MediaTypeNames;

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
            int? parsed = null;
            if (string.IsNullOrWhiteSpace(endereco.Text))
            {
                MessageBox.Show("Por favor, insira um endereço válido.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(number.Text))
            {
                if (!int.TryParse(number.Text, out int parsedNumber))
                {
                    MessageBox.Show("Por favor, insira um número válido.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                parsed = parsedNumber;
            }

            Address addr = new()
            {
                Addres = endereco.Text.ToString(),
                Number = parsed,
                City = city.Text.ToString(),
                State = state.Text.ToString(),
                Neighborhood = neighborhood.Text.ToString()
            };

            addr.Save();
            var test = addr.Read();

            MessageBox.Show(test.Addres + " " + test.Number.ToString() + " " + test.City + " " + test.State + " " + test.Neighborhood);
        }


    }


}
