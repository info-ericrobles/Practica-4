#region programa
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla {
    class TablaMultiplicar {
        public void CargarValor() {
            int valor;
            string linea;
            do {
                Console.Write("Ingresa un numero de la Tabla de Multiplicar (-1 para finalizar):");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor != -1) {
                    Calcular(valor);
                }
            } while (valor != -1);
        }

        public void Calcular(int valors) {
            for (int cantidad = valors; cantidad <= valors * 10; cantidad = cantidad + valors) {
                
                Console.Write(cantidad + ".");
            }
            Console.WriteLine();
        }

        static void Main(string[] args) {
            TablaMultiplicar tm = new TablaMultiplicar();
            tm.CargarValor();
        }
    }
}
#endregion