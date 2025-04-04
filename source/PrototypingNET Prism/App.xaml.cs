using Prism.Ioc;
using Prototyping_Prism.Views;
using System.Runtime.Versioning;
using System.Windows;

namespace Prototyping_Prism
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        [SupportedOSPlatform("windows7.0")]
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
