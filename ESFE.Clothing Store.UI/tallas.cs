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
    public partial class tallas : Form
    {
        public tallas()
        {
            InitializeComponent();
        }

        private void buscarBtnFrmTallas_Click(object sender, EventArgs e)
        {
            string idText = buscarTxtFrmTallas.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Ingrese un ID de talla válido para buscar", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Tallas talla = TallasDal.ObtenerPorId(id);
            if (talla != null)
            {
                FillFormFromEntity(talla);
            }
            else
            {
                MessageBox.Show("Talla no encontrada", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void agregarBtnFrmTallas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tallaProductoTxtFrmTallas.Text.Trim()))
            {
                MessageBox.Show("Ingrese la talla del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Tallas talla = new Tallas
                {
                    TallaProducto = tallaProductoTxtFrmTallas.Text.Trim()
                };

                TallasDal.Insertar(talla);
                MessageBox.Show("Talla agregada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar talla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarBtnFrmTallas_Click(object sender, EventArgs e)
        {
            string idText = idTallaTxtFrmTallas.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Primero busque una talla válida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tallaProductoTxtFrmTallas.Text.Trim()))
            {
                MessageBox.Show("Ingrese la talla del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tallas talla = new Tallas
            {
                idTallas = id,
                TallaProducto = tallaProductoTxtFrmTallas.Text.Trim()
            };

            try
            {
                TallasDal.Actualizar(talla);
                MessageBox.Show("Talla actualizada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarBtnFrmTallas_Click(object sender, EventArgs e)
        {
            string idText = buscarTxtFrmTallas.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Ingrese el ID de la talla a eliminar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar esta talla?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    TallasDal.Eliminar(id);
                    MessageBox.Show("Talla eliminada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("REFERENCE") || ex.Message.Contains("FOREIGN KEY"))
                    {
                        MessageBox.Show("No se puede eliminar esta talla porque está siendo usada en otra tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void limpiarBtnFrmTallas_Click(object sender, EventArgs e)
        {
            ClearForm();
            buscarTxtFrmTallas.Clear();
        }

        private void FillFormFromEntity(Tallas talla)
        {
            idTallaTxtFrmTallas.Text = talla.idTallas.ToString();
            tallaProductoTxtFrmTallas.Text = talla.TallaProducto ?? string.Empty;
        }

        private void ClearForm()
        {
            idTallaTxtFrmTallas.Clear();
            tallaProductoTxtFrmTallas.Clear();
        }
    }
}
