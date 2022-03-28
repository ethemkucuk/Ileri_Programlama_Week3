namespace Week3._2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int y = 0, x=200, k=400;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Location = new Point(y, 432);
            label2.Location = new Point(x, 432);
            label3.Location = new Point(k, 432);

            y--;
            x--;
            k--;

            if (y <= -140)
                y = 450;
            if (x <= -140)
                x = 450;
            if (k <= -140)
                k = 450;
        }
    }
}