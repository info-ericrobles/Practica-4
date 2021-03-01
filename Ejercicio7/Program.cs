using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
#region programa
            Console.WriteLine("Escribe tu Nombre:");
            string nombre = Console.ReadLine();
            char[] nom = nombre.ToCharArray();
            foreach (char n in nom)
            {
                Console.Write("{0} ", n);
            }
#endregion
        }
    }
}
