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
    public partial class Eliminacion : Form
    {
        OleDbConnection Conexion;
        ListViewItem Lista;
        DialogResult Resp2;
        public Eliminacion()
        {
            InitializeComponent();
        }

        private void Eliminacion_Load(object sender, EventArgs e)
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
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                String SQL;
                DialogResult Resp;
                Resp = MessageBox.Show("¿Estás seguro de borrar la siguiente información, esta acción no se podrá deshacer?", "Peligro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resp == DialogResult.Yes)
                {
                    SQL = "DELETE * FROM Productos WHERE Id = " + TxtId.Text + "";

                    OleDbCommand cmdsql = new OleDbCommand(SQL, Conexion);

                    cmdsql.Parameters.AddWithValue("@Id", TxtId.Text);
                    
                    cmdsql.ExecuteNonQuery();

                    TxtId.Clear();
                    TxtNombre.Clear();
                    TxtPrecio.Clear();
                    TxtCantidad.Clear();
                    TxtProveedor.Clear();
                    TxtCategoria.Clear();
                    TxtFCaducidad.Clear();
                    TxtInventario.Clear();
                    

                    Conexion.Close();

                    Resp2 = MessageBox.Show("Información eliminada", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Primero selecciona la información a eliminar o actualiza la base de datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Resp2 == DialogResult.OK)
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
                    Resp2 = 0;
                }
                else
                {
                    MessageBox.Show("La base de datos ya ha sido actualizada o ningun elemento se ha eliminado aún", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("La base de datos ya ha sido actualizada o ningun elemento se ha eliminado aún", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
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
                
            }
            else
            {
                MessageBox.Show("Ocurrio el siguiente error: Favor de seleccionar un elemento de la lista ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LvProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                
                BtnEliminar_Click(sender, e);
                BtnActualizar_Click(sender, e);
            }
        }
    }
}
