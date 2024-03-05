namespace Main9
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void First_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void Plus_Click(object sender, EventArgs e)
        {
            sign.Text = "+";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Minus_Click(object sender, EventArgs e)
        {
            sign.Text = "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            sign.Text = "*";
        }

        private void decide_Click(object sender, EventArgs e)
        {
            sign.Text = "/";
        }

        private void equal_Click(object sender, EventArgs e)
        {

            double num1 = double.Parse(First_num.Text);
            double num2 = double.Parse(Second_num.Text);
            switch (sign.Text)
            {
                case "+":
                    Value.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    Value.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    Value.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    Value.Text = Convert.ToString(num1 / num2);
                    break;
                default:
                    Value.Text = sign.Text;
                    break;
            }


        }

        private void Btn_conv_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2();
            Form2.Show();
        }
    }
}
