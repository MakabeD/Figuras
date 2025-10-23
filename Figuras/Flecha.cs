using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figuras
{
    public class Flecha : Figura
    {
        public Flecha(int x, int y, int tam, Color color) : base(x, y, tam, color) { }

        public override void Draw(Graphics g)
        {
            int bodyWidth = (int)(Tam * 0.5);
            int headWidth = (int)(Tam * 0.5);
            int height = (int)(Tam * 0.4);
            if (height < 6) height = 6;

            int totalWidth = bodyWidth + headWidth;
            int left = X - totalWidth / 2;
            int top = Y - height / 2;

            Rectangle body = new Rectangle(left, top, bodyWidth, height);

            Point p1 = new Point(left + bodyWidth, Y - headWidth / 2); 
            Point p2 = new Point(left + bodyWidth + headWidth, Y); 
            Point p3 = new Point(left + bodyWidth, Y + headWidth / 2); 

            Point[] head = new Point[] { p1, p2, p3 };

            using (Brush b = new SolidBrush(Color))
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.FillRectangle(b, body);
                g.DrawRectangle(pen, body);
                g.FillPolygon(b, head);
                g.DrawPolygon(pen, head);
            }
        }

        public override Rectangle GetBoundingBox()
        {
            int bodyWidth = (int)(Tam * 0.5);
            int headWidth = (int)(Tam * 0.5);
            int height = (int)(Tam * 0.4);
            int totalW = bodyWidth + headWidth;
            return new Rectangle(X - totalW / 2, Y - height / 2, totalW, height);
        }
    }
}
