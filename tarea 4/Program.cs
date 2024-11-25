using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.Events;


namespace tarea_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clases clases = new Clases();

            clases.Buscar();
            clases.entrarArticulo();
            clases.cambiarIdioma();
            clases.VerPreferencias();



        }
    }
}
