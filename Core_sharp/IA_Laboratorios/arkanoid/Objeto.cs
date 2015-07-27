using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace arkanoid
{

    public abstract class Objeto
    {
        #region Variables
        /// <summary>
        /// Variable Privada Posicion X.
        /// </summary>
        private double _posX;
        /// <summary>
        /// Variable Publica Posicion X.
        /// </summary>
        public double X
        {
            get { return _posX; }
            set { _posX = value; }
        }
        /// <summary>
        /// Variable Privada Posicion Y.
        /// </summary>
        private double _posY;
        /// <summary>
        /// Variable Poblica Posicion Y.
        /// </summary>
        public double Y
        {
            get { return _posY; }
            set { _posY = value; }
        }
        /// <summary>
        /// Variable Privada Tamaño.
        /// </summary>
        private int _tam;
        /// <summary>
        /// Variable Privada Tamaño.
        /// </summary>
        public int tamano
        {
            get { return _tam; }
            set { _tam = value; }
        }
        
        #endregion
        
        /// <summary>
        /// Constructor del Objeto
        /// </summary>
        public Objeto()
        {
            _posX = 0;
            _posY = 0;
            _tam = 0;
        }
      
        /// <summary>
        /// Prototipo de función de pintado
        /// </summary>
        /// <param name="g">Objeto de ointado g</param>
        public abstract void Pintar(Graphics g);
        
    }
}
