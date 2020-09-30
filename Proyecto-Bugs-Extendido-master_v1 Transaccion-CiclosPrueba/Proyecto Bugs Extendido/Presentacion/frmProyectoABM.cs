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
using System.Windows;
using System.Windows.Forms;

namespace Proyecto_Bugs_Extendido.Presentacion
{
    public partial class frmProyectoABM : Form
    {
        private Proyecto oProyecto;
        private ProyectoServicio oProyectoServicio;
        private ProductoServicio oProductoServicio;
        private UsuarioServicio oUsuarioServicio;
        private int op,idProyecto;
        public int Op { get => op; set => op = value; }
        
        public frmProyectoABM()
        {
            InitializeComponent();
            this.oProyecto = new Proyecto();
            this.oProyectoServicio = new ProyectoServicio();
            this.oProductoServicio = new ProductoServicio();
            this.oUsuarioServicio = new UsuarioServicio();
        }

        public frmProyectoABM(int idProyecto)
        {
            InitializeComponent();
            this.idProyecto = idProyecto;
            this.oProyectoServicio = new ProyectoServicio();
            this.oProductoServicio = new ProductoServicio();
            this.oUsuarioServicio = new UsuarioServicio();
            
        }

        private void frmProyectoABM_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            LlenarCombo(cboProducto, oProductoServicio.ObtenerTodos(), "Nombre", "Id_producto");
            LlenarCombo(cboResponsable, oUsuarioServicio.ObtenerTodos(), "NombreUsuario", "Id_usuario");
            switch (op)
            {
                case 1:
                    {
                        this.Text = "Nuevo Proyecto";
                    }
                    break;
                case 2:
                    {
                        this.Text = "Editar Proyecto";
                        llenarCampos();
                        habilitarCampos(true);
                    }
                    break;
                case 3:
                    {
                        this.Text = "Eliminar Proyecto";
                        llenarCampos();
                        habilitarCampos(false);
                    }
                    break;
            }
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        public void llenarCampos()
        {
            this.oProyecto =  oProyectoServicio.ObtenerProyectoPorID(this.idProyecto.ToString());
            if (oProyecto!=null)
            {   
                txtID.Text = oProyecto.Id_proyecto.ToString();
                cboProducto.Text = oProyecto.OProducto.ToString();
                cboResponsable.Text = oProyecto.Responsable.ToString();
                txtDescripcion.Text = oProyecto.Descripcion;
                txtVersion.Text = oProyecto.Version;
                txtAlcance.Text = oProyecto.Alcance;
            }
        }

        private void habilitarCampos(bool x)
        {
            cboProducto.Enabled = x;
            cboResponsable.Enabled = x;
            txtDescripcion.Enabled = x;
            txtVersion.Enabled = x;
            txtAlcance.Enabled = x;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (Op)
            {
                case 1:
                    {
                        if (validarCampos())
                        {
                            oProyecto = new Proyecto();
                            oProyecto.OProducto = new Producto();
                            oProyecto.OProducto.Id_producto = (int)cboProducto.SelectedValue;
                            oProyecto.Responsable= new Usuario();
                            oProyecto.Responsable.Id_usuario = (int)cboResponsable.SelectedValue;
                            oProyecto.Descripcion = txtDescripcion.Text;
                            oProyecto.Version = txtVersion.Text;
                            oProyecto.Alcance = txtAlcance.Text;
                            
                            if (oProyectoServicio.CrearProyecto(oProyecto))
                            {

                                MessageBox.Show("El proyecto se creó correctamente");
                                this.Close();
                            }
                            else
                                MessageBox.Show("Falló la creación del proyecto");
                        }
                        break;
                    }
                case 2:
                    {
                        if (validarCampos())
                        {
                            oProyecto.OProducto = new Producto();
                            oProyecto.OProducto.Id_producto = (int)cboProducto.SelectedValue;
                            oProyecto.Responsable = new Usuario();
                            oProyecto.Responsable.Id_usuario = (int)cboResponsable.SelectedValue;
                            oProyecto.Descripcion = txtDescripcion.Text;
                            oProyecto.Version = txtVersion.Text;
                            oProyecto.Alcance = txtAlcance.Text;

                            if (oProyectoServicio.ActualizarProyecto(oProyecto))
                            {
                                MessageBox.Show("El proyecto se actualizó correctamente");
                                this.Close();
                            }
                            else
                                MessageBox.Show("Falló la actualización del proyecto");
                        }
                        break;
                    }
                case 3: 
                    {
                        if (oProyectoServicio.EliminarProyecto(oProyecto))
                        {
                            MessageBox.Show("El proyecto se eliminó correctamente");
                            this.Close();
                        }   
                        else
                            MessageBox.Show("Falló la eliminación del proyecto");
                        break;
                    }
                    
            }

            
        }
        private bool validarCampos()
        {
            if (cboProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un Producto");
                cboProducto.Focus();
                return false;
            }

            if (cboResponsable.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un Responsable");
                cboResponsable.Focus();
                return false;
            }

            if (txtDescripcion.Text == string.Empty)
            {
                txtDescripcion.BackColor = Color.Red;
                txtDescripcion.Focus();
                return false;
            }
            else
                txtDescripcion.BackColor = Color.White;

            if (txtVersion.Text == string.Empty)
            {
                txtVersion.BackColor = Color.Red;
                txtVersion.Focus();
                return false;
            }
            else
                txtVersion.BackColor = Color.White;

            return true;
        }



    }
}
