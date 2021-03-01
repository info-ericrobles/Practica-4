using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un programa que prepare espacio para un máximo de 100 nombres. El usuario deberá ir introduciendo un nombre cada vez, hasta que se pulse Intro sin teclear nada, momento en el que dejarán de pedirse más nombres y se mostrará en pantalla la lista de los nombres que se han introducido.
                #region variables
                String[] nombre = new String[100];
                int contador = 0;
                #endregion
                #region nombre-ceparado
                for (int i = 0; i < nombre.Length; i++)
                {
                Console.Write("Ingrese El Nombre: {0} ", i + 1);
                String nombre2 = Console.ReadLine();
                if (nombre2 == string.Empty)
                {
                    break;
                }
                else
                {
                    nombre[i] = nombre2;
                    contador++;
                }
        
                }
                for (int i = 0; i < contador; i++)
                {
                Console.WriteLine(nombre[i]);
                }
                #endregion
        }
    }
}
