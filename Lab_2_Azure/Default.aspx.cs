using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_2_Azure
{
    public partial class Default : System.Web.UI.Page
    {

        public enum Operations
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide
        }

        private static double tempValue = 0;
        private static bool beginLine = false;
        private static Operations LastOperation = Operations.None;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttn_click(string number)
        {
            if (CalcField.Text == "0" || beginLine)
            {
                beginLine = false;
                CalcField.Text = number;
            }
            else
            {
                CalcField.Text += number;
            }
        }

        protected void btnNumb0_Click(object sender, EventArgs e)
        {
            buttn_click(btn0.Text);
        }

        protected void btnNumb1_Click(object sender, EventArgs e)
        {
            buttn_click(btn1.Text);
        }

        protected void btnNumb2_Click(object sender, EventArgs e)
        {
            buttn_click(btn2.Text);
        }

        protected void btnNumb3_Click(object sender, EventArgs e)
        {
            buttn_click(btn3.Text);
        }

        protected void btnNumb4_Click(object sender, EventArgs e)
        {
            buttn_click(btn4.Text);
        }

        protected void btnNumb5_Click(object sender, EventArgs e)
        {
            buttn_click(btn5.Text);
        }

        protected void btnNumb6_Click(object sender, EventArgs e)
        {
            buttn_click(btn6.Text);
        }

        protected void btnNumb7_Click(object sender, EventArgs e)
        {
            buttn_click(btn7.Text);
        }

        protected void btnNumb8_Click(object sender, EventArgs e)
        {
            buttn_click(btn8.Text);
        }

        protected void btnNumb9_Click(object sender, EventArgs e)
        {
            buttn_click(btn9.Text);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var currentValue = double.Parse(CalcField.Text);
            ProceedLastOperation(currentValue);

            LastOperation = Operations.Add;
            CalcField.Text = tempValue.ToString();
        }

        protected void btnSubtract_Click(object sender, EventArgs e)
        {
            var currentValue = double.Parse(CalcField.Text);
            ProceedLastOperation(currentValue);

            LastOperation = Operations.Subtract;
            CalcField.Text = tempValue.ToString();
        }

        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            var currentValue = double.Parse(CalcField.Text);
            ProceedLastOperation(currentValue);

            LastOperation = Operations.Multiply;
            CalcField.Text = tempValue.ToString();
        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            var currentValue = double.Parse(CalcField.Text);
            ProceedLastOperation(currentValue);

            LastOperation = Operations.Divide;
            CalcField.Text = tempValue.ToString();
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            var currentValue = double.Parse(CalcField.Text);
            ProceedLastOperation(currentValue);

            CalcField.Text = tempValue.ToString();
            LastOperation = Operations.None;
        }

        private void ProceedLastOperation(double currentValue)
        {
            beginLine = true;
            switch (LastOperation)
            {
                case Operations.None:
                    tempValue = currentValue;
                    break;
                case Operations.Add:
                    tempValue = tempValue + currentValue;
                    break;
                case Operations.Subtract:
                    tempValue = tempValue - currentValue;
                    break;
                case Operations.Multiply:
                    tempValue = tempValue * currentValue;
                    break;
                case Operations.Divide:
                    tempValue = tempValue / currentValue;
                    break;
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            tempValue = 0;
            LastOperation = Operations.None;
            CalcField.Text = tempValue.ToString();            
        }
    }
}