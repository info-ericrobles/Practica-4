using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float") y luego los muestre en el orden contrario al que se introdujeron.
            #region variables
            float[] numeros = new float[5];
            #endregion
            #region numeros++
               for (int i=0; i<=4; i++)    
                 {
                 Console.Write("Introduce El Dato Numero {0}: ", i+1);
                 numeros[i] = Convert.ToInt32(Console.ReadLine());
                 }
            #endregion
            #region numeros--
               for (int i = 4; i >= 0; i--)
                   {
                   Console.WriteLine(numeros[i]);
                   }
            #endregion
                
        }
    }
}
