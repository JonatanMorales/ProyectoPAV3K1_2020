namespace Proyecto_Bugs_Extendido.Presentacion
{
    partial class frmCiclosDePrueba
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
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.txtIdResponsable = new System.Windows.Forms.TextBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.lblNameResponsable = new System.Windows.Forms.Label();
            this.lblTituloCdP = new System.Windows.Forms.Label();
            this.gbPlanDePrueba = new System.Windows.Forms.GroupBox();
            this.grdProyecto = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevoPlan = new System.Windows.Forms.Button();
            this.gbCasoDePrueba = new System.Windows.Forms.GroupBox();
            this.cboTituloCaso = new System.Windows.Forms.ComboBox();
            this.btnNuevoCaso = new System.Windows.Forms.Button();
            this.cboNombrePlan = new System.Windows.Forms.ComboBox();
            this.lblNombrePdP = new System.Windows.Forms.Label();
            this.gbCicloDePrueba = new System.Windows.Forms.GroupBox();
            this.cboNombreTester = new System.Windows.Forms.ComboBox();
            this.dtpFechaEjecucion = new System.Windows.Forms.DateTimePicker();
            this.lblFechEjecucion = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.lblIdTester = new System.Windows.Forms.Label();
            this.txtIdTester = new System.Windows.Forms.TextBox();
            this.lblTester = new System.Windows.Forms.Label();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.btnEditarDetalle = new System.Windows.Forms.Button();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.grdDetalleCdP = new System.Windows.Forms.DataGridView();
            this.casoDePrueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEjecucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevoCdP = new System.Windows.Forms.Button();
            this.lblListar = new System.Windows.Forms.Button();
            this.cboNombreResponsable = new System.Windows.Forms.ComboBox();
            this.gbPlanDePrueba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProyecto)).BeginInit();
            this.gbCasoDePrueba.SuspendLayout();
            this.gbCicloDePrueba.SuspendLayout();
            this.gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleCdP)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(96, 12);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 0;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(96, 38);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 1;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(22, 18);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(68, 13);
            this.lblFechaInicio.TabIndex = 2;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(33, 44);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(57, 13);
            this.lblFechaFin.TabIndex = 3;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // txtIdResponsable
            // 
            this.txtIdResponsable.Enabled = false;
            this.txtIdResponsable.Location = new System.Drawing.Point(443, 15);
            this.txtIdResponsable.Name = "txtIdResponsable";
            this.txtIdResponsable.Size = new System.Drawing.Size(50, 20);
            this.txtIdResponsable.TabIndex = 4;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(416, 18);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(21, 13);
            this.lblIdUsuario.TabIndex = 5;
            this.lblIdUsuario.Text = "ID:";
            // 
            // lblNameResponsable
            // 
            this.lblNameResponsable.AutoSize = true;
            this.lblNameResponsable.Location = new System.Drawing.Point(365, 44);
            this.lblNameResponsable.Name = "lblNameResponsable";
            this.lblNameResponsable.Size = new System.Drawing.Size(72, 13);
            this.lblNameResponsable.TabIndex = 7;
            this.lblNameResponsable.Text = "Responsable:";
            // 
            // lblTituloCdP
            // 
            this.lblTituloCdP.AutoSize = true;
            this.lblTituloCdP.Location = new System.Drawing.Point(6, 25);
            this.lblTituloCdP.Name = "lblTituloCdP";
            this.lblTituloCdP.Size = new System.Drawing.Size(36, 13);
            this.lblTituloCdP.TabIndex = 9;
            this.lblTituloCdP.Text = "Titulo:";
            // 
            // gbPlanDePrueba
            // 
            this.gbPlanDePrueba.Controls.Add(this.grdProyecto);
            this.gbPlanDePrueba.Controls.Add(this.btnNuevoPlan);
            this.gbPlanDePrueba.Controls.Add(this.gbCasoDePrueba);
            this.gbPlanDePrueba.Controls.Add(this.cboNombrePlan);
            this.gbPlanDePrueba.Controls.Add(this.lblNombrePdP);
            this.gbPlanDePrueba.Location = new System.Drawing.Point(7, 75);
            this.gbPlanDePrueba.Name = "gbPlanDePrueba";
            this.gbPlanDePrueba.Size = new System.Drawing.Size(657, 151);
            this.gbPlanDePrueba.TabIndex = 10;
            this.gbPlanDePrueba.TabStop = false;
            this.gbPlanDePrueba.Text = "Plan de prueba";
            // 
            // grdProyecto
            // 
            this.grdProyecto.AllowUserToAddRows = false;
            this.grdProyecto.AllowUserToDeleteRows = false;
            this.grdProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProyecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion,
            this.version,
            this.responsable,
            this.producto});
            this.grdProyecto.Location = new System.Drawing.Point(6, 46);
            this.grdProyecto.Name = "grdProyecto";
            this.grdProyecto.ReadOnly = true;
            this.grdProyecto.Size = new System.Drawing.Size(410, 82);
            this.grdProyecto.TabIndex = 15;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 43;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 88;
            // 
            // version
            // 
            this.version.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.version.HeaderText = "Versión";
            this.version.Name = "version";
            this.version.ReadOnly = true;
            this.version.Width = 67;
            // 
            // responsable
            // 
            this.responsable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.responsable.HeaderText = "Responsable";
            this.responsable.Name = "responsable";
            this.responsable.ReadOnly = true;
            this.responsable.Width = 94;
            // 
            // producto
            // 
            this.producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 75;
            // 
            // btnNuevoPlan
            // 
            this.btnNuevoPlan.Location = new System.Drawing.Point(202, 17);
            this.btnNuevoPlan.Name = "btnNuevoPlan";
            this.btnNuevoPlan.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoPlan.TabIndex = 12;
            this.btnNuevoPlan.Text = "Nuevo";
            this.btnNuevoPlan.UseVisualStyleBackColor = true;
            // 
            // gbCasoDePrueba
            // 
            this.gbCasoDePrueba.Controls.Add(this.cboTituloCaso);
            this.gbCasoDePrueba.Controls.Add(this.lblTituloCdP);
            this.gbCasoDePrueba.Controls.Add(this.btnNuevoCaso);
            this.gbCasoDePrueba.Location = new System.Drawing.Point(422, 46);
            this.gbCasoDePrueba.Name = "gbCasoDePrueba";
            this.gbCasoDePrueba.Size = new System.Drawing.Size(229, 82);
            this.gbCasoDePrueba.TabIndex = 14;
            this.gbCasoDePrueba.TabStop = false;
            this.gbCasoDePrueba.Text = "Caso de prueba";
            // 
            // cboTituloCaso
            // 
            this.cboTituloCaso.FormattingEnabled = true;
            this.cboTituloCaso.Location = new System.Drawing.Point(48, 22);
            this.cboTituloCaso.Name = "cboTituloCaso";
            this.cboTituloCaso.Size = new System.Drawing.Size(150, 21);
            this.cboTituloCaso.TabIndex = 10;
            this.cboTituloCaso.SelectionChangeCommitted += new System.EventHandler(this.cboTituloCaso_SelectionChangeCommitted);
            // 
            // btnNuevoCaso
            // 
            this.btnNuevoCaso.Location = new System.Drawing.Point(148, 49);
            this.btnNuevoCaso.Name = "btnNuevoCaso";
            this.btnNuevoCaso.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoCaso.TabIndex = 11;
            this.btnNuevoCaso.Text = "Nuevo";
            this.btnNuevoCaso.UseVisualStyleBackColor = true;
            // 
            // cboNombrePlan
            // 
            this.cboNombrePlan.FormattingEnabled = true;
            this.cboNombrePlan.Location = new System.Drawing.Point(75, 19);
            this.cboNombrePlan.Name = "cboNombrePlan";
            this.cboNombrePlan.Size = new System.Drawing.Size(121, 21);
            this.cboNombrePlan.TabIndex = 13;
            this.cboNombrePlan.SelectionChangeCommitted += new System.EventHandler(this.cboNombrePlan_SelectionChangeCommitted);
            // 
            // lblNombrePdP
            // 
            this.lblNombrePdP.AutoSize = true;
            this.lblNombrePdP.Location = new System.Drawing.Point(22, 22);
            this.lblNombrePdP.Name = "lblNombrePdP";
            this.lblNombrePdP.Size = new System.Drawing.Size(47, 13);
            this.lblNombrePdP.TabIndex = 12;
            this.lblNombrePdP.Text = "Nombre:";
            // 
            // gbCicloDePrueba
            // 
            this.gbCicloDePrueba.Controls.Add(this.cboNombreTester);
            this.gbCicloDePrueba.Controls.Add(this.dtpFechaEjecucion);
            this.gbCicloDePrueba.Controls.Add(this.lblFechEjecucion);
            this.gbCicloDePrueba.Controls.Add(this.lblHoras);
            this.gbCicloDePrueba.Controls.Add(this.txtHoras);
            this.gbCicloDePrueba.Controls.Add(this.btnAgregarDetalle);
            this.gbCicloDePrueba.Controls.Add(this.lblIdTester);
            this.gbCicloDePrueba.Controls.Add(this.txtIdTester);
            this.gbCicloDePrueba.Controls.Add(this.lblTester);
            this.gbCicloDePrueba.Controls.Add(this.gbPlanDePrueba);
            this.gbCicloDePrueba.Location = new System.Drawing.Point(12, 64);
            this.gbCicloDePrueba.Name = "gbCicloDePrueba";
            this.gbCicloDePrueba.Size = new System.Drawing.Size(670, 232);
            this.gbCicloDePrueba.TabIndex = 11;
            this.gbCicloDePrueba.TabStop = false;
            this.gbCicloDePrueba.Text = "Ciclo de prueba";
            // 
            // cboNombreTester
            // 
            this.cboNombreTester.FormattingEnabled = true;
            this.cboNombreTester.Location = new System.Drawing.Point(211, 18);
            this.cboNombreTester.Name = "cboNombreTester";
            this.cboNombreTester.Size = new System.Drawing.Size(121, 21);
            this.cboNombreTester.TabIndex = 18;
            this.cboNombreTester.SelectionChangeCommitted += new System.EventHandler(this.cboNombreTester_SelectionChangeCommitted);
            // 
            // dtpFechaEjecucion
            // 
            this.dtpFechaEjecucion.Location = new System.Drawing.Point(285, 45);
            this.dtpFechaEjecucion.Name = "dtpFechaEjecucion";
            this.dtpFechaEjecucion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEjecucion.TabIndex = 12;
            // 
            // lblFechEjecucion
            // 
            this.lblFechEjecucion.AutoSize = true;
            this.lblFechEjecucion.Location = new System.Drawing.Point(181, 48);
            this.lblFechEjecucion.Name = "lblFechEjecucion";
            this.lblFechEjecucion.Size = new System.Drawing.Size(98, 13);
            this.lblFechEjecucion.TabIndex = 13;
            this.lblFechEjecucion.Text = "Fech de ejecucion:";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(65, 48);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(38, 13);
            this.lblHoras.TabIndex = 17;
            this.lblHoras.Text = "Horas:";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(109, 45);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(50, 20);
            this.txtHoras.TabIndex = 16;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Image = global::Proyecto_Bugs_Extendido.Properties.Resources.add;
            this.btnAgregarDetalle.Location = new System.Drawing.Point(589, 29);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(75, 40);
            this.btnAgregarDetalle.TabIndex = 15;
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // lblIdTester
            // 
            this.lblIdTester.AutoSize = true;
            this.lblIdTester.Location = new System.Drawing.Point(82, 22);
            this.lblIdTester.Name = "lblIdTester";
            this.lblIdTester.Size = new System.Drawing.Size(21, 13);
            this.lblIdTester.TabIndex = 12;
            this.lblIdTester.Text = "ID:";
            // 
            // txtIdTester
            // 
            this.txtIdTester.Enabled = false;
            this.txtIdTester.Location = new System.Drawing.Point(109, 19);
            this.txtIdTester.Name = "txtIdTester";
            this.txtIdTester.Size = new System.Drawing.Size(50, 20);
            this.txtIdTester.TabIndex = 11;
            // 
            // lblTester
            // 
            this.lblTester.AutoSize = true;
            this.lblTester.Location = new System.Drawing.Point(165, 22);
            this.lblTester.Name = "lblTester";
            this.lblTester.Size = new System.Drawing.Size(40, 13);
            this.lblTester.TabIndex = 14;
            this.lblTester.Text = "Tester:";
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.btnEditarDetalle);
            this.gbDetalle.Controls.Add(this.btnEliminarDetalle);
            this.gbDetalle.Controls.Add(this.grdDetalleCdP);
            this.gbDetalle.Location = new System.Drawing.Point(12, 302);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(670, 179);
            this.gbDetalle.TabIndex = 11;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle";
            // 
            // btnEditarDetalle
            // 
            this.btnEditarDetalle.Image = global::Proyecto_Bugs_Extendido.Properties.Resources.save_as;
            this.btnEditarDetalle.Location = new System.Drawing.Point(589, 133);
            this.btnEditarDetalle.Name = "btnEditarDetalle";
            this.btnEditarDetalle.Size = new System.Drawing.Size(75, 40);
            this.btnEditarDetalle.TabIndex = 18;
            this.btnEditarDetalle.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.Image = global::Proyecto_Bugs_Extendido.Properties.Resources.delete;
            this.btnEliminarDetalle.Location = new System.Drawing.Point(589, 87);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(75, 40);
            this.btnEliminarDetalle.TabIndex = 17;
            this.btnEliminarDetalle.UseVisualStyleBackColor = true;
            // 
            // grdDetalleCdP
            // 
            this.grdDetalleCdP.AllowUserToAddRows = false;
            this.grdDetalleCdP.AllowUserToDeleteRows = false;
            this.grdDetalleCdP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalleCdP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.casoDePrueba,
            this.tester,
            this.horas,
            this.fechaEjecucion});
            this.grdDetalleCdP.Location = new System.Drawing.Point(6, 19);
            this.grdDetalleCdP.Name = "grdDetalleCdP";
            this.grdDetalleCdP.ReadOnly = true;
            this.grdDetalleCdP.Size = new System.Drawing.Size(577, 154);
            this.grdDetalleCdP.TabIndex = 16;
            // 
            // casoDePrueba
            // 
            this.casoDePrueba.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.casoDePrueba.HeaderText = "Caso de prueba";
            this.casoDePrueba.Name = "casoDePrueba";
            this.casoDePrueba.ReadOnly = true;
            this.casoDePrueba.Width = 98;
            // 
            // tester
            // 
            this.tester.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tester.HeaderText = "Tester";
            this.tester.Name = "tester";
            this.tester.ReadOnly = true;
            this.tester.Width = 62;
            // 
            // horas
            // 
            this.horas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.horas.HeaderText = "Horas";
            this.horas.Name = "horas";
            this.horas.ReadOnly = true;
            this.horas.Width = 60;
            // 
            // fechaEjecucion
            // 
            this.fechaEjecucion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaEjecucion.HeaderText = "Fecha de ejecución";
            this.fechaEjecucion.Name = "fechaEjecucion";
            this.fechaEjecucion.ReadOnly = true;
            this.fechaEjecucion.Width = 115;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(489, 487);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 40);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(408, 487);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 40);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(607, 487);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 40);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevoCdP
            // 
            this.btnNuevoCdP.Location = new System.Drawing.Point(12, 487);
            this.btnNuevoCdP.Name = "btnNuevoCdP";
            this.btnNuevoCdP.Size = new System.Drawing.Size(75, 40);
            this.btnNuevoCdP.TabIndex = 15;
            this.btnNuevoCdP.Text = "Nuevo";
            this.btnNuevoCdP.UseVisualStyleBackColor = true;
            this.btnNuevoCdP.Click += new System.EventHandler(this.btnNuevoCdP_Click);
            // 
            // lblListar
            // 
            this.lblListar.Location = new System.Drawing.Point(96, 487);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(75, 40);
            this.lblListar.TabIndex = 16;
            this.lblListar.Text = "Listar";
            this.lblListar.UseVisualStyleBackColor = true;
            // 
            // cboNombreResponsable
            // 
            this.cboNombreResponsable.FormattingEnabled = true;
            this.cboNombreResponsable.Location = new System.Drawing.Point(443, 41);
            this.cboNombreResponsable.Name = "cboNombreResponsable";
            this.cboNombreResponsable.Size = new System.Drawing.Size(121, 21);
            this.cboNombreResponsable.TabIndex = 19;
            this.cboNombreResponsable.SelectionChangeCommitted += new System.EventHandler(this.cboNombreResponsable_SelectionChangeCommitted);
            // 
            // frmCiclosDePrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 543);
            this.Controls.Add(this.cboNombreResponsable);
            this.Controls.Add(this.lblListar);
            this.Controls.Add(this.btnNuevoCdP);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.gbCicloDePrueba);
            this.Controls.Add(this.txtIdResponsable);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblNameResponsable);
            this.Name = "frmCiclosDePrueba";
            this.Text = "frmCiclosDePrueba";
            this.Load += new System.EventHandler(this.frmCiclosDePrueba_Load);
            this.gbPlanDePrueba.ResumeLayout(false);
            this.gbPlanDePrueba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProyecto)).EndInit();
            this.gbCasoDePrueba.ResumeLayout(false);
            this.gbCasoDePrueba.PerformLayout();
            this.gbCicloDePrueba.ResumeLayout(false);
            this.gbCicloDePrueba.PerformLayout();
            this.gbDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleCdP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.TextBox txtIdResponsable;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label lblNameResponsable;
        private System.Windows.Forms.Label lblTituloCdP;
        private System.Windows.Forms.GroupBox gbPlanDePrueba;
        private System.Windows.Forms.GroupBox gbCicloDePrueba;
        private System.Windows.Forms.ComboBox cboNombrePlan;
        private System.Windows.Forms.Label lblNombrePdP;
        private System.Windows.Forms.Button btnNuevoCaso;
        private System.Windows.Forms.ComboBox cboTituloCaso;
        private System.Windows.Forms.GroupBox gbCasoDePrueba;
        private System.Windows.Forms.DataGridView grdProyecto;
        private System.Windows.Forms.Button btnNuevoPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn version;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.Label lblIdTester;
        private System.Windows.Forms.TextBox txtIdTester;
        private System.Windows.Forms.Label lblTester;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.DataGridView grdDetalleCdP;
        private System.Windows.Forms.DateTimePicker dtpFechaEjecucion;
        private System.Windows.Forms.Label lblFechEjecucion;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Button btnEditarDetalle;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn casoDePrueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn tester;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEjecucion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevoCdP;
        private System.Windows.Forms.Button lblListar;
        private System.Windows.Forms.ComboBox cboNombreTester;
        private System.Windows.Forms.ComboBox cboNombreResponsable;
    }
}