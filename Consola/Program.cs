using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magos;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Monstruo> mazo1=new Queue<Monstruo>();
            Queue<Monstruo> mazo2 = new Queue<Monstruo>();
            
            #region Cartas
            Warrior carta1 = new Warrior();
            Warrior carta2 = new Warrior();
            Warrior carta3 = new Warrior();
            Warrior carta4 = new Warrior();
            Assassin carta5 = new Assassin();
            Assassin carta6 = new Assassin();
            Healer carta7 = new Healer();
            Tank carta8 = new Tank();
            #endregion

            #region Creando Mazos
            mazo1.Enqueue(carta1);
            mazo1.Enqueue(carta2);
            mazo1.Enqueue(carta3);
            mazo1.Enqueue(carta4);
            mazo1.Enqueue(carta5);
            mazo1.Enqueue(carta6);
            mazo1.Enqueue(carta7);
            mazo1.Enqueue(carta8);

            mazo2.Enqueue(carta8);
            mazo2.Enqueue(carta7);
            mazo2.Enqueue(carta6);
            mazo2.Enqueue(carta5);
            mazo2.Enqueue(carta4);
            mazo2.Enqueue(carta3);
            mazo2.Enqueue(carta2);
            mazo2.Enqueue(carta1);

            #endregion

            Tablero juego=new Tablero(mazo1,mazo2);



        }
    }
}
