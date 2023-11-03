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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvdata = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbobusqueda = new Siticone.UI.WinForms.SiticoneRoundedComboBox();
            this.btnExcel = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.btnLimparBusqueda = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.btnBusqueda = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.txtfechainicio = new Siticone.UI.WinForms.SiticoneRoundedDateTimePicker();
            this.txtfechafin = new Siticone.UI.WinForms.SiticoneRoundedDateTimePicker();
            this.txtbusqueda = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscar = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.cboc2 = new Siticone.UI.WinForms.SiticoneRoundedComboBox();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.cboc1 = new Siticone.UI.WinForms.SiticoneRoundedComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.siticoneLabel3 = new Siticone.UI.WinForms.SiticoneLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvdata.ColumnHeadersHeight = 50;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoTotal,
            this.UsuarioRegistro,
            this.DocumentoProveedor,
            this.RazonSocial,
            this.CodigoProducto,
            this.NombreProducto,
            this.Categoria,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvdata.DoubleBuffered = true;
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgvdata.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.dgvdata.HeaderForeColor = System.Drawing.Color.White;
            this.dgvdata.Location = new System.Drawing.Point(12, 148);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvdata.RowHeadersVisible = false;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvdata.RowTemplate.DividerHeight = 1;
            this.dgvdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.Size = new System.Drawing.Size(861, 661);
            this.dgvdata.TabIndex = 128;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.MinimumWidth = 6;
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.Width = 125;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.MinimumWidth = 6;
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.Width = 125;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Numero Documento";
            this.NumeroDocumento.MinimumWidth = 6;
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.Width = 125;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.MinimumWidth = 6;
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.Width = 125;
            // 
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.HeaderText = "Usuario Registro";
            this.UsuarioRegistro.MinimumWidth = 6;
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            this.UsuarioRegistro.Width = 125;
            // 
            // DocumentoProveedor
            // 
            this.DocumentoProveedor.HeaderText = "Documento Proveedor";
            this.DocumentoProveedor.MinimumWidth = 6;
            this.DocumentoProveedor.Name = "DocumentoProveedor";
            this.DocumentoProveedor.Width = 125;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.MinimumWidth = 6;
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.Width = 125;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 125;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 125;
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
            this.cbobusqueda.Location = new System.Drawing.Point(526, 105);
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
            this.btnLimparBusqueda.Location = new System.Drawing.Point(829, 106);
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
            this.btnBusqueda.Location = new System.Drawing.Point(780, 105);
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
            this.txtfechainicio.Size = new System.Drawing.Size(154, 36);
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
            this.txtfechafin.Location = new System.Drawing.Point(477, 31);
            this.txtfechafin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtfechafin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.ShadowDecoration.Parent = this.txtfechafin;
            this.txtfechafin.Size = new System.Drawing.Size(154, 36);
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
            this.txtbusqueda.Location = new System.Drawing.Point(673, 105);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.PasswordChar = '\0';
            this.txtbusqueda.PlaceholderText = "Busca Aqui";
            this.txtbusqueda.SelectedText = "";
            this.txtbusqueda.ShadowDecoration.Parent = this.txtbusqueda;
            this.txtbusqueda.Size = new System.Drawing.Size(100, 36);
            this.txtbusqueda.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(392, 41);
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
            this.label10.Size = new System.Drawing.Size(860, 83);
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
            this.btnBuscar.Location = new System.Drawing.Point(647, 31);
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
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chart2.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart2.BackSecondaryColor = System.Drawing.Color.White;
            this.chart2.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chart2.BorderSkin.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart2.BorderSkin.BackSecondaryColor = System.Drawing.Color.White;
            this.chart2.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            chartArea7.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            chartArea7.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            chartArea7.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea7);
            legend7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            legend7.BackImageTransparentColor = System.Drawing.Color.White;
            legend7.BackSecondaryColor = System.Drawing.Color.White;
            legend7.BorderColor = System.Drawing.Color.White;
            legend7.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend7.ForeColor = System.Drawing.Color.White;
            legend7.HeaderSeparatorColor = System.Drawing.Color.White;
            legend7.InterlacedRowsColor = System.Drawing.Color.White;
            legend7.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend7.Name = "Legend1";
            legend7.ShadowColor = System.Drawing.Color.White;
            legend7.TitleBackColor = System.Drawing.Color.White;
            legend7.TitleForeColor = System.Drawing.Color.White;
            legend7.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart2.Legends.Add(legend7);
            this.chart2.Location = new System.Drawing.Point(918, 468);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series7.BackImageTransparentColor = System.Drawing.Color.White;
            series7.BackSecondaryColor = System.Drawing.Color.White;
            series7.BorderColor = System.Drawing.Color.Transparent;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series7.Color = System.Drawing.Color.DodgerBlue;
            series7.LabelForeColor = System.Drawing.Color.White;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series7.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series7.ShadowColor = System.Drawing.Color.White;
            series7.YValuesPerPoint = 2;
            this.chart2.Series.Add(series7);
            this.chart2.Size = new System.Drawing.Size(497, 314);
            this.chart2.TabIndex = 135;
            this.chart2.Text = "chart2";
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel2.Location = new System.Drawing.Point(918, 425);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(110, 37);
            this.siticoneLabel2.TabIndex = 134;
            this.siticoneLabel2.Text = "Graficar:";
            // 
            // cboc2
            // 
            this.cboc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cboc2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.cboc2.BorderThickness = 2;
            this.cboc2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboc2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboc2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cboc2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboc2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboc2.ForeColor = System.Drawing.Color.White;
            this.cboc2.FormattingEnabled = true;
            this.cboc2.HoveredState.Parent = this.cboc2;
            this.cboc2.ItemHeight = 30;
            this.cboc2.ItemsAppearance.Parent = this.cboc2;
            this.cboc2.Location = new System.Drawing.Point(1034, 425);
            this.cboc2.Name = "cboc2";
            this.cboc2.ShadowDecoration.Parent = this.cboc2;
            this.cboc2.Size = new System.Drawing.Size(233, 36);
            this.cboc2.TabIndex = 133;
            this.cboc2.SelectedIndexChanged += new System.EventHandler(this.cboc2_SelectedIndexChanged);
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel1.Location = new System.Drawing.Point(918, 62);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(110, 37);
            this.siticoneLabel1.TabIndex = 132;
            this.siticoneLabel1.Text = "Graficar:";
            // 
            // cboc1
            // 
            this.cboc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cboc1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.cboc1.BorderThickness = 2;
            this.cboc1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboc1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboc1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cboc1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboc1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboc1.ForeColor = System.Drawing.Color.White;
            this.cboc1.FormattingEnabled = true;
            this.cboc1.HoveredState.Parent = this.cboc1;
            this.cboc1.ItemHeight = 30;
            this.cboc1.ItemsAppearance.Parent = this.cboc1;
            this.cboc1.Location = new System.Drawing.Point(1034, 62);
            this.cboc1.Name = "cboc1";
            this.cboc1.ShadowDecoration.Parent = this.cboc1;
            this.cboc1.Size = new System.Drawing.Size(233, 36);
            this.cboc1.TabIndex = 131;
            this.cboc1.SelectedIndexChanged += new System.EventHandler(this.cboc1_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chart1.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chart1.BorderSkin.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart1.BorderSkin.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            chartArea8.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            chartArea8.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            legend8.BackImageTransparentColor = System.Drawing.Color.White;
            legend8.BackSecondaryColor = System.Drawing.Color.White;
            legend8.BorderColor = System.Drawing.Color.White;
            legend8.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend8.ForeColor = System.Drawing.Color.White;
            legend8.HeaderSeparatorColor = System.Drawing.Color.White;
            legend8.InterlacedRowsColor = System.Drawing.Color.White;
            legend8.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend8.Name = "Legend1";
            legend8.ShadowColor = System.Drawing.Color.White;
            legend8.TitleBackColor = System.Drawing.Color.White;
            legend8.TitleForeColor = System.Drawing.Color.White;
            legend8.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(918, 105);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series8.BackImageTransparentColor = System.Drawing.Color.White;
            series8.BackSecondaryColor = System.Drawing.Color.White;
            series8.BorderColor = System.Drawing.Color.Transparent;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series8.Color = System.Drawing.Color.DodgerBlue;
            series8.LabelForeColor = System.Drawing.Color.White;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            series8.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series8.ShadowColor = System.Drawing.Color.White;
            series8.YValuesPerPoint = 2;
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(497, 314);
            this.chart1.TabIndex = 130;
            this.chart1.Text = "chart1";
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chart3.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart3.BackSecondaryColor = System.Drawing.Color.White;
            this.chart3.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chart3.BorderSkin.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart3.BorderSkin.BackSecondaryColor = System.Drawing.Color.White;
            this.chart3.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            chartArea9.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            chartArea9.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            chartArea9.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea9);
            legend9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            legend9.BackImageTransparentColor = System.Drawing.Color.White;
            legend9.BackSecondaryColor = System.Drawing.Color.White;
            legend9.BorderColor = System.Drawing.Color.White;
            legend9.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend9.ForeColor = System.Drawing.Color.White;
            legend9.HeaderSeparatorColor = System.Drawing.Color.White;
            legend9.InterlacedRowsColor = System.Drawing.Color.White;
            legend9.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend9.Name = "Legend1";
            legend9.ShadowColor = System.Drawing.Color.White;
            legend9.TitleBackColor = System.Drawing.Color.White;
            legend9.TitleForeColor = System.Drawing.Color.White;
            legend9.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart3.Legends.Add(legend9);
            this.chart3.Location = new System.Drawing.Point(1437, 243);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series9.BackImageTransparentColor = System.Drawing.Color.White;
            series9.BackSecondaryColor = System.Drawing.Color.White;
            series9.BorderColor = System.Drawing.Color.Transparent;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.Color = System.Drawing.Color.DodgerBlue;
            series9.LabelForeColor = System.Drawing.Color.White;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            series9.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series9.ShadowColor = System.Drawing.Color.White;
            series9.YValuesPerPoint = 2;
            this.chart3.Series.Add(series9);
            this.chart3.Size = new System.Drawing.Size(429, 314);
            this.chart3.TabIndex = 136;
            this.chart3.Text = "chart3";
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel3.Location = new System.Drawing.Point(1421, 207);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(238, 27);
            this.siticoneLabel3.TabIndex = 137;
            this.siticoneLabel3.Text = "Productos Mas Vendidos:";
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1888, 852);
            this.Controls.Add(this.siticoneLabel3);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.siticoneLabel2);
            this.Controls.Add(this.cboc2);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.cboc1);
            this.Controls.Add(this.chart1);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Name = "frmReporteVentas";
            this.Text = "frmReporteVentas";
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvdata;
        private Siticone.UI.WinForms.SiticoneRoundedComboBox cbobusqueda;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnExcel;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnLimparBusqueda;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnBusqueda;
        private Siticone.UI.WinForms.SiticoneRoundedDateTimePicker txtfechainicio;
        private Siticone.UI.WinForms.SiticoneRoundedDateTimePicker txtfechafin;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtbusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnBuscar;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private Siticone.UI.WinForms.SiticoneRoundedComboBox cboc2;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticoneRoundedComboBox cboc1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel3;
    }
}