using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESFE._Clothing_Store.DAL;
using ColorEntidad = ESFE._Clothing_Store.EN.Color;

namespace ESFE.Clothing_Store.UI
{
    public partial class ColorForm : Form
    {
        public ColorForm()
        {
            InitializeComponent();
        }

        // Buscar color por ID o por Nombre
        private void button1_Click(object sender, EventArgs e)
        {
            string criterio = buscarTxtFrmColor.Text.Trim();
            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("Ingrese un ID o Nombre de color para buscar.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (int.TryParse(criterio, out int id))
                {
                    var c = ColorDAL.ObtenerPorId(id);
                    if (c != null)
                    {
                        FillFormFromEntity(c);
                        return;
                    }
                }

                // Buscar por coincidencia exacta o parcial de nombre
                var lista = ColorDAL.ObtenerTodos();
                var encontrado = lista.Find(x => !string.IsNullOrEmpty(x.color) && x.color.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                if (encontrado != null)
                {
                    FillFormFromEntity(encontrado);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún color coincidente.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpiar controles
        private void button2_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Eliminar registro por Nombre o por ID
        private void button3_Click(object sender, EventArgs e)
        {
            string q = eliminarTxtFrmColor.Text.Trim();
            if (string.IsNullOrEmpty(q))
            {
                MessageBox.Show("Ingrese un ID o Nombre para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    var lista = ColorDAL.ObtenerTodos();
                    var found = lista.Find(x => string.Equals(x.color, q, StringComparison.OrdinalIgnoreCase));
                    if (found == null)
                    {
                        MessageBox.Show("No se encontró ningún color con ese nombre para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    idToDelete = found.Id_Color;
                }

                var confirm = MessageBox.Show($"¿Confirma eliminar el color con Id={idToDelete}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;

                int rows = ColorDAL.Eliminar(idToDelete);
                if (rows > 0)
                {
                    MessageBox.Show("Color eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el color. Verifique si está en uso por algún producto.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Si el error contiene REFERENCE, significa que hay datos relacionados
                if (ex.Message.Contains("REFERENCE"))
                {
                    MessageBox.Show("No se puede eliminar este Color porque está siendo utilizado por uno o más Productos.\n\nPrimero debe cambiar o eliminar los Productos que usan este Color.", "Restricción de clave foránea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Guardar nuevo color o Modificar el existente
        private void button4_Click(object sender, EventArgs e)
        {
            string nombreColor = colorTxtFrmColor.Text.Trim();
            if (string.IsNullOrEmpty(nombreColor))
            {
                MessageBox.Show("Ingrese el nombre del color.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Limpiar espacios en blanco al parsear el id_color
                string idTexto = idColorTxtFrmColor.Text.Trim();
                if (!string.IsNullOrEmpty(idTexto) && int.TryParse(idTexto, out int idActual) && idActual > 0)
                {
                    // Actualizar color existente
                    var entidad = new ColorEntidad { Id_Color = idActual, color = nombreColor };
                    int rows = ColorDAL.Actualizar(entidad);
                    if (rows > 0)
                    {
                        MessageBox.Show("Color actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillFormFromEntity(entidad);
                    }
                    else
                    {
                        // Si no retornó filas afectadas pero no dio excepción, verificamos si de verdad existe ese ID
                        var existe = ColorDAL.ObtenerPorId(idActual);
                        if (existe == null)
                        {
                            // El ID no existe en la BD. Lo insertamos como nuevo con ese ID específico.
                            MessageBox.Show($"El ID {idActual} no existe en la base de datos. Se intentará registrar como un nuevo Color con ese ID.", "Guardar nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Insertamos directamente llamando a un Query SQL simple con el ID especificado por el usuario
                            using (System.Data.IDbConnection cn = DBComun.ObtenerConexion())
                            {
                                cn.Open();
                                using (System.Data.IDbCommand cmd = cn.CreateCommand())
                                {
                                    cmd.CommandText = "INSERT INTO [dbo].[Color] (Id_Color, Color) VALUES (@Id_Color, @Color)";
                                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@Id_Color"; p1.Value = idActual; cmd.Parameters.Add(p1);
                                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@Color"; p2.Value = nombreColor; cmd.Parameters.Add(p2);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            MessageBox.Show($"Color agregado correctamente con el Id={idActual}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillFormFromEntity(entidad);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el color. Verifique que el nombre sea diferente o que el ID exista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    // Insertar nuevo color autoincrementado (ID máximo + 1)
                    var entidad = new ColorEntidad { color = nombreColor };
                    int newId = ColorDAL.Insertar(entidad);
                    if (newId > 0)
                    {
                        entidad.Id_Color = newId;
                        FillFormFromEntity(entidad);
                        MessageBox.Show($"Color agregado correctamente con el Id={newId}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el color.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillFormFromEntity(ColorEntidad c)
        {
            if (c == null) return;
            idColorTxtFrmColor.Text = c.Id_Color.ToString();
            colorTxtFrmColor.Text = c.color ?? string.Empty;
        }

        private void ClearForm()
        {
            buscarTxtFrmColor.Clear();
            idColorTxtFrmColor.Clear();
            colorTxtFrmColor.Clear();
            eliminarTxtFrmColor.Clear();
            colorTxtFrmColor.Focus();
        }
    }
}
