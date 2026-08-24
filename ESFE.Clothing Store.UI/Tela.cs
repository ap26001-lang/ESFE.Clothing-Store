using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESFE.Clothing_Store.DAL;
using ESFE._Clothing_Store.EN;

namespace ESFE.Clothing_Store.UI
{
    public partial class Tela : Form
    {
        public Tela()
        {
            InitializeComponent();
        }

        private void buscarBtnFrmTela_Click(object sender, EventArgs e)
        {
            string idText = buscarTxtFrmTela.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Ingrese un ID de tela válido para buscar", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ESFE._Clothing_Store.EN.Tela tela = TelaDal.ObtenerPorId(id);
            if (tela != null)
            {
                FillFormFromEntity(tela);
            }
            else
            {
                MessageBox.Show("Tela no encontrada", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void agregarBtnFrmTela_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tipoTelaTxtFrmTela.Text.Trim()))
            {
                MessageBox.Show("Ingrese el tipo de tela", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ESFE._Clothing_Store.EN.Tela tela = new ESFE._Clothing_Store.EN.Tela
                {
                    Tipodetela = tipoTelaTxtFrmTela.Text.Trim()
                };

                TelaDal.Insertar(tela);
                MessageBox.Show("Tela agregada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar tela: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarBtnFrmTela_Click(object sender, EventArgs e)
        {
            string idText = idTelaTxtFrmTela.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Primero busque una tela válida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tipoTelaTxtFrmTela.Text.Trim()))
            {
                MessageBox.Show("Ingrese el tipo de tela", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ESFE._Clothing_Store.EN.Tela tela = new ESFE._Clothing_Store.EN.Tela
            {
                idTela = id,
                Tipodetela = tipoTelaTxtFrmTela.Text.Trim()
            };

            try
            {
                TelaDal.Actualizar(tela);
                MessageBox.Show("Tela actualizada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarBtnFrmTela_Click(object sender, EventArgs e)
        {
            string idText = buscarTxtFrmTela.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Ingrese el ID de la tela a eliminar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar esta tela?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    TelaDal.Eliminar(id);
                    MessageBox.Show("Tela eliminada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("REFERENCE") || ex.Message.Contains("FOREIGN KEY"))
                    {
                        MessageBox.Show("No se puede eliminar esta tela porque está siendo usada en otra tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void limpiarBtnFrmTela_Click(object sender, EventArgs e)
        {
            ClearForm();
            buscarTxtFrmTela.Clear();
        }

        private void FillFormFromEntity(ESFE._Clothing_Store.EN.Tela tela)
        {
            idTelaTxtFrmTela.Text = tela.idTela.ToString();
            tipoTelaTxtFrmTela.Text = tela.Tipodetela ?? string.Empty;
        }

        private void ClearForm()
        {
            idTelaTxtFrmTela.Clear();
            tipoTelaTxtFrmTela.Clear();
        }
    }
}
