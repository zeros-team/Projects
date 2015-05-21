#region License

// Copyright 2015 LoLAccountChecker
// 
// This file is part of LoLAccountChecker.
// 
// LoLAccountChecker is free software: you can redistribute it and/or modify 
// it under the terms of the GNU General Public License as published 
// by the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// LoLAccountChecker is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of 
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
// See the GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License 
// along with LoLAccountChecker. If not, see http://www.gnu.org/licenses/.

#endregion

#region

using System;
using System.Linq;
using System.Windows;
using LoLAccountChecker.Data;
using PVPNetConnect;

#endregion

namespace LoLAccountChecker.Views
{
    public partial class AccountWindow
    {
        public static AccountWindow Instance;

        private Account _account;

        public AccountWindow(Account account = null)
        {
            InitializeComponent();

            _regionBox.ItemsSource = Enum.GetValues(typeof(Region)).Cast<Region>();
            _regionBox.SelectedItem = Settings.Config.SelectedRegion;

            Instance = this;

            Loaded += (o, a) => UpdateWindow();
            Closed += (o, a) => Instance = null;

            if (account == null)
            {
                return;
            }

            _account = account;

            _usernameBox.Text = _account.Username;
            _passwordBox.Password = _account.Password;
            _passwordBoxText.Text = _account.Password;
            _regionBox.SelectedItem = _account.Region;
        }

        public void UpdateWindow()
        {
            if (!Dispatcher.CheckAccess())
            {
                Dispatcher.Invoke(UpdateWindow);
                return;
            }

            if (Settings.Config.ShowPasswords)
            {
                _passwordBoxText.Text = _passwordBox.Password;
                _passwordBoxText.Visibility = Visibility.Visible;
                _passwordBox.Visibility = Visibility.Hidden;
            }
            else
            {
                _passwordBox.Password = _passwordBoxText.Text;
                _passwordBoxText.Visibility = Visibility.Hidden;
                _passwordBox.Visibility = Visibility.Visible;
            }
        }

        private void BtnSaveClick(object sender, RoutedEventArgs e)
        {
            var password = Settings.Config.ShowPasswords ? _passwordBoxText.Text : _passwordBox.Password;

            if (string.IsNullOrEmpty(_usernameBox.Text) || string.IsNullOrWhiteSpace(password))
            {
                _resultLabel.Content = "Insert a username and password!";
                return;
            }

            if (_account != null)
            {
                if (Checker.IsChecking)
                {
                    _resultLabel.Content = "Stop the checker before saving.";
                    return;
                }

                if (_account.Username != _usernameBox.Text &&
                    Checker.Accounts.Any(a => a.Username.ToLower() == _usernameBox.Text.ToLower()))
                {
                    _resultLabel.Content = "Username already exists!";
                    return;
                }

                var account = Checker.Accounts.FirstOrDefault(a => a == _account);

                if (account != null)
                {
                    account.Username = _usernameBox.Text;
                    account.Password = password;
                    account.Region = (Region) _regionBox.SelectedItem;
                    _account = account;
                    _resultLabel.Content = "Account successfuly edited!";
                }
            }
            else
            {
                if (Checker.Accounts.Any(a => a.Username.ToLower() == _usernameBox.Text.ToLower()))
                {
                    _resultLabel.Content = "Username already exists!";
                    return;
                }

                var newAccount = new Account
                {
                    Username = _usernameBox.Text,
                    Password = password,
                    Region = (Region) _regionBox.SelectedItem
                };

                _account = newAccount;
                Checker.Accounts.Add(_account);

                _resultLabel.Content = "Account successfuly added!";
            }

            if (AccountsWindow.Instance != null)
            {
                AccountsWindow.Instance.RefreshAccounts();
            }

            MainWindow.Instance.UpdateControls();
        }
    }
}