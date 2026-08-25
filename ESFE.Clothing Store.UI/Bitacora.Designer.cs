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
            tituloLblFrmBitacora = new Label();
            buscarUsuarioLblFrmBitacora = new Label();
            buscarUsuarioTxtFrmBitacora = new TextBox();
            buscarBtnFrmBitacora = new Button();
            limpiarBtnFrmBitacora = new Button();
            idActividadLblFrmBitacora = new Label();
            accionLblFrmBitacora = new Label();
            idUsuarioLblFrmBitacora = new Label();
            fechaHoraLblFrmBitacora = new Label();
            idActividadTxtFrmBitacora = new TextBox();
            accionTxtFrmBitacora = new TextBox();
            idUsuarioTxtFrmBitacora = new TextBox();
            fechaHoraTxtFrmBitacora = new TextBox();
            agregarBtnFrmBitacora = new Button();
            verListaBtnFrmBitacora = new Button();
            eliminarBtnFrmBitacora = new Button();
            SuspendLayout();
            // 
            // tituloLblFrmBitacora
            // 
            tituloLblFrmBitacora.AutoSize = true;
            tituloLblFrmBitacora.BackColor = Color.FromArgb(169, 132, 94);
            tituloLblFrmBitacora.ForeColor = SystemColors.Control;
            tituloLblFrmBitacora.Location = new Point(10, 7);
            tituloLblFrmBitacora.Margin = new Padding(3, 0, 3, 2);
            tituloLblFrmBitacora.Name = "tituloLblFrmBitacora";
            tituloLblFrmBitacora.Padding = new Padding(0, 0, 4, 2);
            tituloLblFrmBitacora.RightToLeft = RightToLeft.No;
            tituloLblFrmBitacora.Size = new Size(54, 17);
            tituloLblFrmBitacora.TabIndex = 0;
            tituloLblFrmBitacora.Text = "Bitacora";
            tituloLblFrmBitacora.Click += label1_Click_1;
            // 
            // buscarUsuarioLblFrmBitacora
            // 
            buscarUsuarioLblFrmBitacora.AutoSize = true;
            buscarUsuarioLblFrmBitacora.BackColor = Color.FromArgb(169, 132, 94);
            buscarUsuarioLblFrmBitacora.ForeColor = SystemColors.Control;
            buscarUsuarioLblFrmBitacora.Location = new Point(10, 31);
            buscarUsuarioLblFrmBitacora.Name = "buscarUsuarioLblFrmBitacora";
            buscarUsuarioLblFrmBitacora.Size = new Size(120, 15);
            buscarUsuarioLblFrmBitacora.TabIndex = 1;
            buscarUsuarioLblFrmBitacora.Text = "Buscar por ID Usuario";
            // 
            // buscarUsuarioTxtFrmBitacora
            // 
            buscarUsuarioTxtFrmBitacora.BackColor = Color.FromArgb(169, 132, 94);
            buscarUsuarioTxtFrmBitacora.ForeColor = SystemColors.Control;
            buscarUsuarioTxtFrmBitacora.Location = new Point(166, 28);
            buscarUsuarioTxtFrmBitacora.Margin = new Padding(3, 2, 3, 2);
            buscarUsuarioTxtFrmBitacora.Name = "buscarUsuarioTxtFrmBitacora";
            buscarUsuarioTxtFrmBitacora.Size = new Size(155, 23);
            buscarUsuarioTxtFrmBitacora.TabIndex = 2;
            // 
            // buscarBtnFrmBitacora
            // 
            buscarBtnFrmBitacora.BackColor = Color.FromArgb(169, 132, 94);
            buscarBtnFrmBitacora.ForeColor = SystemColors.Control;
            buscarBtnFrmBitacora.Location = new Point(326, 26);
            buscarBtnFrmBitacora.Margin = new Padding(3, 2, 3, 2);
            buscarBtnFrmBitacora.Name = "buscarBtnFrmBitacora";
            buscarBtnFrmBitacora.Size = new Size(66, 26);
            buscarBtnFrmBitacora.TabIndex = 3;
            buscarBtnFrmBitacora.Text = "Buscar";
            buscarBtnFrmBitacora.UseVisualStyleBackColor = false;
            buscarBtnFrmBitacora.Click += button1_Click;
            // 
            // limpiarBtnFrmBitacora
            // 
            limpiarBtnFrmBitacora.BackColor = Color.FromArgb(169, 132, 94);
            limpiarBtnFrmBitacora.ForeColor = SystemColors.Control;
            limpiarBtnFrmBitacora.Location = new Point(405, 26);
            limpiarBtnFrmBitacora.Margin = new Padding(3, 2, 3, 2);
            limpiarBtnFrmBitacora.Name = "limpiarBtnFrmBitacora";
            limpiarBtnFrmBitacora.Size = new Size(64, 26);
            limpiarBtnFrmBitacora.TabIndex = 4;
            limpiarBtnFrmBitacora.Text = "Limpiar";
            limpiarBtnFrmBitacora.UseVisualStyleBackColor = false;
            limpiarBtnFrmBitacora.Click += button2_Click;
            // 
            // idActividadLblFrmBitacora
            // 
            idActividadLblFrmBitacora.AutoSize = true;
            idActividadLblFrmBitacora.BackColor = Color.FromArgb(169, 132, 94);
            idActividadLblFrmBitacora.ForeColor = SystemColors.Control;
            idActividadLblFrmBitacora.Location = new Point(7, 88);
            idActividadLblFrmBitacora.Name = "idActividadLblFrmBitacora";
            idActividadLblFrmBitacora.Size = new Size(74, 15);
            idActividadLblFrmBitacora.TabIndex = 5;
            idActividadLblFrmBitacora.Text = "ID Actividad:";
            // 
            // accionLblFrmBitacora
            // 
            accionLblFrmBitacora.AutoSize = true;
            accionLblFrmBitacora.BackColor = Color.FromArgb(169, 132, 94);
            accionLblFrmBitacora.ForeColor = SystemColors.Control;
            accionLblFrmBitacora.Location = new Point(7, 131);
            accionLblFrmBitacora.Name = "accionLblFrmBitacora";
            accionLblFrmBitacora.Size = new Size(96, 15);
            accionLblFrmBitacora.TabIndex = 6;
            accionLblFrmBitacora.Text = "Accion realizada:";
            // 
            // idUsuarioLblFrmBitacora
            // 
            idUsuarioLblFrmBitacora.AutoSize = true;
            idUsuarioLblFrmBitacora.BackColor = Color.FromArgb(169, 132, 94);
            idUsuarioLblFrmBitacora.ForeColor = SystemColors.Control;
            idUsuarioLblFrmBitacora.Location = new Point(10, 181);
            idUsuarioLblFrmBitacora.Name = "idUsuarioLblFrmBitacora";
            idUsuarioLblFrmBitacora.Size = new Size(64, 15);
            idUsuarioLblFrmBitacora.TabIndex = 7;
            idUsuarioLblFrmBitacora.Text = "ID Usuario:";
            // 
            // fechaHoraLblFrmBitacora
            // 
            fechaHoraLblFrmBitacora.AutoSize = true;
            fechaHoraLblFrmBitacora.BackColor = Color.FromArgb(169, 132, 94);
            fechaHoraLblFrmBitacora.ForeColor = SystemColors.Control;
            fechaHoraLblFrmBitacora.Location = new Point(7, 226);
            fechaHoraLblFrmBitacora.Name = "fechaHoraLblFrmBitacora";
            fechaHoraLblFrmBitacora.Size = new Size(79, 15);
            fechaHoraLblFrmBitacora.TabIndex = 8;
            fechaHoraLblFrmBitacora.Text = "Fecha y Hora;";
            // 
            // idActividadTxtFrmBitacora
            // 
            idActividadTxtFrmBitacora.BackColor = Color.FromArgb(169, 132, 94);
            idActividadTxtFrmBitacora.ForeColor = SystemColors.Control;
            idActividadTxtFrmBitacora.Location = new Point(94, 88);
            idActividadTxtFrmBitacora.Margin = new Padding(3, 2, 3, 2);
            idActividadTxtFrmBitacora.Name = "idActividadTxtFrmBitacora";
            idActividadTxtFrmBitacora.Size = new Size(215, 23);
            idActividadTxtFrmBitacora.TabIndex = 9;
            // 
            // accionTxtFrmBitacora
            // 
            accionTxtFrmBitacora.BackColor = Color.FromArgb(169, 132, 94);
            accionTxtFrmBitacora.ForeColor = SystemColors.Control;
            accionTxtFrmBitacora.Location = new Point(119, 126);
            accionTxtFrmBitacora.Margin = new Padding(3, 2, 3, 2);
            accionTxtFrmBitacora.Name = "accionTxtFrmBitacora";
            accionTxtFrmBitacora.Size = new Size(307, 23);
            accionTxtFrmBitacora.TabIndex = 10;
            // 
            // idUsuarioTxtFrmBitacora
            // 
            idUsuarioTxtFrmBitacora.BackColor = Color.FromArgb(169, 132, 94);
            idUsuarioTxtFrmBitacora.ForeColor = SystemColors.Control;
            idUsuarioTxtFrmBitacora.Location = new Point(87, 178);
            idUsuarioTxtFrmBitacora.Margin = new Padding(3, 2, 3, 2);
            idUsuarioTxtFrmBitacora.Name = "idUsuarioTxtFrmBitacora";
            idUsuarioTxtFrmBitacora.Size = new Size(209, 23);
            idUsuarioTxtFrmBitacora.TabIndex = 11;
            idUsuarioTxtFrmBitacora.TextChanged += textBox4_TextChanged;
            // 
            // fechaHoraTxtFrmBitacora
            // 
            fechaHoraTxtFrmBitacora.BackColor = Color.FromArgb(169, 132, 94);
            fechaHoraTxtFrmBitacora.ForeColor = SystemColors.Control;
            fechaHoraTxtFrmBitacora.Location = new Point(98, 224);
            fechaHoraTxtFrmBitacora.Margin = new Padding(3, 2, 3, 2);
            fechaHoraTxtFrmBitacora.Name = "fechaHoraTxtFrmBitacora";
            fechaHoraTxtFrmBitacora.Size = new Size(165, 23);
            fechaHoraTxtFrmBitacora.TabIndex = 12;
            // 
            // agregarBtnFrmBitacora
            // 
            agregarBtnFrmBitacora.BackColor = Color.FromArgb(169, 132, 94);
            agregarBtnFrmBitacora.ForeColor = SystemColors.Control;
            agregarBtnFrmBitacora.Location = new Point(7, 270);
            agregarBtnFrmBitacora.Margin = new Padding(3, 2, 3, 2);
            agregarBtnFrmBitacora.Name = "agregarBtnFrmBitacora";
            agregarBtnFrmBitacora.Size = new Size(136, 25);
            agregarBtnFrmBitacora.TabIndex = 13;
            agregarBtnFrmBitacora.Text = "Agregar Registro";
            agregarBtnFrmBitacora.UseVisualStyleBackColor = false;
            agregarBtnFrmBitacora.Click += button3_Click;
            // 
            // verListaBtnFrmBitacora
            // 
            verListaBtnFrmBitacora.BackColor = Color.FromArgb(169, 132, 94);
            verListaBtnFrmBitacora.ForeColor = SystemColors.Control;
            verListaBtnFrmBitacora.Location = new Point(159, 271);
            verListaBtnFrmBitacora.Margin = new Padding(3, 2, 3, 2);
            verListaBtnFrmBitacora.Name = "verListaBtnFrmBitacora";
            verListaBtnFrmBitacora.Size = new Size(162, 25);
            verListaBtnFrmBitacora.TabIndex = 14;
            verListaBtnFrmBitacora.Text = "Ver lista (Admin)";
            verListaBtnFrmBitacora.UseVisualStyleBackColor = false;
            verListaBtnFrmBitacora.Click += button4_Click;
            // 
            // eliminarBtnFrmBitacora
            // 
            eliminarBtnFrmBitacora.BackColor = Color.FromArgb(169, 132, 94);
            eliminarBtnFrmBitacora.ForeColor = SystemColors.Control;
            eliminarBtnFrmBitacora.Location = new Point(347, 270);
            eliminarBtnFrmBitacora.Margin = new Padding(3, 2, 3, 2);
            eliminarBtnFrmBitacora.Name = "eliminarBtnFrmBitacora";
            eliminarBtnFrmBitacora.Size = new Size(122, 26);
            eliminarBtnFrmBitacora.TabIndex = 15;
            eliminarBtnFrmBitacora.Text = "Eliminar Registro";
            eliminarBtnFrmBitacora.UseVisualStyleBackColor = false;
            eliminarBtnFrmBitacora.Click += button5_Click;
            // 
            // Bitacora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 245, 240);
            ClientSize = new Size(710, 338);
            Controls.Add(eliminarBtnFrmBitacora);
            Controls.Add(verListaBtnFrmBitacora);
            Controls.Add(agregarBtnFrmBitacora);
            Controls.Add(fechaHoraTxtFrmBitacora);
            Controls.Add(idUsuarioTxtFrmBitacora);
            Controls.Add(accionTxtFrmBitacora);
            Controls.Add(idActividadTxtFrmBitacora);
            Controls.Add(fechaHoraLblFrmBitacora);
            Controls.Add(idUsuarioLblFrmBitacora);
            Controls.Add(accionLblFrmBitacora);
            Controls.Add(idActividadLblFrmBitacora);
            Controls.Add(limpiarBtnFrmBitacora);
            Controls.Add(buscarBtnFrmBitacora);
            Controls.Add(buscarUsuarioTxtFrmBitacora);
            Controls.Add(buscarUsuarioLblFrmBitacora);
            Controls.Add(tituloLblFrmBitacora);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Bitacora";
            Text = "Bitacora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloLblFrmBitacora;
        private Label buscarUsuarioLblFrmBitacora;
        private TextBox buscarUsuarioTxtFrmBitacora;
        private Button buscarBtnFrmBitacora;
        private Button limpiarBtnFrmBitacora;
        private Label idActividadLblFrmBitacora;
        private Label accionLblFrmBitacora;
        private Label idUsuarioLblFrmBitacora;
        private Label fechaHoraLblFrmBitacora;
        private TextBox idActividadTxtFrmBitacora;
        private TextBox accionTxtFrmBitacora;
        private TextBox idUsuarioTxtFrmBitacora;
        private TextBox fechaHoraTxtFrmBitacora;
        private Button agregarBtnFrmBitacora;
        private Button verListaBtnFrmBitacora;
        private Button eliminarBtnFrmBitacora;
    }
}