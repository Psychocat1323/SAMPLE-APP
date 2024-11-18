namespace SAMPLE_APP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // task run the invovokeCreateDB
            SQLClass connectionClass = new SQLClass();
           await connectionClass.InvokeCreateDB();


            ApplicationConfiguration.Initialize();
            Application.Run(new SampleApp());
        }
    }
}