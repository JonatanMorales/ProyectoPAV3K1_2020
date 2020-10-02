using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bugs_Extendido.Entidades
{
    class CicloPrueba
    {
        private int id_ciclo_prueba;
        private DateTime fecha_inicio_ejecucion;
        private DateTime fecha_fin_ejecucion;
        private Usuario oUsuario;
        private PlanDePrueba oPlanDePrueba;
        private string aceptado;
        private string borrado;
        private List<CicloPruebaDetalle> listaCicloPruebaDetalle;

        public int Id_ciclo_prueba { get => id_ciclo_prueba; set => id_ciclo_prueba = value; }
        public DateTime Fecha_inicio_ejecucion { get => fecha_inicio_ejecucion; set => fecha_inicio_ejecucion = value; }
        public DateTime Fecha_fin_ejecucion { get => fecha_fin_ejecucion; set => fecha_fin_ejecucion = value; }
        public Usuario OUsuario { get => oUsuario; set => oUsuario = value; }
        public PlanDePrueba OPlanDePrueba { get => oPlanDePrueba; set => oPlanDePrueba = value; }
        public string Aceptado { get => aceptado; set => aceptado = value; }
        public string Borrado { get => borrado; set => borrado = value; }
        internal List<CicloPruebaDetalle> ListaCicloPruebaDetalle { get => listaCicloPruebaDetalle; set => listaCicloPruebaDetalle = value; }
    }
}
