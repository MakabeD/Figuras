using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Figuras
{
    public class TrapecioIsosceles : Figura
    {
        public TrapecioIsosceles(int x, int y, int tam, Color color) : base(x, y, tam, color) { }

        public override void Draw(Graphics g)
        {
            
            int topWidth = (int)(Tam * 0.6);
            int bottomWidth = Tam;
            int height = (int)(Tam * 0.7);

            Point topLeft = new Point(X - topWidth / 2, Y - height / 2);
            Point topRight = new Point(X + topWidth / 2, Y - height / 2);
            Point bottomRight = new Point(X + bottomWidth / 2, Y + height / 2);
            Point bottomLeft = new Point(X - bottomWidth / 2, Y + height / 2);

            Point[] pts = new Point[] { topLeft, topRight, bottomRight, bottomLeft };
            using (Brush b = new SolidBrush(Color))
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.FillPolygon(b, pts);
                g.DrawPolygon(pen, pts);
            }
        }
        public override Rectangle GetBoundingBox()
        {
            //ajustando bounding box para la altura real
            int height = (int)(Tam * 0.7);
            int halfW = Tam / 2;
            return new Rectangle(X - halfW, Y - height / 2, Tam, height);
        }


    }
}

