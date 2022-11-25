using System;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

            int edad,contador,acumulador,promedio;

                contador = 0;
                acumulador = 0;
                for(int i=0; i<20; i++){
                    Console.WriteLine("Escriba su edad: ");
                    edad= int.Parse(Console.ReadLine());
                    if(edad >18){
                        acumulador = acumulador + edad;
                        contador++;
                    }
                }
                if(contador>0)
                promedio = acumulador/contador;
                else
                promedio = 0;
                    Console.WriteLine("El promedio de las edades es: " + promedio);
        }
    }
}
