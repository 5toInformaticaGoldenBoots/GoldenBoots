using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GoldenBoots
{
    public partial class adminform : Form
    {
        private Database db;

        public adminform()
        {
            InitializeComponent();
            db = new Database(); // Inicia la conexión a la base de datos
        }

        private void adminform_Load(object sender, EventArgs e)
        {
            CargarClientes(); // Cargar clientes al iniciar el formulario
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(nombre))
            {
                try
                {
                    string query = "INSERT INTO Clientes (Nombre) VALUES (@nombre)";
                    db.Execute(query);
                    MessageBox.Show("Cliente guardado correctamente.");
                    CargarClientes(); // Refrescar lista
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un nombre válido.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar.Text, out int id))
            {
                string query = "SELECT Nombre FROM Clientes WHERE Id = @id";
                object[] cliente = db.QueryOne(query);

                if (cliente != null)
                {
                    string text = $"Nombre: {cliente[0]}";
                    dataGridView1.Rows.Add();
                    
                }
                else
                {
                    string texto = "Cliente no encontrado.";
                    MessageBox.Show("Error", texto, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.");
            }
        }

        private void CargarClientes()
        {
            dataGridView1.Rows.Clear(); // Limpia el DataGridView

            List<object[]> clientes = db.Query("SELECT Id, Nombre FROM Clientes");

            foreach (var fila in clientes)
            {
                dataGridView1.Rows.Add(fila); // Agrega cada fila al DataGridView
            }
        }

        private void adminform_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Close(); // Cierra la conexión al cerrar el formulario
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
