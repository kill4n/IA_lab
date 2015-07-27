using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace arkanoid
{
    public class BloqueEventArgs : EventArgs
    {
        public int data = 0;
        public BloqueEventArgs(int dat)
        {
            data = dat;
        }
    }
    public class Bloque : Objeto
    {
        private Color _color;

        public Color color
        {
            get { return _color; }
            set { _color = value; }
        }
        private bool _activo = true;

        public bool isActivo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        public delegate void meDieron(object Sender, BloqueEventArgs e);
        public event meDieron ouch;

        public Bloque()
        {

        }
        public override void Pintar(Graphics g)
        {
            //if (isActivo)
                //g.FillRectangle(new SolidBrush(_color), (int)X, (int)Y, 70, 30);
        }

        public void validarColision(bola b)
        {
            if (_activo)
            {
                //if (((b.X + 20 >= X) & (b.X <= (X + 70))) &&
                //    ((b.Y + 20 >= Y) & (b.Y <= (Y + 30))))
                //{
                //    _activo = false;
                //    if (ouch != null)
                //        ouch(this, new BloqueEventArgs(1));
                //}

            }
        }
    }
}
