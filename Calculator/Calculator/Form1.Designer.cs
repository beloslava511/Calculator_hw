
namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnMMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 70);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMC
            // 
            this.btnMC.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnMC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMC.Location = new System.Drawing.Point(12, 111);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(70, 68);
            this.btnMC.TabIndex = 1;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.DigitCalculate_Click);
            // 
            // btnMR
            // 
            this.btnMR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnMR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMR.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMR.Location = new System.Drawing.Point(88, 112);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(70, 68);
            this.btnMR.TabIndex = 2;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.DigitCalculate_Click);
            // 
            // btnMPlus
            // 
            this.btnMPlus.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnMPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMPlus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMPlus.Location = new System.Drawing.Point(164, 111);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(70, 68);
            this.btnMPlus.TabIndex = 3;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = true;
            this.btnMPlus.Click += new System.EventHandler(this.DigitCalculate_Click);
            // 
            // btnMMinus
            // 
            this.btnMMinus.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnMMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMinus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMMinus.Location = new System.Drawing.Point(240, 111);
            this.btnMMinus.Name = "btnMMinus";
            this.btnMMinus.Size = new System.Drawing.Size(70, 68);
            this.btnMMinus.TabIndex = 4;
            this.btnMMinus.Text = "M-";
            this.btnMMinus.UseVisualStyleBackColor = true;
            this.btnMMinus.Click += new System.EventHandler(this.DigitCalculate_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(302, 414);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(70, 68);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.DigitCalculate_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnDiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDiv.Location = new System.Drawing.Point(302, 185);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(70, 68);
            this.btnDiv.TabIndex = 6;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.DigitCalculate_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnPoint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPoint.Location = new System.Drawing.Point(185, 488);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(70, 68);
            this.btnPoint.TabIndex = 7;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(226, 187);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 66);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnPlusMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusMinus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlusMinus.Location = new System.Drawing.Point(33, 488);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(70, 68);
            this.btnPlusMinus.TabIndex = 9;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(302, 340);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(70, 68);
            this.btnMinus.TabIndex = 10;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.DigitCalculate_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEqual.Location = new System.Drawing.Point(302, 488);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(70, 68);
            this.btnEqual.TabIndex = 11;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.DigitCalculate_Click);
            // 
            // btnMult
            // 
            this.btnMult.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnMult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMult.Location = new System.Drawing.Point(302, 266);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(70, 68);
            this.btnMult.TabIndex = 12;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.DigitCalculate_Click);
            // 
            // btn0
            // 
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(109, 488);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(70, 68);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.DigitButton_click);
            // 
            // btn3
            // 
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(185, 414);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 68);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.DigitButton_click);
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(109, 414);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 68);
            this.btn2.TabIndex = 16;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.DigitButton_click);
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(33, 414);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 68);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.DigitButton_click);
            // 
            // btn6
            // 
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(185, 340);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 68);
            this.btn6.TabIndex = 18;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.DigitButton_click);
            // 
            // btn5
            // 
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(109, 340);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 68);
            this.btn5.TabIndex = 19;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.DigitButton_click);
            // 
            // btn4
            // 
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(33, 340);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 68);
            this.btn4.TabIndex = 20;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.DigitButton_click);
            // 
            // btn9
            // 
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(185, 266);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 68);
            this.btn9.TabIndex = 21;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.DigitButton_click);
            // 
            // btn8
            // 
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(109, 266);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 68);
            this.btn8.TabIndex = 22;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.DigitButton_click);
            // 
            // btn7
            // 
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(33, 266);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 68);
            this.btn7.TabIndex = 23;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.DigitButton_click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSqrt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSqrt.Location = new System.Drawing.Point(12, 186);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(70, 68);
            this.btnSqrt.TabIndex = 24;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click_1);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(410, 604);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMMinus);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.textBox1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnMMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnSqrt;
    }
}

