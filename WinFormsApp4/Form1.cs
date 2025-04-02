namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "win":
                    switch(textBox2.Text)
                    {
                        case "win":
                            textBox3.Text = "Champion";
                            break;
                        default:
                            textBox3.Text = "Attacker";
                            break;
                    }
                    break;
                case "lost":
                    switch(textBox2.Text)
                    {
                        case "win":
                            textBox3.Text = "Attacker";
                            break;
                        default:
                            textBox3.Text = "Sportsman";
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
