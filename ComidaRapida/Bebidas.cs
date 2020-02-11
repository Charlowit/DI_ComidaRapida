using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidaRapida
{
    class Bebidas : Elemento
    {
        Boolean pequeña;
        Boolean mediano;
        Boolean grande;

        public Bebidas() {
            this.pequeña = false;
            this.mediano = false;
            this.grande = false;
        }

        public bool Pequeña { get => pequeña; set => pequeña = value; }
        public bool Mediano { get => mediano; set => mediano = value; }
        public bool Grande { get => grande; set => grande = value; }
    }
}
