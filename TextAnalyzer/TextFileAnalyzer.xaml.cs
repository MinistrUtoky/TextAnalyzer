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

namespace TextAnalyzer.images
{
    /// <summary>
    /// Interaction logic for TextFileAnalyzer.xaml
    /// </summary>
    public partial class TextFileAnalyzer : Window
    {
        private TextBox _fPath;
        public TextFileAnalyzer()
        {
            InitializeComponent();
            _fPath = filePath;//(TextBox)this.FindName("filePath");
            _fPath.Text = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + "\\text.txt";
        }

        private void returnBack(object sender, RoutedEventArgs e)
        {
            MainWindow mW = new MainWindow();
            mW.Show();
            this.Close();
        }

        private void filePathChanged(object sender, TextChangedEventArgs e)
        {
        }       
    }
}
