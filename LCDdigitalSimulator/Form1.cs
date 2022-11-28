using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace LCDdigitalSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Graphics g;
        public Pen p = new Pen(Color.Black);
        public Brush b = new SolidBrush(Color.Black);
        public int len = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            len = txtLCD.Text.Length;

            for (int i = 0; i < len; i++)
            {
                g.DrawString(txtLCD.Text.Substring(i, 1),this.Font,b,10+(i*7),50);
                Thread.Sleep(20);

            }
        }
    }
}
