namespace GoldenBoots
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtContraseña = new TextBox();
            label5 = new Label();
            txtConfirmar = new TextBox();
            label6 = new Label();
            chkTerminos = new CheckBox();
            button1 = new Button();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 24);
            label1.TabIndex = 0;
            label1.Text = "Regístrate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 52);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(67, 68);
            txtNombre.Margin = new Padding(2);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 24);
            txtNombre.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(67, 124);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(191, 24);
            txtUsuario.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 107);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre de usuario";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(67, 175);
            txtEmail.Margin = new Padding(2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 24);
            txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 158);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(67, 228);
            txtContraseña.Margin = new Padding(2);
            txtContraseña.Multiline = true;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(191, 24);
            txtContraseña.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(67, 211);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 8;
            label5.Text = "Contraseña";
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(67, 284);
            txtConfirmar.Margin = new Padding(2);
            txtConfirmar.Multiline = true;
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.PasswordChar = '*';
            txtConfirmar.Size = new Size(191, 24);
            txtConfirmar.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(67, 268);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 10;
            label6.Text = "Confirmar contraseña";
            // 
            // chkTerminos
            // 
            chkTerminos.AutoSize = true;
            chkTerminos.Location = new Point(54, 352);
            chkTerminos.Margin = new Padding(2);
            chkTerminos.Name = "chkTerminos";
            chkTerminos.Size = new Size(213, 19);
            chkTerminos.TabIndex = 11;
            chkTerminos.Text = "Acepto los terminos y condiciones?\r\n";
            chkTerminos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(104, 316);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(111, 28);
            button1.TabIndex = 12;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnRegistrar_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(94, 376);
            linkLabel2.Margin = new Padding(2, 0, 2, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(125, 15);
            linkLabel2.TabIndex = 13;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "¿Ya tienes una cuenta?";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(345, 412);
            Controls.Add(linkLabel2);
            Controls.Add(button1);
            Controls.Add(chkTerminos);
            Controls.Add(label6);
            Controls.Add(txtConfirmar);
            Controls.Add(label5);
            Controls.Add(txtContraseña);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Registro";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtUsuario;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtContraseña;
        private Label label5;
        private TextBox txtConfirmar;
        private Label label6;
        private CheckBox chkTerminos;
        private Button button1;
        private LinkLabel linkLabel2;
    }
}