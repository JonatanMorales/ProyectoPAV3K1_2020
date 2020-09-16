namespace Proyecto_Bugs_Extendido.Presentacion
{
    partial class frmProyecto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbProyecto = new System.Windows.Forms.GroupBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.grdProyecto = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alcance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.cboResponsable = new System.Windows.Forms.ComboBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tTbtn = new System.Windows.Forms.ToolTip(this.components);
            this.gbProyecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProyecto
            // 
            this.gbProyecto.Controls.Add(this.chkTodos);
            this.gbProyecto.Controls.Add(this.grdProyecto);
            this.gbProyecto.Controls.Add(this.lblResponsable);
            this.gbProyecto.Controls.Add(this.cboResponsable);
            this.gbProyecto.Controls.Add(this.cboProducto);
            this.gbProyecto.Controls.Add(this.btnConsultar);
            this.gbProyecto.Controls.Add(this.lblProducto);
            this.gbProyecto.Location = new System.Drawing.Point(13, 13);
            this.gbProyecto.Name = "gbProyecto";
            this.gbProyecto.Size = new System.Drawing.Size(665, 384);
            this.gbProyecto.TabIndex = 0;
            this.gbProyecto.TabStop = false;
            this.gbProyecto.Text = "Proyecto";
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(111, 74);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 3;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // grdProyecto
            // 
            this.grdProyecto.AllowUserToAddRows = false;
            this.grdProyecto.AllowUserToDeleteRows = false;
            this.grdProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProyecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.producto,
            this.descripcion,
            this.version,
            this.responsable,
            this.alcance});
            this.grdProyecto.Location = new System.Drawing.Point(7, 99);
            this.grdProyecto.MultiSelect = false;
            this.grdProyecto.Name = "grdProyecto";
            this.grdProyecto.ReadOnly = true;
            this.grdProyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProyecto.Size = new System.Drawing.Size(652, 279);
            this.grdProyecto.TabIndex = 5;
            this.grdProyecto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProyecto_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 150;
            // 
            // version
            // 
            this.version.HeaderText = "Versión";
            this.version.Name = "version";
            this.version.ReadOnly = true;
            this.version.Width = 50;
            // 
            // responsable
            // 
            this.responsable.HeaderText = "Responsable";
            this.responsable.Name = "responsable";
            this.responsable.ReadOnly = true;
            // 
            // alcance
            // 
            this.alcance.HeaderText = "Alcance";
            this.alcance.Name = "alcance";
            this.alcance.ReadOnly = true;
            this.alcance.Width = 150;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(33, 49);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(72, 13);
            this.lblResponsable.TabIndex = 3;
            this.lblResponsable.Text = "Responsable:";
            // 
            // cboResponsable
            // 
            this.cboResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResponsable.FormattingEnabled = true;
            this.cboResponsable.Location = new System.Drawing.Point(111, 46);
            this.cboResponsable.Name = "cboResponsable";
            this.cboResponsable.Size = new System.Drawing.Size(121, 21);
            this.cboResponsable.TabIndex = 2;
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(111, 19);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(121, 21);
            this.cboProducto.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(460, 68);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(47, 22);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(58, 13);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Productos:";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Proyecto_Bugs_Extendido.Properties.Resources.iconfinder_Login_in_85265;
            this.btnSalir.Location = new System.Drawing.Point(597, 412);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 40);
            this.btnSalir.TabIndex = 4;
            this.tTbtn.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Proyecto_Bugs_Extendido.Properties.Resources.delete;
            this.btnEliminar.Location = new System.Drawing.Point(186, 412);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 40);
            this.btnEliminar.TabIndex = 3;
            this.tTbtn.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Proyecto_Bugs_Extendido.Properties.Resources.save_as;
            this.btnEditar.Location = new System.Drawing.Point(105, 412);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 40);
            this.btnEditar.TabIndex = 2;
            this.tTbtn.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Proyecto_Bugs_Extendido.Properties.Resources.add;
            this.btnNuevo.Location = new System.Drawing.Point(20, 412);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 40);
            this.btnNuevo.TabIndex = 1;
            this.tTbtn.SetToolTip(this.btnNuevo, "Nuevo\r\n");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 466);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbProyecto);
            this.MaximizeBox = false;
            this.Name = "frmProyecto";
            this.Text = "Soporte";
            this.Load += new System.EventHandler(this.frmProyecto_Load);
            this.gbProyecto.ResumeLayout(false);
            this.gbProyecto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProyecto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProyecto;
        private System.Windows.Forms.DataGridView grdProyecto;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.ComboBox cboResponsable;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn version;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn alcance;
        private System.Windows.Forms.ToolTip tTbtn;
    }
}