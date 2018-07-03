using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exmen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.CenterToScreen();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario a23 = new Usuario(0,textBox1.Text);
            Mapa2 mapa = new Mapa2(a23);
            mapa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Top10 t10 = new Top10();
            t10.Show();
            
        }
    }
}
