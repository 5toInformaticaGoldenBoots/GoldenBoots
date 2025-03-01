using GoldenBoots.Properties;
using Microsoft.IdentityModel.Tokens;
using System.Linq;

namespace GoldenBoots
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            inicio123.Image = Image.FromFile(@"..\..\..\Resources\img inicial.png");
            carro3.Image = Image.FromFile(@"..\..\..\Resources\carrito.png");

            Database db = new Database();

            if (db.Select("SELECT * FROM USUARIOS WHERE ACTIVO = 1").Count >= 1)
            {
                sesion.Text = "Perfil";
            }
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

        private void OpenCatalog(object sender, EventArgs e)
        {
            LinkLabel obj = sender as LinkLabel;
            // Crear una nueva instancia del formulario Catalogo5
            Catalogos catalogoForm = new Catalogos(obj.Text);

            RepeatFunctions.OpenForm(this, catalogoForm);
        }

        private void OpenRegister(object sender, EventArgs e)
        {
            Database db = new Database();
            object[]? data = db.SelectOne("SELECT * FROM USUARIOS WHERE ACTIVO = 1");

            if (data.IsNullOrEmpty())
            {
                RepeatFunctions.OpenForm(this, new Sesiones());
                return;
            }
            
            if (Convert.ToBoolean(data[7]))
            {
                RepeatFunctions.OpenForm(this, new adminform());
                return;
            }

            RepeatFunctions.OpenForm(this, new perfil());
        }

        private void carro3_Click(object sender, EventArgs e)
        {
            RepeatFunctions.OpenForm(this, new Carrito());
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RepeatFunctions.OpenForm(this, new Ofertas());
        }
    }
}
