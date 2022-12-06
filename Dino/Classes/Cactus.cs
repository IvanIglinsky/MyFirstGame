using System;
using System.Drawing;

namespace Dino.Classes
{
    public class Cactus
    {
        public Transform transform;
        int srcX = 0;
        int Width = 0;
        public Cactus(PointF pos,Size size)
        {
            transform = new Transform(pos, size);
            ChooseRandomPic();
        }

        public void ChooseRandomPic()
        {
            Random r = new Random();
            int rnd = r.Next(0, 6);
            switch (rnd)
            {
                case 0:
                    srcX = 739;
                    Width = 48;
                    break;
                case 1:
                    srcX = 789;
                    Width = 48;
                    break;
                case 2:
                    srcX = 691;
                    Width = 48;
                    break;
                case 3:
                    srcX = 643;
                    Width = 48;
                    break;
                case 4:
                    srcX = 836;
                    Width = 51;
                    break;
                case 5:
                    srcX = 836;
                    Width=100;
                    break;
            }
        }

        public void DrawSprite(Graphics g)
        {
            g.DrawImage(GameController.spritesheet, new Rectangle(new Point((int)transform.position.X, (int)transform.position.Y), new Size(transform.size.Width, transform.size.Height)), srcX, 0, Width, 100, GraphicsUnit.Pixel);
        }
    }
}
