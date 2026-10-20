namespace BaobabRidgeWildlifeSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // View Animals is the main screen. Add and Update open from its buttons.
            Application.Run(new ViewAnimals());
        }
    }
}