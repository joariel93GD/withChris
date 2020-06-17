using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Assassin:Monstruo
    {
        public Assassin() : base(250, 200, Clase.Assassin, Equipo.Player)
        {

        }

        public Assassin(int vida, int fuerza,Equipo team) : base(vida, fuerza, Clase.Healer,team)
        {

        }
    }
}
