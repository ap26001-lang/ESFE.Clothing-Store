using System.Collections.Generic;
using ESFE._Clothing_Store.DAL;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.LN
{
    public class ColorLN
    {
        public int Insertar(Color entidad)
        {
            return ColorDAL.Insertar(entidad);
        }

        public int Actualizar(Color entidad)
        {
            return ColorDAL.Actualizar(entidad);
        }

        public int Eliminar(int idColor)
        {
            return ColorDAL.Eliminar(idColor);
        }

        public List<Color> ObtenerTodos()
        {
            return ColorDAL.ObtenerTodos();
        }

        public Color ObtenerPorId(int idColor)
        {
            return ColorDAL.ObtenerPorId(idColor);
        }
    }
}

