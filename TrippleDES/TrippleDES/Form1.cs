using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TrippleDES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();
            tDes.Key = md5.ComputeHash(utf8.GetBytes(textBox1.Text));
            tDes.Mode = CipherMode.ECB;
            tDes.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = tDes.CreateEncryptor();
            textBox3.Text = BitConverter.ToString(trans.TransformFinalBlock(utf8.GetBytes(textBox2.Text), 0, utf8.GetBytes(textBox2.Text).Length));
        }
    }
}
