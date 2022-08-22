namespace TallerMecanico.Vistas.Vehiculos
{
    partial class VehiculoForm
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
            this.gridControlVehiculo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDropVehiculo = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditVehiculo = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddVehiculo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlVehiculo
            // 
            this.gridControlVehiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlVehiculo.Location = new System.Drawing.Point(0, 100);
            this.gridControlVehiculo.MainView = this.gridView1;
            this.gridControlVehiculo.Name = "gridControlVehiculo";
            this.gridControlVehiculo.Size = new System.Drawing.Size(800, 350);
            this.gridControlVehiculo.TabIndex = 3;
            this.gridControlVehiculo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlVehiculo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDropVehiculo);
            this.panel1.Controls.Add(this.btnEditVehiculo);
            this.panel1.Controls.Add(this.btnAddVehiculo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnDropVehiculo
            // 
            this.btnDropVehiculo.Location = new System.Drawing.Point(295, 33);
            this.btnDropVehiculo.Name = "btnDropVehiculo";
            this.btnDropVehiculo.Size = new System.Drawing.Size(112, 42);
            this.btnDropVehiculo.TabIndex = 2;
            this.btnDropVehiculo.Text = "Eliminar Vehiculo";
            // 
            // btnEditVehiculo
            // 
            this.btnEditVehiculo.Location = new System.Drawing.Point(162, 33);
            this.btnEditVehiculo.Name = "btnEditVehiculo";
            this.btnEditVehiculo.Size = new System.Drawing.Size(112, 42);
            this.btnEditVehiculo.TabIndex = 1;
            this.btnEditVehiculo.Text = "Editar Vehiculo";
            // 
            // btnAddVehiculo
            // 
            this.btnAddVehiculo.Location = new System.Drawing.Point(29, 33);
            this.btnAddVehiculo.Name = "btnAddVehiculo";
            this.btnAddVehiculo.Size = new System.Drawing.Size(112, 42);
            this.btnAddVehiculo.TabIndex = 0;
            this.btnAddVehiculo.Text = "Agregar Vehiculo";
            // 
            // VehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControlVehiculo);
            this.Controls.Add(this.panel1);
            this.Name = "VehiculoForm";
            this.Text = "VehiculoForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlVehiculo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDropVehiculo;
        private DevExpress.XtraEditors.SimpleButton btnEditVehiculo;
        private DevExpress.XtraEditors.SimpleButton btnAddVehiculo;
    }
}