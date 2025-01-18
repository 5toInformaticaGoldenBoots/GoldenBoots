using System.ComponentModel;

namespace GoldenBoots
{
    partial class Ofertas
    {
        private Container components;

        /* <summary>
<<<<<<< Updated upstream
///  Required designer variable.
=======
/// Required designer variable.
>>>>>>> Stashed changes
/// </summary>
private System.ComponentModel.IContainer components = null;

/// <summary>
<<<<<<< Updated upstream
///  Clean up any resources being used.
=======
/// Clean up any resources being used.
>>>>>>> Stashed changes
/// </summary>
/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
*/
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /* <summary>
<<<<<<< Updated upstream
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
=======
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
>>>>>>> Stashed changes
        /// </summary>
        /// */
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label20 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            label16 = new Label();
            label9 = new Label();
            pictureBox3 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            panel1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            ((ISupportInitialize)pictureBox5).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label20);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(969, 113);
            panel1.TabIndex = 0;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.Control;
            label20.Location = new Point(0, 35);
            label20.Name = "label20";
            label20.Size = new Size(202, 35);
            label20.TabIndex = 25;
            label20.Text = "GooldentBoots";
            label20.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario7;
            pictureBox1.Location = new Point(903, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(275, 45);
            label6.Name = "label6";
            label6.Size = new Size(448, 53);
            label6.TabIndex = 6;
            label6.Text = "Ofertas y Descuentos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F);
            label1.Location = new Point(56, 175);
            label1.Name = "label1";
            label1.Size = new Size(713, 46);
            label1.TabIndex = 1;
            label1.Text = "Hasta 70% de ahorro  en tus estilos ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 24F);
            label2.Location = new Point(43, 223);
            label2.Name = "label2";
            label2.Size = new Size(202, 46);
            label2.TabIndex = 2;
            label2.Text = " favoritos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F);
            label3.Location = new Point(56, 315);
            label3.Name = "label3";
            label3.Size = new Size(811, 17);
            label3.TabIndex = 3;
            label3.Text = "¡Aprovecha nuestro descuento de fin de temporada! Obtén hasta un 70% menos en estilos seleccionados. Esta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F);
            label4.Location = new Point(56, 335);
            label4.Name = "label4";
            label4.Size = new Size(866, 17);
            label4.TabIndex = 4;
            label4.Text = "promoción es por tiempo limitado o hasta agotar existencias, así que no esperes. Recuerda que no es válida con otros";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F);
            label5.Location = new Point(56, 355);
            label5.Name = "label5";
            label5.Size = new Size(75, 17);
            label5.TabIndex = 5;
            label5.Text = "cupones.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(275, 466);
            label7.Name = "label7";
            label7.Size = new Size(413, 53);
            label7.TabIndex = 7;
            label7.Text = "Calzados en Oferta";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.za1;
            pictureBox4.Location = new Point(16, 6);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(177, 207);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._19;
            pictureBox5.Location = new Point(12, 3);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(193, 209);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(26, 217);
            label10.Name = "label10";
            label10.Size = new Size(162, 23);
            label10.TabIndex = 14;
            label10.Text = "Sandalias de cuña";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(33, 211);
            label11.Name = "label11";
            label11.Size = new Size(160, 23);
            label11.TabIndex = 15;
            label11.Text = "Tenis para damas";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 8.5F);
            label12.Location = new Point(50, 253);
            label12.Name = "label12";
            label12.Size = new Size(117, 17);
            label12.TabIndex = 16;
            label12.Text = "Antes: RD$900";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 8.5F);
            label13.ForeColor = Color.DarkOrange;
            label13.Location = new Point(47, 270);
            label13.Name = "label13";
            label13.Size = new Size(120, 17);
            label13.TabIndex = 17;
            label13.Text = "Ahora: RD$500";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 8.5F);
            label14.Location = new Point(46, 253);
            label14.Name = "label14";
            label14.Size = new Size(131, 17);
            label14.TabIndex = 18;
            label14.Text = "Antes: RD$1,448";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Rounded MT Bold", 8.5F);
            label15.ForeColor = Color.DarkOrange;
            label15.Location = new Point(46, 270);
            label15.Name = "label15";
            label15.Size = new Size(120, 17);
            label15.TabIndex = 19;
            label15.Text = "Ahora: RD$800";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial Rounded MT Bold", 8.5F);
            label17.ForeColor = Color.DarkOrange;
            label17.Location = new Point(44, 266);
            label17.Name = "label17";
            label17.Size = new Size(134, 17);
            label17.TabIndex = 21;
            label17.Text = "Ahora: RD$1,000";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Rounded MT Bold", 8.5F);
            label16.Location = new Point(47, 249);
            label16.Name = "label16";
            label16.Size = new Size(131, 17);
            label16.TabIndex = 20;
            label16.Text = "Antes: RD$1,860";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(24, 211);
            label9.Name = "label9";
            label9.Size = new Size(165, 23);
            label9.TabIndex = 13;
            label9.Text = "Zapatos elegantes";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.co1;
            pictureBox3.Location = new Point(13, 1);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(189, 209);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label17);
            groupBox1.Location = new Point(56, 605);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 303);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveBorder;
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Location = new Point(373, 605);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(217, 303);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveBorder;
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(pictureBox4);
            groupBox3.Location = new Point(699, 605);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(208, 303);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            // 
            // Ofertas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 999);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ofertas";
            Text = "Ofertas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            ((ISupportInitialize)pictureBox5).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label20;
        private Label label17;
        private Label label16;
        private Label label9;
        private PictureBox pictureBox3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
//<<<<<<< Updated upstream
}
//=======

//>>>>>>> Stashed changes
