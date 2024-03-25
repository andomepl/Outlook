using Outlook.WPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Outlook.WPF.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.StateChanged += MainWindow_StateChanged;
        }

        private void MainWindow_StateChanged(object sender, System.EventArgs e)
        {

            if (this.WindowState == WindowState.Maximized)
            {
                var vm = this.DataContext as MainWindowViewModel;

                if (vm != null)
                {
                    vm.ResizeBorderThickness = 0;
                }
            }
        }

        private void CloseCommand(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void CanCloseCommand(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void MinimizeCommand(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {

            if(this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }

            else if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }

        }

        private void CanCloseMinimizeCommand(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
