﻿namespace CapaPresentacion.Formularios
{
    partial class CrudClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudClientes));
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.CodigoSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbClientes = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlCrud = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDepto = new System.Windows.Forms.TextBox();
            this.lblocalidad = new System.Windows.Forms.Label();
            this.cboloclaidad = new System.Windows.Forms.ComboBox();
            this.lbpiso = new System.Windows.Forms.Label();
            this.lbAltura = new System.Windows.Forms.Label();
            this.nupPiso = new System.Windows.Forms.NumericUpDown();
            this.nupaltura = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.texboxnumero = new System.Windows.Forms.TextBox();
            this.TxbTelefono = new System.Windows.Forms.Label();
            this.TxbDireccion = new System.Windows.Forms.Label();
            this.TxbDirec = new System.Windows.Forms.TextBox();
            this.lbtipocliente = new System.Windows.Forms.Label();
            this.CboTipoCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbCodCliente = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.TxbApellido = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lbdni = new System.Windows.Forms.Label();
            this.TxbDni = new System.Windows.Forms.TextBox();
            this.picLimpiar = new System.Windows.Forms.PictureBox();
            this.picbajar = new System.Windows.Forms.PictureBox();
            this.rbtTodos = new System.Windows.Forms.RadioButton();
            this.RbtNoSocios = new System.Windows.Forms.RadioButton();
            this.RbtSocios = new System.Windows.Forms.RadioButton();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RbtNombre = new System.Windows.Forms.RadioButton();
            this.RbtDni = new System.Windows.Forms.RadioButton();
            this.picreset = new System.Windows.Forms.PictureBox();
            this.btnLocalidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupaltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbajar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvCliente.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoSocio,
            this.dni,
            this.NombreCompleto,
            this.Fecha,
            this.Cale,
            this.Altura,
            this.Departamento,
            this.Piso,
            this.Telefono,
            this.Activo,
            this.Acciones});
            this.dgvCliente.Location = new System.Drawing.Point(10, 150);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCliente.RowTemplate.Height = 25;
            this.dgvCliente.Size = new System.Drawing.Size(977, 352);
            this.dgvCliente.TabIndex = 25;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_Acciones);
            // 
            // CodigoSocio
            // 
            this.CodigoSocio.Frozen = true;
            this.CodigoSocio.HeaderText = "Codigo Cliente";
            this.CodigoSocio.Name = "CodigoSocio";
            this.CodigoSocio.ReadOnly = true;
            this.CodigoSocio.Width = 80;
            // 
            // dni
            // 
            this.dni.Frozen = true;
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dni.Width = 80;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.Frozen = true;
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 140;
            // 
            // Fecha
            // 
            this.Fecha.Frozen = true;
            this.Fecha.HeaderText = "Fecha Adhesion";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Cale
            // 
            this.Cale.HeaderText = "Direccion";
            this.Cale.Name = "Cale";
            this.Cale.ReadOnly = true;
            this.Cale.Width = 130;
            // 
            // Altura
            // 
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            this.Altura.ReadOnly = true;
            this.Altura.Width = 60;
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // Piso
            // 
            this.Piso.HeaderText = "Piso";
            this.Piso.Name = "Piso";
            this.Piso.ReadOnly = true;
            this.Piso.Width = 50;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Socio";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 50;
            // 
            // Acciones
            // 
            this.Acciones.HeaderText = "Acciones";
            this.Acciones.Name = "Acciones";
            this.Acciones.ReadOnly = true;
            this.Acciones.Text = "Detalle";
            this.Acciones.UseColumnTextForButtonValue = true;
            this.Acciones.Width = 84;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.lbClientes);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(206, 56);
            this.pnlHeader.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.cliente64;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lbClientes
            // 
            this.lbClientes.AutoSize = true;
            this.lbClientes.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbClientes.Location = new System.Drawing.Point(60, 9);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(141, 38);
            this.lbClientes.TabIndex = 21;
            this.lbClientes.Text = "Clientes";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(139, 529);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(139, 42);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pnlCrud
            // 
            this.pnlCrud.BackColor = System.Drawing.Color.OliveDrab;
            this.pnlCrud.Controls.Add(this.label2);
            this.pnlCrud.Controls.Add(this.txbDepto);
            this.pnlCrud.Controls.Add(this.lblocalidad);
            this.pnlCrud.Controls.Add(this.cboloclaidad);
            this.pnlCrud.Controls.Add(this.lbpiso);
            this.pnlCrud.Controls.Add(this.lbAltura);
            this.pnlCrud.Controls.Add(this.nupPiso);
            this.pnlCrud.Controls.Add(this.nupaltura);
            this.pnlCrud.Controls.Add(this.pictureBox2);
            this.pnlCrud.Controls.Add(this.texboxnumero);
            this.pnlCrud.Controls.Add(this.TxbTelefono);
            this.pnlCrud.Controls.Add(this.TxbDireccion);
            this.pnlCrud.Controls.Add(this.TxbDirec);
            this.pnlCrud.Controls.Add(this.lbtipocliente);
            this.pnlCrud.Controls.Add(this.CboTipoCliente);
            this.pnlCrud.Controls.Add(this.label1);
            this.pnlCrud.Controls.Add(this.TxbCodCliente);
            this.pnlCrud.Controls.Add(this.lbEmail);
            this.pnlCrud.Controls.Add(this.TxbEmail);
            this.pnlCrud.Controls.Add(this.lbApellido);
            this.pnlCrud.Controls.Add(this.TxbApellido);
            this.pnlCrud.Controls.Add(this.lbNombre);
            this.pnlCrud.Controls.Add(this.txbNombre);
            this.pnlCrud.Controls.Add(this.lbdni);
            this.pnlCrud.Controls.Add(this.TxbDni);
            this.pnlCrud.Controls.Add(this.picLimpiar);
            this.pnlCrud.Controls.Add(this.picbajar);
            this.pnlCrud.Location = new System.Drawing.Point(10, 106);
            this.pnlCrud.Name = "pnlCrud";
            this.pnlCrud.Size = new System.Drawing.Size(980, 396);
            this.pnlCrud.TabIndex = 29;
            this.pnlCrud.Visible = false;
            this.pnlCrud.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCrud_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(457, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "Departamento";
            // 
            // txbDepto
            // 
            this.txbDepto.Location = new System.Drawing.Point(457, 161);
            this.txbDepto.Name = "txbDepto";
            this.txbDepto.Size = new System.Drawing.Size(122, 23);
            this.txbDepto.TabIndex = 56;
            // 
            // lblocalidad
            // 
            this.lblocalidad.AutoSize = true;
            this.lblocalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblocalidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblocalidad.Location = new System.Drawing.Point(458, 31);
            this.lblocalidad.Name = "lblocalidad";
            this.lblocalidad.Size = new System.Drawing.Size(88, 19);
            this.lblocalidad.TabIndex = 55;
            this.lblocalidad.Text = "Localidad";
            // 
            // cboloclaidad
            // 
            this.cboloclaidad.FormattingEnabled = true;
            this.cboloclaidad.Location = new System.Drawing.Point(457, 64);
            this.cboloclaidad.Name = "cboloclaidad";
            this.cboloclaidad.Size = new System.Drawing.Size(174, 23);
            this.cboloclaidad.TabIndex = 54;
            // 
            // lbpiso
            // 
            this.lbpiso.AutoSize = true;
            this.lbpiso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbpiso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbpiso.Location = new System.Drawing.Point(374, 139);
            this.lbpiso.Name = "lbpiso";
            this.lbpiso.Size = new System.Drawing.Size(38, 19);
            this.lbpiso.TabIndex = 53;
            this.lbpiso.Text = "Piso";
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAltura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAltura.Location = new System.Drawing.Point(258, 140);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(55, 19);
            this.lbAltura.TabIndex = 52;
            this.lbAltura.Text = "Altura";
            // 
            // nupPiso
            // 
            this.nupPiso.Location = new System.Drawing.Point(374, 161);
            this.nupPiso.Name = "nupPiso";
            this.nupPiso.Size = new System.Drawing.Size(61, 23);
            this.nupPiso.TabIndex = 50;
            // 
            // nupaltura
            // 
            this.nupaltura.Location = new System.Drawing.Point(262, 161);
            this.nupaltura.Name = "nupaltura";
            this.nupaltura.Size = new System.Drawing.Size(61, 23);
            this.nupaltura.TabIndex = 49;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.pizza_truck;
            this.pictureBox2.Location = new System.Drawing.Point(608, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(366, 308);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // texboxnumero
            // 
            this.texboxnumero.Location = new System.Drawing.Point(261, 250);
            this.texboxnumero.Name = "texboxnumero";
            this.texboxnumero.Size = new System.Drawing.Size(175, 23);
            this.texboxnumero.TabIndex = 3;
            // 
            // TxbTelefono
            // 
            this.TxbTelefono.AutoSize = true;
            this.TxbTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxbTelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxbTelefono.Location = new System.Drawing.Point(262, 219);
            this.TxbTelefono.Name = "TxbTelefono";
            this.TxbTelefono.Size = new System.Drawing.Size(74, 19);
            this.TxbTelefono.TabIndex = 47;
            this.TxbTelefono.Text = "Telefono";
            // 
            // TxbDireccion
            // 
            this.TxbDireccion.AutoSize = true;
            this.TxbDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxbDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxbDireccion.Location = new System.Drawing.Point(33, 130);
            this.TxbDireccion.Name = "TxbDireccion";
            this.TxbDireccion.Size = new System.Drawing.Size(50, 19);
            this.TxbDireccion.TabIndex = 45;
            this.TxbDireccion.Text = "Calle";
            // 
            // TxbDirec
            // 
            this.TxbDirec.Location = new System.Drawing.Point(33, 161);
            this.TxbDirec.Name = "TxbDirec";
            this.TxbDirec.Size = new System.Drawing.Size(174, 23);
            this.TxbDirec.TabIndex = 2;
            // 
            // lbtipocliente
            // 
            this.lbtipocliente.AutoSize = true;
            this.lbtipocliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbtipocliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbtipocliente.Location = new System.Drawing.Point(34, 217);
            this.lbtipocliente.Name = "lbtipocliente";
            this.lbtipocliente.Size = new System.Drawing.Size(124, 19);
            this.lbtipocliente.TabIndex = 43;
            this.lbtipocliente.Text = "Tipo de Cliente";
            this.lbtipocliente.Click += new System.EventHandler(this.label5_Click);
            // 
            // CboTipoCliente
            // 
            this.CboTipoCliente.FormattingEnabled = true;
            this.CboTipoCliente.Location = new System.Drawing.Point(33, 250);
            this.CboTipoCliente.Name = "CboTipoCliente";
            this.CboTipoCliente.Size = new System.Drawing.Size(174, 23);
            this.CboTipoCliente.TabIndex = 4;
            this.CboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.CboTipoCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(848, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Codigo Cliente";
            this.label1.Visible = false;
            // 
            // TxbCodCliente
            // 
            this.TxbCodCliente.Enabled = false;
            this.TxbCodCliente.Location = new System.Drawing.Point(869, 85);
            this.TxbCodCliente.Name = "TxbCodCliente";
            this.TxbCodCliente.Size = new System.Drawing.Size(82, 23);
            this.TxbCodCliente.TabIndex = 40;
            this.TxbCodCliente.Visible = false;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEmail.Location = new System.Drawing.Point(261, 290);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 19);
            this.lbEmail.TabIndex = 39;
            this.lbEmail.Text = "Email";
            this.lbEmail.Visible = false;
            // 
            // TxbEmail
            // 
            this.TxbEmail.Location = new System.Drawing.Point(261, 321);
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(174, 23);
            this.TxbEmail.TabIndex = 6;
            this.TxbEmail.Visible = false;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbApellido.Location = new System.Drawing.Point(261, 33);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(75, 19);
            this.lbApellido.TabIndex = 37;
            this.lbApellido.Text = "Apellido";
            // 
            // TxbApellido
            // 
            this.TxbApellido.Location = new System.Drawing.Point(261, 64);
            this.TxbApellido.Name = "TxbApellido";
            this.TxbApellido.Size = new System.Drawing.Size(174, 23);
            this.TxbApellido.TabIndex = 1;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNombre.Location = new System.Drawing.Point(33, 33);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(73, 19);
            this.lbNombre.TabIndex = 35;
            this.lbNombre.Text = "Nombre";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(33, 64);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(174, 23);
            this.txbNombre.TabIndex = 0;
            // 
            // lbdni
            // 
            this.lbdni.AutoSize = true;
            this.lbdni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbdni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbdni.Location = new System.Drawing.Point(33, 290);
            this.lbdni.Name = "lbdni";
            this.lbdni.Size = new System.Drawing.Size(36, 19);
            this.lbdni.TabIndex = 32;
            this.lbdni.Text = "DNI";
            this.lbdni.Visible = false;
            // 
            // TxbDni
            // 
            this.TxbDni.Location = new System.Drawing.Point(33, 321);
            this.TxbDni.Name = "TxbDni";
            this.TxbDni.Size = new System.Drawing.Size(174, 23);
            this.TxbDni.TabIndex = 5;
            this.TxbDni.Visible = false;
            // 
            // picLimpiar
            // 
            this.picLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLimpiar.Image = global::CapaPresentacion.Properties.Resources.limpieza_de_datos;
            this.picLimpiar.Location = new System.Drawing.Point(862, 2);
            this.picLimpiar.Name = "picLimpiar";
            this.picLimpiar.Size = new System.Drawing.Size(47, 43);
            this.picLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLimpiar.TabIndex = 20;
            this.picLimpiar.TabStop = false;
            this.picLimpiar.Click += new System.EventHandler(this.picLimpar_Click);
            // 
            // picbajar
            // 
            this.picbajar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbajar.Image = global::CapaPresentacion.Properties.Resources.abajo1;
            this.picbajar.Location = new System.Drawing.Point(927, 2);
            this.picbajar.Name = "picbajar";
            this.picbajar.Size = new System.Drawing.Size(47, 43);
            this.picbajar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbajar.TabIndex = 19;
            this.picbajar.TabStop = false;
            this.picbajar.Click += new System.EventHandler(this.picbajar_Click);
            // 
            // rbtTodos
            // 
            this.rbtTodos.AutoSize = true;
            this.rbtTodos.Checked = true;
            this.rbtTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtTodos.Location = new System.Drawing.Point(691, 114);
            this.rbtTodos.Name = "rbtTodos";
            this.rbtTodos.Size = new System.Drawing.Size(73, 25);
            this.rbtTodos.TabIndex = 36;
            this.rbtTodos.TabStop = true;
            this.rbtTodos.Text = "Todos";
            this.rbtTodos.UseVisualStyleBackColor = true;
            this.rbtTodos.CheckedChanged += new System.EventHandler(this.rbtTodos_CheckedChanged);
            // 
            // RbtNoSocios
            // 
            this.RbtNoSocios.AutoSize = true;
            this.RbtNoSocios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtNoSocios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtNoSocios.Location = new System.Drawing.Point(873, 114);
            this.RbtNoSocios.Name = "RbtNoSocios";
            this.RbtNoSocios.Size = new System.Drawing.Size(101, 25);
            this.RbtNoSocios.TabIndex = 35;
            this.RbtNoSocios.Text = "No Socios";
            this.RbtNoSocios.UseVisualStyleBackColor = true;
            this.RbtNoSocios.CheckedChanged += new System.EventHandler(this.RbtNoSocios_CheckedChanged);
            // 
            // RbtSocios
            // 
            this.RbtSocios.AutoSize = true;
            this.RbtSocios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtSocios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtSocios.Location = new System.Drawing.Point(779, 114);
            this.RbtSocios.Name = "RbtSocios";
            this.RbtSocios.Size = new System.Drawing.Size(75, 25);
            this.RbtSocios.TabIndex = 34;
            this.RbtSocios.Text = "Socios";
            this.RbtSocios.UseVisualStyleBackColor = true;
            this.RbtSocios.CheckedChanged += new System.EventHandler(this.RbtSocios_CheckedChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(365, 113);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(71, 23);
            this.BtnBuscar.TabIndex = 39;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Location = new System.Drawing.Point(217, 114);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(142, 23);
            this.txbBusqueda.TabIndex = 37;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.Enabled = false;
            this.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(337, 529);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(139, 42);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Enabled = false;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(542, 529);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(139, 42);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(740, 529);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(139, 42);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RbtNombre);
            this.panel1.Controls.Add(this.RbtDni);
            this.panel1.Location = new System.Drawing.Point(20, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 31);
            this.panel1.TabIndex = 43;
            // 
            // RbtNombre
            // 
            this.RbtNombre.AutoSize = true;
            this.RbtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtNombre.Location = new System.Drawing.Point(87, 3);
            this.RbtNombre.Name = "RbtNombre";
            this.RbtNombre.Size = new System.Drawing.Size(91, 25);
            this.RbtNombre.TabIndex = 37;
            this.RbtNombre.Text = "Nombre";
            this.RbtNombre.UseVisualStyleBackColor = true;
            // 
            // RbtDni
            // 
            this.RbtDni.AutoSize = true;
            this.RbtDni.Checked = true;
            this.RbtDni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtDni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtDni.Location = new System.Drawing.Point(8, 3);
            this.RbtDni.Name = "RbtDni";
            this.RbtDni.Size = new System.Drawing.Size(57, 25);
            this.RbtDni.TabIndex = 38;
            this.RbtDni.TabStop = true;
            this.RbtDni.Text = "DNI";
            this.RbtDni.UseVisualStyleBackColor = true;
            // 
            // picreset
            // 
            this.picreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picreset.Image = global::CapaPresentacion.Properties.Resources.reset;
            this.picreset.Location = new System.Drawing.Point(451, 106);
            this.picreset.Name = "picreset";
            this.picreset.Size = new System.Drawing.Size(38, 33);
            this.picreset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picreset.TabIndex = 52;
            this.picreset.TabStop = false;
            this.picreset.Click += new System.EventHandler(this.picreset_Click);
            // 
            // btnLocalidad
            // 
            this.btnLocalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnLocalidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalidad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLocalidad.FlatAppearance.BorderSize = 0;
            this.btnLocalidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLocalidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLocalidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalidad.Location = new System.Drawing.Point(881, 0);
            this.btnLocalidad.Name = "btnLocalidad";
            this.btnLocalidad.Size = new System.Drawing.Size(108, 28);
            this.btnLocalidad.TabIndex = 53;
            this.btnLocalidad.Text = "Localidades";
            this.btnLocalidad.UseVisualStyleBackColor = false;
            // 
            // CrudClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(998, 676);
            this.Controls.Add(this.btnLocalidad);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.pnlCrud);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.rbtTodos);
            this.Controls.Add(this.RbtNoSocios);
            this.Controls.Add(this.RbtSocios);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txbBusqueda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picreset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrudClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "w";
            this.Load += new System.EventHandler(this.CrudClubSocial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCrud.ResumeLayout(false);
            this.pnlCrud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupaltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbajar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvCliente;
        private Panel pnlHeader;
        private Label lbClientes;
        private Button btnNuevo;
        private Panel pnlCrud;
        private PictureBox picLimpiar;
        private PictureBox picbajar;
        private Label lbdni;
        private TextBox TxbDni;
        private Label label1;
        private TextBox TxbCodCliente;
        private Label lbEmail;
        private TextBox TxbEmail;
        private Label lbApellido;
        private TextBox TxbApellido;
        private Label lbNombre;
        private TextBox txbNombre;
        private RadioButton rbtTodos;
        private RadioButton RbtNoSocios;
        private RadioButton RbtSocios;
        private Button BtnBuscar;
        private TextBox txbBusqueda;
        private Button BtnEditar;
        private Button BtnCancelar;
        private Button BtnGuardar;
        private Label lbtipocliente;
        private ComboBox CboTipoCliente;
        private PictureBox pictureBox1;
        private Panel panel1;
        private RadioButton RbtDni;
        private RadioButton RbtNombre;
        private Label TxbTelefono;
        private Label TxbDireccion;
        private TextBox TxbDirec;
        private TextBox texboxnumero;
        private PictureBox pictureBox2;
        private PictureBox picreset;
        private DataGridViewTextBoxColumn CodigoSocio;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Cale;
        private DataGridViewTextBoxColumn Altura;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Piso;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Activo;
        private DataGridViewButtonColumn Acciones;
        private Button btnLocalidad;
        private Label lbpiso;
        private Label lbAltura;
        private NumericUpDown nupPiso;
        private NumericUpDown nupaltura;
        private Label lblocalidad;
        private ComboBox cboloclaidad;
        private Label label2;
        private TextBox txbDepto;
    }
}