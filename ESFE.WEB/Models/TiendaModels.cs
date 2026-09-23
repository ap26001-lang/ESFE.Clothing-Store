using System;

namespace ESFE.Clothing_Store_limpio.Models
{
    public class Producto
    {
        public string Codigo_Produc { get; set; }
        public string Nombre_Produc { get; set; }
        public decimal Precio { get; set; }
        public int id_Tipo_Produc { get; set; }
        public int id_tallas { get; set; }
        public int id_Tela { get; set; }
        public int id_Color { get; set; }

        // Propiedades auxiliares para mostrar nombres en la tabla
        public string NombreTipoProducto { get; set; }
        public string NombreTalla { get; set; }
        public string NombreTela { get; set; }
        public string NombreColor { get; set; }
    }

    public class Talla
    {
        public int id_tallas { get; set; }
        public string Talla_Producto { get; set; }
    }

    public class TipoProducto
    {
        public int id_Tipo_Produc { get; set; }
        public string Tipo_de_producto { get; set; }
    }

    public class Tela
    {
        public int Id_Tela { get; set; }
        public string Tipo_de_tela { get; set; }
    }

    public class ColorModel
    {
        public int Id_Color { get; set; }
        public string Color { get; set; }
    }

    public class Cliente
    {
        public int id_cliente { get; set; }
        public string Nombre { get; set; }
        public string DUI { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int? id_rol { get; set; }
        public int? id_permiso { get; set; }
        public int? id_estado { get; set; }
    }

    public class Bitacora
    {
        public int id_actividad { get; set; }
        public string Accion { get; set; }
        public int Id_Usuario { get; set; }
        public DateTime Fecha_y_hora { get; set; }
    }
}
