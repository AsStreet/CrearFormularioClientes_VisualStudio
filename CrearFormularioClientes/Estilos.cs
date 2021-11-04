using CrearFormularioClientes.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrearFormularioClientes
{
    class Estilos
    {
        private Form formulario;
        private DataGridView dgv;
        private Label lblTitulo;
        private Label lblEmpleado;
        private Label lblFecha;
        private Label lblHora;
        private Button botonCerrar;
        private Button botonMaximizar;
        private Button botonMinimizar; 
        private Panel pnlSuperior;
        private Panel pnlCabecera;
        private Panel pnlContenido;
        private Panel pnlInferior;
        private TabControl tbContenido;
        private String tema;
        private PictureBox pbAvatar;
        private ColorConverter cv = new ColorConverter();

        public Estilos() { }

        // Metodo para establecer estilo al Formulario
        public void estiloFormulario(Form form, String tipo, String tema)
        {
            // Creo una instancia de Bitmap
            Bitmap fondo;
            // Vinculo el formulario al objeto formulario de la clase
            this.formulario = form;
            switch (tipo)
            {
                case "login":        
                    fondo = new Bitmap(Application.StartupPath + @"\Imagenes\fondo_linea_azul2.jpg");
                    formulario.BackgroundImage = fondo;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    break;
                case "principal":
                    switch (tema)
                    {
                        case "&claro":
                            this.tema = "&claro";
                            this.formulario.BackColor = (Color)cv.ConvertFromString("#e1eff8"); // #D4FFEA  // #e1eff8
                            break;
                        case "&oscuro":
                            this.tema = "&oscuro";
                            this.formulario.BackColor = (Color)cv.ConvertFromString("#2d2d30"); // #D4FFEA
                            break;
                    }   
                    break;
                case "alta":
                    switch (tema)
                    {
                        case "&claro":
                            this.tema = "&claro";
                            this.formulario.BackColor = (Color)cv.ConvertFromString("#e1eff8"); // #D4FFEA  // #e1eff8
                            break;
                        case "&oscuro":
                            this.tema = "&oscuro";
                            this.formulario.BackColor = (Color)cv.ConvertFromString("#2d2d30"); // #D4FFEA
                            break;
                    }
                    break;
            }
            // Elimino los bordes del formulario
            this.formulario.FormBorderStyle = FormBorderStyle.None;
        }

        // Método para cambiar el tema de un formulario
        public void estiloFormulario(Form nuevo, String tema)
        {
            this.formulario = nuevo;
            switch (tema)
            {
                case "&claro":
                    this.formulario.BackColor = (Color)cv.ConvertFromString("#e1eff8");
                    break;
                case "&oscuro":
                    this.formulario.BackColor = (Color)cv.ConvertFromString("#2d2d30");
                    break;
            }
        }
        
        // Metodo para establecer estilo del DataGridView
        public void estiloDatagridview(DataGridView nuevo)
        {
            this.dgv = nuevo;

            // Establecer estilo general de las celdas

            // Crear objeto de estilo de celdas
            DataGridViewCellStyle estiloGeneralCeldas = new DataGridViewCellStyle();
            // Cambiar color fondo celda
            estiloGeneralCeldas.BackColor = (Color)cv.ConvertFromString("#FFFFFF"); // #F4DCF5
            // Cambiar color fuente (No lo hago porque con el fondo el negro queda mejor)
            estiloGeneralCeldas.ForeColor = (Color)cv.ConvertFromString("#000000");
            // Alineo el contenido al centro y enmedio
            estiloGeneralCeldas.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Cambio el Valor por defecto de las celdas sin asignar
            estiloGeneralCeldas.NullValue = "";
            // Cambio el Color de fondo cuando una fila está seleccionada
            estiloGeneralCeldas.SelectionBackColor = (Color)cv.ConvertFromString("#B0F6E6"); // Rosa que me gusta, pero quizás demasiados colores #F2D8DD
            // Cambio el Color de fuente cuando una fila está seleccionada
            estiloGeneralCeldas.SelectionForeColor = (Color)cv.ConvertFromString("#000000");
            // Hago que las celdas se ajusten al tamaño del contenido
            estiloGeneralCeldas.WrapMode = DataGridViewTriState.True;
            // Asignar Tipo de fuente por defecto
            estiloGeneralCeldas.Font = new Font("Cantarell", 10, FontStyle.Regular); // Me gusta la Candara también, pero Cantarell se lee mejor
            // Asignar el estilo al datagridview
            this.dgv.DefaultCellStyle = estiloGeneralCeldas;
            // Ajustar el tamaño de las filas automáticamente menos las de cabecera
            this.dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

           
            
            // Establecer estilo cabecera

            // Establecer alto de cabecera autoajustable
            this.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // Establece el ancho de la cabecera por defecto a su contenido
            this.dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            // Deshabilitar que la cabecera utilice los estilos actuales
            this.dgv.EnableHeadersVisualStyles = false;
            // Crear estilo para la cabecera
            DataGridViewCellStyle estiloCabecera = new DataGridViewCellStyle();
            // Cambiar Fondo Cabecera
            estiloCabecera.BackColor = (Color)cv.ConvertFromString("#5caaea"); // #CAE6F3
            // Cambiar Color Fuente Cabecera
            estiloCabecera.ForeColor = (Color)cv.ConvertFromString("#000000");
            // Cambiar Tipo de fuente de Cabecera
            estiloCabecera.Font = new Font("Bahnschrift", 12, FontStyle.Bold);
            // Reducir Padding a 0 para intentar centrar el texto de la cabecera
            estiloCabecera.Padding = new Padding(0, 0, 0, 0);
            // Cambiar la alineación de la Cabecera
            estiloCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter; // NO LO CENTRA ENMEDIO AL CENTRO
            // Asignar el estilo a la cabecera
            this.dgv.ColumnHeadersDefaultCellStyle = estiloCabecera;



            // Establecer estilo filas alternas

            // Crear estilo para las filas
            DataGridViewCellStyle estiloFilas = new DataGridViewCellStyle();
            // Asignar color de fondo a la fila pareja
            estiloFilas.BackColor = (Color)cv.ConvertFromString("#dfecf4"); // 
            // Asignar color de fuente a la fila pareja
            estiloFilas.ForeColor = (Color)cv.ConvertFromString("#000000");
            // Asignar valor por defecto de las celdas sin asignar de la fila pareja
            estiloFilas.NullValue = "";
            this.dgv.AlternatingRowsDefaultCellStyle = estiloFilas;


            // Establecer estilo columna independiente

            /*
            // Crear estilo para la columna independiente
            DataGridViewCellStyle estiloColumnaIndependiente = new DataGridViewCellStyle();
            // Asignar color de fondo a la columna independiente
            estiloColumnaIndependiente.BackColor = (Color)cv.ConvertFromString("#F0EBB6");
            // Asignar color de fuente a la columna independiente
            estiloColumnaIndependiente.ForeColor = (Color)cv.ConvertFromString("#000000");
            // Asignar valor por defecto de las celdas sin asignar de la columna independiente
            estiloColumnaIndependiente.NullValue = "";
            // Asignar el valor al DataGrid
            this.dgv.Columns["NombreColumna" o índice].DefaultCellStyle = estiloColumnaIndependiente;
            */

            
            // Retoques generales DataGridLayout
            
            // Cambiar estilo borde del DataGridView
            this.dgv.BorderStyle = BorderStyle.Fixed3D;
            // Ajustar el DataGridView a una posición del formulario
            //this.dgv.Dock = DockStyle.Bottom;
            // Establecer color de fondo del DataGridView
            switch (this.tema)
            {
                case "&claro":
                    this.dgv.BackgroundColor = (Color)cv.ConvertFromString("#fafafa");
                    break;
                case "&oscuro":
                    this.dgv.BackgroundColor = (Color)cv.ConvertFromString("#e1eff8");
                    break;
            }
            
            // Quitar bordes DataGridView
            this.dgv.BorderStyle = BorderStyle.None;
            // Establecer tamaño DataGridView
            TabPage pagina = tbContenido.SelectedTab;
            this.dgv.Width = pagina.Width;
        }

        // Método para establecer el diseño de una celda en concreto
        public void estiloCelda(DataGridView dgv, DataGridViewCellFormattingEventArgs e, int columna, Object contenido)
        {

            // Asigno el DataGridView del parámetro al del Estilo
            this.dgv = dgv;
            // Pregunto si el valor de la celda Tipo de cliente no está vacío y si es A
            if (this.dgv.Rows[e.RowIndex].Cells[6].Value != null && this.dgv.Rows[e.RowIndex].Cells[columna].Value.Equals(contenido.ToString()))
            {
                // Cambio el color de la fila a Lavanda
                this.dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = (Color)cv.ConvertFromString("#F4DCF5");
            }

        }

        // Método para establecer el diseño y el texto del Label utilizado para título
        public void estiloTitulo(Label nuevo, String texto)
        {
            // Asigno el Label del argumento al Label del estilo
            this.lblTitulo = nuevo;
            // Asigno el texto que se le ha pasado al label
            lblTitulo.Text = texto;
            // Cambio el tipo de fuente, el estilo y el tamaño del título
            lblTitulo.Font = new Font("Bahnschrift", 32, FontStyle.Bold); // Candara es buena opción
            lblTitulo.ForeColor = (Color)cv.ConvertFromString("#002b60"); //5caaea
        }

        // Método para establecer el diseño y el texto del Label de saludo al usuario
        public void estiloEmpleado(Label nuevo, String texto)
        {
            this.lblEmpleado = nuevo;
            this.lblEmpleado.Text = "Bienvenido/a: " + texto;
            this.lblEmpleado.Font = new Font("Bahnschrift", 12, FontStyle.Regular);
            this.lblEmpleado.ForeColor = (Color)cv.ConvertFromString("#002b60");
        }

        // Método para personalizar el estilo de un botón
        public void estiloBoton(Button nuevo)
        {
            // De momento no voy a ajustar los botones, pero para hacerlos redondeados si se puede
            // cambiar el color, asignarles una imagen o algo.
        }

        public void estiloBotonCerrar(Button nuevo)
        {
            // Asignar el botón del formulario al estilo
            this.botonCerrar = nuevo;
            // Quitar el texto por defecto que tenga el botón
            this.botonCerrar.Text = "";
            // Instanciar objeto bitmap para cargarle una imagen
            Bitmap fondo = new Bitmap(Application.StartupPath + @"\Imagenes\boton_cerrar2.png");
            // Establecer una imagen al botón
            this.botonCerrar.Image = fondo;
            // Hacer que la imagen se adapta al tamaño del botón
            this.botonCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            // Quitar el color de fondo del botón cerrar
            this.botonCerrar.FlatStyle = FlatStyle.Flat;
            // Quitar el borde al botón de cerrar
            this.botonCerrar.FlatAppearance.BorderSize = 0;
            // Cambiar el color del fondo cuando se pasa el cursor por encima
            this.botonCerrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.botonCerrar.FlatAppearance.MouseOverBackColor = Color.Red;
            // Establecer el tamaño y el ancho del botón para después poder posiconarlo
            this.botonCerrar.Width = 30;
            this.botonCerrar.Height = 30;
            // Colocar el boton arriba a la derecha
            this.botonCerrar.Location = new Point(this.pnlSuperior.Width - this.botonCerrar.Width, 0);
            /*
            if (this.formulario.WindowState.Equals(FormWindowState.Normal))
            {
                this.botonCerrar.Location = new Point(this.pnlSuperior.Width - this.botonCerrar.Width, 0);
            }
            else
            {
                Screen pantalla = Screen.PrimaryScreen;
                this.botonCerrar.Location = new Point(pantalla.Bounds.Width - this.botonCerrar.Width - 300, 500);
            }
            */
        }

        public void estiloBotonMaximizar(Button nuevo)
        {
            Bitmap fondo;
            // Asignar el botón del formulario al estilo
            this.botonMaximizar = nuevo;
            // Quitar el texto por defecto que tenga el botón
            this.botonMaximizar.Text = "";
            fondo = new Bitmap(Application.StartupPath + @"\Imagenes\boton_maximizar2.png");
            // Establecer una imagen al botón
            this.botonMaximizar.Image = fondo;
            // Hacer que la imagen se adapta al tamaño del botón
            this.botonMaximizar.BackgroundImageLayout = ImageLayout.Zoom;
            // Quitar el color de fondo del botón cerrar
            this.botonMaximizar.FlatStyle = FlatStyle.Flat;
            // Quitar el borde al botón de cerrar
            this.botonMaximizar.FlatAppearance.BorderSize = 0;
            // Cambiar el color del fondo cuando se pasa el cursor por encima
            this.botonMaximizar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.botonMaximizar.FlatAppearance.MouseOverBackColor = (Color)cv.ConvertFromString("#dfecf4");
            // Establecer el tamaño y el ancho del botón para después poder posicionarlo
            this.botonMaximizar.Width = 30;
            this.botonMaximizar.Height = 30;
            // Colocar el boton arriba a la derecha antes del botón cerrar
            this.botonMaximizar.Location = new Point(this.pnlSuperior.Width - (this.botonMaximizar.Width * 2), 0);
            /*
            if (this.formulario.WindowState.Equals(FormWindowState.Normal))
            {
                this.botonMaximizar.Location = new Point(this.pnlSuperior.Width - (this.botonMaximizar.Width * 2), 0);
            }
            else
            {
                Screen pantalla = Screen.PrimaryScreen;
                this.botonMaximizar.Location = new Point(pantalla.Bounds.Width - (this.botonMaximizar.Width * 2), 0);
            }
            */
        }

        public void estiloBotonMinimizar(Button nuevo)
        {
            // Asignar el botón del formulario al estilo
            this.botonMinimizar = nuevo;
            // Quitar el texto por defecto que tenga el botón
            this.botonMinimizar.Text = "";
            // Instanciar objeto bitmap para cargarle una imagen
            Bitmap fondo = new Bitmap(Application.StartupPath + @"\Imagenes\boton_minimizar2.png");
            // Establecer una imagen al botón
            this.botonMinimizar.Image = fondo;
            // Hacer que la imagen se adapta al tamaño del botón
            this.botonMinimizar.BackgroundImageLayout = ImageLayout.Zoom;
            // Establecer alineación imagen
            this.botonMinimizar.ImageAlign = ContentAlignment.BottomCenter;
            // Quitar el color de fondo del botón cerrar
            this.botonMinimizar.FlatStyle = FlatStyle.Flat;
            // Quitar el borde al botón de cerrar
            this.botonMinimizar.FlatAppearance.BorderSize = 0;
            // Cambiar el color del fondo cuando se pasa el cursor por encima
            this.botonMinimizar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.botonMinimizar.FlatAppearance.MouseDownBackColor = (Color)cv.ConvertFromString("#dfecf4");
            // Establecer el tamaño y el ancho del botón para después poder posicionarlo
            this.botonMinimizar.Width = 30;
            this.botonMinimizar.Height = 30;
            // Colocar el boton arriba a la derecha antes del botón maximizar
            this.botonMinimizar.Location = new Point(this.pnlSuperior.Width - (this.botonMinimizar.Width * 3), 0);
            /*
            if (this.formulario.WindowState.Equals(FormWindowState.Normal))
            {
                this.botonMinimizar.Location = new Point(this.pnlSuperior.Width - (this.botonMinimizar.Width * 3), 0);
            }
            else
            {
                Screen pantalla = Screen.PrimaryScreen;
                this.botonMinimizar.Location = new Point(pnlSuperior.Width - (this.botonMinimizar.Width * 3), 0);
            }
            */
        }

        // Método para cambiar la posición de los botones al maximizar
        public void estiloBotonesMaximizar()
        {
            Bitmap fondo;
            this.botonCerrar.Location = new Point(this.pnlSuperior.Width - this.botonCerrar.Width, 0);
            this.botonMaximizar.Location = new Point(this.pnlSuperior.Width - (this.botonMaximizar.Width * 2), 0);
            this.botonMinimizar.Location = new Point(this.pnlSuperior.Width - (this.botonMinimizar.Width * 3), 0);
            if (this.formulario.WindowState == FormWindowState.Maximized)
            {
                fondo = new Bitmap(Application.StartupPath + @"\Imagenes\boton_reducir2.png");
            }
            else
            {
                fondo = new Bitmap(Application.StartupPath + @"\Imagenes\boton_maximizar2.png");
            }
            this.botonMaximizar.Image = fondo;
            this.botonMaximizar.FlatAppearance.MouseDownBackColor = (Color)cv.ConvertFromString("#dfecf4");
        }

        // Método para establecer el estilo del panel superior
        public void estiloPanelSuperior(Panel nuevo)
        {
            this.pnlSuperior = nuevo;
            // Cambiar el color de fondo del panel superior
            this.pnlSuperior.BackColor = (Color)cv.ConvertFromString("#e8fbff");
            // Anclarlo a la parte superior del formulario
            this.pnlSuperior.Anchor = AnchorStyles.Top;
            // Ajustar tamaño del panel superior
            this.pnlSuperior.Size = new Size(this.formulario.Width, 30);
            // Ajustar posicion del panel superior
            this.pnlSuperior.Location = new Point(0, 0);
        }

        // Método sobrecargado estilo Panel Superior
        public void estiloPanelSuperior()
        {
            // Ajustar tamaño del panel superior
            this.pnlSuperior.Size = new Size(this.formulario.Width, 30);
            // Ajustar posicion del panel superior
            this.pnlSuperior.Location = new Point(0, 0);
        }

        // Método para establecer el estilo del panel cabecera
        public void estiloPanelCabecera(Panel nuevo)
        {
            this.pnlCabecera = nuevo;
            // Cambiar color de fondo de panel
            this.pnlCabecera.BackColor = Color.Transparent;
            // Fijo el panel a la parte superior del formulario
            this.pnlCabecera.Anchor = AnchorStyles.Top;
            // Colocar el panel en su posición
            this.pnlCabecera.Location = new Point(0, 31);
            // Ajustar ancho panel cabecera
            this.pnlCabecera.Width = this.formulario.Width;
        }

        // Método sobrecargado estiloPanelCabecera
        public void estiloPanelCabecera()
        {
            // Ajustar ancho panel cabecera
            this.pnlCabecera.Width = this.formulario.Width;
        }

        // Método para establecer el estilo del panel de contenido
        public void estiloPanelContenido(Panel nuevo)
        {
            this.pnlContenido = nuevo;
            // Cambiar color de fondo de panel
            this.pnlContenido.BackColor = Color.Transparent;
            // Fijo el panel a la parte superior del formulario
            this.pnlContenido.Anchor = AnchorStyles.Top;
            // Ajustar ancho panel Contenido
            this.pnlContenido.Width = this.formulario.Width;
        }

        // Método sobrecargado estilo panel Contenido
        public void estiloPanelContenido()
        {
            // Ajustar ancho panel Contenido
            this.pnlContenido.Width = this.formulario.Width;
        }

        // Método para establecer el estilo del panel inferior
        public void estiloPanelInferior(Panel nuevo)
        {
            this.pnlInferior = nuevo;
            // Cambiar color al panel inferior
            this.pnlInferior.BackColor = Color.Transparent;
            // Ajustarlo a la parte inferior del formulario
            this.pnlInferior.Anchor = AnchorStyles.Bottom;
            // Ajustar ancho del panel inferior
            this.pnlInferior.Width = formulario.Width;
        }

        // Método sobrecargado del estilo panel inferior
        public void estiloPanelInferior()
        {
            // Ajustar ancho del panel inferior
            this.pnlInferior.Width = formulario.Width;
        }

        // Método para establecer estilo de un TabControl
        public void estiloTabControl(TabControl nuevo)
        {
            this.tbContenido = nuevo;
            // En un foreach, voy cambiando el fondo de todas las páginas del TabControl
            foreach(TabPage p in this.tbContenido.TabPages)
            {
                p.BackColor = (Color)cv.ConvertFromString("#fafafa");
            }
        }

        // Método para redimensionar los elementos al Maximizar
        public void estiloMaximizar(Form Nuevo)
        {
            this.formulario = Nuevo;
            estiloPanelSuperior();
            estiloPanelCabecera();
            estiloPanelContenido();
            estiloPanelInferior();
            estiloBotonesMaximizar();
        }

        // Método para escribir la fecha actual al programa

        public void estiloFecha(Label nuevo)
        {
            this.lblFecha = nuevo;
            this.lblFecha.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
            this.lblFecha.Text = "Fecha: " + DateTime.Now.ToString("dd-MM-yyyy");
        }

        // Método para escribir la hora actual al programa
        public void estiloHora(Label nuevo)
        {
            this.lblHora = nuevo;
            this.lblHora.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
            // El formato de la hora es 24 horas, con hora, minuto y segundos
            // Los segundos realmente se podrían quitar y hacer el cambio cada minuto
            // aligera el programa
            this.lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

        // Método sobrecargado para ir cambiando la hora
        public void estiloHora()
        {
            this.lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss"); ;
        }

        public void estiloImagen(PictureBox nuevo)
        {
            this.pbAvatar = nuevo;
            pbAvatar.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
