using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Practice
{
    public partial class Form1 : Form
    {
        //Variables
        int num1;
        int num2;
        
        //others

        public Form1()
        {
            InitializeComponent();
        }

        public void Exec(object Op)
        {
            if ((int.TryParse(box1.Text, out num1)) && (int.TryParse(box2.Text, out num2)))
            {
                Sol(Op);
            }
            else
            {
                MessageBox.Show("Please input only numbers");
            }
        }

        void Sol(object operation)
        {
            int x;

            void RDisplay()
            {
                ResultLabel.Text = x.ToString();
            }

            switch (operation)
            {
                case "+":
                    x = num1 + num2;
                    RDisplay();
                    break;
                case "-":
                    x = num1 - num2;
                    RDisplay();
                    break;
                case "*":
                    x = num1 * num2;
                    RDisplay();
                    break;
                case "/":
                    x = num1 / num2;
                    RDisplay();
                    break;

            }


        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            Exec("+");
        }

        private void SubBut_Click(object sender, EventArgs e)
        {
            Exec("-");
        }

        private void MulBut_Click(object sender, EventArgs e)
        {
            Exec("*");

        }

        private void DivBut_Click(object sender, EventArgs e)
        {
            Exec("/");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            box1.Text = "";
            box2.Text = "";
            ResultLabel.Text = "*ANSWER*";
        }
    }
}
