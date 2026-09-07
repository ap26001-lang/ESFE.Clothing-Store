using System;
using System.Windows.Forms;

namespace ESFE.Clothing_Store.UI
{
    public static class ValidadorCampos
    {
        /// <summary>
        /// Valida que el campo no esté vacío
        /// </summary>
        public static bool ValidarNoVacio(string valor, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                MessageBox.Show($"{nombreCampo} no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida que el campo contenga solo letras
        /// </summary>
        public static bool ValidarSoloLetras(string valor, string nombreCampo)
        {
            if (!ValidarNoVacio(valor, nombreCampo)) return false;

            foreach (char c in valor)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show($"{nombreCampo} solo puede contener letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Valida que el campo contenga solo números
        /// </summary>
        public static bool ValidarSoloNumeros(string valor, string nombreCampo)
        {
            if (!ValidarNoVacio(valor, nombreCampo)) return false;

            if (!int.TryParse(valor, out int resultado))
            {
                MessageBox.Show($"{nombreCampo} solo puede contener números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida que el número esté en un rango
        /// </summary>
        public static bool ValidarRango(string valor, string nombreCampo, int minimo, int maximo)
        {
            if (!ValidarSoloNumeros(valor, nombreCampo)) return false;

            int numero = int.Parse(valor);
            if (numero < minimo || numero > maximo)
            {
                MessageBox.Show($"{nombreCampo} debe estar entre {minimo} y {maximo}.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida que sea un número decimal válido
        /// </summary>
        public static bool ValidarDecimal(string valor, string nombreCampo)
        {
            if (!ValidarNoVacio(valor, nombreCampo)) return false;

            if (!decimal.TryParse(valor, out decimal resultado))
            {
                MessageBox.Show($"{nombreCampo} debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida que el número sea mayor a cero
        /// </summary>
        public static bool ValidarMayorQueCero(string valor, string nombreCampo)
        {
            if (!ValidarDecimal(valor, nombreCampo)) return false;

            decimal numero = decimal.Parse(valor);
            if (numero <= 0)
            {
                MessageBox.Show($"{nombreCampo} debe ser mayor que cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida un correo electrónico
        /// </summary>
        public static bool ValidarCorreo(string valor, string nombreCampo)
        {
            if (!ValidarNoVacio(valor, nombreCampo)) return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(valor);
                return addr.Address == valor;
            }
            catch
            {
                MessageBox.Show($"{nombreCampo} debe ser un correo válido (ej: usuario@dominio.com).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        /// <summary>
        /// Valida un teléfono (números y guiones)
        /// </summary>
        public static bool ValidarTelefono(string valor, string nombreCampo)
        {
            if (!ValidarNoVacio(valor, nombreCampo)) return false;

            foreach (char c in valor)
            {
                if (!char.IsDigit(c) && c != '-' && c != ' ')
                {
                    MessageBox.Show($"{nombreCampo} solo puede contener números, guiones y espacios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Valida longitud mínima
        /// </summary>
        public static bool ValidarLongitudMinima(string valor, string nombreCampo, int minimo)
        {
            if (!ValidarNoVacio(valor, nombreCampo)) return false;

            if (valor.Length < minimo)
            {
                MessageBox.Show($"{nombreCampo} debe tener al menos {minimo} caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida longitud máxima
        /// </summary>
        public static bool ValidarLongitudMaxima(string valor, string nombreCampo, int maximo)
        {
            if (!ValidarNoVacio(valor, nombreCampo)) return false;

            if (valor.Length > maximo)
            {
                MessageBox.Show($"{nombreCampo} no puede exceder {maximo} caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida longitud exacta
        /// </summary>
        public static bool ValidarLongitudExacta(string valor, string nombreCampo, int longitud)
        {
            if (!ValidarNoVacio(valor, nombreCampo)) return false;

            if (valor.Length != longitud)
            {
                MessageBox.Show($"{nombreCampo} debe tener exactamente {longitud} caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida que dos campos sean iguales (para contraseña)
        /// </summary>
        public static bool ValidarCoincidencia(string valor1, string valor2, string nombreCampo)
        {
            if (valor1 != valor2)
            {
                MessageBox.Show($"Los campos de {nombreCampo} no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida DUI (formato El Salvador: 00000000-0)
        /// </summary>
        public static bool ValidarDUI(string valor, string nombreCampo)
        {
            if (!ValidarNoVacio(valor, nombreCampo)) return false;

            // DUI debe tener formato: 8 dígitos - 1 dígito (00000000-0)
            if (valor.Length != 10 || valor[8] != '-')
            {
                MessageBox.Show($"{nombreCampo} debe tener formato DUI válido (00000000-0).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que los primeros 8 sean dígitos
            for (int i = 0; i < 8; i++)
            {
                if (!char.IsDigit(valor[i]))
                {
                    MessageBox.Show($"{nombreCampo} debe tener formato DUI válido (00000000-0).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // Validar que el último sea dígito
            if (!char.IsDigit(valor[9]))
            {
                MessageBox.Show($"{nombreCampo} debe tener formato DUI válido (00000000-0).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valida que no haya caracteres especiales no permitidos
        /// </summary>
        public static bool ValidarSinCaracteresEspeciales(string valor, string nombreCampo)
        {
            if (!ValidarNoVacio(valor, nombreCampo)) return false;

            foreach (char c in valor)
            {
                if (!char.IsLetterOrDigit(c) && c != ' ' && c != '_' && c != '-')
                {
                    MessageBox.Show($"{nombreCampo} contiene caracteres no permitidos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
    }
}
