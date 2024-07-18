namespace Theme26._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            int num1, num2, result;

            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                if (checkBoxAdd.Checked)
                {
                    result = num1 + num2;
                }
                else 
                {
                    result = num1 - num2;
                }               
                textBoxResult.Text = "Результат:" + result.ToString();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числа.");
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBoxResult.Clear();
            checkBoxAdd.Checked = false;
            checkBoxSub.Checked = false;
        }
    }
}
