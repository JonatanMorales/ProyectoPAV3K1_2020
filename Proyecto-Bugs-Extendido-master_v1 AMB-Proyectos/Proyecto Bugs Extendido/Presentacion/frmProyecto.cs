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

namespace Proyecto_Bugs_Extendido.Presentacion
{
    public partial class frmProyecto : Form
    {
        private ProductoServicio oProductoServicio;
        private UsuarioServicio oUsuarioServicio;
        private ProyectoServicio oProyectoServicio;
        
        
        public frmProyecto()
        {
            InitializeComponent();
            oProductoServicio = new ProductoServicio();
            oUsuarioServicio = new UsuarioServicio();
            oProyectoServicio = new ProyectoServicio();
        }

        private void frmProyecto_Load(object sender, EventArgs e)
        {
            enableComponents(true);
            LlenarCombo(cboProducto,oProductoServicio.ObtenerTodos(),"Nombre","Id_producto");
            LlenarCombo(cboResponsable,oUsuarioServicio.ObtenerTodos(),"Nusuario","id_usuario");
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chkTodos.Checked)
                {
                    cboProducto.Enabled = false;
                    cboResponsable.Enabled = false;
                }
                else
                {
                    cboProducto.Enabled = true;
                    cboResponsable.Enabled = true;
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {   
            String condiciones = string.Empty;
            if (!chkTodos.Checked)
            {
                if (cboProducto.Text != string.Empty)
                    condiciones += " AND pd.id_producto=" + cboProducto.SelectedValue.ToString();

                if (cboResponsable.Text != string.Empty)
                    condiciones += " AND u.id_usuario=" + cboResponsable.SelectedValue.ToString();

                if (condiciones != string.Empty)
                    loadGrid(grdProyecto, oProyectoServicio.ConsultarConFiltrosSinParametros(condiciones));
            }
            else
                loadGrid(grdProyecto, oProyectoServicio.ObtenerTodos());
        }

        private void loadGrid(DataGridView grilla,IList<Proyecto> lista)
        {
            grilla.Rows.Clear();

            if (lista.Count > 0)
                enableComponents(false);
            else
                enableComponents(true);

            for (int i = 0; i < lista.Count; i++)
            {
                grilla.Rows.Add(
                    lista[i].Id_proyecto,
                    lista[i].OProducto.ToString(),
                    lista[i].Descripcion,
                    lista[i].Version,
                    lista[i].OUsuario.ToString(),
                    lista[i].Alcance);
            }

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProyectoABM formulario = new frmProyectoABM();
            formulario.Op = 1;
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmProyectoABM formulario = new frmProyectoABM((int)grdProyecto.CurrentRow.Cells[0].Value);
            formulario.Op = 2;
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmProyectoABM formulario = new frmProyectoABM((int)grdProyecto.CurrentRow.Cells[0].Value);
            formulario.Op = 3;
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        /*enableComponents(bool x) habilita ciertos componestes del formulario
         */
        private void enableComponents(bool x)
        {
            grdProyecto.Enabled=!x;
            btnEditar.Enabled = !x;
            btnEliminar.Enabled = !x;
        }

        private void grdProyecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
