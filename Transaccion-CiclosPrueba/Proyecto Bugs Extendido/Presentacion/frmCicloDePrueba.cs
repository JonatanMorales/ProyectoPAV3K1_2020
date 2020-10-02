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
using System.Web.UI.Design;
using System.Windows.Forms;

namespace Proyecto_Bugs_Extendido.Presentacion
{
    public partial class frmCicloDePrueba : Form
    {
        private PlanDePruebaServicio oPlanDePruebaServicio;
        private UsuarioServicio oUsuarioServicio;
        private ProyectoServicio oProyectoServicio;
        private CasoDePruebaServicio oCasoDePruebaServicio;
        private CicloPruebaServicio oCicloPruebaServicio;
        private CicloPrueba oCicloPrueba;
        public frmCicloDePrueba()
        {
            InitializeComponent();
            oPlanDePruebaServicio = new PlanDePruebaServicio();
            oUsuarioServicio = new UsuarioServicio();
            oProyectoServicio = new ProyectoServicio();
            oCasoDePruebaServicio = new CasoDePruebaServicio();
            oCicloPruebaServicio = new CicloPruebaServicio();
            oCicloPrueba = new CicloPrueba();
        }
        private void frmCiclosDePrueba_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaFin.Value = DateTime.Today;
            LlenarCombo(cboNombreResponsable, oUsuarioServicio.ObtenerTodos(), "NombreUsuario", "Id_usuario");
            LlenarCombo(cboNombreTester, oUsuarioServicio.ObtenerTodos(), "NombreUsuario", "Id_usuario");
            LlenarCombo(cboNombrePlan, oPlanDePruebaServicio.ObtenerTodos(), "Nombre", "Id_plan_prueba");
            
            cboNombrePlan.SelectedIndex = -1;
            btnAgregarDetalle.Enabled = false;
            gbCasoDePrueba.Enabled = false;
            limpiarCampos();
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
            if (controlCamposAceptar())
            {
                oCicloPrueba.Fecha_inicio_ejecucion = dtpFechaInicio.Value;
                oCicloPrueba.Fecha_fin_ejecucion = dtpFechaFin.Value;
                oCicloPrueba.OUsuario = new Usuario();
                oCicloPrueba.OUsuario.Id_usuario = (int)cboNombreResponsable.SelectedValue;
                oCicloPrueba.OPlanDePrueba = new PlanDePrueba();
                oCicloPrueba.OPlanDePrueba.Id_plan_prueba = (int)cboNombrePlan.SelectedValue;
                oCicloPrueba.Aceptado = CheckBoxAceptarCiclo().ToString();
                oCicloPrueba.ListaCicloPruebaDetalle = new List<CicloPruebaDetalle>();

                for (int i = 0; i < grdDetalleCdP.Rows.Count; i++)
                {
                    CicloPruebaDetalle oCicloPruebaDetalle = new CicloPruebaDetalle();
                    oCicloPruebaDetalle.OCicloPrueba = oCicloPrueba;//Id_ciclo_prueba (objeto)
                    oCicloPruebaDetalle.OCasoDePrueba = new CasoDePrueba();
                    oCicloPruebaDetalle.OCasoDePrueba.Id_caso_prueba = (int)grdDetalleCdP.Rows[i].Cells["idCasoDePrueba"].Value;
                    oCicloPruebaDetalle.OUsuario = new Usuario();
                    oCicloPruebaDetalle.OUsuario.Id_usuario = (int)grdDetalleCdP.Rows[i].Cells["idTester"].Value;
                    oCicloPruebaDetalle.Cantidad_horas = Convert.ToInt32(grdDetalleCdP.Rows[i].Cells["horas"].Value);
                    oCicloPruebaDetalle.Fecha_ejecucion = (DateTime)grdDetalleCdP.Rows[i].Cells["fecha"].Value;
                    oCicloPruebaDetalle.Aceptado = grdDetalleCdP.Rows[i].Cells["aceptado"].Value.ToString();

                    oCicloPrueba.ListaCicloPruebaDetalle.Add(oCicloPruebaDetalle);
                }

                if (oCicloPruebaServicio.Crear(oCicloPrueba))
                {
                    MessageBox.Show("El ciclo de prueba se creó con exito");
                }
                    
                else
                    MessageBox.Show("Falló la creacion del ciclo de prueba");

            }
            
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
                grilla.Rows.Add
                    (
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
            if (controlCamposAgregar())
            {
                grdDetalleCdP.Rows.Add(
                cboTituloCaso.SelectedValue,
                cboTituloCaso.Text,
                cboNombreTester.SelectedValue,
                cboNombreTester.Text,
                txtHoras.Text,
                dtpFechaEjecucion.Value, CheckBoxAceptarDetalle());
                limpiarCampos();
            }
            
        }

