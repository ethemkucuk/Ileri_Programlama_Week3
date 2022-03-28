namespace Week3._2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int a, b, c;

        private void hareket_et(object sender, KeyEventArgs e)
        {
            timer1.Enabled = true;
            if (panel1.Top == 100)
                panel1.Top = 220;

            else if (panel1.Top != 100)
                panel1.Top = 100;
        }

        private void durdur(object sender, KeyEventArgs e)
        {
           timer1.Enabled=false;
            if (panel1.Top == 100)
            {
                if (a > c)
                    label5.Text = "You Won!";
                else if (c > a)
                    label5.Text = "You Lost!";
                else
                    label5.Text = "Equal";
            }
            if (panel1.Top == 220)
            {
                if (b > c)
                    label5.Text = "You Won!";
                else if (c > b)
                    label5.Text = "You Lost!";
                else
                    label5.Text = "Equal";
            }
        }

        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            a = rnd.Next(1,10);
            b = rnd.Next(1,10);
            c = rnd.Next(1,10);

            label1.Text = a.ToString();
            label2.Text = b.ToString();
            label3.Text = c.ToString();


        }
    }
}