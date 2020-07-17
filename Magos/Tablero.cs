using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magos;
using Entidades;
using Casillero;
using System.Threading;
using System.Xml.Schema;

namespace Magos
{
    public class Tablero
    {
        public Thread enemyTurn;
        public Casilla[] casillas;
        public Mago jugador;
        public Mago enemigo;
        public int damagePlayer;
        public int casillasOcupadas;

        public Tablero (Queue<Monstruo> mazoJugador,Queue<Monstruo> mazoEnemigo,int playerdamage)
        {
            this.casillas = new Casilla[9];
            this.jugador = new Mago(mazoJugador,Equipo.Player);
            this.enemigo = new Mago(mazoEnemigo, Equipo.Enemy);
            this.damagePlayer = playerdamage;
            this.casillasOcupadas = 0;
            this.casillas[0] = new Casilla();
            this.casillas[1] = new Casilla();
            this.casillas[2] = new Casilla();
            this.casillas[3] = new Casilla();
            this.casillas[4] = new Casilla();
            this.casillas[5] = new Casilla();
            this.casillas[6] = new Casilla();
            this.casillas[7] = new Casilla();
            this.casillas[8] = new Casilla();
            this.enemyTurn = new Thread(TurnoEnemigo);
            this.enemyTurn.Start();
        }

        public bool WaysToWin (Tablero tablero)
        {
            #region Horizontales
            if (tablero.casillas[0].Ocupado && tablero.casillas[1].Ocupado && 
                tablero.casillas[2].Ocupado)
                if (tablero.casillas[0] == tablero.casillas[1] &&
                    tablero.casillas[0] == tablero.casillas[2] &&
                    tablero.casillas[1] == tablero.casillas[2])
                    return true;
            if (tablero.casillas[3].Ocupado && tablero.casillas[4].Ocupado && 
                tablero.casillas[5].Ocupado)
                if (tablero.casillas[3] == tablero.casillas[4] &&
                    tablero.casillas[3] == tablero.casillas[5] &&
                    tablero.casillas[4] == tablero.casillas[5])
                    return true;
            if (tablero.casillas[6].Ocupado && tablero.casillas[7].Ocupado &&
                tablero.casillas[8].Ocupado)
                if (tablero.casillas[6] == tablero.casillas[7] &&
                    tablero.casillas[6] == tablero.casillas[8] &&
                    tablero.casillas[7] == tablero.casillas[8])
                    return true;
            #endregion

            #region Verticales
            if (tablero.casillas[0].Ocupado && tablero.casillas[3].Ocupado &&
                tablero.casillas[6].Ocupado)
                if (tablero.casillas[0] == tablero.casillas[3] &&
                    tablero.casillas[ 0] == tablero.casillas[6] &&
                    tablero.casillas[3] == tablero.casillas[6])
                    return true;
            if (tablero.casillas[1].Ocupado && tablero.casillas[4].Ocupado &&
               tablero.casillas[7].Ocupado)
                if (tablero.casillas[ 1] == tablero.casillas[4] &&
                    tablero.casillas[1] == tablero.casillas[7] &&
                    tablero.casillas[4] == tablero.casillas[7])
                    return true;
            if (tablero.casillas[2].Ocupado && tablero.casillas[5].Ocupado &&
               tablero.casillas[8].Ocupado)
                if (tablero.casillas[2] == tablero.casillas[5] &&
                    tablero.casillas[2] == tablero.casillas[8] &&
                    tablero.casillas[5] == tablero.casillas[8])
                    return true;

            #endregion

            #region Diagonales

            if (tablero.casillas[0].Ocupado && tablero.casillas[4].Ocupado &&
                tablero.casillas[8].Ocupado)
                if (tablero.casillas[0] == tablero.casillas[4] &&
                    tablero.casillas[0] == tablero.casillas[8] &&
                    tablero.casillas[4] == tablero.casillas[8])
                    return true;

            if (tablero.casillas[2].Ocupado && tablero.casillas[4].Ocupado &&
                tablero.casillas[6].Ocupado)
                if (tablero.casillas[2] == tablero.casillas[4] &&
                    tablero.casillas[2] == tablero.casillas[6] &&
                    tablero.casillas[4] == tablero.casillas[6])
                    return true;

            #endregion
            
            return false;
        }

        public void TurnoEnemigo()
        {
            Random eligeCasilla = new Random();
            while (true)
            {
                int indice = eligeCasilla.Next(9);
                if (this.casillasOcupadas > 0 && this.casillas[indice].Ocupado&&this.casillas[indice].Team == Equipo.Player)
                {

                    while (this.casillas[indice].Monstruo.Vida > 0)
                    {
                        Thread.Sleep(1050);
                        if (this.casillas[indice].Monstruo.Vida > 0)
                            this.casillas[indice].Monstruo.Vida -= this.damagePlayer;
                        else
                            this.casillas[indice].Ocupado = false;
                    }

                }

            }

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
