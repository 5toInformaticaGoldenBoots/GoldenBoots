using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GoldenBoots
{
    public partial class adminform : Form
    {
        private Database db;
        private string currentView = "clientes"; // Vista inicial

        public adminform()
        {
            InitializeComponent();
            db = new Database();
        }

        private void adminform_Load(object sender, EventArgs e)
        {
            CargarClientes(); // Cargar clientes al iniciar
        }

        // Métodos para cargar vistas
        private void CargarZapatos()
        {
            currentView = "zapatos"; // Set current view to shoes
            dataGridView1.Rows.Clear(); // Limpia el DataGridView
            dataGridView1.Columns.Clear(); // Limpia las columnas del DataGridView

            // Configura las columnas del DataGridView para la tabla ZAPATOS
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("TALLA", "Talla");
            dataGridView1.Columns.Add("PRECIO", "Precio");
            dataGridView1.Columns.Add("ID_TIPO_DE_ZAPATOS", "Tipo de Zapatos");
            dataGridView1.Columns.Add("ID_MARCA", "Marca");
            dataGridView1.Columns.Add("ID_COLOR_DE_ZAPATO", "Color de Zapato");

            List<object[]> zapatos = db.Query("SELECT Id, TALLA, PRECIO, ID_TIPO_DE_ZAPATOS, ID_MARCA, ID_COLOR_DE_ZAPATO FROM ZAPATOS");

            foreach (var zapato in zapatos)
            {
                dataGridView1.Rows.Add(zapato); // Agrega cada zapato al DataGridView
            }
        }

        private void CargarVentas()
        {
            currentView = "ventas"; // Set current view to sales
            dataGridView1.Rows.Clear(); // Limpia el DataGridView
            dataGridView1.Columns.Clear(); // Limpia las columnas del DataGridView

            // Configura las columnas del DataGridView para la tabla VENTAS
            dataGridView1.Columns.Add("ID_VENTA", "ID Venta");
            dataGridView1.Columns.Add("ID_USUARIO", "ID Usuario");
            dataGridView1.Columns.Add("FECHA", "Fecha");
            dataGridView1.Columns.Add("ESTADO", "Estado");

            List<object[]> ventas = db.Query("SELECT ID_VENTA, ID_USUARIO, FECHA, ESTADO FROM VENTAS");

            foreach (var venta in ventas)
            {
                dataGridView1.Rows.Add(venta); // Agrega cada venta al DataGridView
            }
        }

        private void CargarClientes()
        {
            currentView = "clientes"; // Set current view to users
            dataGridView1.Rows.Clear(); // Limpia el DataGridView
            dataGridView1.Columns.Clear(); // Limpia las columnas del DataGridView

            // Configura las columnas del DataGridView para la tabla USUARIOS
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("NOMBRE", "Nombre");
            dataGridView1.Columns.Add("APELLIDO", "Apellido");
            dataGridView1.Columns.Add("EMAIL", "Email");
            dataGridView1.Columns.Add("CONTRASENA", "Contraseña");
            dataGridView1.Columns.Add("TELEFONO", "Teléfono");
            dataGridView1.Columns.Add("ACTIVO", "Activo");

            List<object[]> usuarios = db.Query("SELECT ID, NOMBRE, APELLIDO, EMAIL, CONTRASENA, TELEFONO, ACTIVO FROM USUARIOS");

            foreach (var usuario in usuarios)
            {
                dataGridView1.Rows.Add(usuario); // Agrega cada usuario al DataGridView
            }
        }
        // Botones de navegación
        private void button1_Click(object sender, EventArgs e) => CargarZapatos();
        private void button2_Click(object sender, EventArgs e) => CargarVentas();
        private void button3_Click(object sender, EventArgs e) => CargarClientes();

        // Botones CRUD
        private void button6_Click(object sender, EventArgs e) // Eliminar
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un elemento");
                return;
            }

            var confirm = MessageBox.Show("¿Eliminar registro?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            MessageBox.Show($"ID a eliminar: {id}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Debug: Show the current view
            MessageBox.Show($"Vista actual: {currentView}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                switch (currentView)
                {
                    case "clientes":
                        db.Execute("DELETE FROM USUARIOS WHERE ID = @Id", new Dictionary<string, object> { { "Id", id } });
                        CargarClientes();
                        break;
                    case "zapatos":
                        db.Execute("DELETE FROM ZAPATOS WHERE ID = @Id", new Dictionary<string, object> { { "Id", id } });
                        CargarZapatos();
                        break;
                    case "ventas":
                        db.Execute("DELETE FROM VENTAS WHERE ID_VENTA = @Id", new Dictionary<string, object> { { "Id", id } });
                        CargarVentas();
                        break;
                    default:
                        MessageBox.Show($"Vista no reconocida: {currentView}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                MessageBox.Show("Registro eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var createForm = new CreateForm(db, currentView);
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    // Recargar la vista actual después de crear un registro
                    switch (currentView)
                    {
                        case "clientes":
                            CargarClientes();
                            break;
                        case "zapatos":
                            CargarZapatos();
                            break;
                        case "ventas":
                            CargarVentas();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para Editar (button5)
        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Determine the correct column names based on the current view
                switch (currentView)
                {
                    case "shoes":
                        int shoeId = (int)selectedRow.Cells["ID"].Value;
                        int talla = (int)selectedRow.Cells["TALLA"].Value;
                        decimal precio = (decimal)selectedRow.Cells["PRECIO"].Value;
                        int idTipo = (int)selectedRow.Cells["ID_TIPO_DE_ZAPATOS"].Value;
                        int idMarca = (int)selectedRow.Cells["ID_MARCA"].Value;
                        int idColor = (int)selectedRow.Cells["ID_COLOR_DE_ZAPATO"].Value;

                        var editShoeForm = new EditForm(db, currentView, shoeId, talla, precio, idTipo, idMarca, idColor);
                        editShoeForm.ShowDialog();
                        break;

                    case "sales":
                        int saleId = (int)selectedRow.Cells["ID_VENTA"].Value;
                        int idUsuario = (int)selectedRow.Cells["ID_USUARIO"].Value;
                        string estado = selectedRow.Cells["ESTADO"].Value.ToString();

                        var editSaleForm = new EditForm(db, currentView, saleId, idUsuario, estado);
                        editSaleForm.ShowDialog();
                        break;

                    case "users":
                        int userId = (int)selectedRow.Cells["ID"].Value;
                        string nombre = selectedRow.Cells["NOMBRE"].Value.ToString();
                        string apellido = selectedRow.Cells["APELLIDO"].Value.ToString();
                        string email = selectedRow.Cells["EMAIL"].Value.ToString();
                        string contrasena = selectedRow.Cells["CONTRASENA"].Value.ToString();
                        long telefono = (long)selectedRow.Cells["TELEFONO"].Value;
                        bool activo = (bool)selectedRow.Cells["ACTIVO"].Value;

                        var editUserForm = new EditForm(db, currentView, userId, nombre, apellido, email, contrasena, telefono, activo);
                        editUserForm.ShowDialog();
                        break;

                    default:
                        MessageBox.Show("Vista no reconocida.");
                        break;
                }

                RefreshView(); // Refrescar la vista actual
            }
            else
            {
                MessageBox.Show("Seleccione un elemento para editar.");
            }
        }
        private void RefreshView()
        {
            switch (currentView)
            {
                case "shoes":
                    CargarZapatos();
                    break;
                case "sales":
                    CargarVentas();
                    break;
                case "users":
                    CargarClientes();
                    break;
            }
        }
    }

}
