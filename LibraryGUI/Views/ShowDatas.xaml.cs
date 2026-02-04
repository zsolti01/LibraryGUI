using LibraryGUI.Datas;
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

namespace LibraryGUI.Views
{
    /// <summary>
    /// Interaction logic for ShowDatas.xaml
    /// </summary>
    public partial class ShowDatas : Page
    {
        Read read = new Read();
        private readonly MainWindow _mainWindow;
        public ShowDatas(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var list = read.ReadAuthors();
            MessageBox.Show(list?.Count.ToString() ?? "null");
            dataGrid1.ItemsSource = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var list = read.ReadCategories();
            MessageBox.Show(list?.Count.ToString() ?? "null");
            dataGrid1.ItemsSource = list;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var list = read.ReadBooks();
            MessageBox.Show(list?.Count.ToString() ?? "null");
            dataGrid1.ItemsSource = list;
        }
    }
}