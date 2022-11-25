using System;

namespace Ejercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
//            Leer atentamente y resolver!

// Para cada ejercicio deberás escribir el código correspondiente y probar su funcionamiento.



// 1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.

        // int num1, num2, resultado;
        // Console.WriteLine("Ingrese un número");
        // num1 = int.Parse(Console.ReadLine());
        // Console.WriteLine("Ingrese otro número");
        // num2 = int.Parse(Console.ReadLine());
        // resultado = num1 + num2;
        // Console.WriteLine("El resultado es: " + resultado);


// 2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

            // int num, resultado;
            // Console.WriteLine("Ingrese un número");
            //  num = int.Parse(Console.ReadLine());
            //  resultado = num * num * num;
            //  Console.WriteLine("El resultado es: " + resultado);

// 3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

// float distancia, velocidad,tiempo;

// Console.WriteLine("Ingrese la distancia en km que hay entre las ciudades");
// distancia = float.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese la velocidad en km/h promedio de viaje");
// velocidad = float.Parse(Console.ReadLine());
// tiempo =  distancia / velocidad;
// Console.WriteLine("El tiempo que tarda en llegar es de: " + tiempo + " horas");

// 4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

// float venta, comision,total;
// Console.WriteLine("ingrese el total facturado");
// venta = float.Parse(Console.ReadLine());
// comision = venta * 0.05f;
// total = comision + 15000; 
// Console.WriteLine( " el total a cobrar es de: " + total + " pesos");

// 5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.

float nota1,nota2,nota3,promedio;
Console.WriteLine("ingrese la primer nota");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("ingrese la segunda nota");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("ingrese la tercer nota");
nota3 = float.Parse(Console.ReadLine());
promedio = (nota1 + nota2 + nota3) / 3 ;
Console.WriteLine( "El promedio es " + promedio);

            
        }
    }
}
