namespace Välj_ditt_äventyr
{
    public partial class Form1 : Form
    {

        bool altA = true;
        bool altB = false;
       

        string scenA = "Ska Jacob ska gå hem?";
        string scenB = "Jacob ska gå in i sitt hus?";
        string scenC = "Nej Jacob stannar.";
        string scenD = "Ja han går in.";
        string scenE = "Nej, han sover ute.";
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = scenA;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (altA == true)
            {
                textBox1.Text = scenB;
                altA = false;
                altB = true;
            }
            else if (altB == true)
            {
                textBox1.Text = scenD;
                altB = false;
               
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (altA == true)
            {
                textBox1.Text = scenC;
                altA = false;
            
            }
            else if (altB == true)
            {
                textBox1.Text = scenE;
                altB = false;
              
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = scenA;
            altA = true;
        }
    }
}