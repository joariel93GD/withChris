using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Equipo
        {
            Player,
            Enemy
        }
    public abstract class Monstruo
    {
        
        public enum Clase
        {
            Mago,
            Warrior,
            Assassin,
            Tank
        }
        protected int vida;
        protected int fuerza;
        protected Clase tipo;
        protected Equipo team;

        public Monstruo()
        {
            this.Vida = default;
            this.Fuerza = default;
            this.tipo = default;
            this.team = default;
        }
        public Monstruo (int vida, int fuerza, Clase tipo, Equipo team)
        {
            this.Vida = vida;
            this.Fuerza = fuerza;
            this.tipo = tipo;
            this.Team = team;

        }
        public Monstruo (Monstruo monstruo)
        {
            this.Vida = monstruo.Vida;
            this.Fuerza = monstruo.Fuerza;
            this.tipo = monstruo.Tipo;
            this.Team = monstruo.Team;
        }
        
        public int Vida
        {
            get
            {
                return this.vida;
            }
            set
            {
                this.vida = value;
            }
        }

        public int Fuerza
        {
            get
            {
                return this.fuerza;
            }
            set
            {
                this.fuerza = value;
            }
        }
        public Clase Tipo
        {
            get
            {
                return this.tipo;
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

        public abstract void SpecialSkill();


    }
}
