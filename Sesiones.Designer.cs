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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            linkLabel3 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
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
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(208, 44);
            linkLabel2.Margin = new Padding(2, 0, 2, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(59, 15);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Registrate\r\n";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 100);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 26);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(88, 168);
            textBox2.Margin = new Padding(2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 22);
            textBox2.TabIndex = 5;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(88, 190);
            linkLabel3.Margin = new Padding(2, 0, 2, 0);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(139, 15);
            linkLabel3.TabIndex = 6;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "¿Olvidaste la contraseña?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(88, 83);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 7;
            label3.Text = "Email*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(88, 151);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 8;
            label4.Text = "Contraseña*";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(110, 226);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(139, 29);
            button1.TabIndex = 9;
            button1.Text = "Iniciar sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(127, 262);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 10;
            label5.Text = "O conectate con:\r\n";
            // 
            // Sesiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(372, 346);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(linkLabel3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            Margin = new Padding(2);
            Name = "Sesiones";
            Text = "InicioDeSesion";
            TransparencyKey = Color.White;
            Load += Sesiones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel linkLabel3;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
    }
}