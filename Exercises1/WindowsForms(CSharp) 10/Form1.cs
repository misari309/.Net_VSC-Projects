namespace WindowsForms_CSharp__10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Enviar_Click(object sender, EventArgs e)
        {
            int ini = int.Parse(textBox1.Text);
            int fin = int.Parse(textBox2.Text);
            int incr = int.Parse(textBox3.Text);
            for (int i = ini; i <= fin; i = i + incr)
            {
                listBox1.Items.Add(i);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}