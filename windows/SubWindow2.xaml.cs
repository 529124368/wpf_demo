using System;
using System.Collections.Generic;

using System.Windows;
using System.Windows.Controls;
using WpfApp1.models;

namespace WpfApp1.windows
{
    /// <summary>
    /// SubWindow2.xaml 的交互逻辑
    /// </summary>
    public partial class SubWindow2 : Window
    {
        public SubWindow2()
        {
            InitializeComponent();      
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MyData data1 = MyData.GetInstance();
            data1.Course = new List<string> { "数学", "语文", "体育", "英语" };
            selectBox.DataContext = data1;

            List<Menus> box = new List<Menus>();
            Menus a1 = new Menus("菜单1", null);
            Menus a2 = new Menus("菜单2", null);
            Menus a4 = new Menus("菜单3", null);
            Menus a1_1 = new Menus("菜单1_1", a1);
            Menus a1_2 = new Menus("菜单1_2", a1);
            Menus a2_1 = new Menus("菜单2_1", a2);
            Menus a1_1_1 = new Menus("菜单1_1_1", a1_1);
            Menus a1_1_2 = new Menus("菜单1_1_2", a1_1);
            Menus a1_1_3 = new Menus("菜单1_1_3", a1_1);
            Menus a1_1_4 = new Menus("菜单1_1_4", a1_1);
            Menus a2_1_1 = new Menus("菜单2_1_1", a2_1);
            Menus a1_1_1_1 = new Menus("菜单1_1_1_1", a1_1_1);
            Menus a1_1_2_1 = new Menus("菜单1_1_2_1", a1_1_1);
            box.Add(a1);
            box.Add(a2);
            box.Add(a4);

            menus.DataContext = box;
        }
    }

    
}
