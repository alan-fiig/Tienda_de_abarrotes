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
    public partial class Productos : Form
    {
        OleDbConnection Conexion;
        ListViewItem Lista;
        int ColumnaOrdenar = -1;

        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
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

            LvProductos.Columns.Add("Id", 108, HorizontalAlignment.Left);
            LvProductos.Columns.Add("Nombre", 131, HorizontalAlignment.Center);
            LvProductos.Columns.Add("Precio", 131, HorizontalAlignment.Center);
            LvProductos.Columns.Add("Cantidad", 131, HorizontalAlignment.Center);
            LvProductos.Columns.Add("Proveedor", 131, HorizontalAlignment.Center);
            LvProductos.Columns.Add("Categoría", 131, HorizontalAlignment.Center);
            LvProductos.Columns.Add("F. de Caducidad", 131, HorizontalAlignment.Center);
            LvProductos.Columns.Add("Inventario", 131, HorizontalAlignment.Center);

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

                MessageBox.Show("La información seleccionada es: \nId: " +
                    Id + "\nNombre: " + Nombre + "\nPrecio: " + Precio + "\nCantidad: " + Cantidad + "\nProveedor: " + Proveedor + "\nCategoría: " 
                    + Categoria + "\nFecha de Caducidad: " + FCaducidad + "\nInventario: " + Inventario, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LvProductos_Enter(object sender, EventArgs e)
        {
            
        }

        private void LvProductos_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != ColumnaOrdenar)
            {
                ColumnaOrdenar = e.Column;
                LvProductos.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (LvProductos.Sorting == SortOrder.Ascending)
                    LvProductos.Sorting = SortOrder.Descending;
                else
                    LvProductos.Sorting = SortOrder.Ascending;
            }
            LvProductos.Sort();


            this.LvProductos.ListViewItemSorter =
                new ListViewItemComparer(e.Column, LvProductos.Sorting);
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

