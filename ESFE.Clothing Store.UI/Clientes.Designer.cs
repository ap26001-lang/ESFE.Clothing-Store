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
            tituloLblFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            tituloLblFrmClientes.ForeColor = SystemColors.Control;
            tituloLblFrmClientes.Location = new Point(10, 7);
            tituloLblFrmClientes.Name = "tituloLblFrmClientes";
            tituloLblFrmClientes.Padding = new Padding(5, 3, 5, 3);
            tituloLblFrmClientes.Size = new Size(62, 21);
            tituloLblFrmClientes.TabIndex = 0;
            tituloLblFrmClientes.Text = "Clientes ";
            // 
            // buscarLblFrmClientes
            // 
            buscarLblFrmClientes.AutoSize = true;
            buscarLblFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            buscarLblFrmClientes.ForeColor = SystemColors.Control;
            buscarLblFrmClientes.Location = new Point(10, 30);
            buscarLblFrmClientes.Name = "buscarLblFrmClientes";
            buscarLblFrmClientes.Size = new Size(164, 15);
            buscarLblFrmClientes.TabIndex = 1;
            buscarLblFrmClientes.Text = "Buscar por ID, DUI o Telefono:";
            // 
            // buscarTxtFrmClientes
            // 
            buscarTxtFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            buscarTxtFrmClientes.ForeColor = SystemColors.Control;
            buscarTxtFrmClientes.Location = new Point(198, 27);
            buscarTxtFrmClientes.Margin = new Padding(3, 2, 3, 2);
            buscarTxtFrmClientes.Name = "buscarTxtFrmClientes";
            buscarTxtFrmClientes.Size = new Size(227, 23);
            buscarTxtFrmClientes.TabIndex = 2;
            // 
            // buscarBtnFrmClientes
            // 
            buscarBtnFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            buscarBtnFrmClientes.ForeColor = SystemColors.Control;
            buscarBtnFrmClientes.Location = new Point(441, 27);
            buscarBtnFrmClientes.Margin = new Padding(3, 2, 3, 2);
            buscarBtnFrmClientes.Name = "buscarBtnFrmClientes";
            buscarBtnFrmClientes.Size = new Size(75, 21);
            buscarBtnFrmClientes.TabIndex = 3;
            buscarBtnFrmClientes.Text = "Buscar";
            buscarBtnFrmClientes.UseVisualStyleBackColor = false;
            buscarBtnFrmClientes.Click += button1_Click;
            // 
            // rolClbFrmClientes
            // 
            rolClbFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            rolClbFrmClientes.ForeColor = SystemColors.Control;
            rolClbFrmClientes.FormattingEnabled = true;
            rolClbFrmClientes.Items.AddRange(new object[] { "Administrador.", "Empleado" });
            rolClbFrmClientes.Location = new Point(547, 23);
            rolClbFrmClientes.Margin = new Padding(3, 2, 3, 2);
            rolClbFrmClientes.Name = "rolClbFrmClientes";
            rolClbFrmClientes.Size = new Size(114, 22);
            rolClbFrmClientes.TabIndex = 4;
            // 
            // filtrarRolLblFrmClientes
            // 
            filtrarRolLblFrmClientes.AutoSize = true;
            filtrarRolLblFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            filtrarRolLblFrmClientes.ForeColor = SystemColors.Control;
            filtrarRolLblFrmClientes.Location = new Point(547, 7);
            filtrarRolLblFrmClientes.Name = "filtrarRolLblFrmClientes";
            filtrarRolLblFrmClientes.Size = new Size(81, 15);
            filtrarRolLblFrmClientes.TabIndex = 5;
            filtrarRolLblFrmClientes.Text = " Filtrar por rol:";
            // 
            // nombreLblFrmClientes
            // 
            nombreLblFrmClientes.AutoSize = true;
            nombreLblFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            nombreLblFrmClientes.ForeColor = SystemColors.Control;
            nombreLblFrmClientes.Location = new Point(19, 117);
            nombreLblFrmClientes.Name = "nombreLblFrmClientes";
            nombreLblFrmClientes.Size = new Size(51, 15);
            nombreLblFrmClientes.TabIndex = 6;
            nombreLblFrmClientes.Text = "Nombre";
            // 
            // idRolLblFrmClientes
            // 
            idRolLblFrmClientes.AutoSize = true;
            idRolLblFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            idRolLblFrmClientes.ForeColor = SystemColors.Control;
            idRolLblFrmClientes.Location = new Point(19, 242);
            idRolLblFrmClientes.Name = "idRolLblFrmClientes";
            idRolLblFrmClientes.Size = new Size(36, 15);
            idRolLblFrmClientes.TabIndex = 7;
            idRolLblFrmClientes.Text = "id_rol";
            // 
            // correoLblFrmClientes
            // 
            correoLblFrmClientes.AutoSize = true;
            correoLblFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            correoLblFrmClientes.ForeColor = SystemColors.Control;
            correoLblFrmClientes.Location = new Point(19, 208);
            correoLblFrmClientes.Name = "correoLblFrmClientes";
            correoLblFrmClientes.Size = new Size(43, 15);
            correoLblFrmClientes.TabIndex = 8;
            correoLblFrmClientes.Text = "Correo";
            // 
            // idClienteLblFrmClientes
            // 
            idClienteLblFrmClientes.AutoSize = true;
            idClienteLblFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            idClienteLblFrmClientes.ForeColor = SystemColors.Control;
            idClienteLblFrmClientes.Location = new Point(19, 92);
            idClienteLblFrmClientes.Name = "idClienteLblFrmClientes";
            idClienteLblFrmClientes.Size = new Size(57, 15);
            idClienteLblFrmClientes.TabIndex = 9;
            idClienteLblFrmClientes.Text = "id_cliente";
            // 
            // telefonoLblFrmClientes
            // 
            telefonoLblFrmClientes.AutoSize = true;
            telefonoLblFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            telefonoLblFrmClientes.ForeColor = SystemColors.Control;
            telefonoLblFrmClientes.Location = new Point(19, 180);
            telefonoLblFrmClientes.Name = "telefonoLblFrmClientes";
            telefonoLblFrmClientes.Size = new Size(53, 15);
            telefonoLblFrmClientes.TabIndex = 10;
            telefonoLblFrmClientes.Text = "Telefono";
            // 
            // duiLblFrmClientes
            // 
            duiLblFrmClientes.AutoSize = true;
            duiLblFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            duiLblFrmClientes.ForeColor = SystemColors.Control;
            duiLblFrmClientes.Location = new Point(19, 148);
            duiLblFrmClientes.Name = "duiLblFrmClientes";
            duiLblFrmClientes.Size = new Size(26, 15);
            duiLblFrmClientes.TabIndex = 11;
            duiLblFrmClientes.Text = "DUI";
            // 
            // idPermisoLblFrmClientes
            // 
            idPermisoLblFrmClientes.AutoSize = true;
            idPermisoLblFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            idPermisoLblFrmClientes.ForeColor = SystemColors.Control;
            idPermisoLblFrmClientes.Location = new Point(19, 274);
            idPermisoLblFrmClientes.Name = "idPermisoLblFrmClientes";
            idPermisoLblFrmClientes.Size = new Size(65, 15);
            idPermisoLblFrmClientes.TabIndex = 12;
            idPermisoLblFrmClientes.Text = "id_permiso";
            // 
            // idEstadoLblFrmClientes
            // 
            idEstadoLblFrmClientes.AutoSize = true;
            idEstadoLblFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            idEstadoLblFrmClientes.ForeColor = SystemColors.Control;
            idEstadoLblFrmClientes.Location = new Point(19, 307);
            idEstadoLblFrmClientes.Name = "idEstadoLblFrmClientes";
            idEstadoLblFrmClientes.Size = new Size(57, 15);
            idEstadoLblFrmClientes.TabIndex = 13;
            idEstadoLblFrmClientes.Text = "id_estado";
            idEstadoLblFrmClientes.Click += label11_Click;
            // 
            // idClienteTxtFrmClientes
            // 
            idClienteTxtFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            idClienteTxtFrmClientes.ForeColor = SystemColors.Control;
            idClienteTxtFrmClientes.Location = new Point(96, 87);
            idClienteTxtFrmClientes.Margin = new Padding(3, 2, 3, 2);
            idClienteTxtFrmClientes.Name = "idClienteTxtFrmClientes";
            idClienteTxtFrmClientes.Size = new Size(106, 23);
            idClienteTxtFrmClientes.TabIndex = 14;
            // 
            // nombreTxtFrmClientes
            // 
            nombreTxtFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            nombreTxtFrmClientes.ForeColor = SystemColors.Control;
            nombreTxtFrmClientes.Location = new Point(96, 117);
            nombreTxtFrmClientes.Margin = new Padding(3, 2, 3, 2);
            nombreTxtFrmClientes.Name = "nombreTxtFrmClientes";
            nombreTxtFrmClientes.Size = new Size(112, 23);
            nombreTxtFrmClientes.TabIndex = 15;
            // 
            // duiTxtFrmClientes
            // 
            duiTxtFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            duiTxtFrmClientes.ForeColor = SystemColors.Control;
            duiTxtFrmClientes.Location = new Point(96, 146);
            duiTxtFrmClientes.Margin = new Padding(3, 2, 3, 2);
            duiTxtFrmClientes.Name = "duiTxtFrmClientes";
            duiTxtFrmClientes.Size = new Size(132, 23);
            duiTxtFrmClientes.TabIndex = 16;
            // 
            // telefonoTxtFrmClientes
            // 
            telefonoTxtFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            telefonoTxtFrmClientes.ForeColor = SystemColors.Control;
            telefonoTxtFrmClientes.Location = new Point(96, 173);
            telefonoTxtFrmClientes.Margin = new Padding(3, 2, 3, 2);
            telefonoTxtFrmClientes.Name = "telefonoTxtFrmClientes";
            telefonoTxtFrmClientes.Size = new Size(129, 23);
            telefonoTxtFrmClientes.TabIndex = 17;
            // 
            // correoTxtFrmClientes
            // 
            correoTxtFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            correoTxtFrmClientes.ForeColor = SystemColors.Control;
            correoTxtFrmClientes.Location = new Point(96, 239);
            correoTxtFrmClientes.Margin = new Padding(3, 2, 3, 2);
            correoTxtFrmClientes.Name = "correoTxtFrmClientes";
            correoTxtFrmClientes.Size = new Size(124, 23);
            correoTxtFrmClientes.TabIndex = 18;
            // 
            // agregarBtnFrmClientes
            // 
            agregarBtnFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            agregarBtnFrmClientes.ForeColor = SystemColors.Control;
            agregarBtnFrmClientes.Location = new Point(406, 89);
            agregarBtnFrmClientes.Margin = new Padding(3, 2, 3, 2);
            agregarBtnFrmClientes.Name = "agregarBtnFrmClientes";
            agregarBtnFrmClientes.Size = new Size(185, 22);
            agregarBtnFrmClientes.TabIndex = 19;
            agregarBtnFrmClientes.Text = "Agregar nuevo cliente";
            agregarBtnFrmClientes.UseVisualStyleBackColor = false;
            agregarBtnFrmClientes.Click += button2_Click;
            // 
            // idRolTxtFrmClientes
            // 
            idRolTxtFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            idRolTxtFrmClientes.ForeColor = SystemColors.Control;
            idRolTxtFrmClientes.Location = new Point(96, 205);
            idRolTxtFrmClientes.Margin = new Padding(3, 2, 3, 2);
            idRolTxtFrmClientes.Name = "idRolTxtFrmClientes";
            idRolTxtFrmClientes.Size = new Size(121, 23);
            idRolTxtFrmClientes.TabIndex = 20;
            // 
            // idEstadoTxtFrmClientes
            // 
            idEstadoTxtFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            idEstadoTxtFrmClientes.ForeColor = SystemColors.Control;
            idEstadoTxtFrmClientes.Location = new Point(96, 299);
            idEstadoTxtFrmClientes.Margin = new Padding(3, 2, 3, 2);
            idEstadoTxtFrmClientes.Name = "idEstadoTxtFrmClientes";
            idEstadoTxtFrmClientes.Size = new Size(121, 23);
            idEstadoTxtFrmClientes.TabIndex = 21;
            // 
            // idPermisoTxtFrmClientes
            // 
            idPermisoTxtFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            idPermisoTxtFrmClientes.ForeColor = SystemColors.Control;
            idPermisoTxtFrmClientes.Location = new Point(96, 266);
            idPermisoTxtFrmClientes.Margin = new Padding(3, 2, 3, 2);
            idPermisoTxtFrmClientes.Name = "idPermisoTxtFrmClientes";
            idPermisoTxtFrmClientes.Size = new Size(121, 23);
            idPermisoTxtFrmClientes.TabIndex = 22;
            // 
            // instruccionesLblFrmClientes
            // 
            instruccionesLblFrmClientes.AutoSize = true;
            instruccionesLblFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            instruccionesLblFrmClientes.ForeColor = SystemColors.Control;
            instruccionesLblFrmClientes.Location = new Point(10, 67);
            instruccionesLblFrmClientes.Name = "instruccionesLblFrmClientes";
            instruccionesLblFrmClientes.Size = new Size(627, 15);
            instruccionesLblFrmClientes.TabIndex = 23;
            instruccionesLblFrmClientes.Text = "Para agregar un nuevo cliente porfavor haga click en \"limpiar\", llene los campos siguiente y presione \"agregar cliente\"";
            // 
            // limpiarBtnFrmClientes
            // 
            limpiarBtnFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            limpiarBtnFrmClientes.ForeColor = SystemColors.Control;
            limpiarBtnFrmClientes.Location = new Point(307, 89);
            limpiarBtnFrmClientes.Margin = new Padding(3, 2, 3, 2);
            limpiarBtnFrmClientes.Name = "limpiarBtnFrmClientes";
            limpiarBtnFrmClientes.Size = new Size(82, 22);
            limpiarBtnFrmClientes.TabIndex = 24;
            limpiarBtnFrmClientes.Text = "Limpiar";
            limpiarBtnFrmClientes.UseVisualStyleBackColor = false;
            limpiarBtnFrmClientes.Click += button3_Click;
            // 
            // eliminarLblFrmClientes
            // 
            eliminarLblFrmClientes.AutoSize = true;
            eliminarLblFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            eliminarLblFrmClientes.ForeColor = SystemColors.Control;
            eliminarLblFrmClientes.Location = new Point(253, 180);
            eliminarLblFrmClientes.Name = "eliminarLblFrmClientes";
            eliminarLblFrmClientes.Size = new Size(172, 15);
            eliminarLblFrmClientes.TabIndex = 25;
            eliminarLblFrmClientes.Text = "Eliminar por ID, DUI o Telefono:";
            // 
            // eliminarTxtFrmClientes
            // 
            eliminarTxtFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            eliminarTxtFrmClientes.ForeColor = SystemColors.Control;
            eliminarTxtFrmClientes.Location = new Point(441, 173);
            eliminarTxtFrmClientes.Margin = new Padding(3, 2, 3, 2);
            eliminarTxtFrmClientes.Name = "eliminarTxtFrmClientes";
            eliminarTxtFrmClientes.Size = new Size(227, 23);
            eliminarTxtFrmClientes.TabIndex = 26;
            // 
            // eliminarBtnFrmClientes
            // 
            eliminarBtnFrmClientes.BackColor = Color.FromArgb(169, 132, 94);
            eliminarBtnFrmClientes.ForeColor = SystemColors.Control;
            eliminarBtnFrmClientes.Location = new Point(561, 251);
            eliminarBtnFrmClientes.Margin = new Padding(3, 2, 3, 2);
            eliminarBtnFrmClientes.Name = "eliminarBtnFrmClientes";
            eliminarBtnFrmClientes.Size = new Size(107, 29);
            eliminarBtnFrmClientes.TabIndex = 27;
            eliminarBtnFrmClientes.Text = "Eliminar";
            eliminarBtnFrmClientes.UseVisualStyleBackColor = false;
            eliminarBtnFrmClientes.Click += button1_Click_1;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 245, 240);
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
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