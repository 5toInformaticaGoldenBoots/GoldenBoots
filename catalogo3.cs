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
    public partial class catalogo3 : Form
    {
        public catalogo3()
        {
            InitializeComponent();
            h1.Image = Image.FromFile(@"..\..\..\Resources\z1.png");
            h2.Image = Image.FromFile(@"..\..\..\Resources\z2.png");
            h3.Image = Image.FromFile(@"..\..\..\Resources\z3.png");
            h4.Image = Image.FromFile(@"..\..\..\Resources\z4.png");
            h5.Image = Image.FromFile(@"..\..\..\Resources\z5.png");
            h6.Image = Image.FromFile(@"..\..\..\Resources\z6.png");
            h7.Image = Image.FromFile(@"..\..\..\Resources\z7.png");
            h8.Image = Image.FromFile(@"..\..\..\Resources\z8.png");
            h9.Image = Image.FromFile(@"..\..\..\Resources\z9.png");
            h10.Image = Image.FromFile(@"..\..\..\Resources\z10.png");
            h11.Image = Image.FromFile(@"..\..\..\Resources\z11.png");
            h12.Image = Image.FromFile(@"..\..\..\Resources\z12.png");
            h13.Image = Image.FromFile(@"..\..\..\Resources\z13.png");
            h14.Image = Image.FromFile(@"..\..\..\Resources\z14.png");
            h15.Image = Image.FromFile(@"..\..\..\Resources\z15.png");
            h16.Image = Image.FromFile(@"..\..\..\Resources\z16.png");
            h17.Image = Image.FromFile(@"..\..\..\Resources\z17.png");
            h18.Image = Image.FromFile(@"..\..\..\Resources\z18.png");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inicio inicioForm = new Inicio();
            inicioForm.Show();
            this.Close();
        }
    }
}
