﻿using Microcredit_System.ControlSystem.DatabaseStuff;
using Microcredit_System.ControlSystem.Persons.ClientStuff;
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

namespace Microcredit_System.Windows.UserControls
{
    /// <summary>
    /// Interaction logic for UserControlDebtors.xaml
    /// </summary>
    public partial class UserControlDebtors : UserControl, IRefreshable
    {
        List<Client> items;

        public UserControlDebtors()
        {
            InitializeComponent();

            items = new List<Client>();
            Refresh();
        }

        private void ListOfDebtors_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            new ChangeDebtWindow(items[ListOfDebtors.SelectedIndex], this).Show();
        }

        public void Refresh()
        {
            items = Database.DB.GetDebtors();
            ListOfDebtors.ItemsSource = items;
        }
    }
}
