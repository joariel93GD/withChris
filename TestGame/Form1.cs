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

    public partial class Form1 : Form
    {

       
        Tablero juego;
        int i=0;
        

        public Form1()
        {
           
            InitializeComponent();
            
        }
        public Tablero ArrancarJuego(Tablero juego)
        {
            Queue<Monstruo> mazo1 = new Queue<Monstruo>();
            Queue<Monstruo> mazo2 = new Queue<Monstruo>();

            #region Cartas
            Warrior carta01 = new Warrior();
            Warrior carta02 = new Warrior();
            Warrior carta03 = new Warrior();
            Warrior carta04 = new Warrior();
            Assassin carta05 = new Assassin();
            Assassin carta06 = new Assassin();
            Healer carta07 = new Healer();
            Tank carta08 = new Tank();
            Warrior carta09 = new Warrior();
            Warrior carta10 = new Warrior();
            Warrior carta11 = new Warrior();
            Warrior carta12 = new Warrior();
            Assassin carta13 = new Assassin();
            Assassin carta14 = new Assassin();
            Healer carta15 = new Healer();
            Tank carta16 = new Tank();
            #endregion

            #region Creando Mazos
            mazo1.Enqueue(carta01);
            mazo1.Enqueue(carta02);
            mazo1.Enqueue(carta03);
            mazo1.Enqueue(carta04);
            mazo1.Enqueue(carta13);
            mazo1.Enqueue(carta14);
            mazo1.Enqueue(carta15);
            mazo1.Enqueue(carta16);

            mazo2.Enqueue(carta08);
            mazo2.Enqueue(carta07);
            mazo2.Enqueue(carta06);
            mazo2.Enqueue(carta05);
            mazo2.Enqueue(carta09);
            mazo2.Enqueue(carta10);
            mazo2.Enqueue(carta11);
            mazo2.Enqueue(carta12);

            #endregion
            juego = new Tablero(mazo1, mazo2);

            return juego;
        }

        

        private void btnTurno_Click(object sender, EventArgs e)
        {
            this.juego.jugador.JugarTurno(this.juego, this.i);
            this.juego.casillasOcupadas++;
            RevisarCasillas(this.juego, sender);
            if (this.juego.WaysToWin(this.juego))
            {
                Form2 fin = new Form2();

                fin.ShowDialog();
            }
            this.i++;
        }
        public void RevisarCasillas (Tablero juego, object sender)
        {
            if(juego.casillas[0,0].Ocupado)
            {
                if (juego.casillas[0, 0].Team == Equipo.Player)
                {
                    this.O00.BringToFront();
                    this.O00.Visible = true;
                }
                else
                {
                    this.X00.BringToFront();
                    this.X00.Visible = true;
                }
            }
            if (juego.casillas[0, 1].Ocupado)
            {
                if (juego.casillas[0, 1].Team == Equipo.Player)
                { 
                    this.O01.BringToFront();
                    this.O01.Visible = true;
                }
                else
                {
                    this.X01.BringToFront();
                    this.X01.Visible = true;
                }
            }

            if (juego.casillas[0, 2].Ocupado)
            {
                if (juego.casillas[0, 2].Team == Equipo.Player)
                {
                    this.O02.BringToFront();
                    this.O02.Visible = true;
                }
                else
                {
                    this.X02.BringToFront();
                    this.X02.Visible = true;
                }
            }

            if (juego.casillas[1, 0].Ocupado)
            {
                if (juego.casillas[1, 0].Team == Equipo.Player)
                {
                    this.O10.BringToFront();
                    this.O10.Visible = true;
                }
                else
                {
                    this.X10.BringToFront();
                    this.X10.Visible = true;
                }
            }
            if (juego.casillas[1, 1].Ocupado)
            {
                if (juego.casillas[1, 1].Team == Equipo.Player)
                {
                    this.O11.BringToFront();
                    this.O11.Visible = true;
                }
                else
                {
                    this.X11.BringToFront();
                    this.X11.Visible = true;
                }
            }
            if (juego.casillas[1, 2].Ocupado)
            {
                if (juego.casillas[1, 2].Team == Equipo.Player)
                {
                    this.O12.BringToFront();
                    this.O12.Visible = true;
                }
                else
                {
                    this.X12.BringToFront();
                    this.X12.Visible = true;
                }
            }
            if (juego.casillas[2, 0].Ocupado)
            {
                if (juego.casillas[2, 0].Team == Equipo.Player)
                {
                    this.O20.BringToFront();
                    this.O20.Visible = true;
                }
                else
                {
                    this.X20.BringToFront();
                    this.X20.Visible = true;
                }
            }
            if (juego.casillas[2, 1].Ocupado)
            {
                if (juego.casillas[2, 1].Team == Equipo.Player)
                {
                    this.O21.BringToFront();
                    this.O21.Visible = true;
                }
                else
                {
                    this.X21.BringToFront();
                    this.X21.Visible = true;
                }
            }
            if (juego.casillas[2, 2].Ocupado)
            {
                if (juego.casillas[2, 2].Team == Equipo.Player)
                {
                    this.O22.BringToFront();
                    this.O22.Visible = true;
                }
                else
                {
                    this.X22.BringToFront();
                    this.X22.Visible = true;
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.juego = ArrancarJuego(this.juego);
            this.timer.Start();
        }

                #region Casillas

       
        #region Casilla22
        private void X22_Click(object sender, EventArgs e)
        {
            this.juego.casillas[2, 2].Monstruo.Vida -= 1000;
            if (this.juego.casillas[2, 2].Monstruo.Vida <= 0)
            {
                this.juego.casillas[2, 2].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.X22.Visible = false;
            }
        }
       private void O22_Click(object sender, EventArgs e)
        {
            this.juego.casillas[2, 2].Monstruo.Vida -= 1000;
            if (this.juego.casillas[2, 2].Monstruo.Vida <= 0)
            {
                this.juego.casillas[2, 2].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.O22.Visible = false;
            }
        }
        #endregion


        #region Casilla21
        private void X21_Click(object sender, EventArgs e)
        {
            this.juego.casillas[2, 1].Monstruo.Vida -= 1000;
            if (this.juego.casillas[2, 1].Monstruo.Vida <= 0)
            {
                this.juego.casillas[2, 1].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.X21.Visible = false;
            }
        }

        private void O21_Click(object sender, EventArgs e)
        {
            this.juego.casillas[2, 1].Monstruo.Vida -= 1000;
            if (this.juego.casillas[2, 1].Monstruo.Vida <= 0)
            {
                this.juego.casillas[2, 1].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.O21.Visible = false;
            }
        }
        #endregion

        #region Casilla20
        private void X20_Click(object sender, EventArgs e)
        {
            this.juego.casillas[2, 0].Monstruo.Vida -= 1000;
            if (this.juego.casillas[2, 0].Monstruo.Vida <= 0)
            {
                this.juego.casillas[2, 0].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.X20.Visible = false;
            }
        }

        private void O20_Click(object sender, EventArgs e)
        {
            this.juego.casillas[2, 0].Monstruo.Vida -= 1000;
            if (this.juego.casillas[2, 0].Monstruo.Vida <= 0)
            {
                this.juego.casillas[2, 0].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.O20.Visible = false;
            }
        }
        #endregion

        #region Casilla12
        private void X12_Click(object sender, EventArgs e)
        {
            this.juego.casillas[1, 2].Monstruo.Vida -= 1000;
            if (this.juego.casillas[1, 2].Monstruo.Vida <= 0)
            {
                this.juego.casillas[1, 2].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.X12.Visible = false;
            }
        }

        private void O12_Click(object sender, EventArgs e)
        {
            this.juego.casillas[1, 2].Monstruo.Vida -= 1000;
            if (this.juego.casillas[1, 2].Monstruo.Vida <= 0)
            {
                this.juego.casillas[1, 2].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.O12.Visible = false;
            }
        }
        #endregion

        #region Casilla11
        private void X11_Click(object sender, EventArgs e)
        {
            this.juego.casillas[1,1].Monstruo.Vida -= 1000;
            if (this.juego.casillas[1,1].Monstruo.Vida <= 0)
            {
                this.juego.casillas[1,1].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.X11.Visible = false;
            }
        }

        private void O11_Click(object sender, EventArgs e)
        {
            this.juego.casillas[1,1].Monstruo.Vida -= 1000;
            if (this.juego.casillas[1,1].Monstruo.Vida <= 0)
            {
                this.juego.casillas[1,1].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.O11.Visible = false;
            }
        }
        #endregion

        #region Casilla10
        private void X10_Click(object sender, EventArgs e)
        {
            this.juego.casillas[1,0].Monstruo.Vida -= 1000;
            if (this.juego.casillas[1,0].Monstruo.Vida <= 0)
            {
                this.juego.casillas[1,0].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.X10.Visible = false;
            }
        }

        private void O10_Click(object sender, EventArgs e)
        {
            this.juego.casillas[1,0].Monstruo.Vida -= 1000;
            if (this.juego.casillas[1,0].Monstruo.Vida <= 0)
            {
                this.juego.casillas[1,0].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.O10.Visible = false;
            }
        }
        #endregion

        #region Casilla02
        private void X02_Click(object sender, EventArgs e)
        {
            this.juego.casillas[0, 2].Monstruo.Vida -= 1000;
            if (this.juego.casillas[0, 2].Monstruo.Vida <= 0)
            {
                this.juego.casillas[0, 2].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.X02.Visible = false;
            }
        }

        private void O02_Click(object sender, EventArgs e)
        {
            this.juego.casillas[0, 2].Monstruo.Vida -= 1000;
            if (this.juego.casillas[0, 2].Monstruo.Vida <= 0)
            {
                this.juego.casillas[0 ,2].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.O02.Visible = false;
            }
        }
        #endregion

        #region Casilla01
        private void X01_Click(object sender, EventArgs e)
        {
            this.juego.casillas[0,1].Monstruo.Vida -= 1000;
            if (this.juego.casillas[0,1].Monstruo.Vida <= 0)
            {
                this.juego.casillas[0,1].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.X01.Visible = false;
            }
        }

        private void O01_Click(object sender, EventArgs e)
        {
            this.juego.casillas[0,1].Monstruo.Vida -= 1000;
            if (this.juego.casillas[0,1].Monstruo.Vida <= 0)
            {
                this.juego.casillas[0,1].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.O01.Visible = false;
            }
        }
        #endregion

        #region Casilla00
        private void X00_Click(object sender, EventArgs e)
        {
            this.juego.casillas[0,0].Monstruo.Vida -= 1000;
            if (this.juego.casillas[0,0].Monstruo.Vida <= 0)
            {
                this.juego.casillas[0,0].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.X00.Visible = false;
            }
        }

        private void O00_Click(object sender, EventArgs e)
        {
            this.juego.casillas[0,0].Monstruo.Vida -= 1000;
            if (this.juego.casillas[0,0].Monstruo.Vida <= 0)
            {
                this.juego.casillas[0,0].Ocupado = false;
                this.juego.casillasOcupadas--;
                this.O00.Visible = false;
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
                fin.ShowDialog();
            }
            this.i++;
        }
    }
}
