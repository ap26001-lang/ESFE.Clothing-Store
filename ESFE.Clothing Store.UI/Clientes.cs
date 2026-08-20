using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EN = ESFE._Clothing_Store.EN;
using ESFE._Clothing_Store.DAL;

namespace ESFE.Clothing_Store.UI
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            // Handler vacío para el evento Click del label11 desde el diseñador
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // Carga inicial si se requiere
        }

        // Buscar por Id, DUI o Telefono
        private void button1_Click(object sender, EventArgs e)
        {
            string q = buscarTxtFrmClientes.Text?.Trim();
            if (string.IsNullOrEmpty(q))
            {
                MessageBox.Show("Ingrese Id, DUI o teléfono para buscar.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Intentar buscar por id (si es número)
                if (int.TryParse(q, out int n))
                {
                    // Primero buscar por id_cliente
                    var entidad = ClientesDAL.ObtenerPorId(n);
                    if (entidad != null)
                    {
                        FillFormFromEntity(entidad);
                        return;
                    }

                    // Si no se encontró por id, buscar en todos por DUI o Telefono
                    var lista = ClientesDAL.ObtenerTodos();
                    var encontrado = lista.Find(x => x.Dui == q || x.Telefono == q);
                    if (encontrado != null)
                    {
                        FillFormFromEntity(encontrado);
                        return;
                    }
                }
                else
                {
                    // Búsqueda por nombre (coincidencia parcial, case-insensitive)
                    var lista = ClientesDAL.ObtenerTodos();
                    var encontradoPorNombre = lista.Find(x => !string.IsNullOrEmpty(x.Nombre) && x.Nombre.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0);
                    if (encontradoPorNombre != null)
                    {
                        FillFormFromEntity(encontradoPorNombre);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("No se encontró ningún cliente con ese identificador.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Agregar nuevo cliente -> llama al DAL que usa procedimientos almacenados
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var entidad = new EN.Clientes
                {
                    Nombre = nombreTxtFrmClientes.Text.Trim(),
                    Dui = duiTxtFrmClientes.Text?.Trim(),
                    Telefono = telefonoTxtFrmClientes.Text?.Trim(),
                    Correo = correoTxtFrmClientes.Text.Trim(),
                    id_rol = ParseIntOrZero(idRolTxtFrmClientes.Text),
                    id_permiso = ParseIntOrZero(idPermisoTxtFrmClientes.Text),
                    id_estado = ParseIntOrZero(idEstadoTxtFrmClientes.Text)
                };

                int newId = ClientesDAL.Insertar(entidad);
                if (newId > 0)
                {
                    FillFormFromEntity(entidad);
                    idClienteTxtFrmClientes.Text = newId.ToString();
                    MessageBox.Show($"Cliente agregado correctamente. Id={newId}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No fue posible agregar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpiar campos para agregar nuevo cliente
        private void button3_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Helper: llenar los controles con la entidad
        private void FillFormFromEntity(EN.Clientes c)
        {
            if (c == null) return;
            idClienteTxtFrmClientes.Text = c.id_cliente.ToString();
            nombreTxtFrmClientes.Text = c.Nombre ?? string.Empty;
            duiTxtFrmClientes.Text = c.Dui ?? string.Empty;
            telefonoTxtFrmClientes.Text = c.Telefono ?? string.Empty;
            correoTxtFrmClientes.Text = c.Correo ?? string.Empty;
            idRolTxtFrmClientes.Text = c.id_rol.ToString();
            idPermisoTxtFrmClientes.Text = c.id_permiso.ToString();
            idEstadoTxtFrmClientes.Text = c.id_estado.ToString();
        }

        // Helper: limpiar controles
        private void ClearForm()
        {
            buscarTxtFrmClientes.Clear();
            idClienteTxtFrmClientes.Clear();
            nombreTxtFrmClientes.Clear();
            duiTxtFrmClientes.Clear();
            telefonoTxtFrmClientes.Clear();
            correoTxtFrmClientes.Clear();
            idRolTxtFrmClientes.Clear();
            idEstadoTxtFrmClientes.Clear();
            idPermisoTxtFrmClientes.Clear();
            eliminarTxtFrmClientes.Clear();
            // Poner el foco en el campo Nombre para agregar un nuevo cliente
            nombreTxtFrmClientes.Focus();
        }

        private int ParseIntOrZero(string s)
        {
            if (int.TryParse(s, out int v)) return v;
            return 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Eliminar por id, DUI o Telefono (valor en textBox10)
            string q = eliminarTxtFrmClientes.Text?.Trim();
            if (string.IsNullOrEmpty(q))
            {
                MessageBox.Show("Ingrese Id, DUI o Teléfono para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int idToDelete = 0;

                // Si es número, usar como id
                if (int.TryParse(q, out int n))
                {
                    idToDelete = n;
                }
                else
                {
                    // Buscar en la lista por DUI o Telefono
                    var lista = ClientesDAL.ObtenerTodos();
                    var found = lista.Find(x => string.Equals(x.Dui, q, StringComparison.OrdinalIgnoreCase) || string.Equals(x.Telefono, q, StringComparison.OrdinalIgnoreCase));
                    if (found == null)
                    {
                        MessageBox.Show("No se encontró ningún cliente con ese DUI/Telefono.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    idToDelete = found.id_cliente;
                }

                var confirm = MessageBox.Show($"¿Confirma eliminar el cliente con Id={idToDelete}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;

                int rows = ClientesDAL.Eliminar(idToDelete);
                if (rows > 0)
                {
                    MessageBox.Show("Cliente eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
