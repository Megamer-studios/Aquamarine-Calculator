namespace AquamarineCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(richTextBox1.Text);
            int num2 = Convert.ToInt32(richTextBox2.Text);
            int outputI = num1 + num2;
            string output = outputI.ToString();
            richTextBox3.Text = output;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(richTextBox1.Text);
            int num2 = Convert.ToInt32(richTextBox2.Text);
            int outputI = num1 - num2;
            string output = outputI.ToString();
            richTextBox3.Text = output;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(richTextBox1.Text);
            int num2 = Convert.ToInt32(richTextBox2.Text);
            int outputI = num1 * num2;
            string output = outputI.ToString();
            richTextBox3.Text = output;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(richTextBox1.Text);
            int num2 = Convert.ToInt32(richTextBox2.Text);
            int outputI = num1 / num2;
            string output = outputI.ToString();
            richTextBox3.Text = output;
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox3.Text);
        }
    }
}
