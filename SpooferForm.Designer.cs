namespace Spoofer
{
    partial class SpooferForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBoxHWID = new TextBox();
            TextBoxProductID = new TextBox();
            TextBoxComputerName = new TextBox();
            ButtonGenerate = new Button();
            ButtonSaveSettings = new Button();
            TextBoxRegisteredOwner = new TextBox();
            LabelWindowsVersion = new Label();
            OffTPMButton = new Button();
            SuspendLayout();
            // 
            // TextBoxHWID
            // 
            TextBoxHWID.Location = new Point(12, 12);
            TextBoxHWID.MaxLength = 36;
            TextBoxHWID.Name = "TextBoxHWID";
            TextBoxHWID.Size = new Size(360, 23);
            TextBoxHWID.TabIndex = 0;
            TextBoxHWID.Text = "HWID";
            TextBoxHWID.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxProductID
            // 
            TextBoxProductID.Location = new Point(12, 41);
            TextBoxProductID.MaxLength = 24;
            TextBoxProductID.Name = "TextBoxProductID";
            TextBoxProductID.Size = new Size(360, 23);
            TextBoxProductID.TabIndex = 1;
            TextBoxProductID.Text = "Product-ID";
            TextBoxProductID.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxComputerName
            // 
            TextBoxComputerName.Location = new Point(12, 70);
            TextBoxComputerName.MaxLength = 15;
            TextBoxComputerName.Name = "TextBoxComputerName";
            TextBoxComputerName.Size = new Size(360, 23);
            TextBoxComputerName.TabIndex = 2;
            TextBoxComputerName.Text = "Computer-Name";
            TextBoxComputerName.TextAlign = HorizontalAlignment.Center;
            // 
            // ButtonGenerate
            // 
            ButtonGenerate.Location = new Point(12, 191);
            ButtonGenerate.Name = "ButtonGenerate";
            ButtonGenerate.Size = new Size(360, 26);
            ButtonGenerate.TabIndex = 3;
            ButtonGenerate.Text = "Сгенерировать";
            ButtonGenerate.UseVisualStyleBackColor = true;
            ButtonGenerate.Click += ButtonGenerate_Click;
            // 
            // ButtonSaveSettings
            // 
            ButtonSaveSettings.Location = new Point(12, 223);
            ButtonSaveSettings.Name = "ButtonSaveSettings";
            ButtonSaveSettings.Size = new Size(360, 26);
            ButtonSaveSettings.TabIndex = 4;
            ButtonSaveSettings.Text = "Сохранить";
            ButtonSaveSettings.UseVisualStyleBackColor = true;
            ButtonSaveSettings.Click += ButtonSaveSettings_Click;
            // 
            // TextBoxRegisteredOwner
            // 
            TextBoxRegisteredOwner.Location = new Point(12, 99);
            TextBoxRegisteredOwner.MaxLength = 256;
            TextBoxRegisteredOwner.Name = "TextBoxRegisteredOwner";
            TextBoxRegisteredOwner.Size = new Size(360, 23);
            TextBoxRegisteredOwner.TabIndex = 5;
            TextBoxRegisteredOwner.Text = "Registered-Owner";
            TextBoxRegisteredOwner.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelWindowsVersion
            // 
            LabelWindowsVersion.AutoSize = true;
            LabelWindowsVersion.BackColor = SystemColors.Control;
            LabelWindowsVersion.ForeColor = SystemColors.AppWorkspace;
            LabelWindowsVersion.Location = new Point(8, 125);
            LabelWindowsVersion.Name = "LabelWindowsVersion";
            LabelWindowsVersion.Size = new Size(0, 15);
            LabelWindowsVersion.TabIndex = 6;
            // 
            // OffTPMButton
            // 
            OffTPMButton.Location = new Point(12, 159);
            OffTPMButton.Name = "OffTPMButton";
            OffTPMButton.Size = new Size(360, 26);
            OffTPMButton.TabIndex = 7;
            OffTPMButton.Text = "Выключить TPM";
            OffTPMButton.UseVisualStyleBackColor = true;
            OffTPMButton.Click += OffTPMButton_Click;
            // 
            // SpooferForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(384, 261);
            Controls.Add(OffTPMButton);
            Controls.Add(LabelWindowsVersion);
            Controls.Add(TextBoxRegisteredOwner);
            Controls.Add(ButtonSaveSettings);
            Controls.Add(ButtonGenerate);
            Controls.Add(TextBoxComputerName);
            Controls.Add(TextBoxProductID);
            Controls.Add(TextBoxHWID);
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
        private Label LabelWindowsVersion;
        private Button OffTPMButton;
    }
}
