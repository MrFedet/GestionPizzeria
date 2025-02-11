﻿namespace CapaPresentacion.Formularios.CombosProducto
{
    partial class FormUnidadMedida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUnidadMedida));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbum = new System.Windows.Forms.Label();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.dgvUnidadMedida = new System.Windows.Forms.DataGridView();
            this.CodigoTipoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbcodum = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.rbtTodos = new System.Windows.Forms.RadioButton();
            this.RbtNoActivo = new System.Windows.Forms.RadioButton();
            this.RbtActivo = new System.Windows.Forms.RadioButton();
            this.txbBusqeuda = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxbUnidadMedida = new System.Windows.Forms.TextBox();
            this.picbajar = new System.Windows.Forms.PictureBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lb = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidadMedida)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbajar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlHeader.Controls.Add(this.lbum);
            this.pnlHeader.Location = new System.Drawing.Point(0, 35);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(314, 56);
            this.pnlHeader.TabIndex = 32;
            // 
            // lbum
            // 
            this.lbum.AutoSize = true;
            this.lbum.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbum.Location = new System.Drawing.Point(9, 9);
            this.lbum.Name = "lbum";
            this.lbum.Size = new System.Drawing.Size(306, 38);
            this.lbum.TabIndex = 21;
            this.lbum.Text = "Unidad de Medida";
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.Maroon;
            this.pnlBarra.Controls.Add(this.Salir);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(688, 35);
            this.pnlBarra.TabIndex = 31;
            this.pnlBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseDown);
            // 
            // Salir
            // 
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Dock = System.Windows.Forms.DockStyle.Right;
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(653, 0);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(35, 35);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Salir.TabIndex = 0;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // dgvUnidadMedida
            // 
            this.dgvUnidadMedida.AllowUserToAddRows = false;
            this.dgvUnidadMedida.AllowUserToDeleteRows = false;
            this.dgvUnidadMedida.AllowUserToResizeColumns = false;
            this.dgvUnidadMedida.AllowUserToResizeRows = false;
            this.dgvUnidadMedida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvUnidadMedida.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnidadMedida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnidadMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidadMedida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoTipoProd,
            this.UnidadMed,
            this.Activo,
            this.Accion});
            this.dgvUnidadMedida.Location = new System.Drawing.Point(67, 211);
            this.dgvUnidadMedida.Name = "dgvUnidadMedida";
            this.dgvUnidadMedida.ReadOnly = true;
            this.dgvUnidadMedida.RowHeadersVisible = false;
            this.dgvUnidadMedida.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUnidadMedida.RowTemplate.Height = 25;
            this.dgvUnidadMedida.Size = new System.Drawing.Size(555, 292);
            this.dgvUnidadMedida.TabIndex = 54;
            this.dgvUnidadMedida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnidadMedida_CellContentClick);
            this.dgvUnidadMedida.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUnidadMedida_CellFormatting);
            // 
            // CodigoTipoProd
            // 
            this.CodigoTipoProd.HeaderText = "Codigo Unidad de Medida";
            this.CodigoTipoProd.Name = "CodigoTipoProd";
            this.CodigoTipoProd.ReadOnly = true;
            this.CodigoTipoProd.Width = 200;
            // 
            // UnidadMed
            // 
            this.UnidadMed.HeaderText = "Unidad de Medida";
            this.UnidadMed.Name = "UnidadMed";
            this.UnidadMed.ReadOnly = true;
            this.UnidadMed.Width = 152;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Accion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Accion.Text = "Detalle";
            this.Accion.UseColumnTextForButtonValue = true;
            // 
            // lbcodum
            // 
            this.lbcodum.AutoSize = true;
            this.lbcodum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbcodum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbcodum.Location = new System.Drawing.Point(65, 159);
            this.lbcodum.Name = "lbcodum";
            this.lbcodum.Size = new System.Drawing.Size(218, 19);
            this.lbcodum.TabIndex = 60;
            this.lbcodum.Text = "Codigo Unidad de Medida";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(201, 182);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(71, 23);
            this.BtnBuscar.TabIndex = 59;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // rbtTodos
            // 
            this.rbtTodos.AutoSize = true;
            this.rbtTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtTodos.Location = new System.Drawing.Point(549, 182);
            this.rbtTodos.Name = "rbtTodos";
            this.rbtTodos.Size = new System.Drawing.Size(73, 25);
            this.rbtTodos.TabIndex = 58;
            this.rbtTodos.Text = "Todos";
            this.rbtTodos.UseVisualStyleBackColor = true;
            this.rbtTodos.CheckedChanged += new System.EventHandler(this.rbtTodos_CheckedChanged);
            // 
            // RbtNoActivo
            // 
            this.RbtNoActivo.AutoSize = true;
            this.RbtNoActivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtNoActivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtNoActivo.Location = new System.Drawing.Point(436, 182);
            this.RbtNoActivo.Name = "RbtNoActivo";
            this.RbtNoActivo.Size = new System.Drawing.Size(107, 25);
            this.RbtNoActivo.TabIndex = 57;
            this.RbtNoActivo.Text = "No Activo";
            this.RbtNoActivo.UseVisualStyleBackColor = true;
            this.RbtNoActivo.CheckedChanged += new System.EventHandler(this.RbtNoActivo_CheckedChanged);
            // 
            // RbtActivo
            // 
            this.RbtActivo.AutoSize = true;
            this.RbtActivo.Checked = true;
            this.RbtActivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtActivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtActivo.Location = new System.Drawing.Point(340, 182);
            this.RbtActivo.Name = "RbtActivo";
            this.RbtActivo.Size = new System.Drawing.Size(81, 25);
            this.RbtActivo.TabIndex = 56;
            this.RbtActivo.TabStop = true;
            this.RbtActivo.Text = "Activo";
            this.RbtActivo.UseVisualStyleBackColor = true;
            this.RbtActivo.CheckedChanged += new System.EventHandler(this.RbtActivo_CheckedChanged);
            // 
            // txbBusqeuda
            // 
            this.txbBusqeuda.Location = new System.Drawing.Point(67, 182);
            this.txbBusqeuda.Name = "txbBusqeuda";
            this.txbBusqeuda.Size = new System.Drawing.Size(128, 23);
            this.txbBusqeuda.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.TxbUnidadMedida);
            this.panel1.Controls.Add(this.picbajar);
            this.panel1.Controls.Add(this.chkActivo);
            this.panel1.Controls.Add(this.lb);
            this.panel1.Location = new System.Drawing.Point(67, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 344);
            this.panel1.TabIndex = 65;
            this.panel1.Visible = false;
            // 
            // TxbUnidadMedida
            // 
            this.TxbUnidadMedida.Location = new System.Drawing.Point(52, 157);
            this.TxbUnidadMedida.Name = "TxbUnidadMedida";
            this.TxbUnidadMedida.Size = new System.Drawing.Size(175, 23);
            this.TxbUnidadMedida.TabIndex = 49;
            // 
            // picbajar
            // 
            this.picbajar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbajar.Image = global::CapaPresentacion.Properties.Resources.abajo1;
            this.picbajar.Location = new System.Drawing.Point(505, 3);
            this.picbajar.Name = "picbajar";
            this.picbajar.Size = new System.Drawing.Size(47, 43);
            this.picbajar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbajar.TabIndex = 48;
            this.picbajar.TabStop = false;
            this.picbajar.Click += new System.EventHandler(this.picbajar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkActivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkActivo.Location = new System.Drawing.Point(324, 157);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(77, 23);
            this.chkActivo.TabIndex = 27;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb.Location = new System.Drawing.Point(52, 127);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(156, 19);
            this.lb.TabIndex = 0;
            this.lb.Text = "Unidad de Medida";
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
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(522, 563);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(97, 42);
            this.BtnGuardar.TabIndex = 64;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
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
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(368, 563);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 42);
            this.BtnCancelar.TabIndex = 63;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            this.BtnEditar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(226, 563);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(112, 42);
            this.BtnEditar.TabIndex = 62;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(83, 563);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 42);
            this.btnNuevo.TabIndex = 61;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FormUnidadMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(688, 663);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvUnidadMedida);
            this.Controls.Add(this.lbcodum);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.rbtTodos);
            this.Controls.Add(this.RbtNoActivo);
            this.Controls.Add(this.RbtActivo);
            this.Controls.Add(this.txbBusqeuda);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUnidadMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUnidadMedida";
            this.Load += new System.EventHandler(this.FormUnidadMedida_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidadMedida)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbajar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlHeader;
        private Label lbum;
        private Panel pnlBarra;
        private PictureBox Salir;
        private DataGridView dgvUnidadMedida;
        private Label lbcodum;
        private Button BtnBuscar;
        private RadioButton rbtTodos;
        private RadioButton RbtNoActivo;
        private RadioButton RbtActivo;
        private TextBox txbBusqeuda;
        private Panel panel1;
        private TextBox TxbUnidadMedida;
        private PictureBox picbajar;
        private CheckBox chkActivo;
        private Label lb;
        private Button BtnGuardar;
        private Button BtnCancelar;
        private Button BtnEditar;
        private Button btnNuevo;
        private DataGridViewTextBoxColumn CodigoTipoProd;
        private DataGridViewTextBoxColumn UnidadMed;
        private DataGridViewTextBoxColumn Activo;
        private DataGridViewButtonColumn Accion;
    }
}