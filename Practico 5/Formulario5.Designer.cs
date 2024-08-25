namespace Practicos.Practico_5
{
    partial class Formulario5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario5));
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            CBMujer = new CheckBox();
            CBHombre = new CheckBox();
            BTAgregar = new Button();
            TBFoto = new TextBox();
            button1 = new Button();
            label6 = new Label();
            TBSaldo = new TextBox();
            TBApellido = new TextBox();
            TBNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ovalImg1 = new OvalImg();
            dataGridView1 = new DataGridView();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            Saldo = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            Ruta = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ovalImg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(CBMujer);
            panel1.Controls.Add(CBHombre);
            panel1.Controls.Add(BTAgregar);
            panel1.Controls.Add(TBFoto);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TBSaldo);
            panel1.Controls.Add(TBApellido);
            panel1.Controls.Add(TBNombre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(47, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 424);
            panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(323, 137);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(195, 31);
            dateTimePicker1.TabIndex = 13;
            // 
            // CBMujer
            // 
            CBMujer.AutoSize = true;
            CBMujer.BackColor = Color.Transparent;
            CBMujer.ForeColor = SystemColors.ControlLight;
            CBMujer.Location = new Point(363, 192);
            CBMujer.Name = "CBMujer";
            CBMujer.Size = new Size(83, 29);
            CBMujer.TabIndex = 12;
            CBMujer.Text = "Mujer";
            CBMujer.UseVisualStyleBackColor = false;
            CBMujer.CheckedChanged += CBMujer_CheckedChanged;
            // 
            // CBHombre
            // 
            CBHombre.AutoSize = true;
            CBHombre.BackColor = Color.Transparent;
            CBHombre.ForeColor = SystemColors.ControlLight;
            CBHombre.Location = new Point(228, 192);
            CBHombre.Name = "CBHombre";
            CBHombre.Size = new Size(104, 29);
            CBHombre.TabIndex = 11;
            CBHombre.Text = "Hombre";
            CBHombre.UseVisualStyleBackColor = false;
            CBHombre.CheckedChanged += CBHombre_CheckedChanged;
            // 
            // BTAgregar
            // 
            BTAgregar.Image = (Image)resources.GetObject("BTAgregar.Image");
            BTAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BTAgregar.Location = new Point(241, 345);
            BTAgregar.Name = "BTAgregar";
            BTAgregar.Size = new Size(226, 72);
            BTAgregar.TabIndex = 10;
            BTAgregar.Text = "Agregar";
            BTAgregar.TextAlign = ContentAlignment.MiddleRight;
            BTAgregar.UseVisualStyleBackColor = true;
            BTAgregar.Click += BTAgregar_Click;
            // 
            // TBFoto
            // 
            TBFoto.Location = new Point(228, 301);
            TBFoto.Name = "TBFoto";
            TBFoto.Size = new Size(254, 31);
            TBFoto.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(25, 290);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Foto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Papyrus", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(25, 290);
            label6.Name = "label6";
            label6.Size = new Size(0, 51);
            label6.TabIndex = 7;
            // 
            // TBSaldo
            // 
            TBSaldo.Location = new Point(228, 241);
            TBSaldo.Name = "TBSaldo";
            TBSaldo.Size = new Size(254, 31);
            TBSaldo.TabIndex = 6;
            // 
            // TBApellido
            // 
            TBApellido.Location = new Point(228, 79);
            TBApellido.Name = "TBApellido";
            TBApellido.Size = new Size(254, 31);
            TBApellido.TabIndex = 5;
            TBApellido.TextChanged += TBApellido_TextChanged;
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(228, 15);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(254, 31);
            TBNombre.TabIndex = 1;
            TBNombre.TextChanged += TBNombre_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Papyrus", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(25, 230);
            label5.Name = "label5";
            label5.Size = new Size(117, 51);
            label5.TabIndex = 4;
            label5.Text = "Saldo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Papyrus", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(25, 179);
            label4.Name = "label4";
            label4.Size = new Size(107, 51);
            label4.TabIndex = 3;
            label4.Text = "Sexo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Papyrus", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(25, 128);
            label3.Name = "label3";
            label3.Size = new Size(292, 51);
            label3.TabIndex = 2;
            label3.Text = "Fecha Nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Papyrus", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(25, 68);
            label2.Name = "label2";
            label2.Size = new Size(154, 51);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Papyrus", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(25, 4);
            label1.Name = "label1";
            label1.Size = new Size(143, 51);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // ovalImg1
            // 
            ovalImg1.BackColor = Color.DarkGray;
            ovalImg1.Image = (Image)resources.GetObject("ovalImg1.Image");
            ovalImg1.Location = new Point(703, 106);
            ovalImg1.Name = "ovalImg1";
            ovalImg1.Size = new Size(246, 268);
            ovalImg1.SizeMode = PictureBoxSizeMode.StretchImage;
            ovalImg1.TabIndex = 1;
            ovalImg1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Apellido, Nombre, FechaNacimiento, Sexo, Eliminar, Saldo, Foto, Ruta });
            dataGridView1.Location = new Point(32, 486);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1048, 216);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            FechaNacimiento.MinimumWidth = 8;
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.ReadOnly = true;
            FechaNacimiento.Width = 150;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 8;
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            Sexo.Width = 150;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            Eliminar.Width = 150;
            // 
            // Saldo
            // 
            Saldo.HeaderText = "Saldo";
            Saldo.MinimumWidth = 8;
            Saldo.Name = "Saldo";
            Saldo.ReadOnly = true;
            Saldo.Width = 150;
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.MinimumWidth = 8;
            Foto.Name = "Foto";
            Foto.ReadOnly = true;
            Foto.Width = 150;
            // 
            // Ruta
            // 
            Ruta.HeaderText = "Ruta";
            Ruta.MinimumWidth = 8;
            Ruta.Name = "Ruta";
            Ruta.ReadOnly = true;
            Ruta.Width = 150;
            // 
            // Formulario5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1112, 714);
            Controls.Add(dataGridView1);
            Controls.Add(ovalImg1);
            Controls.Add(panel1);
            Name = "Formulario5";
            Text = "Formulario con DataGrid";
            Load += Formulario5_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ovalImg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TBNombre;
        private TextBox TBSaldo;
        private TextBox TBApellido;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Label label6;
        private TextBox TBFoto;
        private OvalImg ovalImg1;
        private DataGridView dataGridView1;
        private Button BTAgregar;
        private CheckBox CBHombre;
        private CheckBox CBMujer;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewImageColumn Foto;
        private DataGridViewTextBoxColumn Ruta;
    }
}