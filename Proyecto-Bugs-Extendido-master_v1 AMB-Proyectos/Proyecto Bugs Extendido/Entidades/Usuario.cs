using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    public class Usuario
    {
        private int id_usuario;
        private int id_perfil;
        private string usuario;
        private string password;
        private string email;
        private string estado;
        private int borrado;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_perfil { get => id_perfil; set => id_perfil = value; }
        public string Nusuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Borrado { get => borrado; set => borrado = value; }

        public override string ToString()
        {
            return Nusuario;
        }
    }
}
