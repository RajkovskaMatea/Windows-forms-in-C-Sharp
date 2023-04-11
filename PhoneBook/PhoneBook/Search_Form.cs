using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Search_Form : Form
    {
        public Search_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("You must enter the id");
                return;
            }
                string fn;
                fn = "C:\\Users\\LENOVO\\source\\repos\\informations\\";
                string p;
                string r;
                //.........first name..................
                p = fn + this.textBox1.Text + "_fn.txt";
                if (System.IO.File.Exists(p) == true)
                {
                    r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                    this.Fn_textBox2.Text = r;
                }
                //........last name....................
                p = fn + this.textBox1.Text + "_ln.txt";
                if (System.IO.File.Exists(p) == true)
                {
                    r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                    this.Ln_textBox3.Text = r;
                }
                //........telephone....................
                p = fn + this.textBox1.Text + "_tel.txt";
                if (System.IO.File.Exists(p) == true)
                {
                    r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                    this.Tel_textBox4.Text = r;
                }
                //........email........................
                p = fn + this.textBox1.Text + "_email.txt";
                if (System.IO.File.Exists(p) == true)
                {
                    r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                    this.Email_textBox5.Text = r;
                }
                //........address......................
                p = fn + this.textBox1.Text + "_address.txt";
                if (System.IO.File.Exists(p) == true)
                {
                    r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                    this.Add_textBox6.Text = r;
                }
            this.ID_textBox1.Text = this.textBox1.Text;
            
        }
    }
}
