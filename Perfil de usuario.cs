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
    public partial class perfil : Form
    {
        public perfil()
        {
            InitializeComponent();
            Database db = new Database();
            object[] user = db.QueryOne("SELECT NOMBRE, APELLIDO, CONTRASEÑA FROM USUARIOS WHERE ACTIVO = 1");

            name.Text = user[1].ToString();
            userNombre.Text = user[0].ToString();
            pass.Text = user[2].ToString();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            RepeatFunctions.OpenForm(this, new Inicio());
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            db.Execute("UPDATE USUARIOS SET ACTIVO = 0");

            MessageBox.Show("Sesión Cerrada Exitosamente", "Sesión Cerrada", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            RepeatFunctions.OpenForm(this, new Inicio());
        }

        private void ChangeData(object sender, EventArgs e)
        {
            PictureBox obj = sender as PictureBox;

            TextBox toChange = (new Control[] { name, userNombre, pass })[int.Parse(obj.Name.Substring(obj.Name.Length - 1))-1] as TextBox;

            Database db = new Database();

            db.Execute($"UPDATE USUARIOS SET {obj.Name.Remove(obj.Name.Length - 1)} = '{toChange.Text}' WHERE ACTIVO = 1");

            MessageBox.Show($"Dato Actualizado Exitosamente", "Dato Actualizado", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
