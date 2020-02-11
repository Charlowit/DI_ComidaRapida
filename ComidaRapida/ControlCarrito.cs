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
    public partial class ControlCarrito : UserControl
    {
        public  double precio = 0.0;
        public static int contador = 0;
        public ControlCarrito()
        {
            InitializeComponent();
        }

        public void realizar_pedidos()
        {

            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;

            for (int i = 0; i < Form1.carrito.Count; i++)
            {
                Elemento aux = (Elemento)Form1.carrito[i];
                ListViewItem item = new ListViewItem(aux.Cantidad.ToString());
                // Place a check mark next to the item.
                item.SubItems.Add(aux.Nombre);
                item.SubItems.Add(aux.Precio.ToString());
                listView1.Items.Add(item);
                precio += aux.Precio;

            }

            this.label3.Text = precio.ToString() + " €";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Form1.carrito.RemoveAt(listView1.SelectedIndices[0]);
                listView1.Items.Remove(listView1.SelectedItems[0]);
                precio = 0;
                for (int i = 0; i < Form1.carrito.Count; i++)
                {
                    Elemento aux = (Elemento)Form1.carrito[i];
                    ListViewItem item = new ListViewItem(aux.Cantidad.ToString());
                    precio += aux.Precio;

                }

                this.label3.Text = precio.ToString() + " €";
                this.button1.Visible = false;
            }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            this.button1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.carrito.Count > 0)
            {
                Pasarporcaja pasarporcaja = new Pasarporcaja();
                pasarporcaja.Precio = "Total a pagar es : " + this.label2.Text;
                pasarporcaja.Carrito = this;
                pasarporcaja.Show();
            }
            else {
                MessageBox.Show("No se puede realizar el pedido sin ningún producto");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.precio < 0)
            {
                MessageBox.Show("No hay productos en el pedido");
            }

            else if (this.textBox1.Text.Equals("HOLA30") && contador == 0)
            {
                this.precio *= 0.9;
                this.label3.Text = precio.ToString() + " €";
                contador = 1;
            }
            else if (contador == 1)
            {
                MessageBox.Show("No puedes aplicar varios descuentos");
            }
            else
            {
                MessageBox.Show("No existe ese codigo de descuento");
            }
        }
    }
}
