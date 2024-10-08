﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_equipo_19A
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Nombre";


            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Descripcion";
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarAlta_Click(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            bool formValido = validarAgregarModificar();
            if (!formValido)
            {
                MessageBox.Show("El formulario es invalido. Chequee y vuelva a intentar");
                return;
            }
            try
            {
                if(articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = codTextBox.Text;
                articulo.Nombre = nomTextBox.Text;
                articulo.Descripcion = descTextBox.Text;
                articulo.marca = (Marca)cboMarca.SelectedItem;
                articulo.categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = Convert.ToDecimal(precTextBox.Text);
                articulo.UrlImagen = urlImagenTextBox.Text;

                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Articulo modificado con éxito");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Articulo agregado con éxito");
                }

          
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                btnAceptarAlta.Enabled = true;
            }
        }


        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Nombre";


            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Descripcion";

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboCategoria.DataSource = categoriaNegocio.listar();

                if(articulo !=  null ) {
                    codTextBox.Text = articulo.Codigo;
                    nomTextBox.Text = articulo.Nombre.ToString();
                    descTextBox.Text = articulo.Descripcion;
                    precTextBox.Text = articulo.Precio.ToString();
                    urlImagenTextBox.Text = articulo.UrlImagen;
                    cargarImagen(articulo.UrlImagen);
                    cboMarca.SelectedValue = articulo.marca.Id;
                    cboCategoria.SelectedValue = articulo.categoria.Id;


                }


            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());         
            }
           
        }


        private void urlImagenTextBox_Leave(object sender, EventArgs e)
        {
            cargarImagen(urlImagenTextBox.Text);

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                imgAltaPicBox.Load(imagen);
            }
            catch (Exception ex)
            {
                imgAltaPicBox.Load("https://6104926.fs1.hubspotusercontent-na1.net/hubfs/6104926/Imported_Blog_Media/defect1.jpg");
            }
        }


        private bool validarAgregarModificar()
        {
            if(codTextBox.Text == "")
            {
                MessageBox.Show("El campo Codigo no puede estar vacio");
                return false;
            }
            if (nomTextBox.Text == "")
            {
                MessageBox.Show("El campo Nombre no puede estar vacio");
                return false;
            }
            if (descTextBox.Text == "")
            {
                MessageBox.Show("El campo Descripcion no puede estar vacio");
                return false;
            }
            if (precTextBox.Text == "")
            {
                MessageBox.Show("El campo Precio no puede estar vacio");
                return false;
            }
            if (urlImagenTextBox.Text == "")
            {
                MessageBox.Show("El campo Imagen Url no puede estar vacio");
                return false;
            }
            if (cboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una marca");
                return false;
            }
            if (cboCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoria");
                return false;
            }
            foreach (char caracter in precTextBox.Text)
            {
                if (!char.IsDigit(caracter) && caracter != ',')
                {
                    MessageBox.Show("El campo Precio solo puede contener numeros y una coma");
                    return false;
                }

            }
            return true;

        }
    }
}
