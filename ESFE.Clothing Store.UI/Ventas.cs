using System;
using System.Drawing;
using Color = System.Drawing.Color;
using System.Windows.Forms;
using ESFE._Clothing_Store.DAL;
using VentasEntity = ESFE._Clothing_Store.EN.Ventas;

namespace ESFE.Clothing_Store.UI
{
    public partial class Ventas : Form
    {
        private Label lblCodigo, lblFecha, lblCantidad, lblProducto, lblCliente;
        private TextBox txtCodigo, txtFecha, txtCantidad, txtProducto, txtCliente;
        private Button btnBuscar, btnGuardar, btnEliminar, btnLimpiar;

        public Ventas()
        {
            InitializeComponent();
            DiseñarFormulario();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
        }

        private void DiseñarFormulario()
        {
            this.Text = "ESFE Clothing Store - Registro de Ventas";
            this.Size = new Size(760, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(250, 245, 240); // Crema muy claro

            // Encabezado
            Panel panelTitulo = new Panel();
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Size = new Size(760, 90);
            panelTitulo.BackColor = System.Drawing.Color.FromArgb(120, 81, 51); // Café oscuro

            Label lblTitulo = new Label();
            lblTitulo.Text = "REGISTRO DE VENTA";
            lblTitulo.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 245, 230); // Crema
            lblTitulo.Location = new Point(35, 18);
            lblTitulo.AutoSize = true;

            Label lblSubtitulo = new Label();
            lblSubtitulo.Text = "ESFE Clothing Store";
            lblSubtitulo.Font = new Font("Segoe UI", 10);
            lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(200, 170, 140); // Café claro
            lblSubtitulo.Location = new Point(38, 57);
            lblSubtitulo.AutoSize = true;

            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Controls.Add(lblSubtitulo);
            this.Controls.Add(panelTitulo);

            // CÓDIGO DE VENTA
            lblCodigo = CrearLabel("Codigo_de_Venta", 60, 125);
            txtCodigo = new TextBox();
            txtCodigo.Location = new Point(60, 150);
            txtCodigo.Size = new Size(280, 30);
            txtCodigo.Font = new Font("Segoe UI", 11);
            txtCodigo.BackColor = System.Drawing.Color.FromArgb(255, 250, 245); // Crema muy claro
            txtCodigo.ForeColor = System.Drawing.Color.FromArgb(80, 60, 40); // Café oscuro
            this.Controls.Add(lblCodigo);
            this.Controls.Add(txtCodigo);

            // BOTÓN BUSCAR
            btnBuscar = new Button();
            btnBuscar.Text = "BUSCAR";
            btnBuscar.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnBuscar.Location = new Point(350, 150);
            btnBuscar.Size = new Size(100, 30);
            btnBuscar.BackColor = System.Drawing.Color.FromArgb(169, 132, 94); // Café
            btnBuscar.ForeColor = System.Drawing.Color.FromArgb(255, 245, 230); // Crema
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Click += BtnBuscar_Click;
            this.Controls.Add(btnBuscar);

            // FECHA Y HORA
            lblFecha = CrearLabel("Fecha_y_hora", 470, 125);
            txtFecha = new TextBox();
            txtFecha.Location = new Point(470, 150);
            txtFecha.Size = new Size(200, 30);
            txtFecha.Font = new Font("Segoe UI", 10);
            txtFecha.BackColor = System.Drawing.Color.FromArgb(255, 250, 245);
            txtFecha.ForeColor = System.Drawing.Color.FromArgb(80, 60, 40);
            txtFecha.ReadOnly = true;
            this.Controls.Add(lblFecha);
            this.Controls.Add(txtFecha);

            // CANTIDAD DE PRODUCTO
            lblCantidad = CrearLabel("Cantidad_de_producto", 60, 210);
            txtCantidad = new TextBox();
            txtCantidad.Location = new Point(60, 235);
            txtCantidad.Size = new Size(280, 30);
            txtCantidad.Font = new Font("Segoe UI", 10);
            txtCantidad.BackColor = System.Drawing.Color.FromArgb(255, 250, 245);
            txtCantidad.ForeColor = System.Drawing.Color.FromArgb(80, 60, 40);
            this.Controls.Add(lblCantidad);
            this.Controls.Add(txtCantidad);

            // ID TIPO PRODUCTO
            lblProducto = CrearLabel("id_Tipo_Producto", 390, 210);
            txtProducto = new TextBox();
            txtProducto.Location = new Point(390, 235);
            txtProducto.Size = new Size(280, 30);
            txtProducto.Font = new Font("Segoe UI", 10);
            txtProducto.BackColor = System.Drawing.Color.FromArgb(255, 250, 245);
            txtProducto.ForeColor = System.Drawing.Color.FromArgb(80, 60, 40);
            this.Controls.Add(lblProducto);
            this.Controls.Add(txtProducto);

            // ID CLIENTE
            lblCliente = CrearLabel("id_cliente", 60, 295);
            txtCliente = new TextBox();
            txtCliente.Location = new Point(60, 320);
            txtCliente.Size = new Size(610, 30);
            txtCliente.Font = new Font("Segoe UI", 10);
            txtCliente.BackColor = System.Drawing.Color.FromArgb(255, 250, 245);
            txtCliente.ForeColor = System.Drawing.Color.FromArgb(80, 60, 40);
            this.Controls.Add(lblCliente);
            this.Controls.Add(txtCliente);

            // BOTÓN GUARDAR
            btnGuardar = new Button();
            btnGuardar.Text = "GUARDAR VENTA";
            btnGuardar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnGuardar.Location = new Point(60, 405);
            btnGuardar.Size = new Size(190, 50);
            btnGuardar.BackColor = System.Drawing.Color.FromArgb(140, 100, 60); // Café oscuro
            btnGuardar.ForeColor = System.Drawing.Color.FromArgb(255, 245, 230); // Crema
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Click += BtnGuardar_Click;
            this.Controls.Add(btnGuardar);

            // BOTÓN ELIMINAR
            btnEliminar = new Button();
            btnEliminar.Text = "ELIMINAR VENTA";
            btnEliminar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnEliminar.Location = new Point(260, 405);
            btnEliminar.Size = new Size(190, 50);
            btnEliminar.BackColor = System.Drawing.Color.FromArgb(160, 100, 60); // Café medio-oscuro
            btnEliminar.ForeColor = System.Drawing.Color.FromArgb(255, 245, 230); // Crema
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Click += BtnEliminar_Click;
            this.Controls.Add(btnEliminar);

            // BOTÓN LIMPIAR
            btnLimpiar = new Button();
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnLimpiar.Location = new Point(460, 405);
            btnLimpiar.Size = new Size(190, 50);
            btnLimpiar.BackColor = Color.FromArgb(195, 155, 110); // Café claro
            btnLimpiar.ForeColor = Color.FromArgb(80, 60, 40); // Café oscuro
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Click += BtnLimpiar_Click;
            this.Controls.Add(btnLimpiar);
        }

