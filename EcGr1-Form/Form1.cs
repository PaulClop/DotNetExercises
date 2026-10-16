namespace EcGr1_Form
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int a))
            {
                MessageBox.Show("Scrie a ca si un int valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            if (a == 0)
            {
                MessageBox.Show("a nu poate fi 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            if (!int.TryParse(textBox2.Text, out int b))
            {
                MessageBox.Show("Scrie b ca si un int valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }

            float x = -b / (float)a;

            MessageBox.Show($"Solutia ecuatiei este x = {x}");
        }
    }
}
