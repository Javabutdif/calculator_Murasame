namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string firstNum = "";
        string secondNum = "";
        char op;
        bool indicator = false;
        int first;
        int second;
        double total;

        private void button11_Click(object sender, EventArgs e)
        {
            display.Text += button11.Text;
            op = Convert.ToChar(button11.Text);
            indicator = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text += button7.Text;
            if(!indicator)
            firstNum += Convert.ToInt32(button7.Text);
            else
            secondNum += Convert.ToInt32(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text += button8.Text;
            if (!indicator)
                firstNum += Convert.ToInt32(button8.Text);
            else
                secondNum += Convert.ToInt32(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text += button9.Text;
            if (!indicator)
                firstNum += Convert.ToInt32(button9.Text);
            else
                secondNum += Convert.ToInt32(button9.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text += button4.Text;
            if (!indicator)
                firstNum += Convert.ToInt32(button4.Text);
            else
                secondNum += Convert.ToInt32(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text += button5.Text;
            if (!indicator)
                firstNum += Convert.ToInt32(button5.Text);
            else
                secondNum += Convert.ToInt32(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text += button6.Text;
            if (!indicator)
                firstNum += Convert.ToInt32(button6.Text);
            else
                secondNum += Convert.ToInt32(button6.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text += button1.Text;
            if (!indicator)
                firstNum += Convert.ToInt32(button1.Text);
            else
                secondNum += Convert.ToInt32(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text += button2.Text;
            if (!indicator)
                firstNum += Convert.ToInt32(button2.Text);
            else
                secondNum += Convert.ToInt32(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text += button3.Text;
            if (!indicator)
                firstNum += Convert.ToInt32(button3.Text);
            else
                secondNum += Convert.ToInt32(button3.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display.Text += button10.Text;  
            op =Convert.ToChar( button10.Text);
            indicator = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            first = Convert.ToInt32(firstNum);
            second = Convert.ToInt32(secondNum);
          
            if (op == '+')
            {

                total = first + second;
                display.Text = Convert.ToString(total);
                second = 0;
                indicator = true;
                secondNum = "";
                firstNum = Convert.ToString(total);
            }
            if (op == '-')
            {
                
                total = first - second;
                display.Text = Convert.ToString(total);
                second = 0;
                indicator = true;
                secondNum = "";
                firstNum = Convert.ToString(total);
            }
            if (op == '/') {
                
                total = first / second;
                display.Text = Convert.ToString(total);
                second = 0;
                indicator = true;
                secondNum = "";
                firstNum = Convert.ToString(total);
            }
            if (op == 'x')
            {
              
                total = first * second;
                display.Text = Convert.ToString(total);
                second = 0;
                indicator = true;
                secondNum = "";
                firstNum = Convert.ToString(total);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstNum = "";
            secondNum = "";
            first = 0;
            second = 0;
            op = ' ';
            indicator = false;
            display.Text = "";
            total = 0;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            display.Text += button13.Text;
            op = Convert.ToChar(button13.Text);
            indicator = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            display.Text += button12.Text;
            op = Convert.ToChar(button12.Text);
            indicator = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            display.Text += button14.Text;
            if (!indicator)
                firstNum += Convert.ToInt32(button14.Text);
            else
                secondNum += Convert.ToInt32(button14.Text);
        }
    }
}