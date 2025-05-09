using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool PassCheck(string pass)
        {
            if (pass.Length < 8) return false;
            if (!pass.Any(char.IsLower)) return false;
            if (!pass.Any(char.IsUpper)) return false;
            if (!pass.Any(char.IsDigit)) return false;
            else
            {
                return true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            bool IsValid = PassCheck(pass);
            if (IsValid == false) MessageBox.Show("Invalid Passwoed","Invalid Passowrd", MessageBoxButtons.RetryCancel);
            if (IsValid == true) MessageBox.Show("Welcome " + user, "valid Passwoed", MessageBoxButtons.OK);

            Form2 add = new Form2();
            add.ShowDialog();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
