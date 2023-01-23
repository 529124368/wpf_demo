
using Autofac;
using System;
using System.Windows;
using WpfApp1.models;
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
            builder.RegisterType<MyData>().AsSelf().SingleInstance();
            builder.RegisterType<Route>().AsSelf().SingleInstance();
            builder.RegisterType<ClientHttp>().AsSelf().SingleInstance();
            builder.RegisterType<SubWindow1>().AsSelf().SingleInstance();

            // Add the MainWindowclass and later resolve
            builder.RegisterType<Login>().AsSelf();

            var container = builder.Build();

            using var scope = container.BeginLifetimeScope();
            var window = scope.Resolve<Login>();
            window.Show();
        }
    }
}
