using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE._Clothing_Store.EN
{
    public class Ventas
    {
        public string Codigo_de_Venta { get; set; }
        public DateTime Fecha_y_Hora { get; set; } = DateTime.Now;
        public int Cantidad_de_productos { get; set; }
        public int id_Tipo_Producto { get; set; }
        public int id_cliente { get; set; }
    }...
}
