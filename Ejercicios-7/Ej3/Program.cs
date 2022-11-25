using System;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
//             3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
// CADENA FUENTE: “La mar estaba serena"
// CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
// CADENA RESULTADO: “Li mir estibi sereni"
       string cadena;
       char letra1 = 'a';
       char letra2 ='e';

       cadena = console.ReadLine();

       for (var i = 0; i < cadena.length; i++)
       {
        if(cadena[i]==letra1)
        cadena[i]=letra2;
       }
       Console.WriteLine(cadena);
       
       
       
        }

    }
}
