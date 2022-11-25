using System;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            Console.WriteLine("La cantidad de números pares es: "+pares());

      
   }
        static int pares(){
        int n, contador =0;
        for (var i = 0; i < 20; i++)
        {
            Console.WriteLine("Escriba un número: ");
            n= int.Parse(Console.ReadLine());
            if(n % 2 == 0){
                
                contador++;                         
            }
            
        }
            return contador;  
            }

    }
    
}
    
