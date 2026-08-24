using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESFE._Clothing_Store.DAL;
using BitacoraEntidad = ESFE._Clothing_Store.EN.Bitacora;

namespace ESFE.Clothing_Store.UI
{
    public partial class    Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        // Buscar por ID de usuario
        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(buscarUsuarioTxtFrmBitacora.Text.Trim(), out int idUsuario))
            {
                MessageBox.Show("Ingrese un ID 8de usuario válido.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var lista = BitacoraDAL.ObtenerPorUsuario(idUsuario);
                if (lista.Count > 0)
                {
                    var registro = lista[0];
                    FillFormFromEntity(registro);
                }
                else
                {
                    MessageBox.Show("No se encontraron registros para ese usuario.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpiar formulario
        private void button2_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Agregar nuevo registro a la bitácora
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(idUsuarioTxtFrmBitacora.Text.Trim(), out int idUsuario))
                {
                    MessageBox.Show("Ingrese un ID de usuario válido.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var entidad = new BitacoraEntidad
                {
                    Accion = accionTxtFrmBitacora.Text.Trim(),
                    Id_Usuario = idUsuario,
                    Fecha_y_hora = DateTime.Now
                };

                int newId = BitacoraDAL.Insertar(entidad);
                if (newId > 0)
                {
                    entidad.id_actividad = newId;
                    FillFormFromEntity(entidad);
                    MessageBox.Show($"Registro agregado correctamente. Id={newId}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No fue posible agregar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ver lista completa de registros (Admin)
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = BitacoraDAL.ObtenerTodos();
                if (lista.Count == 0)
                {
                    MessageBox.Show("No hay registros en la bitácora.", "Ver lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var sb = new StringBuilder();
                foreach (var item in lista)
                {
                    sb.AppendLine($"Id={item.id_actividad} | Usuario={item.Id_Usuario} | Accion={item.Accion} | Fecha={item.Fecha_y_hora}");
                }

                MessageBox.Show(sb.ToString(), "Bitácora - Todos los registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la lista: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eliminar registro por ID Actividad
        private void button5_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(idActividadTxtFrmBitacora.Text.Trim(), out int idActividad))
            {
                MessageBox.Show("Ingrese un ID Actividad válido para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show($"¿Confirma eliminar el registro Id={idActividad}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                int rows = BitacoraDAL.Eliminar(idActividad);
                if (rows > 0)
                {
                    MessageBox.Show("Registro eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("No se eliminó ningún registro. Verifique el Id.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper: llenar los controles con la entidad
        private void FillFormFromEntity(BitacoraEntidad b)
        {
            if (b == null) return;
            idActividadTxtFrmBitacora.Text = b.id_actividad.ToString();
            accionTxtFrmBitacora.Text = b.Accion ?? string.Empty;
            idUsuarioTxtFrmBitacora.Text = b.Id_Usuario.ToString();
            fechaHoraTxtFrmBitacora.Text = b.Fecha_y_hora.ToString();
        }

        // Helper: limpiar controles
        private void ClearForm()
        {
            buscarUsuarioTxtFrmBitacora.Clear();
            idActividadTxtFrmBitacora.Clear();
            accionTxtFrmBitacora.Clear();
            idUsuarioTxtFrmBitacora.Clear();
            fechaHoraTxtFrmBitacora.Clear();
        }
    }
}
