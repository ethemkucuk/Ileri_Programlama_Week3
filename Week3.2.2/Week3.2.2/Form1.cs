namespace Week3._2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int control = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (control == 1)
            {
                panel1.Top -= 10;
                timer1.Interval += 2;
                if (panel1.Top==15)
                    control = 2;
            }   

            if (control == 2)
            {
                panel1.Top += 5;
                timer1.Interval -= 1;
                if (panel1.Top == 375)
                    control = 1;
            }
        }

    }
}