using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESFE._Clothing_Store.DAL;
using ESFE._Clothing_Store.EN;

namespace ESFE.Clothing_Store.UI
{
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
            ApplyLuxuryTheme();
        }

        private void ApplyLuxuryTheme()
        {
            this.BackColor = System.Drawing.Color.FromArgb(245, 240, 235); // Crema
            this.ForeColor = System.Drawing.Color.FromArgb(70, 50, 40); // Café oscuro

            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.ForeColor = System.Drawing.Color.FromArgb(70, 50, 40); // Café oscuro
                }
                else if (control is TextBox || control is ComboBox)
                {
                    control.BackColor = System.Drawing.Color.FromArgb(255, 250, 245); // Crema muy clara
                    control.ForeColor = System.Drawing.Color.FromArgb(70, 50, 40); // Café oscuro
                }
                else if (control is Button)
                {
                    control.BackColor = System.Drawing.Color.FromArgb(140, 100, 70); // Café
                    control.ForeColor = System.Drawing.Color.FromArgb(245, 240, 235); // Crema
                    control.Font = new Font(control.Font.FontFamily, control.Font.Size, FontStyle.Bold);
                }
            }
        }

        private void productos_Load(object sender, EventArgs e)
        {
        }

        private void buscarBtnFrmProductos_Click(object sender, EventArgs e)
        {
            string codigo = buscarTxtFrmProductos.Text.Trim();
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingrese un código de producto para buscar", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Productos prod = ProductosDAL.ObtenerPorId(codigo);
            if (prod != null)
            {
                FillFormFromEntity(prod);
            }
            else
            {
                MessageBox.Show("Producto no encontrado", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void limpiarBtnFrmProductos_Click(object sender, EventArgs e)
        {
            ClearForm();
            buscarTxtFrmProductos.Clear();
        }

        private void agregarBtnFrmProductos_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Complete todos los campos requeridos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Productos prod = new Productos
            {
                CodigoProducto = codigoProductoTxtFrmProductos.Text.Trim(),
                NombreProducto = nombreProductoTxtFrmProductos.Text.Trim(),
                precio = precioTxtFrmProductos.Text.Trim(),
                idTipoProducto = ParseIntOrZero(idTipoProductoTxtFrmProductos.Text),
                idtallas = ParseIntOrZero(idTallasTxtFrmProductos.Text),
                idtelas = ParseIntOrZero(idTelaTxtFrmProductos.Text),
                idcolor = ParseIntOrZero(idColorTxtFrmProductos.Text)
            };

            try
            {
                ProductosDAL.Insertar(prod);
                MessageBox.Show("Producto agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarBtnFrmProductos_Click(object sender, EventArgs e)
        {
            string codigo = codigoProductoTxtFrmProductos.Text.Trim();
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingrese un código de producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateFields())
            {
                MessageBox.Show("Complete todos los campos requeridos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Productos prod = new Productos
            {
                CodigoProducto = codigo,
                NombreProducto = nombreProductoTxtFrmProductos.Text.Trim(),
                precio = precioTxtFrmProductos.Text.Trim(),
                idTipoProducto = ParseIntOrZero(idTipoProductoTxtFrmProductos.Text),
                idtallas = ParseIntOrZero(idTallasTxtFrmProductos.Text),
                idtelas = ParseIntOrZero(idTelaTxtFrmProductos.Text),
                idcolor = ParseIntOrZero(idColorTxtFrmProductos.Text)
            };

            try
            {
                int rows = ProductosDAL.Actualizar(prod);
                if (rows > 0)
                {
                    MessageBox.Show("Producto actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarBtnFrmProductos_Click(object sender, EventArgs e)
        {
            string codigo = buscarTxtFrmProductos.Text.Trim();
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingrese el código del producto a eliminar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ProductosDAL.Eliminar(codigo);
                    MessageBox.Show("Producto eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("FOREIGN KEY constraint"))
                    {
                        MessageBox.Show("No se puede eliminar el producto porque está siendo usado en otra tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FillFormFromEntity(Productos prod)
        {
            codigoProductoTxtFrmProductos.Text = prod.CodigoProducto ?? string.Empty;
            nombreProductoTxtFrmProductos.Text = prod.NombreProducto ?? string.Empty;
            precioTxtFrmProductos.Text = prod.precio ?? string.Empty;
            idTipoProductoTxtFrmProductos.Text = prod.idTipoProducto.ToString();
            idTallasTxtFrmProductos.Text = prod.idtallas.ToString();
            idTelaTxtFrmProductos.Text = prod.idtelas.ToString();
            idColorTxtFrmProductos.Text = prod.idcolor.ToString();
        }

        private void ClearForm()
        {
            codigoProductoTxtFrmProductos.Clear();
            nombreProductoTxtFrmProductos.Clear();
            precioTxtFrmProductos.Clear();
            idTipoProductoTxtFrmProductos.Clear();
            idTallasTxtFrmProductos.Clear();
            idTelaTxtFrmProductos.Clear();
            idColorTxtFrmProductos.Clear();
        }

        private bool ValidateFields()
        {
            return !string.IsNullOrEmpty(codigoProductoTxtFrmProductos.Text.Trim()) &&
                   !string.IsNullOrEmpty(nombreProductoTxtFrmProductos.Text.Trim()) &&
                   !string.IsNullOrEmpty(precioTxtFrmProductos.Text.Trim()) &&
                   !string.IsNullOrEmpty(idTipoProductoTxtFrmProductos.Text.Trim()) &&
                   !string.IsNullOrEmpty(idTallasTxtFrmProductos.Text.Trim()) &&
                   !string.IsNullOrEmpty(idTelaTxtFrmProductos.Text.Trim()) &&
                   !string.IsNullOrEmpty(idColorTxtFrmProductos.Text.Trim());
        }

        private int ParseIntOrZero(string value)
        {
            if (int.TryParse(value, out int result))
                return result;
            return 0;
        }

        private void buscarTxtFrmProductos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
