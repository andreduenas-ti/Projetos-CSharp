namespace RotinaSeniorCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string tempo)
        {
            InitializeComponent();
            label8.Text = tempo;
        }
        private void btn_marc(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }
    }
    
}