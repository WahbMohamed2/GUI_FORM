namespace OSTask1V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(malebutton.Checked)
            {
                MessageBox.Show("Hello : " + namebox.Text + " Your age is " + agebox.Text + " Your Gender is Male and you city is " + citybox.Text);
            }
            else
            {
                MessageBox.Show("Hello : " + namebox.Text + " Your age is " + agebox.Text + " Your Gender is Female and you city is " + citybox.Text);
            }
        }
    }
}