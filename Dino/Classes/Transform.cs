using System.Drawing;

namespace Dino.Classes
{
    public class Transform
    {
        public PointF position;
        public Size size;

        public Transform(PointF pos,Size size)
        {
            this.position = pos;
            this.size = size;
        }
    }
}
