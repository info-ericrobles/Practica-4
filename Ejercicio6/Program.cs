#region inicio-programa
using System;

namespace ejercicio6 {
    class Program {

        struct tipoFicha {
            public string nombreFich;
            public float tm;

            public int anpix;
            public int alpix;

        };
        static void Main(string[] args) {
#endregion
#region variables
            tipoFicha[] fichas = new tipoFicha[1];
            int numeroFichas = 0;
            int i;
            int opcion;
            string textoBuscar;
#endregion
#region menu
            do {

                Console.WriteLine();
                Console.WriteLine("Escoja una opción:");
                Console.WriteLine("1.- Añadir una ficha nueva");
                Console.WriteLine("2.- Ver todas las fichas");
                Console.WriteLine("3.- Buscar el nombre de la ficha");
                Console.WriteLine("4.- Salir");

                opcion = Convert.ToInt32(Console.ReadLine());
#endregion
#region switch
                switch (opcion) {
                case 1:
                    if (numeroFichas < fichas.Length) {
                        Console.WriteLine("Introduce el nombre del fichero: ");
                        fichas[numeroFichas].nombreFich = Console.ReadLine();
                        Console.WriteLine("Introduce el ancho de píxeles: ");
                        fichas[numeroFichas].anpix = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduce el alto de píxeles: ");
                        fichas[numeroFichas].alpix = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduce el tamaño en KB: ");
                        fichas[numeroFichas].tm = float.Parse(Console.ReadLine());


                        numeroFichas++;
                    } else
                        Console.WriteLine("Máximo de fichas alcanzado (1)!");
                    break;
                case 2:
                    for (i = 0; i < numeroFichas; i++)
                        Console.WriteLine("Nombre: {0}; Tamaño: {1} Kb; Ancho: {2} X Alto: {3}",
                            fichas[i].nombreFich, fichas[i].tm, fichas[i].anpix, fichas[i].alpix);
                    break;

                case 3:
                    Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
                    textoBuscar = Console.ReadLine();
                    for (i = 0; i < numeroFichas; i++)
                        if (fichas[i].nombreFich == textoBuscar)
                            Console.WriteLine("Nombre: {0}; Tamaño: {1} Kb; Ancho: {2}; Alto: {3}",
                                fichas[i].nombreFich, fichas[i].tm, fichas[i].anpix, fichas[i].alpix);
                    break;
                case 4:
                    Console.WriteLine("Fin del programa");
                    break;
                default:
                    Console.WriteLine("Opción desconocida!");
                    break;
                }
            } while (opcion != 4);
#endregion
#region final-programa

        }
    }
}
#endregion