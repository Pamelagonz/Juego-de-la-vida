using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int c;
        Tablero t;
        
        public Form1()
        {
            InitializeComponent();
            t = new Tablero(20);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            t.next();
            t.update();
            this.Invalidate();
            c = c + 1;
            textBox1.Text = c.ToString();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            t.Dibuja(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t = new Tablero(20);
            c = 0;
            textBox1.Text = c.ToString();
        }

        private void x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = new Tablero(10);
            c = 0;
            textBox1.Text = c.ToString();
        }

        private void x15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = new Tablero(15);
            c = 0;
            textBox1.Text = c.ToString();
        }

        private void x20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = new Tablero(20);
            c = 0;
            textBox1.Text = c.ToString();
        } 
    }
}
