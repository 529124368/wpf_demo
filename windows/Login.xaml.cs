using System;
using System.Security.Principal;
using System.Windows;

using System.Windows.Navigation;


namespace WpfApp1.windows
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        private SubWindow1 _subW;
        public Login(SubWindow1 subW)
        {
            InitializeComponent();
            _subW = subW;
        }


        //登录处理
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO 登录check
            if (Account.Text.Equals("lsz") && Password.Password.Equals("123"))
            {
                _subW.Show();
                this.Close();
            }else
            {
                MessageBox.Show("账号密码输入有误,请重新输入");
            }



        }
    }
}
