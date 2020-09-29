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
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace Proyecto_Bugs_Extendido.Presentacion
{
    public partial class frmPlanDePrueba : Form
    {
        private UsuarioServicio oUsuarioServicio;
        private PlanDePruebaServicio oPlanDePruebaServicio;
        public frmPlanDePrueba()
        {
            InitializeComponent();
            oUsuarioServicio = new UsuarioServicio();
            oPlanDePruebaServicio = new PlanDePruebaServicio();
        }
        private void frmPlanDePrueba_Load(object sender, EventArgs e)
        {   
            llenarCombos(cboResponsable, oUsuarioServicio.ObtenerTodos(), "NombreUsuario", "Id_usuario");
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        public void llenarCombos(ComboBox combo, Object source, string display, string value)
        {
            combo.DataSource = source;
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            grdPlanDePrueba.Rows.Clear();

            string condiciones = string.Empty;
            
            if (!chkTodos.Checked)
            {
                if (txtNombrePlan.Text != string.Empty)
                    condiciones += " AND pdp.nombre LIKE '%" + txtNombrePlan.Text + "%'";
                if (cboResponsable.SelectedIndex != -1)
                    condiciones += " AND u.id_usuario=" + cboResponsable.SelectedValue.ToString();
                if (condiciones != string.Empty)
                    loadGrid(grdPlanDePrueba, oPlanDePruebaServicio.ConsultarConFiltrosSinParametros(condiciones));
            }
            else
                loadGrid(grdPlanDePrueba, oPlanDePruebaServicio.ConsultarConFiltrosSinParametros(condiciones));
        }
        private void loadGrid(DataGridView grilla, IList<PlanDePrueba> lista)
        {
            if (lista.Count>0)
            {
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;

                for (int i = 0; i < lista.Count; i++)
                {
                    grilla.Rows.Add(
                        lista[i].Id_plan_prueba,
                        lista[i].Nombre,
                        lista[i].OUsuario.NombreUsuario,
                        lista[i].Descripcion,
                        lista[i].OProyecto.Id_proyecto);
                }
            }
            else
            {
                MessageBox.Show("No hay Planes registrados");
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }   
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmPlanDePruebaABM ofrmPlanDePruebaABM = new frmPlanDePruebaABM();
            ofrmPlanDePruebaABM.Op = 1;
            ofrmPlanDePruebaABM.ShowDialog();
            btnConsultar_Click(sender, e);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmPlanDePruebaABM ofrmPlanDePruebaABM = new frmPlanDePruebaABM((int)grdPlanDePrueba.CurrentRow.Cells[0].Value);
            ofrmPlanDePruebaABM.Op = 2;
            ofrmPlanDePruebaABM.ShowDialog();
            btnConsultar_Click(sender, e);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmPlanDePruebaABM ofrmPlanDePruebaABM = new frmPlanDePruebaABM((int)grdPlanDePrueba.CurrentRow.Cells[0].Value);
            ofrmPlanDePruebaABM.Op = 3;
            ofrmPlanDePruebaABM.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtNombrePlan.Enabled = false;
                cboResponsable.Enabled = false;
            }
            else
            {
                txtNombrePlan.Enabled = true;
                cboResponsable.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbPlanDePrueba_Enter(object sender, EventArgs e)
        {

        }
    }
}
