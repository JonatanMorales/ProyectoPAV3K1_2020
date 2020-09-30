namespace Proyecto_Bugs_Extendido.Presentacion
{
    partial class frmPlanDePruebaABM
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombrePlan = new System.Windows.Forms.Label();
            this.cboResponsable = new System.Windows.Forms.ComboBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.gbPlanDePrueba = new System.Windows.Forms.GroupBox();
            this.gbProyectoPlan = new System.Windows.Forms.GroupBox();
            this.grdProyectoPlan = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alcance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPlanDePrueba.SuspendLayout();
            this.gbProyectoPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProyectoPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(78, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(105, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(50, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(347, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombrePlan
            // 
            this.lblNombrePlan.AutoSize = true;
            this.lblNombrePlan.Location = new System.Drawing.Point(294, 22);
            this.lblNombrePlan.Name = "lblNombrePlan";
            this.lblNombrePlan.Size = new System.Drawing.Size(47, 13);
            this.lblNombrePlan.TabIndex = 1;
            this.lblNombrePlan.Text = "Nombre:";
            // 
            // cboResponsable
            // 
            this.cboResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResponsable.FormattingEnabled = true;
            this.cboResponsable.Location = new System.Drawing.Point(347, 45);
            this.cboResponsable.Name = "cboResponsable";
            this.cboResponsable.Size = new System.Drawing.Size(150, 21);
            this.cboResponsable.TabIndex = 5;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(269, 48);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(72, 13);
            this.lblResponsable.TabIndex = 5;
            this.lblResponsable.Text = "Responsable:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(105, 46);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(150, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(33, 48);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // gbPlanDePrueba
            // 
            this.gbPlanDePrueba.Controls.Add(this.gbProyectoPlan);
            this.gbPlanDePrueba.Controls.Add(this.txtID);
            this.gbPlanDePrueba.Controls.Add(this.txtDescripcion);
            this.gbPlanDePrueba.Controls.Add(this.lblID);
            this.gbPlanDePrueba.Controls.Add(this.lblDescripcion);
            this.gbPlanDePrueba.Controls.Add(this.lblNombrePlan);
            this.gbPlanDePrueba.Controls.Add(this.lblResponsable);
            this.gbPlanDePrueba.Controls.Add(this.txtNombre);
            this.gbPlanDePrueba.Controls.Add(this.cboResponsable);
            this.gbPlanDePrueba.Location = new System.Drawing.Point(12, 12);
            this.gbPlanDePrueba.Name = "gbPlanDePrueba";
            this.gbPlanDePrueba.Size = new System.Drawing.Size(537, 338);
            this.gbPlanDePrueba.TabIndex = 0;
            this.gbPlanDePrueba.TabStop = false;
            this.gbPlanDePrueba.Text = "Plan de prueba";
            // 
            // gbProyectoPlan
            // 
            this.gbProyectoPlan.Controls.Add(this.grdProyectoPlan);
            this.gbProyectoPlan.Location = new System.Drawing.Point(6, 72);
            this.gbProyectoPlan.Name = "gbProyectoPlan";
            this.gbProyectoPlan.Size = new System.Drawing.Size(525, 260);
            this.gbProyectoPlan.TabIndex = 6;
            this.gbProyectoPlan.TabStop = false;
            this.gbProyectoPlan.Text = "Proyecto";
            // 
            // grdProyectoPlan
            // 
            this.grdProyectoPlan.AllowUserToAddRows = false;
            this.grdProyectoPlan.AllowUserToDeleteRows = false;
            this.grdProyectoPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProyectoPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.producto,
            this.responsable,
            this.descripcion,
            this.version,
            this.alcance});
            this.grdProyectoPlan.Location = new System.Drawing.Point(6, 19);
            this.grdProyectoPlan.MultiSelect = false;
            this.grdProyectoPlan.Name = "grdProyectoPlan";
            this.grdProyectoPlan.ReadOnly = true;
            this.grdProyectoPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProyectoPlan.Size = new System.Drawing.Size(513, 235);
            this.grdProyectoPlan.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Proyecto_Bugs_Extendido.Properties.Resources.save;
            this.btnGuardar.Location = new System.Drawing.Point(393, 358);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 40);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Proyecto_Bugs_Extendido.Properties.Resources.cancel;
            this.btnCancelar.Location = new System.Drawing.Point(474, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 40);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // responsable
            // 
            this.responsable.HeaderText = "Responsable";
            this.responsable.Name = "responsable";
            this.responsable.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // version
            // 
            this.version.HeaderText = "Versión";
            this.version.Name = "version";
            this.version.ReadOnly = true;
            // 
            // alcance
            // 
            this.alcance.HeaderText = "Alcance";
            this.alcance.Name = "alcance";
            this.alcance.ReadOnly = true;
            // 
            // frmPlanDePruebaABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 410);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbPlanDePrueba);
            this.Name = "frmPlanDePruebaABM";
            this.Text = "frcPlanDePruebaABM";
            this.Load += new System.EventHandler(this.frmPlanDePruebaABM_Load);
            this.gbPlanDePrueba.ResumeLayout(false);
            this.gbPlanDePrueba.PerformLayout();
            this.gbProyectoPlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProyectoPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombrePlan;
        private System.Windows.Forms.ComboBox cboResponsable;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.GroupBox gbPlanDePrueba;
        private System.Windows.Forms.GroupBox gbProyectoPlan;
        private System.Windows.Forms.DataGridView grdProyectoPlan;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn version;
        private System.Windows.Forms.DataGridViewTextBoxColumn alcance;
    }
}