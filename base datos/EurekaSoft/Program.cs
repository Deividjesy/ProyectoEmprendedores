using AccesoDatos.Accesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EurekaSoft
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            args = new string[] { "/un=david.alonso@uabc.edu.mx", "/pw=a" };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string email = null;
            string password = null;
            bool success = DBConexion.InitialLoad();
            foreach (string arg in args)
            {
                if (arg.Contains("="))
                {
                    string argumento = arg.Split('=')[0].ToLower();
                    string valor = arg.Split('=')[1];
                    switch (argumento)
                    {
                        case "/un": email = valor; break;
                        case "/pw": password = valor; break;
                    }
                }
            }
            Application.Run(new frmAutenticacion(email, password));
        }
    }
}
