namespace PD_Helper
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

			try
			{
                Application.Run(new PDHelperForm());
            }
			catch (BadImageFormatException e)
			{
                MessageBox.Show("PD Helper was unable to start up due to Windows treating the application as a virus.", "Virus Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
			}
        }
    }
}