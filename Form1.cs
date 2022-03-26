using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_2_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string fileName;

        private void Run_Button_Click(object sender, EventArgs e)
        {
            string startValueStr = (Start_Value_Box.Text).ToString();
            string polynomStr = (Polynom_Box.Text).ToString();

            if (startValueStr == "" || polynomStr == "")
            {
                MessageBox.Show("Please, enter data!");
                return;
            }

            startValueStr = ToCorrectSeq(startValueStr);
            polynomStr = ToCorrectSeq(polynomStr);
            
            if (startValueStr == "" || polynomStr == "")
            {
                MessageBox.Show("Please, enter data consisting of 1 and 0!");
                return;
            }

            if (startValueStr.Length != polynomStr.Length)
            {
                MessageBox.Show("Starting value and polynom of different length!");
                return;
            }

            byte[] startValue = GetMasByte(startValueStr);
            byte[] polynom = GetMasByte(polynomStr);

            FileStream f = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(f);
            fileName = fileName.Insert(fileName.LastIndexOf('.'), "New");
            BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate));

            string startVOut = "", keyOut = "", resOut = "";
            int count = 0;
            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                byte startV = reader.ReadByte();
                byte key = GetKey(startValue, polynom);
                byte res = (byte)(startV ^ key);
                writer.Write(res);

                if (count++ < 100)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        startVOut += GetBit(new byte[] { startV }, i);
                        keyOut += GetBit(new byte[] { key }, i);
                        resOut += GetBit(new byte[] { res }, i);
                    }
                }
            }

            Generated_Key_Box.Text = keyOut;
            File_Content_Box.Text = startVOut;
            Result_Box.Text = resOut;

            reader.Close();
            writer.Close();
        }

        private void Select_File_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            if (Dialog.ShowDialog() == DialogResult.OK)
                fileName = Dialog.FileName;
        }

        private static string ToCorrectSeq (string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
                if (str[i] == '0' || str[i] == '1')
                    result += str[i];

            return result;
        }

        private static byte[] GetMasByte(string str)
        {
            int len = str.Length / 8 + ((str.Length % 8 == 0) ? 0 : 1);
            byte[] mas = new byte[len];
            for (int i = 0; i < str.Length; i++)
            {
                SetBit(mas, i, str[i] - '0');
            }

            return mas;
        }

        private static int GetBit(byte[] arr, int numBit)
        {
            return (arr[numBit / 8] & (1 << (7 - numBit % 8))) >> (7 - numBit % 8);
        }

        private static void SetBit(byte[] arr, int numBit, int bit)
        {
            byte mask = (byte)(1 << (7 - numBit % 8));
            bit <<= (7 - numBit % 8);
            arr[numBit / 8] = (byte)((arr[numBit / 8] & (~mask)) + bit);
        }

        private static byte GetKey(byte[] arr, byte[] pol)
        {
            byte b = 0;

            for (int k = 0; k < 8; k++)
            {
                byte[] a = new byte[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                    a[i] = (byte)(arr[i] & pol[i]);
                int bit = 0;
                for (int i = 0; i < 36; i++)
                    bit ^= GetBit(a, i);

                b <<= 1;
                b += (byte)GetBit(arr, 35);

                for (int i = 35; i > 0; i--)
                    SetBit(arr, i, GetBit(arr, i - 1));
                SetBit(arr, 0, bit);
            }

            return b;
        }
    }
}
