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
    /// Interaction logic for CreateBooks.xaml
    /// </summary>
    public partial class CreateBooks : Page
    {
        Create create = new Create();
        public CreateBooks()
        {
            create.CreateBooks(bookText.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dynamic bookResult = create.CreateBooks(bookText.Text);
            MessageBox.Show(bookResult.message);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
