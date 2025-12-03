using _02_CRUD.Vistas;
using Data_Base_firts.Models;

namespace Data_Base_firts
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
       
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