namespace Zadanie1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxAlgorithms;
        private System.Windows.Forms.Button buttonGenerateKeys;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxPlainText;
        private System.Windows.Forms.TextBox textBoxEncryptedText;
        private System.Windows.Forms.TextBox textBoxDecryptedText;
        private System.Windows.Forms.TextBox textBoxEncryptedHex;
        private System.Windows.Forms.TextBox textBoxDecryptedHex;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxIV;
        private System.Windows.Forms.Label labelEncryptionTime;
        private System.Windows.Forms.Label labelDecryptionTime;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxAlgorithms = new System.Windows.Forms.ComboBox();
            this.buttonGenerateKeys = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxPlainText = new System.Windows.Forms.TextBox();
            this.textBoxEncryptedText = new System.Windows.Forms.TextBox();
            this.textBoxDecryptedText = new System.Windows.Forms.TextBox();
            this.textBoxEncryptedHex = new System.Windows.Forms.TextBox();
            this.textBoxDecryptedHex = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxIV = new System.Windows.Forms.TextBox();
            this.labelEncryptionTime = new System.Windows.Forms.Label();
            this.labelDecryptionTime = new System.Windows.Forms.Label();
            this.SuspendLayout();


            this.comboBoxAlgorithms.FormattingEnabled = true;
            this.comboBoxAlgorithms.Location = new System.Drawing.Point(12, 12);
            this.comboBoxAlgorithms.Name = "comboBoxAlgorithms";
            this.comboBoxAlgorithms.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlgorithms.TabIndex = 0;


            this.buttonGenerateKeys.Location = new System.Drawing.Point(139, 10);
            this.buttonGenerateKeys.Name = "buttonGenerateKeys";
            this.buttonGenerateKeys.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateKeys.TabIndex = 1;
            this.buttonGenerateKeys.Text = "Generuj Klucz";
            this.buttonGenerateKeys.UseVisualStyleBackColor = true;
            this.buttonGenerateKeys.Click += new System.EventHandler(this.buttonGenerateKeys_Click);

            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(220, 10);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Enkrypcja";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);

            // buttonDecrypt

            this.buttonDecrypt.Location = new System.Drawing.Point(301, 10);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrypt.TabIndex = 3;
            this.buttonDecrypt.Text = "Dekrypcja";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);

            // textBoxPlainText

            this.textBoxPlainText.Location = new System.Drawing.Point(12, 39);
            this.textBoxPlainText.Multiline = true;
            this.textBoxPlainText.Name = "textBoxPlainText";
            this.textBoxPlainText.Size = new System.Drawing.Size(364, 50);
            this.textBoxPlainText.TabIndex = 4;

            // textBoxEncryptedText

            this.textBoxEncryptedText.Location = new System.Drawing.Point(12, 95);
            this.textBoxEncryptedText.Multiline = true;
            this.textBoxEncryptedText.Name = "textBoxEncryptedText";
            this.textBoxEncryptedText.Size = new System.Drawing.Size(364, 50);
            this.textBoxEncryptedText.TabIndex = 5;

            // textBoxDecryptedText

            this.textBoxDecryptedText.Location = new System.Drawing.Point(12, 207);
            this.textBoxDecryptedText.Multiline = true;
            this.textBoxDecryptedText.Name = "textBoxDecryptedText";
            this.textBoxDecryptedText.Size = new System.Drawing.Size(364, 50);
            this.textBoxDecryptedText.TabIndex = 6;

            // textBoxEncryptedHex

            this.textBoxEncryptedHex.Location = new System.Drawing.Point(12, 151);
            this.textBoxEncryptedHex.Multiline = true;
            this.textBoxEncryptedHex.Name = "textBoxEncryptedHex";
            this.textBoxEncryptedHex.Size = new System.Drawing.Size(364, 50);
            this.textBoxEncryptedHex.TabIndex = 7;

            // textBoxDecryptedHex

            this.textBoxDecryptedHex.Location = new System.Drawing.Point(12, 263);
            this.textBoxDecryptedHex.Multiline = true;
            this.textBoxDecryptedHex.Name = "textBoxDecryptedHex";
            this.textBoxDecryptedHex.Size = new System.Drawing.Size(364, 50);
            this.textBoxDecryptedHex.TabIndex = 8;

            this.textBoxKey.Location = new System.Drawing.Point(382, 39);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(200, 50);
            this.textBoxKey.TabIndex = 9;

            // tekst Box IV

            this.textBoxIV.Location = new System.Drawing.Point(382, 95);
            this.textBoxIV.Multiline = true;
            this.textBoxIV.Name = "textBoxIV";
            this.textBoxIV.Size = new System.Drawing.Size(200, 50);
            this.textBoxIV.TabIndex = 10;

            // Etykieta czasu enkrypcji

            this.labelEncryptionTime.AutoSize = true;
            this.labelEncryptionTime.Location = new System.Drawing.Point(379, 151);
            this.labelEncryptionTime.Name = "labelEncryptionTime";
            this.labelEncryptionTime.Size = new System.Drawing.Size(87, 13);
            this.labelEncryptionTime.TabIndex = 11;
            this.labelEncryptionTime.Text = "Czas enkrypcji: ";


            // Etykieta czasu dekrypcji

            this.labelDecryptionTime.AutoSize = true;
            this.labelDecryptionTime.Location = new System.Drawing.Point(379, 263);
            this.labelDecryptionTime.Name = "labelDecryptionTime";
            this.labelDecryptionTime.Size = new System.Drawing.Size(87, 13);
            this.labelDecryptionTime.TabIndex = 12;
            this.labelDecryptionTime.Text = "Czas dekrypcji: ";

            this.ClientSize = new System.Drawing.Size(594, 325);
            this.Controls.Add(this.labelDecryptionTime);
            this.Controls.Add(this.labelEncryptionTime);
            this.Controls.Add(this.textBoxIV);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.textBoxDecryptedHex);
            this.Controls.Add(this.textBoxEncryptedHex);
            this.Controls.Add(this.textBoxDecryptedText);
            this.Controls.Add(this.textBoxEncryptedText);
            this.Controls.Add(this.textBoxPlainText);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonGenerateKeys);
            this.Controls.Add(this.comboBoxAlgorithms);
            this.Name = "Form1";
            this.Text = "Aplikacja Enkrypcja/Dekrypcja";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
