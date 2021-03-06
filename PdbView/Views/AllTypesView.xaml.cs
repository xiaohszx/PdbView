﻿using Syncfusion.UI.Xaml.Grid;
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

namespace PdbView.Views {
    /// <summary>
    /// Interaction logic for AllTypesView.xaml
    /// </summary>
    public partial class AllTypesView : UserControl {
        public AllTypesView() {
            InitializeComponent();
        }

        private void SfDataGrid_SelectionChanged(object sender, Syncfusion.UI.Xaml.Grid.GridSelectionChangedEventArgs e) {
            var grid = (SfDataGrid)sender;
            if (grid.SelectedItem != null)
                grid.ScrollInView(new Syncfusion.UI.Xaml.ScrollAxis.RowColumnIndex(grid.SelectedIndex, 0));
        }
    }
}
