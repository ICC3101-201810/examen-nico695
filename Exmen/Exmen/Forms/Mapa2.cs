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
    public partial class Mapa2 : Form
    {
        bool arriba, abajo, izq, der;
        int speed = 5;
        int f2 = 6;
        int f3 = 5;
        int f4 = 6;
        int f5 = 5;
        int ptje = 0;

        Usuario current;
        
        public Mapa2(Usuario a2)
        {
            current = a2;
            this.CenterToScreen();
            InitializeComponent();
            label2.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista.SerializarC(Lista.u21);
            Form1 f1 = new Form1();

            f1.Show();
        }

        private void kdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                abajo = true;
                pictureBox9.Image = Properties.Resources.pacman_down;
            }

            if (e.KeyCode == Keys.Up)
            {

                 arriba = true;
                 pictureBox9.Image = Properties.Resources.pacman_up;
            }

            if (e.KeyCode == Keys.Left)
            {
                izq = true;
                pictureBox9.Image = Properties.Resources.pacman_left;
            }

            if (e.KeyCode == Keys.Right)
            {
                der = true;
                pictureBox9.Image = Properties.Resources.pacman_right;
            }
        }

        private void kup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Down)
            {
                abajo = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                arriba = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                izq = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                der = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Puntaje : " + ptje;


            if (arriba)
            {
                pictureBox9.Top -= speed;
            }

            if (abajo)
            {
                pictureBox9.Top += speed;
            }

            if (izq)
            {
                pictureBox9.Left -= speed;
            }

            if (der)
            {
                pictureBox9.Left += speed;
            }

            
            rosado.Left += f2;
            rosado.Top += f3;
            rojo.Left += f4;
            rojo.Top += f5;
            
            
            foreach(Control x in Controls)
            {
                if (x is PictureBox && x.Name=="rojo" || x.Name=="rosado")
                {
                    if(((PictureBox)x).Bounds.IntersectsWith(pictureBox9.Bounds))
                    {

                        label2.Visible = true;
                        button1.Visible = true;
                        pictureBox9.Image = Properties.Resources.ded1;
                        timer1.Stop();
                        current.Ptje = ptje;
                        Lista.u21.Add(current);
                        
                    }

                    
                }

                
            }
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Name =="uva")
                {
                    if (((PictureBox)control).Bounds.IntersectsWith(pictureBox9.Bounds))
                    {
                        Controls.Remove(control);
                        ptje += 15;
                        current.Ptje = ptje;
                    }
                }
                if (control is PictureBox && control.Name == "guinda")
                {
                    if (((PictureBox)control).Bounds.IntersectsWith(pictureBox9.Bounds))
                    {
                        Controls.Remove(control);
                        ptje += 10;
                        current.Ptje = ptje;


                    }
                }

            }
            if (rosado.Left<1 || rosado.Left+rosado.Width>=ClientSize.Width)
            {
                f2 = -f2;
            }

            if(rosado.Top<1 || rosado.Top + rosado.Height>=ClientSize.Height)
            {
                f3 = -f3;
                
            }

            if (rojo.Left < 1 || rojo.Left + rojo.Width >=ClientSize.Width)
            {
                f4 = -f4;
            }

            if (rojo.Top < 1 || rojo.Top + rojo.Height >=ClientSize.Height)
            {
                f5 = -f5;
            }

            


            

        }
    }
}
