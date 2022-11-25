using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

        int n;
        int[]  num= new int[10];

        for (var i = 0; i < 10; i++)
        {
            Console.WriteLine("Escriba el número: ");
            n = int.Parse(Console.ReadLine());
            num[i] =n;
        }
        int acu=0, promedio=0;

        for (var i = 0; i < 10; i++)
        {
             acu += num[i];
        }
        promedio = acu/10;
 
            Console.Write("los siguientes números son mayores al promedío: ");
        for (var i = 0; i < 10; i++)
        {
            if(num[i]>promedio)
            Console.Write(" " +num[i]+" ");
        }

        



        }
    }
}
