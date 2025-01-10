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
    public partial class Sesiones : Form
    {
        public Sesiones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Sesiones_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }

    namespace LoginForm
    {
        public partial class LoginForm : Form
        {
            public LoginForm()
            {
                InitializeComponent();
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
//                btnLogin.Click += (sender, e) => MessageBox.Show("Iniciando sesión...");
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
    }

}
    