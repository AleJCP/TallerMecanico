namespace TallerMecanico.Vistas.Vehiculos
{
    partial class CedulaFiltroDialog
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
            this.btnBuscarCedula = new DevExpress.XtraEditors.SimpleButton();
            this.textCedula = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textCedula.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarCedula
            // 
            this.btnBuscarCedula.Location = new System.Drawing.Point(343, 32);
            this.btnBuscarCedula.Name = "btnBuscarCedula";
            this.btnBuscarCedula.Size = new System.Drawing.Size(103, 29);
            this.btnBuscarCedula.TabIndex = 3;
            this.btnBuscarCedula.Text = "Mostrar Vehículos";
            this.btnBuscarCedula.Click += new System.EventHandler(this.btnBuscarCedula_Click);
            // 
            // textCedula
            // 
            this.textCedula.Location = new System.Drawing.Point(98, 29);
            this.textCedula.Name = "textCedula";
            this.textCedula.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textCedula.Properties.Appearance.Options.UseFont = true;
            this.textCedula.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textCedula.Properties.MaskSettings.Set("mask", "d");
            this.textCedula.Properties.MaxLength = 8;
            this.textCedula.Size = new System.Drawing.Size(219, 30);
            this.textCedula.TabIndex = 2;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(21, 32);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(57, 23);
            this.labelControl9.TabIndex = 4;
            this.labelControl9.Text = "Cédula";
            // 
            // CedulaFiltroDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 80);
            this.Controls.Add(this.btnBuscarCedula);
            this.Controls.Add(this.textCedula);
            this.Controls.Add(this.labelControl9);
            this.Name = "CedulaFiltroDialog";
            this.Text = "CedulaFiltroDialog";
            ((System.ComponentModel.ISupportInitialize)(this.textCedula.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBuscarCedula;
        private DevExpress.XtraEditors.TextEdit textCedula;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}