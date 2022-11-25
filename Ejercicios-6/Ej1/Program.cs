using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
            int n, contador, primos=0;

            for(int i=0;i<3;i++){
                Console.WriteLine("ingrese un número:");
                n = int.Parse(Console.ReadLine());
                contador=0;
                for(int x=2;x<=n;x++){
                    if(n % x == 0)
                    contador++;
                    
                }
                if(contador==1)
                primos++;
            }
            
            Console.WriteLine("la cantidad de números primos es: " + primos);
        }
    }
}
