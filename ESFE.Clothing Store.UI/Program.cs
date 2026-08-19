using System;
using System.Windows.Forms;
using ESFE.Clothing_Store.UI;

namespace ESFE.Clothing_Store.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Iniciar directamente con el formulario Clientes para pruebas
            Application.Run(new Clientes());
        }
    }
}