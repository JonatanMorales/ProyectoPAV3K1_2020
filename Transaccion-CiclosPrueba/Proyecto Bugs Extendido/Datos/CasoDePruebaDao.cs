using BugTracker;
using BugTracker.Entities;
using Proyecto_Bugs_Extendido.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bugs_Extendido.Datos
{
    class CasoDePruebaDao
    {
        public List<CasoDePrueba> GetByFiltersSinParametros(String condiciones)
        {
            List<CasoDePrueba> lista = new List<CasoDePrueba>();
            string consultaSQL = string.Concat(
                "SELECT cp.id_caso_prueba,cp.id_plan_prueba,cp.titulo,cp.descripcion,cp.id_responsable,cp.borrado,pp.nombre,u.usuario" +
                " FROM CasosDePrueba cp, PlanesDePrueba pp,Usuarios u" +
                " WHERE cp.id_plan_prueba=pp.id_plan_prueba AND cp.id_responsable=u.id_usuario AND cp.borrado=0");

            consultaSQL += condiciones;

            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSQL);
            foreach (DataRow row in resultado.Rows)
            {
                lista.Add(ObjectMapping(row));
            }

            return lista;
        }

        private CasoDePrueba ObjectMapping(DataRow row)
        {
            CasoDePrueba oCasoDePrueba = new CasoDePrueba
            {
                Id_caso_prueba = (int)row["id_caso_prueba"],

                OPlanDePrueba = new PlanDePrueba
                {
                    Id_plan_prueba = (int)row["id_plan_prueba"],
                    Nombre = row["nombre"].ToString()
                },
                Titulo = row["titulo"].ToString(),
                Descripcion = row["descripcion"].ToString(),

                OUsuario = new Usuario
                { 
                    Id_usuario=(int)row["id_responsable"],
                    NombreUsuario=row["usuario"].ToString()
                },
                Borrado = row["borrado"].ToString()
            };
            return oCasoDePrueba;
        }

    }
}
