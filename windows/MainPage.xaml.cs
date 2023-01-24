using System;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.models;
using WpfApp1.tool;

namespace WpfApp1.windows
{
    /// <summary>
    /// SubWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class MainPage : Window
    {
        private Route _route;
        private ClientHttp _clientHttp;


        public MainPage(Route route, ClientHttp clientHttp)
        {
            InitializeComponent();
            _route = route;
            _clientHttp = clientHttp;
        }



        private void ListBox_SelectionChanged1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            _route.Path = "center";
            subContent.Navigate(new Uri(_route.GetPageUri(), UriKind.Relative));
        }

        private void ListBox_SelectionChanged2(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            _route.Path = "store";
            subContent.Navigate(new Uri(_route.GetPageUri(), UriKind.Relative));
        }

        private void ListBox_SelectionChanged3(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            _route.Path = "setting";
            subContent.Navigate(new Uri(_route.GetPageUri(), UriKind.Relative));
        }

        private void ListBox_SelectionChanged4(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            _route.Path = "users";
            subContent.Navigate(new Uri(_route.GetPageUri(), UriKind.Relative));
        }

        private void ListBox_SelectionChanged5(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            _route.Path = "download";
            subContent.Navigate(new Uri(_route.GetPageUri(), UriKind.Relative));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            subContent.DataContext = "/windows/Page1.xaml";
        }

        private void Main_selected(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            _route.Path = "main";
            subContent.Navigate(new Uri(_route.GetPageUri(), UriKind.Relative));
            Task.Run(async () =>
            {
                //http Request
                string token = "bearer " + "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vMTI3LjAuMC4xL2FwaS91c2VycyIsImlhdCI6MTY3NDM2MDEzOCwiZXhwIjoxNjc0NDM5ODEzLCJuYmYiOjE2NzQ0MzYyMTMsImp0aSI6IlZEMkVZVHFmUDdQTWFZTWUiLCJzdWIiOiIyIiwicHJ2IjoiMjNiZDVjODk0OWY2MDBhZGIzOWU3MDFjNDAwODcyZGI3YTU5NzZmNyJ9.pFSEcpv35_-c0bYLR1puRU6YDr7P6HpwkxVCAXDvTW8";
                var result = await _clientHttp.SetRequestHeader("Authorization", token).GetResult(Request.get, "users");
                MessageBox.Show(result);
            });
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            foreach (Window v in Application.Current.Windows)
            {
                if (v != this)
                {
                    v.Close();
                }
            }
            this.Close();
        }
    }
}
