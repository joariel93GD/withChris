using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Healer:Monstruo
    {

        public Healer ():base(1000,25,Clase.Healer,Equipo.Player)
        {

        }
        public Healer(int vida, int fuerza,Equipo team) : base(vida, fuerza, Clase.Healer,team)
        {

        }


    }
}
