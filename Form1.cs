using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Hasher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Hash = "";
        class LoginEncrpyt
        {

            public static string HashString(string passwordString)
            {
                StringBuilder sb = new StringBuilder();
                foreach (byte b in GetHash(passwordString))
                    sb.Append(b.ToString("x3"));
                return sb.ToString();
            }

            public static byte[] GetHash(string passwordString)
            {
                using (HashAlgorithm algorithm = SHA256.Create())
                    return algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordString));
            }
        }


        private void btnHash_Click(object sender, EventArgs e)
        {
            Hash = LoginEncrpyt.HashString(txtHash.Text);
            txtEndHash.Text = Hash;

        }
    }
}
