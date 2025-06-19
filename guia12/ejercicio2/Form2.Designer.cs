namespace ejercicio2
{
    partial class FormModal
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
            btnAceptar = new Button();
            label1 = new Label();
            lbMostrarValor = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Font = new Font("Segoe UI", 10F);
            btnAceptar.Location = new Point(67, 63);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 44);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Cerrar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 3;
            label1.Text = "Valor:";
            // 
            // lbMostrarValor
            // 
            lbMostrarValor.BackColor = SystemColors.ActiveCaption;
            lbMostrarValor.Font = new Font("Segoe UI", 10F);
            lbMostrarValor.Location = new Point(67, 21);
            lbMostrarValor.Name = "lbMostrarValor";
            lbMostrarValor.Size = new Size(172, 19);
            lbMostrarValor.TabIndex = 6;
            // 
            // FormModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 129);
            Controls.Add(lbMostrarValor);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormModal";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label label1;
        public Label lbMostrarValor;
    }
}