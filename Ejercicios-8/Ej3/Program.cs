using System;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
            int n,resultado,promedio;
            int acumulador= 0, contador=0;

            Console.WriteLine("Escriba un número: ");
            n = int.Parse(Console.ReadLine());
            while(n!=0){
                contador++;
             resultado= primos(n);
             if(resultado==1)
             acumulador++;
             Console.WriteLine("Escriba un número: ");
             n = int.Parse(Console.ReadLine());
             }
             promedio = acumulador*100/contador;

             Console.WriteLine("El Promedio de números primos es: "+ promedio+" % ");



            }

            static int primos(int n){
            int contador;

           
                contador=0;
                for(int x=1;x<=n;x++){
                    if(n % x == 0)
                    contador++;
                    
                }
                if(contador==2)
                return 1;
                else 
                return 0;
        
        }

        }
        }

        
    
    
