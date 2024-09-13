using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

using System.Data.SqlClient;





namespace TPWinForm_equipo_19A
{


    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;
        
        public Form1()
        {
            InitializeComponent();



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            //modificar.showDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estás seguro que querés eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                }
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            listaArticulos = negocio.Listar();
            dgvArticulos.DataSource = listaArticulos;

            //ESTO ES PARA QUE NO SE MUESTRE LA COLUMNA DE URL PERO ROMPE TAMBIEN
            //dgvArticulos.Columns["UrlImagen"].Visible = false;
            pbxArticulo.Load(listaArticulos[0].UrlImagen);
            dgvArticulos.SelectionChanged += dgvArticulos_SelectionChanged;

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbxArticulo_Click(object sender, EventArgs e)
        {

        }
        //ESTA COMENTADO EN EL DESIGNER TAMBIEN
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://6104926.fs1.hubspotusercontent-na1.net/hubfs/6104926/Imported_Blog_Media/defect1.jpg");
            }
        }
    }
}
