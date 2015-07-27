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
            
            timer1.Start();
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            arkanoid1.refreshGame();
        }
    }
}
