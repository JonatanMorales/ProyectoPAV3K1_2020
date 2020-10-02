using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Entities;
using Proyecto_Bugs_Extendido.Entidades;

namespace Proyecto_Bugs_Extendido.Entidades
{
    class PlanDePrueba
    {
        private int id_plan_prueba;
        private Proyecto oProyecto;
        private string nombre;
        private Usuario oUsuario;
        private string descripcion;
        private string borrado;
        private int delete;

        public int Id_plan_prueba { get => id_plan_prueba; set => id_plan_prueba = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Usuario OUsuario { get => oUsuario; set => oUsuario = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Borrado { get => borrado; set => borrado = value; }
        internal Proyecto OProyecto { get => oProyecto; set => oProyecto = value; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
