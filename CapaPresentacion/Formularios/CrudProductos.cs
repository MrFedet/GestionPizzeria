﻿using CapaCapaNegocio.Interfaces;
using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using CapaNegocio.Implementacion;
using CapaNegocio.Interfaces;
using CapaPresentacion.Formularios.CombosProducto;
using CapaPresentacion.Formularios_es.CombosProducto;
using CapaPresentacion.RecursoIdioma;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace CapaPresentacion.Formularios
{
    public partial class CrudProductos : Form
    {
        ing_Cbos lgcbo = new ng_Cbos();
        ing_CrudProductos lg = new ng_CrudProductos();
        List<Producto> lproductos = new List<Producto>();   
        Producto prodSelect = new Producto();
        bool chkestado = true;
        DataGridViewButtonColumn customButtonColumn = new DataGridViewButtonColumn();
        public CrudProductos()
        {
            InitializeComponent();
        }
        //deja panel formulario limpio y con los botones necesarios activados y desactivados
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlCrud.Visible = true;
            Limpiar();
            Botones(false);
            picLimpiar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            Habilitar(true);
        }
        //activa o desactiva botones
        private void Botones(bool a)
        {
            BtnCancelar.Enabled = a;
            btnNuevo.Enabled = a;
            BtnEditar.Enabled = a;
            BtnGuardar.Enabled = a;
        }
        //hablita campos para qeu puedan ser editados y tambien los botones
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Botones(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            Habilitar(true);

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

        }
        //cancela la modificacion , limpia los campos y el objeeto
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            pnlCrud.Visible = false;
            Botones(false);
            prodSelect = new Producto();
            chkestado = true;
            btnNuevo.Enabled = true;

        }
        //limpia campos y objeto
        private void Limpiar()
        {
            txbNombre.Text = string.Empty;
            txbDescripcion.Text = string.Empty;
            cboClasificacion.SelectedIndex = -1;
            cboUnidadMeidda.SelectedIndex = -1;
            cboTipoProd.SelectedIndex = - 1;
            chkActivo.Checked = true;
            numpPrecio.Value = 0;
            nupStock.Value = 0;
            prodSelect = new Producto();
            chkestado = true;
        }

        //funciona igual que boton cancelar , es el boton rojo de bajar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Limpiar();
            pnlCrud.Visible = false;
            Botones(false);
            prodSelect = new Producto();
            chkestado = true;
            btnNuevo.Enabled = true;
        }
        //boton de limpiar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //carga CBO con clasificacion activa
        private void cargar_cboClasificacion(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = lgcbo.ObtenerClasificacion();
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }
        //carga CBO con Tipo de producto activo

        private void cargar_cboTipoProducto(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = lgcbo.ObtenerTipoProducto();
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }
        //carga CBO con Unidad meidda activa

        private void cargar_cboUnidadMedida(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = lgcbo.ObtenerUnidadMedida();
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }
        //trae los productos activos, los carga en la dgv, detecta y aplica idioma, tamb carga loscbo
        private void CrudProductos_Load(object sender, EventArgs e)
        {
            cargar_cboClasificacion(cboClasificacion,"clasificacion", "IdClasificacion");
            cargar_cboTipoProducto(cboTipoProd,"Tipo_Producto", "IdTipoProducto");
            cargar_cboUnidadMedida(cboUnidadMeidda,"Unidad_Medida", "IdUnidadMedida");
            lproductos = lg.GetProductos(0);
            cargarDgv(lproductos);
            DetectarIdioma();
            AplicarIdioma();

        }

        //carga la datagrid view
        private void cargarDgv(List<Producto> lp)
        {
            dgvProd.Rows.Clear();

            foreach (Producto p in lp)
            {
                string baj = Rec.No;
                if (p.Baja_logica == 0)
                {
                    baj = Rec.Si;
                }
               dgvProd.Rows.Add(p.Id_producto,p.Nombre,p.Detalle,p.Tipo_producto.Tipo_producto,p.Unidadmedida.Unidad_Medida,p.clasificacion.clasificacion,p.Stock,p.Precio,baj,Rec.Detalle);

            }
        }
        //carga el producto seleccionado en el objeto y carga los datos en el panel de formulario para ver el detalle
        private void Click_Detalle(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvProd.Columns[e.ColumnIndex].Name == "accion" && dgvProd.Rows.Count != 0)
            {
                prodSelect = new Producto();
                Clasificacion c = new Clasificacion();
                UnidadMedida um = new UnidadMedida();
                TipoProducto tprod = new TipoProducto();
                prodSelect.Unidadmedida= um;
                prodSelect.clasificacion= c;
                prodSelect.Tipo_producto= tprod;
                pnlCrud.Visible = true;
                prodSelect.Id_producto = Convert.ToInt32(dgvProd.CurrentRow.Cells[0].Value);
                CargarProducto(prodSelect.Id_producto);
                CargarPanelProducto(prodSelect);
                Habilitar(false);
                picLimpiar.Enabled = false;
                Botones(false);
                BtnEditar.Enabled = true;
                if (Convert.ToInt32(cboClasificacion.SelectedValue) == 2)
                {
                    lbPrecio.Visible = false;
                    numpPrecio.Visible = false;
                    label6.Visible = false;
                }
                pnlCrud.Visible = true;


            }
        }

        //carga el panel con el producto seleccionado
        private void CargarPanelProducto(Producto producto)
        {
            txbNombre.Text = producto.Nombre;
            cboClasificacion.SelectedValue = producto.clasificacion.IdClasificacion;
            cboTipoProd.SelectedValue = producto.Tipo_producto.IdTipoProducto;
            cboUnidadMeidda.SelectedValue = producto.Unidadmedida.IdUnidadMedida;
            txbDescripcion.Text = producto.Detalle;
            if (producto.Baja_logica == 0)
            {
                chkActivo.Checked = true;
                chkestado = true;
            }
            else
            {
                chkActivo.Checked = false;
                chkestado = false;
            }
            nupStock.Value = producto.Stock;
            numpPrecio.Value = producto.Precio;

        }
        //valida que todos los datos requeridos esten
        private bool Validacion()
        {
            if (txbNombre.Text == "")
            {
                MessageBox.Show(Rec.MessageValidacionNombreProd,Rec.CapError,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else if (cboClasificacion.SelectedIndex == -1)
            {
                MessageBox.Show(Rec.MessageValidacionClasificacion, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cboUnidadMeidda.SelectedIndex == -1)
            {
                MessageBox.Show(Rec.MessageValidacionUnidadMed, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cboTipoProd.SelectedIndex == -1)
            {
                MessageBox.Show(Rec.MessageValidacionTipoProd, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (numpPrecio.Value == 0 && Convert.ToInt32(cboClasificacion.SelectedValue) == 1)
            {
                MessageBox.Show(Rec.MessageValidacionPrecioProd, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        //confirma si se quiere darde baja un prod, y modidica o inserta nuevo producto/ ingrediente si es necesario
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (chkestado && !chkActivo.Checked)
            {
                if (MessageBox.Show(Rec.messageDarBajProd, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Validacion())
                    {
                        Producto prod = new Producto();
                        AbstraerProducto(prod);
                        if (!(prod.clasificacion.IdClasificacion == 2))
                        {
                            if (prodSelect.Id_producto != 0)
                            {
                                prod.Id_producto = prodSelect.Id_producto;
                                if (lg.Modificacion(prod, LogIn.u))
                                {
                                    MessageBox.Show(Rec.MessageProdModificado);
                                    lproductos = lg.GetProductos(0);
                                    cargarDgv(lproductos);
                                    Botones(false);
                                    Limpiar();
                                    btnNuevo.Enabled = true;
                                    pnlCrud.Visible = false;
                                    RbtActivos.Checked = true;
                                    prodSelect = new Producto();
                                }
                            }
                            else
                            {
                                if (lg.AltaProducto(prod, LogIn.u))
                                {
                                    MessageBox.Show(Rec.MessageProdAlta);
                                    lproductos = lg.GetProductos(0);
                                    cargarDgv(lproductos);
                                    Botones(false);
                                    Limpiar();
                                    btnNuevo.Enabled = true;
                                    pnlCrud.Visible = false;
                                    RbtActivos.Checked = true;
                                }
                            }
                        }
                        else
                        {
                            if (prodSelect.Id_producto != 0)
                            {
                                prod.Id_producto = prodSelect.Id_producto;
                                if (lg.ModificacionIngrediente(prod, LogIn.u))
                                {
                                    MessageBox.Show(Rec.MessageIngredienteModif);
                                    lproductos = lg.GetProductos(0);
                                    cargarDgv(lproductos);
                                    Botones(false);
                                    Limpiar();
                                    btnNuevo.Enabled = true;
                                    pnlCrud.Visible = false;
                                    RbtActivos.Checked = true;
                                    prodSelect = new Producto();
                                    lbPrecio.Visible = true;
                                    numpPrecio.Visible = true;
                                    label6.Visible = true;
                                }
                            }
                            else
                            {
                                if (lg.AltaIngrediente(prod, LogIn.u))
                                {
                                    MessageBox.Show(Rec.MessageIngredienteAlta);
                                    lproductos = lg.GetProductos(0);
                                    cargarDgv(lproductos);
                                    Botones(false);
                                    Limpiar();
                                    btnNuevo.Enabled = true;
                                    pnlCrud.Visible = false;
                                    RbtActivos.Checked = true;
                                    lbPrecio.Visible = true;
                                    numpPrecio.Visible = true;
                                    label6.Visible = true;

                                }
                            }
                        }


                    }

                }

            }
            else
            {
                if (Validacion())
                {
                    Producto prod = new Producto();
                    AbstraerProducto(prod);
                    if (!(prod.clasificacion.IdClasificacion == 2))
                    {
                        if (prodSelect.Id_producto != 0)
                        {
                            prod.Id_producto = prodSelect.Id_producto;
                            if (lg.Modificacion(prod, LogIn.u))
                            {
                                MessageBox.Show(Rec.MessageProdModificado);
                                lproductos = lg.GetProductos(0);
                                cargarDgv(lproductos);
                                Botones(false);
                                Limpiar();
                                btnNuevo.Enabled = true;
                                pnlCrud.Visible = false;
                                RbtActivos.Checked = true;
                                prodSelect = new Producto();
                            }
                        }
                        else
                        {
                            if (lg.AltaProducto(prod, LogIn.u))
                            {
                                MessageBox.Show(Rec.MessageProdAlta);
                                lproductos = lg.GetProductos(0);
                                cargarDgv(lproductos);
                                Botones(false);
                                Limpiar();
                                btnNuevo.Enabled = true;
                                pnlCrud.Visible = false;
                                RbtActivos.Checked = true;
                            }
                        }
                    }
                    else
                    {
                        if (prodSelect.Id_producto != 0)
                        {
                            prod.Id_producto = prodSelect.Id_producto;
                            if (lg.ModificacionIngrediente(prod, LogIn.u))
                            {
                                MessageBox.Show(Rec.MessageIngredienteModif);
                                lproductos = lg.GetProductos(0);
                                cargarDgv(lproductos);
                                Botones(false);
                                Limpiar();
                                btnNuevo.Enabled = true;
                                pnlCrud.Visible = false;
                                RbtActivos.Checked = true;
                                prodSelect = new Producto();
                                lbPrecio.Visible = true;
                                numpPrecio.Visible = true;
                                label6.Visible = true;
                            }
                        }
                        else
                        {
                            if (lg.AltaIngrediente(prod, LogIn.u))
                            {
                                MessageBox.Show(Rec.MessageIngredienteAlta);
                                lproductos = lg.GetProductos(0);
                                cargarDgv(lproductos);
                                Botones(false);
                                Limpiar();
                                btnNuevo.Enabled = true;
                                pnlCrud.Visible = false;
                                RbtActivos.Checked = true;
                                lbPrecio.Visible = true;
                                numpPrecio.Visible = true;
                                label6.Visible = true;

                            }
                        }
                    }


                }

            }
        }


        //abstrae producto
        private void AbstraerProducto(Producto p)
        {
            Clasificacion c = new Clasificacion();
            UnidadMedida um = new UnidadMedida();
            TipoProducto tprod = new TipoProducto();
            p.clasificacion= c;
            p.Unidadmedida= um;
            p.Tipo_producto= tprod;
            p.Nombre = txbNombre.Text;
            p.Precio = numpPrecio.Value;
            p.Stock = Convert.ToInt32(nupStock.Value);
            p.Detalle = txbDescripcion.Text;
            p.clasificacion.IdClasificacion = Convert.ToInt32(cboClasificacion.SelectedValue);
            p.Tipo_producto.IdTipoProducto = Convert.ToInt32(cboTipoProd.SelectedValue);
            p.Unidadmedida.IdUnidadMedida = Convert.ToInt32(cboUnidadMeidda.SelectedValue);
            if (chkActivo.Checked)
            {
                p.Baja_logica = 0;
            }
            else
            {
                p.Baja_logica = 1;

            }
        }
        //pasa los datos del producto al objeto
        private void CargarProducto( int id_prod)
        {
            foreach (Producto u in lproductos)
            {
                if (u.Id_producto == id_prod)
                {
                    prodSelect = u;
                    break;
                }
            }
        }
        //habilita campos
        private void Habilitar(bool a)
        {
            txbNombre.Enabled = a;
            cboClasificacion.Enabled = a;
            cboTipoProd.Enabled = a;
            cboUnidadMeidda.Enabled = a;
            txbDescripcion.Enabled = a;
            chkActivo.Enabled = a;
            nupStock.Enabled = a;
            numpPrecio.Enabled = a;
        }
        //BOTON BUSCAR!!! permite realizar los filtros segun el filtro seleccionado
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (rbtCodigo.Checked)
            {
                try
                {
                    lproductos.Clear();
                    lproductos = lg.GetProductos(0);
                    cargarDgv(lproductos);
                    Convert.ToInt32(txbbusqueda.Text);
                    List<DataGridViewRow> temp = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in dgvProd.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["IdProducto"].Value) != Convert.ToInt32(txbbusqueda.Text))
                        {
                            temp.Add(row);
                        }

                    }

                    foreach (DataGridViewRow row in temp)
                    {

                        dgvProd.Rows.Remove(row);

                    }
                    rbtTodos.Checked = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(Rec.MessageParafiltrarporCodProd,Rec.CapError,MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
            }else if (txbbusqueda.Text != string.Empty)
            {
                lproductos.Clear();
                lproductos = lg.GetProductos(0);
                cargarDgv(lproductos);
                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvProd.Rows)
                {
                    if (Convert.ToString(row.Cells["nombreprod"].Value).ToLower() != txbbusqueda.Text.ToLower())
                    {
                        temp.Add(row);
                    }

                }

                foreach (DataGridViewRow row in temp)
                {

                    dgvProd.Rows.Remove(row);

                }
                rbtTodos.Checked = true;
            }

        }
        //cambia la dgv segun el rbt seelccionado
        private void RbtActivos_CheckedChanged(object sender, EventArgs e)
        {
            lproductos.Clear();
            int dgvselectedcondicion = 0;
            lproductos = lg.GetProductos(dgvselectedcondicion);
            cargarDgv(lproductos);
        }
        //cambia la dgv segun el rbt seelccionado

        private void RbtEliminados_CheckedChanged(object sender, EventArgs e)
        {
            lproductos.Clear();
            int dgvselectedcondicion = 1;
            lproductos = lg.GetProductos(dgvselectedcondicion);
            cargarDgv(lproductos);
        }
        //cambia la dgv segun el rbt seelccionado

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {
            lproductos.Clear();
            int dgvselectedcondicion = 2;
            lproductos = lg.GetProductos(dgvselectedcondicion);
            cargarDgv(lproductos);
        }
        //abre form de clasifcicacion y para agregar nueva y actualiza los cbo
        private void BtnClasificacion_Click(object sender, EventArgs e)
        {
            FormClasificacion fc = new FormClasificacion();
            fc.ShowDialog();
            if (fc.DialogResult == DialogResult.OK)
            {
                cargar_cboClasificacion(cboClasificacion, "clasificacion", "IdClasificacion");
                cargar_cboTipoProducto(cboTipoProd, "Tipo_Producto", "IdTipoProducto");
                cargar_cboUnidadMedida(cboUnidadMeidda, "Unidad_Medida", "IdUnidadMedida");
            }
        }
        //abre form de Tipo de producto y para agregar nueva y actualiza los cbo

        private void BtnTipoProd_Click(object sender, EventArgs e)
        {
            FormTipoProd ftp = new FormTipoProd();
            ftp.ShowDialog();
            if (ftp.DialogResult == DialogResult.OK)
            {
                cargar_cboClasificacion(cboClasificacion, "clasificacion", "IdClasificacion");
                cargar_cboTipoProducto(cboTipoProd, "Tipo_Producto", "IdTipoProducto");
                cargar_cboUnidadMedida(cboUnidadMeidda, "Unidad_Medida", "IdUnidadMedida");
            }
        }
        //abre form de unidad de medida y para agregar nueva y actualiza los cbo

        private void btnUnidadMedida_Click(object sender, EventArgs e)
        {
            FormUnidadMedida fum = new FormUnidadMedida();
            fum.ShowDialog();
            if (fum.DialogResult == DialogResult.OK)
            {
                cargar_cboClasificacion(cboClasificacion, "clasificacion", "IdClasificacion");
                cargar_cboTipoProducto(cboTipoProd, "Tipo_Producto", "IdTipoProducto");
                cargar_cboUnidadMedida(cboUnidadMeidda, "Unidad_Medida", "IdUnidadMedida");
            }
        }
        //aplica el texto
        public void AplicarIdioma()
        {
            lbProd.Text = Rec.Productos;
            BtnTipoProd.Text = Rec.TipoProducto;
            BtnClasificacion.Text = Rec.Clasificacion;
            btnUnidadMedida.Text = Rec.UnidadMedida;
            chkActivo.Text = Rec.Activo;
            btnNuevo.Text = Rec.Nuevo;
            BtnEditar.Text = Rec.Editar;
            BtnCancelar.Text = Rec.Cancelar;
            BtnGuardar.Text = Rec.Guardar;
            lbNombre.Text = Rec.Nombre;
            lbClasificacion.Text= Rec.Clasificacion;
            lbUnidad.Text = Rec.UnidadMedida;
            lbTipoProd.Text = Rec.TipoProducto;
            lbDesc.Text = Rec.Descripcion;
            lbPrecio.Text = Rec.Precio;
            lbstock.Text = Rec.Stock;
            chkActivo.Text = Rec.Activo;
            rbtTodos.Text = Rec.Todos;
            RbtActivos.Text = Rec.Activos;
            RbtEliminados.Text = Rec.Eliminados;
            rbtCodigo.Text = Rec.Codigo;
            rbtNombre.Text = Rec.Nombre;
            BtnLogin.Text = Rec.Buscar;
            dgvProd.Columns[0].HeaderText = Rec.CodigoProdutco;
            dgvProd.Columns[1].HeaderText = Rec.Nombre;
            dgvProd.Columns[2].HeaderText = Rec.Descripcion;
            dgvProd.Columns[3].HeaderText = Rec.TipoProducto;
            dgvProd.Columns[4].HeaderText = Rec.UnidadMedida;
            dgvProd.Columns[5].HeaderText = Rec.Clasificacion;
            dgvProd.Columns[6].HeaderText = Rec.Stock;
            dgvProd.Columns[7].HeaderText = Rec.Precio;
            dgvProd.Columns[8].HeaderText = Rec.Activo;
            dgvProd.Columns[9].HeaderText = Rec.Detalle;

        }
        //detecta el idioma
        private void DetectarIdioma()
        {
            if (SeleccionIdioma.i.IdIdioma == 2)
            {

                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");

            }
        }
        //segun si es ingrediente o no dejará cargar el precio
        private void cboClasificacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboClasificacion.SelectedValue) != 2)
            {
                lbPrecio.Visible = true;
                numpPrecio.Visible = true;
                label6.Visible = true;

            }
            else
            {
                lbPrecio.Visible = false;
                numpPrecio.Visible = false;
                label6.Visible = false;

            }
        }
        //cambia idioma de btn de dgv
        private void dgvProd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProd.Columns[e.ColumnIndex].Name == "accion")
            {
                // Obtener el valor de la celda
                object value = e.Value;

                if (SeleccionIdioma.i.IdIdioma == 2)
                {
                    // Comprobar el valor y establecer el texto del botón en consecuencia
                    if (value != null && value.ToString() == "accion")
                    {
                        e.Value = "Details";
                    }
                    else
                    {
                        e.Value = "Details";
                    }
                }

            }
        }
    }
}
