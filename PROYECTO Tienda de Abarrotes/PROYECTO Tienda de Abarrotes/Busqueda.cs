using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PROYECTO_Tienda_de_Abarrotes
{
    public partial class Busqueda : Form
    {
        OleDbConnection Conexion;
        ListViewItem Lista;
        int I = 0,x;
        string SQL;
        public Busqueda()
        {
            InitializeComponent();
        }   

        private void Busqueda_Load(object sender, EventArgs e)
        {
            Btn1.Focus();
            String CadConexion;
            CadConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;"
                        + @"Data Source=..\..\Base de Datos\Tienda de Abarrotes.accdb;"
                        + @"Persist Security Info=False;";
            Conexion = new OleDbConnection(CadConexion);

            LvProductos.View = View.Details;
            LvProductos.GridLines = true;
            LvProductos.FullRowSelect = true;

            LvProductos.Columns.Add("Id", 75, HorizontalAlignment.Left);
            LvProductos.Columns.Add("Nombre", 86, HorizontalAlignment.Center);
            LvProductos.Columns.Add("Precio", 86, HorizontalAlignment.Center);
            LvProductos.Columns.Add("Cantidad", 86, HorizontalAlignment.Center);
            LvProductos.Columns.Add("Proveedor", 86, HorizontalAlignment.Center);
            LvProductos.Columns.Add("Categoría", 86, HorizontalAlignment.Center);
            LvProductos.Columns.Add("F. de Caducidad", 86, HorizontalAlignment.Center);
            LvProductos.Columns.Add("Inventario", 75, HorizontalAlignment.Center);

            Conexion.Open();
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmdsql;
                OleDbDataReader Recuperar;
                switch (I)
                {
                    case 1:
                        SQL = "SELECT * FROM Productos WHERE Id LIKE " + TxtId.Text + "";
                        break;
                    case 2:
                        SQL = "SELECT * FROM Productos WHERE Nombre LIKE '" + TxtNombre.Text + "%'";
                        break;
                    case 3:
                        SQL = "SELECT * FROM Productos WHERE Precio LIKE " + TxtPrecio.Text + "";
                        break;
                    case 4:
                        SQL = "SELECT * FROM Productos WHERE Cantidad LIKE '" + TxtCantidad.Text + "%'";
                        break;
                    case 5:
                        SQL = "SELECT * FROM Productos WHERE Proveedor LIKE '" + TxtProveedor.Text + "%'";
                        break;
                    case 6:
                        SQL = "SELECT * FROM Productos WHERE Categoria LIKE '" + TxtCategoria.Text + "%'";
                        break;
                    case 7:
                        SQL = "SELECT * FROM Productos WHERE Fecha_de_Caducidad LIKE '" + TxtFCaducidad.Text + "%'";
                        break;
                    case 8:
                        SQL = "SELECT * FROM Productos WHERE Inventario LIKE " + TxtInventario.Text + "";
                        break;
                    default:    
                        break;
                }
                cmdsql = new OleDbCommand(SQL, Conexion);
                Recuperar = cmdsql.ExecuteReader();
                if (Recuperar.HasRows)
                {
                    while (Recuperar.Read())
                    {
                        Lista = LvProductos.Items.Add(Recuperar["Id"].ToString());
                        Lista.SubItems.Add(Recuperar["Nombre"].ToString());
                        Lista.SubItems.Add(Recuperar["Precio"].ToString());
                        Lista.SubItems.Add(Recuperar["Cantidad"].ToString());
                        Lista.SubItems.Add(Recuperar["Proveedor"].ToString());
                        Lista.SubItems.Add(Recuperar["Categoria"].ToString());
                        Lista.SubItems.Add(Recuperar["Fecha_de_Caducidad"].ToString());
                        Lista.SubItems.Add(Recuperar["Inventario"].ToString());
                    }

                }
                x=LvProductos.Items.Count;
                
                if (x == 0)
                {
                    MessageBox.Show("No se encontraron registros con esas características", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                TxtId.Clear();
                TxtNombre.Clear();
                TxtPrecio.Clear();
                TxtCantidad.Clear();
                TxtProveedor.Clear();
                TxtCategoria.Clear();
                TxtFCaducidad.Clear();
                TxtInventario.Clear();

                TxtId.Enabled = false;
                TxtNombre.Enabled = false;
                TxtPrecio.Enabled = false;
                TxtCantidad.Enabled = false;
                TxtProveedor.Enabled = false;
                TxtCategoria.Enabled = false;
                TxtFCaducidad.Enabled = false;
                TxtInventario.Enabled = false;

                LblId.Visible = true;
                LblNombre.Visible = true;
                LblPrecio.Visible = true;
                LblCantidad.Visible = true;
                LblProveedor.Visible = true;
                LblCategoria.Visible = true;
                LblFCaducidad.Visible = true;
                LblInventario.Visible = true;

                TxtId.Visible = true;
                TxtNombre.Visible = true;
                TxtPrecio.Visible = true;
                TxtCantidad.Visible = true;
                TxtProveedor.Visible = true;
                TxtCategoria.Visible = true;
                TxtFCaducidad.Visible = true;
                TxtInventario.Visible = true;

                LvProductos.Focus();
                LblTitulo.Text = "Selecciona el campo a buscar";

            }
            catch
            {
                MessageBox.Show("Elige una forma de búsqueda o llena el campo solicitado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtId.Enabled = true;
            TxtNombre.Enabled = false;
            TxtPrecio.Enabled = false;
            TxtCantidad.Enabled = false;
            TxtProveedor.Enabled = false;
            TxtCategoria.Enabled = false;
            TxtFCaducidad.Enabled = false;
            TxtInventario.Enabled = false;

            LblId.Visible = true;
            LblNombre.Visible = false;
            LblPrecio.Visible = false;
            LblCantidad.Visible = false;
            LblProveedor.Visible = false;
            LblCategoria.Visible = false;
            LblFCaducidad.Visible = false;
            LblInventario.Visible = false;

            TxtId.Visible = true;
            TxtNombre.Visible = false;
            TxtPrecio.Visible = false;
            TxtCantidad.Visible = false;
            TxtProveedor.Visible = false;
            TxtCategoria.Visible = false;
            TxtFCaducidad.Visible = false;
            TxtInventario.Visible = false;

            TxtId.Focus();

            TxtId.Clear();
            TxtNombre.Clear();
            TxtPrecio.Clear();
            TxtCantidad.Clear();
            TxtProveedor.Clear();
            TxtCategoria.Clear();
            TxtFCaducidad.Clear();
            TxtInventario.Clear();
            LvProductos.Items.Clear();

       

            LblTitulo.Text = "Está buscando por Id...";
            I = 1;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtId.Enabled = false;
            TxtNombre.Enabled = true;
            TxtPrecio.Enabled = false;
            TxtCantidad.Enabled = false;
            TxtProveedor.Enabled = false;
            TxtCategoria.Enabled = false;
            TxtFCaducidad.Enabled = false;
            TxtInventario.Enabled = false;

            LblId.Visible = false;
            LblNombre.Visible = true;
            LblPrecio.Visible = false;
            LblCantidad.Visible = false;
            LblProveedor.Visible = false;
            LblCategoria.Visible = false;
            LblFCaducidad.Visible = false;
            LblInventario.Visible = false;

            TxtId.Visible = false;
            TxtNombre.Visible = true;
            TxtPrecio.Visible = false;
            TxtCantidad.Visible = false;
            TxtProveedor.Visible = false;
            TxtCategoria.Visible = false;
            TxtFCaducidad.Visible = false;
            TxtInventario.Visible = false;

            TxtNombre.Focus();

            TxtId.Clear();
            TxtNombre.Clear();
            TxtPrecio.Clear();
            TxtCantidad.Clear();
            TxtProveedor.Clear();
            TxtCategoria.Clear();
            TxtFCaducidad.Clear();
            TxtInventario.Clear();
            LvProductos.Items.Clear();
        
            LblTitulo.Text = "Está buscando por Nombre...";

            I = 2;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtId.Enabled = false;
            TxtNombre.Enabled = false;
            TxtPrecio.Enabled = true;
            TxtCantidad.Enabled = false;
            TxtProveedor.Enabled = false;
            TxtCategoria.Enabled = false;
            TxtFCaducidad.Enabled = false;
            TxtInventario.Enabled = false;

            LblId.Visible = false;
            LblNombre.Visible = false;
            LblPrecio.Visible = true;
            LblCantidad.Visible = false;
            LblProveedor.Visible = false;
            LblCategoria.Visible = false;
            LblFCaducidad.Visible = false;
            LblInventario.Visible = false;

            TxtId.Visible = false;
            TxtNombre.Visible = false;
            TxtPrecio.Visible = true;
            TxtCantidad.Visible = false;
            TxtProveedor.Visible = false;
            TxtCategoria.Visible = false;
            TxtFCaducidad.Visible = false;
            TxtInventario.Visible = false;

            TxtPrecio.Focus();

            TxtId.Clear();
            TxtNombre.Clear();
            TxtPrecio.Clear();
            TxtCantidad.Clear();
            TxtProveedor.Clear();
            TxtCategoria.Clear();
            TxtFCaducidad.Clear();
            TxtInventario.Clear();
            LvProductos.Items.Clear();
         
            LblTitulo.Text = "Está buscando por Precio...";
            I = 3;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtId.Enabled = false;
            TxtNombre.Enabled = false;
            TxtPrecio.Enabled = false;
            TxtCantidad.Enabled = true;
            TxtProveedor.Enabled = false;
            TxtCategoria.Enabled = false;
            TxtFCaducidad.Enabled = false;
            TxtInventario.Enabled = false;

            LblId.Visible = false;
            LblNombre.Visible = false;
            LblPrecio.Visible = false;
            LblCantidad.Visible = true;
            LblProveedor.Visible = false;
            LblCategoria.Visible = false;
            LblFCaducidad.Visible = false;
            LblInventario.Visible = false;

            TxtId.Visible = false;
            TxtNombre.Visible = false;
            TxtPrecio.Visible = false;
            TxtCantidad.Visible = true;
            TxtProveedor.Visible = false;
            TxtCategoria.Visible = false;
            TxtFCaducidad.Visible = false;
            TxtInventario.Visible = false;

            TxtCantidad.Focus();

            TxtId.Clear();
            TxtNombre.Clear();
            TxtPrecio.Clear();
            TxtCantidad.Clear();
            TxtProveedor.Clear();
            TxtCategoria.Clear();
            TxtFCaducidad.Clear();
            TxtInventario.Clear();
            LvProductos.Items.Clear();
            
            LblTitulo.Text = "Está buscando por Cantidad...";
            I = 4;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtId.Enabled = false;
            TxtNombre.Enabled = false;
            TxtPrecio.Enabled = false;
            TxtCantidad.Enabled = false;
            TxtProveedor.Enabled = true;
            TxtCategoria.Enabled = false;
            TxtFCaducidad.Enabled = false;
            TxtInventario.Enabled = false;

            LblId.Visible = false;
            LblNombre.Visible = false;
            LblPrecio.Visible = false;
            LblCantidad.Visible = false;
            LblProveedor.Visible = true;
            LblCategoria.Visible = false;
            LblFCaducidad.Visible = false;
            LblInventario.Visible = false;

            TxtId.Visible = false;
            TxtNombre.Visible = false;
            TxtPrecio.Visible = false;
            TxtCantidad.Visible = false;
            TxtProveedor.Visible = true;
            TxtCategoria.Visible = false;
            TxtFCaducidad.Visible = false;
            TxtInventario.Visible = false;

            TxtProveedor.Focus();

            TxtId.Clear();
            TxtNombre.Clear();
            TxtPrecio.Clear();
            TxtCantidad.Clear();
            TxtProveedor.Clear();
            TxtCategoria.Clear();
            TxtFCaducidad.Clear();
            TxtInventario.Clear();
            LvProductos.Items.Clear();
            
            LblTitulo.Text = "Está buscando por Proveedor...";
            I = 5;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtId.Enabled = false;
            TxtNombre.Enabled = false;
            TxtPrecio.Enabled = false;
            TxtCantidad.Enabled = false;
            TxtProveedor.Enabled = false;
            TxtCategoria.Enabled = true;
            TxtFCaducidad.Enabled = false;
            TxtInventario.Enabled = false;

            LblId.Visible = false;
            LblNombre.Visible = false;
            LblPrecio.Visible = false;
            LblCantidad.Visible = false;
            LblProveedor.Visible = false;
            LblCategoria.Visible = true;
            LblFCaducidad.Visible = false;
            LblInventario.Visible = false;

            TxtId.Visible = false;
            TxtNombre.Visible = false;
            TxtPrecio.Visible = false;
            TxtCantidad.Visible = false;
            TxtProveedor.Visible = false;
            TxtCategoria.Visible = true;
            TxtFCaducidad.Visible = false;
            TxtInventario.Visible = false;

            TxtCategoria.Focus();

            TxtId.Clear();
            TxtNombre.Clear();
            TxtPrecio.Clear();
            TxtCantidad.Clear();
            TxtProveedor.Clear();
            TxtCategoria.Clear();
            TxtFCaducidad.Clear();
            TxtInventario.Clear();
            LvProductos.Items.Clear();
            LblTitulo.Text = "Está buscando por Categoría...";
            I = 6;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtId.Enabled = false;
            TxtNombre.Enabled = false;
            TxtPrecio.Enabled = false;
            TxtCantidad.Enabled = false;
            TxtProveedor.Enabled = false;
            TxtCategoria.Enabled = false;
            TxtFCaducidad.Enabled = true;
            TxtInventario.Enabled = false;

            LblId.Visible = false;
            LblNombre.Visible = false;
            LblPrecio.Visible = false;
            LblCantidad.Visible = false;
            LblProveedor.Visible = false;
            LblCategoria.Visible = false;
            LblFCaducidad.Visible = true;
            LblInventario.Visible = false;

            TxtId.Visible = false;
            TxtNombre.Visible = false;
            TxtPrecio.Visible = false;
            TxtCantidad.Visible = false;
            TxtProveedor.Visible = false;
            TxtCategoria.Visible = false;
            TxtFCaducidad.Visible = true;
            TxtInventario.Visible = false;

            TxtFCaducidad.Focus();

            TxtId.Clear();
            TxtNombre.Clear();
            TxtPrecio.Clear();
            TxtCantidad.Clear();
            TxtProveedor.Clear();
            TxtCategoria.Clear();
            TxtFCaducidad.Clear();
            TxtInventario.Clear();
            LvProductos.Items.Clear();
            LblTitulo.Text = "Está buscando por Fecha de \nCaducidad...";
            I = 7;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtId.Enabled = false;
            TxtNombre.Enabled = false;
            TxtPrecio.Enabled = false;
            TxtCantidad.Enabled = false;
            TxtProveedor.Enabled = false;
            TxtCategoria.Enabled = false;
            TxtFCaducidad.Enabled = false;
            TxtInventario.Enabled = true;

            LblId.Visible = false;
            LblNombre.Visible = false;
            LblPrecio.Visible = false;
            LblCantidad.Visible = false;
            LblProveedor.Visible = false;
            LblCategoria.Visible = false;
            LblFCaducidad.Visible = false;
            LblInventario.Visible = true;

            TxtId.Visible = false;
            TxtNombre.Visible = false;
            TxtPrecio.Visible = false;
            TxtCantidad.Visible = false;
            TxtProveedor.Visible = false;
            TxtCategoria.Visible = false;
            TxtFCaducidad.Visible = false;
            TxtInventario.Visible = true;

            TxtInventario.Focus();

            TxtId.Clear();
            TxtNombre.Clear();
            TxtPrecio.Clear();
            TxtCantidad.Clear();
            TxtProveedor.Clear();
            TxtCategoria.Clear();
            TxtFCaducidad.Clear();
            TxtInventario.Clear();
            LvProductos.Items.Clear();

            LblTitulo.Text = "Está buscando por Inventario...";
            I = 8;
        }

        private void LvProductos_DoubleClick(object sender, EventArgs e)
        {
            string Id, Nombre, Precio, Cantidad, Proveedor, Categoria, FCaducidad, Inventario;

            if (LvProductos.SelectedItems.Count >= 1)
            {
                Id = LvProductos.SelectedItems[0].Text;
                Nombre = LvProductos.SelectedItems[0].SubItems[1].Text;
                Precio = LvProductos.SelectedItems[0].SubItems[2].Text;
                Cantidad = LvProductos.SelectedItems[0].SubItems[3].Text;
                Proveedor = LvProductos.SelectedItems[0].SubItems[4].Text;
                Categoria = LvProductos.SelectedItems[0].SubItems[5].Text;
                FCaducidad = LvProductos.SelectedItems[0].SubItems[6].Text;
                Inventario = LvProductos.SelectedItems[0].SubItems[7].Text;


                String SQL;
                DialogResult Resp;
                Resp = MessageBox.Show("¿Estás seguro de borrar la siguiente información, esta acción no se podrá deshacer ?", "Peligro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resp == DialogResult.Yes)
                {
                    SQL = "DELETE * FROM Productos WHERE Id = " + Id + "";

                    OleDbCommand cmdsql = new OleDbCommand(SQL, Conexion);                    
                    cmdsql.ExecuteNonQuery();
                                                          
                    MessageBox.Show("Información eliminada", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LvProductos.Items.Clear();
                }
            }
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 08 || e.KeyChar == 32)
            { }
            else if (char.IsNumber(e.KeyChar) == false)
                e.Handled = true;

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnBuscar_Click_1(sender, e);
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 08 || e.KeyChar == 32)
            { }
            else if (char.IsLetter(e.KeyChar) == false)
                e.Handled = true;

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnBuscar_Click_1(sender, e);
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46) //Codigo ascii del'punto'
            {
                if (TxtPrecio.Text.Contains('.') == true)
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            if (e.KeyChar == 08 || e.KeyChar == 32 || e.KeyChar == 46)
            { }
            else if (char.IsNumber(e.KeyChar) == false)
                e.Handled = true;

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnBuscar_Click_1(sender, e);
            }
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46) //Codigo ascii del'punto'
            {
                if (TxtCantidad.Text.Contains('.') == true)
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            if (e.KeyChar == 08 || e.KeyChar == 32)
            { }
            else if ((char.IsLetter(e.KeyChar) == true) && (char.IsNumber(e.KeyChar) == true))
                e.Handled = true;

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnBuscar_Click_1(sender, e);
            }
        }

        private void TxtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 08 || e.KeyChar == 32)
            { }
            else if (char.IsLetter(e.KeyChar) == false)
                e.Handled = true;

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnBuscar_Click_1(sender, e);
            }
        }

        private void TxtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 08 || e.KeyChar == 32)
            { }
            else if (char.IsLetter(e.KeyChar) == false)
                e.Handled = true;

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnBuscar_Click_1(sender, e);
            }
        }

        private void TxtFCaducidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 08 || e.KeyChar == 32 || e.KeyChar == 47)
            { }
            else if (char.IsNumber(e.KeyChar) == false)
                e.Handled = true;

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnBuscar_Click_1(sender, e);
            }
        }

        private void LvProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                LvProductos_DoubleClick(sender, e);
            }
        }

        private void TxtInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 08 || e.KeyChar == 32)
            { }
            else if (char.IsNumber(e.KeyChar) == false)
                e.Handled = true;

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnBuscar_Click_1(sender, e);
            }
        }
    }
}
