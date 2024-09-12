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

namespace TPWinForm_equipo_19A
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo nuevo = new Articulo();
                Negocio negocio = new Negocio();

                nuevo.Codigo = codTextBox.Text;
                nuevo.Nombre = nomTextBox.Text;
                nuevo.Descripcion = descTextBox.Text;
                //nuevo.marca = new Marca();
                nuevo.marca = (Marca)cboMarca.SelectedItem;
                //chequear esto
                //nuevo.categoria = new Categoria();
                nuevo.categoria = (Categoria)cboCategoria.SelectedItem;
                nuevo.Precio = Convert.ToDecimal(precTextBox.Text);

                
                negocio.agregar(nuevo);
                MessageBox.Show("Articulo agregado con exito");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());         
            }
           
        }

        private void idMarcaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
