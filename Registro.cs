using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
                MessageBox.Show("Todos los campos son obligatorios.", "Campos Obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (contraseña.Length < 9)
            {
                MessageBox.Show("La contraseña tiene que tener más de 8 carácteres", "Contraseña corta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (contraseña != confirmarContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Contraseñas diferentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!aceptaTerminos)
            {
                MessageBox.Show("Debe aceptar los términos y condiciones.", "Acepta términos y condiciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Database db = new Database();

            try
            {
                db.Execute($"INSERT INTO USUARIOS VALUES ('{usuario}', '{nombre}', '{email}', '{contraseña}', 1, 1)");
                db.Execute($"UPDATE USUARIOS SET ACTIVO = 0 WHERE NOMBRE != {usuario}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error, vuelva a intentarlo", "Database Error", MessageBoxButtons.OK);
                return;
            }

            MessageBox.Show("Cuenta registrada con exito!", "Cuenta registrada", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            RepeatFunctions.OpenForm(this, new Inicio());
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RepeatFunctions.OpenForm(this, new Sesiones());
        }
    }
}