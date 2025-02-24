using System;
using System.Windows.Forms;

namespace GoldenBoots
{
    public partial class EditForm : Form
    {
        private Database db;
        private string currentView;
        private int id;

        // Constructor for ZAPATOS (shoes)
        public EditForm(Database database, string view, int id, int talla, decimal precio, int idTipo, int idMarca, int idColor)
        {
            InitializeComponent();
            db = database;
            currentView = view;
            this.id = id;

            // Initialize fields for ZAPATOS
            AddField("Talla", "Talla", talla.ToString());
            AddField("Precio", "Precio", precio.ToString());
            AddField("ID_Tipo_De_Zapatos", "Tipo de Zapatos", idTipo.ToString());
            AddField("ID_Marca", "Marca", idMarca.ToString());
            AddField("ID_Color_De_Zapato", "Color de Zapato", idColor.ToString());

            SetupForm();
        }

        // Constructor for VENTAS (sales)
        public EditForm(Database database, string view, int id, int idUsuario, string estado)
        {
            InitializeComponent();
            db = database;
            currentView = view;
            this.id = id;

            // Initialize fields for VENTAS
            AddField("ID_USUARIO", "ID Usuario", idUsuario.ToString());
            AddField("ESTADO", "Estado", estado);

            SetupForm();
        }

        // Constructor for USUARIOS (users)
        public EditForm(Database database, string view, int id, string nombre, string apellido, string email, string contrasena, long telefono, bool activo)
        {
            InitializeComponent();
            db = database;
            currentView = view;
            this.id = id;

            // Initialize fields for USUARIOS
            AddField("NOMBRE", "Nombre", nombre);
            AddField("APELLIDO", "Apellido", apellido);
            AddField("EMAIL", "Email", email);
            AddField("CONTRASENA", "Contraseña", contrasena);
            AddField("TELEFONO", "Teléfono", telefono.ToString());
            AddField("ACTIVO", "Activo", activo.ToString());

            SetupForm();
        }

        private void AddField(string fieldName, string labelText, string defaultValue = "")
        {
            // Crear el Label
            var label = new Label
            {
                Text = labelText,
                Top = 20 + (30 * panelFields.Controls.Count / 2), // Posición vertical
                Left = 20 // Posición horizontal
            };

            // Crear el TextBox
            var textBox = new TextBox
            {
                Name = fieldName,
                Top = label.Top, // Misma posición vertical que el Label
                Left = 150, // Posición horizontal más a la derecha
                Width = 200, // Ancho del TextBox
                Text = defaultValue // Valor por defecto
            };

            // Agregar los controles al panel
            panelFields.Controls.Add(label);
            panelFields.Controls.Add(textBox);
        }

        private void SetupForm()
        {
            saveButton.Click += BtnGuardar_Click;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentView == "shoes")
                {
                    string query = id == -1
                        ? "INSERT INTO ZAPATOS (TALLA, PRECIO, ID_TIPO_DE_ZAPATOS, ID_MARCA, ID_COLOR_DE_ZAPATO) VALUES (@Talla, @Precio, @IdTipo, @IdMarca, @IdColor)"
                        : "UPDATE ZAPATOS SET TALLA = @Talla, PRECIO = @Precio, ID_TIPO_DE_ZAPATOS = @IdTipo, ID_MARCA = @IdMarca, ID_COLOR_DE_ZAPATO = @IdColor WHERE Id = @Id";

                    db.Execute(query, new Dictionary<string, object>
            {
                { "Talla", int.Parse(panelFields.Controls["Talla"].Text) },
                { "Precio", decimal.Parse(panelFields.Controls["Precio"].Text) },
                { "IdTipo", int.Parse(panelFields.Controls["ID_Tipo_De_Zapatos"].Text) },
                { "IdMarca", int.Parse(panelFields.Controls["ID_Marca"].Text) },
                { "IdColor", int.Parse(panelFields.Controls["ID_Color_De_Zapato"].Text) },
                { "Id", id }
            });
                }
                else if (currentView == "sales")
                {
                    string query = id == -1
                        ? "INSERT INTO VENTAS (ID_USUARIO, ESTADO) VALUES (@IdUsuario, @Estado)"
                        : "UPDATE VENTAS SET ID_USUARIO = @IdUsuario, ESTADO = @Estado WHERE ID_VENTA = @Id";

                    db.Execute(query, new Dictionary<string, object>
            {
                { "IdUsuario", int.Parse(panelFields.Controls["ID_USUARIO"].Text) },
                { "Estado", panelFields.Controls["ESTADO"].Text },
                { "Id", id }
            });
                }
                else if (currentView == "users")
                {
                    string query = id == -1
                        ? "INSERT INTO USUARIOS (NOMBRE, APELLIDO, EMAIL, CONTRASENA, TELEFONO, ACTIVO) VALUES (@Nombre, @Apellido, @Email, @Contrasena, @Telefono, @Activo)"
                        : "UPDATE USUARIOS SET NOMBRE = @Nombre, APELLIDO = @Apellido, EMAIL = @Email, CONTRASENA = @Contrasena, TELEFONO = @Telefono, ACTIVO = @Activo WHERE ID = @Id";

                    db.Execute(query, new Dictionary<string, object>
            {
                { "Nombre", panelFields.Controls["NOMBRE"].Text },
                { "Apellido", panelFields.Controls["APELLIDO"].Text },
                { "Email", panelFields.Controls["EMAIL"].Text },
                { "Contrasena", panelFields.Controls["CONTRASENA"].Text },
                { "Telefono", long.Parse(panelFields.Controls["TELEFONO"].Text) },
                { "Activo", bool.Parse(panelFields.Controls["ACTIVO"].Text) },
                { "Id", id }
            });
                }

                MessageBox.Show("Datos guardados correctamente.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}