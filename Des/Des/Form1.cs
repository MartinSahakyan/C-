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
using System.IO;
namespace Des
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Encrypt()
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] key = ASCIIEncoding.ASCII.GetBytes("asxcvfds");
            byte[] iv = ASCIIEncoding.ASCII.GetBytes("cxxcdkkk");
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, iv), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);
            sw.Write(textBox1.Text);
            sw.Flush();
            cs.FlushFinalBlock();
            sw.Flush();
            return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
        }

        private string Decrypt()
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] key = ASCIIEncoding.ASCII.GetBytes("asxcvfds");
            byte[] iv = ASCIIEncoding.ASCII.GetBytes("cxxcdkkk");
            MemoryStream ms = new MemoryStream(Convert.FromBase64String(textBox2.Text));
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, iv), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Encrypt();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Decrypt();
        }

        
    }
}
