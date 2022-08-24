namespace TallerMecanico.Vistas.Trabajos
{
    partial class TrabajoFiltroDialog
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lookUpEVehiculo = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpECliente = new DevExpress.XtraEditors.LookUpEdit();
            this.labelVehiculo = new DevExpress.XtraEditors.LabelControl();
            this.labelCliente = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditFecha = new DevExpress.XtraEditors.DateEdit();
            this.radioButtonMenor = new System.Windows.Forms.RadioButton();
            this.radioButtonMayor = new System.Windows.Forms.RadioButton();
            this.radioButtonIgual = new System.Windows.Forms.RadioButton();
            this.btnAplicarFiltro = new DevExpress.XtraEditors.SimpleButton();
            this.bindingSourceClientes = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceVehiculos = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEVehiculo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpECliente.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lookUpEVehiculo);
            this.groupBox2.Controls.Add(this.lookUpECliente);
            this.groupBox2.Controls.Add(this.labelVehiculo);
            this.groupBox2.Controls.Add(this.labelCliente);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox2.Location = new System.Drawing.Point(12, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 141);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente y Vehículo";
            // 
            // lookUpEVehiculo
            // 
            this.lookUpEVehiculo.Enabled = false;
            this.lookUpEVehiculo.Location = new System.Drawing.Point(96, 94);
            this.lookUpEVehiculo.Name = "lookUpEVehiculo";
            this.lookUpEVehiculo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lookUpEVehiculo.Properties.Appearance.Options.UseFont = true;
            this.lookUpEVehiculo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEVehiculo.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.lookUpEVehiculo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEVehiculo.Size = new System.Drawing.Size(200, 30);
            this.lookUpEVehiculo.TabIndex = 17;
            this.lookUpEVehiculo.EditValueChanged += new System.EventHandler(this.lookUpEVehiculo_EditValueChanged);
            // 
            // lookUpECliente
            // 
            this.lookUpECliente.Location = new System.Drawing.Point(96, 49);
            this.lookUpECliente.Name = "lookUpECliente";
            this.lookUpECliente.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lookUpECliente.Properties.Appearance.Options.UseFont = true;
            this.lookUpECliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpECliente.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.lookUpECliente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpECliente.Size = new System.Drawing.Size(200, 30);
            this.lookUpECliente.TabIndex = 16;
            this.lookUpECliente.EditValueChanged += new System.EventHandler(this.lookUpECliente_EditValueChanged);
            // 
            // labelVehiculo
            // 
            this.labelVehiculo.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelVehiculo.Appearance.Options.UseFont = true;
            this.labelVehiculo.Location = new System.Drawing.Point(331, 97);
            this.labelVehiculo.Name = "labelVehiculo";
            this.labelVehiculo.Size = new System.Drawing.Size(42, 23);
            this.labelVehiculo.TabIndex = 15;
            this.labelVehiculo.Text = "... ...";
            // 
            // labelCliente
            // 
            this.labelCliente.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelCliente.Appearance.Options.UseFont = true;
            this.labelCliente.Location = new System.Drawing.Point(331, 52);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(42, 23);
            this.labelCliente.TabIndex = 14;
            this.labelCliente.Text = "... ...";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(29, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 23);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Cliente";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 101);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 23);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Vehículo";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(41, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(135, 29);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Buscar Por...";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(27, 362);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(235, 16);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "(*) Dejar en blanco para no usar el filtro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMenor);
            this.groupBox1.Controls.Add(this.radioButtonMayor);
            this.groupBox1.Controls.Add(this.radioButtonIgual);
            this.groupBox1.Controls.Add(this.dateEditFecha);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(12, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 147);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(29, 52);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 23);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Fecha";
            // 
            // dateEditFecha
            // 
            this.dateEditFecha.EditValue = null;
            this.dateEditFecha.Location = new System.Drawing.Point(109, 49);
            this.dateEditFecha.Name = "dateEditFecha";
            this.dateEditFecha.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.dateEditFecha.Properties.Appearance.Options.UseFont = true;
            this.dateEditFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFecha.Size = new System.Drawing.Size(287, 30);
            this.dateEditFecha.TabIndex = 26;
            // 
            // radioButtonMenor
            // 
            this.radioButtonMenor.AutoSize = true;
            this.radioButtonMenor.Location = new System.Drawing.Point(73, 100);
            this.radioButtonMenor.Name = "radioButtonMenor";
            this.radioButtonMenor.Size = new System.Drawing.Size(91, 30);
            this.radioButtonMenor.TabIndex = 27;
            this.radioButtonMenor.Text = "Menor";
            this.radioButtonMenor.UseVisualStyleBackColor = true;
            // 
            // radioButtonMayor
            // 
            this.radioButtonMayor.AutoSize = true;
            this.radioButtonMayor.Location = new System.Drawing.Point(191, 100);
            this.radioButtonMayor.Name = "radioButtonMayor";
            this.radioButtonMayor.Size = new System.Drawing.Size(90, 30);
            this.radioButtonMayor.TabIndex = 28;
            this.radioButtonMayor.Text = "Mayor";
            this.radioButtonMayor.UseVisualStyleBackColor = true;
            // 
            // radioButtonIgual
            // 
            this.radioButtonIgual.AutoSize = true;
            this.radioButtonIgual.Checked = true;
            this.radioButtonIgual.Location = new System.Drawing.Point(319, 100);
            this.radioButtonIgual.Name = "radioButtonIgual";
            this.radioButtonIgual.Size = new System.Drawing.Size(77, 30);
            this.radioButtonIgual.TabIndex = 29;
            this.radioButtonIgual.TabStop = true;
            this.radioButtonIgual.Text = "Igual";
            this.radioButtonIgual.UseVisualStyleBackColor = true;
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Location = new System.Drawing.Point(253, 399);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(141, 40);
            this.btnAplicarFiltro.TabIndex = 26;
            this.btnAplicarFiltro.Text = "Aplicar";
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);
            // 
            // TrabajoFiltroDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 462);
            this.Controls.Add(this.btnAplicarFiltro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox2);
            this.Name = "TrabajoFiltroDialog";
            this.Text = "TrabajoFiltroDialog";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEVehiculo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpECliente.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.DateEdit dateEditFecha;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit lookUpEVehiculo;
        private DevExpress.XtraEditors.LookUpEdit lookUpECliente;
        private DevExpress.XtraEditors.LabelControl labelVehiculo;
        private DevExpress.XtraEditors.LabelControl labelCliente;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.RadioButton radioButtonMenor;
        private System.Windows.Forms.RadioButton radioButtonMayor;
        private System.Windows.Forms.RadioButton radioButtonIgual;
        private DevExpress.XtraEditors.SimpleButton btnAplicarFiltro;
        private System.Windows.Forms.BindingSource bindingSourceClientes;
        private System.Windows.Forms.BindingSource bindingSourceVehiculos;
    }
}