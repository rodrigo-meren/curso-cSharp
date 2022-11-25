using System;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //            4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            // - Número de Artículo (1 a 15)
            // - Cantidad Vendida

            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // // b) Los números de artículos que no registraron ventas.
            // // c) Cuantas unidades se vendieron del número de artículo 10.
            int[] registro = new int[15];
            int art,cantidad;

             for (var i = 0; i < 15; i++)
            {
                registro[i]=0;
            }

            Console.WriteLine("ingrese el numero de articulo: ");
            art = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad vendida: ");
            cantidad = int.Parse(Console.ReadLine());

           
            while (art != 0)
            {
                              
                registro[art-1] += cantidad;
                
                Console.WriteLine("ingrese el numero de articulo: ");
                art = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la cantidad vendida: ");
                cantidad = int.Parse(Console.ReadLine());
            }
            int totalVenta = registro[0];
            int máximo=1;
            for (var i = 0; i < 15; i++)
            {
               
            }
            if (registro[9] > 0)
                Console.WriteLine("El articulo 10 tuvo " + registro[9] + " ventas");
            else
                Console.WriteLine("El articulo 10 no tuvo ventas");

            Console.WriteLine("El articulo que mas ventas tuvo fue el: " + mayor);
            
            if(cont ==0)
            Console.WriteLine("Ningun articulo no tuvo ventas");
                
        }
    }
}
