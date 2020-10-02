using BugTracker.Entities;
using Proyecto_Bugs_Extendido.Entidades;
using Proyecto_Bugs_Extendido.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_Bugs_Extendido.Presentacion
{
    public partial class frmPlanDePruebaABM : Form
    {
        private PlanDePruebaServicio oPlanDePruebaServicio;
        private ProyectoServicio oProyectoServicio;
        private UsuarioServicio oUsuarioServicio;
        private PlanDePrueba oPlanDePrueba;
        private int op,iDPlanDePrueba;
        public int Op { get => op; set => op = value; }

        public frmPlanDePruebaABM()
        {
            InitializeComponent();
            oPlanDePrueba = new PlanDePrueba();
            oPlanDePruebaServicio = new PlanDePruebaServicio();
            oProyectoServicio = new ProyectoServicio();
            oUsuarioServicio = new UsuarioServicio();
        }

        public frmPlanDePruebaABM(int id)
        {
            InitializeComponent();
            this.iDPlanDePrueba = id;
            oPlanDePruebaServicio = new PlanDePruebaServicio();
            oProyectoServicio = new ProyectoServicio();
            oUsuarioServicio = new UsuarioServicio();
        }

        private void frmPlanDePruebaABM_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboResponsable, oUsuarioServicio.ObtenerTodos(), "NombreUsuario", "Id_usuario");
            LlenarGrilla(grdProyectoPlan,oProyectoServicio.ObtenerTodos());
            
            switch (op)
            {
                case 1: 
                    {
                        grdProyectoPlan.ClearSelection();
                        grdProyectoPlan.CurrentRow.Selected = false;
                        this.Text = "Nuevo plan de prueba";                        
                    };
                    break;
                case 2: 
                    {
                        llenarCampos();
                        this.Text = "Actualizar Plan de prueba " + txtNombre.Text;
                    }
                    break;
                case 3: 
                    {
                        llenarCampos();
                        habiliatCampos(false);
                        this.Text = "Eliminar Plan de prueba" + txtNombre.Text;
                        oPlanDePruebaServicio.EliminarPlanDePrueba(oPlanDePrueba);
                    };
                    break;
            }
            
        }

        public void llenarCampos()
        {
            //oPlanDePrueba = new PlanDePrueba();
            
            oPlanDePrueba = oPlanDePruebaServicio.ObtenerPlanDePruebaPorID(iDPlanDePrueba.ToString());

            txtID.Text = oPlanDePrueba.Id_plan_prueba.ToString();
            txtNombre.Text = oPlanDePrueba.Nombre;
            txtDescripcion.Text = oPlanDePrueba.Descripcion;
            cboResponsable.SelectedValue = oPlanDePrueba.OUsuario.Id_usuario;

            for (int i = 0; i < grdProyectoPlan.Rows.Count; i++)
            {
                if ((int)grdProyectoPlan.Rows[i].Cells[0].Value == oPlanDePrueba.OProyecto.Id_proyecto)
                {
                    grdProyectoPlan.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    grdProyectoPlan.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case 1: 
                    {
                        if (validarCampos())
                        {
                            oPlanDePrueba.OProyecto = new Proyecto();
                            oPlanDePrueba.OProyecto.Id_proyecto = (int)grdProyectoPlan.CurrentRow.Cells[0].Value;
                            oPlanDePrueba.Nombre = txtNombre.Text;
                            oPlanDePrueba.OUsuario = new Usuario();
                            oPlanDePrueba.OUsuario.Id_usuario = (int)cboResponsable.SelectedValue;
                            oPlanDePrueba.Descripcion = txtDescripcion.Text;

                            if (oPlanDePruebaServicio.CrearPlanDePrueba(oPlanDePrueba))
                            {
                                MessageBox.Show("El plan de prueba se creó correctamente");
                                this.Close();
                            }
                            else
                                MessageBox.Show("Falló la creación del pland de prueba");
                        }
                    };break;
                case 2:
                    {
                        if (validarCampos())
                        {
                            oPlanDePrueba.Id_plan_prueba =Convert.ToInt32(txtID.Text);
                            oPlanDePrueba.OProyecto = new Proyecto();
                            oPlanDePrueba.OProyecto.Id_proyecto = (int)grdProyectoPlan.CurrentRow.Cells[0].Value;
                            oPlanDePrueba.Nombre = txtNombre.Text;
                            oPlanDePrueba.OUsuario = new Usuario();
                            oPlanDePrueba.OUsuario.Id_usuario = (int)cboResponsable.SelectedValue;
                            oPlanDePrueba.Descripcion = txtDescripcion.Text;

                            if (oPlanDePruebaServicio.ActualizarPlanDePrueba(oPlanDePrueba))
                            {
                                MessageBox.Show("El plan de prueba se actualizó correctamente");
                                this.Close();
                            }
                            else
                                MessageBox.Show("Falló la actualización del plan de prueba");
                        }
                    };break;
                case 3:
                    {
                        if (oPlanDePruebaServicio.EliminarPlanDePrueba(oPlanDePrueba))
                        {
                            MessageBox.Show("El plan de prueba se eliminó correctamente");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Falló la eliminación del plan de prueba");
                    };break;
            }
        }

        private void LlenarGrilla(DataGridView grilla, IList<Proyecto> lista)
        {
            if (lista != null)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    grilla.Rows.Add(
                        lista[i].Id_proyecto,
                        lista[i].OProducto.Nombre,
                        lista[i].Responsable.NombreUsuario,
                        lista[i].Descripcion,
                        lista[i].Version,
                        lista[i].Alcance
                        );
                }
            }
        }

        private void habiliatCampos(bool x)
        {
            txtNombre.Enabled = x;
            txtDescripcion.Enabled = x;
            cboResponsable.Enabled = x;
            grdProyectoPlan.Enabled = x;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool validarCampos()
        {
            if (txtNombre.Text == string.Empty)
            {
                txtNombre.BackColor = Color.LightPink;
                return false;
            }
            if (txtDescripcion.Text == string.Empty)
            {
                txtDescripcion.BackColor = Color.LightPink;
                return false;
            }
            if (cboResponsable.SelectedIndex == -1)
            {
                cboResponsable.BackColor = Color.LightPink;
                return false;
            }
            if (grdProyectoPlan.CurrentRow.Selected==false)
            {
                MessageBox.Show("Seleccione una fila de la grilla");
                return false;
            }
            return true;
        }

    }
}
