using Color = System.Drawing.Color;

namespace ESFE.Clothing_Store.UI
{
    partial class Clientes
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
            btn = new Button();
            Administrador = new CheckedListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button2 = new Button();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label12 = new Label();
            button3 = new Button();
            label13 = new Label();
            textBox10 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(212, 175, 55);
            label1.ForeColor = Color.FromArgb(34, 34, 34);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(6, 4, 6, 4);
            label1.Size = new Size(77, 28);
            label1.TabIndex = 0;
            label1.Text = "Clientes ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(248, 246, 244);
            label2.ForeColor = Color.FromArgb(60, 60, 60);
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 1;
            label2.Text = "Buscar por ID, DUI o Telefono:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(226, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 27);
            textBox1.TabIndex = 2;
            // 
            // btn
            // 
            btn.BackColor = Color.FromArgb(212, 175, 55);
            btn.ForeColor = Color.FromArgb(34, 34, 34);
            btn.Location = new Point(504, 36);
            btn.Name = "btn";
            btn.Size = new Size(86, 28);
            btn.TabIndex = 3;
            btn.Text = "Buscar";
            btn.UseVisualStyleBackColor = false;
            btn.Click += button1_Click;
            // 
            // Administrador
            // 
            Administrador.BackColor = Color.FromArgb(248, 246, 244);
            Administrador.ForeColor = Color.FromArgb(80, 80, 80);
            Administrador.FormattingEnabled = true;
            Administrador.Items.AddRange(new object[] { "Administrador.", "Empleado" });
            Administrador.Location = new Point(608, 32);
            Administrador.Name = "Administrador";
            Administrador.Size = new Size(130, 48);
            Administrador.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 99, 71);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(625, 9);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 5;
            label3.Text = " Filtrar por rol:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(224, 247, 250);
            label4.ForeColor = Color.FromArgb(34, 34, 34);
            label4.Location = new Point(22, 156);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 6;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(241, 238, 255);
            label5.ForeColor = Color.FromArgb(34, 34, 34);
            label5.Location = new Point(22, 323);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 7;
            label5.Text = "id_rol";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(227, 247, 237);
            label6.ForeColor = Color.FromArgb(34, 34, 34);
            label6.Location = new Point(22, 278);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 8;
            label6.Text = "Correo";
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.BackColor = Color.FromArgb(223, 235, 255);
            txtNombre.ForeColor = Color.FromArgb(34, 34, 34);
            txtNombre.Location = new Point(22, 123);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(72, 20);
            txtNombre.TabIndex = 9;
            txtNombre.Text = "id_cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(224, 247, 250);
            label8.ForeColor = Color.FromArgb(34, 34, 34);
            label8.Location = new Point(22, 240);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 10;
            label8.Text = "Telefono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(255, 250, 205);
            label9.ForeColor = Color.FromArgb(34, 34, 34);
            label9.Location = new Point(22, 198);
            label9.Name = "label9";
            label9.Size = new Size(34, 20);
            label9.TabIndex = 11;
            label9.Text = "DUI";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(241, 238, 255);
            label10.ForeColor = Color.FromArgb(34, 34, 34);
            label10.Location = new Point(22, 365);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 12;
            label10.Text = "id_permiso";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(255, 240, 238);
            label11.ForeColor = Color.FromArgb(34, 34, 34);
            label11.Location = new Point(22, 409);
            label11.Name = "label11";
            label11.Size = new Size(73, 20);
            label11.TabIndex = 13;
            label11.Text = "id_estado";
            label11.Click += label11_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 27);
            textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(92, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(128, 27);
            textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(62, 195);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 27);
            textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(95, 237);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(147, 27);
            textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(79, 275);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(141, 27);
            textBox6.TabIndex = 18;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(212, 175, 55);
            button2.ForeColor = Color.FromArgb(34, 34, 34);
            button2.Location = new Point(464, 119);
            button2.Name = "button2";
            button2.Size = new Size(211, 29);
            button2.TabIndex = 19;
            button2.Text = "Agregar nuevo cliente";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(74, 320);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(138, 27);
            textBox7.TabIndex = 20;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(101, 406);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(138, 27);
            textBox8.TabIndex = 21;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(110, 362);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(138, 27);
            textBox9.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(248, 246, 244);
            label12.ForeColor = Color.FromArgb(100, 100, 100);
            label12.Location = new Point(12, 89);
            label12.Name = "label12";
            label12.Size = new Size(789, 20);
            label12.TabIndex = 23;
            label12.Text = "Para agregar un nuevo cliente porfavor haga click en \"limpiar\", llene los campos siguiente y presione \"agregar cliente\"";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(34, 34, 34);
            button3.ForeColor = Color.FromArgb(212, 175, 55);
            button3.Location = new Point(351, 119);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 24;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(248, 246, 244);
            label13.ForeColor = Color.FromArgb(80, 80, 80);
            label13.Location = new Point(306, 195);
            label13.Name = "label13";
            label13.Size = new Size(219, 20);
            label13.TabIndex = 25;
            label13.Text = "Eliminar por ID, DUI o Telefono:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(531, 191);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(259, 27);
            textBox10.TabIndex = 26;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 246, 244);
            ClientSize = new Size(800, 450);
            Controls.Add(textBox10);
            Controls.Add(label13);
            Controls.Add(button3);
            Controls.Add(label12);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Administrador);
            Controls.Add(btn);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button btn;
        private CheckedListBox Administrador;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label txtNombre;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button2;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label12;
        private Button button3;
        private Label label13;
        private TextBox textBox10;
    }
}