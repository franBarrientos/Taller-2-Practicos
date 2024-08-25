using Practicos.Practico_1;
using Practicos.Practico_2;
using Practicos.Practico_3;
using Practicos.Practico_4;
using Practicos.Practico_5;
using System.Runtime.CompilerServices;

namespace Practicos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.s
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Formulario1());
            //Application.Run(new Formulario2());
            //Application.Run(new Formulario3());
            //Application.Run(new MDIParent1());
            //Application.Run(new Formulario4());
            Application.Run(new INICIO());
            //Application.Run(new Formulario5());

        }
    }
}