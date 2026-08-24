using System;
using System.Drawing;
using System.Windows.Forms;

namespace ESFE.Clothing_Store.UI
{
    public partial class MenuPrincipal : Form
    {
        private Label lblTitulo;
        private Button btnRoles, btnTallas, btnTela, btnTipoProducto, btnUsuario, btnVentas;
        private Button btnBitacora, btnClientes, btnEstado, btnProductos, btnColor, btnPermiso, btnSalir;

        public MenuPrincipal()
        {
            InitializeComponent();
            DiseñarFormulario();
        }

        private void DiseñarFormulario()
        {
            this.Text = "ESFE Clothing Store - Menú Principal";
            this.Size = new Size(750, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(250, 245, 240); // Crema muy claro

            // Encabezado
            Panel panelTitulo = new Panel();
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Size = new Size(750, 90);
            panelTitulo.BackColor = Color.FromArgb(120, 81, 51); // Café oscuro

            lblTitulo = new Label();
            lblTitulo.Text = "MENÚ PRINCIPAL";
            lblTitulo.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(255, 245, 230); // Crema
            lblTitulo.Location = new Point(35, 18);
            lblTitulo.AutoSize = true;

            Label lblSubtitulo = new Label();
            lblSubtitulo.Text = "ESFE Clothing Store - Sistema de Gestión";
            lblSubtitulo.Font = new Font("Segoe UI", 10);
            lblSubtitulo.ForeColor = Color.FromArgb(200, 170, 140); // Café claro
            lblSubtitulo.Location = new Point(38, 57);
            lblSubtitulo.AutoSize = true;

            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Controls.Add(lblSubtitulo);
            this.Controls.Add(panelTitulo);

            // Fila 1
            btnRoles = CrearBoton("ROLES", 50, 120, Color.FromArgb(169, 132, 94)); // Café
            btnRoles.Click += BtnRoles_Click;

            btnTallas = CrearBoton("TALLAS", 270, 120, Color.FromArgb(195, 155, 110)); // Café claro
            btnTallas.Click += BtnTallas_Click;

            btnTela = CrearBoton("TELA", 490, 120, Color.FromArgb(210, 180, 140)); // Tan claro
            btnTela.Click += BtnTela_Click;

            // Fila 2
            btnTipoProducto = CrearBoton("TIPO PRODUCTO", 50, 180, Color.FromArgb(140, 100, 60)); // Café más oscuro
            btnTipoProducto.Click += BtnTipoProducto_Click;

            btnUsuario = CrearBoton("USUARIO", 270, 180, Color.FromArgb(160, 120, 80)); // Café medio
            btnUsuario.Click += BtnUsuario_Click;

            btnVentas = CrearBoton("VENTAS", 490, 180, Color.FromArgb(180, 140, 100)); // Café claro
            btnVentas.Click += BtnVentas_Click;

            // Fila 3
            btnClientes = CrearBoton("CLIENTES", 50, 240, Color.FromArgb(150, 110, 70)); // Café
            btnClientes.Click += BtnClientes_Click;

            btnProductos = CrearBoton("PRODUCTOS", 270, 240, Color.FromArgb(200, 160, 120)); // Café claro
            btnProductos.Click += BtnProductos_Click;

            btnEstado = CrearBoton("ESTADO", 490, 240, Color.FromArgb(130, 90, 50)); // Café oscuro
            btnEstado.Click += BtnEstado_Click;

            // Fila 4
            btnBitacora = CrearBoton("BITACORA", 50, 300, Color.FromArgb(175, 135, 95)); // Café
            btnBitacora.Click += BtnBitacora_Click;

            btnColor = CrearBoton("COLOR", 270, 300, Color.FromArgb(220, 180, 140)); // Tan
            btnColor.Click += BtnColor_Click;

            btnPermiso = CrearBoton("PERMISO", 490, 300, Color.FromArgb(160, 120, 80)); // Café medio
            btnPermiso.Click += BtnPermiso_Click;

            // Botón Salir
            btnSalir = new Button();
            btnSalir.Text = "SALIR";
            btnSalir.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnSalir.Location = new Point(225, 370);
            btnSalir.Size = new Size(300, 50);
            btnSalir.BackColor = Color.FromArgb(110, 70, 30); // Café muy oscuro
            btnSalir.ForeColor = Color.FromArgb(255, 245, 230); // Crema
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Click += BtnSalir_Click;
            this.Controls.Add(btnSalir);
        }

        private Button CrearBoton(string texto, int x, int y, Color color)
        {
            Button btn = new Button();
            btn.Text = texto;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Location = new Point(x, y);
            btn.Size = new Size(180, 45);
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            this.Controls.Add(btn);
            return btn;
        }

        private void BtnRoles_Click(object sender, EventArgs e) => new roles().Show();
        private void BtnTallas_Click(object sender, EventArgs e) => new tallas().Show();
        private void BtnTela_Click(object sender, EventArgs e) => new Tela().Show();
        private void BtnTipoProducto_Click(object sender, EventArgs e) => new Tipo_producto().Show();
        private void BtnUsuario_Click(object sender, EventArgs e) => new Usuario().Show();
        private void BtnVentas_Click(object sender, EventArgs e) => new Ventas().Show();
        private void BtnClientes_Click(object sender, EventArgs e) => new Clientes().Show();
        private void BtnProductos_Click(object sender, EventArgs e) => new productos().Show();
        private void BtnEstado_Click(object sender, EventArgs e) => new Estado().Show();
        private void BtnBitacora_Click(object sender, EventArgs e) => new Bitacora().Show();
        private void BtnColor_Click(object sender, EventArgs e) => new ColorForm().Show();
        private void BtnPermiso_Click(object sender, EventArgs e) => new Permiso().Show();
        private void BtnSalir_Click(object sender, EventArgs e) => this.Close();
    }
}
