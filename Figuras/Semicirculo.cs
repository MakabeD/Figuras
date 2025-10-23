using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Figuras
{
    public class Semicirculo : Figura
    {
        public Semicirculo(int x, int y, int tam, Color color) : base(x, y, tam, color) { }

        public override void Draw(Graphics g)
        {
            int width = Tam;
            int height = Tam;
            int left = X - width / 2;
            int top = Y - height / 2;

            Rectangle rect = new Rectangle(left, top, width, height);
            using (Brush b = new SolidBrush(Color))
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.FillPie(b, rect, 180, 180); 
                g.DrawArc(pen, rect, 180, 180);
            }
        }

        public override Rectangle GetBoundingBox()
        {
            int half = Tam / 2;
            return new Rectangle(X - half, Y - half, Tam, Tam);
        }
    }
}
