using Jamesnet.Wpf.Controls;
using System.Windows;
using WpfExplorer.Support.UI.Units;

namespace WpfExplorer
{
    internal class App : JamesApplication
    {
        // * 시작 윈도우 설정하기.
        protected override Window CreateShell()
        {
            return new DarkWindow();
        }
    }
}
