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
            components = new System.ComponentModel.Container();
            this.Text = "Permiso - ESFE Clothing Store";
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(250, 245, 240); // Crema muy claro

            // Label y TextBox para buscar
            System.Windows.Forms.Label buscarLbl = new System.Windows.Forms.Label();
            buscarLbl.Text = "Buscar por ID:";
            buscarLbl.Location = new System.Drawing.Point(20, 20);
            buscarLbl.AutoSize = true;
            buscarLbl.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            buscarLbl.ForeColor = System.Drawing.Color.FromArgb(120, 81, 51); // Café oscuro
            this.Controls.Add(buscarLbl);

            buscarTxtFrmPermiso = new System.Windows.Forms.TextBox();
            buscarTxtFrmPermiso.Location = new System.Drawing.Point(20, 45);
            buscarTxtFrmPermiso.Size = new System.Drawing.Size(290, 23);
            buscarTxtFrmPermiso.BackColor = System.Drawing.Color.FromArgb(255, 250, 245);
            buscarTxtFrmPermiso.ForeColor = System.Drawing.Color.FromArgb(80, 60, 40);
            this.Controls.Add(buscarTxtFrmPermiso);

            buscarBtnFrmPermiso = new System.Windows.Forms.Button();
            buscarBtnFrmPermiso.Text = "Buscar";
            buscarBtnFrmPermiso.Location = new System.Drawing.Point(320, 45);
            buscarBtnFrmPermiso.Size = new System.Drawing.Size(160, 23);
            buscarBtnFrmPermiso.BackColor = System.Drawing.Color.FromArgb(169, 132, 94); // Café
            buscarBtnFrmPermiso.ForeColor = System.Drawing.Color.FromArgb(255, 245, 230);
            buscarBtnFrmPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buscarBtnFrmPermiso.FlatAppearance.BorderSize = 0;
            buscarBtnFrmPermiso.Cursor = System.Windows.Forms.Cursors.Hand;
            buscarBtnFrmPermiso.Click += buscarBtnFrmPermiso_Click;
            this.Controls.Add(buscarBtnFrmPermiso);

            // Label y TextBox para ID Permiso
            System.Windows.Forms.Label idLbl = new System.Windows.Forms.Label();
            idLbl.Text = "ID Permiso:";
            idLbl.Location = new System.Drawing.Point(20, 90);
            idLbl.AutoSize = true;
            idLbl.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            idLbl.ForeColor = System.Drawing.Color.FromArgb(120, 81, 51);
            this.Controls.Add(idLbl);

            idPermisoTxtFrmPermiso = new System.Windows.Forms.TextBox();
            idPermisoTxtFrmPermiso.Location = new System.Drawing.Point(20, 115);
            idPermisoTxtFrmPermiso.Size = new System.Drawing.Size(460, 23);
            idPermisoTxtFrmPermiso.BackColor = System.Drawing.Color.FromArgb(255, 250, 245);
            idPermisoTxtFrmPermiso.ForeColor = System.Drawing.Color.FromArgb(80, 60, 40);
            this.Controls.Add(idPermisoTxtFrmPermiso);

            // Label y TextBox para Nivel Permiso
            System.Windows.Forms.Label nivelLbl = new System.Windows.Forms.Label();
            nivelLbl.Text = "Nivel Permiso:";
            nivelLbl.Location = new System.Drawing.Point(20, 160);
            nivelLbl.AutoSize = true;
            nivelLbl.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            nivelLbl.ForeColor = System.Drawing.Color.FromArgb(120, 81, 51);
            this.Controls.Add(nivelLbl);

            nivelPermisoTxtFrmPermiso = new System.Windows.Forms.TextBox();
            nivelPermisoTxtFrmPermiso.Location = new System.Drawing.Point(20, 185);
            nivelPermisoTxtFrmPermiso.Size = new System.Drawing.Size(460, 23);
            nivelPermisoTxtFrmPermiso.BackColor = System.Drawing.Color.FromArgb(255, 250, 245);
            nivelPermisoTxtFrmPermiso.ForeColor = System.Drawing.Color.FromArgb(80, 60, 40);
            this.Controls.Add(nivelPermisoTxtFrmPermiso);

            // Botones
            agregarBtnFrmPermiso = new System.Windows.Forms.Button();
            agregarBtnFrmPermiso.Text = "Agregar";
            agregarBtnFrmPermiso.Location = new System.Drawing.Point(20, 240);
            agregarBtnFrmPermiso.Size = new System.Drawing.Size(100, 35);
            agregarBtnFrmPermiso.BackColor = System.Drawing.Color.FromArgb(140, 100, 60); // Café oscuro
            agregarBtnFrmPermiso.ForeColor = System.Drawing.Color.FromArgb(255, 245, 230);
            agregarBtnFrmPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            agregarBtnFrmPermiso.FlatAppearance.BorderSize = 0;
            agregarBtnFrmPermiso.Cursor = System.Windows.Forms.Cursors.Hand;
            agregarBtnFrmPermiso.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            agregarBtnFrmPermiso.Click += agregarBtnFrmPermiso_Click;
            this.Controls.Add(agregarBtnFrmPermiso);

            guardarBtnFrmPermiso = new System.Windows.Forms.Button();
            guardarBtnFrmPermiso.Text = "Guardar";
            guardarBtnFrmPermiso.Location = new System.Drawing.Point(130, 240);
            guardarBtnFrmPermiso.Size = new System.Drawing.Size(100, 35);
            guardarBtnFrmPermiso.BackColor = System.Drawing.Color.FromArgb(160, 120, 80); // Café medio
            guardarBtnFrmPermiso.ForeColor = System.Drawing.Color.FromArgb(255, 245, 230);
            guardarBtnFrmPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            guardarBtnFrmPermiso.FlatAppearance.BorderSize = 0;
            guardarBtnFrmPermiso.Cursor = System.Windows.Forms.Cursors.Hand;
            guardarBtnFrmPermiso.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            guardarBtnFrmPermiso.Click += guardarBtnFrmPermiso_Click;
            this.Controls.Add(guardarBtnFrmPermiso);

            eliminarBtnFrmPermiso = new System.Windows.Forms.Button();
            eliminarBtnFrmPermiso.Text = "Eliminar";
            eliminarBtnFrmPermiso.Location = new System.Drawing.Point(240, 240);
            eliminarBtnFrmPermiso.Size = new System.Drawing.Size(100, 35);
            eliminarBtnFrmPermiso.BackColor = System.Drawing.Color.FromArgb(130, 90, 50); // Café muy oscuro
            eliminarBtnFrmPermiso.ForeColor = System.Drawing.Color.FromArgb(255, 245, 230);
            eliminarBtnFrmPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            eliminarBtnFrmPermiso.FlatAppearance.BorderSize = 0;
            eliminarBtnFrmPermiso.Cursor = System.Windows.Forms.Cursors.Hand;
            eliminarBtnFrmPermiso.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            eliminarBtnFrmPermiso.Click += eliminarBtnFrmPermiso_Click;
            this.Controls.Add(eliminarBtnFrmPermiso);

            limpiarBtnFrmPermiso = new System.Windows.Forms.Button();
            limpiarBtnFrmPermiso.Text = "Limpiar";
            limpiarBtnFrmPermiso.Location = new System.Drawing.Point(350, 240);
            limpiarBtnFrmPermiso.Size = new System.Drawing.Size(130, 35);
            limpiarBtnFrmPermiso.BackColor = System.Drawing.Color.FromArgb(195, 155, 110); // Café claro
            limpiarBtnFrmPermiso.ForeColor = System.Drawing.Color.FromArgb(80, 60, 40);
            limpiarBtnFrmPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            limpiarBtnFrmPermiso.FlatAppearance.BorderSize = 0;
            limpiarBtnFrmPermiso.Cursor = System.Windows.Forms.Cursors.Hand;
            limpiarBtnFrmPermiso.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            limpiarBtnFrmPermiso.Click += limpiarBtnFrmPermiso_Click;
            this.Controls.Add(limpiarBtnFrmPermiso);
        }

        private System.Windows.Forms.TextBox buscarTxtFrmPermiso;
        private System.Windows.Forms.Button buscarBtnFrmPermiso;
        private System.Windows.Forms.TextBox idPermisoTxtFrmPermiso;
        private System.Windows.Forms.TextBox nivelPermisoTxtFrmPermiso;
        private System.Windows.Forms.Button agregarBtnFrmPermiso;
        private System.Windows.Forms.Button guardarBtnFrmPermiso;
        private System.Windows.Forms.Button eliminarBtnFrmPermiso;
        private System.Windows.Forms.Button limpiarBtnFrmPermiso;
    }
}
