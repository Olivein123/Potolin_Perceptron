namespace Potolin_Perceptron
{
    public partial class Form1 : Form
    {
        Perceptron p = new Perceptron();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double w1 = double.Parse(textBox1.Text);
            double w2 = double.Parse(textBox2.Text);
            double bias = double.Parse(textBox3.Text);
            double learn = double.Parse(textBox4.Text); 
            p.setW1(w1);
            p.setW2(w2);
            p.setBias(bias);
            p.setLearnRate(learn);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.Train();
            var evens = from n in p.DisplayTrainedData() select new { Digit = n };
            dataGridView1.DataSource = evens.ToList();
            textBox5.Text = p.getW1().ToString("0.00");
            textBox6.Text = p.getW2().ToString("0.00"); ;
        }
    }
}