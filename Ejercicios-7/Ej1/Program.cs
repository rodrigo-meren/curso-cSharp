using System;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
            int n;
            int[] num = new int[10];

            for (var i = 0; i  <10; i++)
            {
                Console.WriteLine("escriba el numero:");
                n = int.Parse(Console.ReadLine());
                num[i] =n;
            }
           int max=0,pos=0;
            for (var i = 0; i < 10; i++)
            {
                if(num[i] >max){
                    max = num[i];
                    pos= i+=1;
                }

                Console.WriteLine("el maximo es: " + max + " y se encunetra en la poscíon " + pos);

            }
        }
    }
}
