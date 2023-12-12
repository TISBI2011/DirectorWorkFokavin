﻿using System;
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

namespace DirectorWorkFokavin2.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void TBLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
            var user = App.DB.User.FirstOrDefault(x => x.Login == BLogin.Text && x.Password == BPassword.Text);

            if (user != null)
                NavigationService.Navigate(new MainWindow());
            else
                MessageBox.Show("Введены не правильные данные");
        }

        private void TBRegistracia_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }
    }
}
