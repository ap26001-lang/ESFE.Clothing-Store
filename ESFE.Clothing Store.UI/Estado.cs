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
            string nombreEstado = estadoTxtFrmEstado.Text.Trim();
            if (string.IsNullOrEmpty(nombreEstado))
            {
                MessageBox.Show("Ingrese el nombre del estado.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string idTexto = idEstadoTxtFrmEstado.Text.Trim();
                if (!string.IsNullOrEmpty(idTexto) && int.TryParse(idTexto, out int idActual) && idActual > 0)
                {
                    // Actualizar estado existente
                    var entidad = new EstadoEntidad { id_estado = idActual, estado = nombreEstado };
                    int rows = EstadoDAL.Actualizar(entidad);
                    if (rows > 0)
                    {
                        MessageBox.Show("Estado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillFormFromEntity(entidad);
                    }
                    else
                    {
                        // Si el ID no existe en la base de datos se registra como nuevo con ese ID manual directo
                        var existe = EstadoDAL.ObtenerPorId(idActual);
                        if (existe == null)
                        {
                            MessageBox.Show($"El ID {idActual} no existe en la base de datos. Se registrará como un nuevo Estado con ese ID.", "Guardar nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            using (System.Data.IDbConnection cn = DBComun.ObtenerConexion())
                            {
                                cn.Open();
                                using (System.Data.IDbCommand cmd = cn.CreateCommand())
                                {
                                    cmd.CommandText = "INSERT INTO [dbo].[Estado] (id_estado, Estado) VALUES (@id_estado, @Estado)";
                                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@id_estado"; p1.Value = idActual; cmd.Parameters.Add(p1);
                                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@Estado"; p2.Value = nombreEstado; cmd.Parameters.Add(p2);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            MessageBox.Show($"Estado agregado correctamente con el Id={idActual}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillFormFromEntity(entidad);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    // Insertar nuevo estado autoincrementado (ID máximo + 1)
                    var entidad = new EstadoEntidad { estado = nombreEstado };
                    int newId = EstadoDAL.Insertar(entidad);
                    if (newId > 0)
                    {
                        entidad.id_estado = newId;
                        FillFormFromEntity(entidad);
                        MessageBox.Show($"Estado agregado correctamente con el Id={newId}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
