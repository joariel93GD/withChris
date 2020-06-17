using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magos;
using Entidades;
using System.Xml.Schema;

namespace GameLogic
{
    class Tablero
    {
        public Casilla[,] casillas;
        public Mago jugador;
        public Mago enemigo;
        Queue<Monstruo> mazo;

        public Tablero ()
        {
            this.casillas = new Casilla[3,3];
            this.jugador = new Mago(this.mazo, Mago.Equipo.Player);
        }


    }
}
