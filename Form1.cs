namespace practicad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private bool img= true;

        private void button1_Click(object sender, EventArgs e)
        {
            //utilizar la clase open file dialog para visualizar la ventana
            OpenFileDialog Abrir = new OpenFileDialog();

            //Filtro para abrir imagenes
            Abrir.Filter = "JPGDE(*.JPG)|*.JPG|BMP (*.BMP)|*.BMP";

            //validar ventana y mostrarla
            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                //validaciones sobre ventana img
                pictureBox1.Image = Image.FromFile(Abrir.FileName);
            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool img = true;

        private void button2_Click(object sender, EventArgs e)
        {
            if (img)
            {
                pictureBox2.Image = Image.FromFile("D:\\PRACTICA3\\practicad\\imagenes\\descarga (1).jpg");
                img = false;
            }
            else
            {
                pictureBox2.Image = Image.FromFile("D:\\PRACTICA3\\practicad\\imagenes\\descarga.jpg");
                img = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (img)
            {
                pictureBox3.Image = Image.FromFile("D:\\PRACTICA3\\practicad\\imagenes\\descarga (1).jpg");
                img = false;
            }
            else
            {
                pictureBox3.Image = Image.FromFile("D:\\PRACTICA3\\practicad\\imagenes\\descarga.jpg");
                img = true;
            }
        }
    }
}