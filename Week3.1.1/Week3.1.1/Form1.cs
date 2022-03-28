namespace Week3._1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int para = 0, elli, yirmi, on, bes;

        private void control(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                para = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";


                if (para % 5 != 0)
                    label7.Text = "fsdfsds";
                else
                {
                    label7.Text = para.ToString() + "TL";


                    if (para >= 50)
                    {
                        elli = para / 50;
                        para = para % 50;
                        textBox2.Text = elli.ToString();

                    }

                    if (para >= 20)
                    {
                        yirmi = para / 20;
                        para = para % 20;
                        textBox3.Text = yirmi.ToString();
                    }

                    if (para >= 10)
                    {
                        on = para / 10;
                        para = para % 10;
                        textBox4.Text = on.ToString();
                    }

                    if (para >= 5)
                    {
                        bes = para / 5;

                        textBox5.Text = bes.ToString();
                    }
                }

            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            para = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";


            if (para % 5 != 0)
                label7.Text = "fsdfsds";
            else
            {
                label7.Text = para.ToString()+"TL";  
           

            if (para >= 50)
            {
                elli = para / 50;
                para = para % 50;
                textBox2.Text = elli.ToString();

            }

            if (para >= 20)
            {
                    yirmi = para / 20; 
                    para = para % 20;
                    textBox3.Text = yirmi.ToString();
            }

            if (para >= 10)
            {
                    on = para / 10;
                    para = para % 10;
                    textBox4.Text = on.ToString();
            }

            if (para >= 5)    
            {
                    bes = para / 5;
                   
                    textBox5.Text = bes.ToString();
            }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}