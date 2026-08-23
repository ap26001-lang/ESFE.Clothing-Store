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
    public partial class roles : Form
    {
        public roles()
        {
            InitializeComponent();
        }

        private void roles_Load(object sender, EventArgs e)
        {
        }

        private void buscarBtnFrmRoles_Click(object sender, EventArgs e)
        {
            string idText = buscarTxtFrmRoles.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Ingrese un ID de rol válido para buscar", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Roles rol = RolesDAL.ObtenerPorId(id);
            if (rol != null)
            {
                FillFormFromEntity(rol);
            }
            else
            {
                MessageBox.Show("Rol no encontrado", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void limpiarBtnFrmRoles_Click(object sender, EventArgs e)
        {
            ClearForm();
            buscarTxtFrmRoles.Clear();
        }

        private void agregarBtnFrmRoles_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(descripcionRolTxtFrmRoles.Text.Trim()))
            {
                MessageBox.Show("Ingrese una descripción para el rol", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Roles rol = new Roles
                {
                    DiscripcionRoles = descripcionRolTxtFrmRoles.Text.Trim()
                };

                RolesDAL.Insertar(rol);
                MessageBox.Show("Rol agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarBtnFrmRoles_Click(object sender, EventArgs e)
        {
            string idText = idRolTxtFrmRoles.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Ingrese un ID de rol válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(descripcionRolTxtFrmRoles.Text.Trim()))
            {
                MessageBox.Show("Ingrese una descripción para el rol", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Roles rol = new Roles
            {
                idRoles = id,
                DiscripcionRoles = descripcionRolTxtFrmRoles.Text.Trim()
            };

            try
            {
                int rows = RolesDAL.Actualizar(rol);
                if (rows > 0)
                {
                    MessageBox.Show("Rol actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el rol", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarBtnFrmRoles_Click(object sender, EventArgs e)
        {
            string idText = buscarTxtFrmRoles.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Ingrese el ID del rol a eliminar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar este rol?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    RolesDAL.Eliminar(id);
                    MessageBox.Show("Rol eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("REFERENCE") || ex.Message.Contains("FOREIGN KEY"))
                    {
                        MessageBox.Show("No se puede eliminar este rol porque está siendo usado por clientes en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FillFormFromEntity(Roles rol)
        {
            idRolTxtFrmRoles.Text = rol.idRoles.ToString();
            descripcionRolTxtFrmRoles.Text = rol.DiscripcionRoles ?? string.Empty;
        }

        private void ClearForm()
        {
            idRolTxtFrmRoles.Clear();
            descripcionRolTxtFrmRoles.Clear();
        }
    }
}
