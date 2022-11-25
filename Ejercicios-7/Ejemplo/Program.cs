using System;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Vectores, array,arreglo.

            // int a;
            // int[] numeros = new int[10];
             

            //  for(int i =0; i<10; i++){
            //     Console.WriteLine("numero:");
            //     a = int.Parse(Console.ReadLine());
            //     numeros[i] = a;
            //  }

            // int acu =0, prom=0;
             
            //  for (var i = 0; i <10; i++)
            //  {
            //     acu+= numeros[i];
            //  }
            //  prom = acu/10;

            //  Console.WriteLine(prom);


//----------------------------------------------------------------

//vectores con doble.

double[] mañana = new double[31];

int dia;
double temp;
Console.WriteLine("registro mañana:");
for (var i = 0; i < 31; i++){

    Console.WriteLine("Ingrese el día; ");
    dia = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la temperatura; ");
    temp = int.Parse(Console.ReadLine());

mañana[dia-1] = temp;

}


//leer vector
double acu=0;



        }
    }
}
