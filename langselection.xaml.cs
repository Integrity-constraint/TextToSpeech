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
using System.Windows.Shapes;

namespace TextToSpeech
{
    /// <summary>
    /// Логика взаимодействия для langselection.xaml
    /// </summary>
    public partial class langselection : Window
    {
        public langselection()
        {
            InitializeComponent();
        }

        private void ru(object sender, RoutedEventArgs e)
        {
            Window win = new MainWindow();
            this.Close();
            win.Show();
        }

        private void eng(object sender, RoutedEventArgs e)
        {
            Window win = new MainWindowsENG();
            this.Close();
            win.Show();
        }
    }
}
