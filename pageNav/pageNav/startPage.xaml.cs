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

namespace pageNav
{
    /// <summary>
    /// Interaction logic for startPage.xaml
    /// </summary>
    public partial class startPage : Page
    {
        public startPage()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, RoutedEventArgs e)
        {
            signIn s1 = new signIn();
            this.NavigationService.Navigate(s1);
        }

        private void signOutBtn_Click(object sender, RoutedEventArgs e)
        {
            signOut s2 = new signOut();
            this.NavigationService.Navigate(s2);
        }
    }
}
