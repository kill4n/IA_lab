using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace arkanoid
{
    public enum DirPad
    {
        Derecha,
        Izquierda
    }
    public partial class arkanoid : UserControl
    {
        #region Variables
        int _mult = 40;
        Bitmap wld;
        Graphics g;
        bola b;
        Base padd;
        Bloque[,] bloques = new Bloque[10, 6];
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public arkanoid()
        {
            InitializeComponent();
            wld = new Bitmap(20 * _mult, 20 * _mult);
            g = Graphics.FromImage(wld);

            b = new bola(Math.PI / 4 + 0.01);
            padd = new Base();
            padd.tamano = 80;
            padd.Y = 750;

            b.tamano = (int)(0.5 * _mult);
            b.X = 10 * _mult;
            b.Y = 10 * _mult;

            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 6; j++)
                {
                    bloques[i, j] = new Bloque();
                    bloques[i, j].X = 5 + i * 80;
                    bloques[i, j].Y = 20 + j * 40;
                    bloques[i, j].color = Color.Blue;
                    bloques[i, j].ouch += arkanoid_ouch;
                }
            }

            pictureBox1.Image = wld;
            refreshGame();
        }

        /// <summary>
        /// Funcion de colision
        /// </summary>
        /// <param name="Sender">objeto que colisiono</param>
        /// <param name="e">Datos del evento</param>
        void arkanoid_ouch(object Sender, BloqueEventArgs e)
        {
            //b.cambiodir();
        }
        /// <summary>
        /// Reflescar el juego
        /// </summary>
        public void refreshGame()
        {
            g.Clear(Color.Aqua);
            b.Pintar(g);
            padd.Pintar(g);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    bloques[i, j].validarColision(b);
                }
            }

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 6; j++)
                    bloques[i, j].Pintar(g);

            b.mover();

            pictureBox1.Image = wld;
        }

        public void movePad(DirPad dir)
        {
            switch (dir)
            {
                case DirPad.Derecha:
                    padd.moverDerecha();
                    break;
                case DirPad.Izquierda:
                    padd.moverIzquierda();
                    break;
                default:
                    break;
            }
        }

    }
}
