namespace GoldenBoots
{
    partial class Sobrenosotros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobrenosotros));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1747, 239);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(623, 68);
            label1.Name = "label1";
            label1.Size = new Size(495, 81);
            label1.TabIndex = 1;
            label1.Text = "Sobre nosotros ";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(410, 170);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(901, 514);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 170);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.TopRight;
            label3.Location = new Point(421, 184);
            label3.Name = "label3";
            label3.Size = new Size(880, 405);
            label3.TabIndex = 4;
            label3.Text = resources.GetString("label3.Text");
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Inicio";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(1354, 275);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(332, 382);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(49, 266);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(332, 391);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Times New Roman", 26F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(123, 170);
            label4.Name = "label4";
            label4.Size = new Size(174, 58);
            label4.TabIndex = 8;
            label4.Text = "Misión\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Times New Roman", 26F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(1426, 161);
            label5.Name = "label5";
            label5.Size = new Size(195, 58);
            label5.TabIndex = 9;
            label5.Text = "Valores ";
            // 
            // Sobrenosotros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1742, 695);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Sobrenosotros";
            Text = "Sobre Nosotros";
            TransparencyKey = Color.Black;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label4;
        private Label label5;
    }
}