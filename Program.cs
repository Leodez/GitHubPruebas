﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubPruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime tu nombre:");
            string nombre = Console.ReadLine();
            Saludador.Saludar(nombre);
        }
    }
}
