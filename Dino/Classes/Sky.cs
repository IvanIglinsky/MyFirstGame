using System.Drawing;

namespace Dino.Classes
{
    public class Sky
    {
        public Transform transform;
        int srcX = 0;

        public Sky(PointF pos, Size size)
        {
            transform = new Transform(pos, size);
            srcX = 165;
        }
        public void DrawSprite(Graphics g)
        {
            g.DrawImage(GameController.spritesheet, new Rectangle(new Point((int)transform.position.X, (int)transform.position.Y), new Size(transform.size.Width, transform.size.Height)), srcX, 0,92, 28, GraphicsUnit.Pixel);
        }
    }
}
