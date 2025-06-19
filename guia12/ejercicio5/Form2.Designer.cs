namespace ejercicio5
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
            btnCancelar = new Button();
            tbValor = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Font = new Font("Segoe UI", 10F);
            btnAceptar.Location = new Point(146, 71);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 44);
            btnAceptar.TabIndex = 15;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.Location = new Point(20, 71);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 44);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tbValor
            // 
            tbValor.Font = new Font("Segoe UI", 10F);
            tbValor.Location = new Point(89, 20);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(147, 25);
            tbValor.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(28, 23);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 12;
            label1.Text = "Valor:";
            // 
            // FormModal
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(287, 134);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(tbValor);
            Controls.Add(label1);
            Name = "FormModal";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        public TextBox tbValor;
        private Label label1;
    }
}