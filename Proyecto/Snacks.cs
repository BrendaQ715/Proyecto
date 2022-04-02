using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Snacks
    {
        public int ID { get; set; }
  

        public Snacks(int ID)
        {
            this.ID = ID;
         

        }
        
        //registro de compra de palomitas y refrescos (snacks)
       
        public  string  Compras(double s1, double pagar)
        {
            Console.WriteLine("Tu compra es de "+s1+ "pesos");
            {
                { return "Tu cambio es de " + (pagar -   s1)+"pesos"; }
            }

        }
        public  string Compras(double s1,double s2, double pagar)
        {
            Console.WriteLine("Tu compra es de " + (s1+s2)+"pesos");
            {
                { return "Tu cambio es de " + (pagar - (s1 + s2 ))+ "pesos"; }
            }

        }
        public string Compras(double s1, double s2,double s3, double pagar)
        {
            Console.WriteLine("Tu compra es de " + (s1 + s2+s3)+"pesos ");
            {
                { return "Tu cambio es de " + (pagar - (s1 + s2 + s3 ))+"pesos "; }
            }

        }

       

        public   string Compras(double s1, double s2, double s3,double s4,double pagar)
        {
            Console.WriteLine("Tu compra es de " + (s1 + s2 + s3+s4)+ "pesos");
            {
                { return "Tu cambio es de " + (pagar - (s1 + s2 + s3 + s4 )+"pesos"); }
            }

       }

       


      
    }
    
}
