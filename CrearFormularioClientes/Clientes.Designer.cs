
namespace CrearFormularioClientes
{
    partial class Clientes
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPreferencia = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.mtxDni = new System.Windows.Forms.MaskedTextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txApellido1 = new System.Windows.Forms.TextBox();
            this.txApellido2 = new System.Windows.Forms.TextBox();
            this.txSaldo = new System.Windows.Forms.TextBox();
            this.cbPreferencia = new System.Windows.Forms.ComboBox();
            this.mtxEmail = new System.Windows.Forms.MaskedTextBox();
            this.mcNacimiento = new System.Windows.Forms.MonthCalendar();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.tmHora = new System.Windows.Forms.Timer(this.components);
            this.errClientes = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMoneda = new System.Windows.Forms.Label();
            this.pnlSuperior.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlCabecera.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.btnMinimizar);
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Controls.Add(this.btnMaximizar);
            this.pnlSuperior.Location = new System.Drawing.Point(4, 2);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(589, 31);
            this.pnlSuperior.TabIndex = 0;
            this.pnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseDown);
            this.pnlSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseMove);
            this.pnlSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseUp);
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.lblMoneda);
            this.pnlContenido.Controls.Add(this.lblAvatar);
            this.pnlContenido.Controls.Add(this.pbAvatar);
            this.pnlContenido.Controls.Add(this.mcNacimiento);
            this.pnlContenido.Controls.Add(this.mtxEmail);
            this.pnlContenido.Controls.Add(this.cbPreferencia);
            this.pnlContenido.Controls.Add(this.txSaldo);
            this.pnlContenido.Controls.Add(this.txApellido2);
            this.pnlContenido.Controls.Add(this.txApellido1);
            this.pnlContenido.Controls.Add(this.txNombre);
            this.pnlContenido.Controls.Add(this.mtxDni);
            this.pnlContenido.Controls.Add(this.lblSaldo);
            this.pnlContenido.Controls.Add(this.lblPreferencia);
            this.pnlContenido.Controls.Add(this.btnCancelar);
            this.pnlContenido.Controls.Add(this.btnGuardar);
            this.pnlContenido.Controls.Add(this.lblNacimiento);
            this.pnlContenido.Controls.Add(this.lblEmail);
            this.pnlContenido.Controls.Add(this.lblDni);
            this.pnlContenido.Controls.Add(this.lblApellido2);
            this.pnlContenido.Controls.Add(this.lblApellido1);
            this.pnlContenido.Controls.Add(this.lblNombre);
            this.pnlContenido.Location = new System.Drawing.Point(4, 101);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(589, 584);
            this.pnlContenido.TabIndex = 1;
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.Controls.Add(this.lblEmpleado);
            this.pnlCabecera.Location = new System.Drawing.Point(4, 34);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(589, 61);
            this.pnlCabecera.TabIndex = 2;
            // 
            // pnlInferior
            // 
            this.pnlInferior.Controls.Add(this.lblTitulo);
            this.pnlInferior.Controls.Add(this.lblHora);
            this.pnlInferior.Controls.Add(this.lblFecha);
            this.pnlInferior.Location = new System.Drawing.Point(4, 691);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(589, 83);
            this.pnlInferior.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(503, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "button1";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Location = new System.Drawing.Point(422, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(75, 23);
            this.btnMaximizar.TabIndex = 4;
            this.btnMaximizar.Text = "button2";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Location = new System.Drawing.Point(341, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(75, 23);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.Text = "button3";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(200, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(22, 58);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "label1";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(462, 58);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(35, 13);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "label2";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(22, 19);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(35, 13);
            this.lblEmpleado.TabIndex = 1;
            this.lblEmpleado.Text = "label3";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Location = new System.Drawing.Point(22, 80);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(76, 13);
            this.lblApellido1.TabIndex = 3;
            this.lblApellido1.Text = "Primer Apellido";
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Location = new System.Drawing.Point(22, 120);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(90, 13);
            this.lblApellido2.TabIndex = 4;
            this.lblApellido2.Text = "Segundo Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(22, 165);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "DNI";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(22, 211);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(93, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Correo electrónico";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(22, 262);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(72, 13);
            this.lblNacimiento.TabIndex = 7;
            this.lblNacimiento.Text = "Fecha de alta";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(406, 544);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(501, 544);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPreferencia
            // 
            this.lblPreferencia.AutoSize = true;
            this.lblPreferencia.Location = new System.Drawing.Point(22, 442);
            this.lblPreferencia.Name = "lblPreferencia";
            this.lblPreferencia.Size = new System.Drawing.Size(61, 13);
            this.lblPreferencia.TabIndex = 10;
            this.lblPreferencia.Text = "Preferencia";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(22, 506);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(64, 13);
            this.lblSaldo.TabIndex = 11;
            this.lblSaldo.Text = "Saldo Inicial";
            // 
            // mtxDni
            // 
            this.mtxDni.Location = new System.Drawing.Point(160, 162);
            this.mtxDni.Mask = "99999999L";
            this.mtxDni.Name = "mtxDni";
            this.mtxDni.Size = new System.Drawing.Size(114, 20);
            this.mtxDni.TabIndex = 12;
            this.mtxDni.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.validarDni);
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(160, 28);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(129, 20);
            this.txNombre.TabIndex = 13;
            // 
            // txApellido1
            // 
            this.txApellido1.Location = new System.Drawing.Point(160, 77);
            this.txApellido1.Name = "txApellido1";
            this.txApellido1.Size = new System.Drawing.Size(129, 20);
            this.txApellido1.TabIndex = 14;
            // 
            // txApellido2
            // 
            this.txApellido2.Location = new System.Drawing.Point(160, 117);
            this.txApellido2.Name = "txApellido2";
            this.txApellido2.Size = new System.Drawing.Size(129, 20);
            this.txApellido2.TabIndex = 15;
            // 
            // txSaldo
            // 
            this.txSaldo.Location = new System.Drawing.Point(160, 503);
            this.txSaldo.Name = "txSaldo";
            this.txSaldo.Size = new System.Drawing.Size(100, 20);
            this.txSaldo.TabIndex = 16;
            // 
            // cbPreferencia
            // 
            this.cbPreferencia.FormattingEnabled = true;
            this.cbPreferencia.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbPreferencia.Location = new System.Drawing.Point(160, 439);
            this.cbPreferencia.Name = "cbPreferencia";
            this.cbPreferencia.Size = new System.Drawing.Size(56, 21);
            this.cbPreferencia.TabIndex = 17;
            // 
            // mtxEmail
            // 
            this.mtxEmail.Location = new System.Drawing.Point(160, 208);
            this.mtxEmail.Name = "mtxEmail";
            this.mtxEmail.Size = new System.Drawing.Size(171, 20);
            this.mtxEmail.TabIndex = 18;
            this.mtxEmail.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.validarCorreo);
            // 
            // mcNacimiento
            // 
            this.mcNacimiento.Location = new System.Drawing.Point(160, 262);
            this.mcNacimiento.Name = "mcNacimiento";
            this.mcNacimiento.TabIndex = 19;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(406, 66);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(161, 136);
            this.pbAvatar.TabIndex = 20;
            this.pbAvatar.TabStop = false;
            // 
            // lblAvatar
            // 
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.Location = new System.Drawing.Point(403, 36);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(38, 13);
            this.lblAvatar.TabIndex = 21;
            this.lblAvatar.Text = "Avatar";
            // 
            // tmHora
            // 
            this.tmHora.Enabled = true;
            this.tmHora.Interval = 1000;
            this.tmHora.Tick += new System.EventHandler(this.tmHora_Tick);
            // 
            // errClientes
            // 
            this.errClientes.ContainerControl = this;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(266, 506);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(13, 13);
            this.lblMoneda.TabIndex = 22;
            this.lblMoneda.Text = "€";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 776);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.pnlSuperior);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.pnlInferior.ResumeLayout(false);
            this.pnlInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblPreferencia;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.MonthCalendar mcNacimiento;
        private System.Windows.Forms.MaskedTextBox mtxEmail;
        private System.Windows.Forms.ComboBox cbPreferencia;
        private System.Windows.Forms.TextBox txSaldo;
        private System.Windows.Forms.TextBox txApellido2;
        private System.Windows.Forms.TextBox txApellido1;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.MaskedTextBox mtxDni;
        private System.Windows.Forms.Timer tmHora;
        private System.Windows.Forms.ErrorProvider errClientes;
        private System.Windows.Forms.Label lblMoneda;
    }
}