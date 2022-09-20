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

namespace Oef4_Kassa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //  1. controleren of het 10 cijfers zijn
        //  2. nummer zonder laatste 2 getallen delen door 97 (integer)
        //  3. 97 aftrekken door quotient
        //  4. 
        private void BtnControleCijfer_Click(object sender, RoutedEventArgs e)
        {

        }

        //  TODO

        

        //  Wisknop
        //  TxtVeld.Clear();
    }
}
