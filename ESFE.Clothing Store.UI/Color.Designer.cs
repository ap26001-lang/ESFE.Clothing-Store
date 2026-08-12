namespace ESFE.Clothing_Store.UI
{
    partial class ColorForm
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Chocolate;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Olive;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(205, 20);
            label2.TabIndex = 1;
            label2.Text = "Buscar color por nombre o ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Yellow;
            button1.Location = new Point(417, 41);
            button1.Name = "button1";
            button1.Size = new Size(130, 27);
            button1.TabIndex = 3;
            button1.Text = "Buscar color";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Salmon;
            button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            button2.Location = new Point(12, 77);
            button2.Name = "button2";
            button2.Size = new Size(128, 30);
            button2.TabIndex = 4;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Turquoise;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "id_color";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Turquoise;
            label4.Location = new Point(12, 215);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 6;
            label4.Text = "Color";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(79, 212);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(159, 27);
            textBox3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Red;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 288);
            label5.Name = "label5";
            label5.Size = new Size(325, 20);
            label5.TabIndex = 9;
            label5.Text = "Eliminar color por nombre o ID (Administrador)";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(353, 285);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(159, 27);
            textBox4.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.Red;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(530, 285);
            button3.Name = "button3";
            button3.Size = new Size(130, 27);
            button3.TabIndex = 11;
            button3.Text = "Eliminar color";
            button3.UseVisualStyleBackColor = false;
            // 
            // Color
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Color";
            Text = "Color";
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
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Button button3;
    }
}