namespace Practicos.Practico_4
{
    partial class Formulario4
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
            label2 = new Label();
            TBDesde = new TextBox();
            TBHasta = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            label3 = new Label();
            BTPares = new Button();
            BTImpares = new Button();
            BTPrimos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 76);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 109);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Hasta";
            // 
            // TBDesde
            // 
            TBDesde.Location = new Point(102, 76);
            TBDesde.Margin = new Padding(2);
            TBDesde.Name = "TBDesde";
            TBDesde.Size = new Size(106, 23);
            TBDesde.TabIndex = 2;
            // 
            // TBHasta
            // 
            TBHasta.Location = new Point(102, 109);
            TBHasta.Margin = new Padding(2);
            TBHasta.Name = "TBHasta";
            TBHasta.Size = new Size(106, 23);
            TBHasta.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(102, 159);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(128, 20);
            button1.TabIndex = 4;
            button1.Text = "Generar Funcion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(267, 76);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(145, 244);
            listBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 50);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 6;
            label3.Text = "Lista de Numeros";
            // 
            // BTPares
            // 
            BTPares.Location = new Point(102, 210);
            BTPares.Margin = new Padding(2);
            BTPares.Name = "BTPares";
            BTPares.Size = new Size(128, 20);
            BTPares.TabIndex = 7;
            BTPares.Text = "Numeros Pares";
            BTPares.UseVisualStyleBackColor = true;
            BTPares.Click += button2_Click;
            // 
            // BTImpares
            // 
            BTImpares.Location = new Point(102, 245);
            BTImpares.Margin = new Padding(2);
            BTImpares.Name = "BTImpares";
            BTImpares.Size = new Size(128, 20);
            BTImpares.TabIndex = 8;
            BTImpares.Text = "Numeros Impares";
            BTImpares.UseVisualStyleBackColor = true;
            BTImpares.Click += BTImpares_Click;
            // 
            // BTPrimos
            // 
            BTPrimos.BackColor = SystemColors.ControlLight;
            BTPrimos.Location = new Point(102, 277);
            BTPrimos.Margin = new Padding(2);
            BTPrimos.Name = "BTPrimos";
            BTPrimos.Size = new Size(128, 20);
            BTPrimos.TabIndex = 9;
            BTPrimos.Text = "Numeros Primos";
            BTPrimos.UseVisualStyleBackColor = false;
            BTPrimos.Click += BTPrimos_Click;
            // 
            // Formulario4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 339);
            Controls.Add(BTPrimos);
            Controls.Add(BTImpares);
            Controls.Add(BTPares);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(TBHasta);
            Controls.Add(TBDesde);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Formulario4";
            Text = "Formulario4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TBDesde;
        private TextBox TBHasta;
        private Button button1;
        private ListBox listBox1;
        private Label label3;
        private Button BTPares;
        private Button BTImpares;
        private Button BTPrimos;
    }
}