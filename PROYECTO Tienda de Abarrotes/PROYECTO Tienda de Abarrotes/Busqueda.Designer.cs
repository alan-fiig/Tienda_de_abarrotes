namespace PROYECTO_Tienda_de_Abarrotes
{
    partial class Busqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busqueda));
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LvProductos = new System.Windows.Forms.ListView();
            this.Btn1 = new System.Windows.Forms.Button();
            this.TxtFCaducidad = new System.Windows.Forms.TextBox();
            this.LblFCaducidad = new System.Windows.Forms.Label();
            this.TxtInventario = new System.Windows.Forms.TextBox();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblInventario = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(121)))), ((int)(((byte)(204)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(12, 571);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(353, 32);
            this.BtnBuscar.TabIndex = 101;
            this.BtnBuscar.Text = "&Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // LvProductos
            // 
            this.LvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LvProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(249)))));
            this.LvProductos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvProductos.ForeColor = System.Drawing.Color.Black;
            this.LvProductos.Location = new System.Drawing.Point(371, 12);
            this.LvProductos.Name = "LvProductos";
            this.LvProductos.Size = new System.Drawing.Size(687, 591);
            this.LvProductos.TabIndex = 98;
            this.TpInfo.SetToolTip(this.LvProductos, "Puedes eliminar un registro haciendo doble click sobre \r\nel mismo o con Enter...");
            this.LvProductos.UseCompatibleStateImageBehavior = false;
            this.LvProductos.DoubleClick += new System.EventHandler(this.LvProductos_DoubleClick);
            this.LvProductos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LvProductos_KeyPress);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.White;
            this.Btn1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(121)))), ((int)(((byte)(204)))));
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.Color.Black;
            this.Btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1.Location = new System.Drawing.Point(12, 66);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(100, 32);
            this.Btn1.TabIndex = 103;
            this.Btn1.Text = "&Id";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // TxtFCaducidad
            // 
            this.TxtFCaducidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFCaducidad.Enabled = false;
            this.TxtFCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFCaducidad.Location = new System.Drawing.Point(155, 477);
            this.TxtFCaducidad.MaxLength = 10;
            this.TxtFCaducidad.Multiline = true;
            this.TxtFCaducidad.Name = "TxtFCaducidad";
            this.TxtFCaducidad.Size = new System.Drawing.Size(210, 22);
            this.TxtFCaducidad.TabIndex = 117;
            this.TxtFCaducidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFCaducidad_KeyPress);
            // 
            // LblFCaducidad
            // 
            this.LblFCaducidad.AutoSize = true;
            this.LblFCaducidad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFCaducidad.ForeColor = System.Drawing.Color.White;
            this.LblFCaducidad.Location = new System.Drawing.Point(12, 478);
            this.LblFCaducidad.Name = "LblFCaducidad";
            this.LblFCaducidad.Size = new System.Drawing.Size(137, 22);
            this.LblFCaducidad.TabIndex = 119;
            this.LblFCaducidad.Text = "F. Caducidad:";
            // 
            // TxtInventario
            // 
            this.TxtInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtInventario.Enabled = false;
            this.TxtInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInventario.Location = new System.Drawing.Point(155, 522);
            this.TxtInventario.MaxLength = 3;
            this.TxtInventario.Multiline = true;
            this.TxtInventario.Name = "TxtInventario";
            this.TxtInventario.Size = new System.Drawing.Size(210, 22);
            this.TxtInventario.TabIndex = 118;
            this.TxtInventario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInventario_KeyPress);
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCategoria.Enabled = false;
            this.TxtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCategoria.Location = new System.Drawing.Point(155, 434);
            this.TxtCategoria.MaxLength = 30;
            this.TxtCategoria.Multiline = true;
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(210, 22);
            this.TxtCategoria.TabIndex = 116;
            this.TxtCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCategoria_KeyPress);
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProveedor.Enabled = false;
            this.TxtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProveedor.Location = new System.Drawing.Point(155, 388);
            this.TxtProveedor.MaxLength = 50;
            this.TxtProveedor.Multiline = true;
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.Size = new System.Drawing.Size(210, 22);
            this.TxtProveedor.TabIndex = 115;
            this.TxtProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProveedor_KeyPress);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCantidad.Enabled = false;
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(155, 342);
            this.TxtCantidad.MaxLength = 20;
            this.TxtCantidad.Multiline = true;
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(210, 22);
            this.TxtCantidad.TabIndex = 114;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecio.Enabled = false;
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(155, 296);
            this.TxtPrecio.MaxLength = 7;
            this.TxtPrecio.Multiline = true;
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(210, 22);
            this.TxtPrecio.TabIndex = 113;
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(155, 249);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.Multiline = true;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(210, 22);
            this.TxtNombre.TabIndex = 112;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtId
            // 
            this.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtId.Enabled = false;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(155, 202);
            this.TxtId.MaxLength = 2;
            this.TxtId.Multiline = true;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(210, 22);
            this.TxtId.TabIndex = 111;
            this.TxtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtId_KeyPress);
            // 
            // LblInventario
            // 
            this.LblInventario.AutoSize = true;
            this.LblInventario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInventario.ForeColor = System.Drawing.Color.White;
            this.LblInventario.Location = new System.Drawing.Point(12, 522);
            this.LblInventario.Name = "LblInventario";
            this.LblInventario.Size = new System.Drawing.Size(110, 22);
            this.LblInventario.TabIndex = 110;
            this.LblInventario.Text = "Inventario:";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.ForeColor = System.Drawing.Color.White;
            this.LblCategoria.Location = new System.Drawing.Point(12, 434);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(107, 22);
            this.LblCategoria.TabIndex = 109;
            this.LblCategoria.Text = "Categoría:";
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProveedor.ForeColor = System.Drawing.Color.White;
            this.LblProveedor.Location = new System.Drawing.Point(12, 388);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(115, 22);
            this.LblProveedor.TabIndex = 108;
            this.LblProveedor.Text = "Proveedor:";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.ForeColor = System.Drawing.Color.White;
            this.LblCantidad.Location = new System.Drawing.Point(12, 342);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(100, 22);
            this.LblCantidad.TabIndex = 107;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.ForeColor = System.Drawing.Color.White;
            this.LblPrecio.Location = new System.Drawing.Point(12, 296);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(77, 22);
            this.LblPrecio.TabIndex = 106;
            this.LblPrecio.Text = "Precio:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(12, 249);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(90, 22);
            this.LblNombre.TabIndex = 105;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.Color.White;
            this.LblId.Location = new System.Drawing.Point(12, 199);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(34, 22);
            this.LblId.TabIndex = 104;
            this.LblId.Text = "Id:";
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.White;
            this.Btn2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(121)))), ((int)(((byte)(204)))));
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.Color.Black;
            this.Btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn2.Location = new System.Drawing.Point(138, 66);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(100, 32);
            this.Btn2.TabIndex = 120;
            this.Btn2.Text = "&Nombre";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.White;
            this.Btn3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(121)))), ((int)(((byte)(204)))));
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.Color.Black;
            this.Btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3.Location = new System.Drawing.Point(265, 66);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(100, 32);
            this.Btn3.TabIndex = 121;
            this.Btn3.Text = "&Precio";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.White;
            this.Btn4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn4.FlatAppearance.BorderSize = 0;
            this.Btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(121)))), ((int)(((byte)(204)))));
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.ForeColor = System.Drawing.Color.Black;
            this.Btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn4.Location = new System.Drawing.Point(12, 104);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(100, 32);
            this.Btn4.TabIndex = 122;
            this.Btn4.Text = "&Cantidad";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.White;
            this.Btn5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn5.FlatAppearance.BorderSize = 0;
            this.Btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(121)))), ((int)(((byte)(204)))));
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.ForeColor = System.Drawing.Color.Black;
            this.Btn5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn5.Location = new System.Drawing.Point(138, 104);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(100, 32);
            this.Btn5.TabIndex = 123;
            this.Btn5.Text = "Prov&eedor";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.White;
            this.Btn6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn6.FlatAppearance.BorderSize = 0;
            this.Btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(121)))), ((int)(((byte)(204)))));
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.ForeColor = System.Drawing.Color.Black;
            this.Btn6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn6.Location = new System.Drawing.Point(265, 104);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(100, 32);
            this.Btn6.TabIndex = 124;
            this.Btn6.Text = "Cate&goría";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.White;
            this.Btn7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn7.FlatAppearance.BorderSize = 0;
            this.Btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(121)))), ((int)(((byte)(204)))));
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.ForeColor = System.Drawing.Color.Black;
            this.Btn7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn7.Location = new System.Drawing.Point(12, 142);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(127, 32);
            this.Btn7.TabIndex = 125;
            this.Btn7.Text = "F. Ca&ducidad";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.White;
            this.Btn8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn8.FlatAppearance.BorderSize = 0;
            this.Btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(121)))), ((int)(((byte)(204)))));
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.ForeColor = System.Drawing.Color.Black;
            this.Btn8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn8.Location = new System.Drawing.Point(163, 142);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(127, 32);
            this.Btn8.TabIndex = 126;
            this.Btn8.Text = "Inventari&o";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(41, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(287, 22);
            this.LblTitulo.TabIndex = 127;
            this.LblTitulo.Text = "Selecciona el campo a buscar";
            // 
            // TpInfo
            // 
            this.TpInfo.AutoPopDelay = 2500;
            this.TpInfo.InitialDelay = 500;
            this.TpInfo.IsBalloon = true;
            this.TpInfo.ReshowDelay = 100;
            this.TpInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TpInfo.ToolTipTitle = "Eliminación";
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1070, 615);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.TxtFCaducidad);
            this.Controls.Add(this.LblFCaducidad);
            this.Controls.Add(this.TxtInventario);
            this.Controls.Add(this.TxtCategoria);
            this.Controls.Add(this.TxtProveedor);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblInventario);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblProveedor);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.LvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Busqueda";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Busqueda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ListView LvProductos;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.TextBox TxtFCaducidad;
        private System.Windows.Forms.Label LblFCaducidad;
        private System.Windows.Forms.TextBox TxtInventario;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.TextBox TxtProveedor;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblInventario;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblProveedor;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.ToolTip TpInfo;
    }
}