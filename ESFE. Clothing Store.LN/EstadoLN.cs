using System.Collections.Generic;
using ESFE._Clothing_Store.DAL;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.LN
{
    public class EstadoLN
    {
        public int Insertar(Estado entidad)
        {
            return EstadoDAL.Insertar(entidad);
        }

        public int Actualizar(Estado entidad)
        {
            return EstadoDAL.Actualizar(entidad);
        }

        public int Eliminar(int idEstado)
        {
            return EstadoDAL.Eliminar(idEstado);
        }

        public List<Estado> ObtenerTodos()
        {
            return EstadoDAL.ObtenerTodos();
        }

        public Estado ObtenerPorId(int idEstado)
        {
            return EstadoDAL.ObtenerPorId(idEstado);
        }
    }
}
