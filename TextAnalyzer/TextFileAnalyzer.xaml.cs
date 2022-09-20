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
        private string _startPath;
        private string _fileContent=null;
        public TextFileAnalyzer()
        {
            InitializeComponent();
            _startPath = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + "\\text.txt";
            filePath.Text = _startPath;
        }

        private void returnBack(object sender, RoutedEventArgs e)
        {
            MainWindow mW = new MainWindow();
            mW.Show();
            this.Close();
        }

        private void fileBrowser_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog fileBrowserDialog = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = fileBrowserDialog.ShowDialog();
            if (result == true)
            {
                filePath.Text = fileBrowserDialog.FileName;
                _fileContent = System.IO.File.ReadAllText(filePath.Text);
            }

        }

        private void proceedButton_Click(object sender, RoutedEventArgs e)
        {
            if (System.IO.Path.GetExtension(filePath.Text) == ".txt")
                if (System.IO.File.Exists(filePath.Text))
                {
                    _fileContent = System.IO.File.ReadAllText(filePath.Text);
                    TextInfo tI = new TextInfo();
                    tI.analyzeText(_fileContent);
                    tI.ShowDialog();
                    return;
                }
                else errorMessageSpace.Text = "FILE PATH DOES NOT EXIST!";
            else errorMessageSpace.Text = "TEXT ANALYZER 3000 ACCEPTS ONLY .TXT FILES";
            _fileContent = null;
            filePath.Text = _startPath;
        }
    }
}
