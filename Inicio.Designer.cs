namespace GoldenBoots
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            carro3 = new PictureBox();
            label6 = new Label();
            linkLabel6 = new LinkLabel();
            label10 = new Label();
            linkLabel5 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label15 = new Label();
            label9 = new Label();
            label13 = new Label();
            label11 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            sesion = new Label();
            panel2 = new Panel();
            label8 = new Label();
            inicio123 = new PictureBox();
            label17 = new Label();
            label18 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carro3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inicio123).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(carro3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(linkLabel6);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(linkLabel5);
            panel1.Controls.Add(linkLabel4);
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(sesion);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 207);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(858, 22);
            label1.Name = "label1";
            label1.Size = new Size(66, 23);
            label1.TabIndex = 22;
            label1.Text = "Carrito";
            label1.Click += carro3_Click;
            // 
            // carro3
            // 
            carro3.Location = new Point(800, 12);
            carro3.Name = "carro3";
            carro3.Size = new Size(52, 42);
            carro3.SizeMode = PictureBoxSizeMode.Zoom;
            carro3.TabIndex = 0;
            carro3.TabStop = false;
            carro3.Click += carro3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(925, 20);
            label6.Name = "label6";
            label6.Size = new Size(16, 25);
            label6.TabIndex = 21;
            label6.Text = "|";
            // 
            // linkLabel6
            // 
            linkLabel6.AutoSize = true;
            linkLabel6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel6.LinkColor = Color.Black;
            linkLabel6.Location = new Point(981, 157);
            linkLabel6.Name = "linkLabel6";
            linkLabel6.Size = new Size(84, 23);
            linkLabel6.TabIndex = 20;
            linkLabel6.TabStop = true;
            linkLabel6.Text = "Ofertas";
            linkLabel6.LinkClicked += linkLabel6_LinkClicked;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(956, 157);
            label10.Name = "label10";
            label10.Size = new Size(19, 28);
            label10.TabIndex = 19;
            label10.Text = "/";
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel5.LinkColor = Color.Black;
            linkLabel5.Location = new Point(830, 158);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(121, 23);
            linkLabel5.TabIndex = 18;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Novedades";
            linkLabel5.Click += OpenCatalog;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel4.LinkColor = Color.Black;
            linkLabel4.Location = new Point(699, 158);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(65, 23);
            linkLabel4.TabIndex = 17;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Niñas";
            linkLabel4.Click += OpenCatalog;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(568, 160);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(65, 23);
            linkLabel3.TabIndex = 16;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Niños";
            linkLabel3.Click += OpenCatalog;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(454, 158);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(65, 23);
            linkLabel2.TabIndex = 15;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Mujer";
            linkLabel2.Click += OpenCatalog;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(318, 158);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(89, 23);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Hombre";
            linkLabel1.Click += OpenCatalog;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(785, 157);
            label15.Name = "label15";
            label15.Size = new Size(19, 28);
            label15.TabIndex = 12;
            label15.Text = "/";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(416, 155);
            label9.Name = "label9";
            label9.Size = new Size(19, 28);
            label9.TabIndex = 6;
            label9.Text = "/";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(657, 156);
            label13.Name = "label13";
            label13.Size = new Size(19, 28);
            label13.TabIndex = 10;
            label13.Text = "/";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(530, 157);
            label11.Name = "label11";
            label11.Size = new Size(19, 28);
            label11.TabIndex = 8;
            label11.Text = "/";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1017, 23);
            label3.Name = "label3";
            label3.Size = new Size(144, 23);
            label3.TabIndex = 3;
            label3.Text = "Unete a nosotros";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(938, 22);
            label5.Name = "label5";
            label5.Size = new Size(61, 23);
            label5.TabIndex = 1;
            label5.Text = "Ayuda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1155, 20);
            label2.Name = "label2";
            label2.Size = new Size(16, 25);
            label2.TabIndex = 2;
            label2.Text = "|";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1005, 20);
            label4.Name = "label4";
            label4.Size = new Size(16, 25);
            label4.TabIndex = 0;
            label4.Text = "|";
            // 
            // sesion
            // 
            sesion.AutoSize = true;
            sesion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sesion.Location = new Point(1167, 23);
            sesion.Name = "sesion";
            sesion.Size = new Size(112, 23);
            sesion.TabIndex = 1;
            sesion.Text = "Iniciar sesión";
            sesion.Click += OpenRegister;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label8);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(1281, 69);
            panel2.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(32, 21);
            label8.Name = "label8";
            label8.Size = new Size(202, 35);
            label8.TabIndex = 4;
            label8.Text = "GooldentBoots";
            // 
            // inicio123
            // 
            inicio123.BackColor = Color.Transparent;
            inicio123.Location = new Point(0, 205);
            inicio123.Name = "inicio123";
            inicio123.Size = new Size(1284, 386);
            inicio123.TabIndex = 1;
            inicio123.TabStop = false;
            inicio123.Click += pictureBox4_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Sitka Small", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label17.Location = new Point(286, 604);
            label17.Name = "label17";
            label17.Size = new Size(857, 58);
            label17.TabIndex = 2;
            label17.Text = "\"Camina con estilo, pisa con confianza\"";
            label17.Click += label17_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label18.Location = new Point(454, 652);
            label18.Name = "label18";
            label18.Size = new Size(465, 25);
            label18.TabIndex = 3;
            label18.Text = "Encuentra el par perfecto para cada paso de tu vida";
            label18.Click += label18_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1284, 749);
            Controls.Add(inicio123);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Name = "Inicio";
            Text = "pagina de inicio";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carro3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inicio123).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label sesion;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private PictureBox carro3;
        private Label label9;
        private Label label13;
        private Label label11;
        private Label label15;
        private Label label17;
        private Label label18;
        public PictureBox inicio123;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel5;
        private Label label8;
        private LinkLabel linkLabel6;
        private Label label10;
        private Label label1;
        private Label label6;
    }
}
