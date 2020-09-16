using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Bugs_Extendido.Datos;
using Proyecto_Bugs_Extendido.Entidades;

namespace Proyecto_Bugs_Extendido.Negocio
{
    class ProductoServicio
    {
        private ProductoDao oProductoDao;
        public ProductoServicio()
        {
            this.oProductoDao = new ProductoDao();
        }
        public IList<Producto> ObtenerTodos()
        {
            return oProductoDao.GetAll();
        }
    }
}
