using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCalculatrice
{
    
    public partial class Form1 : Form
    {
        private int resultat;
        //private int result;

        private bool initialiser;

        public Form1()
        {
            InitializeComponent();
            resultat = 0;
            initialiser = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Tag.ToString() + "+";
            resultat = resultat + int.Parse(button1.Tag.ToString());


        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Tag.ToString() + "+";
            resultat = resultat + int.Parse(button2.Tag.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Tag.ToString() + "+";
            resultat = resultat + int.Parse(button3.Tag.ToString());
      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Tag.ToString() + "+";
            resultat = resultat + int.Parse(button4.Tag.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Tag.ToString() + "+";
            resultat = resultat + int.Parse(button5.Tag.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Tag.ToString() + "+";
            resultat = resultat + int.Parse(button6.Tag.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Tag.ToString() + "+";
            resultat = resultat + int.Parse(button7.Tag.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Tag.ToString() + "+";
            resultat = resultat + int.Parse(button8.Tag.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Tag.ToString() + "+";
            resultat = resultat + int.Parse(button9.Tag.ToString());
        }

        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = "'" + resultat + "'";
            resultat = 0;
            initialiser = false;

        }
        

        

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
          
        }

       

       

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

     
      

        private void buttonCalculer_Leave(object sender, EventArgs e)
        {
            if (initialiser == false)
            {
                textBox1.Text = "";
                initialiser = true;
            }
        }

  

        private void button0_Click(object sender, EventArgs e)
        {

        }
    }
}
