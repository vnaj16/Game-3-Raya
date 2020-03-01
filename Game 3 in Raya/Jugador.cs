using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_3_in_Raya
{
    public class Jugador
    {

        public Jugador()
        {
            Victorias = 0;
            Derrotas = 0;
            Empates = 0;
            Ganador = false;
            Nombre = "none";
        }

        public void ReiniciarContadores(int i =0)
        {
            Victorias = 0;
            Derrotas = 0;
            Empates = 0;
            Ganador = false;
            if(i!=2)//Si mando parametro 0 o mejor dicho no mando parametro quiere decir que no cambio. Si mando 1 quiere decir que si reinicio los nombres
            Nombre = "";
        }

        public String Nombre { get; set; }

        public int Victorias { get; set; }
        public int Derrotas { get; set; }
        public int Empates { get; set; }
        public bool Ganador { get; set; }
    }
}
