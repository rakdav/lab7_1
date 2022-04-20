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

namespace lab7_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> list;
        public MainWindow()
        {
            InitializeComponent();
            list=new List<string>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(InputText.Text.Length!=0)
            {
                list.Add(InputText.Text);
                Spisok.Items.Add(InputText.Text);
                InputText.Clear();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int max = 0;
            string res = "";
            foreach(string s in list)
            {
                if (s.Length > max)
                {
                    max = s.Length;
                    res = s;
                }
            }
            Result.Text=res;
        }
    }
}
