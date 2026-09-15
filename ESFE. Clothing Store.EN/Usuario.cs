using System;

namespace ESFE._Clothing_Store.EN
{
    public class Usuario
    {
        public int id_Usuario { get; set; }
        public string usuario { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public int id_Rol { get; set; }
        // Propiedad usada para mapear el estado en la base de datos
        public bool Estado { get; set; }
    }
}