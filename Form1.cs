namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rndm = new Random();
        int pcskor = 0, userskor = 0;
        public void button2_Click(object sender, EventArgs e)
        {
            int a = rndm.Next(1, 4);
            if (a==1)
            {
                label6.Text = "Ta�";
                listBox1.Items.Add("Ka��t ta�� sarar.");
                userskor++;
                label3.Text = userskor.ToString();
            }
            if (a==2)
            {
                label6.Text = "Ka��t";
                listBox1.Items.Add("Beraber");
            }
            if (a==3)
            {
                label6.Text = "Makas";
                listBox1.Items.Add("Makas ka��d� keser.");
                pcskor++;
                label2.Text = pcskor.ToString();
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            int a = rndm.Next(1, 4);
            if (a==1)
            {
                label6.Text = "Ta�";
                listBox1.Items.Add("Ta� Makas� k�rar.");
                pcskor++;
                label2.Text = pcskor.ToString();
            }
            if (a==2)
            {
                label6.Text = "Ka��t";
                listBox1.Items.Add("Makas Ka��d� keser.");
                userskor++;
                label3.Text = userskor.ToString();
            }
            if (a==3)
            {
                label6.Text = "Makas";
                listBox1.Items.Add("Berabere");
            }
        }

        public void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pcskor = 0;
            userskor = 0;
            label2.Text = pcskor.ToString();
            label3.Text = userskor.ToString();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int a = rndm.Next(1, 4);
            if (a==1)
            {
                label6.Text = "Ta�";
                listBox1.Items.Add("Berabere");
            }
            if (a==2)
            {
                label6.Text = "Ka��t";
                listBox1.Items.Add("Ka��t Ta�� sarar.");
                pcskor++;
                label2.Text = pcskor.ToString();
            }
            if (a==3)
            {
                label6.Text = "Makas";
                listBox1.Items.Add("Ta� Makas� k�rar.");
                userskor++;
                label3.Text = userskor.ToString();
            }
        }
    }
}