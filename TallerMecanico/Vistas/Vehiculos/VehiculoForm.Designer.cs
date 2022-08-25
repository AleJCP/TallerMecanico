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
            this.components = new System.ComponentModel.Container();
            this.gridControlVehiculo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTextShow = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDropVehiculo = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditVehiculo = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddVehiculo = new DevExpress.XtraEditors.SimpleButton();
            this.bindingSourceVehiculo = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlVehiculo
            // 
            this.gridControlVehiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlVehiculo.Location = new System.Drawing.Point(0, 112);
            this.gridControlVehiculo.MainView = this.gridView1;
            this.gridControlVehiculo.Name = "gridControlVehiculo";
            this.gridControlVehiculo.Size = new System.Drawing.Size(797, 338);
            this.gridControlVehiculo.TabIndex = 3;
            this.gridControlVehiculo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControlVehiculo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTextShow);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btnDropVehiculo);
            this.panel1.Controls.Add(this.btnEditVehiculo);
            this.panel1.Controls.Add(this.btnAddVehiculo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 112);
            this.panel1.TabIndex = 2;
            // 
            // labelTextShow
            // 
            this.labelTextShow.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelTextShow.Appearance.Options.UseFont = true;
            this.labelTextShow.Location = new System.Drawing.Point(462, 93);
            this.labelTextShow.Name = "labelTextShow";
            this.labelTextShow.Size = new System.Drawing.Size(95, 16);
            this.labelTextShow.TabIndex = 5;
            this.labelTextShow.Text = "Mostrando todos";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(680, 33);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 42);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Mostrar Todo";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(507, 33);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(155, 42);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Mostrar Vehiculos por Cliente";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnDropVehiculo
            // 
            this.btnDropVehiculo.Location = new System.Drawing.Point(295, 33);
            this.btnDropVehiculo.Name = "btnDropVehiculo";
            this.btnDropVehiculo.Size = new System.Drawing.Size(112, 42);
            this.btnDropVehiculo.TabIndex = 2;
            this.btnDropVehiculo.Text = "Eliminar Vehiculo";
            this.btnDropVehiculo.Click += new System.EventHandler(this.btnDropVehiculo_Click);
            // 
            // btnEditVehiculo
            // 
            this.btnEditVehiculo.Location = new System.Drawing.Point(162, 33);
            this.btnEditVehiculo.Name = "btnEditVehiculo";
            this.btnEditVehiculo.Size = new System.Drawing.Size(112, 42);
            this.btnEditVehiculo.TabIndex = 1;
            this.btnEditVehiculo.Text = "Editar Vehiculo";
            this.btnEditVehiculo.Click += new System.EventHandler(this.btnEditVehiculo_Click);
            // 
            // btnAddVehiculo
            // 
            this.btnAddVehiculo.Location = new System.Drawing.Point(29, 33);
            this.btnAddVehiculo.Name = "btnAddVehiculo";
            this.btnAddVehiculo.Size = new System.Drawing.Size(112, 42);
            this.btnAddVehiculo.TabIndex = 0;
            this.btnAddVehiculo.Text = "Agregar Vehiculo";
            this.btnAddVehiculo.Click += new System.EventHandler(this.btnAddVehiculo_Click);
            // 
            // VehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.gridControlVehiculo);
            this.Controls.Add(this.panel1);
            this.Name = "VehiculoForm";
            this.Text = "VehiculoForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlVehiculo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDropVehiculo;
        private DevExpress.XtraEditors.SimpleButton btnEditVehiculo;
        private DevExpress.XtraEditors.SimpleButton btnAddVehiculo;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource bindingSourceVehiculo;
        private DevExpress.XtraEditors.LabelControl labelTextShow;
    }
}