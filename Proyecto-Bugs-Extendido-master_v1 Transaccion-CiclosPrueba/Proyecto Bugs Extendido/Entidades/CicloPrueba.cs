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
        private string fecha_inicio_ejecucion;
        private string fecha_fin_ejecucion;
        private int id_responsable;
        private int id_plan_prueba;
        private string aceptado;
        private string borrado;

        public int Id_ciclo_prueba { get => id_ciclo_prueba; set => id_ciclo_prueba = value; }
        public string Fecha_inicio_ejecucion { get => fecha_inicio_ejecucion; set => fecha_inicio_ejecucion = value; }
        public string Fecha_fin_ejecucion { get => fecha_fin_ejecucion; set => fecha_fin_ejecucion = value; }
        public int Id_responsable { get => id_responsable; set => id_responsable = value; }
        public int Id_plan_prueba { get => id_plan_prueba; set => id_plan_prueba = value; }
        public string Aceptado { get => aceptado; set => aceptado = value; }
        public string Borrado { get => borrado; set => borrado = value; }
    }
}
