using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Casillero;

namespace Magos
{
    public class Mago
    {
        
        public Queue<Monstruo> mazo;
        public Equipo jugador;

        public Mago()
        {
            this.mazo = new Queue<Monstruo>();
            this.jugador = default;
        }
        public Mago (Queue<Monstruo> mazo, Equipo equipo)
        {
            this.mazo = mazo;
            if (equipo == Equipo.Enemy)
            {
                foreach (Monstruo item in mazo)
                {
                    item.Team = equipo;
                }
            }
            this.jugador = equipo;
        }

        public void CrearMonstruo(Casilla casilla, Monstruo monstruo)
        {
            casilla.Monstruo = monstruo;
            casilla.Ocupado = true;
            casilla.Team = monstruo.Team;
        }

        public Casilla ElegirCasilla(Tablero tablero)
        {
            Random random = new Random();

            bool flag = default;

            if (tablero.casillasOcupadas <= 9)
            {
                while (!flag)
                {
                    int index = random.Next(0, 9);
                    if (!tablero.casillas[index].Ocupado)
                        return tablero.casillas[index];
                }
            }
            return null;
        }
        public void JugarTurno(Tablero tablero,int i)
        {
            

            if(i%2==0)
            {
                CrearMonstruo(ElegirCasilla(tablero), tablero.jugador.mazo.Dequeue());
                LanzarSpecialSkills(tablero);
            }
            else
            {
                CrearMonstruo(ElegirCasilla(tablero), tablero.enemigo.mazo.Dequeue());
                LanzarSpecialSkills(tablero);
            }

        }

        public void LanzarSpecialSkills(Tablero tablero)
        {
            foreach(Casilla item in tablero.casillas)
            {
                if (item.Ocupado)
                    item.Monstruo.SpecialSkill();
            }
        }

        

    }
}
