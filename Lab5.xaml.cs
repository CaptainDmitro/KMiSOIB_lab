using System.Windows;
using System.Security.Cryptography;
using System.Text;
using System;
using Org.BouncyCastle;

namespace KMiSOIB_lab
{
    /// <summary>
    /// Логика взаимодействия для Lab3.xaml
    /// </summary>
    public partial class Lab5 : Window
    {
        public Lab5()
        {
            InitializeComponent();
            Task();
        }

        private void Task()
        {
            string plainData = "Mahesh";
            string hashedData = ComputeSha256Hash(plainData);
            string hashedData2 = ComputeSha384Hash(plainData);
            string hashedData3 = ComputeSha512Hash(plainData);

            string plainData2 = "Fanesh";
            string plainData3 = "Monesh";
            string plainData4 = "Malesh";

            string hashedData4 = ComputeMd5HashHash(plainData2);
            string hashedData5 = ComputeRipeMd160HashHash(plainData3);
            string hashedData6 = ComputeSha256Hash(plainData4);

            string plainData5 = "MaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMahesh";
            string hashedData7 = ComputeSha256Hash(plainData5);

            string plainData6 = "MaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMaheshMahesh"; // > 1mb; < 3mb
            string hashedData8 = ComputeSha256Hash(plainData6);

            string plainData7 = "Hello World!";
            string hashedData9 = ComputeSha256Hash(plainData7);

            TheSame1TB.Text = hashedData;
            TheSame2TB.Text = hashedData2;
            TheSame3TB.Text = hashedData3;

            DiffIn1TB.Text = hashedData4;
            DiffIn2TB.Text = hashedData5;
            DiffIn3TB.Text = hashedData6;

            Less1MbTB.Text = hashedData9;
            More1Less3MbTB.Text = hashedData7;
            More10MbTB.Text = hashedData8;
        }

        static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        static string ComputeSha384Hash(string rawData)
        {
            using (SHA384 sha256Hash = SHA384.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
 
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        static string ComputeSha512Hash(string rawData)
        {
            using (SHA512 sha256Hash = SHA512.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        static string ComputeMd5HashHash(string rawData)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] bytes = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        static string ComputeRipeMd160HashHash(string rawData)
        {
            using (RIPEMD160 ripeMd160Hash = RIPEMD160.Create())
            {
                byte[] bytes = ripeMd160Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
