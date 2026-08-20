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
            tituloLblFrmColor = new Label();
            buscarLblFrmColor = new Label();
            buscarTxtFrmColor = new TextBox();
            buscarBtnFrmColor = new Button();
            limpiarBtnFrmColor = new Button();
            idColorLblFrmColor = new Label();
            colorLblFrmColor = new Label();
            idColorTxtFrmColor = new TextBox();
            colorTxtFrmColor = new TextBox();
            eliminarLblFrmColor = new Label();
            eliminarTxtFrmColor = new TextBox();
            eliminarBtnFrmColor = new Button();
            guardarBtnFrmColor = new Button();
            SuspendLayout();
            // 
            // tituloLblFrmColor
            // 
            tituloLblFrmColor.AutoSize = true;
            tituloLblFrmColor.BackColor = System.Drawing.Color.FromArgb(255, 99, 71);
            tituloLblFrmColor.ForeColor = System.Drawing.Color.WhiteSmoke;
            tituloLblFrmColor.Location = new Point(12, 9);
            tituloLblFrmColor.Name = "tituloLblFrmColor";
            tituloLblFrmColor.Size = new Size(45, 20);
            tituloLblFrmColor.TabIndex = 0;
            tituloLblFrmColor.Text = "Color";
            // 
            // buscarLblFrmColor
            // 
            buscarLblFrmColor.AutoSize = true;
            buscarLblFrmColor.BackColor = System.Drawing.Color.FromArgb(0, 128, 128);
            buscarLblFrmColor.ForeColor = System.Drawing.Color.WhiteSmoke;
            buscarLblFrmColor.Location = new Point(12, 44);
            buscarLblFrmColor.Name = "buscarLblFrmColor";
            buscarLblFrmColor.Size = new Size(205, 20);
            buscarLblFrmColor.TabIndex = 1;
            buscarLblFrmColor.Text = "Buscar color por nombre o ID";
            // 
            // buscarTxtFrmColor
            // 
            buscarTxtFrmColor.Location = new Point(232, 41);
            buscarTxtFrmColor.Name = "buscarTxtFrmColor";
            buscarTxtFrmColor.Size = new Size(159, 27);
            buscarTxtFrmColor.TabIndex = 2;
            // 
            // buscarBtnFrmColor
            // 
            buscarBtnFrmColor.BackColor = System.Drawing.Color.FromArgb(255, 99, 71);
            buscarBtnFrmColor.ForeColor = System.Drawing.Color.WhiteSmoke;
            buscarBtnFrmColor.Location = new Point(417, 41);
            buscarBtnFrmColor.Name = "buscarBtnFrmColor";
            buscarBtnFrmColor.Size = new Size(130, 27);
            buscarBtnFrmColor.TabIndex = 3;
            buscarBtnFrmColor.Text = "Buscar color";
            buscarBtnFrmColor.UseVisualStyleBackColor = false;
            buscarBtnFrmColor.Click += button1_Click;
            // 
            // limpiarBtnFrmColor
            // 
            limpiarBtnFrmColor.BackColor = System.Drawing.Color.FromArgb(102, 153, 204);
            limpiarBtnFrmColor.ForeColor = System.Drawing.Color.WhiteSmoke;
            limpiarBtnFrmColor.Location = new Point(12, 77);
            limpiarBtnFrmColor.Name = "limpiarBtnFrmColor";
            limpiarBtnFrmColor.Size = new Size(128, 30);
            limpiarBtnFrmColor.TabIndex = 4;
            limpiarBtnFrmColor.Text = "Limpiar";
            limpiarBtnFrmColor.UseVisualStyleBackColor = false;
            limpiarBtnFrmColor.Click += button2_Click;
            // 
            // idColorLblFrmColor
            // 
            idColorLblFrmColor.AutoSize = true;
            idColorLblFrmColor.BackColor = System.Drawing.Color.FromArgb(224, 247, 250);
            idColorLblFrmColor.ForeColor = System.Drawing.Color.FromArgb(34, 34, 34);
            idColorLblFrmColor.Location = new Point(12, 140);
            idColorLblFrmColor.Name = "idColorLblFrmColor";
            idColorLblFrmColor.Size = new Size(62, 20);
            idColorLblFrmColor.TabIndex = 5;
            idColorLblFrmColor.Text = "id_color";
            // 
            // colorLblFrmColor
            // 
            colorLblFrmColor.AutoSize = true;
            colorLblFrmColor.BackColor = System.Drawing.Color.FromArgb(224, 247, 250);
            colorLblFrmColor.ForeColor = System.Drawing.Color.FromArgb(34, 34, 34);
            colorLblFrmColor.Location = new Point(12, 215);
            colorLblFrmColor.Name = "colorLblFrmColor";
            colorLblFrmColor.Size = new Size(45, 20);
            colorLblFrmColor.TabIndex = 6;
            colorLblFrmColor.Text = "Color";
            // 
            // idColorTxtFrmColor
            // 
            idColorTxtFrmColor.Location = new Point(93, 137);
            idColorTxtFrmColor.Name = "idColorTxtFrmColor";
            idColorTxtFrmColor.Size = new Size(159, 27);
            idColorTxtFrmColor.TabIndex = 7;
            // 
            // colorTxtFrmColor
            // 
            colorTxtFrmColor.Location = new Point(79, 212);
            colorTxtFrmColor.Name = "colorTxtFrmColor";
            colorTxtFrmColor.Size = new Size(159, 27);
            colorTxtFrmColor.TabIndex = 8;
            // 
            // eliminarLblFrmColor
            // 
            eliminarLblFrmColor.AutoSize = true;
            eliminarLblFrmColor.BackColor = System.Drawing.Color.Red;
            eliminarLblFrmColor.ForeColor = SystemColors.ControlLightLight;
            eliminarLblFrmColor.Location = new Point(12, 288);
            eliminarLblFrmColor.Name = "eliminarLblFrmColor";
            eliminarLblFrmColor.Size = new Size(325, 20);
            eliminarLblFrmColor.TabIndex = 9;
            eliminarLblFrmColor.Text = "Eliminar color por nombre o ID (Administrador)";
            // 
            // eliminarTxtFrmColor
            // 
            eliminarTxtFrmColor.Location = new Point(353, 285);
            eliminarTxtFrmColor.Name = "eliminarTxtFrmColor";
            eliminarTxtFrmColor.Size = new Size(159, 27);
            eliminarTxtFrmColor.TabIndex = 10;
            // 
            // eliminarBtnFrmColor
            // 
            eliminarBtnFrmColor.BackColor = System.Drawing.Color.Red;
            eliminarBtnFrmColor.ForeColor = SystemColors.ButtonHighlight;
            eliminarBtnFrmColor.Location = new Point(530, 285);
            eliminarBtnFrmColor.Name = "eliminarBtnFrmColor";
            eliminarBtnFrmColor.Size = new Size(130, 27);
            eliminarBtnFrmColor.TabIndex = 11;
            eliminarBtnFrmColor.Text = "Eliminar color";
            eliminarBtnFrmColor.UseVisualStyleBackColor = false;
            eliminarBtnFrmColor.Click += button3_Click;
            // 
            // guardarBtnFrmColor
            // 
            guardarBtnFrmColor.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
            guardarBtnFrmColor.ForeColor = System.Drawing.Color.WhiteSmoke;
            guardarBtnFrmColor.Location = new Point(265, 212);
            guardarBtnFrmColor.Name = "guardarBtnFrmColor";
            guardarBtnFrmColor.Size = new Size(128, 30);
            guardarBtnFrmColor.TabIndex = 12;
            guardarBtnFrmColor.Text = "Guardar / Modificar";
            guardarBtnFrmColor.UseVisualStyleBackColor = false;
            guardarBtnFrmColor.Click += button4_Click;
            // 
            // Color
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            // Fondo neutro y luminoso para resaltar los colores de la paleta
            BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            ClientSize = new Size(800, 450);
            Controls.Add(guardarBtnFrmColor);
            Controls.Add(eliminarBtnFrmColor);
            Controls.Add(eliminarTxtFrmColor);
            Controls.Add(eliminarLblFrmColor);
            Controls.Add(colorTxtFrmColor);
            Controls.Add(idColorTxtFrmColor);
            Controls.Add(colorLblFrmColor);
            Controls.Add(idColorLblFrmColor);
            Controls.Add(limpiarBtnFrmColor);
            Controls.Add(buscarBtnFrmColor);
            Controls.Add(buscarTxtFrmColor);
            Controls.Add(buscarLblFrmColor);
            Controls.Add(tituloLblFrmColor);
            Name = "Color";
            Text = "Color";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloLblFrmColor;
        private Label buscarLblFrmColor;
        private TextBox buscarTxtFrmColor;
        private Button buscarBtnFrmColor;
        private Button limpiarBtnFrmColor;
        private Label idColorLblFrmColor;
        private Label colorLblFrmColor;
        private TextBox idColorTxtFrmColor;
        private TextBox colorTxtFrmColor;
        private Label eliminarLblFrmColor;
        private TextBox eliminarTxtFrmColor;
        private Button eliminarBtnFrmColor;
        private Button guardarBtnFrmColor;
    }
}