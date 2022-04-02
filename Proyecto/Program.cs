using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto
{
    internal class Program
    {
      
        static void Main(string[] args)

        {
           //los precios de los boletos les asigne un valor simulando que ya esntan registrados en el sistema de un cine..

            Boleto boleto1 = new Boleto();
            Console.WriteLine("No de sala");
           boleto1.NoSala = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre de la pelicula");
            boleto1.Pelicula = (Console.ReadLine());
            Console.WriteLine("Cantidad de boletos de Adulto");
            boleto1.Bc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cantidad de boletos de Niño");
            boleto1.Bnc = Convert.ToInt32(Console.ReadLine());
            boleto1.Vendidos();

            Console.WriteLine("-------------- Compra de snacks---------- ");
            Console.WriteLine("Ingresa el precio de cada uno :............");
            double s1 =double.Parse( Console.ReadLine());
            double s2 = double.Parse(Console.ReadLine());
            double s3 = double.Parse(Console.ReadLine());
            double s4 = double.Parse(Console.ReadLine());



            Snacks snacks1 = new Snacks(4);

            Console.WriteLine("-----------Cantidad con la que relizara su pago------------- ");
            double pagar = double.Parse(Console.ReadLine());
            Console.WriteLine(snacks1.Compras(s1 + s2 + s3 + s4, pagar));


            Console.ReadKey();
            Menu();
            AgregarTexto();
            LeerDocumento();
            Console.ReadKey();



        }

        // En los ficheros solo se imprimira el ticket del boleto 
        static void Menu()
        {
            int opcion;
            opcion = 0;
            do
            {
                Console.WriteLine("***************CINEPOLIS, DELICIAS************");
                Console.WriteLine("----------------TICKET--------------------");
                Console.WriteLine("1.Venta Boletos");
                Console.WriteLine("2. Regitro de venta");
                Console.WriteLine("3. salir ");
                Console.WriteLine("opcion que se va a relizar ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        AgregarTexto();

                        break;
                    case 2:
                        LeerDocumento();
                        break;
                    case 3:
                        Console.WriteLine("--------OPCION FINALIZADA---------");
                        break;
                        
                    default:
                        Console.WriteLine("*************ERROR*******************");
                        break;
                }

            }
            while (opcion != 10000);
        }
        public static void AgregarTexto()
        {
            int Nosala;
            string Asiento;
            int Fila;
            string Pelicula;

            StreamWriter fichero;
            
            string nombrefichero = "C:\\Users\\qbren\\Documents\\Proyecto\\proyecto.txt";
            fichero = File.AppendText(nombrefichero);
            fichero.WriteLine();
            Console.WriteLine("FECHA:......");
            DateTime fecha = DateTime.Today;
            Console.WriteLine(fecha.ToString());
            Console.WriteLine("PELICULA:");
            Pelicula=Console.ReadLine();
            Console.WriteLine("Numero de sala");
            Nosala=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero de fila");
            Fila=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Asiento");
            Asiento = Console.ReadLine();
             
            fichero.WriteLine("FECHA:"+  fecha   +   "PELICULA: " +  Pelicula   +    "N° SALA:" +Nosala+  "N° Fila:" +  Fila  + "ASIENTO: "  + Asiento);
            fichero.Close();

        }
        public static void LeerDocumento()
        {
            StreamReader fichero;
            string nombrefichero = "C:\\Users\\qbren\\Documents\\Proyecto\\proyecto.txt";
            Console.WriteLine("FECHA:......");
            DateTime fecha = DateTime.Today;
            Console.WriteLine(fecha.ToString());
            string linea;
            fichero = File.OpenText(nombrefichero);
            do
            {linea= fichero.ReadLine(); 
                Console.WriteLine(linea);

            }
            while 
            (linea!=null);
            fichero.Close();
            Console.WriteLine();
            Console.ReadKey();

        }
        

    }
}

            
            


        

    

