namespace IcoFarma
{
    partial class frmReporteVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdata = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbobusqueda = new Siticone.UI.WinForms.SiticoneRoundedComboBox();
            this.btnExcel = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.btnLimparBusqueda = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.btnBusqueda = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.txtfechainicio = new Siticone.UI.WinForms.SiticoneRoundedDateTimePicker();
            this.txtfechafin = new Siticone.UI.WinForms.SiticoneRoundedDateTimePicker();
            this.txtbusqueda = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscar = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            // 
            // DocumentoProveedor
            // 
            this.DocumentoProveedor.HeaderText = "Documento Proveedor";
            this.DocumentoProveedor.Name = "DocumentoProveedor";
            // 
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.HeaderText = "Usuario Registro";
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Numero Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdata.ColumnHeadersHeight = 50;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoTotal,
            this.UsuarioRegistro,
            this.DocumentoProveedor,
            this.RazonSocial,
            this.NombreProducto,
            this.Categoria,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvdata.DoubleBuffered = true;
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgvdata.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.dgvdata.HeaderForeColor = System.Drawing.Color.White;
            this.dgvdata.Location = new System.Drawing.Point(12, 157);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvdata.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvdata.RowTemplate.DividerHeight = 1;
            this.dgvdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.Size = new System.Drawing.Size(1010, 447);
            this.dgvdata.TabIndex = 128;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cbobusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.cbobusqueda.BorderThickness = 2;
            this.cbobusqueda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbobusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbobusqueda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbobusqueda.ForeColor = System.Drawing.Color.White;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.HoveredState.Parent = this.cbobusqueda;
            this.cbobusqueda.ItemHeight = 30;
            this.cbobusqueda.ItemsAppearance.Parent = this.cbobusqueda;
            this.cbobusqueda.Location = new System.Drawing.Point(678, 105);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.ShadowDecoration.Parent = this.cbobusqueda;
            this.cbobusqueda.Size = new System.Drawing.Size(140, 36);
            this.cbobusqueda.TabIndex = 127;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnExcel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.btnExcel.BorderThickness = 2;
            this.btnExcel.CheckedState.Parent = this.btnExcel;
            this.btnExcel.CustomImages.Parent = this.btnExcel;
            this.btnExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcel.HoveredState.Parent = this.btnExcel;
            this.btnExcel.Image = global::IcoFarma.Properties.Resources.Microsoft_Excel;
            this.btnExcel.Location = new System.Drawing.Point(12, 105);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.ShadowDecoration.Parent = this.btnExcel;
            this.btnExcel.Size = new System.Drawing.Size(170, 36);
            this.btnExcel.TabIndex = 126;
            this.btnExcel.Text = "Exportar en Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click_1);
            // 
            // btnLimparBusqueda
            // 
            this.btnLimparBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnLimparBusqueda.CheckedState.Parent = this.btnLimparBusqueda;
            this.btnLimparBusqueda.CustomImages.Parent = this.btnLimparBusqueda;
            this.btnLimparBusqueda.FillColor = System.Drawing.Color.Firebrick;
            this.btnLimparBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimparBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnLimparBusqueda.HoveredState.Parent = this.btnLimparBusqueda;
            this.btnLimparBusqueda.Image = global::IcoFarma.Properties.Resources.Broom;
            this.btnLimparBusqueda.Location = new System.Drawing.Point(979, 105);
            this.btnLimparBusqueda.Name = "btnLimparBusqueda";
            this.btnLimparBusqueda.ShadowDecoration.Parent = this.btnLimparBusqueda;
            this.btnLimparBusqueda.Size = new System.Drawing.Size(43, 36);
            this.btnLimparBusqueda.TabIndex = 125;
            this.btnLimparBusqueda.Click += new System.EventHandler(this.btnLimparBusqueda_Click_1);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnBusqueda.CheckedState.Parent = this.btnBusqueda;
            this.btnBusqueda.CustomImages.Parent = this.btnBusqueda;
            this.btnBusqueda.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnBusqueda.HoveredState.Parent = this.btnBusqueda;
            this.btnBusqueda.Image = global::IcoFarma.Properties.Resources.Search;
            this.btnBusqueda.Location = new System.Drawing.Point(930, 105);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.ShadowDecoration.Parent = this.btnBusqueda;
            this.btnBusqueda.Size = new System.Drawing.Size(43, 36);
            this.btnBusqueda.TabIndex = 124;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtfechainicio.BorderThickness = 2;
            this.txtfechainicio.CheckedState.Parent = this.txtfechainicio;
            this.txtfechainicio.CustomFormat = "dd/MM/yyyy";
            this.txtfechainicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtfechainicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfechainicio.HoveredState.Parent = this.txtfechainicio;
            this.txtfechainicio.Location = new System.Drawing.Point(207, 31);
            this.txtfechainicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtfechainicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.ShadowDecoration.Parent = this.txtfechainicio;
            this.txtfechainicio.Size = new System.Drawing.Size(131, 36);
            this.txtfechainicio.TabIndex = 123;
            this.txtfechainicio.Value = new System.DateTime(2023, 10, 28, 0, 0, 0, 0);
            // 
            // txtfechafin
            // 
            this.txtfechafin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtfechafin.BorderThickness = 2;
            this.txtfechafin.CheckedState.Parent = this.txtfechafin;
            this.txtfechafin.CustomFormat = "dd/MM/yyyy";
            this.txtfechafin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtfechafin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfechafin.HoveredState.Parent = this.txtfechafin;
            this.txtfechafin.Location = new System.Drawing.Point(443, 31);
            this.txtfechafin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtfechafin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.ShadowDecoration.Parent = this.txtfechafin;
            this.txtfechafin.Size = new System.Drawing.Size(131, 36);
            this.txtfechafin.TabIndex = 121;
            this.txtfechafin.Value = new System.DateTime(2023, 10, 28, 0, 0, 0, 0);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtbusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtbusqueda.BorderThickness = 2;
            this.txtbusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbusqueda.DefaultText = "";
            this.txtbusqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbusqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbusqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbusqueda.DisabledState.Parent = this.txtbusqueda;
            this.txtbusqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbusqueda.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtbusqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbusqueda.FocusedState.Parent = this.txtbusqueda;
            this.txtbusqueda.ForeColor = System.Drawing.Color.White;
            this.txtbusqueda.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbusqueda.HoveredState.Parent = this.txtbusqueda;
            this.txtbusqueda.Location = new System.Drawing.Point(824, 105);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.PasswordChar = '\0';
            this.txtbusqueda.PlaceholderText = "Busca Aqui";
            this.txtbusqueda.SelectedText = "";
            this.txtbusqueda.ShadowDecoration.Parent = this.txtbusqueda;
            this.txtbusqueda.Size = new System.Drawing.Size(100, 36);
            this.txtbusqueda.TabIndex = 120;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(585, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 118;
            this.label11.Text = "Buscar Por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(358, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 116;
            this.label2.Text = "Fecha Fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(106, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 115;
            this.label1.Text = "Fecha Inicio:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1010, 83);
            this.label10.TabIndex = 114;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnBuscar.CheckedState.Parent = this.btnBuscar;
            this.btnBuscar.CustomImages.Parent = this.btnBuscar;
            this.btnBuscar.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.HoveredState.Parent = this.btnBuscar;
            this.btnBuscar.Image = global::IcoFarma.Properties.Resources.Search;
            this.btnBuscar.Location = new System.Drawing.Point(580, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ShadowDecoration.Parent = this.btnBuscar;
            this.btnBuscar.Size = new System.Drawing.Size(43, 36);
            this.btnBuscar.TabIndex = 122;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.siticonePictureBox1.Image = global::IcoFarma.Properties.Resources.Increase1;
            this.siticonePictureBox1.Location = new System.Drawing.Point(25, 22);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(59, 55);
            this.siticonePictureBox1.TabIndex = 129;
            this.siticonePictureBox1.TabStop = false;
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1034, 691);
            this.Controls.Add(this.siticonePictureBox1);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnLimparBusqueda);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.txtfechainicio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Name = "frmReporteVentas";
            this.Text = "frmReporteVentas";
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private Siticone.UI.WinForms.SiticoneRoundedComboBox cbobusqueda;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnExcel;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnLimparBusqueda;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnBusqueda;
        private Siticone.UI.WinForms.SiticoneRoundedDateTimePicker txtfechainicio;
        private Siticone.UI.WinForms.SiticoneRoundedDateTimePicker txtfechafin;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtbusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnBuscar;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
    }
}