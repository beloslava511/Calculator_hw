using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        string Result;
        double EndResult;

        string CheckForManipulation;
        private decimal MemoryStore = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            btn0.Click += new EventHandler(DigitButton_click);
            btn1.Click += new EventHandler(DigitButton_click);
            btn2.Click += new EventHandler(DigitButton_click);
            btn3.Click += new EventHandler(DigitButton_click);
            btn4.Click += new EventHandler(DigitButton_click);
            btn5.Click += new EventHandler(DigitButton_click);
            btn6.Click += new EventHandler(DigitButton_click);
            btn7.Click += new EventHandler(DigitButton_click);
            btn8.Click += new EventHandler(DigitButton_click);
            btn9.Click += new EventHandler(DigitButton_click);


            btnPlus.Click += new EventHandler(DigitCalculate_Click);
            btnMinus.Click += new EventHandler(DigitCalculate_Click);
            btnMult.Click += new EventHandler(DigitCalculate_Click);
            btnDiv.Click += new EventHandler(DigitCalculate_Click);


            btnMC.Click += new EventHandler(DigitCalculate_Click);
            btnMR.Click += new EventHandler(DigitCalculate_Click);
            btnMMinus.Click += new EventHandler(DigitCalculate_Click);
            btnMPlus.Click += new EventHandler(DigitCalculate_Click);

            btnEqual.Click += new System.EventHandler(this.DigitCalculate_Click);
            
        }

        void DigitButton_click(object sender, EventArgs e)
        {
            Button ButtonThatWasPushed = (Button)sender;
            textBox1.Text += ButtonThatWasPushed.Text;  
        }


        void DigitCalculate_Click(object sender, EventArgs e)
        {
            Button ButtonThatWasPushed = (Button)sender;
            string ButtonText = ButtonThatWasPushed.Text;


            if (textBox1.Text != string.Empty)
            {
                double valueHolder1 = Convert.ToDouble(textBox1.Text);
            }

            if (ButtonText == "+")
            {


                Result = textBox1.Text;
                CheckForManipulation = "Add";
                textBox1.Clear();
                textBox1.Focus();


            }
            else if (ButtonText == "-")
            {

                Result = textBox1.Text;
                CheckForManipulation = "Substract";
                textBox1.Clear();
                textBox1.Focus();

            }
            else if (ButtonText == "*")
            {

                Result = textBox1.Text;
                CheckForManipulation = "Multiply";
                textBox1.Clear();
                textBox1.Focus();
            }
            else if (ButtonText == "/")
            {

                Result = textBox1.Text;
                CheckForManipulation = "Division";
                textBox1.Clear();
                textBox1.Focus();
            }

            if (ButtonText == "MC")
            {
                this.MemoryStore = 0;
                return;
            }

            if (ButtonText == "MR")
            {
                textBox1.Text = this.MemoryStore.ToString();
                return;
            }

            if (ButtonText == "M-")
            {
                this.MemoryStore -= Convert.ToDecimal(this.EndResult);
                return;
            }

            if (ButtonText == "M+")
            {
                this.MemoryStore += Convert.ToDecimal(this.EndResult);
                return;

            }

            if (textBox1.Text != string.Empty && Result != string.Empty)
            {
                double valueHolder2 = Convert.ToDouble(textBox1.Text);
                double chk = Convert.ToDouble(Result);
                if (CheckForManipulation == "Add")
                {

                    EndResult = chk + valueHolder2;
                    textBox1.Text = EndResult.ToString();

                }
                else if (CheckForManipulation == "Substract")
                {

                    EndResult = chk - valueHolder2;
                    textBox1.Text = EndResult.ToString();
                }
                else if (CheckForManipulation == "Multiply")
                {

                    EndResult = chk * valueHolder2;
                    textBox1.Text = EndResult.ToString();
                }
                else if (CheckForManipulation == "Division")
                {

                    if (valueHolder2 == 0)
                    {
                        textBox1.Text = "Cannot divide by Zero";
                        return;
                    }
                    EndResult = chk / valueHolder2;
                    textBox1.Text = EndResult.ToString();
                }

            }

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();

        }

        private void btnSqrt_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                double SqrRoot = Math.Sqrt(Convert.ToDouble(this.textBox1.Text));
                textBox1.Text = SqrRoot.ToString();
            }

        }

        private void btnPoint_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text;
            }

            else
            {
                textBox1.Text = textBox1.Text + ".";
            }

        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                double chk = Convert.ToDouble(this.textBox1.Text);
                chk = -chk;
                textBox1.Text = chk.ToString();
            }

        }
    }
}



        
    

