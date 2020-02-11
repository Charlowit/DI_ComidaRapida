using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidaRapida
{
    class Hamburguesa : Elemento
    {
        Boolean lechuga;
        Boolean tomate;
        Boolean cebolla;
        public Hamburguesa() {

            this.lechuga = false;
            this.tomate = false;
            this.cebolla = false;

        }

        public bool Lechuga { get => lechuga; set => lechuga = value; }
        public bool Tomate { get => tomate; set => tomate = value; }
        public bool Cebolla { get => cebolla; set => cebolla = value; }
    }
}
