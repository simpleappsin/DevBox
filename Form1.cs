using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool dark = true;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Cursor cr = Cursors.Hand;
            this.Cursor = cr;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor cr = Cursors.Default;
            this.Cursor = cr;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Python py = new Python();
            py.ShowDialog();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(31, 32, 32);
            bunifuTileButton1.BackColor = Color.FromArgb(50, 62, 70);
            bunifuTileButton4.BackColor = Color.FromArgb(50, 62, 70);
            dark = true;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            bunifuTileButton1.BackColor = Color.FromArgb(70, 50, 70);
            bunifuTileButton4.BackColor = Color.FromArgb(70, 50, 70);
            dark = false;
        }

        private void bunifuTileButton4_MouseEnter(object sender, EventArgs e)
        {
            if(dark == true)
            {
                bunifuTileButton4.BackColor = Color.FromArgb(31, 32, 32);
            }else if(dark == false)
            {
                bunifuTileButton4.BackColor = Color.FromArgb(75,55,75);
            }
        }

        private void bunifuTileButton4_MouseLeave(object sender, EventArgs e)
        {
            if (dark == true)
            {
                bunifuTileButton4.BackColor = Color.FromArgb(50, 62, 70);
            }
            else if (dark == false)
            {
                bunifuTileButton4.BackColor = Color.FromArgb(70, 50, 70);
            }
        }

        private void bunifuTileButton1_MouseEnter(object sender, EventArgs e)
        {
            if (dark == true)
            {
                bunifuTileButton1.BackColor = Color.FromArgb(31, 32, 32);
            }
            else if (dark == false)
            {
                bunifuTileButton1.BackColor = Color.FromArgb(75, 55, 75);
            }
        }

        private void bunifuTileButton1_MouseLeave(object sender, EventArgs e)
        {
            if (dark == true)
            {
                bunifuTileButton1.BackColor = Color.FromArgb(50, 62, 70);
            }
            else if (dark == false)
            {
                bunifuTileButton1.BackColor = Color.FromArgb(70, 50, 70);
            }
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            CSharp csharp = new CSharp();
            csharp.ShowDialog();
        }
    }
}
