using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace arkanoid
{
    /// <summary>
    /// Objeto de la base.
    /// </summary>
    public class Base : Objeto
    {
        #region Variables
        /// <summary>
        /// Velocidad de la base.
        /// </summary>
        public double speed = 10;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public Base()
        {

        }

        /// <summary>
        /// Mover la base *funcion a dejar abierta*.
        /// </summary>
        public void moverDerecha()
        {
            var tmpX = X + speed;
            if ((tmpX > 0) & (tmpX < 800 - tamano))
            {
                X += speed;
            }
        }

        public void moverIzquierda()
        {
            var tmpX = X - speed;
            if ((tmpX > 0) & (tmpX < 800 - tamano))
            {
                X -= speed;
            }
        }
        /// <summary>
        /// Prototipo de función de pintado
        /// </summary>
        /// <param name="g">Objeto de ointado g</param>
        public override void Pintar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Red), (int)X, (int)Y, tamano, tamano / 4);
        }
    }
}
