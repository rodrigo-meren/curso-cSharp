﻿using System;

namespace Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .

            int n1,n2,n3,n4;
            Console.WriteLine("Escriba un número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba un número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba un número");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba un número");
            n4 = int.Parse(Console.ReadLine());

            if(n1>n2 && n2>n3 && n3>n4)
            Console.WriteLine("Los númeroes estan ordenados de forma decreciente");
            else
            Console.WriteLine("Los númeroes no estan ordenados de forma decreciente");
        }
    }
}
