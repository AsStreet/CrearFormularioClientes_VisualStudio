using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrearFormularioClientes
{
    public partial class Clientes : Form
    {
        private DataGridView dgv;
        private DataGridViewCellCollection fila;
        private Estilos estilo = new Estilos();
        // Estas variables se necesitan para mover el formulario
        int x, y;
        Boolean movimiento;

        public Clientes()
        {
            InitializeComponent();
        }

        public Clientes(ref DataGridView nuevo)
        {
            InitializeComponent();
            this.dgv = nuevo;
        }

        public Clientes(ref DataGridViewCellCollection nuevo)
        {
            InitializeComponent();
            this.fila = nuevo;
            // Establecer los datos en el formulario
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            estilo.estiloFormulario(this, "alta", "claro");
            estilo.estiloPanelSuperior(pnlSuperior);
            estilo.estiloPanelCabecera(pnlCabecera);
            estilo.estiloPanelContenido(pnlContenido);
            estilo.estiloPanelInferior(pnlInferior);
            estilo.estiloBotonCerrar(btnCerrar);
            estilo.estiloBotonMaximizar(btnMaximizar);
            estilo.estiloBotonMinimizar(btnMinimizar);
            estilo.estiloEmpleado(lblEmpleado, "Angel");
            estilo.estiloTitulo(lblTitulo, "EMPRESA");
            estilo.estiloFecha(lblFecha);
            estilo.estiloHora(lblHora);
        }

        private void Click(object sender, EventArgs e)
        {
            // Si se ha pulsado el botón de cerrar se sale de la aplicación
            if (sender.Equals(btnCerrar))
            {
                // Esta vez el botón de cerrar cierra la ventana, no la aplicación
                this.Close();
            }
            else if (sender.Equals(btnMaximizar))
            {
                // Si se ha pulsado el botón de maximizar, se comprueba el estado de la ventana
                // y se modifica al contrario
                if (this.WindowState.Equals(FormWindowState.Maximized))
                {
                    this.WindowState = FormWindowState.Normal;
                    estilo.estiloMaximizar(this);
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    estilo.estiloMaximizar(this);
                }
            }
            else if (sender.Equals(btnMinimizar))
            {
                // Si se ha pulsado del botón de minimizar
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            // Se pone movimiento en true, y se guarda la posicion del cursor en X e Y
            movimiento = true;
            x = e.X;
            y = e.Y;
        }

        private void pnlSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            // Mientras que movimiento sea cierta, el formulario se situa en la posicion del cursor
            if (movimiento)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void tmHora_Tick(object sender, EventArgs e)
        {
            estilo.estiloHora();
        }

        private void pnlSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            // Se para el movimiento y se pone a false
            movimiento = false;
        }

        // Método validar dni
        private void validarDni(object sender, PreviewKeyDownEventArgs e)
        {
            char[] letra = { 't', 'r', 'w', 'a', 'g', 'm', 'y', 'f', 'p', 'd', 'x', 'b', 'n', 'j', 'z', 's', 'q', 'v', 'h', 'l', 'c', 'k', 'e' };
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Tab)
            {
                int dni = int.Parse(mtxDni.Text.Substring(0, mtxDni.Text.Length - 1));
                dni %= 23;
                char l = char.ToLower(mtxDni.Text[mtxDni.Text.Length - 1]);
                if (letra[dni] != l)
                    errClientes.SetError(this.mtxDni, "DNI NO válido");
                else
                    errClientes.SetError(this.mtxDni, "");
            }
        }

        // Método validar correo electrónico
        private void validarCorreo(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Tab)
            {
                Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                bool isValid = regex.IsMatch(this.mtxEmail.Text.Trim());
                if (!isValid)
                {
                    errClientes.SetError(this.mtxEmail, "EMAIL NO válido");
                }
                else
                    errClientes.SetError(this.mtxEmail, "");
            }
        }

        // Método para guardar los datos del alta en el DGV
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        // Método para cerrar la ventana de Clientes
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
