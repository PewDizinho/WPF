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
    /// Interação lógica para CreditPage.xam
    /// </summary>
    public partial class CreditPage : Page
    {
        private MainWindow _mainWindow;
        public CreditPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void ChangePage(object sender, RoutedEventArgs e)
        {
            _mainWindow.ChangePage(new MainMenu(_mainWindow));
        }
    }

}
