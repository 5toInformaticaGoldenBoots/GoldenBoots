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
using GoldenBoots.Properties;

namespace GoldenBoots
{
    public partial class Sesiones : Form
    {
        public Sesiones()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RepeatFunctions.OpenForm(this, new Registro());
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            object[] data = db.QueryOne(
                "SELECT * FROM USUARIOS WHERE EMAIL = @Email",
                new Dictionary<string, object> { { "Email", email.Text } }
            );

            if (data != null && data[4].ToString() == pass.Text)
            {
                MessageBox.Show("Sesión Iniciada Exitosamente", "Sesión Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.Execute("UPDATE USUARIOS SET ACTIVO = 0", null);
                db.Execute(
                    "UPDATE USUARIOS SET ACTIVO = 1 WHERE EMAIL = @Email",
                    new Dictionary<string, object> { { "Email", email.Text } }
                );

                RepeatFunctions.OpenForm(this, new Inicio());
                return;
            }

            MessageBox.Show("La contraseña o el correo no están correctos", "Datos no encontrados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepeatFunctions.OpenForm(this, new Inicio());
        }
    }
}


    