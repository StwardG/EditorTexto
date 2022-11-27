namespace tareaCapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int first_value = comboBox1.SelectedIndex;
            if(first_value == 0 )
            {
                Form editorText = new editorTexto();
                editorText.Show();
            }
            else
            {
                if(first_value == 1)
                {
                    Form paint = new Paint();
                    paint.Show();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

      
    }
}