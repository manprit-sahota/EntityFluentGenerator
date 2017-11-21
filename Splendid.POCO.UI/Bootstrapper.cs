using Prism.Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using Prism.Mvvm;
using Splendid.POCO.UI.ViewModels;

namespace Splendid.POCO.UI
{
    public class Bootstrapper : AutofacBootstrapper
    {
        protected override void ConfigureContainerBuilder(ContainerBuilder builder)
        {
            base.ConfigureContainerBuilder(builder);

            builder.RegisterType<MainWindowViewModel>()
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();
        }

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}
