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

using LoLAccountChecker.Data;

#endregion

namespace LoLAccountChecker.Views
{
    public partial class RunesWindow
    {
        public RunesWindow(Account account)
        {
            InitializeComponent();

            Title = string.Format("{0} - Runes", account.Username);

            if (account.Runes != null)
            {
                _runesDataGrid.ItemsSource = account.Runes;
            }
        }
    }
}