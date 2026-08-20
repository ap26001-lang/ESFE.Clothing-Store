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
            tituloLblFrmClientes = new Label();
            buscarLblFrmClientes = new Label();
            buscarTxtFrmClientes = new TextBox();
            buscarBtnFrmClientes = new Button();
            rolClbFrmClientes = new CheckedListBox();
            filtrarRolLblFrmClientes = new Label();
            nombreLblFrmClientes = new Label();
            idRolLblFrmClientes = new Label();
            correoLblFrmClientes = new Label();
            idClienteLblFrmClientes = new Label();
            telefonoLblFrmClientes = new Label();
            duiLblFrmClientes = new Label();
            idPermisoLblFrmClientes = new Label();
            idEstadoLblFrmClientes = new Label();
            idClienteTxtFrmClientes = new TextBox();
            nombreTxtFrmClientes = new TextBox();
            duiTxtFrmClientes = new TextBox();
            telefonoTxtFrmClientes = new TextBox();
            correoTxtFrmClientes = new TextBox();
            agregarBtnFrmClientes = new Button();
            idRolTxtFrmClientes = new TextBox();
            idEstadoTxtFrmClientes = new TextBox();
            idPermisoTxtFrmClientes = new TextBox();
            instruccionesLblFrmClientes = new Label();
            limpiarBtnFrmClientes = new Button();
            eliminarLblFrmClientes = new Label();
            eliminarTxtFrmClientes = new TextBox();
            eliminarBtnFrmClientes = new Button();
            SuspendLayout();
            // 
            // tituloLblFrmClientes
            // 
            tituloLblFrmClientes.AutoSize = true;
            tituloLblFrmClientes.BackColor = Color.FromArgb(212, 175, 55);
            tituloLblFrmClientes.ForeColor = Color.FromArgb(34, 34, 34);
            tituloLblFrmClientes.Location = new Point(12, 9);
            tituloLblFrmClientes.Name = "tituloLblFrmClientes";
            tituloLblFrmClientes.Padding = new Padding(6, 4, 6, 4);
            tituloLblFrmClientes.Size = new Size(77, 28);
            tituloLblFrmClientes.TabIndex = 0;
            tituloLblFrmClientes.Text = "Clientes ";
            // 
            // buscarLblFrmClientes
            // 
            buscarLblFrmClientes.AutoSize = true;
            buscarLblFrmClientes.BackColor = Color.FromArgb(248, 246, 244);
            buscarLblFrmClientes.ForeColor = Color.FromArgb(60, 60, 60);
            buscarLblFrmClientes.Location = new Point(12, 40);
            buscarLblFrmClientes.Name = "buscarLblFrmClientes";
            buscarLblFrmClientes.Size = new Size(208, 20);
            buscarLblFrmClientes.TabIndex = 1;
            buscarLblFrmClientes.Text = "Buscar por ID, DUI o Telefono:";
            // 
            // buscarTxtFrmClientes
            // 
            buscarTxtFrmClientes.Location = new Point(226, 36);
            buscarTxtFrmClientes.Name = "buscarTxtFrmClientes";
            buscarTxtFrmClientes.Size = new Size(259, 27);
            buscarTxtFrmClientes.TabIndex = 2;
            // 
            // buscarBtnFrmClientes
            // 
            buscarBtnFrmClientes.BackColor = Color.FromArgb(212, 175, 55);
            buscarBtnFrmClientes.ForeColor = Color.FromArgb(34, 34, 34);
            buscarBtnFrmClientes.Location = new Point(504, 36);
            buscarBtnFrmClientes.Name = "buscarBtnFrmClientes";
            buscarBtnFrmClientes.Size = new Size(86, 28);
            buscarBtnFrmClientes.TabIndex = 3;
            buscarBtnFrmClientes.Text = "Buscar";
            buscarBtnFrmClientes.UseVisualStyleBackColor = false;
            buscarBtnFrmClientes.Click += button1_Click;
            // 
            // rolClbFrmClientes
            // 
            rolClbFrmClientes.BackColor = Color.FromArgb(248, 246, 244);
            rolClbFrmClientes.ForeColor = Color.FromArgb(80, 80, 80);
            rolClbFrmClientes.FormattingEnabled = true;
            rolClbFrmClientes.Items.AddRange(new object[] { "Administrador.", "Empleado" });
            rolClbFrmClientes.Location = new Point(608, 32);
            rolClbFrmClientes.Name = "rolClbFrmClientes";
            rolClbFrmClientes.Size = new Size(130, 48);
            rolClbFrmClientes.TabIndex = 4;
            // 
            // filtrarRolLblFrmClientes
            // 
            filtrarRolLblFrmClientes.AutoSize = true;
            filtrarRolLblFrmClientes.BackColor = Color.FromArgb(255, 99, 71);
            filtrarRolLblFrmClientes.ForeColor = SystemColors.ButtonHighlight;
            filtrarRolLblFrmClientes.Location = new Point(625, 9);
            filtrarRolLblFrmClientes.Name = "filtrarRolLblFrmClientes";
            filtrarRolLblFrmClientes.Size = new Size(103, 20);
            filtrarRolLblFrmClientes.TabIndex = 5;
            filtrarRolLblFrmClientes.Text = " Filtrar por rol:";
            // 
            // nombreLblFrmClientes
            // 
            nombreLblFrmClientes.AutoSize = true;
            nombreLblFrmClientes.BackColor = Color.FromArgb(224, 247, 250);
            nombreLblFrmClientes.ForeColor = Color.FromArgb(34, 34, 34);
            nombreLblFrmClientes.Location = new Point(22, 156);
            nombreLblFrmClientes.Name = "nombreLblFrmClientes";
            nombreLblFrmClientes.Size = new Size(64, 20);
            nombreLblFrmClientes.TabIndex = 6;
            nombreLblFrmClientes.Text = "Nombre";
            // 
            // idRolLblFrmClientes
            // 
            idRolLblFrmClientes.AutoSize = true;
            idRolLblFrmClientes.BackColor = Color.FromArgb(241, 238, 255);
            idRolLblFrmClientes.ForeColor = Color.FromArgb(34, 34, 34);
            idRolLblFrmClientes.Location = new Point(22, 323);
            idRolLblFrmClientes.Name = "idRolLblFrmClientes";
            idRolLblFrmClientes.Size = new Size(46, 20);
            idRolLblFrmClientes.TabIndex = 7;
            idRolLblFrmClientes.Text = "id_rol";
            // 
            // correoLblFrmClientes
            // 
            correoLblFrmClientes.AutoSize = true;
            correoLblFrmClientes.BackColor = Color.FromArgb(227, 247, 237);
            correoLblFrmClientes.ForeColor = Color.FromArgb(34, 34, 34);
            correoLblFrmClientes.Location = new Point(22, 278);
            correoLblFrmClientes.Name = "correoLblFrmClientes";
            correoLblFrmClientes.Size = new Size(54, 20);
            correoLblFrmClientes.TabIndex = 8;
            correoLblFrmClientes.Text = "Correo";
            // 
            // idClienteLblFrmClientes
            // 
            idClienteLblFrmClientes.AutoSize = true;
            idClienteLblFrmClientes.BackColor = Color.FromArgb(223, 235, 255);
            idClienteLblFrmClientes.ForeColor = Color.FromArgb(34, 34, 34);
            idClienteLblFrmClientes.Location = new Point(22, 123);
            idClienteLblFrmClientes.Name = "idClienteLblFrmClientes";
            idClienteLblFrmClientes.Size = new Size(72, 20);
            idClienteLblFrmClientes.TabIndex = 9;
            idClienteLblFrmClientes.Text = "id_cliente";
            // 
            // telefonoLblFrmClientes
            // 
            telefonoLblFrmClientes.AutoSize = true;
            telefonoLblFrmClientes.BackColor = Color.FromArgb(224, 247, 250);
            telefonoLblFrmClientes.ForeColor = Color.FromArgb(34, 34, 34);
            telefonoLblFrmClientes.Location = new Point(22, 240);
            telefonoLblFrmClientes.Name = "telefonoLblFrmClientes";
            telefonoLblFrmClientes.Size = new Size(67, 20);
            telefonoLblFrmClientes.TabIndex = 10;
            telefonoLblFrmClientes.Text = "Telefono";
            // 
            // duiLblFrmClientes
            // 
            duiLblFrmClientes.AutoSize = true;
            duiLblFrmClientes.BackColor = Color.FromArgb(255, 250, 205);
            duiLblFrmClientes.ForeColor = Color.FromArgb(34, 34, 34);
            duiLblFrmClientes.Location = new Point(22, 198);
            duiLblFrmClientes.Name = "duiLblFrmClientes";
            duiLblFrmClientes.Size = new Size(34, 20);
            duiLblFrmClientes.TabIndex = 11;
            duiLblFrmClientes.Text = "DUI";
            // 
            // idPermisoLblFrmClientes
            // 
            idPermisoLblFrmClientes.AutoSize = true;
            idPermisoLblFrmClientes.BackColor = Color.FromArgb(241, 238, 255);
            idPermisoLblFrmClientes.ForeColor = Color.FromArgb(34, 34, 34);
            idPermisoLblFrmClientes.Location = new Point(22, 365);
            idPermisoLblFrmClientes.Name = "idPermisoLblFrmClientes";
            idPermisoLblFrmClientes.Size = new Size(82, 20);
            idPermisoLblFrmClientes.TabIndex = 12;
            idPermisoLblFrmClientes.Text = "id_permiso";
            // 
            // idEstadoLblFrmClientes
            // 
            idEstadoLblFrmClientes.AutoSize = true;
            idEstadoLblFrmClientes.BackColor = Color.FromArgb(255, 240, 238);
            idEstadoLblFrmClientes.ForeColor = Color.FromArgb(34, 34, 34);
            idEstadoLblFrmClientes.Location = new Point(22, 409);
            idEstadoLblFrmClientes.Name = "idEstadoLblFrmClientes";
            idEstadoLblFrmClientes.Size = new Size(73, 20);
            idEstadoLblFrmClientes.TabIndex = 13;
            idEstadoLblFrmClientes.Text = "id_estado";
            idEstadoLblFrmClientes.Click += label11_Click;
            // 
            // idClienteTxtFrmClientes
            // 
            idClienteTxtFrmClientes.Location = new Point(110, 116);
            idClienteTxtFrmClientes.Name = "idClienteTxtFrmClientes";
            idClienteTxtFrmClientes.Size = new Size(120, 27);
            idClienteTxtFrmClientes.TabIndex = 14;
            // 
            // nombreTxtFrmClientes
            // 
            nombreTxtFrmClientes.Location = new Point(92, 153);
            nombreTxtFrmClientes.Name = "nombreTxtFrmClientes";
            nombreTxtFrmClientes.Size = new Size(128, 27);
            nombreTxtFrmClientes.TabIndex = 15;
            // 
            // duiTxtFrmClientes
            // 
            duiTxtFrmClientes.Location = new Point(62, 195);
            duiTxtFrmClientes.Name = "duiTxtFrmClientes";
            duiTxtFrmClientes.Size = new Size(150, 27);
            duiTxtFrmClientes.TabIndex = 16;
            // 
            // telefonoTxtFrmClientes
            // 
            telefonoTxtFrmClientes.Location = new Point(95, 237);
            telefonoTxtFrmClientes.Name = "telefonoTxtFrmClientes";
            telefonoTxtFrmClientes.Size = new Size(147, 27);
            telefonoTxtFrmClientes.TabIndex = 17;
            // 
            // correoTxtFrmClientes
            // 
            correoTxtFrmClientes.Location = new Point(79, 275);
            correoTxtFrmClientes.Name = "correoTxtFrmClientes";
            correoTxtFrmClientes.Size = new Size(141, 27);
            correoTxtFrmClientes.TabIndex = 18;
            // 
            // agregarBtnFrmClientes
            // 
            agregarBtnFrmClientes.BackColor = Color.FromArgb(212, 175, 55);
            agregarBtnFrmClientes.ForeColor = Color.FromArgb(34, 34, 34);
            agregarBtnFrmClientes.Location = new Point(464, 119);
            agregarBtnFrmClientes.Name = "agregarBtnFrmClientes";
            agregarBtnFrmClientes.Size = new Size(211, 29);
            agregarBtnFrmClientes.TabIndex = 19;
            agregarBtnFrmClientes.Text = "Agregar nuevo cliente";
            agregarBtnFrmClientes.UseVisualStyleBackColor = false;
            agregarBtnFrmClientes.Click += button2_Click;
            // 
            // idRolTxtFrmClientes
            // 
            idRolTxtFrmClientes.Location = new Point(74, 320);
            idRolTxtFrmClientes.Name = "idRolTxtFrmClientes";
            idRolTxtFrmClientes.Size = new Size(138, 27);
            idRolTxtFrmClientes.TabIndex = 20;
            // 
            // idEstadoTxtFrmClientes
            // 
            idEstadoTxtFrmClientes.Location = new Point(101, 406);
            idEstadoTxtFrmClientes.Name = "idEstadoTxtFrmClientes";
            idEstadoTxtFrmClientes.Size = new Size(138, 27);
            idEstadoTxtFrmClientes.TabIndex = 21;
            // 
            // idPermisoTxtFrmClientes
            // 
            idPermisoTxtFrmClientes.Location = new Point(110, 362);
            idPermisoTxtFrmClientes.Name = "idPermisoTxtFrmClientes";
            idPermisoTxtFrmClientes.Size = new Size(138, 27);
            idPermisoTxtFrmClientes.TabIndex = 22;
            // 
            // instruccionesLblFrmClientes
            // 
            instruccionesLblFrmClientes.AutoSize = true;
            instruccionesLblFrmClientes.BackColor = Color.FromArgb(248, 246, 244);
            instruccionesLblFrmClientes.ForeColor = Color.FromArgb(100, 100, 100);
            instruccionesLblFrmClientes.Location = new Point(12, 89);
            instruccionesLblFrmClientes.Name = "instruccionesLblFrmClientes";
            instruccionesLblFrmClientes.Size = new Size(789, 20);
            instruccionesLblFrmClientes.TabIndex = 23;
            instruccionesLblFrmClientes.Text = "Para agregar un nuevo cliente porfavor haga click en \"limpiar\", llene los campos siguiente y presione \"agregar cliente\"";
            // 
            // limpiarBtnFrmClientes
            // 
            limpiarBtnFrmClientes.BackColor = Color.FromArgb(34, 34, 34);
            limpiarBtnFrmClientes.ForeColor = Color.FromArgb(212, 175, 55);
            limpiarBtnFrmClientes.Location = new Point(351, 119);
            limpiarBtnFrmClientes.Name = "limpiarBtnFrmClientes";
            limpiarBtnFrmClientes.Size = new Size(94, 29);
            limpiarBtnFrmClientes.TabIndex = 24;
            limpiarBtnFrmClientes.Text = "Limpiar";
            limpiarBtnFrmClientes.UseVisualStyleBackColor = false;
            limpiarBtnFrmClientes.Click += button3_Click;
            // 
            // eliminarLblFrmClientes
            // 
            eliminarLblFrmClientes.AutoSize = true;
            eliminarLblFrmClientes.BackColor = Color.FromArgb(248, 246, 244);
            eliminarLblFrmClientes.ForeColor = Color.FromArgb(80, 80, 80);
            eliminarLblFrmClientes.Location = new Point(306, 195);
            eliminarLblFrmClientes.Name = "eliminarLblFrmClientes";
            eliminarLblFrmClientes.Size = new Size(219, 20);
            eliminarLblFrmClientes.TabIndex = 25;
            eliminarLblFrmClientes.Text = "Eliminar por ID, DUI o Telefono:";
            // 
            // eliminarTxtFrmClientes
            // 
            eliminarTxtFrmClientes.Location = new Point(531, 191);
            eliminarTxtFrmClientes.Name = "eliminarTxtFrmClientes";
            eliminarTxtFrmClientes.Size = new Size(259, 27);
            eliminarTxtFrmClientes.TabIndex = 26;
            // 
            // eliminarBtnFrmClientes
            // 
            eliminarBtnFrmClientes.Location = new Point(586, 240);
            eliminarBtnFrmClientes.Name = "eliminarBtnFrmClientes";
            eliminarBtnFrmClientes.Size = new Size(122, 39);
            eliminarBtnFrmClientes.TabIndex = 27;
            eliminarBtnFrmClientes.Text = "Eliminar";
            eliminarBtnFrmClientes.UseVisualStyleBackColor = true;
            eliminarBtnFrmClientes.Click += button1_Click_1;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 246, 244);
            ClientSize = new Size(800, 450);
            Controls.Add(eliminarBtnFrmClientes);
            Controls.Add(eliminarTxtFrmClientes);
            Controls.Add(eliminarLblFrmClientes);
            Controls.Add(limpiarBtnFrmClientes);
            Controls.Add(instruccionesLblFrmClientes);
            Controls.Add(idPermisoTxtFrmClientes);
            Controls.Add(idEstadoTxtFrmClientes);
            Controls.Add(idRolTxtFrmClientes);
            Controls.Add(agregarBtnFrmClientes);
            Controls.Add(correoTxtFrmClientes);
            Controls.Add(telefonoTxtFrmClientes);
            Controls.Add(duiTxtFrmClientes);
            Controls.Add(nombreTxtFrmClientes);
            Controls.Add(idClienteTxtFrmClientes);
            Controls.Add(idEstadoLblFrmClientes);
            Controls.Add(idPermisoLblFrmClientes);
            Controls.Add(duiLblFrmClientes);
            Controls.Add(telefonoLblFrmClientes);
            Controls.Add(idClienteLblFrmClientes);
            Controls.Add(correoLblFrmClientes);
            Controls.Add(idRolLblFrmClientes);
            Controls.Add(nombreLblFrmClientes);
            Controls.Add(filtrarRolLblFrmClientes);
            Controls.Add(rolClbFrmClientes);
            Controls.Add(buscarBtnFrmClientes);
            Controls.Add(buscarTxtFrmClientes);
            Controls.Add(buscarLblFrmClientes);
            Controls.Add(tituloLblFrmClientes);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloLblFrmClientes;
        private Label buscarLblFrmClientes;
        private TextBox buscarTxtFrmClientes;
        private Button buscarBtnFrmClientes;
        private CheckedListBox rolClbFrmClientes;
        private Label filtrarRolLblFrmClientes;
        private Label nombreLblFrmClientes;
        private Label idRolLblFrmClientes;
        private Label correoLblFrmClientes;
        private Label idClienteLblFrmClientes;
        private Label telefonoLblFrmClientes;
        private Label duiLblFrmClientes;
        private Label idPermisoLblFrmClientes;
        private Label idEstadoLblFrmClientes;
        private TextBox idClienteTxtFrmClientes;
        private TextBox nombreTxtFrmClientes;
        private TextBox duiTxtFrmClientes;
        private TextBox telefonoTxtFrmClientes;
        private TextBox correoTxtFrmClientes;
        private Button agregarBtnFrmClientes;
        private TextBox idRolTxtFrmClientes;
        private TextBox idEstadoTxtFrmClientes;
        private TextBox idPermisoTxtFrmClientes;
        private Label instruccionesLblFrmClientes;
        private Button limpiarBtnFrmClientes;
        private Label eliminarLblFrmClientes;
        private TextBox eliminarTxtFrmClientes;
        private Button eliminarBtnFrmClientes;
    }
}