using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSK_Grzegorz_Krzyzanski
{
    public partial class Form1 : Form
    {
        public string pathFile;
        public int messageLength;

        public void vigenereEncrypt(ref StringBuilder s, string key)
        {
        
            for (int i = 0; i < s.Length; i++)
            {
               s[i] =Char.ToUpper(s[i]);
            }
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    try
                    {
                        s[i] = (char)(s[i] + key[j] - 'A');
                    }
                    catch(Exception )
                    { 
                    }
                
                    if (s[i]>'Z')
                    {
                        s[i] = (char)(s[i] - 'Z' + 'A' - 1);
                    }
                }
                j = j + 1 == key.Length ? 0 : j + 1;
            }
        }
        public void vigenereDecrypt(ref StringBuilder s, string key)
        {
          
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = Char.ToUpper(s[i]);
            }
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    try
                    {
                        s[i] = s[i] >= key[j] ? (char)(s[i] - key[j] + 'A') : (char)('A' + ('Z' - key[j] + s[i] - 'A') + 1);
                    }
                    catch(Exception e)
                    {
                        richTextBox4_decrypt_output.Text = "Wprowadz poprawny klucz do odkodowania!";
                    }
                }
                j = j + 1 == key.Length ? 0 : j + 1;
            }
    

        }
        public Form1()
        {
            InitializeComponent();
            richTextBox3_Encrypt_Output.Enabled = false;
            richTextBox4_decrypt_output.Enabled = false;

        }

        private void button1_encrypt_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                Bitmap image = new Bitmap(pathFile);
                messageLength = richTextBox2_Encrypt_Input.TextLength;

                for (int i = 0; i < image.Width; i++)
                {
                    for (int j = 0; j < image.Height; j++)
                    {
                        Color pixel = image.GetPixel(i, j);

                        if (i < 1 && j < messageLength)
                        {
                            char letter = Convert.ToChar(richTextBox2_Encrypt_Input.Text.Substring(j, 1));
                            int wartoscASCII = Convert.ToInt32(letter);

                            image.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, wartoscASCII));
                        }
                    }
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Pliki obrazu (*.png) | *.png";
                saveFileDialog.InitialDirectory = @"C:\Users\";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathFile = saveFileDialog.FileName.ToString();
                    pictureBox1.ImageLocation = pathFile;

                    image.Save(pathFile);
                }
                richTextBox2_Encrypt_Input.Text = "";

            }


            else
            {
                StringBuilder s = new StringBuilder(richTextBox2_Encrypt_Input.Text);
                string key = textBox1_Key_Encrypt.Text;
                if (key.Length == 0 || key == null)
                {
                    key = "key";
                }
                vigenereEncrypt(ref s, key);
                richTextBox3_Encrypt_Output.Text = Convert.ToString(s);
            }
        }

        private void button1_decrypt_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Bitmap image = new Bitmap(pathFile);
                string message = "";

                for (int i = 0; i < image.Width; i++)
                {
                    for (int j = 0; j < image.Height; j++)
                    {
                        Color pixel = image.GetPixel(i, j);

                        if (i < 1 && j < messageLength)
                        {
                            int value = pixel.B;
                            char ASCIIznak = Convert.ToChar(value);
                            string letter= System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(ASCIIznak) });

                            message =message+ letter;
                        }
                    }
                }
                richTextBox4_decrypt_output.Text = message;
            }
            else
            {
                StringBuilder s = new StringBuilder(richTextBox1_Decrpt_input.Text);
                string key = textBox2_key_decrypt.Text;
                if (key.Length == 0 || key == null)
                {
                    key = "key";
                }
                vigenereDecrypt(ref s, key);
                richTextBox4_decrypt_output.Text = Convert.ToString(s);
            }
        }

        private void button1_openFile_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pliki obrazu (*.png) | *.png";
                openFile.InitialDirectory = @"C:\Users\";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    pathFile = openFile.FileName.ToString();
                    pictureBox1.ImageLocation = pathFile;
                }
                richTextBox2_Encrypt_Input.Text = "";
            }
            else
            {
                Stream myStream;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        string strfilename = openFileDialog.FileName;
                        string fileText = File.ReadAllText(strfilename);
                        richTextBox2_Encrypt_Input.Text = fileText;

                    }

                }
            }
        }

        private async void button1_save_file_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog()==DialogResult.OK)
                {
                    using(StreamWriter sw=new StreamWriter(sfd.FileName))
                    {
                        await sw.WriteLineAsync(richTextBox3_Encrypt_Output.Text);
                        MessageBox.Show("Plik został zapisany");
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_Encrypt_Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
