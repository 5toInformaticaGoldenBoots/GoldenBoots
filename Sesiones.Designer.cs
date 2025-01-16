namespace GoldenBoots
{
    partial class Sesiones
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
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            mail = new Label();
            label4 = new Label();
            iniciar = new Button();
            email = new TextBox();
            pass = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(102, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 29);
            label1.TabIndex = 0;
            label1.Text = "Iniciar sesión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(88, 44);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 16);
            label2.TabIndex = 1;
            label2.Text = "¿Es tu  primera vez?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(238, 59);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 2;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(208, 45);
            linkLabel2.Margin = new Padding(2, 0, 2, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(59, 15);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Registrate\r\n";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(110, 190);
            linkLabel3.Margin = new Padding(2, 0, 2, 0);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(139, 15);
            linkLabel3.TabIndex = 6;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "¿Olvidaste la contraseña?";
            // 
            // mail
            // 
            mail.AutoSize = true;
            mail.BackColor = Color.Transparent;
            mail.ForeColor = SystemColors.ActiveCaptionText;
            mail.Location = new Point(88, 83);
            mail.Margin = new Padding(2, 0, 2, 0);
            mail.Name = "mail";
            mail.Size = new Size(41, 15);
            mail.TabIndex = 7;
            mail.Text = "Email*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(87, 146);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 8;
            label4.Text = "Contraseña*";
            // 
            // iniciar
            // 
            iniciar.BackColor = Color.Black;
            iniciar.ForeColor = SystemColors.ButtonHighlight;
            iniciar.Location = new Point(110, 226);
            iniciar.Margin = new Padding(2);
            iniciar.Name = "iniciar";
            iniciar.Size = new Size(139, 29);
            iniciar.TabIndex = 9;
            iniciar.Text = "Iniciar sesión";
            iniciar.UseVisualStyleBackColor = false;
            iniciar.Click += iniciar_Click;
            // 
            // email
            // 
            email.Location = new Point(87, 101);
            email.Margin = new Padding(2);
            email.Name = "email";
            email.Size = new Size(180, 23);
            email.TabIndex = 11;
            // 
            // pass
            // 
            pass.Location = new Point(87, 164);
            pass.Margin = new Padding(2);
            pass.Name = "pass";
            pass.Size = new Size(180, 23);
            pass.TabIndex = 12;
            // 
            // Sesiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(372, 346);
            Controls.Add(pass);
            Controls.Add(email);
            Controls.Add(iniciar);
            Controls.Add(label4);
            Controls.Add(mail);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            Margin = new Padding(2);
            Name = "Sesiones";
            Text = "InicioDeSesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Label mail;
        private Label label4;
        private Button iniciar;
        private TextBox email;
        private TextBox pass;
    }
}