namespace TallerMecanico.Vistas
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnTrabajos = new DevExpress.XtraEditors.SimpleButton();
            this.btnCerrarS = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.btnServicios = new DevExpress.XtraEditors.SimpleButton();
            this.btnVehiculos = new DevExpress.XtraEditors.SimpleButton();
            this.btnClientes = new DevExpress.XtraEditors.SimpleButton();
            this.btnMenu = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainLabel = new DevExpress.XtraEditors.LabelControl();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnMenuTool = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelUsuario = new DevExpress.XtraEditors.LabelControl();
            this.MenuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.MenuPanel.Controls.Add(this.btnTrabajos);
            this.MenuPanel.Controls.Add(this.btnCerrarS);
            this.MenuPanel.Controls.Add(this.btnSalir);
            this.MenuPanel.Controls.Add(this.btnServicios);
            this.MenuPanel.Controls.Add(this.btnVehiculos);
            this.MenuPanel.Controls.Add(this.btnClientes);
            this.MenuPanel.Controls.Add(this.btnMenu);
            this.MenuPanel.Controls.Add(this.panel2);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(244, 661);
            this.MenuPanel.TabIndex = 0;
            // 
            // btnTrabajos
            // 
            this.btnTrabajos.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnTrabajos.Appearance.Options.UseFont = true;
            this.btnTrabajos.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnTrabajos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTrabajos.ImageOptions.SvgImage")));
            this.btnTrabajos.Location = new System.Drawing.Point(0, 426);
            this.btnTrabajos.Name = "btnTrabajos";
            this.btnTrabajos.Size = new System.Drawing.Size(244, 69);
            this.btnTrabajos.TabIndex = 5;
            this.btnTrabajos.Text = "Servicios Realizados";
            this.btnTrabajos.Click += new System.EventHandler(this.btnTrabajos_Click);
            // 
            // btnCerrarS
            // 
            this.btnCerrarS.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarS.ImageOptions.Image")));
            this.btnCerrarS.Location = new System.Drawing.Point(138, 580);
            this.btnCerrarS.Name = "btnCerrarS";
            this.btnCerrarS.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCerrarS.Size = new System.Drawing.Size(71, 69);
            this.btnCerrarS.TabIndex = 7;
            this.btnCerrarS.Click += new System.EventHandler(this.btnCerrarS_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(12, 580);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSalir.Size = new System.Drawing.Size(71, 69);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnServicios.Appearance.Options.UseFont = true;
            this.btnServicios.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnServicios.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnServicios.ImageOptions.SvgImage")));
            this.btnServicios.Location = new System.Drawing.Point(0, 351);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(244, 69);
            this.btnServicios.TabIndex = 4;
            this.btnServicios.Text = "Servicios (Oferta)";
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnVehiculos.Appearance.Options.UseFont = true;
            this.btnVehiculos.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnVehiculos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnVehiculos.ImageOptions.SvgImage")));
            this.btnVehiculos.Location = new System.Drawing.Point(0, 276);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(244, 69);
            this.btnVehiculos.TabIndex = 3;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnClientes.Appearance.Options.UseFont = true;
            this.btnClientes.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnClientes.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClientes.ImageOptions.SvgImage")));
            this.btnClientes.Location = new System.Drawing.Point(0, 201);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(244, 69);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnMenu.Appearance.Options.UseFont = true;
            this.btnMenu.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMenu.ImageOptions.SvgImage")));
            this.btnMenu.Location = new System.Drawing.Point(0, 126);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(244, 69);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu Principal";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelUsuario);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.panel3.Controls.Add(this.btnMenuTool);
            this.panel3.Controls.Add(this.mainLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(244, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(916, 100);
            this.panel3.TabIndex = 1;
            // 
            // mainLabel
            // 
            this.mainLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.mainLabel.Appearance.ForeColor = System.Drawing.Color.White;
            this.mainLabel.Appearance.Options.UseFont = true;
            this.mainLabel.Appearance.Options.UseForeColor = true;
            this.mainLabel.Location = new System.Drawing.Point(271, 41);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(253, 40);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Menu Principal";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(244, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(916, 561);
            this.mainPanel.TabIndex = 2;
            // 
            // btnMenuTool
            // 
            this.btnMenuTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenuTool.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnMenuTool.Location = new System.Drawing.Point(22, 13);
            this.btnMenuTool.Name = "btnMenuTool";
            this.btnMenuTool.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMenuTool.Size = new System.Drawing.Size(71, 70);
            this.btnMenuTool.TabIndex = 1;
            this.btnMenuTool.Click += new System.EventHandler(this.btnMenuTool_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(12, 13);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(71, 70);
            this.simpleButton2.TabIndex = 2;
            // 
            // labelUsuario
            // 
            this.labelUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline);
            this.labelUsuario.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Appearance.Options.UseFont = true;
            this.labelUsuario.Appearance.Options.UseForeColor = true;
            this.labelUsuario.Location = new System.Drawing.Point(103, 41);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(117, 19);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Nombre apellido";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 661);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.MenuPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MenuPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private DevExpress.XtraEditors.SimpleButton btnMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel mainPanel;
        private DevExpress.XtraEditors.SimpleButton btnCerrarS;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.SimpleButton btnServicios;
        private DevExpress.XtraEditors.SimpleButton btnVehiculos;
        private DevExpress.XtraEditors.SimpleButton btnClientes;
        private DevExpress.XtraEditors.LabelControl mainLabel;
        private DevExpress.XtraEditors.SimpleButton btnTrabajos;
        private DevExpress.XtraEditors.LabelControl labelUsuario;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnMenuTool;
    }
}