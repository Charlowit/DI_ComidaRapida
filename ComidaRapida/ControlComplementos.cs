using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComidaRapida
{
    public partial class ControlComplementos : UserControl
    {
        public ControlComplementos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento();
            elemento.Nombre = "Alitas de pollo";
            elemento.Cantidad = 1;
            elemento.Precio = 2;

            Form1.carrito.Add(elemento);
            MessageBox.Show("Complemento agregado al carrito");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento();
            elemento.Nombre = "McBites";
            elemento.Cantidad = 1;
            elemento.Precio = 2;

            Form1.carrito.Add(elemento);
            MessageBox.Show("Complemento agregado al carrito");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento();
            elemento.Nombre = "Patatas Fritas";
            elemento.Cantidad = 1;
            elemento.Precio = 2;

            Form1.carrito.Add(elemento);
            MessageBox.Show("Complemento agregado al carrito");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento();
            elemento.Nombre = "Patatas Deluxe";
            elemento.Cantidad = 1;
            elemento.Precio = 2;

            Form1.carrito.Add(elemento);
            MessageBox.Show("Complemento agregado al carrito");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento();
            elemento.Nombre = "Top Fries";
            elemento.Cantidad = 1;
            elemento.Precio = 2;

            Form1.carrito.Add(elemento);
            MessageBox.Show("Complemento agregado al carrito");
        }
    }
}
