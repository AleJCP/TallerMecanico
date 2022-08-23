namespace TallerMecanico.Vistas.Servicios
{
    partial class ServicioForm
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
            this.gridControlServicio = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDropCliente = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditCliente = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddServicio = new DevExpress.XtraEditors.SimpleButton();
            this.bindingSourceServicio = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlServicio
            // 
            this.gridControlServicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlServicio.Location = new System.Drawing.Point(0, 100);
            this.gridControlServicio.MainView = this.gridView1;
            this.gridControlServicio.Name = "gridControlServicio";
            this.gridControlServicio.Size = new System.Drawing.Size(832, 407);
            this.gridControlServicio.TabIndex = 3;
            this.gridControlServicio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlServicio;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDropCliente);
            this.panel1.Controls.Add(this.btnEditCliente);
            this.panel1.Controls.Add(this.btnAddServicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnDropCliente
            // 
            this.btnDropCliente.Location = new System.Drawing.Point(295, 33);
            this.btnDropCliente.Name = "btnDropCliente";
            this.btnDropCliente.Size = new System.Drawing.Size(112, 42);
            this.btnDropCliente.TabIndex = 2;
            this.btnDropCliente.Text = "Eliminar Servicio";
            this.btnDropCliente.Click += new System.EventHandler(this.btnDropCliente_Click);
            // 
            // btnEditCliente
            // 
            this.btnEditCliente.Location = new System.Drawing.Point(162, 33);
            this.btnEditCliente.Name = "btnEditCliente";
            this.btnEditCliente.Size = new System.Drawing.Size(112, 42);
            this.btnEditCliente.TabIndex = 1;
            this.btnEditCliente.Text = "Editar Servicio";
            this.btnEditCliente.Click += new System.EventHandler(this.btnEditCliente_Click);
            // 
            // btnAddServicio
            // 
            this.btnAddServicio.Location = new System.Drawing.Point(29, 33);
            this.btnAddServicio.Name = "btnAddServicio";
            this.btnAddServicio.Size = new System.Drawing.Size(112, 42);
            this.btnAddServicio.TabIndex = 0;
            this.btnAddServicio.Text = "Agregar Servicio";
            this.btnAddServicio.Click += new System.EventHandler(this.btnAddServicio_Click);
            // 
            // ServicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 507);
            this.Controls.Add(this.gridControlServicio);
            this.Controls.Add(this.panel1);
            this.Name = "ServicioForm";
            this.Text = "ServicioForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceServicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlServicio;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDropCliente;
        private DevExpress.XtraEditors.SimpleButton btnEditCliente;
        private DevExpress.XtraEditors.SimpleButton btnAddServicio;
        private System.Windows.Forms.BindingSource bindingSourceServicio;
    }
}