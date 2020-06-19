using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Assassin:Monstruo
    {
        public int turnos;
        public Assassin() : base(250, 200, Clase.Assassin, Equipo.Player)
        {
            this.turnos = 0;
        }

        public Assassin(int vida, int fuerza,Equipo team) : base(vida, fuerza, Clase.Assassin,team)
        {

        }

        public override void SpecialSkill()
        {
            if(turnos==2)
            {
                this.Fuerza = 400;
                this.turnos = 0;
            }    
            else
            {
                this.Fuerza = 200;
                this.turnos++;
            }
        }
    }
}
