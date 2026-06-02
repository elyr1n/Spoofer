namespace Spoofer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
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