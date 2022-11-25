using System;

namespace Ejercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //1. Hacer un programa para ingresar un número y luego se   emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

            // int num;
            // Console.WriteLine("Ingrese un número:");
            // num = int.Parse(Console.ReadLine());

            // if(num > 10){
            //     Console.WriteLine("Es mayor a 10");
            // } else{
            //     Console.WriteLine("No es mayor a 10");
            // }

            // 2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.

                // int num;
                // Console.WriteLine("ingrese un número:");
                // num = int.Parse(Console.ReadLine());

                // if(num > 0){
                //     Console.WriteLine("Positivo.");
                // }else if(num==0)
                //     Console.WriteLine("Negativo");
                // } else{
                  //  Console.WriteLine("Negativo");
                //} 




            // 3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:

            // Si el importe es menor a ARS 1000, no hay descuento.
            // Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            // Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            // Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.


            // int importe;
            // Console.WriteLine("ingrese el importe de la compra:");
            // importe = int.Parse(Console.ReadLine());
            // if(importe >= 5000){
            //     Console.WriteLine("El importe tota es de " + importe * 0.82 + " pesos");
            // }else{
            //     if(importe>=1000){
            //         Console.WriteLine("El importe tota es de " + importe * 0.90 + " pesos");
            //     }else{
            //         Console.WriteLine("El importe tota es de " + importe + " pesos");
            //     }
            // }

            // 4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

                // int num1, num2, num3,num4, menor;

                // Console.WriteLine("Escriba un número:");
                // num1 = int.Parse(Console.ReadLine());
                // Console.WriteLine("Escriba otro número:");
                // num2 = int.Parse(Console.ReadLine());
                // Console.WriteLine("Escriba otro número:");
                // num3 = int.Parse(Console.ReadLine());
                // Console.WriteLine("Escriba otro número:");
                // num4 = int.Parse(Console.ReadLine());

                

                // if(num1<num2)
                //     menor = num1;
                // else
                //     menor = num2;
                // 
                // if(num3<menor)
                //     menor= num3;
                // 
                // if(num4<menor)
                //    menor = num4;
                // 
                

                // Console.WriteLine("el número mas chico es: " + menor);

            // 5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

                int num1, num2, num3,num4;

                Console.WriteLine("Escriba un número:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba otro número:");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba otro número:");
                num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba otro número:");
                num4 = int.Parse(Console.ReadLine());

                if (num1>100){
                    Console.WriteLine(num1 + " Es mayor a 100");
                }
                if (num2>100){
                    Console.WriteLine(num2 + " Es mayor a 100");
                }
                if (num3>100){
                    Console.WriteLine(num3 + " Es mayor a 100");
                }
                if (num4>100){
                    Console.WriteLine(num4 + " Es mayor a 100");
                }

           
        }
    }
}
