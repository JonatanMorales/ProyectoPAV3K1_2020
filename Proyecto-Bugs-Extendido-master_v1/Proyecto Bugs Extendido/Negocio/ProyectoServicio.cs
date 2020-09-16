using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracker.Entities;
using Proyecto_Bugs_Extendido.Datos;
using Proyecto_Bugs_Extendido.Entidades;

namespace Proyecto_Bugs_Extendido.Negocio
{   
    class ProyectoServicio
    {
        private ProyectoDao oProyectoDao;
        public ProyectoServicio()
        {
            oProyectoDao = new ProyectoDao();
        }

        internal IList<Proyecto> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oProyectoDao.GetByFiltersSinParametros(condiciones);
        }

        public IList<Proyecto> ObtenerTodos()
        {
            return oProyectoDao.GetAll();
        }
        public Proyecto ObtenerProyectoPorID(String idProyecto)
        {
            return oProyectoDao.GetProyecto(idProyecto);
        }

        internal bool CrearProyecto(Proyecto oProyecto)
        {
            return oProyectoDao.Create(oProyecto);
        }

        internal bool ActualizarProyecto(Proyecto oProyecto)
        {
            return oProyectoDao.Update(oProyecto);
        }
        internal bool EliminarProyecto(Proyecto oProyecto)
        {
            return oProyectoDao.Delete(oProyecto);
        }

    }
}
