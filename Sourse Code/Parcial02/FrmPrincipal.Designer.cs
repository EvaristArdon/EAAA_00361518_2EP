using System.ComponentModel;

namespace Parcial02
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrdenEliminar = new System.Windows.Forms.TextBox();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.dgrPedidos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccionEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminarDireccion = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccionNueva = new System.Windows.Forms.TextBox();
            this.txtDireccionModificar = new System.Windows.Forms.TextBox();
            this.btnModificarDireccion = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnVerDirecciones = new System.Windows.Forms.Button();
            this.dgrDireccion = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dgrOrdenes = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgrNegocios = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtNegocio = new System.Windows.Forms.TextBox();
            this.btnAgregarNegocio = new System.Windows.Forms.Button();
            this.btnEliminarNegocio = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgrProductos = new System.Windows.Forms.DataGridView();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtNombreNegocio2 = new System.Windows.Forms.TextBox();
            this.btnAregarProducto = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.dgrUsuarios = new System.Windows.Forms.DataGridView();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgrPedidos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgrDireccion)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgrOrdenes)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgrNegocios)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgrProductos)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgrUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Indigo;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.62007F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.37993F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 587);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Indigo;
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Realizar pedido";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.10105F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.39895F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDireccion, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbProductos, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnEliminarPedido, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtOrdenEliminar, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnAgregarPedido, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.dgrPedidos, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.59829F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.53846F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.45299F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.982906F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(736, 468);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 70);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dirección";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 51);
            this.label3.TabIndex = 1;
            this.label3.Text = "Producto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.Location = new System.Drawing.Point(276, 23);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(210, 23);
            this.txtDireccion.TabIndex = 2;
            // 
            // cmbProductos
            // 
            this.cmbProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(274, 84);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(213, 23);
            this.cmbProductos.TabIndex = 3;
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarPedido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarPedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarPedido.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarPedido.Location = new System.Drawing.Point(538, 141);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(178, 33);
            this.btnEliminarPedido.TabIndex = 4;
            this.btnEliminarPedido.Text = "Eliminar";
            this.btnEliminarPedido.UseVisualStyleBackColor = true;
            this.btnEliminarPedido.Click += new System.EventHandler(this.btnEliminarPedido_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 74);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID de la orden a eliminar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOrdenEliminar
            // 
            this.txtOrdenEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrdenEliminar.Location = new System.Drawing.Point(276, 146);
            this.txtOrdenEliminar.Name = "txtOrdenEliminar";
            this.txtOrdenEliminar.Size = new System.Drawing.Size(210, 23);
            this.txtOrdenEliminar.TabIndex = 6;
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarPedido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarPedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregarPedido.ForeColor = System.Drawing.Color.Blue;
            this.btnAgregarPedido.Location = new System.Drawing.Point(542, 80);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(171, 31);
            this.btnAgregarPedido.TabIndex = 8;
            this.btnAgregarPedido.Text = "Agregar pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // dgrPedidos
            // 
            this.dgrPedidos.AllowUserToAddRows = false;
            this.dgrPedidos.AllowUserToDeleteRows = false;
            this.dgrPedidos.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dgrPedidos, 3);
            this.dgrPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrPedidos.Location = new System.Drawing.Point(3, 224);
            this.dgrPedidos.Name = "dgrPedidos";
            this.dgrPedidos.ReadOnly = true;
            this.tableLayoutPanel2.SetRowSpan(this.dgrPedidos, 3);
            this.dgrPedidos.Size = new System.Drawing.Size(730, 241);
            this.dgrPedidos.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Indigo;
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(741, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cambiar direccion";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtDireccionEliminar, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnEliminarDireccion, 6, 3);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtDireccionNueva, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtDireccionModificar, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnModificarDireccion, 6, 2);
            this.tableLayoutPanel3.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtUser, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnVerDirecciones, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgrDireccion, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.08791F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.48352F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(735, 469);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label7
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.label7, 2);
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(107, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 66);
            this.label7.TabIndex = 2;
            this.label7.Text = "Dirección a eliminar:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDireccionEliminar
            // 
            this.txtDireccionEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.SetColumnSpan(this.txtDireccionEliminar, 2);
            this.txtDireccionEliminar.Location = new System.Drawing.Point(425, 220);
            this.txtDireccionEliminar.Name = "txtDireccionEliminar";
            this.txtDireccionEliminar.Size = new System.Drawing.Size(189, 23);
            this.txtDireccionEliminar.TabIndex = 5;
            // 
            // btnEliminarDireccion
            // 
            this.btnEliminarDireccion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminarDireccion.Font = new System.Drawing.Font("Century Gothic", 9F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarDireccion.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarDireccion.Location = new System.Drawing.Point(627, 202);
            this.btnEliminarDireccion.Name = "btnEliminarDireccion";
            this.btnEliminarDireccion.Size = new System.Drawing.Size(105, 60);
            this.btnEliminarDireccion.TabIndex = 10;
            this.btnEliminarDireccion.Text = "Eliminar dirección";
            this.btnEliminarDireccion.UseVisualStyleBackColor = true;
            this.btnEliminarDireccion.Click += new System.EventHandler(this.btnEliminarDireccion_Click);
            // 
            // label6
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.label6, 2);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(107, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 66);
            this.label6.TabIndex = 1;
            this.label6.Text = "Dirección nueva:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.label5, 2);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(107, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 77);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dirección a modificar:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDireccionNueva
            // 
            this.txtDireccionNueva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.SetColumnSpan(this.txtDireccionNueva, 2);
            this.txtDireccionNueva.Location = new System.Drawing.Point(425, 154);
            this.txtDireccionNueva.Name = "txtDireccionNueva";
            this.txtDireccionNueva.Size = new System.Drawing.Size(189, 23);
            this.txtDireccionNueva.TabIndex = 4;
            // 
            // txtDireccionModificar
            // 
            this.txtDireccionModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.SetColumnSpan(this.txtDireccionModificar, 2);
            this.txtDireccionModificar.Location = new System.Drawing.Point(425, 83);
            this.txtDireccionModificar.Name = "txtDireccionModificar";
            this.txtDireccionModificar.Size = new System.Drawing.Size(189, 23);
            this.txtDireccionModificar.TabIndex = 3;
            // 
            // btnModificarDireccion
            // 
            this.btnModificarDireccion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificarDireccion.Font = new System.Drawing.Font("Century Gothic", 9F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnModificarDireccion.ForeColor = System.Drawing.Color.Blue;
            this.btnModificarDireccion.Location = new System.Drawing.Point(627, 136);
            this.btnModificarDireccion.Name = "btnModificarDireccion";
            this.btnModificarDireccion.Size = new System.Drawing.Size(105, 60);
            this.btnModificarDireccion.TabIndex = 9;
            this.btnModificarDireccion.Text = "Modificar dirección";
            this.btnModificarDireccion.UseVisualStyleBackColor = true;
            this.btnModificarDireccion.Click += new System.EventHandler(this.btnDireccionModificar_Click);
            // 
            // label8
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.label8, 2);
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(107, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 55);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nombre de usuario";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.SetColumnSpan(this.txtUser, 2);
            this.txtUser.Location = new System.Drawing.Point(425, 16);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(189, 23);
            this.txtUser.TabIndex = 8;
            // 
            // btnVerDirecciones
            // 
            this.btnVerDirecciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerDirecciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerDirecciones.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnVerDirecciones.ForeColor = System.Drawing.Color.Blue;
            this.btnVerDirecciones.Location = new System.Drawing.Point(627, 3);
            this.btnVerDirecciones.Name = "btnVerDirecciones";
            this.btnVerDirecciones.Size = new System.Drawing.Size(105, 50);
            this.btnVerDirecciones.TabIndex = 11;
            this.btnVerDirecciones.Text = "Ver mis direcciones";
            this.btnVerDirecciones.UseVisualStyleBackColor = true;
            this.btnVerDirecciones.Click += new System.EventHandler(this.btnVerDirecciones_Click);
            // 
            // dgrDireccion
            // 
            this.dgrDireccion.AllowUserToAddRows = false;
            this.dgrDireccion.AllowUserToDeleteRows = false;
            this.dgrDireccion.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel3.SetColumnSpan(this.dgrDireccion, 7);
            this.dgrDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrDireccion.Location = new System.Drawing.Point(3, 268);
            this.dgrDireccion.Name = "dgrDireccion";
            this.dgrDireccion.ReadOnly = true;
            this.tableLayoutPanel3.SetRowSpan(this.dgrDireccion, 3);
            this.dgrDireccion.Size = new System.Drawing.Size(729, 198);
            this.dgrDireccion.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Indigo;
            this.tabPage3.Controls.Add(this.tableLayoutPanel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(741, 475);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ver órdenes";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.dgrOrdenes, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(735, 469);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // dgrOrdenes
            // 
            this.dgrOrdenes.AllowUserToAddRows = false;
            this.dgrOrdenes.AllowUserToDeleteRows = false;
            this.dgrOrdenes.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel4.SetColumnSpan(this.dgrOrdenes, 2);
            this.dgrOrdenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrOrdenes.Location = new System.Drawing.Point(3, 3);
            this.dgrOrdenes.Name = "dgrOrdenes";
            this.dgrOrdenes.ReadOnly = true;
            this.tableLayoutPanel4.SetRowSpan(this.dgrOrdenes, 2);
            this.dgrOrdenes.Size = new System.Drawing.Size(729, 463);
            this.dgrOrdenes.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Indigo;
            this.tabPage4.Controls.Add(this.tableLayoutPanel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(741, 475);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ver negocios";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.46196F));
            this.tableLayoutPanel5.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.61957F));
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.dgrNegocios, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.richTextBox1, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtNegocio, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnAgregarNegocio, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnEliminarNegocio, 4, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(735, 469);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label9
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.label9, 2);
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 93);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nombre del negocio:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.label10, 2);
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(286, 93);
            this.label10.TabIndex = 1;
            this.label10.Text = "Descripción:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgrNegocios
            // 
            this.dgrNegocios.AllowUserToAddRows = false;
            this.dgrNegocios.AllowUserToDeleteRows = false;
            this.dgrNegocios.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel5.SetColumnSpan(this.dgrNegocios, 5);
            this.dgrNegocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrNegocios.Location = new System.Drawing.Point(3, 282);
            this.dgrNegocios.Name = "dgrNegocios";
            this.dgrNegocios.ReadOnly = true;
            this.tableLayoutPanel5.SetRowSpan(this.dgrNegocios, 2);
            this.dgrNegocios.Size = new System.Drawing.Size(729, 184);
            this.dgrNegocios.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel5.SetColumnSpan(this.richTextBox1, 2);
            this.richTextBox1.Location = new System.Drawing.Point(296, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.tableLayoutPanel5.SetRowSpan(this.richTextBox1, 2);
            this.richTextBox1.Size = new System.Drawing.Size(214, 177);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // txtNegocio
            // 
            this.txtNegocio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel5.SetColumnSpan(this.txtNegocio, 2);
            this.txtNegocio.Location = new System.Drawing.Point(296, 35);
            this.txtNegocio.Name = "txtNegocio";
            this.txtNegocio.Size = new System.Drawing.Size(214, 23);
            this.txtNegocio.TabIndex = 2;
            // 
            // btnAgregarNegocio
            // 
            this.btnAgregarNegocio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarNegocio.Font = new System.Drawing.Font("Century Gothic", 14.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregarNegocio.ForeColor = System.Drawing.Color.Blue;
            this.btnAgregarNegocio.Location = new System.Drawing.Point(526, 21);
            this.btnAgregarNegocio.Name = "btnAgregarNegocio";
            this.btnAgregarNegocio.Size = new System.Drawing.Size(196, 50);
            this.btnAgregarNegocio.TabIndex = 5;
            this.btnAgregarNegocio.Text = "Agregar negocio";
            this.btnAgregarNegocio.UseVisualStyleBackColor = true;
            this.btnAgregarNegocio.Click += new System.EventHandler(this.btnAgregarNegocio_Click);
            // 
            // btnEliminarNegocio
            // 
            this.btnEliminarNegocio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarNegocio.Font = new System.Drawing.Font("Century Gothic", 14.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarNegocio.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarNegocio.Location = new System.Drawing.Point(529, 116);
            this.btnEliminarNegocio.Name = "btnEliminarNegocio";
            this.btnEliminarNegocio.Size = new System.Drawing.Size(191, 46);
            this.btnEliminarNegocio.TabIndex = 6;
            this.btnEliminarNegocio.Text = "Eliminar Negocio";
            this.btnEliminarNegocio.UseVisualStyleBackColor = true;
            this.btnEliminarNegocio.Click += new System.EventHandler(this.btnEliminarNegocio_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Indigo;
            this.tabPage5.Controls.Add(this.tableLayoutPanel6);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(742, 474);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Ver productos";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.dgrProductos, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.txtNombreProducto, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtNombreNegocio2, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.btnAregarProducto, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnEliminarProducto, 4, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(736, 468);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label11
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.label11, 2);
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 93);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nombre del producto:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.label12, 2);
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 93);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nombre del negocio:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgrProductos
            // 
            this.dgrProductos.AllowUserToAddRows = false;
            this.dgrProductos.AllowUserToDeleteRows = false;
            this.dgrProductos.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel6.SetColumnSpan(this.dgrProductos, 5);
            this.dgrProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrProductos.Location = new System.Drawing.Point(3, 189);
            this.dgrProductos.Name = "dgrProductos";
            this.dgrProductos.ReadOnly = true;
            this.tableLayoutPanel6.SetRowSpan(this.dgrProductos, 3);
            this.dgrProductos.Size = new System.Drawing.Size(730, 276);
            this.dgrProductos.TabIndex = 4;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel6.SetColumnSpan(this.txtNombreProducto, 2);
            this.txtNombreProducto.Location = new System.Drawing.Point(309, 35);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(264, 23);
            this.txtNombreProducto.TabIndex = 2;
            // 
            // txtNombreNegocio2
            // 
            this.txtNombreNegocio2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel6.SetColumnSpan(this.txtNombreNegocio2, 2);
            this.txtNombreNegocio2.Location = new System.Drawing.Point(309, 128);
            this.txtNombreNegocio2.Name = "txtNombreNegocio2";
            this.txtNombreNegocio2.Size = new System.Drawing.Size(264, 23);
            this.txtNombreNegocio2.TabIndex = 3;
            // 
            // btnAregarProducto
            // 
            this.btnAregarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAregarProducto.Font = new System.Drawing.Font("Century Gothic", 14.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAregarProducto.ForeColor = System.Drawing.Color.Blue;
            this.btnAregarProducto.Location = new System.Drawing.Point(591, 8);
            this.btnAregarProducto.Name = "btnAregarProducto";
            this.btnAregarProducto.Size = new System.Drawing.Size(141, 77);
            this.btnAregarProducto.TabIndex = 5;
            this.btnAregarProducto.Text = "Agregar producto";
            this.btnAregarProducto.UseVisualStyleBackColor = true;
            this.btnAregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Indigo;
            this.tabPage6.Controls.Add(this.tableLayoutPanel7);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(741, 475);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Ver usuarios";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel7.ColumnCount = 5;
            this.tableLayoutPanel7.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtNombreCompleto, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtNombreUsuario, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.dgrUsuarios, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.btnAgregarUsuario, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnEliminarUsuario, 4, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 5;
            this.tableLayoutPanel7.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.8764F));
            this.tableLayoutPanel7.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.726458F));
            this.tableLayoutPanel7.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.52915F));
            this.tableLayoutPanel7.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(735, 469);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label14
            // 
            this.tableLayoutPanel7.SetColumnSpan(this.label14, 2);
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(288, 84);
            this.label14.TabIndex = 2;
            this.label14.Text = "Nombre de usuario:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.tableLayoutPanel7.SetColumnSpan(this.label13, 2);
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(288, 89);
            this.label13.TabIndex = 0;
            this.label13.Text = "Nombe completo:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel7.SetColumnSpan(this.txtNombreCompleto, 2);
            this.txtNombreCompleto.Location = new System.Drawing.Point(306, 33);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(270, 23);
            this.txtNombreCompleto.TabIndex = 1;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel7.SetColumnSpan(this.txtNombreUsuario, 2);
            this.txtNombreUsuario.Location = new System.Drawing.Point(306, 119);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(270, 23);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // dgrUsuarios
            // 
            this.dgrUsuarios.AllowUserToAddRows = false;
            this.dgrUsuarios.AllowUserToDeleteRows = false;
            this.dgrUsuarios.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel7.SetColumnSpan(this.dgrUsuarios, 5);
            this.dgrUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrUsuarios.Location = new System.Drawing.Point(3, 206);
            this.dgrUsuarios.Name = "dgrUsuarios";
            this.dgrUsuarios.ReadOnly = true;
            this.tableLayoutPanel7.SetRowSpan(this.dgrUsuarios, 3);
            this.dgrUsuarios.Size = new System.Drawing.Size(729, 260);
            this.dgrUsuarios.TabIndex = 4;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.Blue;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(591, 3);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(141, 82);
            this.btnAgregarUsuario.TabIndex = 5;
            this.btnAgregarUsuario.Text = "Agregar usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuari_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(591, 93);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(141, 76);
            this.btnEliminarUsuario.TabIndex = 6;
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 79);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Onyx", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarProducto.Location = new System.Drawing.Point(595, 103);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(134, 73);
            this.btnEliminarProducto.TabIndex = 6;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 587);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HUGO Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgrPedidos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgrDireccion)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgrOrdenes)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgrNegocios)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgrProductos)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgrUsuarios)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.TextBox txtOrdenEliminar;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.TextBox txtDireccionModificar;
        private System.Windows.Forms.TextBox txtDireccionNueva;
        private System.Windows.Forms.TextBox txtDireccionEliminar;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnModificarDireccion;
        private System.Windows.Forms.Button btnEliminarDireccion;
        private System.Windows.Forms.Button btnVerDirecciones;
        private System.Windows.Forms.DataGridView dgrPedidos;
        private System.Windows.Forms.DataGridView dgrDireccion;
        private System.Windows.Forms.DataGridView dgrOrdenes;
        private System.Windows.Forms.TextBox txtNegocio;
        private System.Windows.Forms.DataGridView dgrNegocios;
        private System.Windows.Forms.Button btnAgregarNegocio;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtNombreNegocio2;
        private System.Windows.Forms.DataGridView dgrProductos;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.DataGridView dgrUsuarios;
        private System.Windows.Forms.Button btnAregarProducto;
        private System.Windows.Forms.Button btnEliminarNegocio;
        private System.Windows.Forms.Button btnEliminarProducto;
    }
}