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
    /// Interação lógica para EstaPensandoPage.xam
    /// </summary>
    public partial class EstaPensandoPage : Page
    {
        private MainWindow _mainWindow;
        public EstaPensandoPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        public void NoClicked(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Psiuu, você precisa estar pensand em você mesmo para funcionar", "Anteção", MessageBoxButton.OK, MessageBoxImage.Information);
            _mainWindow.ChangePage(new VouPensarPage(_mainWindow));
        }

        public void ChangePage(object sender, RoutedEventArgs e)
        {
            _mainWindow.ChangePage(new InfoPage(_mainWindow));
        }


    }
}
