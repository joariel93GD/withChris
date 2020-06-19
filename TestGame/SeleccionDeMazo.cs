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
        public SeleccionDeMazo()
        {
            InitializeComponent();  
        }

        #region Eventos del mouse
        private void btnWarrior_MouseMove(object sender, MouseEventArgs e)
        {
            btnWarrior.BackgroundImage = Properties.Resources.Warrior;
        }

        private void btnWarrior_MouseLeave(object sender, EventArgs e)
        {
            btnWarrior.BackgroundImage = Properties.Resources.WarriorByN;
        }
        private void btnAssassin_MouseMove(object sender, MouseEventArgs e)
        {
            btnAssassin.BackgroundImage = Properties.Resources.Assassin;
        }
        private void btnAssassin_MouseLeave(object sender, EventArgs e)
        {
            btnAssassin.BackgroundImage = Properties.Resources.AssassinByN;
        }
        private void btnHealer_MouseMove(object sender, MouseEventArgs e)
        {
            btnHealer.BackgroundImage = Properties.Resources.Healer;
        }
        private void btnHealer_MouseLeave(object sender, EventArgs e)
        {
            btnHealer.BackgroundImage = Properties.Resources.HealerByN;
        }

        private void btnTank_MouseMove(object sender, MouseEventArgs e)
        {
            btnTank.BackgroundImage = Properties.Resources.Tank;
        }
        private void btnTank_MouseLeave(object sender, EventArgs e)
        {
            btnTank.BackgroundImage = Properties.Resources.TankByN;
        }

        #endregion

    }
}
