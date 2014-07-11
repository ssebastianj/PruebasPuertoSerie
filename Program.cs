// <copyright file="Program.cs" company="SEBAS">SEBAS</copyright>
namespace PruebasPuertoSerie
{
    using System;
    using System.Windows.Forms;
    
    /// <summary>
    /// Punto de entrada a la aplicación
    /// </summary>
    public static class Program 
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        public static void Main() 
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularioPrincipal());
        }
    }
}