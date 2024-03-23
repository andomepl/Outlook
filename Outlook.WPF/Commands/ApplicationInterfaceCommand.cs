using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Outlook.WPF.Commands
{
    public static class ApplicationInterfaceCommand
    {

        public static void CloseWindow(object sender,RoutedEventArgs e)
        {

            Application.Current.Shutdown();
        }

    }
}
