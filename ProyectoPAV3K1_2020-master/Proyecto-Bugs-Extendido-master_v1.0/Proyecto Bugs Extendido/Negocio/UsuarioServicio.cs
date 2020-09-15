using BugTracker.Entities;
using Proyecto_Bugs_Extendido.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bugs_Extendido.Negocio
{
    class UsuarioServicio
    {
        private UsuarioDao oUsuarioDao;
        public UsuarioServicio()
        {
            oUsuarioDao = new UsuarioDao();
        }
        public IList<Usuario> ObtenerTodos()
        {
            return oUsuarioDao.GetAll();
        }


    }
}
