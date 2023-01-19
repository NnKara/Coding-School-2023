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
            if (_result != null)
            {
                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }
            if (_value1 == null)
            {
                _value1 = 3;
            }
            else
            {
                _value2 =3 ;
            }
            ctrlDisplay.Text += "3";
        }
        
    

        private void button4_Click(object sender, EventArgs e)
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
                _value1 = 4;
            }
            else
            {
                _value2 = 4;
            }
            ctrlDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
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
                _value1 = 5;
            }
            else
            {
                _value2 = 5;
            }
            ctrlDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
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
                _value1 = 6;
            }
            else
            {
                _value2 = 6;
            }
            ctrlDisplay.Text += "6"; ;
        }

        private void button7_Click(object sender, EventArgs e)
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
                _value1 = 7;
            }
            else
            {
                _value2 = 7;
            }
            ctrlDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
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
                _value1 = 8;
            }
            else
            {
                _value2 = 8;
            }
            ctrlDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
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
                _value1 = 9;
            }
            else
            {
                _value2 = 9;
            }
            ctrlDisplay.Text += "9";
        }

        private void Result_Click(object sender, EventArgs e)
        {
            Calculation calculation = new Calculation();
            ctrlDisplay.Text += "=";

            switch (_calcOperation)
            {
                case CalcOperation.Addition:                   
                    _result = calculation.Addition(_value1, _value2);
                    break;

                case CalcOperation.Substraction:
                    _result=calculation.Subtraction(_value1, _value2);
                    break;

                    case CalcOperation.Multiplication:
                    _result = calculation.Multiplication(_value1, _value2);
                    break;

                case CalcOperation.Division:
                    _result=calculation.Division(_value1, _value2);
                    break;

                case CalcOperation.Power:
                    _result = calculation.Power(_value1, _value2);
                    break;

                case CalcOperation.SquareRoot:
                    
                    _result = calculation.SquareRoot(_value1);
                    break;


                default:
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

        private void button10_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += "/";
            _calcOperation = CalcOperation.Division;
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += "-";
            _calcOperation = CalcOperation.Substraction;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += "*";
            _calcOperation = CalcOperation.Multiplication;
        }

        private void button11_Click(object sender, EventArgs e)
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
                _value1 = 0;
            }
            else
            {
                _value2 = 0;
            }
            ctrlDisplay.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += "^";
            _calcOperation = CalcOperation.Power;
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += "RootOf"; 
            _calcOperation = CalcOperation.SquareRoot;
        }
    }
}