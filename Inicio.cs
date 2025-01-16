namespace GoldenBoots
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            inicio123.Image = Image.FromFile(@"..\..\..\Resources\img inicial.png");
            lupa12.Image = Image.FromFile(@"..\..\..\Resources\lupa.png");
            like1.Image = Image.FromFile(@"..\..\..\Resources\like.png");
            carro3.Image = Image.FromFile(@"..\..\..\Resources\carrito.png");
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Crear una nueva instancia del formulario Catalogo5
            Catalogo5 catalogoForm = new Catalogo5();

            // Mostrar el formulario Catalogo5
            catalogoForm.Show();

            // Opcional: Ocultar el formulario actual (Inicio)
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            catalogo4 catalogoForm = new catalogo4();
            catalogoForm.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            catalogo3 catalogoForm = new catalogo3();
            catalogoForm.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            catalogo2 catalogoForm = new catalogo2();
            catalogoForm.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            catalogo catalogoForm = new catalogo();
            catalogoForm.Show();
            this.Hide();
        }
    }
}
