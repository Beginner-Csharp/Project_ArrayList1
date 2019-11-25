using System;
using System.Collections;
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

namespace ProjectTest_ArrayList1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }


        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (string data in arrayList)
            {
                MessageBox.Show(data);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Add(inputNum.Text);
            inputNum.Text = "";
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(inputNum.Text);
            inputNum.Text = "";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
