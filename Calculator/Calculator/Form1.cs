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
    public partial class labelCurrent : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isoperationPerformed = false;

        public labelCurrent()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (isoperationPerformed))
                textBox.Clear();
            isoperationPerformed = false;
            Button button = (Button)sender;
            textBox.Text = textBox.Text + button.Text ;



        }

        private void oppButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox.Text);
            labelCurrentOperation.Text = resultValue + " " + operationPerformed;
            isoperationPerformed = true;
        }

        private void buttonClearentry_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            resultValue = 0;
        }

        private void buttonequals_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {

                case "+":
                    textBox.Text = (resultValue + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (resultValue - Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (resultValue * Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (resultValue / Double.Parse(textBox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCurrent_Load(object sender, EventArgs e)
        {

        }
    }
}
