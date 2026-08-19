namespace ESFE.Clothing_Store.UI
{
    partial class Estado
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
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            // Cabecera con acento coral para sensación de moda y calidez
            label1.BackColor = System.Drawing.Color.FromArgb(255, 99, 71);
            label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            label1.Padding = new Padding(6, 4, 6, 4);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            // Indicador de búsqueda en teal para frescura
            label2.BackColor = System.Drawing.Color.FromArgb(0, 128, 128);
            label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 1;
            label2.Text = "Buscar estado por nombre ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 27);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            // Etiqueta en fondo mint suave para sensación acogedora
            label3.BackColor = System.Drawing.Color.FromArgb(227, 247, 237);
            label3.ForeColor = System.Drawing.Color.FromArgb(34, 34, 34);
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Id_estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.FromArgb(224, 247, 250);
            label4.ForeColor = System.Drawing.Color.FromArgb(34, 34, 34);
            label4.Location = new Point(12, 171);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 4;
            label4.Text = "Estado";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(82, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(101, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 27);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            // Botón Buscar en coral (CTA coherente con cabecera)
            button1.BackColor = System.Drawing.Color.FromArgb(255, 99, 71);
            button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            button1.Location = new Point(471, 57);
            button1.Name = "button1";
            button1.Size = new Size(87, 35);
            button1.TabIndex = 7;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            // Botón Limpiar en azul suave para balancear la paleta
            button2.BackColor = System.Drawing.Color.FromArgb(102, 153, 204);
            button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            button2.Location = new Point(577, 60);
            button2.Name = "button2";
            button2.Size = new Size(87, 32);
            button2.TabIndex = 8;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            // Instrucciones en rosa pálido para suavidad
            label5.BackColor = System.Drawing.Color.FromArgb(255, 240, 245);
            label5.ForeColor = System.Drawing.Color.FromArgb(34, 34, 34);
            label5.Location = new Point(12, 281);
            label5.Name = "label5";
            label5.Size = new Size(301, 20);
            label5.TabIndex = 9;
            label5.Text = "Eliminar o Agregar estado por nombrre o Id";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(319, 278);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(219, 27);
            textBox4.TabIndex = 10;
            // 
            // button3
            // 
            // Botón Eliminar en tono tomate suave
            button3.BackColor = System.Drawing.Color.FromArgb(220, 90, 90);
            button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            button3.Location = new Point(105, 320);
            button3.Name = "button3";
            button3.Size = new Size(87, 35);
            button3.TabIndex = 11;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            // Botón Agregar con acento dorado para CTA
            button4.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            button4.ForeColor = System.Drawing.Color.FromArgb(34, 34, 34);
            button4.Location = new Point(12, 320);
            button4.Name = "button4";
            button4.Size = new Size(87, 35);
            button4.TabIndex = 12;
            button4.Click += button4_Click;
            button4.Text = "Agregar";
            button4.UseVisualStyleBackColor = false;
            // 
            // Estado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            // Fondo claro y neutro para resaltar la paleta del formulario
            BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Estado";
            Text = "Estado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Label label5;
        private TextBox textBox4;
        private Button button3;
        private Button button4;
    }
}