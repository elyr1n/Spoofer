using Microsoft.Win32;

namespace Spoofer
{
    public partial class SpooferForm : Form
    {
        public SpooferForm()
        {
            InitializeComponent();
            getSystemValues();
        }

        private void getSystemValues()
        {
            TextBoxHWID.Text = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography", "MachineGuid", "HWID")?.ToString();
            TextBoxProductID.Text = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductId", "Product-ID")?.ToString();
            TextBoxComputerName.Text = Environment.MachineName;
            TextBoxRegisteredOwner.Text = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "RegisteredOwner", "Registered Owner")?.ToString();
            LabelWindowsVersion.Text = Environment.OSVersion.ToString();
        }

        private void ButtonSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography", "MachineGuid", TextBoxHWID.Text);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductId", TextBoxProductID.Text);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\ComputerName\ActiveComputerName", "ComputerName", TextBoxComputerName.Text);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\ComputerName\ComputerName", "ComputerName", TextBoxComputerName.Text);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "RegisteredOwner", TextBoxRegisteredOwner.Text);

                MessageBox.Show("Настройки успешно сохранены. Перезагрузите компьютер, чтобы изменения вступили в силу.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ошибка при сохранении настроек: {error.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            TextBoxHWID.Text = Guid.NewGuid().ToString();
            TextBoxProductID.Text = $"{new Random().Next(10000, 99999)}-OEM-{new Random().Next(1000000, 9999999)}-{new Random().Next(10000, 99999)}";
            TextBoxComputerName.Text = $"DESKTOP-{Guid.NewGuid().ToString().Substring(0, 7).ToUpper()}";
            TextBoxRegisteredOwner.Text = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
        }

        private void OffTPMButton_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\Setup\MoSetup", "AllowUpgradesWithUnsupportedTPMOrCPU", 1);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\Setup\LabConfig", "BypassTPMCheck", 1);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\Setup\LabConfig", "BypassSecureBootCheck", 1);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\Setup\LabConfig", "BypassRAMCheck", 1);

                MessageBox.Show("TPM успешно отключён. Перезагрузите компьютер, чтобы изменения вступили в силу.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ошибка при отключении TPM: {error.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
