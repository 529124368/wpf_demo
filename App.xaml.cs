
using Autofac;
using System;
using System.Windows;
using WpfApp1.models;
using WpfApp1.service;
using WpfApp1.tool;
using WpfApp1.windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MyData>().SingleInstance();
            builder.RegisterType<Route>().SingleInstance();
            builder.RegisterType<ClientHttp>().SingleInstance();
            builder.RegisterType<MainPage>().SingleInstance();
            builder.RegisterType<UserService>().SingleInstance();

            // Add the MainWindowclass and later resolve
            builder.RegisterType<Login>().AsSelf();

            var container = builder.Build();

            using var scope = container.BeginLifetimeScope();
            var window = scope.Resolve<Login>();
            window.Show();
        }
    }
}
