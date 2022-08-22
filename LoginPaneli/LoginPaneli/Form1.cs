using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPaneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            bool durum = textBox2.UseSystemPasswordChar;
            if (durum)
            {
                textBox2.UseSystemPasswordChar = false;
                Pwsee.Text = "Şifreyi Gösterme";
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                Pwsee.Text = "Şifreyi göster";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length < 9 || textBox1.Text.Length > 16)
            {
                ErrorLabel.Text = "Kullanıcı adı 9 ila 16 karakterden oluşabilir";
                ErrorLabel.Visible = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mail adresinize sıfırlama kodu gönderilmiştir");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
