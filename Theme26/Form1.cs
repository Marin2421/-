namespace Theme26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("������ 1 ������");
            }
            else
            {
                MessageBox.Show("������ 1 �� ������");
            }
            if (checkBox2.Checked)
            {
                MessageBox.Show("������ 2 ������");
            }
            else
            {
                MessageBox.Show("������ 2 �� ������");
            }
            if (checkBox3.Checked)
            {
                MessageBox.Show("������ 3 ������");
            }
            else
            {
                MessageBox.Show("������ 3 �� ������");
            }
        }
    }
}
