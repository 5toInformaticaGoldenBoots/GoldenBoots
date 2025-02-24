using System;
using System.Windows.Forms;

namespace GoldenBoots
{
    public partial class EditUserForm : Form
    {
        private Database db;
        private int userId;

        public EditUserForm(Database database, int id, string nombre, string apellido, string email, string contrasena, int telefono, bool activo)
        {
            InitializeComponent();
            db = database;
            userId = id;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtEmail.Text = email;
            txtContrasena.Text = contrasena;
            txtTelefono.Text = telefono.ToString();
            chkActivo.Checked = activo;
        }

       // private void btnSave_Click(object sender, EventArgs e)
        //{
        //    string nombre = txtNombre.Text.Trim();
        //    string apellido = txtApellido.Text.Trim();
        //    string email = txtEmail.Text.Trim();
        //    string contrasena = txtContrasena.Text.Trim();
        //    int telefono = int.Parse(txtTelefono.Text.Trim());
        //    bool activo = chkActivo.Checked;
        //
        //    string query = $"UPDATE USUARIOS SET NOMBRE = @nombre, APELLIDO = @apellido, EMAIL = @Email, CONTRASENA = @contrasena, TELEFONO = @telefono, ACTIVO = @activo WHERE ID = @userId";
        //    using (SqlCommand command = new SqlCommand(query, db.Connection))
        //    {
        //        command.Parameters.AddWithValue("@nombre", nombre);
        //        command.Parameters.AddWithValue("@apellido", apellido);
        //        command.Parameters.AddWithValue("@Email", email);
        //        command.Parameters.AddWithValue("@contrasena", contrasena);
        //        command.Parameters.AddWithValue("@telefono", telefono);
        //        command.Parameters.AddWithValue("@activo", activo);
        //        command.Parameters.AddWithValue("@userId", userId);
        //        command.ExecuteNonQuery();
        //    }
        //
        //    MessageBox.Show("Usuario actualizado correctamente.");
        //    this.Close();
        //}
    }
}