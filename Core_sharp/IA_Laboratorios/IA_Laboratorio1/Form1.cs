using arkanoid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IA_Laboratorio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            arkanoid2.refreshGame();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                arkanoid2.movePad(DirPad.Izquierda);
            }
            if (e.KeyCode == Keys.D)
            {
                arkanoid2.movePad(DirPad.Derecha);
            }
        }
    }
}
