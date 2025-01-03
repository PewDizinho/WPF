﻿using Desafio.Classes;
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
    /// Interação lógica para UserPage.xam
    /// </summary>
    public partial class UserPage : Page
    {
        private MainWindow _mainWindow;
        public UserPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void SaveButton(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text))
            {
                MessageBox.Show("Por favor, insira um nome válido.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            User user = new()
            {
                Name = name.Text,
                Cpf = cpf.Text,
                Birthdate = birthday.Text,
                Job = job.Text,
                Education = education.Text,
                Genre = genre.Text
            };

            user.Save();

            _mainWindow.ChangePage(new VouPensarPage(_mainWindow));
        }
    }
}
