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
    public partial class frmModificarArticulo : Form
        
    {   
        private Articulo articulo = null;
        public frmModificarArticulo()
        {
            InitializeComponent();
        }

        public frmModificarArticulo(Articulo articulo)
        {
            InitializeComponent();
        this.articulo = articulo;
        }
    }
}
