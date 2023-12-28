namespace SM4D_2
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  Programme principal qui lance la fenetre d'accueil
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           //  Application.Run(new Accueil());
           Application.Run( new AccueilBorne());
        }
    }
}