        private Label CrearLabel(string texto, int x, int y)
        {
            Label label = new Label();
            label.Text = texto;
            label.Location = new Point(x, y);
            label.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            label.ForeColor = Color.FromArgb(120, 81, 51); // Café oscuro
            label.AutoSize = true;
            return label;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingrese el código de la venta a buscar.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            VentasEntity venta = VentasDAL.ObtenerPorCodigo(codigo);
            if (venta != null)
            {
                txtFecha.Text = venta.Fecha_y_Hora.ToString("dd/MM/yyyy HH:mm");
                txtCantidad.Text = venta.Cantidad_de_productos.ToString();
                txtProducto.Text = venta.id_Tipo_Producto.ToString();
                txtCliente.Text = venta.id_cliente.ToString();
            }
            else
            {
                MessageBox.Show("Venta no encontrada", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Ingrese el código de la venta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProducto.Text) || !int.TryParse(txtProducto.Text, out int idProducto))
            {
                MessageBox.Show("Ingrese un ID de tipo de producto válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCliente.Text) || !int.TryParse(txtCliente.Text, out int idCliente))
            {
                MessageBox.Show("Ingrese un ID de cliente válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            VentasEntity venta = new VentasEntity();
            venta.Codigo_de_Venta = txtCodigo.Text.Trim();
            venta.Fecha_y_Hora = DateTime.Now;
            venta.Cantidad_de_productos = cantidad;
            venta.id_Tipo_Producto = idProducto;
            venta.id_cliente = idCliente;

            try
            {
                VentasEntity existente = VentasDAL.ObtenerPorCodigo(venta.Codigo_de_Venta);
                if (existente != null)
                {
                    VentasDAL.Actualizar(venta);
                    MessageBox.Show("Venta actualizada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    VentasDAL.Insertar(venta);
                    MessageBox.Show("Venta registrada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                BtnLimpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingrese el código de la venta a eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar esta venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    VentasDAL.Eliminar(codigo);
                    MessageBox.Show("Venta eliminada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnLimpiar_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtFecha.Clear();
            txtCantidad.Clear();
            txtProducto.Clear();
            txtCliente.Clear();
            txtCodigo.Focus();
        }
    }
}
