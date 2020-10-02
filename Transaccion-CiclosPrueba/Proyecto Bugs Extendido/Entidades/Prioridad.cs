using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bugs_Extendido.Entidades
{
    class Prioridad
    {
        private int id;
        private string nombre;
        private string borrado;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Borrado { get => borrado; set => borrado = value; }
    }
}
