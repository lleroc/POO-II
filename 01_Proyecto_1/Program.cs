namespace _01_Proyecto_1
{
    using _01_Proyecto_1.Vistas.DashBoard;
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
            Application.Run(new frm_cuadro_de_mando());
        }
    }
}