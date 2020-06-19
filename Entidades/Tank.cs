using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tank:Monstruo
    {
        int turnos;
        public Tank() : base(2000, 25, Clase.Tank, Equipo.Player)
        {
            this.turnos = 0;
        }
        public Tank(int vida, int fuerza, Equipo team) : base(vida, fuerza, Clase.Tank, team)
        {

        }
        public override void SpecialSkill()
        {
            if (this.turnos == 2)
            { 
                this.Fuerza += 25;
                this.turnos = 0;
            }
            else
                this.turnos++;
        }
    }
}
