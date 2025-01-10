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
    public partial class Form2 : Form
    {
        

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void InitializeComponent()
        {
            this.Text = "InicioDeSesion";
            this.ClientSize = new System.Drawing.Size(400, 400);

            // Título
            Label lblTitle = new Label();
            lblTitle.Text = "Iniciar sesión";
            lblTitle.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(125, 20);
            lblTitle.AutoSize = true;
            this.Controls.Add(lblTitle);

            // ¿Es tu primera vez?
            Label lblPrimeraVez = new Label();
            lblPrimeraVez.Text = "¿Es tu primera vez?";
            lblPrimeraVez.Location = new System.Drawing.Point(100, 60);
            lblPrimeraVez.AutoSize = true;
            this.Controls.Add(lblPrimeraVez);

            LinkLabel linkRegistrarse = new LinkLabel();
            linkRegistrarse.Text = "Registrate";
            linkRegistrarse.Location = new System.Drawing.Point(220, 60);
            linkRegistrarse.AutoSize = true;
            linkRegistrarse.Click += (sender, e) => {
                RegistroForm registroForm = new RegistroForm();
                registroForm.ShowDialog();
            };
            this.Controls.Add(linkRegistrarse);

            // Email
            Label lblEmail = new Label();
            lblEmail.Text = "Email*";
            lblEmail.Location = new System.Drawing.Point(50, 100);
            lblEmail.AutoSize = true;
            this.Controls.Add(lblEmail);

            TextBox txtEmail = new TextBox();
            txtEmail.Location = new System.Drawing.Point(50, 120);
            txtEmail.Width = 300;
            this.Controls.Add(txtEmail);

            // Contraseña
            Label lblPassword = new Label();
            lblPassword.Text = "Contraseña*";
            lblPassword.Location = new System.Drawing.Point(50, 160);
            lblPassword.AutoSize = true;
            this.Controls.Add(lblPassword);

            TextBox txtPassword = new TextBox();
            txtPassword.Location = new System.Drawing.Point(50, 180);
            txtPassword.Width = 300;
            txtPassword.UseSystemPasswordChar = true;
            this.Controls.Add(txtPassword);

            // ¿Olvidaste la contraseña?
            LinkLabel linkOlvidaste = new LinkLabel();
            linkOlvidaste.Text = "¿Olvidaste la contraseña?";
            linkOlvidaste.Location = new System.Drawing.Point(50, 210);
            linkOlvidaste.AutoSize = true;
            this.Controls.Add(linkOlvidaste);

            // Botón de iniciar sesión
            Button btnLogin = new Button();
            btnLogin.Text = "Iniciar sesión";
            btnLogin.Location = new System.Drawing.Point(150, 250);
            btnLogin.Width = 100;
            btnLogin.Click += (sender, e) => MessageBox.Show("Iniciando sesión...");
            this.Controls.Add(btnLogin);

            // O conéctate con:
            Label lblConectar = new Label();
            lblConectar.Text = "O conectate con:";
            lblConectar.Location = new System.Drawing.Point(150, 300);
            lblConectar.AutoSize = true;
            this.Controls.Add(lblConectar);

            // Botones de Google y Facebook
            Button btnGoogle = new Button();
            btnGoogle.Text = "Google";
            btnGoogle.Location = new System.Drawing.Point(100, 330);
            btnGoogle.Width = 80;
            this.Controls.Add(btnGoogle);

            Button btnFacebook = new Button();
            btnFacebook.Text = "Facebook";
            btnFacebook.Location = new System.Drawing.Point(200, 330);
            btnFacebook.Width = 80;
            this.Controls.Add(btnFacebook);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }

    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeRegistroForm();
        }

        private void InitializeRegistroForm()
        {
            this.Text = "Registro";
            this.ClientSize = new System.Drawing.Size(400, 450);

            // Título
            Label lblTitle = new Label();
            lblTitle.Text = "Regístrate";
            lblTitle.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(140, 20);
            lblTitle.AutoSize = true;
            this.Controls.Add(lblTitle);

            // Nombre
            Label lblNombre = new Label();
            lblNombre.Text = "Nombre";
            lblNombre.Location = new System.Drawing.Point(50, 70);
            lblNombre.AutoSize = true;
            this.Controls.Add(lblNombre);

            TextBox txtNombre = new TextBox();
            txtNombre.Location = new System.Drawing.Point(50, 90);
            txtNombre.Width = 300;
            this.Controls.Add(txtNombre);

            // Nombre de usuario
            Label lblUsuario = new Label();
            lblUsuario.Text = "Nombre de usuario";
            lblUsuario.Location = new System.Drawing.Point(50, 130);
            lblUsuario.AutoSize = true;
            this.Controls.Add(lblUsuario);

            TextBox txtUsuario = new TextBox();
            txtUsuario.Location = new System.Drawing.Point(50, 150);
            txtUsuario.Width = 300;
            this.Controls.Add(txtUsuario);

            // Email
            Label lblEmail = new Label();
            lblEmail.Text = "Email";
            lblEmail.Location = new System.Drawing.Point(50, 190);
            lblEmail.AutoSize = true;
            this.Controls.Add(lblEmail);

            TextBox txtEmail = new TextBox();
            txtEmail.Location = new System.Drawing.Point(50, 210);
            txtEmail.Width = 300;
            this.Controls.Add(txtEmail);

            // Contraseña
            Label lblPassword = new Label();
            lblPassword.Text = "Contraseña";
            lblPassword.Location = new System.Drawing.Point(50, 250);
            lblPassword.AutoSize = true;
            this.Controls.Add(lblPassword);

            TextBox txtPassword = new TextBox();
            txtPassword.Location = new System.Drawing.Point(50, 270);
            txtPassword.Width = 300;
            txtPassword.UseSystemPasswordChar = true;
            this.Controls.Add(txtPassword);

            // Confirmar contraseña
            Label lblConfirmPassword = new Label();
            lblConfirmPassword.Text = "Confirmar contraseña";
            lblConfirmPassword.Location = new System.Drawing.Point(50, 310);
            lblConfirmPassword.AutoSize = true;
            this.Controls.Add(lblConfirmPassword);

            TextBox txtConfirmPassword = new TextBox();
            txtConfirmPassword.Location = new System.Drawing.Point(50, 330);
            txtConfirmPassword.Width = 300;
            txtConfirmPassword.UseSystemPasswordChar = true;
            this.Controls.Add(txtConfirmPassword);

            // Checkbox de términos y condiciones
            CheckBox chkTerms = new CheckBox();
            chkTerms.Text = "Acepto los términos y condiciones";
            chkTerms.Location = new System.Drawing.Point(50, 370);
            chkTerms.AutoSize = true;
            this.Controls.Add(chkTerms);

            // Botón de registrar
            Button btnRegister = new Button();
            btnRegister.Text = "Registrar";
            btnRegister.Location = new System.Drawing.Point(150, 400);
            btnRegister.Width = 100;
            btnRegister.Click += (sender, e) => {
                if (chkTerms.Checked)
                {
                    MessageBox.Show("Registro completado.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe aceptar los términos y condiciones.");
                }
            };
            this.Controls.Add(btnRegister);
        }
    }
}
        
