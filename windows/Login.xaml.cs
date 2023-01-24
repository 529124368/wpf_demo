using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.service;
using WpfApp1.tool;

namespace WpfApp1.windows
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        private MainPage _subW;
        private UserService _userService;
        public Login(MainPage subW, UserService userService)
        {
            InitializeComponent();
            _subW = subW;
            _userService = userService;
        }

        //登录处理
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string account = Account.Text;
            string password = Password.Password;
            //登录权限验证
            Task.Run(async () => {
                if (await _userService.CheckAuth(account, password))
                {
                    await this.Dispatcher.BeginInvoke(() => {
                        this.Hide();
                        _subW.ShowDialog();
                    });
                }
                else
                {
                    MessageBox.Show("账号密码输入有误,请重新输入");
                }
            }); 
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            foreach (Window v in  Application.Current.Windows)
            {
                if(v != this)
                {
                    v.Close();
                }
            }
            this.Close();
        }
    }
}
