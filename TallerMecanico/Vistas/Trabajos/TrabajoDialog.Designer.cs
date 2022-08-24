namespace TallerMecanico.Vistas.Trabajos
{
    partial class TrabajoDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddTrabajo = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnDropTrabajo = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlTrabajos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEServicios = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSetToday = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditFecha = new DevExpress.XtraEditors.DateEdit();
            this.textComentario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lookUpEVehiculo = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpECliente = new DevExpress.XtraEditors.LookUpEdit();
            this.labelVehiculo = new DevExpress.XtraEditors.LabelControl();
            this.labelCliente = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.bindingSourceClientes = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceVehiculos = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceServicios = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTrabajos = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTrabajos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEServicios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textComentario.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEVehiculo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpECliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTrabajos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddTrabajo);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.btnDropTrabajo);
            this.groupBox1.Controls.Add(this.gridControlTrabajos);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.lookUpEServicios);
            this.groupBox1.Controls.Add(this.btnSetToday);
            this.groupBox1.Controls.Add(this.dateEditFecha);
            this.groupBox1.Controls.Add(this.textComentario);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 466);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle del servicio";
            // 
            // btnAddTrabajo
            // 
            this.btnAddTrabajo.Location = new System.Drawing.Point(444, 88);
            this.btnAddTrabajo.Name = "btnAddTrabajo";
            this.btnAddTrabajo.Size = new System.Drawing.Size(96, 31);
            this.btnAddTrabajo.TabIndex = 28;
            this.btnAddTrabajo.Text = "Agregar Servicio";
            this.btnAddTrabajo.Click += new System.EventHandler(this.btnAddTrabajo_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(29, 132);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(172, 23);
            this.labelControl6.TabIndex = 27;
            this.labelControl6.Text = "Servicios a Contratar";
            // 
            // btnDropTrabajo
            // 
            this.btnDropTrabajo.Location = new System.Drawing.Point(560, 88);
            this.btnDropTrabajo.Name = "btnDropTrabajo";
            this.btnDropTrabajo.Size = new System.Drawing.Size(165, 31);
            this.btnDropTrabajo.TabIndex = 26;
            this.btnDropTrabajo.Text = "Eliminar Servicio de la Lista";
            this.btnDropTrabajo.Click += new System.EventHandler(this.btnDropTrabajo_Click);
            // 
            // gridControlTrabajos
            // 
            this.gridControlTrabajos.Location = new System.Drawing.Point(15, 161);
            this.gridControlTrabajos.MainView = this.gridView1;
            this.gridControlTrabajos.Name = "gridControlTrabajos";
            this.gridControlTrabajos.Size = new System.Drawing.Size(710, 235);
            this.gridControlTrabajos.TabIndex = 25;
            this.gridControlTrabajos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlTrabajos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(15, 92);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(164, 23);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Servicio a Contratar";
            // 
            // lookUpEServicios
            // 
            this.lookUpEServicios.Location = new System.Drawing.Point(194, 89);
            this.lookUpEServicios.Name = "lookUpEServicios";
            this.lookUpEServicios.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lookUpEServicios.Properties.Appearance.Options.UseFont = true;
            this.lookUpEServicios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEServicios.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.lookUpEServicios.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEServicios.Size = new System.Drawing.Size(229, 30);
            this.lookUpEServicios.TabIndex = 18;
            // 
            // btnSetToday
            // 
            this.btnSetToday.Location = new System.Drawing.Point(511, 47);
            this.btnSetToday.Name = "btnSetToday";
            this.btnSetToday.Size = new System.Drawing.Size(214, 31);
            this.btnSetToday.TabIndex = 24;
            this.btnSetToday.Text = "Hoy";
            this.btnSetToday.Click += new System.EventHandler(this.btnSetToday_Click);
            // 
            // dateEditFecha
            // 
            this.dateEditFecha.EditValue = null;
            this.dateEditFecha.Location = new System.Drawing.Point(194, 48);
            this.dateEditFecha.Name = "dateEditFecha";
            this.dateEditFecha.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.dateEditFecha.Properties.Appearance.Options.UseFont = true;
            this.dateEditFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFecha.Size = new System.Drawing.Size(297, 30);
            this.dateEditFecha.TabIndex = 24;
            // 
            // textComentario
            // 
            this.textComentario.EditValue = "";
            this.textComentario.Location = new System.Drawing.Point(177, 417);
            this.textComentario.Name = "textComentario";
            this.textComentario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textComentario.Properties.Appearance.Options.UseFont = true;
            this.textComentario.Size = new System.Drawing.Size(548, 30);
            this.textComentario.TabIndex = 12;
            this.textComentario.ToolTip = "Opcional";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(40, 420);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Comentario(s)";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(129, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 23);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Fecha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lookUpEVehiculo);
            this.groupBox2.Controls.Add(this.lookUpECliente);
            this.groupBox2.Controls.Add(this.labelVehiculo);
            this.groupBox2.Controls.Add(this.labelCliente);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 157);
            this.groupBox2.TabIndex = 22;
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
            this.labelVehiculo.Location = new System.Drawing.Point(354, 101);
            this.labelVehiculo.Name = "labelVehiculo";
            this.labelVehiculo.Size = new System.Drawing.Size(42, 23);
            this.labelVehiculo.TabIndex = 15;
            this.labelVehiculo.Text = "... ...";
            // 
            // labelCliente
            // 
            this.labelCliente.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelCliente.Appearance.Options.UseFont = true;
            this.labelCliente.Location = new System.Drawing.Point(354, 52);
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
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(316, 672);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 51);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // TrabajoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 735);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TrabajoDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TrabajoDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTrabajos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEServicios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textComentario.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEVehiculo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpECliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTrabajos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit textComentario;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelVehiculo;
        private DevExpress.XtraEditors.LabelControl labelCliente;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.DateEdit dateEditFecha;
        private DevExpress.XtraEditors.SimpleButton btnSetToday;
        private DevExpress.XtraEditors.LookUpEdit lookUpEVehiculo;
        private DevExpress.XtraEditors.LookUpEdit lookUpECliente;
        private System.Windows.Forms.BindingSource bindingSourceClientes;
        private System.Windows.Forms.BindingSource bindingSourceVehiculos;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnDropTrabajo;
        private DevExpress.XtraGrid.GridControl gridControlTrabajos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lookUpEServicios;
        private System.Windows.Forms.BindingSource bindingSourceServicios;
        private System.Windows.Forms.BindingSource bindingSourceTrabajos;
        private DevExpress.XtraEditors.SimpleButton btnAddTrabajo;
    }
}