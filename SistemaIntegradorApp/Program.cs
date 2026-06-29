using System;
using System.Windows.Forms;
using SistemaIntegradorApp.Presentacion; // Esto permite encontrar tu carpeta Presentacion

namespace SistemaIntegradorApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Señalo que inicie mostrando el FormLogin
            Application.Run(new FormLogin());
        }
    }
}