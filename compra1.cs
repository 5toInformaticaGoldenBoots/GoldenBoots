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
    public partial class compra1 : Form
    {
        public compra1()
        {
            InitializeComponent();
            p1.Image = Image.FromFile(@"..\..\..\Resources\co1.png");
            p2.Image = Image.FromFile(@"..\..\..\Resources\co2.png");
            p3.Image = Image.FromFile(@"..\..\..\Resources\co3.png");
            p4.Image = Image.FromFile(@"..\..\..\Resources\co4.png");
            p5.Image = Image.FromFile(@"..\..\..\Resources\co5.png");
            p6.Image = Image.FromFile(@"..\..\..\Resources\pago.png");
        }

        private void imgs_Click(object sender, EventArgs e)
        {
            PictureBox? img = sender as PictureBox;

            imgprincipal.Image = img.Image;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inicio inicioForm = new Inicio();
            inicioForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Añadido al carrito con éxito.");
        }
    }
}
