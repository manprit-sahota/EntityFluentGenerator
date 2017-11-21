using Autofac;
using Splendid.POCO.UI.ViewModels;
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

namespace Splendid.POCO.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IContainer container)
        {
            InitializeComponent();
            DataContext = container.Resolve<MainWindowViewModel>(new NamedParameter("entityEditor", entityCodeEditor), new NamedParameter("entityMapEditor", entityMapEditor));
        }
    }
}
