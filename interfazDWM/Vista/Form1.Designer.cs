namespace interfazDWM
{
    partial class menuDWM
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuDWM));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnOperaciones = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnAcercade = new System.Windows.Forms.Button();
            this.btnCuentas = new System.Windows.Forms.Button();
            this.btnMovimiento = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelHora = new System.Windows.Forms.Panel();
            this.hora = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.panelHora.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuVertical.Controls.Add(this.btnSalir);
            this.menuVertical.Controls.Add(this.btnHome);
            this.menuVertical.Controls.Add(this.btnOperaciones);
            this.menuVertical.Controls.Add(this.btnCategorias);
            this.menuVertical.Controls.Add(this.btnAcercade);
            this.menuVertical.Controls.Add(this.btnCuentas);
            this.menuVertical.Controls.Add(this.btnMovimiento);
            this.menuVertical.Controls.Add(this.LogoBox);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(250, 650);
            this.menuVertical.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 600);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(250, 45);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Cerrar sesion";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 120);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(250, 45);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperaciones.FlatAppearance.BorderSize = 0;
            this.btnOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperaciones.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperaciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOperaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnOperaciones.Image")));
            this.btnOperaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperaciones.Location = new System.Drawing.Point(0, 360);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Size = new System.Drawing.Size(247, 45);
            this.btnOperaciones.TabIndex = 5;
            this.btnOperaciones.Text = "Operaciones";
            this.btnOperaciones.UseVisualStyleBackColor = true;
            this.btnOperaciones.Click += new System.EventHandler(this.btnOperaciones_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCategorias.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias.Image")));
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(0, 440);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(250, 45);
            this.btnCategorias.TabIndex = 4;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnAcercade
            // 
            this.btnAcercade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcercade.FlatAppearance.BorderSize = 0;
            this.btnAcercade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercade.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAcercade.Image = ((System.Drawing.Image)(resources.GetObject("btnAcercade.Image")));
            this.btnAcercade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcercade.Location = new System.Drawing.Point(0, 520);
            this.btnAcercade.Name = "btnAcercade";
            this.btnAcercade.Size = new System.Drawing.Size(250, 45);
            this.btnAcercade.TabIndex = 3;
            this.btnAcercade.Text = "Acerca de";
            this.btnAcercade.UseVisualStyleBackColor = true;
            this.btnAcercade.Click += new System.EventHandler(this.btnAcercade_Click);
            // 
            // btnCuentas
            // 
            this.btnCuentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuentas.FlatAppearance.BorderSize = 0;
            this.btnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentas.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCuentas.Image = ((System.Drawing.Image)(resources.GetObject("btnCuentas.Image")));
            this.btnCuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuentas.Location = new System.Drawing.Point(0, 280);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(250, 45);
            this.btnCuentas.TabIndex = 2;
            this.btnCuentas.Text = "Cuentas";
            this.btnCuentas.UseVisualStyleBackColor = true;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // btnMovimiento
            // 
            this.btnMovimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovimiento.FlatAppearance.BorderSize = 0;
            this.btnMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimiento.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMovimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnMovimiento.Image")));
            this.btnMovimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimiento.Location = new System.Drawing.Point(0, 200);
            this.btnMovimiento.Name = "btnMovimiento";
            this.btnMovimiento.Size = new System.Drawing.Size(250, 45);
            this.btnMovimiento.TabIndex = 1;
            this.btnMovimiento.Text = "Movimientos";
            this.btnMovimiento.UseVisualStyleBackColor = true;
            this.btnMovimiento.Click += new System.EventHandler(this.btnMovimiento_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Location = new System.Drawing.Point(3, 3);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(241, 47);
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.barraTitulo.Controls.Add(this.btnMin);
            this.barraTitulo.Controls.Add(this.btnRestaurar);
            this.barraTitulo.Controls.Add(this.btnMax);
            this.barraTitulo.Controls.Add(this.btnClose);
            this.barraTitulo.Controls.Add(this.btnSlide);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(250, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(930, 9);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(35, 35);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 1;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(971, 9);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(35, 35);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(971, 9);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(35, 35);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 1;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1012, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
            this.btnSlide.Location = new System.Drawing.Point(6, 9);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelHora);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 600);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // panelHora
            // 
            this.panelHora.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelHora.Controls.Add(this.fecha);
            this.panelHora.Controls.Add(this.hora);
            this.panelHora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHora.Location = new System.Drawing.Point(0, 500);
            this.panelHora.Name = "panelHora";
            this.panelHora.Size = new System.Drawing.Size(1050, 100);
            this.panelHora.TabIndex = 2;
            // 
            // hora
            // 
            this.hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Microsoft YaHei", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.Location = new System.Drawing.Point(748, 36);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(133, 52);
            this.hora.TabIndex = 0;
            this.hora.Text = "Hora:";
            // 
            // fecha
            // 
            this.fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(752, 9);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(70, 27);
            this.fecha.TabIndex = 1;
            this.fecha.Text = "Fecha";
            // 
            // menuDWM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuDWM";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menuDWM_FormClosing);
            this.menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelHora.ResumeLayout(false);
            this.panelHora.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Button btnMovimiento;
        private System.Windows.Forms.Button btnOperaciones;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnAcercade;
        private System.Windows.Forms.Button btnCuentas;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Panel panelHora;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label fecha;
    }
}

