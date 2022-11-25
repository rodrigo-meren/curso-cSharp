using System;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
            // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            int n, nTotales, impar, grupoMayor=0;
            double porcentaje, mayPor=0;
            int contador=0, maximo, decrecientes=0,cantidad=0;

            for(int i=0; i<2;i++){            
                           
               nTotales=0; 
               impar=0;
                n= int.Parse(Console.ReadLine());
                maximo= n;
                
            while (n!=0){                 
                    
            nTotales++;
            if(n % 2 != 0)
             impar++;     
             contador++;
            if(n<=maximo)
            decrecientes++;       
            n= int.Parse(Console.ReadLine());
                
            } //fin del while
            porcentaje = impar*100/nTotales;
            if(porcentaje>mayPor){
            mayPor=porcentaje;
            grupoMayor=i+1;

            if(contador==decrecientes)
            cantidad++;

            }
            } //fin del for
            
            Console.WriteLine("El número del grupo con mayor porcentaje de impares es: " + grupoMayor);
            Console.WriteLine("La cantidad de grupos ordenados de manera decreciente es de: " + cantidad);


        }
    }
}
