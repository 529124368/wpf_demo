using System;
using System.Collections.Generic;
using System.Windows;
using WpfApp1.models;

namespace WpfApp1.windows
{
    /// <summary>
    /// SubWindow2.xaml 的交互逻辑
    /// </summary>
    public partial class SubWindow2 : Window
    {
        private MyData _my;
        public SubWindow2(MyData my)
        {
            InitializeComponent();
            _my = my;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _my.Course = new List<string> { "数学", "语文", "体育", "英语" };
            selectBox.DataContext = _my;

            List<Menus> box = new List<Menus>();
            Menus a1 = new Menus("菜单1", null);
            Menus a2 = new Menus("菜单2", null);
            Menus a4 = new Menus("菜单3", null);
            Menus a1_1 = new Menus("菜单1_1", a1);
            Menus a1_2 = new Menus("打开文件", a1);
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

            List<GameModel> g = new List<GameModel>();
            g.Add(new GameModel("暗黑破坏神1", @"D:\BaiduNetdiskDownload\switch_game_maliao\1","lsz1", @"D:\BaiduNetdiskDownload\switch_game_maliao\1"));
            g.Add(new GameModel("暗黑破坏神2", @"D:\BaiduNetdiskDownload\switch_game_maliao\2", "lsz2", @"D:\BaiduNetdiskDownload\switch_game_maliao\2"));
            g.Add(new GameModel("暗黑破坏神3", @"D:\BaiduNetdiskDownload\switch_game_maliao\3", "lsz3", @"D:\BaiduNetdiskDownload\switch_game_maliao\3"));
            g.Add(new GameModel("暗黑破坏神4", @"D:\BaiduNetdiskDownload\switch_game_maliao\4", "lsz1", @"D:\BaiduNetdiskDownload\switch_game_maliao\4"));
            g.Add(new GameModel("暗黑破坏神5", @"D:\BaiduNetdiskDownload\switch_game_maliao\5", "lsz2", @"D:\BaiduNetdiskDownload\switch_game_maliao\5"));
            g.Add(new GameModel("暗黑破坏神6", @"D:\BaiduNetdiskDownload\switch_game_maliao\6", "lsz3", @"D:\BaiduNetdiskDownload\switch_game_maliao\6"));
            gameList.DataContext = g;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"账号:{account.Text},密码:{password.Password}");
        }
    }

    
}
