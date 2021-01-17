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

namespace FdsFormWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ConsoleBox.Text = "Hello World!!\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n" +
                              "Hello\n";
            ConsoleBoxScroll.ScrollToBottom();
        }
    }
}
