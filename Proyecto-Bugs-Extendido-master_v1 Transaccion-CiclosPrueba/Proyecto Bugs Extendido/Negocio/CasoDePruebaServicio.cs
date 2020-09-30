using Proyecto_Bugs_Extendido.Datos;
using Proyecto_Bugs_Extendido.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bugs_Extendido.Negocio
{
    class CasoDePruebaServicio
    {
        private CasoDePruebaDao oCasoDePruebaDao = new CasoDePruebaDao();
        public IList<CasoDePrueba> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oCasoDePruebaDao.GetByFiltersSinParametros(condiciones);
        }

    }
}
