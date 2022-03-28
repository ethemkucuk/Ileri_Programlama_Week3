namespace Week3._2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        int x, y;

        private void move1(object sender, MouseEventArgs e)
        {
            label4.Text = MousePosition.X.ToString();
            label5.Text = MousePosition.Y.ToString();
        }

        private void catch1(object sender, EventArgs e)
        {
            Random  rnd=new Random();
            x = rnd.Next(1, 600);
            y = rnd.Next(1, 400);
            label1.Location = new Point(x, y);
        }
    }
}