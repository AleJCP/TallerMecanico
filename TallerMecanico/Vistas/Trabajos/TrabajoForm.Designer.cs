namespace TallerMecanico.Vistas.Trabajos
{
    partial class TrabajoForm
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
            this.gridControlTrabajos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTextShow = new DevExpress.XtraEditors.LabelControl();
            this.btnMostrarTodo = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.btnDetalles = new DevExpress.XtraEditors.SimpleButton();
            this.btnDropCliente = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditCliente = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTrabajo = new DevExpress.XtraEditors.SimpleButton();
            this.bindingSourceTrabajos = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTrabajos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTrabajos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlTrabajos
            // 
            this.gridControlTrabajos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTrabajos.Location = new System.Drawing.Point(0, 100);
            this.gridControlTrabajos.MainView = this.gridView1;
            this.gridControlTrabajos.Name = "gridControlTrabajos";
            this.gridControlTrabajos.Size = new System.Drawing.Size(800, 350);
            this.gridControlTrabajos.TabIndex = 3;
            this.gridControlTrabajos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControlTrabajos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTextShow);
            this.panel1.Controls.Add(this.btnMostrarTodo);
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.btnDetalles);
            this.panel1.Controls.Add(this.btnDropCliente);
            this.panel1.Controls.Add(this.btnEditCliente);
            this.panel1.Controls.Add(this.btnAddTrabajo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
            // 
            // labelTextShow
            // 
            this.labelTextShow.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelTextShow.Appearance.Options.UseFont = true;
            this.labelTextShow.Location = new System.Drawing.Point(364, 65);
            this.labelTextShow.Name = "labelTextShow";
            this.labelTextShow.Size = new System.Drawing.Size(95, 16);
            this.labelTextShow.TabIndex = 8;
            this.labelTextShow.Text = "Mostrando todos";
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(583, 12);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(199, 37);
            this.btnMostrarTodo.TabIndex = 5;
            this.btnMostrarTodo.Text = "Mostrar Todos";
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(344, 12);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(205, 37);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar...";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(179, 54);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(137, 40);
            this.btnDetalles.TabIndex = 3;
            this.btnDetalles.Text = "Mostrar Detalles";
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnDropCliente
            // 
            this.btnDropCliente.Location = new System.Drawing.Point(179, 12);
            this.btnDropCliente.Name = "btnDropCliente";
            this.btnDropCliente.Size = new System.Drawing.Size(137, 37);
            this.btnDropCliente.TabIndex = 2;
            this.btnDropCliente.Text = "Eliminar Servicio Realizado";
            this.btnDropCliente.Click += new System.EventHandler(this.btnDropCliente_Click);
            // 
            // btnEditCliente
            // 
            this.btnEditCliente.Location = new System.Drawing.Point(25, 55);
            this.btnEditCliente.Name = "btnEditCliente";
            this.btnEditCliente.Size = new System.Drawing.Size(132, 39);
            this.btnEditCliente.TabIndex = 1;
            this.btnEditCliente.Text = "Editar Servicio Realizado";
            this.btnEditCliente.Click += new System.EventHandler(this.btnEditCliente_Click);
            // 
            // btnAddTrabajo
            // 
            this.btnAddTrabajo.Location = new System.Drawing.Point(25, 12);
            this.btnAddTrabajo.Name = "btnAddTrabajo";
            this.btnAddTrabajo.Size = new System.Drawing.Size(132, 37);
            this.btnAddTrabajo.TabIndex = 0;
            this.btnAddTrabajo.Text = "Realizar Servicio";
            this.btnAddTrabajo.Click += new System.EventHandler(this.btnAddTrabajo_Click);
            // 
            // TrabajoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControlTrabajos);
            this.Controls.Add(this.panel1);
            this.Name = "TrabajoForm";
            this.Text = "TrabajoForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTrabajos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTrabajos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlTrabajos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDropCliente;
        private DevExpress.XtraEditors.SimpleButton btnEditCliente;
        private DevExpress.XtraEditors.SimpleButton btnAddTrabajo;
        private System.Windows.Forms.BindingSource bindingSourceTrabajos;
        private DevExpress.XtraEditors.SimpleButton btnMostrarTodo;
        private DevExpress.XtraEditors.SimpleButton btnFiltrar;
        private DevExpress.XtraEditors.SimpleButton btnDetalles;
        public DevExpress.XtraEditors.LabelControl labelTextShow;
    }
}