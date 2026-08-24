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
    public partial class Usuario : Form
    {
        public Usuario()
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

        private void buscarBtnFrmUsuario_Click(object sender, EventArgs e)
        {
            string idText = buscarTxtFrmUsuario.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Ingrese un ID de usuario v\u00E1lido para buscar", "B\u00FAsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ESFE._Clothing_Store.EN.Usuario usuario = UsuarioDAL.ObtenerPorId(id);
            if (usuario != null)
            {
                FillFormFromEntity(usuario);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "B\u00FAsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void agregarBtnFrmUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usuarioTxtFrmUsuario.Text.Trim()))
            {
                MessageBox.Show("Ingrese el nombre de usuario", "Validaci\u00F3n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ESFE._Clothing_Store.EN.Usuario usuario = new ESFE._Clothing_Store.EN.Usuario
                {
                    usuario = usuarioTxtFrmUsuario.Text.Trim()
                };

                UsuarioDAL.Insertar(usuario);
                MessageBox.Show("Usuario agregado exitosamente", "\u00C9xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarBtnFrmUsuario_Click(object sender, EventArgs e)
        {
            string idText = idUsuarioTxtFrmUsuario.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Primero busque un usuario v\u00E1lido", "Validaci\u00F3n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(usuarioTxtFrmUsuario.Text.Trim()))
            {
                MessageBox.Show("Ingrese el nombre de usuario", "Validaci\u00F3n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ESFE._Clothing_Store.EN.Usuario usuario = new ESFE._Clothing_Store.EN.Usuario
            {
                id_Usuario = id,
                usuario = usuarioTxtFrmUsuario.Text.Trim()
            };

            try
            {
                UsuarioDAL.Actualizar(usuario);
                MessageBox.Show("Usuario actualizado exitosamente", "\u00C9xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarBtnFrmUsuario_Click(object sender, EventArgs e)
        {
            string idText = buscarTxtFrmUsuario.Text.Trim();
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Ingrese el ID del usuario a eliminar", "Validaci\u00F3n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("\u00BFDesea eliminar este usuario?", "Confirmaci\u00F3n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    UsuarioDAL.Eliminar(id);
                    MessageBox.Show("Usuario eliminado exitosamente", "\u00C9xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("REFERENCE") || ex.Message.Contains("FOREIGN KEY"))
                    {
                        MessageBox.Show("No se puede eliminar este usuario porque est\u00E1 siendo usado en otra tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void limpiarBtnFrmUsuario_Click(object sender, EventArgs e)
        {
            ClearForm();
            buscarTxtFrmUsuario.Clear();
        }

        private void FillFormFromEntity(ESFE._Clothing_Store.EN.Usuario usuario)
        {
            idUsuarioTxtFrmUsuario.Text = usuario.id_Usuario.ToString();
            usuarioTxtFrmUsuario.Text = usuario.usuario ?? string.Empty;
        }

        private void ClearForm()
        {
            idUsuarioTxtFrmUsuario.Clear();
            usuarioTxtFrmUsuario.Clear();
        }
    }
}
