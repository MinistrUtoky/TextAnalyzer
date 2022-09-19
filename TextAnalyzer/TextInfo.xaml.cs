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
    /// Interaction logic for TextInfo.xaml
    /// </summary>
    public partial class TextInfo : Window
    {
        public TextInfo()
        {
            InitializeComponent();
        }
        
        public void analyzeText(string text)
        {
            if (text == null)
            {
                wordsNumber.Text = "0";
                uniqueWordsNumber.Text = "0";
                longestWords.Text = "-";
                mostPopularWords.Text = "-";
                characterPercentile.Text = "-";
                return;
            }
        }
    }
}
