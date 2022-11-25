using System;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
            int mayor,n;
            mayor = 0;
            for(int i =0; i<10;i++){
                Console.WriteLine("escriba un numero");
                n = int.Parse(Console.ReadLine());
                if(n>mayor)
                mayor = n;
            }
            Console.WriteLine("El número mayor es: " + mayor);
        }
    }
}
