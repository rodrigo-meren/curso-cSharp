using System;

namespace Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

            int n, pares=0, impares=0;
            int contpar=0,contimpar=0;
            for(int i = 0; i<5;i++){
                Console.WriteLine("Escriba un número:");
                n= int.Parse(Console.ReadLine());
                if(n % 2 == 0){
                    contpar++;
                    if(contpar==1)
                    pares=n;
                    else if(n>pares)
                    pares = n;
                }else{
                    contimpar++;
                    if(contimpar==1)
                    impares = n;
                    else if(n<impares)
                    impares = n;

            }
            Console.WriteLine("El mayor de los pares es: " + pares + " y el menor de los impares es: " + impares);
        }
    }
}}
