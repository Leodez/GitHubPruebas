using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubPruebas
{
    static class Saludador
    {
        public static void Saludar(string nombre)
        {
            Console.WriteLine($"Hola {nombre}!");
        }

        public static void Presentar()
        {
            Console.WriteLine("Hola, tengo un método Saludar. ¿Quieres probarlo?");
        }
    }
}
