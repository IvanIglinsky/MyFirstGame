using System;
using System.Windows.Forms;
using Dino.Classes;

namespace Dino
{
    public partial class Skins : Form
    {
        public Skins()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameController.spritesheet = Properties.Resources.colored_sprite;
            label2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameController.spritesheet = Properties.Resources.spiderman_sprite;
            label2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameController.spritesheet = Properties.Resources.Horror_sprite;
            label2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GameController.spritesheet = Properties.Resources.Monke_sprite;
            label2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GameController.spritesheet = Properties.Resources.Doom_sprite;
            label2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GameController.spritesheet = Properties.Resources.red_colored_sprite;
            label2.Visible = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            GameController.spritesheet = Properties.Resources.mario_sprite;
            label2.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GameController.spritesheet = Properties.Resources.sonic_sprite;
            label2.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GameController.spritesheet = Properties.Resources.mushrooms_sprite;
            label2.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GameController.spritesheet = Properties.Resources.Zelda;
            label2.Visible = true;
        }

 
    }
}
