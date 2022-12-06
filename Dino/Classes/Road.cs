using System;
using System.Drawing;

namespace Dino.Classes
{
    public class Road
    {
        public Transform transform;
        int srcX = 0;

        public Road(PointF pos, Size size)
        {
            transform = new Transform(pos, size);
            ChooseRandomPic();
        }

        public void ChooseRandomPic()
        {
            Random r = new Random();
            int rnd = r.Next(0, 4);
            switch (rnd)
            {
                case 0:
                    srcX = 100;
                    break;
                case 1:
                    srcX = 1420;
                    break;
                case 2:
                    srcX = 100;
                    break;
                case 3:
                    srcX = 100;
                    break;
            }
        }

        public void DrawSprite(Graphics g)
        {
            g.DrawImage(GameController.spritesheet, new Rectangle(new Point((int)transform.position.X, (int)transform.position.Y), new Size(transform.size.Width, transform.size.Height)), srcX, 105, 204, 17, GraphicsUnit.Pixel);
        }
    }
}
