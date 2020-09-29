using BugTracker;
using BugTracker.Entities;
using Proyecto_Bugs_Extendido.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Bugs_Extendido.Datos
{
    class PlanDePruebaDao
    {
        public List<PlanDePrueba> GetByFiltersSinParametros(String condiciones)
        {
            List<PlanDePrueba> lista = new List<PlanDePrueba>();
            string consultaSQL = string.Concat(
                "SELECT pdp.id_plan_prueba,pdp.nombre,pdp.descripcion,pdp.borrado,py.id_proyecto,u.id_usuario,u.usuario" +
                " FROM PlanesDePrueba pdp,Proyectos py, Usuarios u" +
                " where pdp.id_proyecto=py.id_proyecto and pdp.id_responsable=u.id_usuario AND pdp.borrado=0");

            consultaSQL += condiciones;

            var resultado=DBHelper.GetDBHelper().ConsultaSQL(consultaSQL);
            foreach (DataRow row in resultado.Rows)
            {
                lista.Add(ObjectMapping(row));
            }

            return lista;
        }

        private PlanDePrueba ObjectMapping(DataRow row)
        {
            PlanDePrueba oPlanDePrueba = new PlanDePrueba
            {
                Id_plan_prueba = Convert.ToInt32(row["id_plan_prueba"].ToString()),
                Nombre = row["nombre"].ToString(),
                Descripcion = row["descripcion"].ToString(),
                OProyecto = new Proyecto
                {
                    Id_proyecto = Convert.ToInt32(row["id_proyecto"].ToString())
                },
                Borrado = row["borrado"].ToString(),
                OUsuario = new Usuario
                {
                    Id_usuario = Convert.ToInt32(row["id_usuario"].ToString()),
                    NombreUsuario = row["usuario"].ToString()
                }
            };
            return oPlanDePrueba;
        }

        public PlanDePrueba GetPlanDePrueba(string idPlanDePrueba)
        {
            string consultaSQL = string.Concat(
                "SELECT pdp.id_plan_prueba,pdp.nombre,pdp.descripcion,pdp.borrado,py.id_proyecto,u.id_usuario,u.usuario" +
                " FROM PlanesDePrueba pdp,Proyectos py, Usuarios u" +
                " where pdp.id_proyecto=py.id_proyecto and pdp.id_responsable=u.id_usuario AND pdp.borrado=0");

            consultaSQL += " AND pdp.id_plan_prueba=" + idPlanDePrueba;

            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSQL);

            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }
        public bool Create(PlanDePrueba oPlanDePrueba)
        {
            string consultaSQL = "INSERT INTO PlanesDePrueba (id_proyecto,nombre,id_responsable,descripcion,borrado)" +
                                 " VALUES (" +
                                 oPlanDePrueba.OProyecto.Id_proyecto + ",'" +
                                 oPlanDePrueba.Nombre + "'," +
                                 oPlanDePrueba.OUsuario.Id_usuario + ",'" +
                                 oPlanDePrueba.Descripcion + "',0)";

            return (DBHelper.GetDBHelper().EjecutarSQL(consultaSQL) == 1);
        }

        public bool Update(PlanDePrueba oPlanDePrueba)
        {
            string consultaSQL = "UPDATE PlanesDePrueba" +
                                 " SET id_proyecto =" + oPlanDePrueba.OProyecto.Id_proyecto + "," +
                                 "nombre = '" + oPlanDePrueba.Nombre + "'," +
                                 "id_responsable =" + oPlanDePrueba.OUsuario.Id_usuario + "," +
                                 "descripcion = '" + oPlanDePrueba.Descripcion + "'"+
                                 " WHERE id_plan_prueba =" + oPlanDePrueba.Id_plan_prueba+" AND borrado=0"
                                 ;

            return (DBHelper.GetDBHelper().EjecutarSQL(consultaSQL) == 1);
        }
        public bool Delete(PlanDePrueba oPlanDePrueba)
        {
            string consultaSQL = "UPDATE PlanesDePrueba" +
                                 " SET borrado=1"+
                                 " WHERE id_plan_prueba =" + oPlanDePrueba.Id_plan_prueba;

            return (DBHelper.GetDBHelper().EjecutarSQL(consultaSQL) == 1);
        }

    }
}
