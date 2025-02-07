using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace GoldenBoots
{
    public partial class Carrito : Form
    {
        public Carrito()
        {
            InitializeComponent();
            this.Text = "Zapatito";

        }

        private void ChangeCantity(object sender, EventArgs e)
        {
            if (sender is Button obj)
            {
                string textBoxName = "cantityText" + obj.Name.Substring(3);
                if (this.Controls[textBoxName] is TextBox cantity)
                {
                    DataTable calculator = new DataTable();
                    try
                    {
                        cantity.Text = calculator.Compute(cantity.Text + obj.Text + "1", null).ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en cálculo: " + ex.Message);
                    }
                }
            }
        }

        private void NewTotal(object sender, EventArgs e)
        {
            try
            {
                double price1Value = double.Parse(price1.Text.Substring(4));
                double price2Value = double.Parse(price2.Text.Substring(4));
                int quantity1 = int.Parse(cantityText1.Text);
                int quantity2 = int.Parse(cantityText2.Text);

                double totalAmount = (price1Value * quantity1) + (price2Value * quantity2);
                total.Text = "Total: " + totalAmount.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el cálculo del total: " + ex.Message);
            }
        }

        private void bvolver_Click(object sender, EventArgs e)
        {
            RepeatFunctions.OpenForm(this, new Inicio());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra realizada con éxito.");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            var productos = db.Select("SELECT * FROM CARRITO_DE_COMPRAS WHERE Codigo = 'algo'");

            if (productos.Count > 0 && productos[0].Length > 0)
            {
                string rutaImagen = productos[0][0].ToString();
                try
                {
                    pictureBox2.Image = Image.FromFile("././" + rutaImagen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }

        private void Carrito_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
