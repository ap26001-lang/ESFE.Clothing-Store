using System;
using System.Drawing;
using Color = System.Drawing.Color;
using System.Windows.Forms;
using ESFE._Clothing_Store.EN;

namespace ESFE.Clothing_Store.UI
{
    public partial class Ventas : Form
    {
        // Controles
        private Label lblTitulo;
        private Label lblCodigo;
        private Label lblFecha;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblCliente;

        private TextBox txtCodigo;
        private DateTimePicker dtpFecha;
        private ComboBox cmbProducto;
        private NumericUpDown nudCantidad;
        private ComboBox cmbCliente;

        private Button btnGuardar;
        private Button btnLimpiar;

        public Ventas()
        {
            InitializeComponent();
            DiseñarFormulario();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            // Handler asociado desde el diseñador; sin lógica adicional por ahora.
        }



        private void DiseñarFormulario()
        {
            // ==============================
            // CONFIGURACIÓN DEL FORMULARIO
            // ==============================

            this.Text = "ESFE Clothing Store - Registro de Ventas";
            this.Size = new Size(760, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(245, 246, 248);

            // ==============================
            // ENCABEZADO
            // ==============================

            Panel panelTitulo = new Panel();
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Size = new Size(760, 90);
            panelTitulo.BackColor = Color.FromArgb(35, 39, 47);

            lblTitulo = new Label();
            lblTitulo.Text = "REGISTRO DE VENTA";
            lblTitulo.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(35, 18);
            lblTitulo.AutoSize = true;

            Label lblSubtitulo = new Label();
            lblSubtitulo.Text = "ESFE Clothing Store";
            lblSubtitulo.Font = new Font("Segoe UI", 10);
            lblSubtitulo.ForeColor = Color.LightGray;
            lblSubtitulo.Location = new Point(38, 57);
            lblSubtitulo.AutoSize = true;

            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Controls.Add(lblSubtitulo);

            this.Controls.Add(panelTitulo);

            // ==============================
            // CÓDIGO DE VENTA
            // ==============================

            lblCodigo = CrearLabel("Código de venta", 60, 125);

            txtCodigo = new TextBox();
            txtCodigo.Location = new Point(60, 150);
            txtCodigo.Size = new Size(280, 30);
            txtCodigo.Font = new Font("Segoe UI", 11);
            txtCodigo.PlaceholderText = "Ejemplo: VTA-0001";

            this.Controls.Add(lblCodigo);
            this.Controls.Add(txtCodigo);

            // ==============================
            // FECHA Y HORA
            // ==============================

            lblFecha = CrearLabel("Fecha y hora", 390, 125);

            dtpFecha = new DateTimePicker();
            dtpFecha.Location = new Point(390, 150);
            dtpFecha.Size = new Size(280, 30);
            dtpFecha.Font = new Font("Segoe UI", 10);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFecha.Value = DateTime.Now;

            this.Controls.Add(lblFecha);
            this.Controls.Add(dtpFecha);

            // ==============================
            // TIPO DE PRODUCTO
            // ==============================

            lblProducto = CrearLabel("Tipo de producto", 60, 210);

            cmbProducto = new ComboBox();
            cmbProducto.Location = new Point(60, 235);
            cmbProducto.Size = new Size(280, 30);
            cmbProducto.Font = new Font("Segoe UI", 10);
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;

            // Datos de ejemplo
            cmbProducto.Items.Add("Camisa");
            cmbProducto.Items.Add("Pantalón");
            cmbProducto.Items.Add("Vestido");
            cmbProducto.Items.Add("Zapatos");
            cmbProducto.Items.Add("Accesorios");

            this.Controls.Add(lblProducto);
            this.Controls.Add(cmbProducto);

            // ==============================
            // CANTIDAD
            // ==============================

            lblCantidad = CrearLabel("Cantidad de productos", 390, 210);

            nudCantidad = new NumericUpDown();
            nudCantidad.Location = new Point(390, 235);
            nudCantidad.Size = new Size(280, 30);
            nudCantidad.Font = new Font("Segoe UI", 10);
            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 999;
            nudCantidad.Value = 1;

            this.Controls.Add(lblCantidad);
            this.Controls.Add(nudCantidad);

            // ==============================
            // CLIENTE
            // ==============================

            lblCliente = CrearLabel("Cliente", 60, 295);

            cmbCliente = new ComboBox();
            cmbCliente.Location = new Point(60, 320);
            cmbCliente.Size = new Size(610, 30);
            cmbCliente.Font = new Font("Segoe UI", 10);
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;

            // Datos de ejemplo
            cmbCliente.Items.Add("Cliente 1");
            cmbCliente.Items.Add("Cliente 2");
            cmbCliente.Items.Add("Cliente 3");
            cmbCliente.Items.Add("Cliente 4");

            this.Controls.Add(lblCliente);
            this.Controls.Add(cmbCliente);

            // ==============================
            // BOTÓN GUARDAR
            // ==============================

            btnGuardar = new Button();
            btnGuardar.Text = "GUARDAR VENTA";
            btnGuardar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnGuardar.Location = new Point(170, 405);
            btnGuardar.Size = new Size(190, 50);
            btnGuardar.BackColor = Color.FromArgb(40, 167, 69);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Cursor = Cursors.Hand;

            btnGuardar.Click += BtnGuardar_Click;

            this.Controls.Add(btnGuardar);

            // ==============================
            // BOTÓN LIMPIAR
            // ==============================

            btnLimpiar = new Button();
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnLimpiar.Location = new Point(380, 405);
            btnLimpiar.Size = new Size(190, 50);
            btnLimpiar.BackColor = Color.FromArgb(108, 117, 125);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.Cursor = Cursors.Hand;

            btnLimpiar.Click += BtnLimpiar_Click;

            this.Controls.Add(btnLimpiar);
        }

        // ==============================
        // CREAR LABEL
        // ==============================

        private Label CrearLabel(string texto, int x, int y)
        {
            Label label = new Label();

            label.Text = texto;
            label.Location = new Point(x, y);
            label.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            label.ForeColor = Color.FromArgb(50, 50, 50);
            label.AutoSize = true;

            return label;
        }

        // ==============================
        // BOTÓN GUARDAR
        // ==============================

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Validar código
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show(
                    "Ingrese el código de la venta.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCodigo.Focus();
                return;
            }

            // Validar producto
            if (cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un tipo de producto.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbProducto.Focus();
                return;
            }

            // Validar cliente
            if (cmbCliente.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un cliente.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbCliente.Focus();
                return;
            }

            // ==================================
            // CREAR OBJETO DE LA CLASE DE ENTIDAD VENTAS (namespace EN)
            // ==================================

            ESFE._Clothing_Store.EN.Ventas venta = new ESFE._Clothing_Store.EN.Ventas();

            venta.Codigo_de_Venta = txtCodigo.Text;
            venta.Fecha_y_Hora = dtpFecha.Value;
            venta.Cantidad_de_productos = (int)nudCantidad.Value;

            // Por ahora usamos el índice como ID
            venta.id_Tipo_Producto = cmbProducto.SelectedIndex + 1;
            venta.id_cliente = cmbCliente.SelectedIndex + 1;

            MessageBox.Show(
                "Venta registrada correctamente.\n\n" +
                "Código: " + venta.Codigo_de_Venta + "\n" +
                "Fecha: " + venta.Fecha_y_Hora.ToString("dd/MM/yyyy HH:mm") + "\n" +
                "Cantidad: " + venta.Cantidad_de_productos + "\n" +
                "ID Producto: " + venta.id_Tipo_Producto + "\n" +
                "ID Cliente: " + venta.id_cliente,
                "Venta registrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // ==============================
        // BOTÓN LIMPIAR
        // ==============================

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();

            dtpFecha.Value = DateTime.Now;

            cmbProducto.SelectedIndex = -1;

            nudCantidad.Value = 1;

            cmbCliente.SelectedIndex = -1;

            txtCodigo.Focus();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}