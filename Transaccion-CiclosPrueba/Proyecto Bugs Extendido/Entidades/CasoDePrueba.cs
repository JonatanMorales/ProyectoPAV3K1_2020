using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bugs_Extendido.Entidades
{
    class CasoDePrueba
    {
        private int id_caso_prueba;
        private PlanDePrueba oPlanDePrueba;
        private string titulo;
        private string descripcion;
        private Usuario oUsuario;
        private string borrado;

        public int Id_caso_prueba { get => id_caso_prueba; set => id_caso_prueba = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Borrado { get => borrado; set => borrado = value; }
        public Usuario OUsuario { get => oUsuario; set => oUsuario = value; }
        public PlanDePrueba OPlanDePrueba { get => oPlanDePrueba; set => oPlanDePrueba = value; }

        public override string ToString()
        {
            return titulo;
        }
    }
}
