using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_19A
{
    public partial class frmElementos : Form
    {

        string accion = "";
        

        public frmElementos(string accion)
        {
            this.accion = accion;
            InitializeComponent();

            if (accion == "agregar")
            {
                cboEliminarElemento.Visible = false;
                lblElemento.Visible = false;
            }
            else if(accion == "eliminar")
            {
                txtBoxAgregar.Visible = false;
                lblNomElemento.Visible = false;
                btnAceptarElemento.Text = "Eliminar";
                lblElemento.Text = "Eliminar";
            }
            else if (accion == "modificar")
            {
                btnAceptarElemento.Text = "Modificar";
                lblElemento.Text = "Modificar";
            }

        }


   

  

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            string[] elementos = new string[] { "Categoria", "Marca" };
            cboElemento.DataSource = elementos;
        }

        private void btnAceptarElemento_Click(object sender, EventArgs e)
        {
            bool formValido = validarCampos();
            if (!formValido && accion != "eliminar")
            {
                MessageBox.Show("El formulario es invalido. Chequee y vuelva a intentar");
                return;
            }
            if (cboElemento.Text == "Categoria")
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                if(accion == "eliminar")
                {
                    categoriaNegocio.eliminar((int)cboEliminarElemento.SelectedValue);
                }
                else if (accion == "agregar")
                {
                    categoriaNegocio.agregar(txtBoxAgregar.Text);

                }
                else if (accion == "modificar")
                {
                    categoriaNegocio.modificar((int)cboEliminarElemento.SelectedValue, txtBoxAgregar.Text);
                }

            }
            else
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                if (accion == "eliminar")
                {
                    marcaNegocio.eliminar((int)cboEliminarElemento.SelectedValue);
                }
                else if (accion == "agregar")
                {
                    marcaNegocio.agregar(txtBoxAgregar.Text);

                }
                else if (accion == "modificar")
                {
                    marcaNegocio.modificar((int)cboEliminarElemento.SelectedValue, txtBoxAgregar.Text);
                }
            }

            Close();

        }

        private void cambiarElemento()
        {
            
            if (cboElemento.Text == "Categoria")
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                
                List<Categoria> categorias = categoriaNegocio.listar();
                cboEliminarElemento.DataSource = categorias;
                cboEliminarElemento.DisplayMember = "Descripcion"; 
                cboEliminarElemento.ValueMember = "Id"; 

               
            }
            else
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                List<Marca> marcas = marcaNegocio.listar();
                cboEliminarElemento.DataSource = marcas;
                cboEliminarElemento.DisplayMember = "Descripcion"; 
                cboEliminarElemento.ValueMember = "Id"; 

            }


        }


        private void cboElemento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(accion != "agregar") cambiarElemento();
        }

        private bool validarCampos()
        {
            if(txtBoxAgregar.Text == "")
            {
                return false;
            }
            return true;

        }
    }
}
