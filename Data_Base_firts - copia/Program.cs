using _02_CRUD.Vistas;
using Data_Base_firts.Models;
using System.Security.Cryptography.X509Certificates;

namespace Data_Base_firts
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
       
        public static int usuarioActualId;
        public static string rol;
        public static int rolId;
        public static string nombreUsuario;
        public static bool logueado;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frm_login());
        }
    }
}

// Scaffold-DbContext "Server=localhost;Port=3306;Database=mecanica;Uid=root;Pwd=root;" Pomelo.EntityFrameworkCore.MySql -OutputDir Models -Force