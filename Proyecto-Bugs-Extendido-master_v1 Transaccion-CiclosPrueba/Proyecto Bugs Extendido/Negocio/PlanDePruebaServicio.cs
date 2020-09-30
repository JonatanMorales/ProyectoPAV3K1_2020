using Proyecto_Bugs_Extendido.Datos;
using Proyecto_Bugs_Extendido.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Bugs_Extendido.Negocio
{
    class PlanDePruebaServicio
    {
        private PlanDePruebaDao oPlanDePruebaDao = new PlanDePruebaDao();

        public IList<PlanDePrueba> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oPlanDePruebaDao.GetByFiltersSinParametros(condiciones);
        }

        public PlanDePrueba ObtenerPlanDePruebaPorID(string id)
        {
            return oPlanDePruebaDao.GetPlanDePrueba(id);
        }

        public bool CrearPlanDePrueba(PlanDePrueba oPlanDePrueba)
        {
            return oPlanDePruebaDao.Create(oPlanDePrueba);
        }

        internal bool ActualizarPlanDePrueba(PlanDePrueba oPlanDePrueba)
        {
            return oPlanDePruebaDao.Update(oPlanDePrueba);
        }

        public bool EliminarPlanDePrueba(PlanDePrueba oPlanDePrueba)
        {
            return oPlanDePruebaDao.Delete(oPlanDePrueba);
        }

        public void llenarCombos(ComboBox combo, Object source, string display, string value)
        {
            combo.DataSource = source;
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.SelectedIndex = -1;
        }

        public IList<PlanDePrueba> ObtenerTodos()
        {
            return oPlanDePruebaDao.GetAll();
        }

    }
}
