using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GoldenBoots
{
    public partial class CreateForm : Form
    {
        private Database db;
        private string currentView;
        public Dictionary<string, object> Datos { get; private set; }

        public CreateForm(Database database, string view)
        {
            InitializeComponent();
            db = database;
            currentView = view;
            Datos = new Dictionary<string, object>();

            SetupForm();
        }

        private void SetupForm()
        {
            // Configura el formulario según la vista actual
            switch (currentView)
            {
                case "clientes":
                    this.Text = "Crear Cliente";
                    AddField("NOMBRE", "Nombre");
                    AddField("APELLIDO", "Apellido");
                    AddField("EMAIL", "Email");
                    AddField("CONTRASENA", "Contraseña");
                    AddField("TELEFONO", "Teléfono");
                    AddField("ACTIVO", "Activo (true/false)");
                    break;

                case "zapatos":
                    this.Text = "Crear Zapato";
                    AddField("TALLA", "Talla");
                    AddField("PRECIO", "Precio");
                    AddField("ID_TIPO_DE_ZAPATOS", "ID Tipo de Zapatos");
                    AddField("ID_MARCA", "ID Marca");
                    AddField("ID_COLOR_DE_ZAPATO", "ID Color de Zapato");
                    break;

                case "ventas":
                    this.Text = "Crear Venta";
                    AddField("ID_USUARIO", "ID Usuario");
                    AddField("ESTADO", "Estado");
                    break;

                default:
                    throw new InvalidOperationException("Vista no reconocida.");
            }

            // Botón para guardar
            var saveButton = new Button { Text = "Guardar", Top = 20 + (30 * panelFields.Controls.Count / 2), Left = 20 };
            saveButton.Click += BtnGuardar_Click;
            this.Controls.Add(saveButton);
        }

        private void AddField(string fieldName, string labelText)
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
                Width = 200 // Ancho del TextBox
            };

            // Agregar los controles al panel
            panelFields.Controls.Add(label);
            panelFields.Controls.Add(textBox);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Recopilar los datos del formulario
                foreach (Control control in panelFields.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        Datos[textBox.Name] = textBox.Text;
                    }
                }

                // Insertar los datos en la base de datos
                switch (currentView)
                {
                    case "clientes":
                        db.Execute(
                            "INSERT INTO USUARIOS (NOMBRE, APELLIDO, EMAIL, CONTRASENA, TELEFONO, ACTIVO) VALUES (@Nombre, @Apellido, @Email, @Contrasena, @Telefono, @Activo)",
                            new Dictionary<string, object>
                            {
                                { "Nombre", Datos["NOMBRE"] },
                                { "Apellido", Datos["APELLIDO"] },
                                { "Email", Datos["EMAIL"] },
                                { "Contrasena", Datos["CONTRASENA"] },
                                { "Telefono", long.Parse(Datos["TELEFONO"].ToString()) },
                                { "Activo", bool.Parse(Datos["ACTIVO"].ToString()) }
                            }
                        );
                        break;

                    case "zapatos":
                        db.Execute(
                            "INSERT INTO ZAPATOS (TALLA, PRECIO, ID_TIPO_DE_ZAPATOS, ID_MARCA, ID_COLOR_DE_ZAPATO) VALUES (@Talla, @Precio, @IdTipo, @IdMarca, @IdColor)",
                            new Dictionary<string, object>
                            {
                                { "Talla", int.Parse(Datos["TALLA"].ToString()) },
                                { "Precio", decimal.Parse(Datos["PRECIO"].ToString()) },
                                { "IdTipo", int.Parse(Datos["ID_TIPO_DE_ZAPATOS"].ToString()) },
                                { "IdMarca", int.Parse(Datos["ID_MARCA"].ToString()) },
                                { "IdColor", int.Parse(Datos["ID_COLOR_DE_ZAPATO"].ToString()) }
                            }
                        );
                        break;

                    case "ventas":
                        db.Execute(
                            "INSERT INTO VENTAS (ID_USUARIO, ESTADO) VALUES (@IdUsuario, @Estado)",
                            new Dictionary<string, object>
                            {
                                { "IdUsuario", int.Parse(Datos["ID_USUARIO"].ToString()) },
                                { "Estado", Datos["ESTADO"].ToString() }
                            }
                        );
                        break;
                }

                MessageBox.Show("Registro creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el registro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}