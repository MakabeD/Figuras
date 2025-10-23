using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figuras
{
    public static class FiguraFactory
    {
        
        public static Figura Create(string tipo, int x, int y, int tam, Color color)
        {
            if (tam <= 0)
                throw new ArgumentException("Tamaño inválido. Debe ser mayor que 0.", nameof(tam));

            switch (tipo)
            {
                case "Rombo":
                    return new Rombo(x, y, tam, color);
                case "Trapecio Isósceles":
                case "Trapecio":
                    return new TrapecioIsosceles(x, y, tam, color);
                case "Semicírculo":
                case "Semicirculo":
                    return new Semicirculo(x, y, tam, color);
                case "Flecha":
                    return new Flecha(x, y, tam, color);
                default:
                    throw new ArgumentException("Tipo de figura no reconocido: " + tipo);
            }
        }
    }
}
