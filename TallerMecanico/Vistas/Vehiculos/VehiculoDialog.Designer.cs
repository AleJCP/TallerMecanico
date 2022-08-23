namespace TallerMecanico.Vistas.Vehiculos
{
    partial class VehiculoDialog
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
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textAnio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textTipo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textColor = new DevExpress.XtraEditors.TextEdit();
            this.textModelo = new DevExpress.XtraEditors.TextEdit();
            this.textMarca = new DevExpress.XtraEditors.TextEdit();
            this.txtPlaca = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCedula = new DevExpress.XtraEditors.SimpleButton();
            this.labelNombreApellido = new DevExpress.XtraEditors.LabelControl();
            this.textCedula = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textAnio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textModelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaca.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCedula.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(305, 424);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(158, 51);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.textAnio);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.textTipo);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.textColor);
            this.groupBox1.Controls.Add(this.textModelo);
            this.groupBox1.Controls.Add(this.textMarca);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 211);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Vehículo";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(419, 152);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 23);
            this.labelControl6.TabIndex = 20;
            this.labelControl6.Text = "Año";
            // 
            // textAnio
            // 
            this.textAnio.Location = new System.Drawing.Point(481, 145);
            this.textAnio.Name = "textAnio";
            this.textAnio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textAnio.Properties.Appearance.Options.UseFont = true;
            this.textAnio.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textAnio.Properties.MaskSettings.Set("mask", "d");
            this.textAnio.Properties.MaxLength = 4;
            this.textAnio.Size = new System.Drawing.Size(219, 30);
            this.textAnio.TabIndex = 19;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(419, 105);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 23);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Tipo";
            // 
            // textTipo
            // 
            this.textTipo.Location = new System.Drawing.Point(481, 98);
            this.textTipo.Name = "textTipo";
            this.textTipo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textTipo.Properties.Appearance.Options.UseFont = true;
            this.textTipo.Size = new System.Drawing.Size(219, 30);
            this.textTipo.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(413, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 23);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Color";
            // 
            // textColor
            // 
            this.textColor.Location = new System.Drawing.Point(481, 49);
            this.textColor.Name = "textColor";
            this.textColor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textColor.Properties.Appearance.Options.UseFont = true;
            this.textColor.Size = new System.Drawing.Size(219, 30);
            this.textColor.TabIndex = 6;
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(157, 145);
            this.textModelo.Name = "textModelo";
            this.textModelo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textModelo.Properties.Appearance.Options.UseFont = true;
            this.textModelo.Size = new System.Drawing.Size(219, 30);
            this.textModelo.TabIndex = 5;
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(157, 98);
            this.textMarca.Name = "textMarca";
            this.textMarca.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textMarca.Properties.Appearance.Options.UseFont = true;
            this.textMarca.Size = new System.Drawing.Size(219, 30);
            this.textMarca.TabIndex = 4;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(157, 49);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtPlaca.Properties.Appearance.Options.UseFont = true;
            this.txtPlaca.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtPlaca.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtPlaca.Properties.MaskSettings.Set("mask", "[0-9A-Z]{6,7}");
            this.txtPlaca.Size = new System.Drawing.Size(219, 30);
            this.txtPlaca.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(29, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nro. Placa";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(61, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 23);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Marca";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(54, 148);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 23);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Modelo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarCedula);
            this.groupBox2.Controls.Add(this.labelNombreApellido);
            this.groupBox2.Controls.Add(this.textCedula);
            this.groupBox2.Controls.Add(this.labelControl8);
            this.groupBox2.Controls.Add(this.labelControl9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 156);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // btnBuscarCedula
            // 
            this.btnBuscarCedula.Location = new System.Drawing.Point(481, 99);
            this.btnBuscarCedula.Name = "btnBuscarCedula";
            this.btnBuscarCedula.Size = new System.Drawing.Size(103, 29);
            this.btnBuscarCedula.TabIndex = 2;
            this.btnBuscarCedula.Text = "Buscar";
            this.btnBuscarCedula.Click += new System.EventHandler(this.btnBuscarCedula_Click);
            // 
            // labelNombreApellido
            // 
            this.labelNombreApellido.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelNombreApellido.Appearance.Options.UseFont = true;
            this.labelNombreApellido.Location = new System.Drawing.Point(236, 52);
            this.labelNombreApellido.Name = "labelNombreApellido";
            this.labelNombreApellido.Size = new System.Drawing.Size(188, 23);
            this.labelNombreApellido.TabIndex = 19;
            this.labelNombreApellido.Text = "... ... ... Vacío ... ... ...";
            // 
            // textCedula
            // 
            this.textCedula.Location = new System.Drawing.Point(236, 98);
            this.textCedula.Name = "textCedula";
            this.textCedula.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textCedula.Properties.Appearance.Options.UseFont = true;
            this.textCedula.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textCedula.Properties.MaskSettings.Set("mask", "d");
            this.textCedula.Properties.MaxLength = 8;
            this.textCedula.Size = new System.Drawing.Size(219, 30);
            this.textCedula.TabIndex = 1;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(29, 52);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(153, 23);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Nombre y Apellido";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(125, 105);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(57, 23);
            this.labelControl9.TabIndex = 1;
            this.labelControl9.Text = "Cédula";
            // 
            // VehiculoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "VehiculoDialog";
            this.Text = "VehiculoDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textAnio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaca.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCedula.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textTipo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textColor;
        private DevExpress.XtraEditors.TextEdit textModelo;
        private DevExpress.XtraEditors.TextEdit textMarca;
        private DevExpress.XtraEditors.TextEdit txtPlaca;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit textCedula;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelNombreApellido;
        private DevExpress.XtraEditors.SimpleButton btnBuscarCedula;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textAnio;
    }
}