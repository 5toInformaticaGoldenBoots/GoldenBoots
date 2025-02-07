namespace GoldenBoots
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
            b1 = new Button();
            l1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button9 = new Button();
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
            textBox2 = new TextBox();
            button1 = new Button();
            label13 = new Label();
            button2 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 406);
            pictureBox1.Margin = new Padding(2, 4, 2, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 205);
            pictureBox2.Margin = new Padding(2, 4, 2, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(96, 81);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(403, 45);
            label1.TabIndex = 2;
            label1.Text = "Mi carrito de compras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 101);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(578, 101);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 4;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(382, 101);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 5;
            label4.Text = "Medida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(809, 101);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 6;
            label5.Text = "Quitar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(312, 246);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 7;
            // 
            // b1
            // 
            b1.BackColor = SystemColors.ControlText;
            b1.ForeColor = SystemColors.ButtonHighlight;
            b1.Location = new Point(554, 215);
            b1.Margin = new Padding(2, 4, 2, 4);
            b1.Name = "b1";
            b1.Size = new Size(61, 54);
            b1.TabIndex = 9;
            b1.Text = "+";
            b1.UseVisualStyleBackColor = false;
            b1.Click += ChangeCantity;
            // 
            // l1
            // 
            l1.BackColor = SystemColors.ControlText;
            l1.ForeColor = SystemColors.ButtonHighlight;
            l1.Location = new Point(656, 214);
            l1.Margin = new Padding(2, 4, 2, 4);
            l1.Name = "l1";
            l1.Size = new Size(63, 55);
            l1.TabIndex = 12;
            l1.Text = "-";
            l1.UseVisualStyleBackColor = false;
            l1.Click += ChangeCantity;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(32, 126);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(957, 75);
            label7.TabIndex = 16;
            label7.Text = "_______________________________________________________________________________________________________________________________________\r\n\r\n\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(32, 330);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(957, 75);
            label8.TabIndex = 17;
            label8.Text = "_______________________________________________________________________________________________________________________________________\r\n\r\n\r\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(894, 101);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(64, 25);
            label9.TabIndex = 18;
            label9.Text = "Precio";
            // 
            // button9
            // 
            button9.Location = new Point(809, 224);
            button9.Margin = new Padding(2, 4, 2, 4);
            button9.Name = "button9";
            button9.Size = new Size(66, 49);
            button9.TabIndex = 19;
            button9.Text = "X";
            button9.UseVisualStyleBackColor = true;
            // 
            // cantityText1
            // 
            cantityText1.Location = new Point(607, 217);
            cantityText1.Margin = new Padding(2, 4, 2, 4);
            cantityText1.Multiline = true;
            cantityText1.Name = "cantityText1";
            cantityText1.Size = new Size(57, 50);
            cantityText1.TabIndex = 21;
            cantityText1.Text = "1";
            cantityText1.TextAlign = HorizontalAlignment.Center;
            cantityText1.TextChanged += NewTotal;
            // 
            // button3
            // 
            button3.Location = new Point(809, 406);
            button3.Margin = new Padding(2, 4, 2, 4);
            button3.Name = "button3";
            button3.Size = new Size(66, 49);
            button3.TabIndex = 22;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(32, 506);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(957, 75);
            label10.TabIndex = 23;
            label10.Text = "_______________________________________________________________________________________________________________________________________\r\n\r\n\r\n";
            // 
            // price1
            // 
            price1.AutoSize = true;
            price1.Location = new Point(894, 232);
            price1.Margin = new Padding(2, 0, 2, 0);
            price1.Name = "price1";
            price1.Size = new Size(95, 25);
            price1.TabIndex = 26;
            price1.Text = "RD$ 1,448";
            // 
            // price2
            // 
            price2.AutoSize = true;
            price2.Location = new Point(894, 416);
            price2.Margin = new Padding(2, 0, 2, 0);
            price2.Name = "price2";
            price2.Size = new Size(95, 25);
            price2.TabIndex = 27;
            price2.Text = "RD$ 2,962";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(689, 25);
            pictureBox3.Margin = new Padding(2, 4, 2, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 57);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(115, 217);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(193, 75);
            label11.TabIndex = 29;
            label11.Text = "Sandalias para damas \r\n\r\n\r\n";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(115, 242);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(209, 25);
            label12.TabIndex = 30;
            label12.Text = "Codigo de zapatos #003";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(111, 416);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(171, 25);
            label15.TabIndex = 31;
            label15.Text = "Zapato de hombre \r\n";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(111, 441);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(209, 25);
            label16.TabIndex = 32;
            label16.Text = "Codigo de zapatos #009";
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ActiveCaptionText;
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Location = new Point(809, 586);
            button10.Margin = new Padding(2, 4, 2, 4);
            button10.Name = "button10";
            button10.Size = new Size(112, 46);
            button10.TabIndex = 34;
            button10.Text = "Comprar";
            button10.UseVisualStyleBackColor = false;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 14F);
            total.Location = new Point(38, 581);
            total.Margin = new Padding(4, 0, 4, 0);
            total.Name = "total";
            total.Size = new Size(81, 38);
            total.TabIndex = 35;
            total.Text = "Total:";
            // 
            // bvolver
            // 
            bvolver.Location = new Point(-1, -6);
            bvolver.Margin = new Padding(4, 5, 4, 5);
            bvolver.Name = "bvolver";
            bvolver.Size = new Size(108, 39);
            bvolver.TabIndex = 36;
            bvolver.Text = "Volver";
            bvolver.UseVisualStyleBackColor = true;
            bvolver.Click += bvolver_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(392, 217);
            textBox2.Margin = new Padding(2, 4, 2, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(65, 50);
            textBox2.TabIndex = 38;
            textBox2.Text = "1";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(348, 217);
            button1.Margin = new Padding(2, 4, 2, 4);
            button1.Name = "button1";
            button1.Size = new Size(54, 54);
            button1.TabIndex = 39;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(32, 330);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(957, 75);
            label13.TabIndex = 40;
            label13.Text = "_______________________________________________________________________________________________________________________________________\r\n\r\n\r\n";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlText;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(451, 215);
            button2.Margin = new Padding(2, 4, 2, 4);
            button2.Name = "button2";
            button2.Size = new Size(56, 55);
            button2.TabIndex = 41;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlText;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(554, 411);
            button4.Margin = new Padding(2, 4, 2, 4);
            button4.Name = "button4";
            button4.Size = new Size(61, 54);
            button4.TabIndex = 42;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(607, 413);
            textBox3.Margin = new Padding(2, 4, 2, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(57, 50);
            textBox3.TabIndex = 43;
            textBox3.Text = "1";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlText;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(656, 409);
            button5.Margin = new Padding(2, 4, 2, 4);
            button5.Name = "button5";
            button5.Size = new Size(63, 55);
            button5.TabIndex = 44;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlText;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(341, 416);
            button6.Margin = new Padding(2, 4, 2, 4);
            button6.Name = "button6";
            button6.Size = new Size(61, 54);
            button6.TabIndex = 45;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(400, 416);
            textBox1.Margin = new Padding(2, 4, 2, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(57, 50);
            textBox1.TabIndex = 46;
            textBox1.Text = "1";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlText;
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(451, 413);
            button7.Margin = new Padding(2, 4, 2, 4);
            button7.Name = "button7";
            button7.Size = new Size(63, 55);
            button7.TabIndex = 47;
            button7.Text = "-";
            button7.UseVisualStyleBackColor = false;
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1051, 734);
            Controls.Add(button7);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label13);
            Controls.Add(button1);
            Controls.Add(textBox2);
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
            Controls.Add(button9);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(l1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(b1);
            Margin = new Padding(2, 4, 2, 4);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label13;
        private Button button2;
        private TextBox textBox3;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}