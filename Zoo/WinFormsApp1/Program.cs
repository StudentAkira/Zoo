namespace WinFormsApp1
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
            Application.Run(new Form1());
            var logger = NLog.LogManager.GetCurrentClassLogger();
            NLog.LogManager.Flush();
            string[] args = { " hello ", " logging " };
            logger.Info("App started {arguments}", args);

            NLog.LogManager.Shutdown();
        }
    }
}