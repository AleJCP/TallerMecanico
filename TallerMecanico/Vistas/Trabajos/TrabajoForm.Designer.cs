﻿namespace TallerMecanico.Vistas.Trabajos
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDropCliente = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditCliente = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTrabajo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 350);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDropCliente);
            this.panel1.Controls.Add(this.btnEditCliente);
            this.panel1.Controls.Add(this.btnAddTrabajo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnDropCliente
            // 
            this.btnDropCliente.Location = new System.Drawing.Point(336, 33);
            this.btnDropCliente.Name = "btnDropCliente";
            this.btnDropCliente.Size = new System.Drawing.Size(160, 42);
            this.btnDropCliente.TabIndex = 2;
            this.btnDropCliente.Text = "Eliminar Servicio Realizado";
            // 
            // btnEditCliente
            // 
            this.btnEditCliente.Location = new System.Drawing.Point(162, 33);
            this.btnEditCliente.Name = "btnEditCliente";
            this.btnEditCliente.Size = new System.Drawing.Size(154, 42);
            this.btnEditCliente.TabIndex = 1;
            this.btnEditCliente.Text = "Editar Servicio Realizado";
            // 
            // btnAddTrabajo
            // 
            this.btnAddTrabajo.Location = new System.Drawing.Point(29, 33);
            this.btnAddTrabajo.Name = "btnAddTrabajo";
            this.btnAddTrabajo.Size = new System.Drawing.Size(112, 42);
            this.btnAddTrabajo.TabIndex = 0;
            this.btnAddTrabajo.Text = "Realizar Servicio";
            // 
            // TrabajoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "TrabajoForm";
            this.Text = "TrabajoForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDropCliente;
        private DevExpress.XtraEditors.SimpleButton btnEditCliente;
        private DevExpress.XtraEditors.SimpleButton btnAddTrabajo;
    }
}