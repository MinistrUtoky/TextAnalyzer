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

namespace TextAnalyzer
{
    /// <summary>
    /// Interaction logic for TextInputAnalyzer.xaml
    /// </summary>
    public partial class TextInputAnalyzer : Window
    {
        public TextInputAnalyzer()
        {
            InitializeComponent();
        }
        private void returnBack(object sender, RoutedEventArgs e)
        {
            MainWindow mW = new MainWindow();
            mW.Show();
            this.Close();
        }

        private void eraserButton_Click(object sender, RoutedEventArgs e)
        {
            textField.Text = "";
        }

        private void analyzeButton_Click(object sender, RoutedEventArgs e)
        {
            TextInfo tI = new TextInfo();
            if (textField.Text == "") tI.analyzeText(null);
            else tI.analyzeText(textField.Text);
            tI.ShowDialog();
        }
    }
}
