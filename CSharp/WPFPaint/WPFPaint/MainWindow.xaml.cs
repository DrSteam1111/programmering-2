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

namespace WPFPaint
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

        private void inkCanvas1_Gesture(object sender, InkCanvasGestureEventArgs e)
        {
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.Strokes.Clear();
            MessageBox.Show("you have pressed the clear button");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Now the window will be closed thanks for using WPFPaint");
            Close();
        }
    }
}
