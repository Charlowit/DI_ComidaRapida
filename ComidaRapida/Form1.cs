using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public static ArrayList carrito;
        public Form1()
        {
            InitializeComponent();
            carrito = new ArrayList();
            controlInicio1.BringToFront();
            ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(button2, "Carrito");
            toolTip1.IsBalloon = true;
            toolTip1.InitialDelay = 500000;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.controlHamburguesas1.BringToFront();
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            this.controlBebidas1.BringToFront();
        }

        private void btnComplementos_Click(object sender, EventArgs e)
        {
            this.controlComplementos1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.controldePostres1.BringToFront();
        }

        private void pictureCarrito_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.controlCarrito1.realizar_pedidos();
            this.controlCarrito1.BringToFront();
        }
    }
}
