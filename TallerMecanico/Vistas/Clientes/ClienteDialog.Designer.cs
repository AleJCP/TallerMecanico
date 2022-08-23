namespace TallerMecanico.Vistas.Clientes
{
    partial class ClienteDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textDireccion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textTelefono = new DevExpress.XtraEditors.TextEdit();
            this.textCedula = new DevExpress.XtraEditors.TextEdit();
            this.textApellido = new DevExpress.XtraEditors.TextEdit();
            this.textNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCedula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textApellido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNombre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.textDireccion);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.textTelefono);
            this.groupBox1.Controls.Add(this.textCedula);
            this.groupBox1.Controls.Add(this.textApellido);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 293);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(41, 243);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 23);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Dirección";
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(157, 240);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textDireccion.Properties.Appearance.Options.UseFont = true;
            this.textDireccion.Size = new System.Drawing.Size(219, 30);
            this.textDireccion.TabIndex = 17;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(46, 195);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 23);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Teléfono";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(157, 192);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textTelefono.Properties.Appearance.Options.UseFont = true;
            this.textTelefono.Properties.MaskSettings.Set("mask", "d");
            this.textTelefono.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.textTelefono.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textTelefono.Properties.MaxLength = 10;
            this.textTelefono.Size = new System.Drawing.Size(219, 30);
            this.textTelefono.TabIndex = 15;
            // 
            // textCedula
            // 
            this.textCedula.Location = new System.Drawing.Point(157, 145);
            this.textCedula.Name = "textCedula";
            this.textCedula.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textCedula.Properties.Appearance.Options.UseFont = true;
            this.textCedula.Properties.MaskSettings.Set("mask", "d");
            this.textCedula.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.textCedula.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textCedula.Properties.MaxLength = 8;
            this.textCedula.Size = new System.Drawing.Size(219, 30);
            this.textCedula.TabIndex = 14;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(157, 98);
            this.textApellido.Name = "textApellido";
            this.textApellido.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textApellido.Properties.Appearance.Options.UseFont = true;
            this.textApellido.Size = new System.Drawing.Size(219, 30);
            this.textApellido.TabIndex = 13;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(157, 49);
            this.textNombre.Name = "textNombre";
            this.textNombre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textNombre.Properties.Appearance.Options.UseFont = true;
            this.textNombre.Size = new System.Drawing.Size(219, 30);
            this.textNombre.TabIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(29, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nombre(s)";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(31, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 23);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Apellido(s)";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(61, 148);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 23);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Cédula";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(149, 341);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(130, 51);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "Guardar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ClienteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 420);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClienteDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClienteDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCedula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textApellido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNombre.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textNombre;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textDireccion;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textTelefono;
        private DevExpress.XtraEditors.TextEdit textCedula;
        private DevExpress.XtraEditors.TextEdit textApellido;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}