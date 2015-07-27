using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace arkanoid
{
    public class bola : Objeto
    {
        Random r;
        private double _ang;
        public double angulo
        {
            get { return _ang; }
            set { _ang = value; }
        }

        private double spped = 2;

        /// <summary>
        /// Constructor, recive elangulo inicial.
        /// </summary>
        /// <param name="ang"></param>
        public bola(double ang)
        {
            _ang = ang;
            r = new Random(DateTime.Now.Millisecond);
        }

        override public void Pintar(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Black), (int)X, (int)Y, tamano, tamano);
        }

        public void mover()
        {
            var tmpX = X + (spped * Math.Cos(_ang));
            var tmpY = Y + (spped * Math.Sin(_ang));

            if (tmpX <= 0)
            {
                cambiodir(-1);
                mo();
                return;
            }
            if (tmpY <= 0)
            {
                cambiodir(-1);
                mo();
                return;
            }
            if (tmpX+tamano >= 800)
            {
                cambiodir(-1);
                mo();
                return;
            }
            if (tmpY+tamano >=800)
            {
                cambiodir(1);
                mo();
                return;
            }
            mo();
        }
        void mo()
        {
            X += spped * Math.Cos(_ang);
            Y += spped * Math.Sin(_ang);
        }

        public void cambiodir(int dir)
        {
            _ang += dir * (Math.PI / 2) + r.NextDouble() * 0.01;
        }
    }
}
