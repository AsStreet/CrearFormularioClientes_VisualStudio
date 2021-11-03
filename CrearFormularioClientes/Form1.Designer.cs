
namespace CrearFormularioClientes
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgvInicio = new System.Windows.Forms.DataGridView();
            this.lblTituloInicio = new System.Windows.Forms.Label();
            this.pnlCabeceraInicio = new System.Windows.Forms.Panel();
            this.gbTemasInicio = new System.Windows.Forms.GroupBox();
            this.rbTemaOscuroInicio = new System.Windows.Forms.RadioButton();
            this.rbTemaClaroInicio = new System.Windows.Forms.RadioButton();
            this.lblNombreEmpleadoInicio = new System.Windows.Forms.Label();
            this.btnCerrarInicio = new System.Windows.Forms.Button();
            this.btnMaximizarInicio = new System.Windows.Forms.Button();
            this.btnMinimizarInicio = new System.Windows.Forms.Button();
            this.pnlBordeSuperior = new System.Windows.Forms.Panel();
            this.pnlPieInicio = new System.Windows.Forms.Panel();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.tcContenidoInicio = new System.Windows.Forms.TabControl();
            this.tbpContenidoClientesInicio = new System.Windows.Forms.TabPage();
            this.tbpCitasContenidoInicio = new System.Windows.Forms.TabPage();
            this.pnlContenidoInicio = new System.Windows.Forms.Panel();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.pbAvatarInicio = new System.Windows.Forms.PictureBox();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preferente = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInicio)).BeginInit();
            this.pnlCabeceraInicio.SuspendLayout();
            this.gbTemasInicio.SuspendLayout();
            this.pnlBordeSuperior.SuspendLayout();
            this.pnlPieInicio.SuspendLayout();
            this.tcContenidoInicio.SuspendLayout();
            this.tbpContenidoClientesInicio.SuspendLayout();
            this.pnlContenidoInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInicio
            // 
            this.dgvInicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.apellido1,
            this.apellido2,
            this.dni,
            this.email,
            this.creacion,
            this.preferente,
            this.saldo});
            this.dgvInicio.Location = new System.Drawing.Point(0, 0);
            this.dgvInicio.Name = "dgvInicio";
            this.dgvInicio.Size = new System.Drawing.Size(936, 343);
            this.dgvInicio.TabIndex = 0;
            this.dgvInicio.DoubleClick += new System.EventHandler(this.dgvInicio_DoubleClick);
            // 
            // lblTituloInicio
            // 
            this.lblTituloInicio.AutoSize = true;
            this.lblTituloInicio.Location = new System.Drawing.Point(416, 49);
            this.lblTituloInicio.Name = "lblTituloInicio";
            this.lblTituloInicio.Size = new System.Drawing.Size(43, 13);
            this.lblTituloInicio.TabIndex = 1;
            this.lblTituloInicio.Text = "lblTitulo";
            // 
            // pnlCabeceraInicio
            // 
            this.pnlCabeceraInicio.Controls.Add(this.gbTemasInicio);
            this.pnlCabeceraInicio.Controls.Add(this.pbAvatarInicio);
            this.pnlCabeceraInicio.Controls.Add(this.lblNombreEmpleadoInicio);
            this.pnlCabeceraInicio.Location = new System.Drawing.Point(-2, 42);
            this.pnlCabeceraInicio.Name = "pnlCabeceraInicio";
            this.pnlCabeceraInicio.Size = new System.Drawing.Size(1024, 153);
            this.pnlCabeceraInicio.TabIndex = 2;
            // 
            // gbTemasInicio
            // 
            this.gbTemasInicio.Controls.Add(this.rbTemaOscuroInicio);
            this.gbTemasInicio.Controls.Add(this.rbTemaClaroInicio);
            this.gbTemasInicio.Location = new System.Drawing.Point(765, 27);
            this.gbTemasInicio.Name = "gbTemasInicio";
            this.gbTemasInicio.Size = new System.Drawing.Size(131, 73);
            this.gbTemasInicio.TabIndex = 4;
            this.gbTemasInicio.TabStop = false;
            this.gbTemasInicio.Text = "Temas";
            // 
            // rbTemaOscuroInicio
            // 
            this.rbTemaOscuroInicio.AutoSize = true;
            this.rbTemaOscuroInicio.Location = new System.Drawing.Point(7, 43);
            this.rbTemaOscuroInicio.Name = "rbTemaOscuroInicio";
            this.rbTemaOscuroInicio.Size = new System.Drawing.Size(59, 17);
            this.rbTemaOscuroInicio.TabIndex = 1;
            this.rbTemaOscuroInicio.Text = "Oscuro";
            this.rbTemaOscuroInicio.UseVisualStyleBackColor = true;
            this.rbTemaOscuroInicio.Click += new System.EventHandler(this.cambioEstilo_Click);
            // 
            // rbTemaClaroInicio
            // 
            this.rbTemaClaroInicio.AutoSize = true;
            this.rbTemaClaroInicio.Location = new System.Drawing.Point(7, 20);
            this.rbTemaClaroInicio.Name = "rbTemaClaroInicio";
            this.rbTemaClaroInicio.Size = new System.Drawing.Size(49, 17);
            this.rbTemaClaroInicio.TabIndex = 0;
            this.rbTemaClaroInicio.Text = "Claro";
            this.rbTemaClaroInicio.UseVisualStyleBackColor = true;
            this.rbTemaClaroInicio.Click += new System.EventHandler(this.cambioEstilo_Click);
            // 
            // lblNombreEmpleadoInicio
            // 
            this.lblNombreEmpleadoInicio.AutoSize = true;
            this.lblNombreEmpleadoInicio.Location = new System.Drawing.Point(242, 11);
            this.lblNombreEmpleadoInicio.Name = "lblNombreEmpleadoInicio";
            this.lblNombreEmpleadoInicio.Size = new System.Drawing.Size(64, 13);
            this.lblNombreEmpleadoInicio.TabIndex = 2;
            this.lblNombreEmpleadoInicio.Text = "lblEmpleado";
            // 
            // btnCerrarInicio
            // 
            this.btnCerrarInicio.Location = new System.Drawing.Point(984, 3);
            this.btnCerrarInicio.Name = "btnCerrarInicio";
            this.btnCerrarInicio.Size = new System.Drawing.Size(37, 31);
            this.btnCerrarInicio.TabIndex = 0;
            this.btnCerrarInicio.Text = "button1";
            this.btnCerrarInicio.UseVisualStyleBackColor = true;
            this.btnCerrarInicio.Click += new System.EventHandler(this.Click);
            // 
            // btnMaximizarInicio
            // 
            this.btnMaximizarInicio.Location = new System.Drawing.Point(942, 3);
            this.btnMaximizarInicio.Name = "btnMaximizarInicio";
            this.btnMaximizarInicio.Size = new System.Drawing.Size(37, 31);
            this.btnMaximizarInicio.TabIndex = 3;
            this.btnMaximizarInicio.Text = "button1";
            this.btnMaximizarInicio.UseVisualStyleBackColor = true;
            this.btnMaximizarInicio.Click += new System.EventHandler(this.Click);
            // 
            // btnMinimizarInicio
            // 
            this.btnMinimizarInicio.Location = new System.Drawing.Point(899, 3);
            this.btnMinimizarInicio.Name = "btnMinimizarInicio";
            this.btnMinimizarInicio.Size = new System.Drawing.Size(37, 31);
            this.btnMinimizarInicio.TabIndex = 4;
            this.btnMinimizarInicio.Text = "button1";
            this.btnMinimizarInicio.UseVisualStyleBackColor = true;
            this.btnMinimizarInicio.Click += new System.EventHandler(this.Click);
            // 
            // pnlBordeSuperior
            // 
            this.pnlBordeSuperior.Controls.Add(this.btnMinimizarInicio);
            this.pnlBordeSuperior.Controls.Add(this.btnCerrarInicio);
            this.pnlBordeSuperior.Controls.Add(this.btnMaximizarInicio);
            this.pnlBordeSuperior.Location = new System.Drawing.Point(-2, 2);
            this.pnlBordeSuperior.Name = "pnlBordeSuperior";
            this.pnlBordeSuperior.Size = new System.Drawing.Size(1024, 37);
            this.pnlBordeSuperior.TabIndex = 3;
            this.pnlBordeSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseDown);
            this.pnlBordeSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseMove);
            this.pnlBordeSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseUp);
            // 
            // pnlPieInicio
            // 
            this.pnlPieInicio.Controls.Add(this.lblFechaInicio);
            this.pnlPieInicio.Controls.Add(this.lblTituloInicio);
            this.pnlPieInicio.Controls.Add(this.lblHoraInicio);
            this.pnlPieInicio.Location = new System.Drawing.Point(-2, 687);
            this.pnlPieInicio.Name = "pnlPieInicio";
            this.pnlPieInicio.Size = new System.Drawing.Size(1024, 113);
            this.pnlPieInicio.TabIndex = 4;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(145, 82);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(47, 13);
            this.lblFechaInicio.TabIndex = 1;
            this.lblFechaInicio.Text = "lblFecha";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(830, 82);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(40, 13);
            this.lblHoraInicio.TabIndex = 0;
            this.lblHoraInicio.Text = "lblHora";
            // 
            // tcContenidoInicio
            // 
            this.tcContenidoInicio.Controls.Add(this.tbpContenidoClientesInicio);
            this.tcContenidoInicio.Controls.Add(this.tbpCitasContenidoInicio);
            this.tcContenidoInicio.Location = new System.Drawing.Point(39, 40);
            this.tcContenidoInicio.Name = "tcContenidoInicio";
            this.tcContenidoInicio.SelectedIndex = 0;
            this.tcContenidoInicio.Size = new System.Drawing.Size(940, 369);
            this.tcContenidoInicio.TabIndex = 5;
            // 
            // tbpContenidoClientesInicio
            // 
            this.tbpContenidoClientesInicio.Controls.Add(this.dgvInicio);
            this.tbpContenidoClientesInicio.Location = new System.Drawing.Point(4, 22);
            this.tbpContenidoClientesInicio.Name = "tbpContenidoClientesInicio";
            this.tbpContenidoClientesInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tbpContenidoClientesInicio.Size = new System.Drawing.Size(932, 343);
            this.tbpContenidoClientesInicio.TabIndex = 0;
            this.tbpContenidoClientesInicio.Text = "Clientes";
            this.tbpContenidoClientesInicio.UseVisualStyleBackColor = true;
            // 
            // tbpCitasContenidoInicio
            // 
            this.tbpCitasContenidoInicio.Location = new System.Drawing.Point(4, 22);
            this.tbpCitasContenidoInicio.Name = "tbpCitasContenidoInicio";
            this.tbpCitasContenidoInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCitasContenidoInicio.Size = new System.Drawing.Size(738, 343);
            this.tbpCitasContenidoInicio.TabIndex = 1;
            this.tbpCitasContenidoInicio.Text = "Citas";
            this.tbpCitasContenidoInicio.UseVisualStyleBackColor = true;
            // 
            // pnlContenidoInicio
            // 
            this.pnlContenidoInicio.Controls.Add(this.tcContenidoInicio);
            this.pnlContenidoInicio.Location = new System.Drawing.Point(-2, 201);
            this.pnlContenidoInicio.Name = "pnlContenidoInicio";
            this.pnlContenidoInicio.Size = new System.Drawing.Size(1024, 480);
            this.pnlContenidoInicio.TabIndex = 5;
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // pbAvatarInicio
            // 
            this.pbAvatarInicio.Location = new System.Drawing.Point(43, 11);
            this.pbAvatarInicio.Name = "pbAvatarInicio";
            this.pbAvatarInicio.Size = new System.Drawing.Size(159, 120);
            this.pbAvatarInicio.TabIndex = 3;
            this.pbAvatarInicio.TabStop = false;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido1
            // 
            this.apellido1.HeaderText = "Apellido1";
            this.apellido1.Name = "apellido1";
            // 
            // apellido2
            // 
            this.apellido2.HeaderText = "Apellido2";
            this.apellido2.Name = "apellido2";
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // creacion
            // 
            this.creacion.HeaderText = "Fecha alta";
            this.creacion.Name = "creacion";
            // 
            // preferente
            // 
            this.preferente.HeaderText = "Preferente";
            this.preferente.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.preferente.Name = "preferente";
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 798);
            this.Controls.Add(this.pnlContenidoInicio);
            this.Controls.Add(this.pnlPieInicio);
            this.Controls.Add(this.pnlBordeSuperior);
            this.Controls.Add(this.pnlCabeceraInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInicio)).EndInit();
            this.pnlCabeceraInicio.ResumeLayout(false);
            this.pnlCabeceraInicio.PerformLayout();
            this.gbTemasInicio.ResumeLayout(false);
            this.gbTemasInicio.PerformLayout();
            this.pnlBordeSuperior.ResumeLayout(false);
            this.pnlPieInicio.ResumeLayout(false);
            this.pnlPieInicio.PerformLayout();
            this.tcContenidoInicio.ResumeLayout(false);
            this.tbpContenidoClientesInicio.ResumeLayout(false);
            this.pnlContenidoInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInicio;
        private System.Windows.Forms.Label lblTituloInicio;
        private System.Windows.Forms.Panel pnlCabeceraInicio;
        private System.Windows.Forms.Button btnCerrarInicio;
        private System.Windows.Forms.Label lblNombreEmpleadoInicio;
        private System.Windows.Forms.Button btnMaximizarInicio;
        private System.Windows.Forms.Button btnMinimizarInicio;
        private System.Windows.Forms.Panel pnlBordeSuperior;
        private System.Windows.Forms.GroupBox gbTemasInicio;
        private System.Windows.Forms.RadioButton rbTemaOscuroInicio;
        private System.Windows.Forms.RadioButton rbTemaClaroInicio;
        private System.Windows.Forms.PictureBox pbAvatarInicio;
        private System.Windows.Forms.Panel pnlPieInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.TabControl tcContenidoInicio;
        private System.Windows.Forms.TabPage tbpContenidoClientesInicio;
        private System.Windows.Forms.TabPage tbpCitasContenidoInicio;
        private System.Windows.Forms.Panel pnlContenidoInicio;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn creacion;
        private System.Windows.Forms.DataGridViewComboBoxColumn preferente;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
    }
}

