using BugTracker.Entities;
using Proyecto_Bugs_Extendido.Entidades;
using Proyecto_Bugs_Extendido.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Proyecto_Bugs_Extendido.Negocio;

namespace Proyecto_Bugs_Extendido.Presentacion
{
    public partial class frmCiclosDePrueba : Form
    {
        private PlanDePruebaServicio oPlanDePruebaServicio;
        private UsuarioServicio oUsuarioServicio;
        private ProyectoServicio oProyectoServicio;
        private CasoDePruebaServicio oCasoDePruebaServicio;
        private List<CicloPruebaDetalle> listaDetalle;
        private CicloPrueba oCicloPrueba;
        public frmCiclosDePrueba()
        {
            InitializeComponent();
            oPlanDePruebaServicio = new PlanDePruebaServicio();
            oUsuarioServicio = new UsuarioServicio();
            oProyectoServicio = new ProyectoServicio();
            oCasoDePruebaServicio = new CasoDePruebaServicio();
            listaDetalle = new List<CicloPruebaDetalle>();
            oCicloPrueba = new CicloPrueba();
        }
        private void frmCiclosDePrueba_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Today;
            LlenarCombo(cboNombreResponsable, oUsuarioServicio.ObtenerTodos(), "NombreUsuario", "Id_usuario");
            LlenarCombo(cboNombreTester, oUsuarioServicio.ObtenerTodos(), "NombreUsuario", "Id_usuario");
            LlenarCombo(cboNombrePlan, oPlanDePruebaServicio.ObtenerTodos(), "Nombre", "Id_plan_prueba");
            btnAgregarDetalle.Enabled = false;
            gbCasoDePrueba.Enabled = false;
            
        }
        
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNuevoCdP_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboNombrePlan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboNombrePlan.SelectedIndex != -1)
            {
                List<Proyecto> lista = new List<Proyecto>();
                lista.Add(oProyectoServicio.ObtenerProyectoPorID(oPlanDePruebaServicio.ObtenerPlanDePruebaPorID(cboNombrePlan.SelectedValue.ToString()).OProyecto.Id_proyecto.ToString()));
                loadGrid(grdProyecto, lista);
                gbCasoDePrueba.Enabled = true;

                string consultaSQL = " AND cp.id_plan_prueba="+cboNombrePlan.SelectedValue;
                LlenarCombo(cboTituloCaso,oCasoDePruebaServicio.ConsultarConFiltrosSinParametros(consultaSQL), "Titulo", "Id_caso_prueba");
            }
        }

        private void loadGrid(DataGridView grilla, IList<Proyecto> lista)
        {
            grilla.Rows.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                grilla.Rows.Add(
                    lista[i].Id_proyecto,
                    lista[i].Descripcion,
                    lista[i].Version,
                    lista[i].Responsable.NombreUsuario,
                    lista[i].OProducto.Nombre
                    );
            }
        }

        private void cboTituloCaso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboTituloCaso.SelectedIndex != -1)
                btnAgregarDetalle.Enabled = true;
        }

        private void cboNombreResponsable_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboNombreResponsable.SelectedIndex != -1)
                txtIdResponsable.Text = cboNombreResponsable.SelectedValue.ToString();
        }

        private void cboNombreTester_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboNombreTester.SelectedIndex != -1)
                txtIdTester.Text = cboNombreTester.SelectedValue.ToString();
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            CicloPruebaDetalle oCicloPruebaDetalle = new CicloPruebaDetalle();

            oCicloPruebaDetalle.OCicloPrueba.Id_ciclo_prueba = oCicloPrueba.Id_ciclo_prueba;//Ciclo de prueba, dueña de los detalles
            oCicloPruebaDetalle.OCasoDePrueba = new CasoDePrueba();//caso de prueba del detalle
            oCicloPruebaDetalle.OCasoDePrueba.Id_caso_prueba = (int)cboTituloCaso.SelectedValue;
            oCicloPruebaDetalle.OUsuario = new Usuario();//usuario tester
            oCicloPruebaDetalle.OUsuario.Id_usuario = (int)cboNombreTester.SelectedValue;
            oCicloPruebaDetalle.Fecha_ejecucion = dtpFechaEjecucion.Value;//fechaDeEjecución

            listaDetalle.Add(oCicloPruebaDetalle);



        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
        
        }
    }
}
