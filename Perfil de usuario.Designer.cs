namespace GoldenBoots
{
    partial class perfil
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
            panel1 = new Panel();
            CONTRASEÑA3 = new PictureBox();
            NOMBRE2 = new PictureBox();
            APELLIDO1 = new PictureBox();
            cerrar = new Button();
            fecha = new TextBox();
            pass = new TextBox();
            direccion = new TextBox();
            userNombre = new TextBox();
            name = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            volver = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CONTRASEÑA3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NOMBRE2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)APELLIDO1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(CONTRASEÑA3);
            panel1.Controls.Add(NOMBRE2);
            panel1.Controls.Add(APELLIDO1);
            panel1.Controls.Add(cerrar);
            panel1.Controls.Add(fecha);
            panel1.Controls.Add(pass);
            panel1.Controls.Add(direccion);
            panel1.Controls.Add(userNombre);
            panel1.Controls.Add(name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(258, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 515);
            panel1.TabIndex = 0;
            // 
            // CONTRASEÑA3
            // 
            CONTRASEÑA3.Image = Properties.Resources.pen_to_square_regular1;
            CONTRASEÑA3.Location = new Point(334, 352);
            CONTRASEÑA3.Name = "CONTRASEÑA3";
            CONTRASEÑA3.Size = new Size(28, 23);
            CONTRASEÑA3.SizeMode = PictureBoxSizeMode.Zoom;
            CONTRASEÑA3.TabIndex = 15;
            CONTRASEÑA3.TabStop = false;
            CONTRASEÑA3.Click += ChangeData;
            // 
            // NOMBRE2
            // 
            NOMBRE2.Image = Properties.Resources.pen_to_square_regular1;
            NOMBRE2.Location = new Point(334, 255);
            NOMBRE2.Name = "NOMBRE2";
            NOMBRE2.Size = new Size(28, 23);
            NOMBRE2.SizeMode = PictureBoxSizeMode.Zoom;
            NOMBRE2.TabIndex = 14;
            NOMBRE2.TabStop = false;
            NOMBRE2.Click += ChangeData;
            // 
            // APELLIDO1
            // 
            APELLIDO1.Image = Properties.Resources.pen_to_square_regular1;
            APELLIDO1.Location = new Point(334, 209);
            APELLIDO1.Name = "APELLIDO1";
            APELLIDO1.Size = new Size(28, 23);
            APELLIDO1.SizeMode = PictureBoxSizeMode.Zoom;
            APELLIDO1.TabIndex = 13;
            APELLIDO1.TabStop = false;
            APELLIDO1.Click += ChangeData;
            // 
            // cerrar
            // 
            cerrar.Location = new Point(198, 474);
            cerrar.Name = "cerrar";
            cerrar.Size = new Size(89, 23);
            cerrar.TabIndex = 11;
            cerrar.Text = "Cerrar sesión";
            cerrar.UseVisualStyleBackColor = true;
            cerrar.Click += cerrar_Click;
            // 
            // fecha
            // 
            fecha.Location = new Point(169, 395);
            fecha.Name = "fecha";
            fecha.Size = new Size(159, 23);
            fecha.TabIndex = 10;
            fecha.Text = "17/1/2025";
            // 
            // pass
            // 
            pass.Location = new Point(169, 352);
            pass.Name = "pass";
            pass.PasswordChar = '*';
            pass.Size = new Size(159, 23);
            pass.TabIndex = 9;
            // 
            // direccion
            // 
            direccion.Location = new Point(169, 303);
            direccion.Name = "direccion";
            direccion.Size = new Size(159, 23);
            direccion.TabIndex = 8;
            direccion.Text = "Las Caobas";
            // 
            // userNombre
            // 
            userNombre.Location = new Point(169, 255);
            userNombre.Name = "userNombre";
            userNombre.Size = new Size(159, 23);
            userNombre.TabIndex = 7;
            // 
            // name
            // 
            name.Location = new Point(169, 209);
            name.Name = "name";
            name.Size = new Size(159, 23);
            name.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(62, 399);
            label5.Name = "label5";
            label5.Size = new Size(101, 19);
            label5.TabIndex = 5;
            label5.Text = "Dia de registro:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(82, 356);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 4;
            label4.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(93, 307);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 3;
            label3.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 259);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 2;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 213);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario1;
            pictureBox1.Location = new Point(126, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(12, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(249, 515);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // volver
            // 
            volver.Location = new Point(0, 0);
            volver.Name = "volver";
            volver.Size = new Size(75, 23);
            volver.TabIndex = 14;
            volver.Text = "Volver";
            volver.UseVisualStyleBackColor = true;
            volver.Click += volver_Click;
            // 
            // perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 566);
            Controls.Add(volver);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "perfil";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CONTRASEÑA3).EndInit();
            ((System.ComponentModel.ISupportInitialize)NOMBRE2).EndInit();
            ((System.ComponentModel.ISupportInitialize)APELLIDO1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox fecha;
        private TextBox pass;
        private TextBox direccion;
        private TextBox userNombre;
        private TextBox name;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox APELLIDO1;
        private Button cerrar;
        private PictureBox pictureBox2;
        private PictureBox CONTRASEÑA3;
        private PictureBox NOMBRE2;
        private Button volver;
    }
}