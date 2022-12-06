using Dino.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dino
{
    public partial class Menu : Form
    {
        public Transform transform;
        readonly Game f1;
        readonly Skins f3;
        readonly Settings f4;
        public Menu(Game f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        public Menu(Skins f3)
        {
            InitializeComponent();
            this.f3 = f3;
        }
        public Menu(Settings f4)
        {
            InitializeComponent();
            this.f4 = f4;
        }
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Game f1 = new Game();
            Menu f2 = new Menu(f1);
            if (f1.ShowDialog() == DialogResult.Cancel)
            {
                f2.ShowDialog();
            }
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Стрибок вверх:\t W,Up,Space\nПригнутися:\t S,Down,Ctrl\nПауза:\t\t P\nПоновлення гри:\t F\nРестарт:\t\t R\n","Управління");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Skins f3 = new Skins();
            Menu f2 = new Menu(f3);
            if (f3.ShowDialog() == DialogResult.Cancel)
            {
                f2.ShowDialog();
            }
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Image image;
            Game f1 = new Game();
            Random r = new Random();
            int obj = r.Next(1, 11);
            switch (obj)
            {
                case 1:
                    image = Properties.Resources.colored_sprite;
                    GameController.Img(image);
                    break;
                case 2:
                    image = Properties.Resources.spiderman_sprite;
                    GameController.Img(image);
                    break;
                case 3:
                    image = Properties.Resources.Horror_sprite;
                    GameController.Img(image);
                    break;
                case 4:
                    image = Properties.Resources.Monke_sprite;
                    GameController.Img(image);
                    break;
                case 5:
                    image = Properties.Resources.Doom_sprite;
                    GameController.Img(image);
                    break;
                case 6:
                    image = Properties.Resources.red_colored_sprite;
                    GameController.Img(image);
                    break;
                case 7:
                    image = Properties.Resources.mario_sprite;
                    GameController.Img(image);
                    break;
                case 8:
                    image = Properties.Resources.sonic_sprite;
                    GameController.Img(image);
                    break;
                case 9:
                    image = Properties.Resources.mushrooms_sprite;
                    GameController.Img(image);
                    break;
                case 10:
                    image = Properties.Resources.Zelda;
                    GameController.Img(image);
                    break;
            }
            Hide();
            Menu f2 = new Menu(f1);
            if (f1.ShowDialog() == DialogResult.Cancel)
            {
                f2.ShowDialog();
            }
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
  
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Settings f4 = new Settings();
           
            Menu f2 = new Menu(f4);
            if (f4.ShowDialog() == DialogResult.Cancel)
            {
                f2.ShowDialog();
            }
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button1.ForeColor = Color.GreenYellow;
            button2.ForeColor = Color.GreenYellow;
            button3.ForeColor = Color.GreenYellow;
            button4.ForeColor = Color.GreenYellow;
            button5.ForeColor = Color.GreenYellow;
            button6.ForeColor = Color.GreenYellow;
            label2.ForeColor = Color.Red;
            BackgroundImage = Properties.Resources.fon_light;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.fon_bg;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button1.ForeColor = Color.Red;
            button2.ForeColor = Color.Red;
            button3.ForeColor = Color.Red;
            button4.ForeColor = Color.Red;
            button5.ForeColor = Color.Red;
            button6.ForeColor = Color.Red;
            label2.ForeColor = Color.Green;
        }
    }
}
