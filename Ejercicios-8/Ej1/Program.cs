using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
            int n1=0, n2=0, resultado;
            
           
            pedirDatos(ref n1, ref n2);

            resultado = producto( n1,n2);

            Console.WriteLine("El resultado es: " + resultado);


        }

        static int producto(int a, int b){
           int r;           
            r = a * b;
            return r;
        }

        static void pedirDatos(ref int n1,ref int n2){
            Console.WriteLine("Escriba un número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba otro número:");
            n2 = int.Parse(Console.ReadLine());
        }
    }
}
