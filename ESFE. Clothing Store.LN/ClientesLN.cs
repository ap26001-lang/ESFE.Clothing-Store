using System.Collections.Generic;
using ESFE._Clothing_Store.DAL;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.LN
{
    public class ClientesLN
    {
        public int Insertar(Clientes entidad)
        {
            return ClientesDAL.Insertar(entidad);
        }

        public int Actualizar(Clientes entidad)
        {
            return ClientesDAL.Actualizar(entidad);
        }

        public int Eliminar(int idCliente)
        {
            return ClientesDAL.Eliminar(idCliente);
        }

        public List<Clientes> ObtenerTodos()
        {
            return ClientesDAL.ObtenerTodos();
        }

        public Clientes ObtenerPorId(int idCliente)
        {
            return ClientesDAL.ObtenerPorId(idCliente);
        }
    }
}
