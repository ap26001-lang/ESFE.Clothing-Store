using System.Collections.Generic;
using ESFE._Clothing_Store.DAL;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.LN
{
    public class TallasLN
    {
        public int Insertar(Tallas entidad)
        {
            return TallasDal.Insertar(entidad);
        }

        public int Actualizar(Tallas entidad)
        {
            return TallasDal.Actualizar(entidad);
        }

        public int Eliminar(int idTallas)
        {
            return TallasDal.Eliminar(idTallas);
        }

        public List<Tallas> ObtenerTodos()
        {
            return TallasDal.ObtenerTodos();
        }

        public Tallas ObtenerPorId(int idTallas)
        {
            return TallasDal.ObtenerPorId(idTallas);
        }
    }
}
