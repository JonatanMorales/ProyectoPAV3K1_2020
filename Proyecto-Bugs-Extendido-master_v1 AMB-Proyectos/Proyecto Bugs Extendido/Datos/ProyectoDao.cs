using BugTracker;
using BugTracker.Entities;
using Proyecto_Bugs_Extendido.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bugs_Extendido.Datos
{
    class ProyectoDao
    {
        public IList<Proyecto> GetByFiltersSinParametros(String condiciones)
        {
            List<Proyecto> lst = new List<Proyecto>();
            String consultaSQL = string.Concat(
                "SELECT py.id_proyecto,py.id_producto,py.descripcion,py.version,py.alcance,py.id_responsable,py.borrado,pd.id_producto,pd.nombre as producto,u.id_usuario,u.usuario as responsable" +
                " FROM Proyectos py,Productos pd ,Usuarios u" +
                " WHERE py.id_producto=pd.id_producto and py.id_responsable=u.id_usuario and py.borrado='0'");
            
            consultaSQL += condiciones;

            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSQL);

            foreach (DataRow row in resultado.Rows) 
            {
                lst.Add(ObjectMapping(row));
            }

            return lst;
        }

        private Proyecto ObjectMapping(DataRow row)
        {
            Proyecto oProyecto = new Proyecto
            {
                Id_proyecto = Convert.ToInt32(row["id_proyecto"].ToString()),
                Id_producto = Convert.ToInt32(row["id_producto"].ToString()),
                Descripcion = row["descripcion"].ToString(),
                Version = row["version"].ToString(),
                Alcance = row["alcance"].ToString(),
                Responsable = Convert.ToInt32(row["id_responsable"].ToString()),
                Borrado = row["borrado"].ToString(),
                OProducto = new Producto()
                {
                    Id_producto = Convert.ToInt32(row["id_producto"].ToString()),
                    Nombre = row["producto"].ToString(),
                },
                OUsuario = new Usuario()
                {
                    Id_usuario = Convert.ToInt32(row["id_usuario"].ToString()),
                    Nusuario = row["responsable"].ToString(),
                }
            };

            return oProyecto;
        }

        public IList<Proyecto> GetAll()
        {
            List<Proyecto> lst = new List<Proyecto>();
            String consultaSQL = string.Concat(
                "SELECT py.id_proyecto,py.id_producto,py.descripcion,py.version,py.alcance,py.id_responsable,py.borrado,pd.id_producto,pd.nombre as producto,u.id_usuario,u.usuario as responsable" +
                " FROM Proyectos py,Productos pd ,Usuarios u" +
                " WHERE py.id_producto=pd.id_producto and py.id_responsable=u.id_usuario and py.borrado ='0'");

            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSQL);

            foreach (DataRow row in resultado.Rows)
            {
                lst.Add(ObjectMapping(row));
            }

            return lst;
        }

        public bool Create(Proyecto oProyecto)
        {
            //La base de datos tiene id_proyecto autoincremental
            string consultaSQL ="INSERT INTO Proyectos (id_producto,descripcion,version,alcance,id_responsable,borrado)"+
                                " VALUES ("+
                                oProyecto.Id_producto+",'"+
                                oProyecto.Descripcion+"','"+
                                oProyecto.Version+"','"+
                                oProyecto.Alcance+"',"+
                                oProyecto.Responsable+",'0')";
            return (DBHelper.GetDBHelper().EjecutarSQL(consultaSQL)==1);
        }

        public bool Update(Proyecto oProyecto)
        {
            string consultaSQL ="UPDATE Proyectos" +
                                " SET id_producto = "+oProyecto.Id_producto+","+
                                "descripcion = '"+oProyecto.Descripcion+"',"+
                                "version = '"+oProyecto.Version+"',"+
                                "alcance = '"+oProyecto.Alcance+"',"+
                                "id_responsable = "+oProyecto.Responsable+
                                " where id_proyecto = "+oProyecto.Id_proyecto+" AND borrado = '0'";

            return (DBHelper.GetDBHelper().EjecutarSQL(consultaSQL) == 1);
        }

        public bool Delete(Proyecto oProyecto)
        {
            string consultaSQL ="UPDATE Proyectos" +
                                " set borrado='1'"+
                                " where id_proyecto = " + oProyecto.Id_proyecto + " AND borrado = '0'";
            return (DBHelper.GetDBHelper().EjecutarSQL(consultaSQL) == 1);
        }


        public Proyecto GetProyecto(string idProyecto)
        {
            String consultaSQL = string.Concat(
                "SELECT py.id_proyecto,py.id_producto,py.descripcion,py.version,py.alcance,py.id_responsable,py.borrado,pd.id_producto,pd.nombre as producto,u.id_usuario,u.usuario as responsable" +
                " FROM Proyectos py,Productos pd ,Usuarios u" +
                " WHERE py.id_producto=pd.id_producto and py.id_responsable=u.id_usuario and py.borrado ='0'");

            consultaSQL += " AND py.id_proyecto=" + "'" + idProyecto + "'";

            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSQL);

            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }


    }
}
