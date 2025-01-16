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
    public partial class catalogo2 : Form
    {
        public catalogo2()
        {
            InitializeComponent();
            f1.Image = Image.FromFile(@"..\..\..\Resources\za1f.png");
            f2.Image = Image.FromFile(@"..\..\..\Resources\za2f.png");
            f3.Image = Image.FromFile(@"..\..\..\Resources\za3f.png");
            f4.Image = Image.FromFile(@"..\..\..\Resources\za4f.png");
            f5.Image = Image.FromFile(@"..\..\..\Resources\za5f.png");
            f6.Image = Image.FromFile(@"..\..\..\Resources\za6f.png");
            f7.Image = Image.FromFile(@"..\..\..\Resources\za7f.png");
            f8.Image = Image.FromFile(@"..\..\..\Resources\za8f.png");
            f9.Image = Image.FromFile(@"..\..\..\Resources\za9f.png");
            f10.Image = Image.FromFile(@"..\..\..\Resources\za10f.png");
            f11.Image = Image.FromFile(@"..\..\..\Resources\za11f.png");
            f12.Image = Image.FromFile(@"..\..\..\Resources\za12f.png");
            f13.Image = Image.FromFile(@"..\..\..\Resources\za13f.png");
            f14.Image = Image.FromFile(@"..\..\..\Resources\za14f.png");
            f15.Image = Image.FromFile(@"..\..\..\Resources\za15f.png");
            f16.Image = Image.FromFile(@"..\..\..\Resources\za16f.png");
            f17.Image = Image.FromFile(@"..\..\..\Resources\za17f.png");
            f18.Image = Image.FromFile(@"..\..\..\Resources\za18f.png");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Crear una nueva instancia del formulario Inicio
            Inicio inicioForm = new Inicio();

            // Mostrar el formulario Inicio
            inicioForm.Show();

            // Cerrar el formulario actual (Catalogo2)
            this.Close();
        }
    }
}
