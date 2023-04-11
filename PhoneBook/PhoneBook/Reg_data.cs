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
    public partial class Reg_data : Form
    {
        public Reg_data()
        {
            InitializeComponent();
        }

        private void New_button_Click(object sender, EventArgs e)
        {
            this.Save_button.Enabled = true;
            this.New_button.Enabled = false;

            this.Info_gbox.Enabled = true;
            //Clear textboxes
            this.ID_textBox1.Text = "";
            //this.ID_textBox1.ResetText();
            this.Fn_textBox2.ResetText();
            this.Ln_textBox3.ResetText();
            this.Tel_textBox4.ResetText();
            this.Email_textBox5.ResetText();
            this.Add_textBox6.ResetText();
        }

        private void Reg_data_Load(object sender, EventArgs e)
        {
            this.Info_gbox.Enabled=false;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (this.ID_textBox1.Text == "")
            {
                MessageBox.Show("You must enter the ID");
                return;
            }
            this.Save_button.Enabled = false;
            this.New_button.Enabled = true;
            this.Info_gbox.Enabled = false;
            
            string fn;
            fn = "C:\\Users\\LENOVO\\source\\repos\\informations\\";
            string p;
            p = fn + this.ID_textBox1.Text+ "_fn.txt";
            System.IO.File.WriteAllText(p, this.Fn_textBox2.Text, Encoding.UTF8);

            p = fn + this.ID_textBox1.Text + "_ln.txt";
            System.IO.File.WriteAllText(p, this.Ln_textBox3.Text, Encoding.UTF8);

            p = fn + this.ID_textBox1.Text + "_tel.txt";
            System.IO.File.WriteAllText(p, this.Tel_textBox4.Text, Encoding.UTF8);

            p = fn + this.ID_textBox1.Text + "_email.txt";
            System.IO.File.WriteAllText(p, this.Email_textBox5.Text, Encoding.UTF8);

            p = fn + this.ID_textBox1.Text + "_address.txt";
            System.IO.File.WriteAllText(p, this.Add_textBox6.Text, Encoding.UTF8);

            MessageBox.Show("Saved successfully");

        }

        
        
    }
}
