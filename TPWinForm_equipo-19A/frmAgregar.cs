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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void txtBoxAgregar_TextChanged(object sender, EventArgs e)
        {

        }

  

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            string[] elementos = new string[] { "Categoria", "Marca" };
            cboElemento.DataSource = elementos;
        }

        private void btnAceptarElemento_Click(object sender, EventArgs e)
        {
            if (cboElemento.Text == "Categoria")
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                categoriaNegocio.agregar(txtBoxAgregar.Text);

            }
            else
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                marcaNegocio.agregar(txtBoxAgregar.Text);
            }

            Close();

        }
    }
}
