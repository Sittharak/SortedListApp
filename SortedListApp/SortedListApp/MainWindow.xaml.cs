using System;
using System.Collections;
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

namespace SortedListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            sortedList.Add(keyTxt.Text,valueTxt.Text);
            ICollection collection = sortedList.Keys;
            string allValue = "";
            foreach(string key in collection)
            {
                allValue = allValue + " " + sortedList[key].ToString() + "\n";
            }
            MessageBox.Show(allValue);
        }
    }
}
