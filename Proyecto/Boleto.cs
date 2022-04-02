using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Boleto:Venta
    {
        public override void Vendidos()
        {
            base.Vendidos();
            Console.WriteLine("Boleto: ({0},{1})",NoSala,Pelicula);
        }




    }
}
