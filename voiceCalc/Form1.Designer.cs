namespace VoiceCalc
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnBracketClose = new System.Windows.Forms.Button();
            this.btnBracketOpen = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDecimalPoint = new System.Windows.Forms.Button();
            this.headingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.White;
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(43, 51);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.ReadOnly = true;
            this.inputBox.Size = new System.Drawing.Size(206, 63);
            this.inputBox.TabIndex = 0;
            this.inputBox.TabStop = false;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.White;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(267, 51);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(75, 63);
            this.resultBox.TabIndex = 1;
            this.resultBox.TabStop = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(43, 120);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(53, 51);
            this.btn7.TabIndex = 2;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(119, 120);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(53, 51);
            this.btn8.TabIndex = 3;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(196, 120);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(53, 51);
            this.btn9.TabIndex = 4;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(196, 194);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(53, 51);
            this.btn6.TabIndex = 7;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(119, 194);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(53, 51);
            this.btn5.TabIndex = 6;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(43, 194);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(53, 51);
            this.btn4.TabIndex = 5;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(196, 270);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(53, 51);
            this.btn3.TabIndex = 10;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(119, 270);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(53, 51);
            this.btn2.TabIndex = 9;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(43, 270);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(53, 51);
            this.btn1.TabIndex = 8;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.White;
            this.btnDivide.Location = new System.Drawing.Point(267, 270);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 51);
            this.btnDivide.TabIndex = 13;
            this.btnDivide.TabStop = false;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.White;
            this.btnMinus.Location = new System.Drawing.Point(267, 194);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 51);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.TabStop = false;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.Location = new System.Drawing.Point(267, 120);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 51);
            this.btnPlus.TabIndex = 11;
            this.btnPlus.TabStop = false;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.White;
            this.btnMultiply.Location = new System.Drawing.Point(267, 346);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 51);
            this.btnMultiply.TabIndex = 17;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(119, 346);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(53, 51);
            this.btn0.TabIndex = 15;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnBracketClose
            // 
            this.btnBracketClose.BackColor = System.Drawing.Color.White;
            this.btnBracketClose.Location = new System.Drawing.Point(196, 346);
            this.btnBracketClose.Name = "btnBracketClose";
            this.btnBracketClose.Size = new System.Drawing.Size(53, 51);
            this.btnBracketClose.TabIndex = 19;
            this.btnBracketClose.TabStop = false;
            this.btnBracketClose.Text = ")";
            this.btnBracketClose.UseVisualStyleBackColor = false;
            this.btnBracketClose.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnBracketOpen
            // 
            this.btnBracketOpen.BackColor = System.Drawing.Color.White;
            this.btnBracketOpen.Location = new System.Drawing.Point(43, 346);
            this.btnBracketOpen.Name = "btnBracketOpen";
            this.btnBracketOpen.Size = new System.Drawing.Size(53, 51);
            this.btnBracketOpen.TabIndex = 18;
            this.btnBracketOpen.TabStop = false;
            this.btnBracketOpen.Text = "(";
            this.btnBracketOpen.UseVisualStyleBackColor = false;
            this.btnBracketOpen.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.White;
            this.btnDeleteAll.Location = new System.Drawing.Point(196, 418);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(53, 51);
            this.btnDeleteAll.TabIndex = 23;
            this.btnDeleteAll.TabStop = false;
            this.btnDeleteAll.Text = "C";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.Color.White;
            this.btnMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMute.Location = new System.Drawing.Point(43, 418);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(53, 51);
            this.btnMute.TabIndex = 22;
            this.btnMute.TabStop = false;
            this.btnMute.Text = "🎤 ";
            this.btnMute.UseVisualStyleBackColor = false;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.White;
            this.btnEquals.Location = new System.Drawing.Point(267, 418);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(75, 51);
            this.btnEquals.TabIndex = 21;
            this.btnEquals.TabStop = false;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnDecimalPoint
            // 
            this.btnDecimalPoint.BackColor = System.Drawing.Color.White;
            this.btnDecimalPoint.Location = new System.Drawing.Point(119, 418);
            this.btnDecimalPoint.Name = "btnDecimalPoint";
            this.btnDecimalPoint.Size = new System.Drawing.Size(53, 51);
            this.btnDecimalPoint.TabIndex = 20;
            this.btnDecimalPoint.TabStop = false;
            this.btnDecimalPoint.Text = ",";
            this.btnDecimalPoint.UseVisualStyleBackColor = false;
            this.btnDecimalPoint.Click += new System.EventHandler(this.btn_Click);
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.ForeColor = System.Drawing.Color.White;
            this.headingLabel.Location = new System.Drawing.Point(39, 9);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(296, 21);
            this.headingLabel.TabIndex = 24;
            this.headingLabel.Text = "Hej bara här kan en snacka";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(388, 507);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDecimalPoint);
            this.Controls.Add(this.btnBracketClose);
            this.Controls.Add(this.btnBracketOpen);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.inputBox);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "🎤 ";
            this.Text = "Voice Controlled Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnBracketClose;
        private System.Windows.Forms.Button btnBracketOpen;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDecimalPoint;
        private System.Windows.Forms.Label headingLabel;
    }
}

