using System;

namespace TpFinal_Meren
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.
            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.
            int
                n,
                primos,
                contPrimo = 0;
            Console.WriteLine("Escriba un número: ");
            n = int.Parse(Console.ReadLine());
            bool banPar = false;
            int mayorPar = 0;
            int impar = 0;
            int menorPrimo = 0;

            while (n != 0)
            {
                if (n % 2 == 0)
                {
                    if (banPar == false)
                    {
                        mayorPar = n;
                        banPar = true;
                    }
                    else if (n > mayorPar) mayorPar = n;
                }
                else
                {
                    impar++;
                }
                primos = primo(n);
                if (primos == 1) contPrimo++;
                if (contPrimo == 1)
                    menorPrimo = n;
                else if (n < menorPrimo) menorPrimo = n;

                Console.WriteLine("Escriba un número: ");
                n = int.Parse(Console.ReadLine());
            }
            Console
                .WriteLine("El mayor de los números pares es: " +
                mayorPar +
                ", la cantidad de números impares es: " +
                impar +
                " y el menor de los números primos es: " +
                menorPrimo);
        }

        static int primo(int n)
        {
            int contador;
            contador = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) contador++;
            }
            if (contador == 2)
                return 1;
            else
                return 0;
        }
    }
}
