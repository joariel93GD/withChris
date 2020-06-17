using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tank:Monstruo
    {
        public Tank() : base(2000, 25, Clase.Tank, Equipo.Player)
        {

        }
        public Tank(int vida, int fuerza, Equipo team) : base(vida, fuerza, Clase.Healer, team)
        {

        }

    }
}
