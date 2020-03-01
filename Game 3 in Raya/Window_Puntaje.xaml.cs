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
using System.Windows.Shapes;

namespace Game_3_in_Raya
{
    /// <summary>
    /// Interaction logic for Window_Puntaje.xaml
    /// </summary>
    public partial class Window_Puntaje : Window
    {
        public Window_Puntaje(List<Jugador> Players)
        {
            InitializeComponent();
            DataGrid_Puntaje.ItemsSource = Players;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
