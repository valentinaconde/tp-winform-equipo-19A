namespace TPWinForm_equipo_19A
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregarCategoriaMarca = new System.Windows.Forms.Button();
            this.btnEliminarCategoriaMarca = new System.Windows.Forms.Button();
            this.btnModCategoriaMarca = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblListadoArticulos";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de articulos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleName = "btnAgregar";
            this.btnAgregar.Location = new System.Drawing.Point(12, 296);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(64, 24);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleName = "btnEditar";
            this.btnEditar.Location = new System.Drawing.Point(82, 296);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(64, 24);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleName = "btnEliminar";
            this.btnEliminar.Location = new System.Drawing.Point(152, 296);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 24);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCriterio);
            this.groupBox1.Controls.Add(this.cboCampo);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.lblCampo);
            this.groupBox1.Controls.Add(this.lblFiltro);
            this.groupBox1.Controls.Add(this.lblCriterio);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lblCampo
            // 
            this.lblCampo.AccessibleName = "lblMarca";
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(4, 24);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 8;
            this.lblCampo.Text = "Campo";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AccessibleName = "lblFiltro";
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(348, 23);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblFiltro.TabIndex = 6;
            this.lblFiltro.Text = "Filtro";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AccessibleName = "lblCategoria";
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(164, 24);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 5;
            this.lblCriterio.Text = "Criterio";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleName = "btnBuscar";
            this.btnBuscar.Location = new System.Drawing.Point(515, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AccessibleName = "dgvArticulos";
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArticulos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 101);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvArticulos.ShowEditingIcon = false;
            this.dgvArticulos.Size = new System.Drawing.Size(840, 189);
            this.dgvArticulos.TabIndex = 6;
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(895, 101);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(198, 189);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 7;
            this.pbxArticulo.TabStop = false;
            // 
            // btnAgregarCategoriaMarca
            // 
            this.btnAgregarCategoriaMarca.AccessibleName = "btnAgregarCategoria";
            this.btnAgregarCategoriaMarca.Location = new System.Drawing.Point(655, 296);
            this.btnAgregarCategoriaMarca.Name = "btnAgregarCategoriaMarca";
            this.btnAgregarCategoriaMarca.Size = new System.Drawing.Size(197, 25);
            this.btnAgregarCategoriaMarca.TabIndex = 8;
            this.btnAgregarCategoriaMarca.Text = "Agregar marca/categoria";
            this.btnAgregarCategoriaMarca.UseVisualStyleBackColor = true;
            this.btnAgregarCategoriaMarca.Click += new System.EventHandler(this.btnAgregarCategoriaMarca_Click);
            // 
            // btnEliminarCategoriaMarca
            // 
            this.btnEliminarCategoriaMarca.AccessibleName = "btnEliminarCategoriaMarca";
            this.btnEliminarCategoriaMarca.Location = new System.Drawing.Point(655, 358);
            this.btnEliminarCategoriaMarca.Name = "btnEliminarCategoriaMarca";
            this.btnEliminarCategoriaMarca.Size = new System.Drawing.Size(197, 25);
            this.btnEliminarCategoriaMarca.TabIndex = 9;
            this.btnEliminarCategoriaMarca.Text = "Eliminar marca/categoria";
            this.btnEliminarCategoriaMarca.UseVisualStyleBackColor = true;
            this.btnEliminarCategoriaMarca.Click += new System.EventHandler(this.btnEliminarCategoriaMarca_Click);
            // 
            // btnModCategoriaMarca
            // 
            this.btnModCategoriaMarca.AccessibleName = "btnAgregarCategoria";
            this.btnModCategoriaMarca.Location = new System.Drawing.Point(655, 327);
            this.btnModCategoriaMarca.Name = "btnModCategoriaMarca";
            this.btnModCategoriaMarca.Size = new System.Drawing.Size(197, 25);
            this.btnModCategoriaMarca.TabIndex = 10;
            this.btnModCategoriaMarca.Text = "Modificar marca/categoria";
            this.btnModCategoriaMarca.UseVisualStyleBackColor = true;
            this.btnModCategoriaMarca.Click += new System.EventHandler(this.btnModCategoriaMarca_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(399, 20);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtFiltro.TabIndex = 11;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(50, 19);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(97, 21);
            this.cboCampo.TabIndex = 12;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(209, 19);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 13;
            // 
            // Form1
            // 
            this.AccessibleName = "frmListadoArticulos";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1353, 711);
            this.Controls.Add(this.btnModCategoriaMarca);
            this.Controls.Add(this.btnEliminarCategoriaMarca);
            this.Controls.Add(this.btnAgregarCategoriaMarca);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Listado Articulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnAgregarCategoriaMarca;
        private System.Windows.Forms.Button btnEliminarCategoriaMarca;
        private System.Windows.Forms.Button btnModCategoriaMarca;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
    }
}

