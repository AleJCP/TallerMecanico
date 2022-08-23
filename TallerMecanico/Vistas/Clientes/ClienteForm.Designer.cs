namespace TallerMecanico.Vistas.Clientes
{
    partial class ClienteForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDropCliente = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditCliente = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCliente = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlCliente = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bindingSourceCliente = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDropCliente);
            this.panel1.Controls.Add(this.btnEditCliente);
            this.panel1.Controls.Add(this.btnAddCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnDropCliente
            // 
            this.btnDropCliente.Location = new System.Drawing.Point(295, 33);
            this.btnDropCliente.Name = "btnDropCliente";
            this.btnDropCliente.Size = new System.Drawing.Size(112, 42);
            this.btnDropCliente.TabIndex = 2;
            this.btnDropCliente.Text = "Eliminar Cliente";
            this.btnDropCliente.Click += new System.EventHandler(this.btnDropCliente_Click);
            // 
            // btnEditCliente
            // 
            this.btnEditCliente.Location = new System.Drawing.Point(162, 33);
            this.btnEditCliente.Name = "btnEditCliente";
            this.btnEditCliente.Size = new System.Drawing.Size(112, 42);
            this.btnEditCliente.TabIndex = 1;
            this.btnEditCliente.Text = "Editar Cliente";
            this.btnEditCliente.Click += new System.EventHandler(this.btnEditCliente_Click);
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Location = new System.Drawing.Point(29, 33);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(112, 42);
            this.btnAddCliente.TabIndex = 0;
            this.btnAddCliente.Text = "Agregar Cliente";
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // gridControlCliente
            // 
            this.gridControlCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCliente.Location = new System.Drawing.Point(0, 100);
            this.gridControlCliente.MainView = this.gridView1;
            this.gridControlCliente.Name = "gridControlCliente";
            this.gridControlCliente.Size = new System.Drawing.Size(822, 397);
            this.gridControlCliente.TabIndex = 1;
            this.gridControlCliente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlCliente;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 497);
            this.Controls.Add(this.gridControlCliente);
            this.Controls.Add(this.panel1);
            this.Name = "ClienteForm";
            this.Text = "ClienteForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnDropCliente;
        private DevExpress.XtraEditors.SimpleButton btnEditCliente;
        private DevExpress.XtraEditors.SimpleButton btnAddCliente;
        private System.Windows.Forms.BindingSource bindingSourceCliente;
    }
}