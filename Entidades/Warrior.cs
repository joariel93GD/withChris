using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Warrior:Monstruo
    {

        int turnos;
        public Warrior() : base(500, 125, Clase.Warrior, Equipo.Player)
        {
            this.turnos = 0;
        }
        public Warrior(int vida, int fuerza, Equipo team) : base(vida, fuerza, Clase.Warrior, team)
        {

        }

        public override void SpecialSkill()
        {
            if (this.Vida <= 450 && this.turnos == 2)
            {
                this.Vida += 50;
                this.turnos = 0;
            }
            else if(this.turnos==2&&this.Vida>450)
            {
                this.Vida = 500;
                this.turnos = 0;
            }
            else
            {
                this.turnos++;
            }
        }

    }
}
