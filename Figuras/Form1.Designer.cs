namespace Figuras
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbFigura;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.NumericUpDown nudTamaño;
        private System.Windows.Forms.PictureBox pbLienzo;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColor;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbFigura = new System.Windows.Forms.ComboBox();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudTamaño = new System.Windows.Forms.NumericUpDown();
            this.pbLienzo = new System.Windows.Forms.PictureBox();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamaño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLienzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            this.SuspendLayout();

            
            this.cmbFigura.Location = new System.Drawing.Point(12, 12);
            this.cmbFigura.Size = new System.Drawing.Size(180, 24);

            this.nudX.Location = new System.Drawing.Point(12, 50);
            this.nudX.Maximum = 2000;
            this.nudX.Size = new System.Drawing.Size(80, 22);

            this.nudY.Location = new System.Drawing.Point(110, 50);
            this.nudY.Maximum = 2000;
            this.nudY.Size = new System.Drawing.Size(80, 22);

            this.nudTamaño.Location = new System.Drawing.Point(12, 88);
            this.nudTamaño.Maximum = 2000;
            this.nudTamaño.Size = new System.Drawing.Size(80, 22);

            this.btnColor.Location = new System.Drawing.Point(110, 84);
            this.btnColor.Size = new System.Drawing.Size(82, 28);
            this.btnColor.Text = "Color";
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);

            this.pbColor.Location = new System.Drawing.Point(200, 84);
            this.pbColor.Size = new System.Drawing.Size(36, 28);
            this.pbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnCrear.Location = new System.Drawing.Point(12, 130);
            this.btnCrear.Size = new System.Drawing.Size(80, 30);
            this.btnCrear.Text = "Crear";
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);

            this.btnLimpiar.Location = new System.Drawing.Point(110, 130);
            this.btnLimpiar.Size = new System.Drawing.Size(80, 30);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.txtContador.Location = new System.Drawing.Point(200, 134);
            this.txtContador.Size = new System.Drawing.Size(60, 22);

            this.pbLienzo.Location = new System.Drawing.Point(12, 180);
            this.pbLienzo.Size = new System.Drawing.Size(600, 380);
            this.pbLienzo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLienzo.BackColor = System.Drawing.Color.White;

            // Form
            this.ClientSize = new System.Drawing.Size(640, 580);
            this.Controls.Add(this.cmbFigura);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudTamaño);
            this.Controls.Add(this.pbColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.pbLienzo);
            this.Text = "Figuras - POO y Factory";
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamaño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLienzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

