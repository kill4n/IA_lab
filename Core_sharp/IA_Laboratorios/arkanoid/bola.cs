using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace arkanoid
{
    /// <summary>
    /// Posibles direcciones de choque.
    /// </summary>
    public enum Direccion
    {
        Horiz = 0,
        Verti = 1
    }

    public class bola : Objeto
    {
        /// <summary>
        /// Objeto para agregar un movimiento random.
        /// </summary>
        Random r;
        /// <summary>
        /// Variable privada del angulo.
        /// </summary>
        private double _ang;
        /// <summary>
        /// Variable publica del angulo
        /// </summary>
        public double angulo
        {
            get { return _ang; }
            set { _ang = value; }
        }
        /// <summary>
        /// Velocidad de la bola.
        /// </summary>
        private double spped = 5;

        /// <summary>
        /// Constructor, recive elangulo inicial.
        /// </summary>
        /// <param name="ang"></param>
        public bola(double ang)
        {
            _ang = ang;
            r = new Random(DateTime.Now.Millisecond);
        }

        /// <summary>
        /// Prototipo de función de pintado
        /// </summary>
        /// <param name="g">Objeto de ointado g</param>
        override public void Pintar(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Black), (int)X, (int)Y, tamano, tamano);
        }
        /// <summary>
        /// Mover la esfera a una nueva posicion y validar choque con el mundo.
        /// </summary>
        public void mover()
        {
            var tmpX = X + (spped * Math.Cos(_ang));
            var tmpY = Y + (spped * Math.Sin(_ang));

            if (((tmpX < 0) ||
                ((tmpX + tamano) > 800)) ||
                ((tmpY < 0) ||
                ((tmpY + tamano) > 800)))
            {
                cambiodir();
                X += spped * Math.Cos(_ang);
                Y += spped * Math.Sin(_ang);
            }
            else
            {
                X += spped * Math.Cos(_ang);
                Y += spped * Math.Sin(_ang);
            }
        }
        /// <summary>
        /// Cambiar la direccion de la bola
        /// </summary>
        /// <param name="d">direccion pendiente</param>
        public void cambiodir()
        {
            if ((Y + tamano >= 750))
            {
                _ang *= -1;
            }
            else
            {
                if ((Y <= 0))
                {
                    _ang = Math.Abs(_ang);
                }
                else
                {
                    _ang = Math.PI - _ang;// (Math.PI / 2) + r.NextDouble() * 0.01;
                }

            }


        }
    }
}
