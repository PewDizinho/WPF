using System.Windows;
using System.Windows.Controls;

namespace Desafio
{
    public partial class MainMenu : Page
    {
        private MainWindow _mainWindow;

        public MainMenu(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;  // Armazena a referência à MainWindow
        }

        private void ChangePage(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                string content = button.Content?.ToString() ?? "null";
                Page page = content switch
                {
                    "Iniciar" => new StartPage(_mainWindow),
                    "Créditos" => new CreditPage(_mainWindow),
                    _ => throw new NotImplementedException(),
                };

                if (page != null)
                {
                    _mainWindow.ChangePage(page);
                }
            }
        }
    }
}
