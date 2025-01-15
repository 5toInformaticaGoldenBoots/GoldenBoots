using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace GoldenBoots
{
    public partial class catalogo : Form
    {
        public catalogo()
        {
            InitializeComponent();
            za1.Image = Image.FromFile(@"..\..\..\Resources\zap1.png");
            za2.Image = Image.FromFile(@"..\..\..\Resources\zap2.png");
            za3.Image = Image.FromFile(@"..\..\..\Resources\zap5.png");
            za4.Image = Image.FromFile(@"..\..\..\Resources\zap6.png");
            za5.Image = Image.FromFile(@"..\..\..\Resources\zap7.png");
            za6.Image = Image.FromFile(@"..\..\..\Resources\zap9.png");
            za7.Image = Image.FromFile(@"..\..\..\Resources\zap12.png");
            za8.Image = Image.FromFile(@"..\..\..\Resources\zap16.png");
            za9.Image = Image.FromFile(@"..\..\..\Resources\zap15.png");
            za10.Image = Image.FromFile(@"..\..\..\Resources\zap13.png");
        }

        private void img1_Click(object sender, EventArgs e)
        {

            // Crear una nueva instancia del formulario Compra1
            compra1 compraForm = new compra1();

            // Mostrar el formulario Compra1
            compraForm.Show();

            // Opcional: Ocultar el formulario actual
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Crear una nueva instancia del formulario Inicio
            Inicio inicioForm = new Inicio();

            // Mostrar el formulario Inicio
            inicioForm.Show();

            // Cerrar el formulario actual (Catalogo)
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Catalogo5 catalogoForm = new Catalogo5();
            catalogoForm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
    }
}
