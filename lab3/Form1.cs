using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        List<IOperation> operations;
        List<TextBox> textBoxes;
        public Form1()
        {
            InitializeComponent();
            operations = new List<IOperation>
            {
                new Addition(),
                new Subtraction(),
                new Multiplication(),
                new Division()
            };
            textBoxes = new List<TextBox>
            {
                FirstArgTextBox,
                SecondArgTextBox,
                SignTextBox
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void FirstArgTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxesValuesValid())
            {
                PerformOperation();
            }
        }

        private void FirstArgTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8)
            {
                return;
            }
            e.Handled = true;
        }   

        private void SecondArgTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8)
            {
                return;
            }
            e.Handled = true;
        }

        private void SignTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {            
            switch (e.KeyChar)
            {
                case '+':
                    return;
                case '-':
                    return;
                case '/':
                    return;
                case '*':
                    return;
                case (char)8:
                    return;
            }
            e.Handled = true;           
        }

        private bool TextBoxesValuesValid()
        {
            foreach(var textbox in textBoxes)
            {
                if (string.IsNullOrEmpty(textbox.Text))
                {
                    OperationLabel.Text = "";
                    SignLabel.Text = "";
                    ResultLabel.Text = "";
                    return false;
                }
            }
            return true;
        }
        private void PerformOperation()
        {
            foreach(var operation in operations)
            {
                if (operation.GetOperationSign() == SignTextBox.Text)
                {
                    ResultLabel.Text = operation.GetOperationResult(float.Parse(FirstArgTextBox.Text), float.Parse(SecondArgTextBox.Text)).ToString();
                    OperationLabel.Text = operation.GetOperationName();
                    SignLabel.Text = operation.GetOperationSign();
                }
            }
        }

        private void SecondArgTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxesValuesValid())
            {
                PerformOperation();
            }
        }

        private void SignTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxesValuesValid())
            {
                PerformOperation();
            }
        }
    }
}
