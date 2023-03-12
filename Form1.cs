using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int köd = 0;
        int currentd = 0;

        bool mouseDown;
        private Point offset;

        private void button1_Click(object sender, EventArgs e)
        {
            if(sonuçL.Text==string.Empty)
            {
                sonuçL.Text = "1";
            }
            else
            {
                sonuçL.Text = sonuçL.Text + "1";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sonuçL.Text == string.Empty)
            {
                sonuçL.Text = "2";
            }
            else
            {
                sonuçL.Text = sonuçL.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sonuçL.Text == string.Empty)
            {
                sonuçL.Text = "3";
            }
            else
            {
                sonuçL.Text = sonuçL.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sonuçL.Text == string.Empty)
            {
                sonuçL.Text = "4";
            }
            else
            {
                sonuçL.Text = sonuçL.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sonuçL.Text == string.Empty)
            {
                sonuçL.Text = "5";
            }
            else
            {
                sonuçL.Text = sonuçL.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sonuçL.Text == string.Empty)
            {
                sonuçL.Text = "6";
            }
            else
            {
                sonuçL.Text = sonuçL.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sonuçL.Text == string.Empty)
            {
                sonuçL.Text = "7";
            }
            else
            {
                sonuçL.Text = sonuçL.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sonuçL.Text == string.Empty)
            {
                sonuçL.Text = "8";
            }
            else
            {
                sonuçL.Text = sonuçL.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sonuçL.Text == string.Empty)
            {
                sonuçL.Text = "9";
            }
            else
            {
                sonuçL.Text = sonuçL.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (sonuçL.Text == string.Empty)
            {
                sonuçL.Text = "0";
            }
            else
            {
                sonuçL.Text = sonuçL.Text + "0";
            }
        }

        private void buttonartı_Click(object sender, EventArgs e)
        {
            if (sonuçL.Text != string.Empty)
            {
                if (currentd == 0)
                {
                    köd = Convert.ToInt32(sonuçL.Text);
                }
                else if (currentd == 1)
                {
                    köd += Convert.ToInt32(sonuçL.Text);
                }
                else if (currentd == 2)
                {
                    köd -= Convert.ToInt32(sonuçL.Text);
                }
                else if (currentd == 3)
                {
                    köd *= Convert.ToInt32(sonuçL.Text);
                }
                else if (currentd == 4)
                {
                    köd /= Convert.ToInt32(sonuçL.Text);
                }
            }
            sonuçL.Text = "";
            currentd = 1;
        }

        private void buttoneksi_Click(object sender, EventArgs e)
        {
            if (sonuçL.Text != string.Empty)
            {
                if (currentd == 0)
                {
                    köd = Convert.ToInt32(sonuçL.Text);
                }
                else if (currentd == 1)
                {
                    köd += Convert.ToInt32(sonuçL.Text);
                }
                else if (currentd == 2)
                {
                    köd -= Convert.ToInt32(sonuçL.Text);
                }
                else if (currentd == 3)
                {
                    köd *= Convert.ToInt32(sonuçL.Text);
                }
                else if (currentd == 4)
                {
                    köd /= Convert.ToInt32(sonuçL.Text);
                }
            }
            sonuçL.Text = "";
            currentd = 2;
        }

        private void buttonçarpı_Click(object sender, EventArgs e)
        {
            if (sonuçL.Text != string.Empty)
            {
                if (currentd == 0)
                {
                    köd = Convert.ToInt32(sonuçL.Text);
                }
                else if (currentd == 1)
                {
                    köd += Convert.ToInt32(sonuçL.Text);
                }
                else if (currentd == 2)
                {
                    köd -= Convert.ToInt32(sonuçL.Text);
                }
                else if (currentd == 3)
                {
                    köd *= Convert.ToInt32(sonuçL.Text);
                }
                else if (currentd == 4)
                {
                    köd /= Convert.ToInt32(sonuçL.Text);
                }
            }
            sonuçL.Text = "";
            currentd = 3;
        }

        private void buttonbölü_Click(object sender, EventArgs e)
        {
            if (sonuçL.Text != string.Empty)
            {
                if (currentd == 0)
                {
                    köd = Convert.ToInt32(sonuçL.Text);
                }
                else if (currentd == 1)
                {
                    köd += Convert.ToInt32(sonuçL.Text);
                }
                else if (currentd == 2)
                {
                    köd -= Convert.ToInt32(sonuçL.Text);
                }
                else if (currentd == 3)
                {
                    köd *= Convert.ToInt32(sonuçL.Text);
                }
                else if (currentd == 4)
                {
                    köd /= Convert.ToInt32(sonuçL.Text);
                }
            }
            sonuçL.Text = "";
            currentd = 4;
        }

        private void buttonesittir_Click(object sender, EventArgs e)
        {
            if (sonuçL.Text == string.Empty)
            {
                sonuçL.Text = köd.ToString();
            }
            else
            {
                if (currentd == 1)
                {
                    sonuçL.Text = Convert.ToString(köd += Convert.ToInt32(sonuçL.Text));
                }
                else if (currentd == 2)
                {
                    sonuçL.Text = Convert.ToString(köd -= Convert.ToInt32(sonuçL.Text));
                }
                else if(currentd == 3)
                {
                    sonuçL.Text = Convert.ToString(köd *= Convert.ToInt32(sonuçL.Text));
                }
                else if(currentd == 4)
                {
                    sonuçL.Text = Convert.ToString(köd /= Convert.ToInt32(sonuçL.Text));
                }
            }
            köd = 0;
            currentd = 0;
        }

        private void rstB_Click(object sender, EventArgs e)
        {
            sonuçL.Text = "";
            köd = 0;
            currentd = 0;
        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void kapamaB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void asagıB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sonuçL.Text == string.Empty)
            {
                sonuçL.Text = "";
            }
            else
            {
                sonuçL.Text = Convert.ToString(Convert.ToInt32(sonuçL.Text) * -1);
            }
        }
    }
}
