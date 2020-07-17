using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;
using Magos;
using Casillero;

namespace TestGame
{

    public partial class GameForm : Form
    {
       
       
        Tablero juego;
        int cantWarriors,cantAssassins,cantHealers,cantTanks;

        int i=0;
        

        public GameForm(int cantWarrior,int cantAssassin,int cantHealer,int cantTank)
        {
            this.cantWarriors = cantWarrior;
            this.cantAssassins = cantAssassin;
            this.cantHealers = cantHealer;
            this.cantTanks = cantTank;

            InitializeComponent();
            
        }
        public Tablero ArrancarJuego(Tablero juego,int cantWarrior,int cantHealer,int cantAssasin,int cantTank)
        {
            Queue<Monstruo> mazo1 = new Queue<Monstruo>();
            Queue<Monstruo> mazo2 = new Queue<Monstruo>();
            List<Monstruo> mazoJugador = new List<Monstruo>();
            int i;
            
            #region Creando mazo jugador
            if(cantWarrior>0)
            { 
                Warrior warrior = new Warrior();
                for( i=0;i<cantWarrior;i++)
                {
                    mazoJugador.Add(warrior);
                }
            }
            if (cantAssasin > 0)
            {
                Assassin assassin = new Assassin();
                for (i = 0; i < cantWarrior; i++)
                {
                    mazoJugador.Add(assassin);
                }
            }
            if (cantHealer > 0)
            {
                Entidades.Mago mago = new Entidades.Mago();
                for (i = 0; i < cantWarrior; i++)
                {
                    mazoJugador.Add(mago);
                }
            }
            if (cantTank > 0)
            {
                Tank tank = new Tank();
                for (i = 0; i < cantWarrior; i++)
                {
                    mazoJugador.Add(tank);
                }
            }

            mazoJugador = DesordenarMazo(mazoJugador);

            foreach (Monstruo item in mazoJugador)
            {
                mazo1.Enqueue(item);
            }

            #endregion
            
            for(i=0;i<4;i++)
            {
                mazo2.Enqueue(new Warrior());
                mazo2.Enqueue(new Assassin());
                mazo2.Enqueue(new Tank());
                mazo2.Enqueue(new Entidades.Mago());
            }

            juego = new Tablero(mazo1, mazo2,50);

            return juego;
        }


        
        public void RevisarCasillas (Tablero juego, object sender)
        {
            if(juego.casillas[0].Ocupado)
            {
                if (juego.casillas[0].Team == Equipo.Player)
                {
                    this.X00.Image = Properties.Resources.O;
                    this.lblVida00.Text = juego.casillas[0].Monstruo.Vida.ToString();
                    this.lblFuerza00.Text = juego.casillas[0].Monstruo.Fuerza.ToString();
                    this.X00.Visible = true;
                    this.lblVida00.Visible = true;
                    this.lblFuerza00.Visible = true;
                }
                else
                {
                    this.X00.Image = Properties.Resources.X;
                    this.lblVida00.Text = juego.casillas[0].Monstruo.Vida.ToString();
                    this.lblFuerza00.Text = juego.casillas[0].Monstruo.Fuerza.ToString();
                    this.X00.Visible = true;
                    this.lblVida00.Visible = true;
                    this.lblFuerza00.Visible = true;
                }
            }
            else
            {
                this.X00.Visible = false;
                this.lblVida00.Visible = false;
                this.lblFuerza00.Visible = false;
            }
            if (juego.casillas[1].Ocupado)
            {
                if (juego.casillas[1].Team == Equipo.Player)
                {
                    this.X01.Image = Properties.Resources.O;
                    this.lblVida01.Text = juego.casillas[1].Monstruo.Vida.ToString();
                    this.lblFuerza01.Text = juego.casillas[1].Monstruo.Fuerza.ToString();
                    this.X01.Visible = true;
                    this.lblVida01.Visible = true;
                    this.lblFuerza01.Visible = true;
                }
                else
                {
                    this.X01.Image = Properties.Resources.X;
                    this.lblVida01.Text = juego.casillas[1].Monstruo.Vida.ToString();
                    this.lblFuerza01.Text = juego.casillas[1].Monstruo.Fuerza.ToString();
                    this.X01.Visible = true;
                    this.lblVida01.Visible = true;
                    this.lblFuerza01.Visible = true;
                }
            }
            else
            {
                this.X01.Visible = false;
                this.lblVida01.Visible = false;
                this.lblFuerza01.Visible = false;
            }
            if (juego.casillas[2].Ocupado)
            {
                if (juego.casillas[2].Team == Equipo.Player)
                {
                    this.X02.Image = Properties.Resources.O;
                    this.lblVida02.Text = juego.casillas[2].Monstruo.Vida.ToString();
                    this.lblFuerza02.Text = juego.casillas[2].Monstruo.Fuerza.ToString();
                    this.X02.Visible = true;
                    this.lblVida02.Visible = true;
                    this.lblFuerza02.Visible = true;
                }
                else
                {
                    this.X02.Image = Properties.Resources.X;
                    this.lblVida02.Text = juego.casillas[2].Monstruo.Vida.ToString();
                    this.lblFuerza02.Text = juego.casillas[2].Monstruo.Fuerza.ToString();
                    this.X02.Visible = true;
                    this.lblVida02.Visible = true;
                    this.lblFuerza02.Visible = true;
                }
            }
            else
            {
                this.X02.Visible = false;
                this.lblVida02.Visible = false;
                this.lblFuerza02.Visible = false;
            }

            if (juego.casillas[3].Ocupado)
            {
                if (juego.casillas[3].Team == Equipo.Player)
                {
                    this.X10.Image = Properties.Resources.O;
                    this.lblVida10.Text = juego.casillas[3].Monstruo.Vida.ToString();
                    this.lblFuerza10.Text = juego.casillas[3].Monstruo.Fuerza.ToString();
                    this.X10.Visible = true;
                    this.lblVida10.Visible = true;
                    this.lblFuerza10.Visible = true;
                }
                else
                {
                    this.X10.Image = Properties.Resources.X;
                    this.lblVida10.Text = juego.casillas[3].Monstruo.Vida.ToString();
                    this.lblFuerza10.Text = juego.casillas[3].Monstruo.Fuerza.ToString();
                    this.X10.Visible = true;
                    this.lblVida10.Visible = true;
                    this.lblFuerza10.Visible = true;
                }
            }
            else
            {
                this.X10.Visible = false;
                this.lblVida10.Visible = false;
                this.lblFuerza10.Visible = false;
            }
            if (juego.casillas[4].Ocupado)
            {
                if (juego.casillas[4].Team == Equipo.Player)
                {
                    this.X11.Image = Properties.Resources.O;
                    this.lblVida11.Text = juego.casillas[4].Monstruo.Vida.ToString();
                    this.lblFuerza11.Text = juego.casillas[4].Monstruo.Fuerza.ToString();
                    this.X11.Visible = true;
                    this.lblVida11.Visible = true;
                    this.lblFuerza11.Visible = true;
                }
                else
                {
                    this.X11.Image = Properties.Resources.X;
                    this.lblVida11.Text = juego.casillas[4].Monstruo.Vida.ToString();
                    this.lblFuerza11.Text = juego.casillas[4].Monstruo.Fuerza.ToString();
                    this.X11.Visible = true;
                    this.lblVida11.Visible = true;
                    this.lblFuerza11.Visible = true;
                }
            }
            else
            {
                this.X11.Visible = false;
                this.lblVida11.Visible = false;
                this.lblFuerza11.Visible = false;
            }
            if (juego.casillas[5].Ocupado)
            {
                if (juego.casillas[5].Team == Equipo.Player)
                {
                    this.X00.Image = Properties.Resources.O;
                    this.lblVida12.Text = juego.casillas[5].Monstruo.Vida.ToString();
                    this.lblFuerza12.Text = juego.casillas[5].Monstruo.Fuerza.ToString();
                    this.X12.Visible = true;
                    this.lblVida12.Visible = true;
                    this.lblFuerza12.Visible = true;
                }
                else
                {
                    this.X12.Image = Properties.Resources.X;
                    this.lblVida12.Text = juego.casillas[5].Monstruo.Vida.ToString();
                    this.lblFuerza12.Text = juego.casillas[5].Monstruo.Fuerza.ToString();
                    this.X12.Visible = true;
                    this.lblVida12.Visible = true;
                    this.lblFuerza12.Visible = true;
                }
            }
            else
            {
                this.X12.Visible = false;
                this.lblVida12.Visible = false;
                this.lblFuerza12.Visible = false;
            }
            if (juego.casillas[6].Ocupado)
            {
                if (juego.casillas[6].Team == Equipo.Player)
                {
                    this.X20.Image = Properties.Resources.O;
                    this.lblVida20.Text = juego.casillas[6].Monstruo.Vida.ToString();
                    this.lblFuerza20.Text = juego.casillas[6].Monstruo.Fuerza.ToString();
                    this.X20.Visible = true;
                    this.lblVida20.Visible = true;
                    this.lblFuerza20.Visible = true;
                }
                else
                {
                    this.X20.Image = Properties.Resources.X;
                    this.lblVida20.Text = juego.casillas[6].Monstruo.Vida.ToString();
                    this.lblFuerza20.Text = juego.casillas[6].Monstruo.Fuerza.ToString();
                    this.X20.Visible = true;
                    this.lblVida20.Visible = true;
                    this.lblFuerza20.Visible = true;
                }
            }
            else
            {
                this.X20.Visible = false;
                this.lblVida20.Visible = false;
                this.lblFuerza20.Visible = false;
            }
            if (juego.casillas[7].Ocupado)
            {
                if (juego.casillas[7].Team == Equipo.Player)
                {
                    this.X21.Image = Properties.Resources.O;
                    this.lblVida21.Text = juego.casillas[7].Monstruo.Vida.ToString();
                    this.lblFuerza21.Text = juego.casillas[7].Monstruo.Fuerza.ToString();
                    this.X21.Visible = true;
                    this.lblVida21.Visible = true;
                    this.lblFuerza21.Visible = true;
                }
                else
                {
                    this.X21.Image = Properties.Resources.X;
                    this.lblVida21.Text = juego.casillas[7].Monstruo.Vida.ToString();
                    this.lblFuerza21.Text = juego.casillas[7].Monstruo.Fuerza.ToString();
                    this.X21.Visible = true;
                    this.lblVida21.Visible = true;
                    this.lblFuerza21.Visible = true;
                }
            }
            else
            {
                this.X21.Visible = false;
                this.lblVida21.Visible = false;
                this.lblFuerza21.Visible = false;
            }
            if (juego.casillas[8].Ocupado)
            {
                if (juego.casillas[8].Team == Equipo.Player)
                {
                    this.X22.Image = Properties.Resources.O;
                    this.lblVida22.Text = juego.casillas[8].Monstruo.Vida.ToString();
                    this.lblFuerza22.Text = juego.casillas[8].Monstruo.Fuerza.ToString();
                    this.X22.Visible = true;
                    this.lblVida22.Visible = true;
                    this.lblFuerza22.Visible = true;
                }
                else
                {
                    this.X22.Image = Properties.Resources.X;
                    this.lblVida22.Text = juego.casillas[8].Monstruo.Vida.ToString();
                    this.lblFuerza22.Text = juego.casillas[8].Monstruo.Fuerza.ToString();
                    this.X22.Visible = true;
                    this.lblVida22.Visible = true;
                    this.lblFuerza22.Visible = true;
                }
            }
            else
            {
                this.X22.Visible = false;
                this.lblVida22.Visible = false;
                this.lblFuerza22.Visible = false;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.juego = ArrancarJuego(this.juego,this.cantWarriors,this.cantHealers,this.cantAssassins,this.cantTanks);
           
            this.timer.Start();
        }

                #region Casillas

       
        #region Casilla22
        private void X22_Click(object sender, EventArgs e)
        {
            if (this.juego.casillas[8].Monstruo.Team == Equipo.Enemy)
            {
                this.juego.casillas[8].Monstruo.Vida -= this.juego.damagePlayer;
                this.lblVida22.Text = this.juego.casillas[8].Monstruo.Vida.ToString();
                if (this.juego.casillas[8].Monstruo.Vida <= 0)
                {
                    this.juego.casillas[8].Ocupado = false;
                    this.juego.casillasOcupadas--;
                    this.X22.Visible = false;
                    this.lblVida22.Visible = false;
                    this.lblFuerza22.Visible = false;
                }
            }
        }
      
        #endregion

        #region Casilla21
        private void X21_Click(object sender, EventArgs e)
        {
            if (this.juego.casillas[7].Monstruo.Team == Entidades.Equipo.Enemy)
            {
                this.juego.casillas[7].Monstruo.Vida -= this.juego.damagePlayer;
                this.lblVida21.Text = this.juego.casillas[7].Monstruo.Vida.ToString();
                if (this.juego.casillas[7].Monstruo.Vida <= 0)
                {
                    this.juego.casillas[7].Ocupado = false;
                    this.juego.casillasOcupadas--;
                    this.X21.Visible = false;
                    this.lblVida21.Visible = false;
                    this.lblFuerza21.Visible = false;
                }
            }
        }

        #endregion

        #region Casilla20
        private void X20_Click(object sender, EventArgs e)
        {
            if (this.juego.casillas[6].Monstruo.Team == Entidades.Equipo.Enemy)
            {
                this.juego.casillas[6].Monstruo.Vida -= this.juego.damagePlayer;
                this.lblVida20.Text = this.juego.casillas[6].Monstruo.Vida.ToString();
                if (this.juego.casillas[6].Monstruo.Vida <= 0)
                {
                    this.juego.casillas[6].Ocupado = false;
                    this.juego.casillasOcupadas--;
                    this.X20.Visible = false;
                    this.lblVida20.Visible = false;
                    this.lblFuerza20.Visible = false;
                }
            }
        }

        
        #endregion

        #region Casilla12
        private void X12_Click(object sender, EventArgs e)
        {
            if (this.juego.casillas[5].Monstruo.Team == Entidades.Equipo.Enemy)
            {
                this.juego.casillas[5].Monstruo.Vida -= this.juego.damagePlayer;
                this.lblVida12.Text = this.juego.casillas[5].Monstruo.Vida.ToString();
                if (this.juego.casillas[5].Monstruo.Vida <= 0)
                {
                    this.juego.casillas[5].Ocupado = false;
                    this.juego.casillasOcupadas--;
                    this.X12.Visible = false;
                    this.lblVida12.Visible = false;
                    this.lblFuerza12.Visible = false;
                }
            }
        }

        #endregion

        #region Casilla11
        private void X11_Click(object sender, EventArgs e)
        {
            if (this.juego.casillas[4].Monstruo.Team == Entidades.Equipo.Enemy)
            {
                this.juego.casillas[4].Monstruo.Vida -= this.juego.damagePlayer;
                this.lblVida11.Text = this.juego.casillas[4].Monstruo.Vida.ToString();
                if (this.juego.casillas[4].Monstruo.Vida <= 0)
                {
                    this.juego.casillas[4].Ocupado = false;
                    this.juego.casillasOcupadas--;
                    this.X11.Visible = false;
                    this.lblVida11.Visible = false;
                    this.lblFuerza11.Visible = false;
                }
            }
        }

        #endregion

        #region Casilla10
        private void X10_Click(object sender, EventArgs e)
        {
            if (this.juego.casillas[3].Monstruo.Team == Entidades.Equipo.Enemy)
            {
                this.juego.casillas[3].Monstruo.Vida -= this.juego.damagePlayer;
                this.lblVida10.Text = this.juego.casillas[3].Monstruo.Vida.ToString();
                if (this.juego.casillas[3].Monstruo.Vida <= 0)
                {
                    this.juego.casillas[3].Ocupado = false;
                    this.juego.casillasOcupadas--;
                    this.X10.Visible = false;
                    this.lblVida10.Visible = false;
                    this.lblFuerza10.Visible = false;
                }
            }
        }
        
        #endregion

        #region Casilla02
        private void X02_Click(object sender, EventArgs e)
        {
            if (this.juego.casillas[2].Monstruo.Team == Entidades.Equipo.Enemy)
            {
                this.juego.casillas[2].Monstruo.Vida -= this.juego.damagePlayer;
                this.lblVida02.Text = this.juego.casillas[2].Monstruo.Vida.ToString();
                if (this.juego.casillas[2].Monstruo.Vida <= 0)
                {
                    this.juego.casillas[2].Ocupado = false;
                    this.juego.casillasOcupadas--;
                    this.X02.Visible = false;
                    this.lblVida02.Visible = false;
                    this.lblFuerza02.Visible = false;
                }
            }
        }
        #endregion

        #region Casilla01
        private void X01_Click(object sender, EventArgs e)
        {
            if (this.juego.casillas[1].Monstruo.Team == Entidades.Equipo.Enemy)
            {
                this.juego.casillas[1].Monstruo.Vida -= this.juego.damagePlayer;
                this.lblVida01.Text = this.juego.casillas[1].Monstruo.Vida.ToString();
                if (this.juego.casillas[1].Monstruo.Vida <= 0)
                {
                    this.juego.casillas[1].Ocupado = false;
                    this.juego.casillasOcupadas--;
                    this.X01.Visible = false;
                    this.lblVida01.Visible = false;
                    this.lblFuerza01.Visible = false;
                }
            }
        }

        private void background_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Casilla00
        private void X00_Click(object sender, EventArgs e)
        {
            if (this.juego.casillas[0].Monstruo.Team == Entidades.Equipo.Enemy)
            {
                this.juego.casillas[0].Monstruo.Vida -= this.juego.damagePlayer;
                this.lblVida00.Text = this.juego.casillas[0].Monstruo.Vida.ToString();
                if (this.juego.casillas[0].Monstruo.Vida <= 0)
                {
                    this.juego.casillas[0].Ocupado = false;
                    this.juego.casillasOcupadas--;
                    this.X00.Visible = false;
                    this.lblVida00.Visible = false;
                    this.lblFuerza00.Visible = false;
                }
            }
        }
        #endregion

        #endregion

        

        private void timer_Tick(object sender, EventArgs e)
        {
            this.juego.jugador.JugarTurno(this.juego, this.i);
            this.juego.casillasOcupadas++;
            RevisarCasillas(this.juego, sender);
            if (this.juego.WaysToWin(this.juego))
            {
                Form2 fin = new Form2();
                this.timer.Stop();
                this.juego.enemyTurn.Abort();
                fin.ShowDialog();
            }
            
            this.i++;
        }

        public List<Monstruo> DesordenarMazo(List<Monstruo> listaOrdenada)
        {
            List<Monstruo> arr = listaOrdenada;
            List<Monstruo> arrDes = new List<Monstruo>();

            Random randNum = new Random();
            while (arr.Count > 0)
            {
                int val = randNum.Next(0, arr.Count - 1);
                arrDes.Add(arr[val]);
                arr.RemoveAt(val);
            }

            return arrDes;
        }
    }
}
