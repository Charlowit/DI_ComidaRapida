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
    public partial class ControldePostres : UserControl
    {
        public ControldePostres()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento();
            elemento.Nombre = "McShacke";
            elemento.Cantidad = 1;
            elemento.Precio = 3;

            Form1.carrito.Add(elemento);
            MessageBox.Show("Postre agregado al carrito");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento();
            elemento.Nombre = "McFlurry";
            elemento.Cantidad = 1;
            elemento.Precio = 3;

            Form1.carrito.Add(elemento);
            MessageBox.Show("Postre agregado al carrito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento();
            elemento.Nombre = "Redondo";
            elemento.Cantidad = 1;
            elemento.Precio = 3;

            Form1.carrito.Add(elemento);
            MessageBox.Show("Postre agregado al carrito");
        }
    }
}
