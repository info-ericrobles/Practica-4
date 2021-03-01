#region programa
using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            #endregion
#region variables
            int i ;
            int menor = 0;
            int mayor = 0;
            
            float[] altura = new float[5];
            float suma = 0, promedio;
#endregion
#region altura
            for (i = 0; i < altura.Length; i++)
            {
            Console.Write("Ingrese Altura {0}: ", i + 1);
            altura[i] = float.Parse(Console.ReadLine());
            }
            for (i = 0; i < altura.Length; i++)
            {


            suma = suma + altura[i];
            }
            promedio = suma / 5;
            #endregion
#region cal-promedio
            Console.WriteLine("\nPromedio Alturas: {0}\n", promedio);

            for (i = 0; i < altura.Length; i++)
            {
            if (altura[i] > promedio)
            {
            mayor++;
            }
            else
            {
            if (altura[i] < promedio)
            {
            menor++;
            }
            }
            }
#endregion          
#region promedio
            Console.WriteLine("Cantidad de personas mayores al promedio: {0}", mayor);
            Console.WriteLine("Cantidad de personas menores al promedio: {0}", menor);

            return;
#endregion
#region fin-programa
        }
    }
}
#endregion
