using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "7";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "1";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "4";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "5";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "6";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "9";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "*";
            /* if (this.main_num_label1.Text == "0")
             {

             }*/
            this.first_num_label.Text = this.main_num_label1.Text;

            this.main_num_label1.Text = "";
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "+";
            //If operator label is + show the operator in the label//
           // if (this.main_num_label1.Text == "0")
           // {
                this.first_num_label.Text = this.main_num_label1.Text;
           // }
            //If main num label is equal to nothing then do nothing else//
            this.main_num_label1.Text = "";
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "-";
            //if (this.main_num_label1.Text == "0")
           // {
                this.first_num_label.Text = this.main_num_label1.Text;
           // }

            this.main_num_label1.Text = "";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "%";
            //if (this.main_num_label1.Text == "0")
            //{
                this.first_num_label.Text = this.main_num_label1.Text;
           // }

            this.main_num_label1.Text = "";
        }

        private void operator_label_Click(object sender, EventArgs e)
        {
            
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            double fn;
            double sn;
            double r;
            //----------------------------
            double.TryParse(this.first_num_label.Text, out fn);
            double.TryParse(this.main_num_label1.Text, out sn);
            r = 0;
            //----------------------------
            if (this.operator_label.Text == "+")
            {
                r = fn + sn;
            }
            //--------------------------------
            if (this.operator_label.Text == "-")
            {
                r = fn - sn;
            }
            //--------------------------------
            if (this.operator_label.Text == "*")
            {
                r = fn * sn;
            }
            //--------------------------------
            if (this.operator_label.Text == "%")
            {
                r = fn / sn;
            }
            //-------------------------------- 
            this.main_num_label1.Text = r.ToString();
            this.operator_label.Text = "";
            this.first_num_label.ResetText();
        }

        private void first_num_label_Click(object sender, EventArgs e)
        {

        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + ".";
        }
    }
}

