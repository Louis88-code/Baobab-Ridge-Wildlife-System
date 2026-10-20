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
            try
            {
                // anything not caught inside a form is sent to the exception handler
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                Application.ThreadException += (sender, e) =>
                    ExceptionHandler.Handle(e.Exception, "An unexpected error occurred.");
                AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
                    ExceptionHandler.Handle(
                        e.ExceptionObject as Exception ?? new Exception(e.ExceptionObject?.ToString()),
                        "A fatal error occurred.");

                ApplicationConfiguration.Initialize();

                Application.Run(new ViewAnimals());
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "The application could not start.");
            }
        }
    }
}
