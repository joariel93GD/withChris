using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mago:Monstruo
    {

        public Mago ():base(1000,25,Clase.Mago,Equipo.Player)
        {

        }
        public Mago(int vida, int fuerza,Equipo team) : base(vida, fuerza, Clase.Mago,team)
        {

        }

        public override void SpecialSkill()
        {
            this.Fuerza += 25;
        }
    }
}
