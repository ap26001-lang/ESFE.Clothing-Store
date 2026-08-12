using Color = System.Drawing.Color;

namespace ESFE.Clothing_Store.UI
{
    partial class Bitacora
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
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            // Cabecera minimalista en color carbón con acento dorado (lujo)
            label1.BackColor = Color.FromArgb(34, 34, 34);
            label1.ForeColor = Color.FromArgb(212, 175, 55);
            label1.Location = new Point(12, 9);
            label1.Margin = new Padding(3, 0, 3, 2);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 5, 3);
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(69, 23);
            label1.TabIndex = 0;
            label1.Text = "Bitacora";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            // Texto de guía en tono neutro sobre fondo del formulario
            label2.BackColor = Color.FromArgb(248, 246, 244);
            label2.ForeColor = Color.FromArgb(68, 68, 68);
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 1;
            label2.Text = "Buscar por ID Usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            // Botón Buscar en un estilo sobrio: fondo carbón y texto dorado
            button1.BackColor = Color.FromArgb(34, 34, 34);
            button1.Location = new Point(373, 34);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.ForeColor = Color.FromArgb(212, 175, 55);
            button1.ForeColor = SystemColors.ButtonHighlight;
            // 
            // button2
            // 
            // Acción secundaria con fondo claro y texto oscuro
            button2.BackColor = Color.FromArgb(245, 245, 245);
            button2.ForeColor = Color.FromArgb(68, 68, 68);
            button2.Location = new Point(463, 35);
            button2.Name = "button2";
            button2.Size = new Size(73, 34);
            button2.TabIndex = 4;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            // Etiquetas en fondo muy claro y texto gris oscuro (minimalista)
            label3.BackColor = Color.FromArgb(248, 246, 244);
            label3.ForeColor = Color.FromArgb(80, 80, 80);
            label3.Location = new Point(8, 117);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 5;
            label3.Text = "ID Actividad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(248, 246, 244);
            label4.ForeColor = Color.FromArgb(80, 80, 80);
            label4.Location = new Point(8, 175);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 6;
            label4.Text = "Accion realizada:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(248, 246, 244);
            label5.ForeColor = Color.FromArgb(80, 80, 80);
            label5.Location = new Point(12, 241);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 7;
            label5.Text = "ID Usuario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(248, 246, 244);
            label6.ForeColor = Color.FromArgb(80, 80, 80);
            label6.Location = new Point(8, 302);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 8;
            label6.Text = "Fecha y Hora;";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 168);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(350, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(99, 238);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(238, 27);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(112, 299);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(188, 27);
            textBox5.TabIndex = 12;
            // 
            // button3
            // 
            // Botón Agregar Registro en dorado (acento de lujo)
            button3.BackColor = Color.FromArgb(212, 175, 55);
            button3.ForeColor = Color.FromArgb(34, 34, 34);
            button3.Location = new Point(8, 360);
            button3.Name = "button3";
            button3.Size = new Size(156, 33);
            button3.TabIndex = 13;
            button3.Text = "Agregar Registro";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            // Botón de ver lista en carbón con texto dorado
            button4.BackColor = Color.FromArgb(34, 34, 34);
            button4.ForeColor = Color.FromArgb(212, 175, 55);
            button4.Location = new Point(182, 361);
            button4.Name = "button4";
            button4.Size = new Size(185, 33);
            button4.TabIndex = 14;
            button4.Text = "Ver lista (Admin)";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            // Botón eliminar con tono rojo apagado para mantener sobriedad
            button5.BackColor = Color.FromArgb(128, 34, 34);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(397, 360);
            button5.Name = "button5";
            button5.Size = new Size(139, 34);
            button5.TabIndex = 15;
            button5.Text = "Eliminar Registro";
            button5.UseVisualStyleBackColor = false;
            // 
            // Bitacora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            // Fondo neutro y luminoso para resaltar prendas y controles
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(812, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bitacora";
            Text = "Bitacora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}