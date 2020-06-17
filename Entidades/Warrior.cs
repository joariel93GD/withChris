using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Warrior:Monstruo
    {
        public Warrior() : base(500, 125, Clase.Warrior, Equipo.Player)
        {

        }
        public Warrior(int vida, int fuerza, Equipo team) : base(vida, fuerza, Clase.Healer, team)
        {

        }

    }
}
