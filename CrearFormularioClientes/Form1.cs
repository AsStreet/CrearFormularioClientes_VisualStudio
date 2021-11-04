using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrearFormularioClientes
{
    public partial class Form1 : Form
    {

        /*
         * Elementos que tiene el formulario:
         * 1 - Label
         * 2 - PictureBox
         * 3 - GroupBox
         * 4 - RadioButton
         * 5 - Minemonic (Los temas)
         * 6 - Button
         * 7 - TabControl
         * 8 - DataGridView
         * 9 - Timer
         * 10 - Panel
         * 
        */


        // Estas variables se necesitan para mover el formulario
        int x, y;
        Boolean movimiento;

        // Instanciar la clase Estilos
        Estilos estilo = new Estilos();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Obligo que la primera vez que se carga el formulario, esté seleccionado el tema
            // claro, después se establece la preferencia por la configuración del usuario
            // o por defecto
            rbTemaClaroInicio.Checked = true;
            if (rbTemaClaroInicio.Checked)
            {
                estilo.estiloFormulario(this, "principal", rbTemaClaroInicio.Text.ToLower());
            }
            // El tema oscuro hay que ajustarlo, solo cambia el color de fondo del formulario y no se
            // leen bien las cosas, pero realiza la acción de cambiarlo
            if (rbTemaOscuroInicio.Checked)
            {
                estilo.estiloFormulario(this, "principal", rbTemaOscuroInicio.Text.ToLower());
            }
            // Establecer estilos paneles formulario
            estilo.estiloPanelSuperior(pnlBordeSuperior);
            estilo.estiloPanelCabecera(pnlCabeceraInicio);
            estilo.estiloPanelContenido(pnlContenidoInicio);
            estilo.estiloPanelInferior(pnlPieInicio);
            // Establecer estilos botones superiores formulario
            estilo.estiloBotonCerrar(btnCerrarInicio);
            estilo.estiloBotonMaximizar(btnMaximizarInicio);
            estilo.estiloBotonMinimizar(btnMinimizarInicio);
            // Establecer estilos elementos de elementos externos del panel contenido
            estilo.estiloTitulo(lblTituloInicio, "EMPRESA");
            estilo.estiloEmpleado(lblNombreEmpleadoInicio, "Ángel");
            estilo.estiloFecha(lblFechaInicio);
            estilo.estiloHora(lblHoraInicio);
            // Establecer estilos elementos del panel contenido del formulario
            estilo.estiloTabControl(tcContenidoInicio);
            estilo.estiloDatagridview(dgvInicio);
            // Establecer estilo PictureBox Avatar
            estilo.estiloImagen(this.pbAvatarInicio);
            // Establecer tipo de datos del DataGridView 
            definirDatos();
        }

        // Método para definir el tipo de datos del DataGridView
        public void definirDatos()
        {
            this.dgvInicio.Columns[0].ValueType = Type.GetType("System.Integer");
            this.dgvInicio.Columns[1].ValueType = Type.GetType("System.String");
            this.dgvInicio.Columns[2].ValueType = Type.GetType("System.String");
            this.dgvInicio.Columns[3].ValueType = Type.GetType("System.String");
            this.dgvInicio.Columns[4].ValueType = Type.GetType("System.String");
            this.dgvInicio.Columns[5].ValueType = Type.GetType("System.String");
            this.dgvInicio.Columns[6].ValueType = Type.GetType("System.DateTime");
            this.dgvInicio.Columns[7].ValueType = Type.GetType("System.String");
            this.dgvInicio.Columns[8].ValueType = Type.GetType("System.Double");
        }

        // Método para definir el comportamiento de los botones superiores
        private void Click(object sender, EventArgs e)
        {
            // Si se ha pulsado el botón de cerrar se sale de la aplicación
            if (sender.Equals(btnCerrarInicio))
            {
                Application.Exit();
            }else if (sender.Equals(btnMaximizarInicio))
            {
                // Si se ha pulsado el botón de maximizar, se comprueba el estado de la ventana
                // y se modifica al contrario
                if (this.WindowState.Equals(FormWindowState.Maximized)){
                    this.WindowState = FormWindowState.Normal;
                    estilo.estiloMaximizar(this);
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    estilo.estiloMaximizar(this);
                }   
            }
            else if (sender.Equals(btnMinimizarInicio))
            {
                // Si se ha pulsado del botón de minimizar
                this.WindowState = FormWindowState.Minimized;
            }
        }

        // Estos 3 métodos son para mover el formulario
        private void pnlBordeSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            // Se pone movimiento en true, y se guarda la posicion del cursor en X e Y
            movimiento = true;
            x = e.X;
            y = e.Y;
        }

        private void pnlBordeSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            // Mientras que movimiento sea cierta, el formulario se situa en la posicion del cursor
            if (movimiento)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void pnlBordeSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            // Se para el movimiento y se pone a false
            movimiento = false;
        }

        // Método del Timer para ir actualizando la hora cada segundo
        private void timerHora_Tick(object sender, EventArgs e)
        {
            // Cambio la hora
            estilo.estiloHora();
            // Compruebo si se ha cambiado el tema pulsando la C o la O
            if (rbTemaClaroInicio.Checked)
            {
                estilo.estiloFormulario(this, rbTemaClaroInicio.Text.ToLower());
            }
            if (rbTemaOscuroInicio.Checked)
            {
                estilo.estiloFormulario(this, rbTemaOscuroInicio.Text.ToLower());
            }
        }

        // Método para abrir formulario de Nuevo cliente al hacer doble clic sobre el DGV
        private void dgvInicio_DoubleClick(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes(ref dgvInicio);
            cliente.Show();
        }

        private void pbAvatarInicio_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog(); BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            //Aquí incluiremos los filtros que queramos.
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Titulo del Dialogo";
            BuscarImagen.InitialDirectory = "C:\\";
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                String Direccion = BuscarImagen.FileName; this.pbAvatarInicio.ImageLocation = Direccion;
                //Pueden usar tambien esta forma para cargar la Imagen solo activenla y comenten la linea donde se cargaba anteriormente 
                //this.pictureBox1.ImageLocation = textBox1.Text;
                pbAvatarInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        // Método para cambiar el tema del formulario al hacer clic en los radiobuttons
        private void cambioEstilo_Click(object sender, EventArgs e)
        {
            if (rbTemaClaroInicio.Checked)
            {
                estilo.estiloFormulario(this, rbTemaClaroInicio.Text.ToLower());
            }
            if (rbTemaOscuroInicio.Checked)
            {
                estilo.estiloFormulario(this, rbTemaOscuroInicio.Text.ToLower());
            }
        }
    }
}
