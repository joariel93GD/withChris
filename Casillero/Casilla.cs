using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Casillero
{
    public class Casilla
    {
        protected Monstruo monstruo;
        protected Equipo team;
        protected bool ocupado;

        public Casilla()
        {
            this.Monstruo = default;
            this.team = default;
            this.Ocupado = false;
        }
        public Monstruo Monstruo
        {
            get
            {
                return this.monstruo;
            }
            set
            {
                this.monstruo = value;
            }
        }

        public bool Ocupado
        {
            get
            {
                return this.ocupado;
            }
            set
            {
                this.ocupado = value;
            }
        }
        public Equipo Team
        {
            get
            {
                return this.team;
            }
            set
            {
                this.team = value;
            }
        }
        public static bool operator ==(Casilla c1,Casilla c2 )
        {
            if (c1.Team == c2.Team)
                return true;

            return false;
        }
        public static bool operator !=(Casilla c1, Casilla c2)
        {
            return !(c1 == c2);
        }

    }
}
