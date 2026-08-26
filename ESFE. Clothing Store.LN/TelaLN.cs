using System.Collections.Generic;
using ESFE.Clothing_Store.DAL;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.LN
{
    public class TelaLN
    {
        public int Insertar(Tela entidad)
        {
            return TelaDal.Insertar(entidad);
        }

        public int Actualizar(Tela entidad)
        {
            return TelaDal.Actualizar(entidad);
        }

        public int Eliminar(int idTela)
        {
            return TelaDal.Eliminar(idTela);
        }

        public List<Tela> ObtenerTodos()
        {
            return TelaDal.ObtenerTodos();
        }

        public Tela ObtenerPorId(int idTela)
        {
            return TelaDal.ObtenerPorId(idTela);
        }
    }
}
