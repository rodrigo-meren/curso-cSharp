using System;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            int n, contador1=0, contador2=0;
                
                
            do
            {
                n = int.Parse(Console.ReadLine());
                while (n>0)
                {
                    
                }
            } while (n>=0);

            Console.WriteLine("La primer lista tiene " + contador1 + " Números " + " y " + " La segunda " + contador2 +" Números");
        }
    }
}
