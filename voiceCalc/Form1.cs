using System;
using System.Windows.Forms;
using System.Drawing;


namespace VoiceCalc 
{
    public partial class Calculator : Form
    {
        
        MathematicalExpressionBuilder myExpressionBuilder = null; //gör plats för
        string result = "";
       

        public Calculator()
        { 
            InitializeComponent();
            myExpressionBuilder = new MathematicalExpressionBuilder(this); //skapar
        }

        #region Buttons

        private void myBtn(string newInput)
        {
            myExpressionBuilder.SetCurrentExpression(myExpressionBuilder.GetCurrentExpression() + newInput);
            inputBox.Text = myExpressionBuilder.GetCurrentExpression();
            headingLabel.Focus();
        }

        
        private void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            myBtn(b.Text);

            //Försöker göra så att varje tal endast innehåller 1 kommatecken. misslyckas. 
            //if (b.Text == ",")
            //{
            //    if (!inputBox.Text.Contains(","))
            //        myBtn(b.Text);
            //}
            //else
            //    myBtn(b.Text);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            myExpressionBuilder.ResetAllData();
            inputBox.Text = myExpressionBuilder.GetCurrentExpression();
            resultBox.Text = "";
            headingLabel.Focus();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            myExpressionBuilder.ResetAllData();
            inputBox.Text = myExpressionBuilder.GetCurrentExpression();
            resultBox.Text = "";
            myExpressionBuilder.ResetMathematicalExpressionBuilderData();
            if (myExpressionBuilder.IsSpeechRecognitionOn())
            {
                
                myExpressionBuilder.StopSpeechRecognition();
                EnableButtons();
            }
            else
            {
                
                myExpressionBuilder.StartSpeechRecognition();
                DisableButtons();
            }
            headingLabel.Focus();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            resultBox.Text = MathematicalExpressionEvaluator.EvaluateMathematicalExpression(inputBox.Text).ToString();
           // result = resultBox.Text; //global variabel gjorde metod.
            headingLabel.Focus();
        }

        public string getResult()
        {
            result = resultBox.Text;
            return result;
        }

        #endregion

        private bool IsOperand(string op)
        {
            return (op != "+" && op != "-" && op != "*" && op != ":" && op != "(" && op != ")");
        }

        private bool IsOperator(string op)
        {
            return (op == "+" || op == "-" || op == "*" || op == ":");
        }

        public void setInputBoxText(string newInput)
        {
            inputBox.Text = newInput;
        }

        public void extendInputBoxText(string newInput)
        {
            inputBox.Text += newInput;
        }

        public void ExternalButton_Click(string btnName)
        {
            switch (btnName)
            {
                case "equals":
                    btnEquals_Click(btnEquals, EventArgs.Empty);
                    
                    break;
                case "clear":
                    btnDeleteAll_Click(btnDeleteAll, EventArgs.Empty);
                    break;
                case "mute":
                    btnMute_Click(btnMute, EventArgs.Empty);
                    break;
                default:
                    break;
            }
        }

        private void EnableButtons()
        {
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnBracketOpen.Enabled = true;
            btnBracketClose.Enabled = true;
            btnPlus.Enabled = true;
            btnMinus.Enabled = true;
            btnMultiply.Enabled = true;
            btnDivide.Enabled = true;
            btnDecimalPoint.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnEquals.Enabled = true;
        }

        private void DisableButtons()
        {
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnBracketOpen.Enabled = false;
            btnBracketClose.Enabled = false;
            btnPlus.Enabled = false;
            btnMinus.Enabled = false;
            btnMultiply.Enabled = false;
            btnDivide.Enabled = false;
            btnDecimalPoint.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnEquals.Enabled = false;
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }


}
