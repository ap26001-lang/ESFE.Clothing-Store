using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESFE._Clothing_Store.DAL;
using EstadoEntidad = ESFE._Clothing_Store.EN.Estado;

namespace ESFE.Clothing_Store.UI
{
    public partial class Estado : Form
    {
        public Estado()
        {
            InitializeComponent();
        }

        // Buscar estado por id, o por coincidencia parcial de texto
        private void button1_Click(object sender, EventArgs e)
        {
            string criterio = buscarTxtFrmEstado.Text.Trim();
            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("Ingrese un ID o Nombre de estado para buscar.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Si es un ID numérico buscar directamente
                if (int.TryParse(criterio, out int id))
                {
                    var est = EstadoDAL.ObtenerPorId(id);
                    if (est != null)
                    {
                        FillFormFromEntity(est);
                        return;
                    }
                }

                // Por texto parcial
                var lista = EstadoDAL.ObtenerTodos();
                var encontrado = lista.Find(x => !string.IsNullOrEmpty(x.estado) && x.estado.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                if (encontrado != null)
                {
                    FillFormFromEntity(encontrado);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún estado coincidente.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpiar
        private void button2_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Eliminar
        private void button3_Click(object sender, EventArgs e)
        {
            string q = eliminarTxtFrmEstado.Text.Trim();
            if (string.IsNullOrEmpty(q))
            {
                MessageBox.Show("Ingrese un ID o nombre de estado para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int idToDelete = 0;
                if (int.TryParse(q, out int id))
                {
                    idToDelete = id;
                }
                else
                {
                    var lista = EstadoDAL.ObtenerTodos();
                    var found = lista.Find(x => string.Equals(x.estado, q, StringComparison.OrdinalIgnoreCase));
                    if (found == null)
                    {
                        MessageBox.Show("No se encontró ningún estado con ese nombre para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    idToDelete = found.id_estado;
                }

                var confirm = MessageBox.Show($"¿Confirma eliminar el Estado con Id={idToDelete}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;

                int rows = EstadoDAL.Eliminar(idToDelete);
                if (rows > 0)
                {
                    MessageBox.Show("Estado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el estado. Verifique si está asignado a algún Cliente, Producto o Rol.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Si el error contiene REFERENCE_FK, significa que hay datos relacionados
                if (ex.Message.Contains("REFERENCE"))
                {
                    MessageBox.Show("No se puede eliminar este Estado porque está siendo utilizado por uno o más Clientes.\n\nPrimero debe cambiar o eliminar los Clientes que usan este Estado.", "Restricción de clave foránea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Guardar / Modificar
        private void button4_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (!ValidadorCampos.ValidarSoloLetras(estadoTxtFrmEstado.Text, "Nombre del Estado")) return;
            if (!ValidadorCampos.ValidarLongitudMaxima(estadoTxtFrmEstado.Text, "Nombre del Estado", 50)) return;

            try
            {
                string idTexto = idEstadoTxtFrmEstado.Text.Trim();
                if (!string.IsNullOrEmpty(idTexto) && int.TryParse(idTexto, out int idActual) && idActual > 0)
                {
                    // Actualizar estado existente
                    var entidad = new EstadoEntidad { id_estado = idActual, estado = estadoTxtFrmEstado.Text.Trim() };
                    EstadoDAL.Actualizar(entidad);
                    MessageBox.Show("Estado actualizado correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Agregar nuevo estado
                    var entidad = new EstadoEntidad { estado = estadoTxtFrmEstado.Text.Trim() };
                    int newId = EstadoDAL.Insertar(entidad);
                    if (newId > 0)
                    {
                        idEstadoTxtFrmEstado.Text = newId.ToString();
                        MessageBox.Show($"Estado agregado correctamente. Id={newId}", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No fue posible guardar el estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillFormFromEntity(EstadoEntidad est)
        {
            if (est == null) return;
            idEstadoTxtFrmEstado.Text = est.id_estado.ToString();
            estadoTxtFrmEstado.Text = est.estado ?? string.Empty;
        }

        private void ClearForm()
        {
            buscarTxtFrmEstado.Clear();
            idEstadoTxtFrmEstado.Clear();
            estadoTxtFrmEstado.Clear();
            eliminarTxtFrmEstado.Clear();
            estadoTxtFrmEstado.Focus();
        }
    }
}
