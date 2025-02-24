namespace GoldenBoots
{
    partial class EditForm
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
            saveButton = new Button();
            panelFields = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 36);
            label1.TabIndex = 16;
            label1.Text = "Editar ";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(123, 435);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(237, 29);
            saveButton.TabIndex = 15;
            saveButton.Text = "Guardar";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // panelFields
            // 
            panelFields.Location = new Point(75, 48);
            panelFields.Name = "panelFields";
            panelFields.Size = new Size(354, 362);
            panelFields.TabIndex = 18;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 476);
            Controls.Add(panelFields);
            Controls.Add(label1);
            Controls.Add(saveButton);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button saveButton;
        private Panel panelFields;
    }
}