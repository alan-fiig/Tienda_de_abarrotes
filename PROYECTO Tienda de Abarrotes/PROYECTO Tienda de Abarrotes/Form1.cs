using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //Librería que nos permite poder ejecutar el código para que el formulario (ventana) se pueda mover
using System.Data.OleDb;

namespace PROYECTO_Tienda_de_Abarrotes
{
    public partial class FormTienda : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
            //Código que permite que el formulario pueda moverse con libertad, la cual será llamada más adelante

        public FormTienda()
        {
            InitializeComponent();         
        }      

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (resp == DialogResult.Yes)
                this.Close();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;   //Maximiza el forumlario  y las imagenen correspondiente pasa a modo invisible
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;  //Vuelve al tamaño original el forumlario  y las imagenen correspondiente pasa a modo invisible
            BtnMaximizar.Visible = true;
            BtnRestaurar.Visible = false;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Minimiza el formulario
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); //Intrucción que llama al código anteriormete puesto para que el formulario se pueda mover libremente 
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (resp == DialogResult.Yes)
                this.Close();
        }

        private void BtnSalirr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbrirFormFormulario(object formformularios)    //Función con objetos, el cual funciona para poder llamar a los formulario y mostrarlos en pantalla
        {
            if (this.panelContenedor.Controls.Count > 0)    //Pregunta si el pane tiene algún formulario abierto
                this.panelContenedor.Controls.RemoveAt(0);  //En caso de que si lo cierra con RemoveAt

            Form Fm = formformularios as Form;            //Creación del formulario, el cual es igual al objeto que recibe de la función  
            Fm.TopLevel = false;                          //Instrucción que sirve para decir que el formulario no es un formulario de nivel superior y si uno secundario
            Fm.Dock = DockStyle.Fill;                     //Intrucción que sirve para que el formulario se acople al panel contenedor
            this.panelContenedor.Controls.Add(Fm);        //El formulario se agrega al panel 
            this.panelContenedor.Tag = Fm;                //Se establece la instancia (documento en el que se solicita algo) como contenedor de datos del panel
            Fm.Show();                                    //El formulario se muestra en pantalla
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormFormulario(new Productos());  
            //Instrucción que manda a llamar a la "Función con objetos" para que se muestre el formulario que se pide despues de la palabra "new ____________"
        }

        private void FormTienda_Load(object sender, EventArgs e)
        {
            BtnProductos_Click(null, e);      //Instrucción que sirve para que al iniciar el programa se muestre el formulario de productos    
        }

        private void BtnCaptura_Click(object sender, EventArgs e)
        {
            AbrirFormFormulario(new Captura());
        }

        private void BtnBusquedas_Click(object sender, EventArgs e)
        {
            AbrirFormFormulario(new Busqueda());
        }

        private void BtnEliminacion_Click(object sender, EventArgs e)
        {
            AbrirFormFormulario(new Eliminacion());
        }

        private void BtnModificacion_Click(object sender, EventArgs e)
        {
            AbrirFormFormulario(new Modificacion());
        }

        private void BtnSalir2_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if(resp == DialogResult.Yes)
            this.Close();
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Titulo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
