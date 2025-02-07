using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenBoots
{
    public partial class catalogo4 : Form
    {
        public catalogo4()
        {
            InitializeComponent();
            a1.Image = Image.FromFile(@"..\..\..\Resources\za1.png");
            a2.Image = Image.FromFile(@"..\..\..\Resources\za2.png");
            a3.Image = Image.FromFile(@"..\..\..\Resources\za3.png");
            a4.Image = Image.FromFile(@"..\..\..\Resources\za4.png");
            a5.Image = Image.FromFile(@"..\..\..\Resources\za5.png");
            a6.Image = Image.FromFile(@"..\..\..\Resources\za6.png");
            a7.Image = Image.FromFile(@"..\..\..\Resources\za7.png");
            a8.Image = Image.FromFile(@"..\..\..\Resources\za8.png");
            a9.Image = Image.FromFile(@"..\..\..\Resources\za9.png");
            a10.Image = Image.FromFile(@"..\..\..\Resources\za10.png");
            a11.Image = Image.FromFile(@"..\..\..\Resources\za11.png");
            a12.Image = Image.FromFile(@"..\..\..\Resources\za12.png");
            a13.Image = Image.FromFile(@"..\..\..\Resources\za13.png");
            a14.Image = Image.FromFile(@"..\..\..\Resources\za14.png");
            a15.Image = Image.FromFile(@"..\..\..\Resources\za15.png");
            a16.Image = Image.FromFile(@"..\..\..\Resources\16.png");
            a17.Image = Image.FromFile(@"..\..\..\Resources\za17.png");
            a18.Image = Image.FromFile(@"..\..\..\Resources\za18.png");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Inicio inicioForm = new Inicio();
            inicioForm.Show();
            this.Close();
        }

        private void a18_Click(object sender, EventArgs e)
        {

            // Crear una nueva instancia del formulario Compra2
            compra2 compraForm = new compra2();

            // Mostrar el formulario Compra2
            compraForm.Show();

            // Opcional: Ocultar el formulario actual
            this.Hide();
        }
    }
}
