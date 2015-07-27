using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace arkanoid
{
    /// <summary>
    /// Clase de eventos de colision con el bloque
    /// </summary>
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

        #region Variables
        
        /// <summary>
        /// Color de los bloques (privado).
        /// </summary>
        private Color _color;
        
        /// <summary>
        /// Color de los bloques (publico).
        /// </summary>
        public Color color
        {
            get { return _color; }
            set { _color = value; }
        }
        
        /// <summary>
        /// El bloque se debe mostrar? (privada)
        /// </summary>
        private bool _activo = true;
    
        /// <summary>
        /// El bloque se debe mostrar? (publica)
        /// </summary>
        public bool isActivo
        {
            get { return _activo; }
            set { _activo = value; }
        } 
        #endregion

        #region Eventos

        /// <summary>
        /// Delegado para la colision.
        /// </summary>
        /// <param name="Sender">objeto que colisiono</param>
        /// <param name="e">evento de colision</param>
        public delegate void meDieron(object Sender, BloqueEventArgs e);

        /// <summary>
        /// Evento de que hubo colision.
        /// </summary>
        public event meDieron ouch; 
        #endregion
        
        /// <summary>
        /// Constructor.
        /// </summary>
        public Bloque()
        {

        }
        
        /// <summary>
        /// Prototipo de función de pintado
        /// </summary>
        /// <param name="g">Objeto de ointado g</param>
        public override void Pintar(Graphics g)
        {
            if (isActivo)
                g.FillRectangle(new SolidBrush(_color), (int)X, (int)Y, 70, 30);
        }
      
        /// <summary>
        /// Validar las colisiones con la bola.
        /// </summary>
        /// <param name="b">Bola.</param>
        public void validarColision(bola b)
        {
            if (_activo)
            {
                if (((b.X + 20 >= X) & (b.X <= (X + 70))) &&
                    ((b.Y + 20 >= Y) & (b.Y <= (Y + 30))))
                {
                    _activo = false;
                    if (ouch != null)
                        ouch(this, new BloqueEventArgs(1));
                }

            }
        }
    }
}
