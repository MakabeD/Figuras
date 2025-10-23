using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Figuras
{
    public partial class Form1 : Form
    {
        
        private List<Figura> figuras = new List<Figura>();
        private Color? colorSeleccionado = null;

        public Form1()
        {
            InitializeComponent();
            InicializarValores();
            
            pbLienzo.Paint += PbLienzo_Paint;
            
            pbLienzo.Resize += (s, e) => pbLienzo.Invalidate();
        }

        private void InicializarValores()
        {
            cmbFigura.Items.Clear();
            cmbFigura.Items.Add("Rombo");
            cmbFigura.Items.Add("Trapecio Isósceles");
            cmbFigura.Items.Add("Semicírculo");
            cmbFigura.Items.Add("Flecha");
            cmbFigura.SelectedIndex = 0;

            nudX.Minimum = 0;
            nudY.Minimum = 0;
            nudTamaño.Minimum = 1;
            txtContador.ReadOnly = true;
            txtContador.Text = "0";
        }

        private void PbLienzo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            foreach (var f in figuras)
            {
                f.Draw(g);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorSeleccionado = colorDialog1.Color;
                pbColor.BackColor = colorDialog1.Color;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (colorSeleccionado == null)
                {
                    MessageBox.Show("Selecciona un color antes de crear la figura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tipo = cmbFigura.SelectedItem.ToString();
                int x = (int)nudX.Value;
                int y = (int)nudY.Value;
                int tam = (int)nudTamaño.Value;

                // verificanp tamaño > 0 (factory ya valida), y figura dentro del lienzo
                Figura temp = FiguraFactory.Create(tipo, x, y, tam, colorSeleccionado.Value);

                //validando si el bounding box queda dentro de pbLienzo
                Rectangle bb = temp.GetBoundingBox();
                Rectangle canvasRect = new Rectangle(0, 0, pbLienzo.Width, pbLienzo.Height);

                if (!canvasRect.Contains(bb))
                {
                    MessageBox.Show("Posición fuera de rango: la figura no cabe completamente dentro del lienzo.", "Error de posición", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                figuras.Add(temp);
                txtContador.Text = figuras.Count.ToString();
                pbLienzo.Invalidate(); 
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            figuras.Clear();
            txtContador.Text = "0";
            pbLienzo.Invalidate();
        }
    }
}

