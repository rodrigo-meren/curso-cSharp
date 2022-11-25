using System;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

            int n,contador=0;
          
            Console.WriteLine("Escriba un número:");
                n= int.Parse(Console.ReadLine());
            for(int i = 2; i<=n;i++){
                

                if (n % i == 0)
                contador++;
               
            }
            if(contador ==1)
            Console.WriteLine("Es Primo");
                else
                Console.WriteLine("No es primo");
        }
    }
}
