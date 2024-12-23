namespace NET_09._EventArgs_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addButton.Click += Caluclator;
            addButton.Click += ChangeColor;
            subtractButton.Click += Caluclator;
            multipleButton.Click += Caluclator;
            divideButton.Click += Caluclator;
        }

        private void Caluclator(object sender, EventArgs e)
        {
            int left = int.Parse(firstNumber.Text);
            int right = int.Parse(secondNumber.Text);
            var btn = sender as Button;
            if (btn.Name == "addButton")
            {
                resultLabel.Text = (left + right).ToString();
            }
            else if (btn.Name == "subtractButton")
            {
                resultLabel.Text = (left - right).ToString();
            }
            if (btn.Name == "multipleButton")
            {
                resultLabel.Text = (left * right).ToString();
            }
            if (btn.Name == "divideButton")
            {
                if (right != 0)
                {
                    resultLabel.Text = ((float)left / right).ToString();
                }
                else
                {
                    resultLabel.Text = "Can't divide by zero";
                }
            }
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
