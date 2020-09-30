using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bugs_Extendido.Entidades
{
    class CicloPruebaDetalle
    {
        private int id_ciclo_prueba_detalle;
        private CicloPrueba oCicloPrueba;//id_ciclo_prueba
        private CasoDePrueba oCasoDePrueba;//id_caso_prueba
        private Usuario oUsuario;//id_usuario_tester
        private int cantidad_horas;
        private DateTime fecha_ejecucion;
        private string aceptado;
        private string borrado;

        public int Id_ciclo_prueba_detalle { get => id_ciclo_prueba_detalle; set => id_ciclo_prueba_detalle = value; }
        internal CicloPrueba OCicloPrueba { get => oCicloPrueba; set => oCicloPrueba = value; }
        internal CasoDePrueba OCasoDePrueba { get => oCasoDePrueba; set => oCasoDePrueba = value; }
        public Usuario OUsuario { get => oUsuario; set => oUsuario = value; }
        public int Cantidad_horas { get => cantidad_horas; set => cantidad_horas = value; }
        public DateTime Fecha_ejecucion { get => fecha_ejecucion; set => fecha_ejecucion = value; }
        public string Aceptado { get => aceptado; set => aceptado = value; }
        public string Borrado { get => borrado; set => borrado = value; }
        
    }
}
