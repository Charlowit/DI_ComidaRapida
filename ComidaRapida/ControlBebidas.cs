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
    public partial class ControlBebidas : UserControl
    {
        public ControlBebidas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bebidas bebida = new Bebidas();
            bebida.Nombre = "Lipton";
            bebida.Cantidad = 1;
            bebida.Precio = 3;

            Form1.carrito.Add(bebida);
            MessageBox.Show("Bebida agregada al carrito");
        }

        private void Añadir_Burguer_1_Click(object sender, EventArgs e)
        {
            Bebidas bebida = new Bebidas();
            bebida.Nombre = "Cocacola";
            bebida.Cantidad = 1;
            bebida.Precio = 3;

            Form1.carrito.Add(bebida);
            MessageBox.Show("Bebida agregada al carrito");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bebidas bebida = new Bebidas();
            bebida.Nombre = "Aquarius";
            bebida.Cantidad = 1;
            bebida.Precio = 3;

            Form1.carrito.Add(bebida);
            MessageBox.Show("Bebida agregada al carrito");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bebidas bebida = new Bebidas();
            bebida.Nombre = "Sprite";
            bebida.Cantidad = 1;
            bebida.Precio = 3;

            Form1.carrito.Add(bebida);
            MessageBox.Show("Bebida agregada al carrito");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bebidas bebida = new Bebidas();
            bebida.Nombre = "Cerveza";
            bebida.Cantidad = 1;
            bebida.Precio = 5;

            Form1.carrito.Add(bebida);
            MessageBox.Show("Bebida agregada al carrito");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bebidas bebida = new Bebidas();
            bebida.Nombre = "Cocacola";
            bebida.Cantidad = 1;
            bebida.Precio = 1.5;

            Form1.carrito.Add(bebida);
            MessageBox.Show("Bebida agregada al carrito");
        }
    }
}
