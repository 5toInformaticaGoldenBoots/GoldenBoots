﻿namespace GoldenBoots
{
    partial class Carrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrito));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            b1 = new Button();
            button4 = new Button();
            l1 = new Button();
            b2 = new Button();
            l2 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button9 = new Button();
            cantityText2 = new TextBox();
            cantityText1 = new TextBox();
            button3 = new Button();
            label10 = new Label();
            price1 = new Label();
            price2 = new Label();
            pictureBox3 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            label15 = new Label();
            label16 = new Label();
            button10 = new Button();
            total = new Label();
            bvolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 247);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.th__2_;
            pictureBox2.Location = new Point(23, 131);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(276, 31);
            label1.TabIndex = 2;
            label1.Text = "Mi carrito de compras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 70);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(368, 70);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(268, 70);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 5;
            label4.Text = "Medida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(566, 70);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 6;
            label5.Text = "Quitar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(219, 148);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(272, 140);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(47, 31);
            button1.TabIndex = 8;
            button1.Text = "12";
            button1.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            b1.BackColor = SystemColors.ControlText;
            b1.ForeColor = SystemColors.ButtonHighlight;
            b1.Location = new Point(350, 138);
            b1.Margin = new Padding(2);
            b1.Name = "b1";
            b1.Size = new Size(46, 32);
            b1.TabIndex = 9;
            b1.Text = "+";
            b1.UseVisualStyleBackColor = false;
            b1.Click += ChangeCantity;
            // 
            // button4
            // 
            button4.Location = new Point(272, 247);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(47, 32);
            button4.TabIndex = 11;
            button4.Text = "8";
            button4.UseVisualStyleBackColor = true;
            // 
            // l1
            // 
            l1.BackColor = SystemColors.ControlText;
            l1.ForeColor = SystemColors.ButtonHighlight;
            l1.Location = new Point(433, 138);
            l1.Margin = new Padding(2);
            l1.Name = "l1";
            l1.Size = new Size(46, 33);
            l1.TabIndex = 12;
            l1.Text = "-";
            l1.UseVisualStyleBackColor = false;
            l1.Click += ChangeCantity;
            // 
            // b2
            // 
            b2.BackColor = SystemColors.ControlText;
            b2.ForeColor = SystemColors.ButtonHighlight;
            b2.Location = new Point(350, 242);
            b2.Margin = new Padding(2);
            b2.Name = "b2";
            b2.Size = new Size(46, 36);
            b2.TabIndex = 13;
            b2.Text = "+";
            b2.UseVisualStyleBackColor = false;
            b2.Click += ChangeCantity;
            // 
            // l2
            // 
            l2.BackColor = SystemColors.ControlText;
            l2.ForeColor = SystemColors.ButtonHighlight;
            l2.Location = new Point(433, 239);
            l2.Margin = new Padding(2);
            l2.Name = "l2";
            l2.Size = new Size(46, 38);
            l2.TabIndex = 15;
            l2.Text = "-";
            l2.UseVisualStyleBackColor = false;
            l2.Click += ChangeCantity;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(23, 85);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(682, 45);
            label7.TabIndex = 16;
            label7.Text = "_______________________________________________________________________________________________________________________________________\r\n\r\n\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(23, 198);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(682, 45);
            label8.TabIndex = 17;
            label8.Text = "_______________________________________________________________________________________________________________________________________\r\n\r\n\r\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(630, 70);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 18;
            label9.Text = "Precio";
            // 
            // button9
            // 
            button9.Location = new Point(566, 134);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(46, 29);
            button9.TabIndex = 19;
            button9.Text = "X";
            button9.UseVisualStyleBackColor = true;
            // 
            // cantityText2
            // 
            cantityText2.Location = new Point(388, 243);
            cantityText2.Margin = new Padding(2);
            cantityText2.Multiline = true;
            cantityText2.Name = "cantityText2";
            cantityText2.Size = new Size(50, 34);
            cantityText2.TabIndex = 20;
            cantityText2.Text = "1";
            cantityText2.TextAlign = HorizontalAlignment.Center;
            cantityText2.TextChanged += NewTotal;
            // 
            // cantityText1
            // 
            cantityText1.Location = new Point(388, 139);
            cantityText1.Margin = new Padding(2);
            cantityText1.Multiline = true;
            cantityText1.Name = "cantityText1";
            cantityText1.Size = new Size(50, 32);
            cantityText1.TabIndex = 21;
            cantityText1.Text = "1";
            cantityText1.TextAlign = HorizontalAlignment.Center;
            cantityText1.TextChanged += NewTotal;
            // 
            // button3
            // 
            button3.Location = new Point(566, 244);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(46, 29);
            button3.TabIndex = 22;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(23, 304);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(682, 45);
            label10.TabIndex = 23;
            label10.Text = "_______________________________________________________________________________________________________________________________________\r\n\r\n\r\n";
            // 
            // price1
            // 
            price1.AutoSize = true;
            price1.Location = new Point(626, 140);
            price1.Margin = new Padding(2, 0, 2, 0);
            price1.Name = "price1";
            price1.Size = new Size(64, 15);
            price1.TabIndex = 26;
            price1.Text = "RD$ 250.00";
            // 
            // price2
            // 
            price2.AutoSize = true;
            price2.Location = new Point(620, 254);
            price2.Margin = new Padding(2, 0, 2, 0);
            price2.Name = "price2";
            price2.Size = new Size(73, 15);
            price2.TabIndex = 27;
            price2.Text = "RD$ 5,000.00";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(503, 8);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(94, 130);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(135, 15);
            label11.TabIndex = 29;
            label11.Text = "Tacones Rojos Elegantes\r\n";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(94, 145);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(133, 15);
            label12.TabIndex = 30;
            label12.Text = "Codigo de zapatos #003";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(94, 250);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(119, 15);
            label15.TabIndex = 31;
            label15.Text = "Tacones louis vuitton";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(94, 266);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(133, 15);
            label16.TabIndex = 32;
            label16.Text = "Codigo de zapatos #009";
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ActiveCaptionText;
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Location = new Point(566, 352);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(79, 28);
            button10.TabIndex = 34;
            button10.Text = "Comprar";
            button10.UseVisualStyleBackColor = false;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 14F);
            total.Location = new Point(26, 349);
            total.Name = "total";
            total.Size = new Size(56, 25);
            total.TabIndex = 35;
            total.Text = "Total:";
            // 
            // bvolver
            // 
            bvolver.Location = new Point(-1, 1);
            bvolver.Name = "bvolver";
            bvolver.Size = new Size(75, 23);
            bvolver.TabIndex = 36;
            bvolver.Text = "Volver";
            bvolver.UseVisualStyleBackColor = true;
            bvolver.Click += bvolver_Click;
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(736, 440);
            Controls.Add(bvolver);
            Controls.Add(total);
            Controls.Add(button10);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(pictureBox3);
            Controls.Add(price2);
            Controls.Add(price1);
            Controls.Add(label10);
            Controls.Add(button3);
            Controls.Add(cantityText1);
            Controls.Add(cantityText2);
            Controls.Add(button9);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(l2);
            Controls.Add(b2);
            Controls.Add(l1);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(b1);
            Margin = new Padding(2);
            Name = "Carrito";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button b1;
        private Button button4;
        private Button l1;
        private Button b2;
        private Button l2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button9;
        private TextBox cantityText2;
        private TextBox cantityText1;
        private Button button3;
        private Label label10;
        private Label price1;
        private Label price2;
        private PictureBox pictureBox3;
        private Label label11;
        private Label label12;
        private Label label15;
        private Label label16;
        private Button button10;
        private Label total;
        private Button bvolver;
    }
}