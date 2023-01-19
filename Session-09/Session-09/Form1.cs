using CalculateOperations;

namespace Session_09
{
    public partial class Form1 : Form
         
    {
        private decimal? _value1 = null;
        private decimal? _value2= null;
        private decimal? _result= null;

        private CalcOperation _calcOperation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (_result != null)
            {
                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result= null;
            }
            if (_value1 == null)
            {
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
            }
            ctrlDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {
                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }
            if (_value1 == null)
            {
                _value1 = 2;
            }
            else
            {
                _value2 = 2;
            }
            ctrlDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += "9";
        }

        private void Result_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += "=";

            switch (_calcOperation)
            {
                case CalcOperation.Addition:
                    class1 addition = new class1();
                    _result = addition.Addition(_value1, _value2);
                    break;
            }
            ctrlDisplay.Text += _result;
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += "+";
            _calcOperation = CalcOperation.Addition;
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}