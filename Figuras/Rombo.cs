using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Figuras
{
    public class Rombo : Figura
    {
        public Rombo(int x, int y, int tam, Color color) : base(x, y, tam, color) { }

        public override void Draw(Graphics g)
        {
            var bb = GetBoundingBox();
            //acomodando los puntos gracias al boundingbox heredado de figura
            Point pTop = new Point(X, bb.Top);
            Point pRight = new Point(bb.Right, Y);
            Point pBottom = new Point(X, bb.Bottom);
            Point pLeft = new Point(bb.Left, Y);
            
            Point[] pts = new Point[] { pTop, pRight, pBottom, pLeft };

            using (Brush b = new SolidBrush(Color))
            using (Pen p = new Pen(Color.Black, 2))
            {
                g.FillPolygon(b, pts);
                g.DrawPolygon(p, pts);
            }
        }
    }
}

