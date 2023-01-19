
using Autofac;
using System;
using System.Windows;
using WpfApp1.models;
using WpfApp1.windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    
    public partial class App : Application
    {
        public static IContainer container { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MyData>().SingleInstance();

            // Add the MainWindowclass and later resolve
            builder.RegisterType<SubWindow2>().AsSelf();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var window = scope.Resolve<SubWindow2>();
                window.Show();
            }
        }
    }
}