        private int CheckBoxAceptarDetalle()
        {
            int aceptado = 0;
            if (chkAceptarDetalle.Checked)
                aceptado = 1;
            return aceptado;
        }

        private int CheckBoxAceptarCiclo()
        {
            int aceptado = 0;
            if (chkAceptarCiclo.Checked)
                aceptado = 1;
            return aceptado;
        }




        private void limpiarCampos()
        {
            cboNombreTester.SelectedIndex = -1;
            dtpFechaEjecucion.Value = DateTime.Today;
            txtHoras.Text = string.Empty;
            if (cboNombrePlan.SelectedIndex != -1)
            {
                cboNombrePlan.Enabled = false;
                gbCasoDePrueba.Enabled = true;
                btnNuevoPlan.Enabled = false;
                btnAgregarDetalle.Enabled = true;
                chkAceptarDetalle.Checked = false;
                
                //
                //dtpFechaInicio.Enabled = false;
                //dtpFechaFin.Enabled = false;
            }
            cboTituloCaso.SelectedIndex = -1;
        }

        private bool controlCamposAgregar()
        {
            if (cboTituloCaso.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un caso de prueba");
                return false;
            }
            if (dtpFechaEjecucion.Value < dtpFechaInicio.Value || dtpFechaEjecucion.Value > dtpFechaFin.Value)
            {
                MessageBox.Show("La fecha fecha ejecución se encuentra fuera del rango establecido...", "Fecha de Ejecución");
                return false;
            }
            if (cboNombreTester.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tester", "Usuario Tester");
                return false;
            }
            if (txtHoras.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un valor numerico","Horas designadas");
                return false;
            }
            return true;
        }

        private bool controlCamposAceptar()
        {
            if (dtpFechaInicio.Value > dtpFechaFin.Value)
            {
                MessageBox.Show("La fecha inicial es mayor a la fecha final");
                return false;
            };

            if (cboNombreResponsable.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un responsable");
                return false;
            }

            if (cboNombrePlan.SelectedIndex==-1)
            {
                MessageBox.Show("Seleccione un Plan de prueba");
                return false;
            }

            if (grdDetalleCdP.Rows.Count > 0)
            {
                int contador = 0;
                for (int i = 0; i < grdDetalleCdP.Rows.Count; i++)
                {
                    DateTime fecha = (DateTime)grdDetalleCdP.Rows[i].Cells["Fecha"].Value;
                    if ((DateTime)grdDetalleCdP.Rows[i].Cells["Fecha"].Value < dtpFechaInicio.Value || (DateTime)grdDetalleCdP.Rows[i].Cells["Fecha"].Value > dtpFechaFin.Value)
                    {
                        grdDetalleCdP.Rows[i].DefaultCellStyle.BackColor=Color.LightPink;
                        contador += 1;
                    }
                    
                }
                if (contador > 0)
                {
                    MessageBox.Show("Las siguientes fechas de ejecución no coinciden con sus fechas de inicio y fin");
                    return false;
                }
            }

            return true;
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdDetalleCdP.SelectedRows)
            {
                grdDetalleCdP.Rows.Remove(row);
            }
        }

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void btnEditarDetalle_Click(object sender, EventArgs e)
        {
            //if (grdDetalleCdP.CurrentRow != null)
            //{
            //    txtHoras.
            //}
        }

        private void btnNuevoPlan_Click(object sender, EventArgs e)
        {
            frmPlanDePruebaABM ofrmPlanDePruebaABM = new frmPlanDePruebaABM();
            ofrmPlanDePruebaABM.Op = 1;
            ofrmPlanDePruebaABM.ShowDialog();
            LlenarCombo(cboNombrePlan, oPlanDePruebaServicio.ObtenerTodos(), "Nombre", "Id_plan_prueba");
        }
    }
}
