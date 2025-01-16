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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Obtener valores de los campos
            string nombre = txtNombre.Text;
            string usuario = txtUsuario.Text;
            string email = txtEmail.Text;
            string contraseña = txtContraseña.Text;
            string confirmarContraseña = txtConfirmar.Text;
            bool aceptaTerminos = chkTerminos.Checked;

            // Validaciones
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(contraseña) ||
                string.IsNullOrWhiteSpace(confirmarContraseña))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (contraseña != confirmarContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!aceptaTerminos)
            {
                MessageBox.Show("Debe aceptar los términos y condiciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mensaje de éxito
            MessageBox.Show("Registro exitoso.\nBienvenido, " + nombre + "!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
        
