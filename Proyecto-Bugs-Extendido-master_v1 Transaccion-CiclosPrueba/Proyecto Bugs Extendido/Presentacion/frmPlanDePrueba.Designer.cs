namespace Proyecto_Bugs_Extendido.Presentacion
{
    partial class frmPlanDePrueba
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
            this.gbPlanDePrueba = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.cboResponsable = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombrePlan = new System.Windows.Forms.TextBox();
            this.grdPlanDePrueba = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbPlanDePrueba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlanDePrueba)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPlanDePrueba
            // 
            this.gbPlanDePrueba.Controls.Add(this.btnConsultar);
            this.gbPlanDePrueba.Controls.Add(this.chkTodos);
            this.gbPlanDePrueba.Controls.Add(this.lblResponsable);
            this.gbPlanDePrueba.Controls.Add(this.cboResponsable);
            this.gbPlanDePrueba.Controls.Add(this.lblNombre);
            this.gbPlanDePrueba.Controls.Add(this.txtNombrePlan);
            this.gbPlanDePrueba.Controls.Add(this.grdPlanDePrueba);
            this.gbPlanDePrueba.Location = new System.Drawing.Point(12, 13);
            this.gbPlanDePrueba.Name = "gbPlanDePrueba";
            this.gbPlanDePrueba.Size = new System.Drawing.Size(590, 379);
            this.gbPlanDePrueba.TabIndex = 0;
            this.gbPlanDePrueba.TabStop = false;
            this.gbPlanDePrueba.Text = "Plan de prueba";
            this.gbPlanDePrueba.Enter += new System.EventHandler(this.gbPlanDePrueba_Enter);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(453, 72);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(372, 76);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 3;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(136, 48);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(72, 13);
            this.lblResponsable.TabIndex = 21;
            this.lblResponsable.Text = "Responsable:";
            // 
            // cboResponsable
            // 
            this.cboResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResponsable.FormattingEnabled = true;
            this.cboResponsable.Location = new System.Drawing.Point(214, 45);
            this.cboResponsable.Name = "cboResponsable";
            this.cboResponsable.Size = new System.Drawing.Size(150, 21);
            this.cboResponsable.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(121, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre del plan:";
            // 
            // txtNombrePlan
            // 
            this.txtNombrePlan.Location = new System.Drawing.Point(214, 19);
            this.txtNombrePlan.Name = "txtNombrePlan";
            this.txtNombrePlan.Size = new System.Drawing.Size(150, 20);
            this.txtNombrePlan.TabIndex = 1;
            // 
            // grdPlanDePrueba
            // 
            this.grdPlanDePrueba.AllowUserToAddRows = false;
            this.grdPlanDePrueba.AllowUserToDeleteRows = false;
            this.grdPlanDePrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPlanDePrueba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.responsable,
            this.descripcion,
            this.idProyecto});
            this.grdPlanDePrueba.Location = new System.Drawing.Point(6, 101);
            this.grdPlanDePrueba.MultiSelect = false;
            this.grdPlanDePrueba.Name = "grdPlanDePrueba";
            this.grdPlanDePrueba.ReadOnly = true;
            this.grdPlanDePrueba.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPlanDePrueba.Size = new System.Drawing.Size(578, 272);
            this.grdPlanDePrueba.TabIndex = 5;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.FillWeight = 150F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 43;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre.HeaderText = "Nombre Plan";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 93;
            // 
            // responsable
            // 
            this.responsable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.responsable.HeaderText = "Responsable";
            this.responsable.Name = "responsable";
            this.responsable.ReadOnly = true;
            this.responsable.Width = 94;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 88;
            // 
            // idProyecto
            // 
            this.idProyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idProyecto.HeaderText = "ID Proyecto";
            this.idProyecto.Name = "idProyecto";
            this.idProyecto.ReadOnly = true;
            this.idProyecto.Width = 88;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Proyecto_Bugs_Extendido.Properties.Resources.iconfinder_Login_in_85265;
            this.btnSalir.Location = new System.Drawing.Point(521, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 40);
            this.btnSalir.TabIndex = 0;
            this.toolTipButton.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Proyecto_Bugs_Extendido.Properties.Resources.delete;
            this.btnEliminar.Location = new System.Drawing.Point(180, 398);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 40);
            this.btnEliminar.TabIndex = 3;
            this.toolTipButton.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Proyecto_Bugs_Extendido.Properties.Resources.save_as;
            this.btnEditar.Location = new System.Drawing.Point(99, 398);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 40);
            this.btnEditar.TabIndex = 2;
            this.toolTipButton.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Proyecto_Bugs_Extendido.Properties.Resources.add;
            this.btnNuevo.Location = new System.Drawing.Point(18, 398);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 40);
            this.btnNuevo.TabIndex = 1;
            this.toolTipButton.SetToolTip(this.btnNuevo, "Nuevo");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmPlanDePrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbPlanDePrueba);
            this.Name = "frmPlanDePrueba";
            this.Text = "Soporte de plan de prueba";
            this.Load += new System.EventHandler(this.frmPlanDePrueba_Load);
            this.gbPlanDePrueba.ResumeLayout(false);
            this.gbPlanDePrueba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlanDePrueba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlanDePrueba;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombrePlan;
        private System.Windows.Forms.DataGridView grdPlanDePrueba;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.ComboBox cboResponsable;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProyecto;
    }
}