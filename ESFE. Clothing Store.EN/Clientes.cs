using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE._Clothing_Store.EN
{
    public class Clientes
    {
        public int id_cliente { get; set; }
        public string Nombre { get; set; }
        public int Dui { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public int id_rol { get; set; }
        public int id_permiso { get; set; }
        public int id_estado { get; set; }
    }
}
