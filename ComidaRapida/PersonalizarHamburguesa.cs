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
    public partial class PersonalizarHamburguesa : Form
    {
        Hamburguesa hamburguesa = new Hamburguesa();
        public PersonalizarHamburguesa()
        {
            InitializeComponent();
            

        }

        internal Hamburguesa Hamburguesa { get => hamburguesa; set => hamburguesa = value; }

        private void PersonalizarHamburguesa_Load(object sender, EventArgs e)
        {
            this.label1.Text = hamburguesa.Nombre;
            this.label2.Text = hamburguesa.Precio.ToString() + "€";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) {
                hamburguesa.Lechuga = true;
            }
            if (checkBox2.Checked == true) {
                hamburguesa.Tomate = true;
            }
            if (checkBox3.Checked == true) {
                hamburguesa.Cebolla = true;
            }

            Form1.carrito.Add(hamburguesa);
            MessageBox.Show("Hamburguesa añadida al carrito");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este alimento contiene gluten, y puede contener trazas de huevo");
        }
    }
}
