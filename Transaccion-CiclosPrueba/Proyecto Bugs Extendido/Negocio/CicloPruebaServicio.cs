using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Bugs_Extendido.Datos;
using Proyecto_Bugs_Extendido.Entidades;

namespace Proyecto_Bugs_Extendido.Negocio
{
    class CicloPruebaServicio
    {
        private CicloPruebaDao oCicloPruebaDao= new CicloPruebaDao();

        public bool Crear(CicloPrueba oCicloPrueba)
        {
            return oCicloPruebaDao.Create(oCicloPrueba);
        }
    }
}
