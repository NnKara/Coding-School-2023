using CalculateOperations;

namespace Session_09
{
    public partial class Form1 : Form
         
    {
        private decimal? _value1 = null;
        private decimal? _value2= null;
        private decimal? _result= null;
        public Form1()
        {
            InitializeComponent();
            _calcOperation = CalcOperation.None;
        }


       

        private CalcOperation _calcOperation;
       

        private void button1_Click(object sender, EventArgs e)
        {          
            UpdateValue(1);
            AppendToDisplay("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateValue(2);
            AppendToDisplay("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateValue(3);
            AppendToDisplay("3");
        }
        
    

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateValue(4);
            AppendToDisplay("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateValue(5);
            AppendToDisplay("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateValue(6);
            AppendToDisplay("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UpdateValue(7);
            AppendToDisplay("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateValue(8);
            AppendToDisplay("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UpdateValue(9);
            AppendToDisplay("9");
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
                    _calcOperation = CalcOperation.None;
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
            UpdateValue(0);
            AppendToDisplay("0");
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


        private void UpdateValue(decimal? number)
        {
            if (_result != null)
            {
                _value1 = _result;
                _value2 = null;
                _result = null;
            }

            if (_value1 == null)
            {
                _value1 = number;
            }
            else
            {
                _value2 = number;
            }
        }

        private void AppendToDisplay(String text)
        {
            ctrlDisplay.Text += text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _value1 = null;
            _value2 = null;
            _result = null;
            _calcOperation = CalcOperation.None;
            ctrlDisplay.Text = string.Empty;
        }
    }

}