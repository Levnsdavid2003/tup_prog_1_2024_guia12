namespace ejercicio2
{
    partial class Form1
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
            label1 = new Label();
            btnMostrarValor = new Button();
            tbValor = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(23, 34);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 4;
            label1.Text = "Valor:";
            // 
            // btnMostrarValor
            // 
            btnMostrarValor.Font = new Font("Segoe UI", 10F);
            btnMostrarValor.Location = new Point(284, 12);
            btnMostrarValor.Name = "btnMostrarValor";
            btnMostrarValor.Size = new Size(203, 63);
            btnMostrarValor.TabIndex = 3;
            btnMostrarValor.Text = "Mostrar Valor";
            btnMostrarValor.UseVisualStyleBackColor = true;
            btnMostrarValor.Click += btnMostrarValor_Click;
            // 
            // tbValor
            // 
            tbValor.Font = new Font("Segoe UI", 10F);
            tbValor.Location = new Point(72, 31);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(197, 25);
            tbValor.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 88);
            Controls.Add(tbValor);
            Controls.Add(label1);
            Controls.Add(btnMostrarValor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMostrarValor;
        private TextBox tbValor;
    }
}
