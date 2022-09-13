using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TextAnalyzer.images;

namespace TextAnalyzer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void redPillButton_Click(object sender, RoutedEventArgs e)
        {
            TextFileAnalyzer txtFileAnalyzer = new TextFileAnalyzer();
            txtFileAnalyzer.Show();
            this.Close();
        }

        private void bluePillButton_Click(object sender, RoutedEventArgs e)
        {
            TextInputAnalyzer txtInputAnalyzer = new TextInputAnalyzer()    ;
            txtInputAnalyzer.Show();
            this.Close();
        }
    }
}
