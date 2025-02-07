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
    public partial class Catalogo5 : Form
    {
        public Catalogo5()
        {
            InitializeComponent();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
