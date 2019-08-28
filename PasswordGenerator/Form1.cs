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

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private delegate void InvokePasswordGenerator();
        private event InvokePasswordGenerator invoker;

        const string lower = "abcdefghijklmnopqrstuvwzyx";

        string upper => lower.ToUpper();

        const string numbers = "0123456789";

        const string specials = "~`!@#$%^&*()-_=+[{]}:;'<,>.?/";

        public Form1()
        {
            InitializeComponent();

            invoker += Generate;

            KeyPreview = true;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            invoker.Invoke();
        }

        private void Generate()
        {
            if (nudLength.Value > 0)
            {
                int length = int.Parse(nudLength.Value.ToString());
                char[] text;

                if (cbSymbols.Checked)
                    text = (lower + upper + numbers + specials).ToCharArray();
                else
                    text = (lower + upper + numbers).ToCharArray();

                byte[] data = new byte[length];
                using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
                {
                    crypto.GetBytes(data);
                }
                StringBuilder result = new StringBuilder(length);
                foreach (byte b in data)
                {
                    result.Append(text[b % (text.Length)]);
                }

                tbResult.Text = result.ToString();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                invoker.Invoke();
            }

            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            {
                Clipboard.SetText(tbResult.Text);
            }
        }
    }
}
