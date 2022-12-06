﻿using System.Drawing;

namespace Dino.Classes
{
    public class Bird
    {
        public Transform transform;
        int frameCount = 0;
        int animationCount = 0;

        public Bird(PointF pos,Size size)
        {
            transform = new Transform(pos, size);
        }

        public void DrawSprite(Graphics g)
        {
            frameCount++;
            if (frameCount <= 10)
                animationCount = 0;
            else if (frameCount > 10 && frameCount <= 20)
                animationCount = 1;
            else if (frameCount > 20)
                frameCount = 0;
  

            g.DrawImage(GameController.spritesheet, new Rectangle(new Point((int)transform.position.X, (int)transform.position.Y), new Size(transform.size.Width, transform.size.Height)), 258+90*animationCount, 6, 84, 71, GraphicsUnit.Pixel);
        }
     
    }
}