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

using System.Diagnostics;
using System.Linq;
using System.Windows;
using LoLAccountChecker.Data;

#endregion

namespace LoLAccountChecker.Views
{
    public partial class SkinsWindow
    {
        public SkinsWindow(Account account)
        {
            InitializeComponent();

            Title = string.Format("{0} - Skins", account.Username);

            if (account.SkinList != null)
            {
                account.SkinList.ForEach(skin => _skinsDataGrid.Items.Add(skin));
            }
        }

        private void CmViewModel(object sender, RoutedEventArgs e)
        {
            // old versions didn't save skin id and champion id in the exported files 
            var selectedSkin = _skinsDataGrid.SelectedItem as SkinData;

            if (selectedSkin == null)
            {
                return;
            }

            if (selectedSkin.Skin == null)
            {
                var champion = LeagueData.Champions.FirstOrDefault(c => c.Skins.Any(s => s.Name == selectedSkin.Name));

                if (champion == null)
                {
                    return;
                }

                var skin = champion.Skins.FirstOrDefault(s => s.Name == selectedSkin.Name);

                if (skin == null)
                {
                    return;
                }

                selectedSkin.Skin = skin;
                selectedSkin.Champion = champion;
            }

            Process.Start(
                string.Format(
                    "http://www.lolking.net/models/?champion={0}&skin={1}", selectedSkin.Champion.Id,
                    selectedSkin.Skin.Number - 1));
        }
    }
}