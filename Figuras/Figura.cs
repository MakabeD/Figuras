using System.Drawing;

namespace Figuras
{
    public abstract class Figura
    {
        //encapsulando 
        private int x;
        private int y;
        private int tam;
        private Color color;

        public int X => x;
        public int Y => y;
        public int Tam => tam;
        public Color Color => color;

        //el constructor protegido para que solo subclases o factory la instancien
        protected Figura(int x, int y, int tam, Color color)
        {
            this.x = x;
            this.y = y;
            this.tam = tam;
            this.color = color;
        }
        public abstract void Draw(Graphics g);
        public virtual Rectangle GetBoundingBox()
        {
            int half = tam / 2;
            return new Rectangle(X - half, Y - half, tam, tam);
        }
    }
}
