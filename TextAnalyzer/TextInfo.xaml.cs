using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private Dictionary<string, int> _counter = new Dictionary<string, int>();
        private string[] _parts;
        private string _pattern;
        private Regex _regex;
        private StringBuilder _popularitySB;
        private StringBuilder _lengthSB;
        private StringBuilder _charsSB;
        private Dictionary<char, int> _charactersCounter = new Dictionary<char, int>();
        //Жил был Боба(не гей[честно-пречестно]), умер. Грустно,но- что поделать !!!... Был жил Биба(гей{да}), не - умер/ Капец да -жир№кукодж%поридж , 
        public TextInfo()
        {
            InitializeComponent();
            _pattern = @"([^A-Za-zА-Яа-я -])";
            _regex = new Regex(_pattern);
            _popularitySB = new StringBuilder();
            _lengthSB = new StringBuilder();
            _charsSB = new StringBuilder();
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
 
            text = _regex.Replace(text.ToLower(), " ");
            // ;) some cringe:
            text = text.Replace(" -", " ").Replace("- ", " ").Replace("--", "");

            _parts = text.Split();
            foreach (var part in _parts)
                if (part != "")
                    if (_counter.ContainsKey(part)) _counter[part]++;
                    else _counter[part] = 1;
            foreach (char c in text)
            {
                if (c != ' ' && c != '-')
                    if (_charactersCounter.ContainsKey(c)) _charactersCounter[c]++;
                    else _charactersCounter[c] = 1;
            }

            int i = 0; _counter = _counter.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var word in _counter)
            {
                _popularitySB.Append(word.Key+"\n");
                if (++i == 10) break;
            }

            i = 0; _counter = _counter.OrderByDescending(x => x.Key.Length).ToDictionary(x => x.Key, x => x.Value);
            foreach (var word in _counter)
            {
                _lengthSB.Append(word.Key+"\n");
                if (++i == 10) break;
            }

            _charactersCounter.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            double sum = _charactersCounter.Sum(x => x.Value);
            foreach (var ch in _charactersCounter)
            {
                _charsSB.Append("\'"+ch.Key+ "' " + Math.Round(((double)ch.Value) / sum * 100, 2) + "%\n");
            }

            wordsNumber.Text = _counter.Sum(x => x.Value).ToString();
            uniqueWordsNumber.Text = _counter.Count().ToString();
            mostPopularWords.Text = _popularitySB.ToString();
            longestWords.Text = _lengthSB.ToString();
            characterPercentile.Text = _charsSB.ToString();
           
        }
    }
}
