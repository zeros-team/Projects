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
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using LoLAccountChecker.Data;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Win32;
using Newtonsoft.Json;
using PVPNetConnect;

#endregion

namespace LoLAccountChecker.Views
{
    public partial class MainWindow
    {
        public static MainWindow Instance;

        public MainWindow()
        {
            InitializeComponent();

            Instance = this;

            _accountsDataGrid.ItemsSource = Checker.Accounts.Where(a => a.State == Account.Result.Success);

            // Init Regions
            _regionsComboBox.ItemsSource = Enum.GetValues(typeof(Region)).Cast<Region>();
            _regionsComboBox.SelectedItem = Settings.Config.SelectedRegion;

            Loaded += WindowLoaded;
            Closed += WindowClosed;
        }

        private async void WindowLoaded(object sender, RoutedEventArgs e)
        {
            await LeagueData.Load();
            await Utils.UpdateClientVersion();
        }

        private void WindowClosed(object sender, EventArgs e)
        {
            Settings.Save();
            Application.Current.Shutdown();
        }

        public void UpdateControls()
        {
            if (!Dispatcher.CheckAccess())
            {
                Dispatcher.Invoke(UpdateControls);
                return;
            }

            var numCheckedAcccounts = Checker.Accounts.Count(a => a.State != Account.Result.Unchecked);

            // Progress Bar
            _progressBar.Value = Checker.Accounts.Any() ? ((numCheckedAcccounts * 100f) / Checker.Accounts.Count()) : 0;

            // Export Button
            _exportButton.IsEnabled = numCheckedAcccounts > 0;

            // Start Button
            _startButton.IsEnabled = numCheckedAcccounts < Checker.Accounts.Count;
            _startButton.Content = Checker.IsChecking ? "Stop" : "Start";

            // Status Label
            if (Checker.IsChecking)
            {
                _statusLabel.Content = "Status: Checking...";
            }
            else if (numCheckedAcccounts > 0 && Checker.Accounts.All(a => a.State != Account.Result.Unchecked))
            {
                _statusLabel.Content = "Status: Finished!";
            }

            // Checked Accounts Label
            _checkedLabel.Content = string.Format("Checked: {0}/{1}", numCheckedAcccounts, Checker.Accounts.Count);

            // Grid
            _accountsDataGrid.ItemsSource = Checker.Accounts.Where(a => a.State == Account.Result.Success);
        }

        public void UpdateProgressBar(double value)
        {
            if (value > 100 || value < 0)
            {
                return;
            }

            if (!Dispatcher.CheckAccess())
            {
                Dispatcher.Invoke(() => UpdateProgressBar(value));
                return;
            }

            _progressBar.Value = value;
        }

        #region Right Window Commands

        private void BtnDonateClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=CHEV6LWPMHUMW");
        }

