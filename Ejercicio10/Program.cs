#region programa
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa10 {
    class Persona {
        private string nombre;
        private int edad;

        public void Inicializar() {
            Console.Write("Ingrese El Nombre:");
            nombre = Console.ReadLine();
            string linea;
            Console.Write("Ingrese la Edad:");
            linea = Console.ReadLine();
            edad = int.Parse(linea);
        }

        public void Imprimir() {
            Console.Write("Nombre:");
            Console.WriteLine(nombre);
            Console.Write("Edad:");
            Console.WriteLine(edad);
        }

        public void EsMayorEdad() {
            if (edad >= 18) {
                Console.Write("Es mayor de Edad");
            } else {
                Console.Write("No es mayor de Edad");
            }
            Console.ReadKey();
        }


        static void Main(string[] args) {
            Persona per1 = new Persona();
            per1.Inicializar();
            per1.Imprimir();
            per1.EsMayorEdad();
        }
    }
}
#endregion