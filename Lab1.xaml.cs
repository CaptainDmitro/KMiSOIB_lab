using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KMiSOIB_lab
{
    public partial class Lab1 : Window
    {
        private string message;

        public Lab1()
        {
            InitializeComponent();
            message = Message1TB.Text;
        }

        private void Task1()
        {
            int[] substitutTable =
            {
                7, 14, 0, 10, 2, 4, 1, 13, 11, 12, 5, 6, 8, 3, 9
            };

            char[] encryptedMsg = new char[message.Length];
            for(int i = 0; i < message.Length; i++)
            {
                encryptedMsg[i] = message[substitutTable[i]];
            }
            Encrypted1TB.Text = string.Join("", encryptedMsg);

            char[] decryptedMsg = new char[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                decryptedMsg[substitutTable[i]] = encryptedMsg[i];
            }
            Decrypted1TB.Text = string.Join("", decryptedMsg);
        }

        private void Task2()
        {
            /*int[] substitutedTable =
                {
                    8, 7, 6, 5, 4, 3, 2, 1, 0,
                    17, 16, 15, 14, 13, 12, 11, 10, 9,
                    26, 25, 24, 23, 22, 21, 20, 19, 18,
                    32, 31, 30, 29, 28, 27,

                };*/

            int[] substituteTable = Enumerable.Range(1072, 32).ToArray();

            char[] encrypted = new char[message.Length];

            string tst = "абвгдежзийклмнопрстуфхцчшщъыьэюя";

            //Console.WriteLine(string.Join(" ", substituteTable));

            for(int i = 0; i < substituteTable.Length - 1; i++)
            {
                int tmp = substituteTable[i];
                substituteTable[i] = substituteTable[i + 1];
                substituteTable[i + 1] = tmp;
            }

            //Console.WriteLine(string.Join(" ", substituteTable));

            char[] encryptedMsg = new char[tst.Length];
            for(int i = 0; i < tst.Length; i++)
            {
                encryptedMsg[i] = (char)substituteTable[tst[i] % 1072];
            }

            Console.WriteLine(tst);
            Console.WriteLine(string.Join("", encryptedMsg));

            char[] decryptedMsg = new char[tst.Length];
            for (int i = 0; i < tst.Length; i++)
            {
                for (int j = 0; j < tst.Length; j++)
                {
                    if (encryptedMsg[i] == substituteTable[j]) decryptedMsg[i] = encryptedMsg[j];
                }
            }

            Console.WriteLine(string.Join("", decryptedMsg));
        }

        private void Proceed1_Click(object sender, RoutedEventArgs e) { Task1(); }
        private void Proceed2_Click(object sender, RoutedEventArgs e) { Task2(); }
    }

}
