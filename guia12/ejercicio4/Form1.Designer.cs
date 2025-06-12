namespace ejercicio4
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
            btnSolicitar = new Button();
            lbCantidad = new Label();
            lsbListado = new ListBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSolicitar
            // 
            btnSolicitar.Font = new Font("Segoe UI", 10F);
            btnSolicitar.Location = new Point(97, 22);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(149, 60);
            btnSolicitar.TabIndex = 9;
            btnSolicitar.Text = "Solicitar Valor";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // lbCantidad
            // 
            lbCantidad.BorderStyle = BorderStyle.FixedSingle;
            lbCantidad.Font = new Font("Segoe UI", 10F);
            lbCantidad.Location = new Point(216, 126);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(87, 19);
            lbCantidad.TabIndex = 8;
            // 
            // lsbListado
            // 
            lsbListado.Font = new Font("Segoe UI", 10F);
            lsbListado.FormattingEnabled = true;
            lsbListado.ItemHeight = 17;
            lsbListado.Location = new Point(27, 162);
            lsbListado.Name = "lsbListado";
            lsbListado.Size = new Size(277, 174);
            lsbListado.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(143, 126);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 6;
            label2.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(22, 126);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 5;
            label1.Text = "Listado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 364);
            Controls.Add(btnSolicitar);
            Controls.Add(lbCantidad);
            Controls.Add(lsbListado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSolicitar;
        private Label lbCantidad;
        private ListBox lsbListado;
        private Label label2;
        private Label label1;
    }
}
