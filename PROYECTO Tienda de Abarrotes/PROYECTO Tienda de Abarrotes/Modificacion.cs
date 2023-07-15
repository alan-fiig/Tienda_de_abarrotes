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
    public partial class Modificacion : Form
    {
        OleDbConnection Conexion;
        ListViewItem Lista;
        DialogResult Resp;
        public Modificacion()
        {
            InitializeComponent();
        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            LvProductos.Focus();
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

            OleDbCommand Mostrar;
            OleDbDataReader Recuperar;
            String SQL;
            SQL = "SELECT * FROM Productos";
            Mostrar = new OleDbCommand(SQL, Conexion);

            Recuperar = Mostrar.ExecuteReader();
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

        }

        private void BtnModificar_Click(object sender, EventArgs e)
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

                TxtId.Text = Id;
                TxtNombre.Text = Nombre;
                TxtPrecio.Text = Precio;
                TxtCantidad.Text = Cantidad;
                TxtProveedor.Text = Proveedor;
                TxtCategoria.Text = Categoria;
                TxtFCaducidad.Text = FCaducidad;
                TxtInventario.Text = Inventario;

                TxtId.Enabled = false;
                TxtNombre.Enabled = true;
                TxtPrecio.Enabled = true;
                TxtCantidad.Enabled = true;
                TxtProveedor.Enabled = true;
                TxtCategoria.Enabled = true;
                TxtFCaducidad.Enabled = true;
                TxtInventario.Enabled = true;
                TxtNombre.Focus();
            }
            
            else
            {
                MessageBox.Show("Ocurrio el siguiente error: Favor de seleccionar un elemento de la lista ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                String SQL;
                SQL = "UPDATE Productos SET Nombre = '" + TxtNombre.Text + "', Precio = " + TxtPrecio.Text + ", Cantidad = '" + TxtCantidad.Text + "', Proveedor = '" + TxtProveedor.Text + "', Categoria = '" + TxtCategoria.Text + "', Fecha_de_Caducidad = '" + TxtFCaducidad.Text + "', Inventario = " + TxtInventario.Text + " WHERE Id = " + TxtId.Text + " ";
                OleDbCommand cmdsql = new OleDbCommand(SQL, Conexion);

                cmdsql.Parameters.AddWithValue("@Id", TxtId.Text);
                cmdsql.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                cmdsql.Parameters.AddWithValue("@Precio", TxtPrecio.Text);
                cmdsql.Parameters.AddWithValue("@Cantidad", TxtCantidad.Text);
                cmdsql.Parameters.AddWithValue("@Proveedor", TxtProveedor.Text);
                cmdsql.Parameters.AddWithValue("@Categoria", TxtCategoria.Text);
                cmdsql.Parameters.AddWithValue("@Fecha_de_Caducidad", TxtFCaducidad.Text);
                cmdsql.Parameters.AddWithValue("@Inventario", TxtInventario.Text);

                cmdsql.ExecuteNonQuery();
                
                TxtId.Clear();
                TxtNombre.Clear();
                TxtPrecio.Clear();
                TxtCantidad.Clear();
                TxtProveedor.Clear();
                TxtCategoria.Clear();
                TxtFCaducidad.Clear();
                TxtInventario.Clear();

                TxtNombre.Enabled = false;
                TxtPrecio.Enabled = false;
                TxtCantidad.Enabled = false;
                TxtProveedor.Enabled = false;
                TxtCategoria.Enabled = false;
                TxtFCaducidad.Enabled = false;
                TxtInventario.Enabled = false;

                Conexion.Close();

                Resp = MessageBox.Show("Datos guardados", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch
            {
                MessageBox.Show("Primero elige un archivo a modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Resp == DialogResult.OK)
                {
                    LvProductos.Items.Clear();
                    Lista.SubItems.Clear();
                    Conexion.Open();


                    OleDbCommand Mostrar;
                    OleDbDataReader Recuperar;
                    String SQL;
                    SQL = "SELECT * FROM Productos";
                    Mostrar = new OleDbCommand(SQL, Conexion);

                    Recuperar = Mostrar.ExecuteReader();
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
                    Resp = 0;
                }
                else
                {
                    MessageBox.Show("La base de datos ya ha sido actualizada o ningun elemento se ha guardado aún", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("La base de datos ya ha sido actualizada o ningun elemento se ha guardado aún", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                BtnGuardar_Click(sender, e);
                BtnActualizar_Click(sender, e);

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
                BtnGuardar_Click(sender, e);
                BtnActualizar_Click(sender, e);

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
                BtnGuardar_Click(sender, e);
                BtnActualizar_Click(sender, e);

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
                BtnGuardar_Click(sender, e);
                BtnActualizar_Click(sender, e);

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
                BtnGuardar_Click(sender, e);
                BtnActualizar_Click(sender, e);

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
                BtnGuardar_Click(sender, e);
                BtnActualizar_Click(sender, e);

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
                BtnGuardar_Click(sender, e);
                BtnActualizar_Click(sender, e);

            }
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

                TxtId.Text = Id;
                TxtNombre.Text = Nombre;
                TxtPrecio.Text = Precio;
                TxtCantidad.Text = Cantidad;
                TxtProveedor.Text = Proveedor;
                TxtCategoria.Text = Categoria;
                TxtFCaducidad.Text = FCaducidad;
                TxtInventario.Text = Inventario;

                TxtId.Enabled = false;
                TxtNombre.Enabled = true;
                TxtPrecio.Enabled = true;
                TxtCantidad.Enabled = true;
                TxtProveedor.Enabled = true;
                TxtCategoria.Enabled = true;
                TxtFCaducidad.Enabled = true;
                TxtInventario.Enabled = true;
            }
            TxtNombre.Focus();
        }

        private void LvProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                LvProductos_DoubleClick(sender, e);

            }
        }
    }
}
