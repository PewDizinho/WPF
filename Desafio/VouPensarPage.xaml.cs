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
    /// Interação lógica para VouPensarPage.xam
    /// </summary>
    public partial class VouPensarPage : Page
    {
        private MainWindow _mainWindow;
        public VouPensarPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }


        public void NoClicked(object sender, RoutedEventArgs e)
        {
            
        }
        public void ChangePage(object sender, RoutedEventArgs e)
        {
            _mainWindow.ChangePage(new EstaPensandoPage(_mainWindow));
        }
    }
}
