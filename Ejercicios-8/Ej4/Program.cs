﻿using System;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:

// a. 1 si el número es positivo.
// b. -1 si el número es negativo.
// c. 0 si el número es cero
        int a=0;

        
        positivoNegativoCero(11,ref a);

        Console.WriteLine( a );
        }

        static void positivoNegativoCero(int n, ref int b){
        //     Console.WriteLine("Escriba 1, 0 o -1 : ");
        //  n = int.Parse(Console.ReadLine());
            if(n==0)
            b=0;
            else if(n>0)
            b=1;
            else
            b=-1;
        }
    }
}
