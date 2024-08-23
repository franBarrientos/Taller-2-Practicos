
namespace Practicos.Practico_3
{
    partial class Formulario3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario3));
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
            panel1 = new Panel();
            CBMastercard = new CheckBox();
            CBVisa = new CheckBox();
            CBNaranja = new CheckBox();
            label1 = new Label();
            TBTelefono = new TextBox();
            LTelefono = new Label();
            CBVaron = new CheckBox();
            CBMujer = new CheckBox();
            ImgAvatar = new PictureBox();
            LBTitulo = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImgAvatar).BeginInit();
            SuspendLayout();
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(16, 23);
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
            LModificar.Location = new Point(203, 23);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(87, 25);
            LModificar.TabIndex = 1;
            LModificar.Text = "modificar";
            LModificar.Click += label1_Click_1;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(19, 62);
            LDni.Name = "LDni";
            LDni.Size = new Size(43, 25);
            LDni.TabIndex = 2;
            LDni.Text = "DNI";
            LDni.Click += label1_Click_2;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(19, 131);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(78, 25);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            LApellido.Click += label1_Click_3;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(19, 204);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(78, 25);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre";
            // 
            // TBDni
            // 
            TBDni.Location = new Point(203, 59);
            TBDni.Name = "TBDni";
            TBDni.Size = new Size(150, 31);
            TBDni.TabIndex = 5;
            TBDni.TextChanged += TBDni_TextChanged;
            // 
            // TBApellido
            // 
            TBApellido.Location = new Point(203, 131);
            TBApellido.Name = "TBApellido";
            TBApellido.Size = new Size(150, 31);
            TBApellido.TabIndex = 6;
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(203, 204);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(150, 31);
            TBNombre.TabIndex = 7;
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(0, 0);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 19;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(0, 0);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(CBMastercard);
            panel1.Controls.Add(CBVisa);
            panel1.Controls.Add(CBNaranja);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TBTelefono);
            panel1.Controls.Add(LTelefono);
            panel1.Controls.Add(LNya);
            panel1.Controls.Add(LModificar);
            panel1.Controls.Add(LDni);
            panel1.Controls.Add(TBNombre);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(TBApellido);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(TBDni);
            panel1.Location = new Point(12, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 454);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // CBMastercard
            // 
            CBMastercard.AutoSize = true;
            CBMastercard.Location = new Point(203, 410);
            CBMastercard.Name = "CBMastercard";
            CBMastercard.Size = new Size(126, 29);
            CBMastercard.TabIndex = 13;
            CBMastercard.Text = "Mastercard";
            CBMastercard.UseVisualStyleBackColor = true;
            CBMastercard.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // CBVisa
            // 
            CBVisa.AutoSize = true;
            CBVisa.Location = new Point(203, 375);
            CBVisa.Name = "CBVisa";
            CBVisa.Size = new Size(70, 29);
            CBVisa.TabIndex = 12;
            CBVisa.Text = "Visa";
            CBVisa.UseVisualStyleBackColor = true;
            CBVisa.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // CBNaranja
            // 
            CBNaranja.AutoSize = true;
            CBNaranja.Location = new Point(203, 340);
            CBNaranja.Name = "CBNaranja";
            CBNaranja.Size = new Size(98, 29);
            CBNaranja.TabIndex = 11;
            CBNaranja.Text = "Naranja";
            CBNaranja.UseVisualStyleBackColor = true;
            CBNaranja.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 360);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 10;
            label1.Text = "Tarjetas de credito";
            label1.Click += label1_Click_5;
            // 
            // TBTelefono
            // 
            TBTelefono.Location = new Point(203, 284);
            TBTelefono.Name = "TBTelefono";
            TBTelefono.Size = new Size(150, 31);
            TBTelefono.TabIndex = 9;
            TBTelefono.TextChanged += textBox1_TextChanged;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(19, 284);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(79, 25);
            LTelefono.TabIndex = 8;
            LTelefono.Text = "Telefono";
            LTelefono.Click += label1_Click_4;
            // 
            // CBVaron
            // 
            CBVaron.AutoSize = true;
            CBVaron.Checked = true;
            CBVaron.CheckState = CheckState.Checked;
            CBVaron.Location = new Point(432, 324);
            CBVaron.Name = "CBVaron";
            CBVaron.Size = new Size(84, 29);
            CBVaron.TabIndex = 12;
            CBVaron.Text = "Varon";
            CBVaron.UseVisualStyleBackColor = true;
            CBVaron.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // CBMujer
            // 
            CBMujer.AutoSize = true;
            CBMujer.Location = new Point(546, 324);
            CBMujer.Name = "CBMujer";
            CBMujer.Size = new Size(83, 29);
            CBMujer.TabIndex = 13;
            CBMujer.Text = "Mujer";
            CBMujer.UseVisualStyleBackColor = true;
            CBMujer.CheckedChanged += CBMujer_CheckedChanged;
            // 
            // ImgAvatar
            // 
            ImgAvatar.BackgroundImage = (Image)resources.GetObject("ImgAvatar.BackgroundImage");
            ImgAvatar.Location = new Point(413, 76);
            ImgAvatar.MaximumSize = new Size(226, 219);
            ImgAvatar.MinimumSize = new Size(226, 219);
            ImgAvatar.Name = "ImgAvatar";
            ImgAvatar.Size = new Size(226, 219);
            ImgAvatar.SizeMode = PictureBoxSizeMode.CenterImage;
            ImgAvatar.TabIndex = 0;
            ImgAvatar.TabStop = false;
            ImgAvatar.Click += Avatar_Click_1;
            // 
            // LBTitulo
            // 
            LBTitulo.AutoSize = true;
            LBTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBTitulo.ForeColor = Color.LightSeaGreen;
            LBTitulo.Location = new Point(228, 16);
            LBTitulo.Name = "LBTitulo";
            LBTitulo.Size = new Size(230, 45);
            LBTitulo.TabIndex = 14;
            LBTitulo.Text = "Nuevo Cliente";
            LBTitulo.Click += label2_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(12, 568);
            button1.Name = "button1";
            button1.Size = new Size(201, 89);
            button1.TabIndex = 15;
            button1.Text = "Guardar";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += BGuardar_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(228, 568);
            button2.Name = "button2";
            button2.Size = new Size(207, 89);
            button2.TabIndex = 16;
            button2.Text = "Eliminar";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += BEliminar_Click;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(452, 568);
            button3.Name = "button3";
            button3.Size = new Size(177, 89);
            button3.TabIndex = 17;
            button3.Text = "Salir";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Formulario3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 701);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(LBTitulo);
            Controls.Add(ImgAvatar);
            Controls.Add(CBMujer);
            Controls.Add(CBVaron);
            Controls.Add(panel1);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            MaximizeBox = false;
            MaximumSize = new Size(693, 757);
            MinimumSize = new Size(493, 557);
            Name = "Formulario3";
            Text = "Pequeño Formulario";
            Load += Formulario2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImgAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           return;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            return;
        }

        private void label1_Click_4(object sender, EventArgs e)
        {
            return;
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
        private Panel panel1;
        private TextBox TBTelefono;
        private Label LTelefono;
        private Label label1;
        private CheckBox CBMastercard;
        private CheckBox CBVisa;
        private CheckBox CBNaranja;
        private CheckBox CBVaron;
        private CheckBox CBMujer;
        private PictureBox ImgAvatar;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label LBTitulo;
    }
}