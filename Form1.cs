namespace Convertitore_Gradi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int celsius = Convert.ToInt32(textBox1.Text);
            float indice = 1.8f;
            float conversione = (celsius * indice) + 32;

            label5.Text = conversione.ToString();
        }


        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int farenight = Convert.ToInt32(textBox2.Text);
           
            float conversione = (farenight - 32) * 5 / 9;

            label6.Text = conversione.ToString();
        
    }
    }
}
