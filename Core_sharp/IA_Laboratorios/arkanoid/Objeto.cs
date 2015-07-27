using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace arkanoid
{
public abstract class Objeto
    {
    private double _posX;

        public double X
        {
            get { return _posX; }
            set { _posX = value; }
        }
        private double _posY;

        public double Y
        {
            get { return _posY; }
            set { _posY = value; }
        }

        private int _tam;
        public int tamano
        {
            get { return _tam; }
            set { _tam = value; }
        }

        public abstract void Pintar(Graphics g);

        public Objeto()
        {
            _posX = 0;
            _posY = 0;
            _tam = 0;
        }
        
    }
}