        private void BtnGithubClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/madk/LoLAccountChecker");
        }

        private async void BtnRefreshClick(object sender, RoutedEventArgs e)
        {
            if (Checker.IsChecking)
            {
                await this.ShowMessageAsync("Error", "Please wait for the checking process to be completed.");
                return;
            }

            if (!Checker.Accounts.Any())
            {
                await this.ShowMessageAsync("Error", "You don't have any accounts.");
                return;
            }

            if (Checker.Accounts.Any(a => a.State == Account.Result.Error))
            {
                var dialog =
                    await
                        this.ShowMessageAsync(
                            "Refresh", "Do you want to refresh accounts with Errors?",
                            MessageDialogStyle.AffirmativeAndNegative);

                Checker.Refresh(dialog == MessageDialogResult.Affirmative);
                return;
            }

            Checker.Refresh();
        }

        #endregion

        #region Import Button

        private void BtnImportClick(object sender, RoutedEventArgs e)
        {
            var ofd = new OpenFileDialog();

            ofd.Filter = "JavaScript Object Notation (*.json)|*.json";

            var result = ofd.ShowDialog();

            if (result == true)
            {
                var file = ofd.FileName;
                if (!File.Exists(ofd.FileName))
                {
                    return;
                }

                List<Account> accounts;
                var num = 0;

                using (var sr = new StreamReader(file))
                {
                    accounts = JsonConvert.DeserializeObject<List<Account>>(sr.ReadToEnd());
                }

                foreach (var account in accounts)
                {
                    if (!Checker.Accounts.Exists(a => a.Username == account.Username))
                    {
                        Checker.Accounts.Add(account);
                        num++;
                    }
                }

                UpdateControls();

                if (num > 0)
                {
                    this.ShowMessageAsync("Import", string.Format("Imported {0} accounts.", num));
                }
                else
                {
                    this.ShowMessageAsync("Import", "No new accounts found.");
                }
            }
        }

        #endregion

        #region Export Button

        private void BtnExportToFileClick(object sender, RoutedEventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.FileName = "output";
            sfd.Filter = "JavaScript Object Notation (*.json)|*.json";

            if (sfd.ShowDialog() == true)
            {
                var file = sfd.FileName;

                Utils.ExportAsJson(file, Checker.Accounts, true);
                this.ShowMessageAsync("Export", string.Format("Exported {0} accounts.", Checker.Accounts.Count));
            }
        }

        #endregion

        #region Accounts Button

        private void BtnAccountsClick(object sender, RoutedEventArgs e)
        {
            if (AccountsWindow.Instance == null)
            {
                AccountsWindow.Instance = new AccountsWindow();
                AccountsWindow.Instance.Show();
                AccountsWindow.Instance.Closed += (o, a) => { AccountsWindow.Instance = null; };
            }
            else if (AccountsWindow.Instance != null && !AccountsWindow.Instance.IsActive)
            {
                AccountsWindow.Instance.Activate();
            }
        }

        #endregion

        #region Start Button

        private void BtnStartCheckingClick(object sender, RoutedEventArgs e)
        {
            if (Checker.IsChecking)
            {
                Checker.Stop();
                _startButton.Content = "Start";
                _statusLabel.Content = "Status: Stopped!";
                return;
            }

            if (Checker.Accounts.All(a => a.State != Account.Result.Unchecked))
            {
                this.ShowMessageAsync("Error", "All accounts have already been checked.");
                return;
            }

            _startButton.Content = "Stop";
            _statusLabel.Content = "Status: Checking...";

            Checker.Start();
        }

        #endregion

        #region Context Menu

        private void CmCopyComboClick(object sender, RoutedEventArgs e)
        {
            var account = _accountsDataGrid.SelectedItem as Account;

            if (account == null)
            {
                return;
            }

            var combo = string.Format("{0}:{1}", account.Username, account.Password);
            Clipboard.SetText(combo);
        }

        private void CmViewChampionsClick(object sender, RoutedEventArgs e)
        {
            var account = _accountsDataGrid.SelectedItem as Account;

            if (account == null)
            {
                return;
            }

            var window = new ChampionsWindow(account);
            window.Show();
        }

        private void CmViewSkinsClick(object sender, RoutedEventArgs e)
        {
            var account = _accountsDataGrid.SelectedItem as Account;

            if (account == null)
            {
                return;
            }

            var window = new SkinsWindow(account);
            window.Show();
        }

        private void CmViewRunesClick(object sender, RoutedEventArgs e)
        {
            var account = _accountsDataGrid.SelectedItem as Account;

            if (account == null)
            {
                return;
            }

            var window = new RunesWindow(account);
            window.Show();
        }

        private void CmViewTransfersClick(object sender, RoutedEventArgs e)
        {
            var account = _accountsDataGrid.SelectedItem as Account;

            if (account == null)
            {
                return;
            }

            var window = new TransfersWindow(account);
            window.Show();
        }

        #endregion

        #region Regions Combo Box

        private void CbRegionOnChangeSelection(object sender, SelectionChangedEventArgs e)
        {
            Settings.Config.SelectedRegion = (Region) _regionsComboBox.SelectedIndex;
        }

        #endregion

    }
}