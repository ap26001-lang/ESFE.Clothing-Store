namespace ESFE.Clothing_Store.UI
{
    partial class tallas
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(26, 33);
            button1.Name = "button1";
            button1.Size = new Size(112, 31);
            button1.TabIndex = 0;
            button1.Text = "buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(50, 133);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 1;
            label1.Text = "id tallas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 192, 192);
            label2.Location = new Point(374, 133);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 2;
            label2.Text = "talla producto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(514, 130);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 31);
            textBox3.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Location = new Point(385, 33);
            button2.Name = "button2";
            button2.Size = new Size(112, 31);
            button2.TabIndex = 6;
            button2.Text = "cambiar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(548, 33);
            button3.Name = "button3";
            button3.Size = new Size(112, 31);
            button3.TabIndex = 7;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // tallas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "tallas";
            Text = "tallas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
    }
}