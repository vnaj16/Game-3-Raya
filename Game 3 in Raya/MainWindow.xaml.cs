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
using System.Configuration;

namespace Game_3_in_Raya
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            try
            {
                InitializeComponent();

                //Inicializar componentes del juego
                Iniciar_Casillas_Pressed();
                Iniciar_Casillas_Usuarios();

                Players = new List<Jugador>();

                Players.Add(Jugador1);
                Players.Add(Jugador2);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //CREAR UNA CLASE APARTE PARA NO TENER PROBLEMAS CON EL STACKOVERFLOW Y EN VEZ DE PONER A ESTA VENTANA EN EL DATA CONTEXT
        //PORQUE AL PARECER GENERA RECURSIVIDAD, PONER LOS LAS VARIABLES RESPECTIVAS
        #region ATRIBUTOS DEL JUEGO
        private int Turno = 1, Casillas_Activas = 0;
        private bool[,] Casillas_Pressed = new bool[3, 3];//Determina si esa casilla se puede presionar o no
        private int[,] Casillas_Usuario = new int[3, 3];//Para determinar en que lugar ha puesto tal usuario
        public Jugador Jugador1 = new Jugador(), Jugador2 = new Jugador();
        public List<Jugador> Players;
        #endregion

        #region ACCIONES DEL JUEGO
        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            if (Casillas_Pressed[0, 0])
            {//Si esa casilla se puede presionar
                if (Turno == 1)
                {//Si es turno del usuario 1
                    Turno = 2;
                    Casillas_Usuario[0, 0] = 1;
                    Dibujar_X((Button)sender);//getSource retorna el objeto donde ha empezado el evento
                }
                else
                {//Si es turno del usuario 2
                    Dibujar_O((Button)sender); ;
                    Turno = 1;
                    Casillas_Usuario[0, 0] = 2;
                }

                Casillas_Pressed[0, 0] = false;
                Casillas_Activas++;
                Comprobar_Ganador();
            }

        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            if (Casillas_Pressed[0, 1])
            {
                if (Turno == 1)
                {
                    Turno = 2;
                    Casillas_Usuario[0, 1] = 1;
                    Dibujar_X((Button)sender);
                }
                else
                {
                    Dibujar_O((Button)sender);
                    Turno = 1;
                    Casillas_Usuario[0, 1] = 2;
                }

                Casillas_Pressed[0, 1] = false;
                Casillas_Activas++;
                Comprobar_Ganador();
            }
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            // TODO add your handling code here:
            if (Casillas_Pressed[0, 2])
            {
                if (Turno == 1)
                {
                    Turno = 2;
                    Casillas_Usuario[0, 2] = 1;
                    Dibujar_X((Button)sender);
                }
                else
                {
                    Dibujar_O((Button)sender);
                    Turno = 1;
                    Casillas_Usuario[0, 2] = 2;
                }

                Casillas_Pressed[0, 2] = false;
                Casillas_Activas++;
                Comprobar_Ganador();
            }
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            // TODO add your handling code here:
            if (Casillas_Pressed[1, 0])
            {
                if (Turno == 1)
                {
                    Turno = 2;
                    Casillas_Usuario[1, 0] = 1;
                    Dibujar_X((Button)sender);
                }
                else
                {
                    Dibujar_O((Button)sender);
                    Turno = 1;
                    Casillas_Usuario[1, 0] = 2;
                }

                Casillas_Pressed[1, 0] = false;
                Casillas_Activas++;
                Comprobar_Ganador();
            }
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            // TODO add your handling code here:
            if (Casillas_Pressed[1, 1])
            {
                if (Turno == 1)
                {
                    Turno = 2;
                    Casillas_Usuario[1, 1] = 1;
                    Dibujar_X((Button)sender);
                }
                else
                {
                    Dibujar_O((Button)sender);
                    Turno = 1;
                    Casillas_Usuario[1, 1] = 2;
                }

                Casillas_Pressed[1, 1] = false;
                Casillas_Activas++;
                Comprobar_Ganador();
            }
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            // TODO add your handling code here:
            if (Casillas_Pressed[1, 2])
            {
                if (Turno == 1)
                {
                    Turno = 2;
                    Casillas_Usuario[1, 2] = 1;
                    Dibujar_X((Button)sender);
                }
                else
                {
                    Dibujar_O((Button)sender);
                    Turno = 1;
                    Casillas_Usuario[1, 2] = 2;
                }

                Casillas_Pressed[1, 2] = false;
                Casillas_Activas++;
                Comprobar_Ganador();
            }
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            // TODO add your handling code here:
            if (Casillas_Pressed[2, 0])
            {
                if (Turno == 1)
                {
                    Turno = 2;
                    Casillas_Usuario[2, 0] = 1;
                    Dibujar_X((Button)sender);
                }
                else
                {
                    Dibujar_O((Button)sender);
                    Turno = 1;
                    Casillas_Usuario[2, 0] = 2;
                }

                Casillas_Pressed[2, 0] = false;
                Casillas_Activas++;
                Comprobar_Ganador();
            }
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            // TODO add your handling code here:
            if (Casillas_Pressed[2, 1])
            {
                if (Turno == 1)
                {
                    Turno = 2;
                    Casillas_Usuario[2, 1] = 1;
                    Dibujar_X((Button)sender);
                }
                else
                {
                    Dibujar_O((Button)sender);
                    Turno = 1;
                    Casillas_Usuario[2, 1] = 2;
                }

                Casillas_Pressed[2, 1] = false;
                Casillas_Activas++;
                Comprobar_Ganador();
            }
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            // TODO add your handling code here:
            if (Casillas_Pressed[2, 2])
            {
                if (Turno == 1)
                {
                    Turno = 2;
                    Casillas_Usuario[2, 2] = 1;
                    Dibujar_X((Button)sender);
                }
                else
                {
                    Dibujar_O((Button)sender); ;
                    Turno = 1;
                    Casillas_Usuario[2, 2] = 2;
                }

                Casillas_Pressed[2, 2] = false;
                Casillas_Activas++;
                Comprobar_Ganador();
            }
        }


        #endregion

        #region LOGICA DEL JUEGO
        private void Dibujar_X(Button btn)
        {
            Image Imagen = new Image();
            Imagen.Stretch = Stretch.None;
            Uri resourceUri = new Uri("..\\Imagenes\\cross.png", UriKind.Relative);
            Imagen.Source = new BitmapImage(resourceUri);

            btn.Content = Imagen;
        }

        private void Dibujar_O(Button btn)
        {
            Image Imagen = new Image();
            Imagen.Stretch = Stretch.None;
            Uri resourceUri = new Uri("..\\Imagenes\\dot.png", UriKind.Relative);
            Imagen.Source = new BitmapImage(resourceUri);

            btn.Content = Imagen;
        }

        private void Iniciar_Casillas_Pressed()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Casillas_Pressed[i, j] = true;
                }
            }
        }

        private void Button_Guardar_Grid_Home_Click(object sender, RoutedEventArgs e)
        {
            Button_Guardar_Grid_Home.IsEnabled = false;

            Label_Jugador1_Grid_Home.Visibility = Visibility.Visible;
            Label_Jugador2_Grid_Home.Visibility = Visibility.Visible;

            Button_ComenzarJuego_Grid_Home.Visibility = Visibility.Visible;

            Jugador1.Nombre = TextBox_Jugador1_Grid_Home.Text;
            Jugador2.Nombre = TextBox_Jugador2_Grid_Home.Text;

            Label_Jugador1_Grid_Home.Text = $"{Jugador1.Nombre} jugará primero con la ficha X";
            Label_Jugador2_Grid_Home.Text = $"{Jugador2.Nombre} usará la ficha O";
        }

        #region CODIGO DE LOS MENU ITEMS
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Inicio_Click(object sender, RoutedEventArgs e)
        {
            Grid_Juego.Visibility = Visibility.Hidden;

            System.Threading.Thread.Sleep(100);

            Grid_Home.Visibility = Visibility.Visible;

            //REINICIO DE COMPONENTES DE GRID_HOME
            Button_Guardar_Grid_Home.IsEnabled = true;

            Label_Jugador1_Grid_Home.Visibility = Visibility.Hidden;
            Label_Jugador2_Grid_Home.Visibility = Visibility.Hidden;

            Button_ComenzarJuego_Grid_Home.Visibility = Visibility.Hidden;

            TextBox_Jugador1_Grid_Home.Clear();
            TextBox_Jugador2_Grid_Home.Clear();

            Jugador1.ReiniciarContadores();
            Jugador2.ReiniciarContadores();
        }

        private void MenuItem_ComenzarNuevo_Click(object sender, RoutedEventArgs e)
        {
            Jugador1.ReiniciarContadores(2);
            Jugador2.ReiniciarContadores(2);
            Reiniciar_Juego();
        }

        private void MenuItem_VerResultados_Click(object sender, RoutedEventArgs e)
        {
            Window_Puntaje Ventana_Puntaje = new Window_Puntaje(Players);
            Ventana_Puntaje.Owner = this;
            Ventana_Puntaje.ShowDialog();
        }
        #endregion


        private void Reiniciar_Juego()
        {
            Iniciar_Casillas_Pressed();
            Iniciar_Casillas_Usuarios();

            Button_1.Content = null;
            Button_2.Content = null;
            Button_3.Content = null;
            Button_4.Content = null;
            Button_5.Content = null;
            Button_6.Content = null;
            Button_7.Content = null;
            Button_8.Content = null;
            Button_9.Content = null;

            Casillas_Activas = 0;
        }

        private void Button_ComenzarJuego_Grid_Home_Click(object sender, RoutedEventArgs e)
        {
            Grid_Home.Visibility = Visibility.Collapsed;

            System.Threading.Thread.Sleep(100);

            Grid_Juego.Visibility = Visibility.Visible;
        }

        private void Iniciar_Casillas_Usuarios()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Casillas_Usuario[i, j] = 0;
                }
            }
        }

        private void Comprobar_Ganador()
        {
            if (Casillas_Activas >= 5)
            {

                Jugador1.Ganador = Comprobar(1);
                Jugador2.Ganador = Comprobar(2);


                if (Jugador1.Ganador)
                {
                    Jugador1.Victorias++;
                    Jugador2.Derrotas++;
                    MessageBox.Show(this,$"El ganador es {Jugador1.Nombre}");
                    Cambio_Turnos();
                    Reiniciar_Juego();
                }
                else if (Jugador2.Ganador)
                {
                    Jugador2.Victorias++;
                    Jugador1.Derrotas++;
                    MessageBox.Show(this,$"El ganador es {Jugador2.Nombre}");
                    Cambio_Turnos();
                    Reiniciar_Juego();
                }
                else if (Casillas_Activas == 9)
                {//Si ya se presiono todas las casillas y no hay ganador
                    Jugador1.Empates++;
                    Jugador2.Empates++;
                    MessageBox.Show(this,$"Hay un empate");
                    Cambio_Turnos();
                    Reiniciar_Juego();
                }
            }
        }

        private void MenuItem_CambiarJugadores_Click(object sender, RoutedEventArgs e)
        {
            Grid_Home.Visibility = Visibility.Visible;
            Jugador1.ReiniciarContadores();
            Jugador2.ReiniciarContadores();

            Grid_Juego.Visibility = Visibility.Collapsed;
        }

        private bool Comprobar(int user)
        {
            bool Ganador = false;

            if (Casillas_Usuario[0, 0] == user && Casillas_Usuario[0, 1] == user && Casillas_Usuario[0, 2] == user)
            {//Compruebo la 1ra Fila
                Ganador = true;
            }
            else if (Casillas_Usuario[1, 0] == user && Casillas_Usuario[1, 1] == user && Casillas_Usuario[1, 2] == user)
            {//Compruebo la 2da Fila
                Ganador = true;
            }
            else if (Casillas_Usuario[2, 0] == user && Casillas_Usuario[2, 1] == user && Casillas_Usuario[2, 2] == user)
            {//Compruebo la 3ra Fila
                Ganador = true;
            }
            else if (Casillas_Usuario[0, 0] == user && Casillas_Usuario[1, 0] == user && Casillas_Usuario[2, 0] == user)
            {//Compruebo la 1ra columna
                Ganador = true;
            }
            else if (Casillas_Usuario[0, 1] == user && Casillas_Usuario[1, 1] == user && Casillas_Usuario[2, 1] == user)
            {//Compruebo la 2da columna
                Ganador = true;
            }
            else if (Casillas_Usuario[0, 2] == user && Casillas_Usuario[1, 2] == user && Casillas_Usuario[2, 2] == user)
            {//Compruebo la 3ra columna
                Ganador = true;
            }
            else if (Casillas_Usuario[0, 0] == user && Casillas_Usuario[1, 1] == user && Casillas_Usuario[2, 2] == user)
            {//Compruebo la 3ra columna
                Ganador = true;
            }
            else if (Casillas_Usuario[0, 2] == user && Casillas_Usuario[1, 1] == user && Casillas_Usuario[2, 0] == user)
            {//Compruebo la 3ra columna
                Ganador = true;
            }


            return Ganador;
        }

        private void Cambio_Turnos()
        {//Muestra dos botones donde se escoge quien empieza de nuevo
            Window_CambioTurnos Ventana_CambioTurnos = new Window_CambioTurnos(Jugador1.Nombre, Jugador2.Nombre);
            Ventana_CambioTurnos.Owner = this;
            Ventana_CambioTurnos.ShowDialog();
            Turno = Ventana_CambioTurnos.Turno;

            //Dialog_TurnoSig Ventana_CambioTurno = new Dialog_TurnoSig(this, true, Jugador1.getNombre(), Jugador2.getNombre());//Poner en false hace que se le pase mal el valor a Turno
            //Con true hago de que primero cierre la ventana para pasar a la siguiente linea (Turno=....)

            //Ventana_CambioTurno.setVisible(true);

            //Turno = Ventana_CambioTurno.GetTurno();
        }
        #endregion
    }
}
