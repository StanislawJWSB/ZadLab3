using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

class EncryptionBenchmark
{
    public static void Main()
    {
        byte[] data = new byte[1024]; // 1KB blok danych
        new Random().NextBytes(data);

        BenchmarkAlgorithm("AES", Aes.Create(), data);
        BenchmarkAlgorithm("DES", DES.Create(), data);
        BenchmarkAlgorithm("3DES", TripleDES.Create(), data);
    }

    static void BenchmarkAlgorithm(string name, SymmetricAlgorithm algorithm, byte[] data)
    {
        // Z pamięci
        using (MemoryStream memoryStream = new MemoryStream(data))
        {
            TimeAndPrint(name, "Pamięć", algorithm, memoryStream);
        }

        // Z dysku
        string tempFile = Path.GetTempFileName();
        File.WriteAllBytes(tempFile, data);
        using (FileStream fileStream = new FileStream(tempFile, FileMode.Open))
        {
            TimeAndPrint(name, "Dysk", algorithm, fileStream);
        }
        File.Delete(tempFile);
    }

    static void TimeAndPrint(string name, string source, SymmetricAlgorithm algorithm, Stream stream)
    {
        byte[] buffer = new byte[1024]; // 1KB
        using (CryptoStream cryptoStream = new CryptoStream(stream, algorithm.CreateEncryptor(), CryptoStreamMode.Read))
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            while (cryptoStream.Read(buffer, 0, buffer.Length) > 0) { }
            stopwatch.Stop();

            double secondsPerBlock = stopwatch.Elapsed.TotalSeconds;
            double bytesPerSecond = buffer.Length / secondsPerBlock;
            Console.WriteLine($"{name}\t{source}\t{secondsPerBlock:E5}\t{bytesPerSecond:E2}");
        }
    }
}
