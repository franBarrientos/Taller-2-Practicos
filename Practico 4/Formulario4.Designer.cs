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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 126);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 181);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 1;
            label2.Text = "Hasta";
            // 
            // TBDesde
            // 
            TBDesde.Location = new Point(145, 126);
            TBDesde.Name = "TBDesde";
            TBDesde.Size = new Size(150, 31);
            TBDesde.TabIndex = 2;
            // 
            // TBHasta
            // 
            TBHasta.Location = new Point(145, 181);
            TBHasta.Name = "TBHasta";
            TBHasta.Size = new Size(150, 31);
            TBHasta.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(324, 154);
            button1.Name = "button1";
            button1.Size = new Size(183, 34);
            button1.TabIndex = 4;
            button1.Text = "Generar Funcion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(550, 126);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 254);
            listBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(562, 46);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 6;
            label3.Text = "Lista de Numeros";
            // 
            // Formulario4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(TBHasta);
            Controls.Add(TBDesde);
            Controls.Add(label2);
            Controls.Add(label1);
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
    }
}