namespace WinFormsCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_say_hello_Click(object sender, EventArgs e)
        {
            text_show_hello.Text = "Hello World!";
        }
    }
}