namespace ejercicio5
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
            btnRegistrar = new Button();
            btnBuscar = new Button();
            btnMostrar = new Button();
            groupBox1 = new GroupBox();
            tbValor = new TextBox();
            rbBiseccional = new RadioButton();
            rbSecuencial = new RadioButton();
            rbBurbuja = new RadioButton();
            rbQuicksort = new RadioButton();
            tbLista = new TextBox();
            label1 = new Label();
            lbCantidadIngresados = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 10F);
            btnRegistrar.Location = new Point(194, 25);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(125, 41);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.Location = new Point(182, 22);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(126, 38);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI", 10F);
            btnMostrar.Location = new Point(194, 216);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(126, 41);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar Listado";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbValor);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(rbBiseccional);
            groupBox1.Controls.Add(rbSecuencial);
            groupBox1.Location = new Point(12, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de Ordenamiento";
            // 
            // tbValor
            // 
            tbValor.Font = new Font("Segoe UI", 10F);
            tbValor.Location = new Point(18, 30);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(145, 25);
            tbValor.TabIndex = 2;
            // 
            // rbBiseccional
            // 
            rbBiseccional.AutoSize = true;
            rbBiseccional.Font = new Font("Segoe UI", 10F);
            rbBiseccional.Location = new Point(18, 90);
            rbBiseccional.Name = "rbBiseccional";
            rbBiseccional.Size = new Size(92, 23);
            rbBiseccional.TabIndex = 5;
            rbBiseccional.TabStop = true;
            rbBiseccional.Text = "Biseccional";
            rbBiseccional.UseVisualStyleBackColor = true;
            // 
            // rbSecuencial
            // 
            rbSecuencial.AutoSize = true;
            rbSecuencial.Font = new Font("Segoe UI", 10F);
            rbSecuencial.Location = new Point(18, 61);
            rbSecuencial.Name = "rbSecuencial";
            rbSecuencial.Size = new Size(89, 23);
            rbSecuencial.TabIndex = 4;
            rbSecuencial.TabStop = true;
            rbSecuencial.Text = "Secuencial";
            rbSecuencial.UseVisualStyleBackColor = true;
            // 
            // rbBurbuja
            // 
            rbBurbuja.AutoSize = true;
            rbBurbuja.Font = new Font("Segoe UI", 10F);
            rbBurbuja.Location = new Point(18, 29);
            rbBurbuja.Name = "rbBurbuja";
            rbBurbuja.Size = new Size(74, 23);
            rbBurbuja.TabIndex = 6;
            rbBurbuja.TabStop = true;
            rbBurbuja.Text = "Burbuja";
            rbBurbuja.UseVisualStyleBackColor = true;
            // 
            // rbQuicksort
            // 
            rbQuicksort.AutoSize = true;
            rbQuicksort.Font = new Font("Segoe UI", 10F);
            rbQuicksort.Location = new Point(18, 58);
            rbQuicksort.Name = "rbQuicksort";
            rbQuicksort.Size = new Size(86, 23);
            rbQuicksort.TabIndex = 7;
            rbQuicksort.TabStop = true;
            rbQuicksort.Text = "Quicksort";
            rbQuicksort.UseVisualStyleBackColor = true;
            // 
            // tbLista
            // 
            tbLista.Location = new Point(12, 227);
            tbLista.Multiline = true;
            tbLista.Name = "tbLista";
            tbLista.Size = new Size(165, 152);
            tbLista.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(110, 395);
            label1.Name = "label1";
            label1.Size = new Size(67, 19);
            label1.TabIndex = 9;
            label1.Text = "Cantidad:";
            // 
            // lbCantidadIngresados
            // 
            lbCantidadIngresados.BorderStyle = BorderStyle.FixedSingle;
            lbCantidadIngresados.Font = new Font("Segoe UI", 10F);
            lbCantidadIngresados.Location = new Point(194, 394);
            lbCantidadIngresados.Name = "lbCantidadIngresados";
            lbCantidadIngresados.Size = new Size(139, 19);
            lbCantidadIngresados.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbQuicksort);
            groupBox2.Controls.Add(rbBurbuja);
            groupBox2.Location = new Point(194, 277);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(139, 102);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo Ordenamiento";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 434);
            Controls.Add(groupBox2);
            Controls.Add(lbCantidadIngresados);
            Controls.Add(label1);
            Controls.Add(tbLista);
            Controls.Add(groupBox1);
            Controls.Add(btnMostrar);
            Controls.Add(btnRegistrar);
            Name = "Form1";
            Text = "Generar número";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnBuscar;
        private Button btnMostrar;
        private GroupBox groupBox1;
        private TextBox tbValor;
        private RadioButton rbBiseccional;
        private RadioButton rbSecuencial;
        private RadioButton rbBurbuja;
        private RadioButton rbQuicksort;
        private TextBox tbLista;
        private Label label1;
        private Label lbCantidadIngresados;
        private GroupBox groupBox2;
    }
}
