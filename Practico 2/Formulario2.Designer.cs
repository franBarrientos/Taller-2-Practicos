namespace Practicos.Practico_2
{
    partial class Formulario2
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
            LNya = new Label();
            LModificar = new Label();
            LDni = new Label();
            LApellido = new Label();
            LNombre = new Label();
            TBDni = new TextBox();
            TBApellido = new TextBox();
            TBNombre = new TextBox();
            BGuardar = new Button();
            BEliminar = new Button();
            SuspendLayout();
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(27, 46);
            LNya.Name = "LNya";
            LNya.Size = new Size(167, 25);
            LNya.TabIndex = 0;
            LNya.Text = "Nombre y Apellido:";
            LNya.Click += label1_Click;
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(253, 46);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(87, 25);
            LModificar.TabIndex = 1;
            LModificar.Text = "modificar";
            LModificar.Click += label1_Click_1;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(27, 115);
            LDni.Name = "LDni";
            LDni.Size = new Size(43, 25);
            LDni.TabIndex = 2;
            LDni.Text = "DNI";
            LDni.Click += label1_Click_2;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(27, 184);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(78, 25);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            LApellido.Click += label1_Click_3;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(27, 257);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(78, 25);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre";
            // 
            // TBDni
            // 
            TBDni.Location = new Point(211, 112);
            TBDni.Name = "TBDni";
            TBDni.Size = new Size(150, 31);
            TBDni.TabIndex = 5;
            TBDni.TextChanged += TBDni_TextChanged;
            // 
            // TBApellido
            // 
            TBApellido.Location = new Point(211, 184);
            TBApellido.Name = "TBApellido";
            TBApellido.Size = new Size(150, 31);
            TBApellido.TabIndex = 6;
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(211, 257);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(150, 31);
            TBNombre.TabIndex = 7;
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(59, 367);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(112, 34);
            BGuardar.TabIndex = 8;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(228, 367);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(112, 34);
            BEliminar.TabIndex = 9;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // Formulario2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 501);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Controls.Add(TBNombre);
            Controls.Add(TBApellido);
            Controls.Add(TBDni);
            Controls.Add(LNombre);
            Controls.Add(LApellido);
            Controls.Add(LDni);
            Controls.Add(LModificar);
            Controls.Add(LNya);
            MaximizeBox = false;
            MaximumSize = new Size(493, 557);
            MinimumSize = new Size(493, 557);
            Name = "Formulario2";
            Text = "Pequeño Formulario";
            Load += Formulario2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNya;
        private Label LModificar;
        private Label LDni;
        private Label LApellido;
        private Label LNombre;
        private TextBox TBDni;
        private TextBox TBApellido;
        private TextBox TBNombre;
        private Button BGuardar;
        private Button BEliminar;
    }
}