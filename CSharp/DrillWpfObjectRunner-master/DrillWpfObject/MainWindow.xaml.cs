using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace DrillWpfObject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Result> results = new List<Result>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            int dist_in_m;
            bool int_isParsable = Int32.TryParse(Distance.Text, out dist_in_m);
            if (!int_isParsable)
                return;

            double time;
            bool double_isParsable = Double.TryParse(Time.Text, out time);
            if (!double_isParsable)
                return;

            results.Add(new Result(NameOfRunner.Text, dist_in_m, time));

            int lastIndex = results.Count - 1;
            TextBlock textBlock = new TextBlock();
            textBlock.Text = results[lastIndex].ToString();
            lopare.Children.Add(textBlock);
        }
    }
}
