using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace arkanoid
{
    public class Base : Objeto
    {
        public Base()
        {

        }
        public double spped = 0.1;
        public void mover()
        {
            var tmpX = X + spped ;
            if ((tmpX > 0) & (tmpX < 800 - tamano))
            {
                X += spped ;
            }            
        }

        public override void Pintar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Red), (int)X, (int)Y, tamano, tamano/4);
        }
    }
}
