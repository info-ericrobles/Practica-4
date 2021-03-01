using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variables
            
            int[] numero = new int[10];
            int mayor;
            #endregion
            #region programa 
            mayor = numero[0];

            Console.WriteLine("Ingrese 10 Numeros\n");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese El Numero {0}:", i + 1);
                numero[i] = int.Parse(Console.ReadLine());
                if (numero[i] > mayor) mayor = numero[i];
             }
            Console.WriteLine("El Numero mayor es: {0}", mayor);
            #endregion
        }
    }
}
