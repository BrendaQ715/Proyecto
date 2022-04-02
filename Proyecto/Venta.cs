using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Venta
    {

        public double Adulto { get; set; }
        public double Niño { get; set; }
        public int NoSala { get; set; }
        

        public string Pelicula { get; set; }
        public int Bc { get; set; }
        public int Bnc { get; set; }

        public Venta()
        {
            this.Adulto = 50.25;
            this.Niño = 37;
           
            
            
        // Venta de boletos de niño y adulto .....
        // Bc= cantidad de boletos de adulto comprados....
        // Bcn= cantidad de boletos de niño comprados..


        }
        public virtual void Vendidos()
        {
          
            Console.WriteLine("la compra de los boletos  de adulto" +"$"+ (Adulto * Bc)+"PESOS");
            Console.WriteLine("la compra de los boletos  de Niño" + "$" +(Niño * Bnc)+ "PESOS");


        }
       









    }
}
