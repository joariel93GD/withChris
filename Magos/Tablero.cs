using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magos;
using Entidades;
using Casillero;
using System.Xml.Schema;

namespace Magos
{
    public class Tablero
    {
        public Casilla[,] casillas;
        public Mago jugador;
        public Mago enemigo;
        public int casillasOcupadas;

        public Tablero (Queue<Monstruo> mazoJugador,Queue<Monstruo> mazoEnemigo)
        {
            this.casillas = new Casilla[3,3];
            this.jugador = new Mago(mazoJugador,Equipo.Player);
            this.enemigo = new Mago(mazoEnemigo, Equipo.Enemy);
            this.casillasOcupadas = 0;
            this.casillas[0, 0] = new Casilla();
            this.casillas[0, 1] = new Casilla();
            this.casillas[0, 2] = new Casilla();
            this.casillas[1, 0] = new Casilla();
            this.casillas[1, 1] = new Casilla();
            this.casillas[1, 2] = new Casilla();
            this.casillas[2, 0] = new Casilla();
            this.casillas[2, 1] = new Casilla();
            this.casillas[2, 2] = new Casilla();
        }

        public bool WaysToWin (Tablero tablero)
        {
            #region Horizontales
            if (tablero.casillas[0, 0].Ocupado && tablero.casillas[0, 1].Ocupado && 
                tablero.casillas[0, 2].Ocupado)
                if (tablero.casillas[0, 0] == tablero.casillas[0, 1] &&
                    tablero.casillas[0, 0] == tablero.casillas[0, 2] &&
                    tablero.casillas[0, 1] == tablero.casillas[0, 2])
                    return true;
            if (tablero.casillas[1, 0].Ocupado && tablero.casillas[1, 1].Ocupado && 
                tablero.casillas[1, 2].Ocupado)
                if (tablero.casillas[1, 0] == tablero.casillas[1, 1] &&
                    tablero.casillas[1, 0] == tablero.casillas[1, 2] &&
                    tablero.casillas[1, 1] == tablero.casillas[1, 2])
                    return true;
            if (tablero.casillas[2, 0].Ocupado && tablero.casillas[1, 1].Ocupado &&
                tablero.casillas[2, 2].Ocupado)
                if (tablero.casillas[2, 0] == tablero.casillas[2, 1] &&
                    tablero.casillas[2, 0] == tablero.casillas[2, 2] &&
                    tablero.casillas[2, 1] == tablero.casillas[2, 2])
                    return true;
            #endregion

            #region Verticales
            if (tablero.casillas[0, 0].Ocupado && tablero.casillas[1, 0].Ocupado &&
                tablero.casillas[2,0].Ocupado)
                if (tablero.casillas[0, 0] == tablero.casillas[1,0] &&
                    tablero.casillas[0, 0] == tablero.casillas[2,0] &&
                    tablero.casillas[1,0] == tablero.casillas[2,0])
                    return true;
            if (tablero.casillas[0, 1].Ocupado && tablero.casillas[1, 1].Ocupado &&
               tablero.casillas[2, 1].Ocupado)
                if (tablero.casillas[0, 1] == tablero.casillas[1, 1] &&
                    tablero.casillas[0, 1] == tablero.casillas[2, 1] &&
                    tablero.casillas[1, 1] == tablero.casillas[2, 1])
                    return true;
            if (tablero.casillas[0, 2].Ocupado && tablero.casillas[1, 2].Ocupado &&
               tablero.casillas[2, 2].Ocupado)
                if (tablero.casillas[0, 2] == tablero.casillas[1, 2] &&
                    tablero.casillas[0, 2] == tablero.casillas[2, 2] &&
                    tablero.casillas[1, 2] == tablero.casillas[2, 2])
                    return true;

            #endregion

            #region Diagonales

            if (tablero.casillas[0, 0].Ocupado && tablero.casillas[1, 1].Ocupado &&
                tablero.casillas[2, 2].Ocupado)
                if (tablero.casillas[0, 0] == tablero.casillas[1, 1] &&
                    tablero.casillas[0, 0] == tablero.casillas[2, 2] &&
                    tablero.casillas[1, 1] == tablero.casillas[2, 2])
                    return true;

            if (tablero.casillas[0, 2].Ocupado && tablero.casillas[1, 1].Ocupado &&
                tablero.casillas[2, 0].Ocupado)
                if (tablero.casillas[0, 2] == tablero.casillas[1, 1] &&
                    tablero.casillas[0, 2] == tablero.casillas[2, 0] &&
                    tablero.casillas[1, 1] == tablero.casillas[2, 0])
                    return true;

            #endregion
            
            return false;
        }
        void Jugar()
        {
            if(!WaysToWin(this))
            {
                this.jugador.JugarTurno(this, 1);
                this.enemigo.JugarTurno(this, 2);
            }

        }
    }
}
