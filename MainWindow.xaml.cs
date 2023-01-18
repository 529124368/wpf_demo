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
using WpfApp1.models;

namespace WpfApp1
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


        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UIElementCollection kechengs = kecheng.Children;
            StringBuilder strs = new StringBuilder();
            foreach(var v in kechengs)
            {
                if((bool)(v as RadioButton).IsChecked)
                {
                    _ = strs.Append((v as RadioButton).DataContext);
                    strs.Append(@"\r\n");
                }
                
            }
            MessageBox.Show(strs.ToString());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mylabel.DataContext = MyData.GetInstance();
        }
    }
}
