using BanAlwaysThere.Class;
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

namespace BanAlwaysThere
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ClassNavigate.frmmainnavigate = FrmMainPage;
            

            this.MaxHeight = SystemParameters.VirtualScreenHeight - 33; //Установка максимальной высоты окна у приложения при запуске
            this.MaxWidth = SystemParameters.VirtualScreenWidth;   //Установка максимальной ширины окна у приложения при запуске

        }

        /// <summary>
        /// Завершение работы приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShutDown_Click(object sender, RoutedEventArgs e)
        
        {

            Application.Current.Shutdown();

        }

        /// <summary>
        /// Восстановить/развернуть окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnResizeWindow_Click(object sender, RoutedEventArgs e)
        
        {

            switch (this.WindowState)

            {

                case WindowState.Maximized:
                    this.WindowState = WindowState.Normal;
                    break;

                case WindowState.Normal:
                    this.WindowState = WindowState.Maximized;
                    break;

            }

        }

        /// <summary>
        /// Свернуть окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMinWindow_Click(object sender, RoutedEventArgs e)
        
        {

            this.WindowState = WindowState.Minimized;

        }

        /// <summary>
        /// Изменение ToolTip у BtnResizeWin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinMain_SizeChanged(object sender, SizeChangedEventArgs e)
        
        {

            switch (this.WindowState)

            {

                case WindowState.Maximized:
                    this.BorderThickness = new Thickness(7.4, 7.4, 7.4, 0);
                    BtnResizeWindow.ToolTip = "Восстановить";
                    break;

                case WindowState.Normal:
                    this.BorderThickness = new Thickness(0);
                    BtnResizeWindow.ToolTip = "Развернуть";
                    break;

            }

        }

        private void StpProfile_MouseEnter(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            TxtProfile.TextDecorations = TextDecorations.Underline;
        }

        private void StpProfile_MouseLeave(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
            TxtProfile.TextDecorations = null;
        }

        private void StpProfile_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FrmMainPage.Navigate(new Pages.Profile());
        }

        private void TxtContacts_MouseEnter(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            TxtContacts.TextDecorations = TextDecorations.Underline;
        }

        private void TxtContacts_MouseLeave(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
            TxtContacts.TextDecorations = null;
        }

        private void TxtContacts_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FrmMainPage.Navigate(new Pages.PageContact());
        }
    }

}
