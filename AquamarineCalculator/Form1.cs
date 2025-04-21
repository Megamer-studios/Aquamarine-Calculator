using System.Diagnostics;
using System.Globalization;

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
            float num1 = float.Parse(richTextBox1.Text, CultureInfo.InvariantCulture);
            float num2 = float.Parse(richTextBox2.Text, CultureInfo.InvariantCulture);
            float outputI = num1 + num2;
            string output = outputI.ToString();
            richTextBox3.Text = output;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(richTextBox1.Text, CultureInfo.InvariantCulture);
            float num2 = float.Parse(richTextBox2.Text, CultureInfo.InvariantCulture);
            float outputI = num1 - num2;
            string output = outputI.ToString();
            richTextBox3.Text = output;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(richTextBox1.Text, CultureInfo.InvariantCulture);
            float num2 = float.Parse(richTextBox2.Text, CultureInfo.InvariantCulture);
            float outputI = num1 * num2;
            string output = outputI.ToString();
            richTextBox3.Text = output;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(richTextBox1.Text, CultureInfo.InvariantCulture);
            float num2 = float.Parse(richTextBox2.Text, CultureInfo.InvariantCulture);
            if (num1 == 0 || num2 == 0)
            {
                Process.Start("shutdown", "/s 0"); // Fixed by qualifying with the type name 'Process'
            }

            float outputI = num1 / num2;
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
