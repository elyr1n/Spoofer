namespace Spoofer
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
            if (!Environment.Is64BitOperatingSystem)
            {
                MessageBox.Show("Программа предназначена для 64-разрядных операционных систем.", "Несовместимая операционная система", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new SpooferForm());
        }
    }
}