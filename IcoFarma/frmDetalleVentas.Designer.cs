namespace IcoFarma
{
    partial class frmDetalleVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleVentas));
            this.btnLimpiar = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.btnBuscar = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.txtbusqueda = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.txtusuario = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.txttipodocumento = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.txtfecha = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombrecliente = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.txtdoccliente = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.txtnumerodocumento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnboleta = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmontototal = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmontopago = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmontocambio = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.txt_precioxu = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.siticoneGroupBox1 = new Siticone.UI.WinForms.SiticoneGroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.siticoneGroupBox2 = new Siticone.UI.WinForms.SiticoneGroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvdata = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siticoneGroupBox1.SuspendLayout();
            this.siticoneGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnLimpiar.CheckedState.Parent = this.btnLimpiar;
            this.btnLimpiar.CustomImages.Parent = this.btnLimpiar;
            this.btnLimpiar.FillColor = System.Drawing.Color.Firebrick;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.HoveredState.Parent = this.btnLimpiar;
            this.btnLimpiar.Image = global::IcoFarma.Properties.Resources.Broom;
            this.btnLimpiar.Location = new System.Drawing.Point(1069, 27);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.ShadowDecoration.Parent = this.btnLimpiar;
            this.btnLimpiar.Size = new System.Drawing.Size(57, 44);
            this.btnLimpiar.TabIndex = 142;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnBuscar.CheckedState.Parent = this.btnBuscar;
            this.btnBuscar.CustomImages.Parent = this.btnBuscar;
            this.btnBuscar.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.HoveredState.Parent = this.btnBuscar;
            this.btnBuscar.Image = global::IcoFarma.Properties.Resources.Search;
            this.btnBuscar.Location = new System.Drawing.Point(1004, 27);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ShadowDecoration.Parent = this.btnBuscar;
            this.btnBuscar.Size = new System.Drawing.Size(57, 44);
            this.btnBuscar.TabIndex = 141;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
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
            this.txtbusqueda.Location = new System.Drawing.Point(863, 27);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.PasswordChar = '\0';
            this.txtbusqueda.PlaceholderText = "Busca Aqui";
            this.txtbusqueda.SelectedText = "";
            this.txtbusqueda.ShadowDecoration.Parent = this.txtbusqueda;
            this.txtbusqueda.Size = new System.Drawing.Size(133, 44);
            this.txtbusqueda.TabIndex = 140;
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtusuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtusuario.BorderThickness = 2;
            this.txtusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusuario.DefaultText = "";
            this.txtusuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtusuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtusuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusuario.DisabledState.Parent = this.txtusuario;
            this.txtusuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtusuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusuario.FocusedState.Parent = this.txtusuario;
            this.txtusuario.ForeColor = System.Drawing.Color.White;
            this.txtusuario.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusuario.HoveredState.Parent = this.txtusuario;
            this.txtusuario.Location = new System.Drawing.Point(412, 55);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.PlaceholderText = "";
            this.txtusuario.SelectedText = "";
            this.txtusuario.ShadowDecoration.Parent = this.txtusuario;
            this.txtusuario.Size = new System.Drawing.Size(296, 44);
            this.txtusuario.TabIndex = 176;
            // 
            // txttipodocumento
            // 
            this.txttipodocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txttipodocumento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txttipodocumento.BorderThickness = 2;
            this.txttipodocumento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttipodocumento.DefaultText = "";
            this.txttipodocumento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttipodocumento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttipodocumento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttipodocumento.DisabledState.Parent = this.txttipodocumento;
            this.txttipodocumento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttipodocumento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txttipodocumento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttipodocumento.FocusedState.Parent = this.txttipodocumento;
            this.txttipodocumento.ForeColor = System.Drawing.Color.White;
            this.txttipodocumento.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttipodocumento.HoveredState.Parent = this.txttipodocumento;
            this.txttipodocumento.Location = new System.Drawing.Point(201, 54);
            this.txttipodocumento.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txttipodocumento.Name = "txttipodocumento";
            this.txttipodocumento.PasswordChar = '\0';
            this.txttipodocumento.PlaceholderText = "";
            this.txttipodocumento.SelectedText = "";
            this.txttipodocumento.ShadowDecoration.Parent = this.txttipodocumento;
            this.txttipodocumento.Size = new System.Drawing.Size(175, 46);
            this.txttipodocumento.TabIndex = 175;
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtfecha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtfecha.BorderThickness = 2;
            this.txtfecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfecha.DefaultText = "";
            this.txtfecha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfecha.DisabledState.Parent = this.txtfecha;
            this.txtfecha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtfecha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfecha.FocusedState.Parent = this.txtfecha;
            this.txtfecha.ForeColor = System.Drawing.Color.White;
            this.txtfecha.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfecha.HoveredState.Parent = this.txtfecha;
            this.txtfecha.Location = new System.Drawing.Point(9, 55);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.PasswordChar = '\0';
            this.txtfecha.PlaceholderText = "";
            this.txtfecha.SelectedText = "";
            this.txtfecha.ShadowDecoration.Parent = this.txtfecha;
            this.txtfecha.Size = new System.Drawing.Size(176, 46);
            this.txtfecha.TabIndex = 174;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(636, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 138;
            this.label2.Text = "Nro Documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(56, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 137;
            this.label1.Text = "Detalle Venta:";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtnombrecliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtnombrecliente.BorderThickness = 2;
            this.txtnombrecliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombrecliente.DefaultText = "";
            this.txtnombrecliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnombrecliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnombrecliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombrecliente.DisabledState.Parent = this.txtnombrecliente;
            this.txtnombrecliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombrecliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtnombrecliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombrecliente.FocusedState.Parent = this.txtnombrecliente;
            this.txtnombrecliente.ForeColor = System.Drawing.Color.White;
            this.txtnombrecliente.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombrecliente.HoveredState.Parent = this.txtnombrecliente;
            this.txtnombrecliente.Location = new System.Drawing.Point(233, 54);
            this.txtnombrecliente.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.PasswordChar = '\0';
            this.txtnombrecliente.PlaceholderText = "";
            this.txtnombrecliente.SelectedText = "";
            this.txtnombrecliente.ShadowDecoration.Parent = this.txtnombrecliente;
            this.txtnombrecliente.Size = new System.Drawing.Size(224, 43);
            this.txtnombrecliente.TabIndex = 178;
            // 
            // txtdoccliente
            // 
            this.txtdoccliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtdoccliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtdoccliente.BorderThickness = 2;
            this.txtdoccliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdoccliente.DefaultText = "";
            this.txtdoccliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdoccliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdoccliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdoccliente.DisabledState.Parent = this.txtdoccliente;
            this.txtdoccliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdoccliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtdoccliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdoccliente.FocusedState.Parent = this.txtdoccliente;
            this.txtdoccliente.ForeColor = System.Drawing.Color.White;
            this.txtdoccliente.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdoccliente.HoveredState.Parent = this.txtdoccliente;
            this.txtdoccliente.Location = new System.Drawing.Point(17, 54);
            this.txtdoccliente.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtdoccliente.Name = "txtdoccliente";
            this.txtdoccliente.PasswordChar = '\0';
            this.txtdoccliente.PlaceholderText = "";
            this.txtdoccliente.SelectedText = "";
            this.txtdoccliente.ShadowDecoration.Parent = this.txtdoccliente;
            this.txtdoccliente.Size = new System.Drawing.Size(176, 44);
            this.txtdoccliente.TabIndex = 177;
            // 
            // txtnumerodocumento
            // 
            this.txtnumerodocumento.Location = new System.Drawing.Point(979, 54);
            this.txtnumerodocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnumerodocumento.Name = "txtnumerodocumento";
            this.txtnumerodocumento.Size = new System.Drawing.Size(79, 27);
            this.txtnumerodocumento.TabIndex = 4;
            this.txtnumerodocumento.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nombre Cliente:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Documento:";
            // 
            // btnboleta
            // 
            this.btnboleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnboleta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.btnboleta.BorderThickness = 2;
            this.btnboleta.CheckedState.Parent = this.btnboleta;
            this.btnboleta.CustomImages.Parent = this.btnboleta;
            this.btnboleta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnboleta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnboleta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnboleta.HoveredState.Parent = this.btnboleta;
            this.btnboleta.Image = global::IcoFarma.Properties.Resources.PDF;
            this.btnboleta.Location = new System.Drawing.Point(900, 725);
            this.btnboleta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnboleta.Name = "btnboleta";
            this.btnboleta.ShadowDecoration.Parent = this.btnboleta;
            this.btnboleta.Size = new System.Drawing.Size(227, 44);
            this.btnboleta.TabIndex = 181;
            this.btnboleta.Text = "Imprimir";
            this.btnboleta.Click += new System.EventHandler(this.btnboleta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(25, 750);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 183;
            this.label7.Text = "Monto Total:";
            // 
            // txtmontototal
            // 
            this.txtmontototal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtmontototal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtmontototal.BorderThickness = 2;
            this.txtmontototal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmontototal.DefaultText = "";
            this.txtmontototal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmontototal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmontototal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmontototal.DisabledState.Parent = this.txtmontototal;
            this.txtmontototal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmontototal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtmontototal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmontototal.FocusedState.Parent = this.txtmontototal;
            this.txtmontototal.ForeColor = System.Drawing.Color.White;
            this.txtmontototal.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmontototal.HoveredState.Parent = this.txtmontototal;
            this.txtmontototal.Location = new System.Drawing.Point(141, 736);
            this.txtmontototal.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtmontototal.Name = "txtmontototal";
            this.txtmontototal.PasswordChar = '\0';
            this.txtmontototal.PlaceholderText = "0";
            this.txtmontototal.SelectedText = "";
            this.txtmontototal.ShadowDecoration.Parent = this.txtmontototal;
            this.txtmontototal.Size = new System.Drawing.Size(113, 42);
            this.txtmontototal.TabIndex = 177;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(265, 750);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 184;
            this.label6.Text = "Paga con:";
            // 
            // txtmontopago
            // 
            this.txtmontopago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtmontopago.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtmontopago.BorderThickness = 2;
            this.txtmontopago.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmontopago.DefaultText = "";
            this.txtmontopago.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmontopago.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmontopago.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmontopago.DisabledState.Parent = this.txtmontopago;
            this.txtmontopago.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmontopago.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtmontopago.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmontopago.FocusedState.Parent = this.txtmontopago;
            this.txtmontopago.ForeColor = System.Drawing.Color.White;
            this.txtmontopago.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmontopago.HoveredState.Parent = this.txtmontopago;
            this.txtmontopago.Location = new System.Drawing.Point(367, 736);
            this.txtmontopago.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtmontopago.Name = "txtmontopago";
            this.txtmontopago.PasswordChar = '\0';
            this.txtmontopago.PlaceholderText = "0";
            this.txtmontopago.SelectedText = "";
            this.txtmontopago.ShadowDecoration.Parent = this.txtmontopago;
            this.txtmontopago.Size = new System.Drawing.Size(113, 42);
            this.txtmontopago.TabIndex = 185;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(485, 750);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 186;
            this.label8.Text = "Cambio:";
            // 
            // txtmontocambio
            // 
            this.txtmontocambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtmontocambio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtmontocambio.BorderThickness = 2;
            this.txtmontocambio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmontocambio.DefaultText = "";
            this.txtmontocambio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmontocambio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmontocambio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmontocambio.DisabledState.Parent = this.txtmontocambio;
            this.txtmontocambio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmontocambio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtmontocambio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmontocambio.FocusedState.Parent = this.txtmontocambio;
            this.txtmontocambio.ForeColor = System.Drawing.Color.White;
            this.txtmontocambio.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmontocambio.HoveredState.Parent = this.txtmontocambio;
            this.txtmontocambio.Location = new System.Drawing.Point(572, 736);
            this.txtmontocambio.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtmontocambio.Name = "txtmontocambio";
            this.txtmontocambio.PasswordChar = '\0';
            this.txtmontocambio.PlaceholderText = "0";
            this.txtmontocambio.SelectedText = "";
            this.txtmontocambio.ShadowDecoration.Parent = this.txtmontocambio;
            this.txtmontocambio.Size = new System.Drawing.Size(113, 42);
            this.txtmontocambio.TabIndex = 187;
            // 
            // txt_precioxu
            // 
            this.txt_precioxu.Location = new System.Drawing.Point(1152, 117);
            this.txt_precioxu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_precioxu.Name = "txt_precioxu";
            this.txt_precioxu.Size = new System.Drawing.Size(132, 22);
            this.txt_precioxu.TabIndex = 188;
            this.txt_precioxu.Visible = false;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(1293, 85);
            this.txt_subtotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(132, 22);
            this.txt_subtotal.TabIndex = 189;
            this.txt_subtotal.Visible = false;
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(1152, 85);
            this.txt_producto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(132, 22);
            this.txt_producto.TabIndex = 190;
            this.txt_producto.Visible = false;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(1293, 117);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(132, 22);
            this.txt_cantidad.TabIndex = 191;
            this.txt_cantidad.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(264, 770);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 25);
            this.label11.TabIndex = 193;
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.siticoneGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.siticoneGroupBox1.BorderRadius = 2;
            this.siticoneGroupBox1.Controls.Add(this.label12);
            this.siticoneGroupBox1.Controls.Add(this.txtusuario);
            this.siticoneGroupBox1.Controls.Add(this.label5);
            this.siticoneGroupBox1.Controls.Add(this.txtfecha);
            this.siticoneGroupBox1.Controls.Add(this.txttipodocumento);
            this.siticoneGroupBox1.Controls.Add(this.label3);
            this.siticoneGroupBox1.Controls.Add(this.label4);
            this.siticoneGroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.siticoneGroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.siticoneGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.White;
            this.siticoneGroupBox1.Location = new System.Drawing.Point(57, 87);
            this.siticoneGroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.ShadowDecoration.Parent = this.siticoneGroupBox1;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(1073, 110);
            this.siticoneGroupBox1.TabIndex = 194;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(13, 4);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 20);
            this.label12.TabIndex = 195;
            this.label12.Text = "Informacion Venta:";
            // 
            // siticoneGroupBox2
            // 
            this.siticoneGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.siticoneGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.siticoneGroupBox2.BorderRadius = 2;
            this.siticoneGroupBox2.Controls.Add(this.txtnumerodocumento);
            this.siticoneGroupBox2.Controls.Add(this.txtnombrecliente);
            this.siticoneGroupBox2.Controls.Add(this.label13);
            this.siticoneGroupBox2.Controls.Add(this.txtdoccliente);
            this.siticoneGroupBox2.Controls.Add(this.label9);
            this.siticoneGroupBox2.Controls.Add(this.label10);
            this.siticoneGroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.siticoneGroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.siticoneGroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.siticoneGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox2.ForeColor = System.Drawing.Color.White;
            this.siticoneGroupBox2.Location = new System.Drawing.Point(59, 209);
            this.siticoneGroupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneGroupBox2.Name = "siticoneGroupBox2";
            this.siticoneGroupBox2.ShadowDecoration.Parent = this.siticoneGroupBox2;
            this.siticoneGroupBox2.Size = new System.Drawing.Size(1073, 110);
            this.siticoneGroupBox2.TabIndex = 196;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(13, 4);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 20);
            this.label13.TabIndex = 195;
            this.label13.Text = "Informacion Cliente:";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.ColumnHeadersHeight = 50;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.DoubleBuffered = true;
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgvdata.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.dgvdata.HeaderForeColor = System.Drawing.Color.White;
            this.dgvdata.Location = new System.Drawing.Point(63, 326);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvdata.RowHeadersVisible = false;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdata.RowTemplate.DividerHeight = 1;
            this.dgvdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.Size = new System.Drawing.Size(1069, 391);
            this.dgvdata.TabIndex = 197;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick_1);
            // 
            // Producto
            // 
            this.Producto.FillWeight = 83.89366F;
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 200;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 200;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 200;
            // 
            // frmDetalleVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1531, 795);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.siticoneGroupBox2);
            this.Controls.Add(this.siticoneGroupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.txt_precioxu);
            this.Controls.Add(this.txtmontocambio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmontopago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmontototal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnboleta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDetalleVentas";
            this.Text = "frmDetalleVentas";
            this.Load += new System.EventHandler(this.frmDetalleVentas_Load);
            this.siticoneGroupBox1.ResumeLayout(false);
            this.siticoneGroupBox1.PerformLayout();
            this.siticoneGroupBox2.ResumeLayout(false);
            this.siticoneGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneRoundedButton btnLimpiar;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnBuscar;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtbusqueda;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtusuario;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txttipodocumento;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtfecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtnombrecliente;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtdoccliente;
        private System.Windows.Forms.TextBox txtnumerodocumento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnboleta;
        private System.Windows.Forms.Label label7;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtmontototal;
        private System.Windows.Forms.Label label6;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtmontopago;
        private System.Windows.Forms.Label label8;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtmontocambio;
        private System.Windows.Forms.TextBox txt_precioxu;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label11;
        private Siticone.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
        private System.Windows.Forms.Label label12;
        private Siticone.UI.WinForms.SiticoneGroupBox siticoneGroupBox2;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}