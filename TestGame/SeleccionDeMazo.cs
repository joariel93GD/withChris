using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGame
{
    public partial class SeleccionDeMazo : Form
    {
        int cantAssa;
        int cantMago;
        int cantTank;
        int cantWarrior;
        int cantTotal;

        public SeleccionDeMazo()
        {
            this.cantAssa = 0;
            this.cantMago = 0;
            this.cantTank = 0;
            this.cantWarrior = 0;
            this.cantTotal = 0;
            InitializeComponent();  
        }



        #region Eventos del movimiento del mouse
        private void btnWarrior_MouseMove(object sender, MouseEventArgs e)
        {
            btnWarrior.BackgroundImage = Properties.Resources.Warrior;
            pctBxStatsWarrior.Visible = true;
        }

        private void btnWarrior_MouseLeave(object sender, EventArgs e)
        {
            btnWarrior.BackgroundImage = Properties.Resources.WarriorByN;
            pctBxStatsWarrior.Visible = false;
        }
        private void btnAssassin_MouseMove(object sender, MouseEventArgs e)
        {
            btnAssassin.BackgroundImage = Properties.Resources.Assassin;
            pctBxAssa.Visible = true;
        }
        private void btnAssassin_MouseLeave(object sender, EventArgs e)
        {
            btnAssassin.BackgroundImage = Properties.Resources.AssassinByN;
            pctBxAssa.Visible = false;
        }
        private void btnHealer_MouseMove(object sender, MouseEventArgs e)
        {
            btnHealer.BackgroundImage = Properties.Resources.Healer;
            pctBxMago.Visible = true;
        }
        private void btnHealer_MouseLeave(object sender, EventArgs e)
        {
            btnHealer.BackgroundImage = Properties.Resources.HealerByN;
            pctBxMago.Visible = false;
        }

        private void btnTank_MouseMove(object sender, MouseEventArgs e)
        {
            btnTank.BackgroundImage = Properties.Resources.Tank;
            pctBxTank.Visible = true;
        }
        private void btnTank_MouseLeave(object sender, EventArgs e)
        {
            btnTank.BackgroundImage = Properties.Resources.TankByN;
            pctBxTank.Visible = false;
        }

        #endregion

        #region Eventos del click del mouse
        private void btnWarrior_Click(object sender, EventArgs e)
        {
            this.cantWarrior++;
            this.cantTotal++;
        }

        private void btnAssassin_Click(object sender, EventArgs e)
        {
            this.cantAssa++;
            this.cantTotal++;
        }

        private void btnHealer_Click(object sender, EventArgs e)
        {
            this.cantMago++;
            this.cantTotal++;
        }

        private void btnTank_Click(object sender, EventArgs e)
        {
            this.cantTank++;
            this.cantTotal++;
        }

        #endregion

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }
    }
}
