using System.Windows;
using System.Windows.Controls;

namespace Desafio
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
         
            MainFrame.Navigate(new MainMenu(this));
        }

        public void ChangePage(Page page)
        {
            MainFrame.Navigate(page);
        }


    }
}
