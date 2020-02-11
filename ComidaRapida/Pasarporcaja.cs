using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComidaRapida
{
    public partial class Pasarporcaja : Form
    {
        String precio;
        Random random = new Random();
        ControlCarrito carrito;

        public string Precio { get => precio; set => precio = value; }
        public ControlCarrito Carrito { get => carrito; set => carrito = value; }

        public Pasarporcaja()
        {
            InitializeComponent();
        }

        private void Pasarporcaja_Load(object sender, EventArgs e)
        {
            //random.Next(5, 30);
            this.label1.Text= "El tiempo estimado de entrega es de " +  random.Next(5, 30).ToString() + " minutos";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true)
            {
                MessageBox.Show("Pase por caja para pagar y recoger su pedido");
            }
            else if (this.radioButton2.Checked == true)
            {
                MessageBox.Show("Recoja su recibo y pase por caja a recoger su pedido");
            }
            Form1.carrito.Clear();
            ControlCarrito.contador = 0;
            this.Close();
            this.carrito.listView1.Clear();
            this.carrito.label3.Text = "";
        }
    }
}
