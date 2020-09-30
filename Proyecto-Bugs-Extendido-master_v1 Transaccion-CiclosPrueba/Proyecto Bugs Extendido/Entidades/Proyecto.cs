using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bugs_Extendido.Entidades
{
    class Proyecto
    {
        private int id_proyecto;
        private Producto oProducto;
        private string descripcion;
        private string version;
        private string alcance;
        private string borrado;
        private Usuario oUsuario;

        public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
        public Producto OProducto { get => oProducto; set => oProducto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Version { get => version; set => version = value; }
        public string Alcance { get => alcance; set => alcance = value; }
        public string Borrado { get => borrado; set => borrado = value; }
        public Usuario Responsable { get => oUsuario; set => oUsuario = value; }
    }
}
