namespace GoldenBoots
{
    partial class EditUserForm
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtContrasena = new TextBox();
            txtTelefono = new TextBox();
            chkActivo = new CheckBox();
            saveButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(125, 115);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(237, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(125, 171);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(237, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(125, 236);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(125, 302);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(237, 27);
            txtContrasena.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(125, 361);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(237, 27);
            txtTelefono.TabIndex = 4;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(395, 364);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 5;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(125, 414);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(237, 29);
            saveButton.TabIndex = 6;
            saveButton.Text = "Guardar";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 23);
            label1.Name = "label1";
            label1.Size = new Size(102, 36);
            label1.TabIndex = 7;
            label1.Text = "Editar ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 92);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saveButton);
            Controls.Add(chkActivo);
            Controls.Add(txtTelefono);
            Controls.Add(txtContrasena);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "EditUserForm";
            Text = "EditUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtContrasena;
        private TextBox txtTelefono;
        private CheckBox chkActivo;
        private Button saveButton;
        private Label label1;
        private Label label2;
    }
}