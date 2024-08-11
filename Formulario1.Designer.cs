namespace Practico1
{
    partial class Formulario1
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
            BGuardar = new Button();
            BEliminar = new Button();
            LApellido = new Label();
            LNombre = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            BSalir = new Button();
            SuspendLayout();
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(24, 152);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(112, 34);
            BGuardar.TabIndex = 0;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(142, 152);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(112, 34);
            BEliminar.TabIndex = 1;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(12, 29);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(78, 25);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido";
            LApellido.Click += label1_Click;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(12, 81);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(78, 25);
            LNombre.TabIndex = 3;
            LNombre.Text = "Nombre";
            LNombre.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.AcceptsReturn = true;
            textBox3.Location = new Point(260, 12);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(206, 220);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // BSalir
            // 
            BSalir.Location = new Point(73, 207);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(112, 34);
            BSalir.TabIndex = 7;
            BSalir.Text = "Salir";
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // Formulario1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 244);
            Controls.Add(BSalir);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LNombre);
            Controls.Add(LApellido);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            KeyPreview = true;
            Name = "Formulario1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mi primer Forms";
            Load += Formulario1_Load;
            ResumeLayout(false);
            PerformLayout();
            this.KeyDown += Form1_KeyDown;
        }

        #endregion

        private Button BGuardar;
        private Button BEliminar;
        private Label LApellido;
        private Label LNombre;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button BSalir;
    }
}
