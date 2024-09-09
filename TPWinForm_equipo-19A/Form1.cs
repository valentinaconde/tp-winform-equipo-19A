using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;





namespace TPWinForm_equipo_19A
{


    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

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
            dgvArticulos.DataSource = negocio.Listar();
        }
    }
}
