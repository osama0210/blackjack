namespace blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amountPlayers = (int)numericUpDown1.Value;

            Form2 startScreen = new Form2(amountPlayers);
            startScreen.Show();

            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
