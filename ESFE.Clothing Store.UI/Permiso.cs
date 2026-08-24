using System;
using System.Windows.Forms;
using ESFE._Clothing_Store.DAL;
using ESFE._Clothing_Store.EN;

namespace ESFE.Clothing_Store.UI
{
    public partial class Permiso : Form
    {
        public Permiso()
        {
            InitializeComponent();
        }

        private void buscarBtnFrmPermiso_Click(object sender, EventArgs e)
        {
            string idText = buscarTxtFrmPermiso.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Ingrese un ID de permiso válido para buscar", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ESFE._Clothing_Store.EN.Permiso permiso = PermisoDAL.ObtenerPorId(id);
            if (permiso != null)
            {
                FillFormFromEntity(permiso);
            }
            else
            {
                MessageBox.Show("Permiso no encontrado", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void agregarBtnFrmPermiso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nivelPermisoTxtFrmPermiso.Text.Trim()))
            {
                MessageBox.Show("Ingrese el nivel de permiso", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Generar nuevo ID automáticamente (MAX + 1)
                var todosPermisos = PermisoDAL.ObtenerTodos();
                int nuevoId = todosPermisos.Count > 0 ? todosPermisos.FindAll(p => p.id_permiso > 0).ConvertAll(p => p.id_permiso).Max() + 1 : 1;

                ESFE._Clothing_Store.EN.Permiso permiso = new ESFE._Clothing_Store.EN.Permiso
                {
                    id_permiso = nuevoId,
                    Nivel_permiso = nivelPermisoTxtFrmPermiso.Text.Trim()
                };

                PermisoDAL.Insertar(permiso);
                MessageBox.Show("Permiso agregado exitosamente con ID: " + nuevoId, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar permiso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarBtnFrmPermiso_Click(object sender, EventArgs e)
        {
            string idText = idPermisoTxtFrmPermiso.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Primero busque un permiso válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(nivelPermisoTxtFrmPermiso.Text.Trim()))
            {
                MessageBox.Show("Ingrese el nivel de permiso", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ESFE._Clothing_Store.EN.Permiso permiso = new ESFE._Clothing_Store.EN.Permiso
            {
                id_permiso = id,
                Nivel_permiso = nivelPermisoTxtFrmPermiso.Text.Trim()
            };

            try
            {
                PermisoDAL.Actualizar(permiso);
                MessageBox.Show("Permiso actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarBtnFrmPermiso_Click(object sender, EventArgs e)
        {
            string idText = buscarTxtFrmPermiso.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Ingrese el ID del permiso a eliminar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar este permiso?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    PermisoDAL.Eliminar(id);
                    MessageBox.Show("Permiso eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("REFERENCE") || ex.Message.Contains("FOREIGN KEY"))
                    {
                        MessageBox.Show("No se puede eliminar este permiso porque está siendo usado en otra tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void limpiarBtnFrmPermiso_Click(object sender, EventArgs e)
        {
            ClearForm();
            buscarTxtFrmPermiso.Clear();
        }

        private void FillFormFromEntity(ESFE._Clothing_Store.EN.Permiso permiso)
        {
            idPermisoTxtFrmPermiso.Text = permiso.id_permiso.ToString();
            nivelPermisoTxtFrmPermiso.Text = permiso.Nivel_permiso ?? string.Empty;
        }

        private void ClearForm()
        {
            idPermisoTxtFrmPermiso.Clear();
            nivelPermisoTxtFrmPermiso.Clear();
        }
    }
}
