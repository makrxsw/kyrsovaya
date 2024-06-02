namespace kyrsovaya
{
    public partial class golovna : Form
    {
        public golovna()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            golovna form1 = new golovna();
            football form4 = new football();
            form4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            golovna form1 = new golovna();
            basketball form5 = new basketball();
            form5.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            golovna form1 = new golovna();
            hockey form6 = new hockey();
            form6.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sportsmen form3 = new sportsmen();
            form3.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clubs form2 = new clubs();
            form2.Show();
            this.Hide();

        }

        private void ‚ËÈÚËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void golovna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}