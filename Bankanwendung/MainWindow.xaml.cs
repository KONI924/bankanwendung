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

namespace Bankanwendung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Consultant cons1;
        private Consultant cons2;

        public MainWindow()
        {
            InitializeComponent();

            // manuelles Anlegen von Kundenberatern
            DateTime date1 = new DateTime(1976, 5, 1);
            cons1 = new Consultant("Mustermann", "Max", date1, "Am Ring 24, 12345 Wursthausen", 1);
            DateTime date2 = new DateTime(1986, 4, 8);
            cons2 = new Consultant("Musterfrau", "Martina", date2, "Lange Straße 4, 45678 Freiburg", 2);
        }
    }
}
