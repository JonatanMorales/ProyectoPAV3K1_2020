using Proyecto_Bugs_Extendido.Entidades;
using Proyecto_Bugs_Extendido.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Bugs_Extendido.Datos
{
    class CicloPruebaDao
    {
        private int ultimoID = 0;
        internal bool Create(CicloPrueba oCicloPrueba)
        {
            DataManager dm = new DataManager();

            try
            {
                dm.Open();
                dm.BeginTransaction();

                string consultaSQL = string.Concat(
                    "INSERT INTO [dbo].[CiclosPrueba]   ",
                    "       ([fecha_inicio_ejecucion]   ",
                    "       ,[fecha_fin_ejecucion]      ",
                    "       ,[id_responsable]           ",
                    "       ,[id_plan_prueba]           ",
                    "       ,[aceptado]                 ",
                    "       ,[borrado])                 ",
                    "   VALUES                          ",
                    "       (@fecha_inicio_ejecucion    ",
                    "       ,@fecha_fin_ejecucion       ",
                    "       ,@id_responsable            ",
                    "       ,@id_plan_prueba            ",
                    "       ,@aceptado                  ",
                    "       ,@borrado)                   ");

                var parametros = new Dictionary<string, object>();
                parametros.Add("fecha_inicio_ejecucion",oCicloPrueba.Fecha_inicio_ejecucion);
                parametros.Add("fecha_fin_ejecucion",oCicloPrueba.Fecha_fin_ejecucion);
                parametros.Add("id_responsable",oCicloPrueba.OUsuario.Id_usuario);
                parametros.Add("id_plan_prueba",oCicloPrueba.OPlanDePrueba.Id_plan_prueba);
                parametros.Add("aceptado",oCicloPrueba.Aceptado);
                parametros.Add("borrado",false);
                
                dm.EjecutarSQLCONPARAMETROS(consultaSQL, parametros);

                var newId = dm.ConsultaSQLScalar("SELECT @@IDENTITY");
                oCicloPrueba.Id_ciclo_prueba = ultimoID = Convert.ToInt32(newId);

                foreach (var cicloPruebaDetalle in oCicloPrueba.ListaCicloPruebaDetalle)
                {
                    string sqlDetalle = string.Concat("   INSERT INTO [dbo].[CiclosPruebaDetalle]   ",
                                                      "         ([id_ciclo_prueba]                  ",
                                                      "         ,[id_caso_prueba]                   ",
                                                      "         ,[id_usuario_tester]                ",
                                                      "         ,[cantidad_horas]                   ",
                                                      "         ,[fecha_ejecucion]                  ",
                                                      "         ,[aceptado]                         ",
                                                      "         ,[borrado])                         ",
                                                      "   VALUES                                    ",
                                                      "         (@id_ciclo_prueba                   ",
                                                      "         ,@id_caso_prueba                    ",
                                                      "         ,@id_usuario_tester                 ",
                                                      "         ,@cantidad_horas                    ",
                                                      "         ,@fecha_ejecucion                   ",
                                                      "         ,@aceptado                          ",
                                                      "         ,@borrado)                          ");

                    var paramDetalle = new Dictionary<string, object>();
                    paramDetalle.Add("id_ciclo_prueba", oCicloPrueba.Id_ciclo_prueba);
                    paramDetalle.Add("id_caso_prueba", cicloPruebaDetalle.OCasoDePrueba.Id_caso_prueba);
                    paramDetalle.Add("id_usuario_tester",cicloPruebaDetalle.OUsuario.Id_usuario);
                    paramDetalle.Add("cantidad_horas",cicloPruebaDetalle.Cantidad_horas);
                    paramDetalle.Add("fecha_ejecucion",cicloPruebaDetalle.Fecha_ejecucion);
                    paramDetalle.Add("aceptado",cicloPruebaDetalle.Aceptado);
                    paramDetalle.Add("borrado",false);

                    dm.EjecutarSQLCONPARAMETROS(sqlDetalle, paramDetalle);
                }

                dm.Commit();
            }
            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                dm.Close();
            }
            return true;

        }

    }
}
