﻿namespace IA_Laboratorio1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.arkanoid1 = new arkanoid.arkanoid();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // arkanoid1
            // 
            this.arkanoid1.Location = new System.Drawing.Point(12, 12);
            this.arkanoid1.MaximumSize = new System.Drawing.Size(400, 400);
            this.arkanoid1.MinimumSize = new System.Drawing.Size(400, 400);
            this.arkanoid1.Name = "arkanoid1";
            this.arkanoid1.Size = new System.Drawing.Size(400, 400);
            this.arkanoid1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 419);
            this.Controls.Add(this.arkanoid1);
            this.Name = "Form1";
            this.Text = "Practica_1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private arkanoid.arkanoid arkanoid1;

    }
}

