using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenBoots
{
    public partial class compra2 : Form
    {
        public compra2()
        {
            InitializeComponent();
            piernarica.Image = Image.FromFile(@"..\..\..\Resources\16.png");
            q1.Image = Image.FromFile(@"..\..\..\Resources\17.png");
            q2.Image = Image.FromFile(@"..\..\..\Resources\18.png");
            q3.Image = Image.FromFile(@"..\..\..\Resources\19.png");
            q4.Image = Image.FromFile(@"..\..\..\Resources\20.png");
            q5.Image = Image.FromFile(@"..\..\..\Resources\21.png");
            q6.Image = Image.FromFile(@"..\..\..\Resources\pago.png");
        }

        private void imgs_Click(object sender, EventArgs e)
        {
            PictureBox? img = sender as PictureBox;

            piernarica.Image = img.Image;
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
