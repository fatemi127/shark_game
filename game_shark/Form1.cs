using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_shark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y - 10);
            }
            if (e.KeyData == Keys.Down)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + 10);
            }
            if (e.KeyData == Keys.Right)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X+10, pictureBox4.Location.Y);
            }
            if (e.KeyData == Keys.Left)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X-10, pictureBox4.Location.Y);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location== pictureBox2.Location)
            {
                pictureBox2.Visible = false;

            }
        }
    }
}
