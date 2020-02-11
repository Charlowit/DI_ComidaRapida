using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidaRapida
{
    class Elemento
    {
        int id;
        String nombre;
        Double precio;
        int cantidad;

        public Elemento() {
            this.nombre = "";
            precio = 0.0;
            cantidad = 0;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
