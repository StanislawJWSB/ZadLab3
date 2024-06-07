using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EncryptionApp
{
    public partial class Form1 : Form
    {
        private SymmetricAlgorithm algorithm;
        private byte[] key;
        private byte[] iv;

        public Form1()
        {
            InitializeComponent();
            InitializeAlgorithms();
        }

        private void InitializeAlgorithms()
        {
            comboBoxAlgorithms.Items.Add("AES");
            comboBoxAlgorithms.Items.Add("DES");
            comboBoxAlgorithms.Items.Add("3DES");
            comboBoxAlgorithms.SelectedIndex = 0;
        }

        private void buttonGenerateKeys_Click(object sender, EventArgs e)
        {
            switch (comboBoxAlgorithms.SelectedItem.ToString())
            {
                case "AES":
                    algorithm = Aes.Create();
                    break;
                case "DES":
                    algorithm = DES.Create();
                    break;
                case "3DES":
                    algorithm = TripleDES.Create();
                    break;
            }

            algorithm.GenerateKey();
            algorithm.GenerateIV();
            key = algorithm.Key;
            iv = algorithm.IV;

            textBoxKey.Text = BitConverter.ToString(key).Replace("-", "");
            textBoxIV.Text = BitConverter.ToString(iv).Replace("-", "");
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            var plainText = textBoxPlainText.Text;
            var plainBytes = Encoding.ASCII.GetBytes(plainText);

            var stopwatch = Stopwatch.StartNew();
            var encryptedBytes = Encrypt(plainBytes);
            stopwatch.Stop();

            textBoxEncryptedText.Text = Encoding.ASCII.GetString(encryptedBytes);
            textBoxEncryptedHex.Text = BitConverter.ToString(encryptedBytes).Replace("-", "");
            labelEncryptionTime.Text = $"Czas enkrypcji: {stopwatch.ElapsedMilliseconds} ms";
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            var encryptedBytes = ConvertHexStringToByteArray(textBoxEncryptedHex.Text);

            var stopwatch = Stopwatch.StartNew();
            var decryptedBytes = Decrypt(encryptedBytes);
            stopwatch.Stop();

            textBoxDecryptedText.Text = Encoding.ASCII.GetString(decryptedBytes);
            textBoxDecryptedHex.Text = BitConverter.ToString(decryptedBytes).Replace("-", "");
            labelDecryptionTime.Text = $"Czas dekrypcji: {stopwatch.ElapsedMilliseconds} ms";
        }

        private byte[] Encrypt(byte[] plainBytes)
        {
            using (var encryptor = algorithm.CreateEncryptor(key, iv))
            {
                return encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
            }
        }

        private byte[] Decrypt(byte[] encryptedBytes)
        {
            using (var decryptor = algorithm.CreateDecryptor(key, iv))
            {
                return decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
            }
        }

        private byte[] ConvertHexStringToByteArray(string hexString)
        {
            int length = hexString.Length;
            byte[] bytes = new byte[length / 2];
            for (int i = 0; i < length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }
            return bytes;
        }
    }
}
