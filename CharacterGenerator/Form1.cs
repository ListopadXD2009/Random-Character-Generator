using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterGenerator
{
    public partial class Form1 : Form
    {
        private static Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private static string GenerateGibberish(int nLength)
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+=<>?";
            StringBuilder sb = new StringBuilder(nLength);

            for (int i = 0; i < nLength; i++)
            {
                sb.Append(chars[random.Next(chars.Length)]);
            }

            return sb.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = GenerateGibberish(random.Next(34));
        }
    }
}

