using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Presentation
{
    /// <summary>
    /// Glavni prozor aplikacije (MainWindow) za WPF projekat.
    /// Ova klasa sadrži logiku za interakciju sa korisničkim interfejsom definisanim u MainWindow.xaml.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Konstruktor glavnog prozora.
        /// Poziva InitializeComponent() koji učitava XAML i inicijalizuje UI komponente.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}