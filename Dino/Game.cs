using Dino.Classes;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Dino
{
    public partial class Game : Form
    {
        Player player;
        public Transform transform;
        Timer mainTimer;
        public int MaxScore;
        public bool Chek1
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool Chek2
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public Game()
        {
            InitializeComponent();
            
            this.Width = 700;
            this.Height = 300;
            this.DoubleBuffered = true;

            this.Paint += new PaintEventHandler(DrawGame);
            this.KeyUp += new KeyEventHandler(OnKeyboardUp);
            this.KeyDown += new KeyEventHandler(OnKeyboardDown);
            mainTimer = new Timer();
            mainTimer.Interval = 10;
            mainTimer.Tick += new EventHandler(Update);
            Init();
        }
        

        private void OnKeyboardDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.S:
                case Keys.ControlKey:
                    if (!player.physics.isJumping)
                    {
                        player.physics.isCrouching = true;
                        player.physics.isJumping = false;
                        player.physics.transform.size.Height = 25;
                        player.physics.transform.position.Y = 181;
                    }
                    break;
            }
        }

        public void OnKeyboardUp(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyCode)
            {
                
                case Keys.Up:
                case Keys.W:
                case Keys.Space:
                    if (!player.physics.isCrouching)
                    {
                        if (Chek2 == true)
                            GameController.soundplayer.Stop();
                        else
                            GameController.soundplayer.Play();
                        player.physics.isCrouching = false;
                        player.physics.AddForce();
                    }
                    break;
                case Keys.Down:
                case Keys.S:
                case Keys.ControlKey:
                    player.physics.isCrouching = false;
                    player.physics.transform.size.Height = 50;
                    player.physics.transform.position.Y = 159.2f;
                    break;
                case Keys.R:
                    Init();
                    break;
                case Keys.P:
                    mainTimer.Stop();
                    break;
                case Keys.F:
                    mainTimer.Start();
                    break;

            }
        }
        public void Init()
        {
            GameController.Init();
            player = new Player(new PointF(50, 159), new Size(50, 50));
            mainTimer.Start();
            Invalidate();      
            BackColor = Color.White;
            label1.ForeColor = Color.Red;
            label3.ForeColor = Color.Red;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label5.Visible = false;
        }
        public void Update(object sender , EventArgs e)
        {
            player.score++;
            label1.Text = "Score: " + player.score/10;
            if (player.score/10 > MaxScore)
            {
                MaxScore = (player.score/10);             
            }    
            if ((player.score/10) % 100 == 0)
            {
               
                label1.Text = "Score: " + player.score/10;
                label1.ForeColor = Color.Red;
             
            }
          
            if ((player.score/10) % 100 != 0)
                    label1.ForeColor = Color.Black;
         
            label3.Text="Max Score: "+ MaxScore;
            if (player.physics.Collide())
            {
                mainTimer.Stop();
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
              
            }
            player.physics.ApplyPhysics();
            int scorecount = 0;
           
            GameController.MoveMap();
            if (player.score / 10 > 100)
            {
                scorecount=0;
                GameController.MoveMap();
                player.score++;
                label5.Visible = true;
                label5.Text = "Speed:X2";
                label5.ForeColor = Color.Red;
            }
           
            if (player.score / 10 > 1000)
            {
                GameController.MoveMap();
                label5.Visible = true;
                label5.Text = "Speed++";
                player.score++;
                label5.ForeColor = Color.Red;
            }
            if (player.score / 10 > 110&&player.score/10<1000 || player.score/10>1010)
                label5.Visible = false;
            if (Chek1 == true)
            {
                label1.ForeColor = Color.GreenYellow;
                BackColor = Color.Black;
            }
         
            else
            {
                for (int i = 0; i < 100000; i += 200)
                {
                    if ((player.score / 10 / 200) % 2 == 0)
                    {
                        scorecount = 0;

                    }
                    if ((player.score / 10 / 200) % 2 != 0)
                        scorecount = 1;
                }

                
                if (scorecount == 1)
                {
                    BackColor = Color.Black;
                    label1.ForeColor = Color.GreenYellow;
                    label3.ForeColor = Color.Red;
                }

                if (scorecount == 0)
                {
                    BackColor = Color.White;
                    label1.ForeColor = Color.Black;
                    label3.ForeColor = Color.Red;
                }
            }
            Invalidate();
        }
        private void DrawGame(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            player.DrawSprite(g);
            GameController.DrawObjets(g);
        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.DrawImage(GameController.spritesheet, new Rectangle(new Point(0, 0), new Size(65, 60)), 3, 3, 70, 60, GraphicsUnit.Pixel);

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Init();
            pictureBox2.Visible = false;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(GameController.spritesheet, new Rectangle(new Point(0, 0), new Size(375, 30)), 1271, 28, 378, 30, GraphicsUnit.Pixel);
        }
    }
}
