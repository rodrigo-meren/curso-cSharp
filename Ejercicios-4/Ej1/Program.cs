﻿using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

            // La resta si el primero es mayor que el segundo.
            // La suma si son iguales.
            // El producto si el primero es menor.
            // Se deberá emitir un cartel por pantalla con el resultado correspondiente.
            int num1,num2,resultado;
   
            Console.WriteLine("ingrese un numero: ");           
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese otro numero: ");
            num2 = int.Parse(Console.ReadLine());
            if(num1 == num2)
            resultado = num1 + num2;
             else if (num1>num2)
                resultado = num1 - num2;
             else  
                resultado = num1*num2;
            
                Console.WriteLine("El resultado es: " + resultado);
  

        }
    }
}
