using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fenetre_de_login
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "vous")
            {
                if (textBox2.Text == "password")

                    //si le mot de passe et le login est bon alors sa ouvre une fentre
                    //sinon ca rend "mot de passe incorrect" visible
                {
                    Form2 f = new Form2();
                    f.Show();
                    this.Hide(); //cache l'interface d'authentifi

                }
                else
                    label3.Visible = true;
            }

        }
    }
}
