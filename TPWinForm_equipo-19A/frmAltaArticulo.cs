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
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
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
                nuevo.marca = new Marca();
                nuevo.marca.Nombre = descTextBox.Text;
                //chequear esto
                nuevo.categoria = new Categoria();
                nuevo.categoria.Descripcion = descTextBox.Text;
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
    }
}
