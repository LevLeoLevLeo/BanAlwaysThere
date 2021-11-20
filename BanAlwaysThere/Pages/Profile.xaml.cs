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

namespace BanAlwaysThere.Pages
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void PgProfile_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (ActualWidth < 1600)

            {

                TxtProfile.Visibility = Visibility.Collapsed;

            }

            else TxtProfile.Visibility = Visibility.Visible;
            
        }
    }
}
