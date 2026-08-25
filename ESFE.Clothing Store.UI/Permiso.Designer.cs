namespace ESFE.Clothing_Store.UI
{
    partial class Permiso
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            buscarLbl = new Label();
            buscarTxtFrmPermiso = new TextBox();
            buscarBtnFrmPermiso = new Button();
            idLbl = new Label();
            idPermisoTxtFrmPermiso = new TextBox();
            nivelLbl = new Label();
            nivelPermisoTxtFrmPermiso = new TextBox();
            agregarBtnFrmPermiso = new Button();
            guardarBtnFrmPermiso = new Button();
            eliminarBtnFrmPermiso = new Button();
            limpiarBtnFrmPermiso = new Button();
            SuspendLayout();
            // 
            // buscarLbl
            // 
            buscarLbl.AutoSize = true;
            buscarLbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buscarLbl.ForeColor = Color.FromArgb(120, 81, 51);
            buscarLbl.Location = new Point(20, 20);
            buscarLbl.Name = "buscarLbl";
            buscarLbl.Size = new Size(103, 19);
            buscarLbl.TabIndex = 0;
            buscarLbl.Text = "Buscar por ID:";
            // 
            // buscarTxtFrmPermiso
            // 
            buscarTxtFrmPermiso.BackColor = Color.FromArgb(255, 250, 245);
            buscarTxtFrmPermiso.ForeColor = Color.FromArgb(80, 60, 40);
            buscarTxtFrmPermiso.Location = new Point(20, 45);
            buscarTxtFrmPermiso.Name = "buscarTxtFrmPermiso";
            buscarTxtFrmPermiso.Size = new Size(290, 23);
            buscarTxtFrmPermiso.TabIndex = 1;
            // 
            // buscarBtnFrmPermiso
            // 
            buscarBtnFrmPermiso.BackColor = Color.FromArgb(169, 132, 94);
            buscarBtnFrmPermiso.Cursor = Cursors.Hand;
            buscarBtnFrmPermiso.FlatAppearance.BorderSize = 0;
            buscarBtnFrmPermiso.FlatStyle = FlatStyle.Flat;
            buscarBtnFrmPermiso.ForeColor = Color.FromArgb(255, 245, 230);
            buscarBtnFrmPermiso.Location = new Point(320, 45);
            buscarBtnFrmPermiso.Name = "buscarBtnFrmPermiso";
            buscarBtnFrmPermiso.Size = new Size(160, 23);
            buscarBtnFrmPermiso.TabIndex = 2;
            buscarBtnFrmPermiso.Text = "Buscar";
            buscarBtnFrmPermiso.UseVisualStyleBackColor = false;
            buscarBtnFrmPermiso.Click += buscarBtnFrmPermiso_Click;
            // 
            // idLbl
            // 
            idLbl.AutoSize = true;
            idLbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            idLbl.ForeColor = Color.FromArgb(120, 81, 51);
            idLbl.Location = new Point(20, 90);
            idLbl.Name = "idLbl";
            idLbl.Size = new Size(86, 19);
            idLbl.TabIndex = 3;
            idLbl.Text = "ID Permiso:";
            // 
            // idPermisoTxtFrmPermiso
            // 
            idPermisoTxtFrmPermiso.BackColor = Color.FromArgb(255, 250, 245);
            idPermisoTxtFrmPermiso.ForeColor = Color.FromArgb(80, 60, 40);
            idPermisoTxtFrmPermiso.Location = new Point(20, 112);
            idPermisoTxtFrmPermiso.Name = "idPermisoTxtFrmPermiso";
            idPermisoTxtFrmPermiso.Size = new Size(460, 23);
            idPermisoTxtFrmPermiso.TabIndex = 4;
            // 
            // nivelLbl
            // 
            nivelLbl.AutoSize = true;
            nivelLbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            nivelLbl.ForeColor = Color.FromArgb(120, 81, 51);
            nivelLbl.Location = new Point(20, 160);
            nivelLbl.Name = "nivelLbl";
            nivelLbl.Size = new Size(107, 19);
            nivelLbl.TabIndex = 5;
            nivelLbl.Text = "Nivel Permiso:";
            // 
            // nivelPermisoTxtFrmPermiso
            // 
            nivelPermisoTxtFrmPermiso.BackColor = Color.FromArgb(255, 250, 245);
            nivelPermisoTxtFrmPermiso.ForeColor = Color.FromArgb(80, 60, 40);
            nivelPermisoTxtFrmPermiso.Location = new Point(20, 185);
            nivelPermisoTxtFrmPermiso.Name = "nivelPermisoTxtFrmPermiso";
            nivelPermisoTxtFrmPermiso.Size = new Size(460, 23);
            nivelPermisoTxtFrmPermiso.TabIndex = 6;
            // 
            // agregarBtnFrmPermiso
            // 
            agregarBtnFrmPermiso.BackColor = Color.FromArgb(140, 100, 60);
            agregarBtnFrmPermiso.Cursor = Cursors.Hand;
            agregarBtnFrmPermiso.FlatAppearance.BorderSize = 0;
            agregarBtnFrmPermiso.FlatStyle = FlatStyle.Flat;
            agregarBtnFrmPermiso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            agregarBtnFrmPermiso.ForeColor = Color.FromArgb(255, 245, 230);
            agregarBtnFrmPermiso.Location = new Point(20, 240);
            agregarBtnFrmPermiso.Name = "agregarBtnFrmPermiso";
            agregarBtnFrmPermiso.Size = new Size(100, 35);
            agregarBtnFrmPermiso.TabIndex = 7;
            agregarBtnFrmPermiso.Text = "Agregar";
            agregarBtnFrmPermiso.UseVisualStyleBackColor = false;
            agregarBtnFrmPermiso.Click += agregarBtnFrmPermiso_Click;
            // 
            // guardarBtnFrmPermiso
            // 
            guardarBtnFrmPermiso.BackColor = Color.FromArgb(160, 120, 80);
            guardarBtnFrmPermiso.Cursor = Cursors.Hand;
            guardarBtnFrmPermiso.FlatAppearance.BorderSize = 0;
            guardarBtnFrmPermiso.FlatStyle = FlatStyle.Flat;
            guardarBtnFrmPermiso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guardarBtnFrmPermiso.ForeColor = Color.FromArgb(255, 245, 230);
            guardarBtnFrmPermiso.Location = new Point(130, 240);
            guardarBtnFrmPermiso.Name = "guardarBtnFrmPermiso";
            guardarBtnFrmPermiso.Size = new Size(100, 35);
            guardarBtnFrmPermiso.TabIndex = 8;
            guardarBtnFrmPermiso.Text = "Guardar";
            guardarBtnFrmPermiso.UseVisualStyleBackColor = false;
            guardarBtnFrmPermiso.Click += guardarBtnFrmPermiso_Click;
            // 
            // eliminarBtnFrmPermiso
            // 
            eliminarBtnFrmPermiso.BackColor = Color.FromArgb(130, 90, 50);
            eliminarBtnFrmPermiso.Cursor = Cursors.Hand;
            eliminarBtnFrmPermiso.FlatAppearance.BorderSize = 0;
            eliminarBtnFrmPermiso.FlatStyle = FlatStyle.Flat;
            eliminarBtnFrmPermiso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            eliminarBtnFrmPermiso.ForeColor = Color.FromArgb(255, 245, 230);
            eliminarBtnFrmPermiso.Location = new Point(240, 240);
            eliminarBtnFrmPermiso.Name = "eliminarBtnFrmPermiso";
            eliminarBtnFrmPermiso.Size = new Size(100, 35);
            eliminarBtnFrmPermiso.TabIndex = 9;
            eliminarBtnFrmPermiso.Text = "Eliminar";
            eliminarBtnFrmPermiso.UseVisualStyleBackColor = false;
            eliminarBtnFrmPermiso.Click += eliminarBtnFrmPermiso_Click;
            // 
            // limpiarBtnFrmPermiso
            // 
            limpiarBtnFrmPermiso.BackColor = Color.FromArgb(195, 155, 110);
            limpiarBtnFrmPermiso.Cursor = Cursors.Hand;
            limpiarBtnFrmPermiso.FlatAppearance.BorderSize = 0;
            limpiarBtnFrmPermiso.FlatStyle = FlatStyle.Flat;
            limpiarBtnFrmPermiso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            limpiarBtnFrmPermiso.ForeColor = Color.FromArgb(80, 60, 40);
            limpiarBtnFrmPermiso.Location = new Point(350, 240);
            limpiarBtnFrmPermiso.Name = "limpiarBtnFrmPermiso";
            limpiarBtnFrmPermiso.Size = new Size(130, 35);
            limpiarBtnFrmPermiso.TabIndex = 10;
            limpiarBtnFrmPermiso.Text = "Limpiar";
            limpiarBtnFrmPermiso.UseVisualStyleBackColor = false;
            limpiarBtnFrmPermiso.Click += limpiarBtnFrmPermiso_Click;
            // 
            // Permiso
            // 
            BackColor = Color.FromArgb(250, 245, 240);
            ClientSize = new Size(500, 400);
            Controls.Add(buscarLbl);
            Controls.Add(buscarTxtFrmPermiso);
            Controls.Add(buscarBtnFrmPermiso);
            Controls.Add(idLbl);
            Controls.Add(idPermisoTxtFrmPermiso);
            Controls.Add(nivelLbl);
            Controls.Add(nivelPermisoTxtFrmPermiso);
            Controls.Add(agregarBtnFrmPermiso);
            Controls.Add(guardarBtnFrmPermiso);
            Controls.Add(eliminarBtnFrmPermiso);
            Controls.Add(limpiarBtnFrmPermiso);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Permiso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permiso - ESFE Clothing Store";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox buscarTxtFrmPermiso;
        private System.Windows.Forms.Button buscarBtnFrmPermiso;
        private System.Windows.Forms.TextBox idPermisoTxtFrmPermiso;
        private System.Windows.Forms.TextBox nivelPermisoTxtFrmPermiso;
        private System.Windows.Forms.Button agregarBtnFrmPermiso;
        private System.Windows.Forms.Button guardarBtnFrmPermiso;
        private System.Windows.Forms.Button eliminarBtnFrmPermiso;
        private System.Windows.Forms.Button limpiarBtnFrmPermiso;
        private Label buscarLbl;
        private Label idLbl;
        private Label nivelLbl;
    }
}
