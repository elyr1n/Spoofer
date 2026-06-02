namespace Spoofer
{
    partial class SpooferForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            TextBoxHWID = new TextBox();
            TextBoxProductID = new TextBox();
            TextBoxComputerName = new TextBox();
            ButtonGenerate = new Button();
            ButtonSaveSettings = new Button();
            TextBoxRegisteredOwner = new TextBox();
            OffTPMButton = new Button();
            SuspendLayout();
            // 
            // TextBoxHWID
            // 
            TextBoxHWID.Location = new Point(14, 16);
            TextBoxHWID.Margin = new Padding(3, 4, 3, 4);
            TextBoxHWID.MaxLength = 36;
            TextBoxHWID.Name = "TextBoxHWID";
            TextBoxHWID.Size = new Size(411, 27);
            TextBoxHWID.TabIndex = 0;
            TextBoxHWID.Text = "HWID";
            TextBoxHWID.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxProductID
            // 
            TextBoxProductID.Location = new Point(14, 55);
            TextBoxProductID.Margin = new Padding(3, 4, 3, 4);
            TextBoxProductID.MaxLength = 24;
            TextBoxProductID.Name = "TextBoxProductID";
            TextBoxProductID.Size = new Size(411, 27);
            TextBoxProductID.TabIndex = 1;
            TextBoxProductID.Text = "Product-ID";
            TextBoxProductID.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxComputerName
            // 
            TextBoxComputerName.Location = new Point(14, 93);
            TextBoxComputerName.Margin = new Padding(3, 4, 3, 4);
            TextBoxComputerName.MaxLength = 15;
            TextBoxComputerName.Name = "TextBoxComputerName";
            TextBoxComputerName.Size = new Size(411, 27);
            TextBoxComputerName.TabIndex = 2;
            TextBoxComputerName.Text = "Computer-Name";
            TextBoxComputerName.TextAlign = HorizontalAlignment.Center;
            // 
            // ButtonGenerate
            // 
            ButtonGenerate.Location = new Point(14, 255);
            ButtonGenerate.Margin = new Padding(3, 4, 3, 4);
            ButtonGenerate.Name = "ButtonGenerate";
            ButtonGenerate.Size = new Size(411, 35);
            ButtonGenerate.TabIndex = 3;
            ButtonGenerate.Text = "Сгенерировать";
            ButtonGenerate.UseVisualStyleBackColor = true;
            ButtonGenerate.Click += ButtonGenerate_Click;
            // 
            // ButtonSaveSettings
            // 
            ButtonSaveSettings.Location = new Point(14, 297);
            ButtonSaveSettings.Margin = new Padding(3, 4, 3, 4);
            ButtonSaveSettings.Name = "ButtonSaveSettings";
            ButtonSaveSettings.Size = new Size(411, 35);
            ButtonSaveSettings.TabIndex = 4;
            ButtonSaveSettings.Text = "Сохранить";
            ButtonSaveSettings.UseVisualStyleBackColor = true;
            ButtonSaveSettings.Click += ButtonSaveSettings_Click;
            // 
            // TextBoxRegisteredOwner
            // 
            TextBoxRegisteredOwner.Location = new Point(14, 132);
            TextBoxRegisteredOwner.Margin = new Padding(3, 4, 3, 4);
            TextBoxRegisteredOwner.MaxLength = 256;
            TextBoxRegisteredOwner.Name = "TextBoxRegisteredOwner";
            TextBoxRegisteredOwner.Size = new Size(411, 27);
            TextBoxRegisteredOwner.TabIndex = 5;
            TextBoxRegisteredOwner.Text = "Registered-Owner";
            TextBoxRegisteredOwner.TextAlign = HorizontalAlignment.Center;
            // 
            // OffTPMButton
            // 
            OffTPMButton.Location = new Point(14, 212);
            OffTPMButton.Margin = new Padding(3, 4, 3, 4);
            OffTPMButton.Name = "OffTPMButton";
            OffTPMButton.Size = new Size(411, 35);
            OffTPMButton.TabIndex = 7;
            OffTPMButton.Text = "Выключить TPM";
            OffTPMButton.UseVisualStyleBackColor = true;
            OffTPMButton.Click += OffTPMButton_Click;
            // 
            // SpooferForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(439, 348);
            Controls.Add(OffTPMButton);
            Controls.Add(TextBoxRegisteredOwner);
            Controls.Add(ButtonSaveSettings);
            Controls.Add(ButtonGenerate);
            Controls.Add(TextBoxComputerName);
            Controls.Add(TextBoxProductID);
            Controls.Add(TextBoxHWID);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SpooferForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Spoofer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxHWID;
        private TextBox TextBoxProductID;
        private TextBox TextBoxComputerName;
        private Button ButtonGenerate;
        private Button ButtonSaveSettings;
        private TextBox TextBoxRegisteredOwner;
        private Button OffTPMButton;
    }
}
