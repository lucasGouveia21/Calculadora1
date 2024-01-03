namespace Calculadora1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNro1.Text) + float.Parse(txtNro2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNro1.Text) - float.Parse(txtNro2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNro1.Text) * float.Parse(txtNro2.Text)).ToString();
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNro1.Text) / float.Parse(txtNro2.Text)).ToString();
        }
    }
}
