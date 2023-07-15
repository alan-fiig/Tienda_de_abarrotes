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
    public partial class Captura : Form
    {
        OleDbConnection Conexion;
        ListViewItem Lista;
        DialogResult Resp;
        public Captura()
        {
            InitializeComponent();
        }

        private void Captura_Load(object sender, EventArgs e)
        {
            TxtNombre.Focus();
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                String SQL;
                SQL = "INSERT INTO Productos (Nombre, Precio, Cantidad, Proveedor, Categoria, Fecha_de_Caducidad, Inventario) VALUES (@Nombre, @Precio, @Cantidad, @Proveedor, @Categoria, @Fecha_de_Caducidad, @Inventario)";
                OleDbCommand cmdsql = new OleDbCommand(SQL, Conexion);



                cmdsql.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                cmdsql.Parameters.AddWithValue("@Precio", TxtPrecio.Text);
                cmdsql.Parameters.AddWithValue("@Cantidad", TxtCantidad.Text);
                cmdsql.Parameters.AddWithValue("@Proveedor", TxtProveedor.Text);
                cmdsql.Parameters.AddWithValue("@Categoria", TxtCategoria.Text);
                cmdsql.Parameters.AddWithValue("@Fecha_de_Caducidad", TxtFCaducidad.Text);
                cmdsql.Parameters.AddWithValue("@Inventario", TxtInventario.Text);

                cmdsql.ExecuteNonQuery();

                
                TxtNombre.Clear();
                TxtPrecio.Clear();
                TxtCantidad.Clear();
                TxtProveedor.Clear();
                TxtCategoria.Clear();
                TxtFCaducidad.Clear();
                TxtInventario.Clear();

                Conexion.Close();

                Resp = MessageBox.Show("Dato guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Favor de llenar todos los campos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    LvProductos.Focus();
                }
                else
                {
                    MessageBox.Show("La base de datos ya ha sido actualizada o ningún elemento se ha guardado aún", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("La base de datos ya ha sido actualizada o ningún elemento se ha guardado aún", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 08 || e.KeyChar == 32)
            { }
            else if (char.IsLetter(e.KeyChar) == false)
                e.Handled = true;
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
        }

        private void TxtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 08 || e.KeyChar == 32)
            { }
            else if (char.IsLetter(e.KeyChar) == false)
                e.Handled = true;
        }

        private void TxtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 08 || e.KeyChar == 32)
            { }
            else if (char.IsLetter(e.KeyChar) == false)
                e.Handled = true;
        }

        private void TxtFCaducidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 08 || e.KeyChar == 47)
            { }
            else if (char.IsNumber(e.KeyChar) == false)
                e.Handled = true;
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
    }
}
