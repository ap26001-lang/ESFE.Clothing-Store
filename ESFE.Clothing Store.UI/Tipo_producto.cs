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
    public partial class Tipo_producto : Form
    {
        public Tipo_producto()
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

        private void buscarBtnFrmTipoProducto_Click(object sender, EventArgs e)
        {
            string idText = buscarTxtFrmTipoProducto.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Ingrese un ID de tipo de producto v\u00E1lido para buscar", "B\u00FAsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Tipo_Producto tipoProducto = TipoProductoDAL.ObtenerPorId(id);
            if (tipoProducto != null)
            {
                FillFormFromEntity(tipoProducto);
            }
            else
            {
                MessageBox.Show("Tipo de producto no encontrado", "B\u00FAsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void agregarBtnFrmTipoProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tipoProductoTxtFrmTipoProducto.Text.Trim()))
            {
                MessageBox.Show("Ingrese el tipo de producto", "Validaci\u00F3n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Tipo_Producto tipoProducto = new Tipo_Producto
                {
                    Tipo_de_producto = tipoProductoTxtFrmTipoProducto.Text.Trim()
                };

                TipoProductoDAL.Insertar(tipoProducto);
                MessageBox.Show("Tipo de producto agregado exitosamente", "\u00C9xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar tipo de producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarBtnFrmTipoProducto_Click(object sender, EventArgs e)
        {
            string idText = idTipoProductoTxtFrmTipoProducto.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Primero busque un tipo de producto v\u00E1lido", "Validaci\u00F3n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tipoProductoTxtFrmTipoProducto.Text.Trim()))
            {
                MessageBox.Show("Ingrese el tipo de producto", "Validaci\u00F3n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tipo_Producto tipoProducto = new Tipo_Producto
            {
                id_tipo_producto = id,
                Tipo_de_producto = tipoProductoTxtFrmTipoProducto.Text.Trim()
            };

            try
            {
                TipoProductoDAL.Actualizar(tipoProducto);
                MessageBox.Show("Tipo de producto actualizado exitosamente", "\u00C9xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarBtnFrmTipoProducto_Click(object sender, EventArgs e)
        {
            string idText = buscarTxtFrmTipoProducto.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Ingrese el ID del tipo de producto a eliminar", "Validaci\u00F3n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("\u00BFDesea eliminar este tipo de producto?", "Confirmaci\u00F3n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    TipoProductoDAL.Eliminar(id);
                    MessageBox.Show("Tipo de producto eliminado exitosamente", "\u00C9xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("REFERENCE") || ex.Message.Contains("FOREIGN KEY"))
                    {
                        MessageBox.Show("No se puede eliminar este tipo de producto porque est\u00E1 siendo usado en otra tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void limpiarBtnFrmTipoProducto_Click(object sender, EventArgs e)
        {
            ClearForm();
            buscarTxtFrmTipoProducto.Clear();
        }

        private void FillFormFromEntity(Tipo_Producto tipoProducto)
        {
            idTipoProductoTxtFrmTipoProducto.Text = tipoProducto.id_tipo_producto.ToString();
            tipoProductoTxtFrmTipoProducto.Text = tipoProducto.Tipo_de_producto ?? string.Empty;
        }

        private void ClearForm()
        {
            idTipoProductoTxtFrmTipoProducto.Clear();
            tipoProductoTxtFrmTipoProducto.Clear();
        }
    }
}
