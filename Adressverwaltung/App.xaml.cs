
using System.Windows;

namespace Adressverwaltung
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
       

        public App()
        {
         
        }

        protected override void OnStartup(StartupEventArgs e)
        {

            MainWindow = new MainWindow();
            MainWindow.Show();
            base.OnStartup(e);
        }

   

    }
}
