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
    public partial class ControlHamburguesas : UserControl
    {
        public ControlHamburguesas()
        {
            InitializeComponent();
        }

        private void Añadir_Burguer_1_Click(object sender, EventArgs e)
        {
            Hamburguesa hamburguesa = new Hamburguesa();
            hamburguesa.Nombre = "Big Mac";
            hamburguesa.Precio = 10;
            hamburguesa.Cantidad = 1;
            PersonalizarHamburguesa personalizarhamburgesa = new PersonalizarHamburguesa();
            personalizarhamburgesa.Hamburguesa = hamburguesa;

            ((PictureBox)personalizarhamburgesa.Controls["pictureBox1"]).Image = this.pictureBox1.Image;

            personalizarhamburgesa.Show();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hamburguesa hamburguesa = new Hamburguesa();
            hamburguesa.Nombre = "Bacon Extreme";
            hamburguesa.Precio = 8;
            hamburguesa.Cantidad = 1;
            PersonalizarHamburguesa personalizarhamburgesa = new PersonalizarHamburguesa();
            personalizarhamburgesa.Hamburguesa = hamburguesa;

            ((PictureBox)personalizarhamburgesa.Controls["pictureBox1"]).Image = this.pictureBox2.Image;

            personalizarhamburgesa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hamburguesa hamburguesa = new Hamburguesa();
            hamburguesa.Nombre = "CBO";
            hamburguesa.Precio = 12;
            hamburguesa.Cantidad = 1;
            PersonalizarHamburguesa personalizarhamburgesa = new PersonalizarHamburguesa();
            personalizarhamburgesa.Hamburguesa = hamburguesa;

            ((PictureBox)personalizarhamburgesa.Controls["pictureBox1"]).Image = this.pictureBox3.Image;

            personalizarhamburgesa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hamburguesa hamburguesa = new Hamburguesa();
            hamburguesa.Nombre = "Cuarto de Libra";
            hamburguesa.Precio = 11;
            hamburguesa.Cantidad = 1;
            PersonalizarHamburguesa personalizarhamburgesa = new PersonalizarHamburguesa();
            personalizarhamburgesa.Hamburguesa = hamburguesa;

            ((PictureBox)personalizarhamburgesa.Controls["pictureBox1"]).Image = this.pictureBox4.Image;

            personalizarhamburgesa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hamburguesa hamburguesa = new Hamburguesa();
            hamburguesa.Nombre = "McRoyal Deluxe";
            hamburguesa.Precio = 15;
            hamburguesa.Cantidad = 1;
            PersonalizarHamburguesa personalizarhamburgesa = new PersonalizarHamburguesa();
            personalizarhamburgesa.Hamburguesa = hamburguesa;

            ((PictureBox)personalizarhamburgesa.Controls["pictureBox1"]).Image = this.pictureBox4.Image;

            personalizarhamburgesa.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hamburguesa hamburguesa = new Hamburguesa();
            hamburguesa.Nombre = "McPollo";
            hamburguesa.Precio = 7;
            hamburguesa.Cantidad = 1;
            PersonalizarHamburguesa personalizarhamburgesa = new PersonalizarHamburguesa();
            personalizarhamburgesa.Hamburguesa = hamburguesa;

            ((PictureBox)personalizarhamburgesa.Controls["pictureBox1"]).Image = this.pictureBox4.Image;

            personalizarhamburgesa.Show();
        }
    }
}
