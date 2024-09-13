namespace TPWinForm_equipo_19A
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.codigoLabel = new System.Windows.Forms.Label();
            this.codTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.precTextBox = new System.Windows.Forms.TextBox();
            this.precLabel = new System.Windows.Forms.Label();
            this.idMarcaLabel = new System.Windows.Forms.Label();
            this.idCatLabel = new System.Windows.Forms.Label();
            this.btnAceptarAlta = new System.Windows.Forms.Button();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.urlImagenTextBox = new System.Windows.Forms.TextBox();
            this.urlImagenLabel = new System.Windows.Forms.Label();
            this.imgAltaPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgAltaPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            this.codigoLabel.AccessibleName = "codLabel";
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(49, 34);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(40, 13);
            this.codigoLabel.TabIndex = 9;
            this.codigoLabel.Text = "Codigo";
            // 
            // codTextBox
            // 
            this.codTextBox.AccessibleName = "codTextBox";
            this.codTextBox.Location = new System.Drawing.Point(95, 31);
            this.codTextBox.Name = "codTextBox";
            this.codTextBox.Size = new System.Drawing.Size(195, 20);
            this.codTextBox.TabIndex = 0;
            // 
            // nomTextBox
            // 
            this.nomTextBox.AccessibleName = "nomTextBox";
            this.nomTextBox.Location = new System.Drawing.Point(95, 76);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(195, 20);
            this.nomTextBox.TabIndex = 1;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AccessibleName = "nombreLabel";
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(49, 79);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 10;
            this.nombreLabel.Text = "Nombre";
            // 
            // descTextBox
            // 
            this.descTextBox.AccessibleName = "descTextBox";
            this.descTextBox.Location = new System.Drawing.Point(95, 116);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(195, 20);
            this.descTextBox.TabIndex = 2;
            // 
            // descLabel
            // 
            this.descLabel.AccessibleName = "descLabel";
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(30, 119);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(63, 13);
            this.descLabel.TabIndex = 11;
            this.descLabel.Text = "Descripcion";
            // 
            // precTextBox
            // 
            this.precTextBox.AccessibleName = "precTextBox";
            this.precTextBox.Location = new System.Drawing.Point(95, 153);
            this.precTextBox.Name = "precTextBox";
            this.precTextBox.Size = new System.Drawing.Size(195, 20);
            this.precTextBox.TabIndex = 3;
            // 
            // precLabel
            // 
            this.precLabel.AccessibleName = "precLabel";
            this.precLabel.AutoSize = true;
            this.precLabel.Location = new System.Drawing.Point(49, 156);
            this.precLabel.Name = "precLabel";
            this.precLabel.Size = new System.Drawing.Size(37, 13);
            this.precLabel.TabIndex = 12;
            this.precLabel.Text = "Precio";
            // 
            // idMarcaLabel
            // 
            this.idMarcaLabel.AccessibleName = "idMarcaLabel";
            this.idMarcaLabel.AutoSize = true;
            this.idMarcaLabel.Location = new System.Drawing.Point(49, 234);
            this.idMarcaLabel.Name = "idMarcaLabel";
            this.idMarcaLabel.Size = new System.Drawing.Size(37, 13);
            this.idMarcaLabel.TabIndex = 13;
            this.idMarcaLabel.Text = "Marca";
            // 
            // idCatLabel
            // 
            this.idCatLabel.AccessibleName = "idCatLabel";
            this.idCatLabel.AutoSize = true;
            this.idCatLabel.Location = new System.Drawing.Point(34, 276);
            this.idCatLabel.Name = "idCatLabel";
            this.idCatLabel.Size = new System.Drawing.Size(52, 13);
            this.idCatLabel.TabIndex = 14;
            this.idCatLabel.Text = "Categoria";
            // 
            // btnAceptarAlta
            // 
            this.btnAceptarAlta.AccessibleName = "btnAceptarAlta";
            this.btnAceptarAlta.Location = new System.Drawing.Point(211, 314);
            this.btnAceptarAlta.Name = "btnAceptarAlta";
            this.btnAceptarAlta.Size = new System.Drawing.Size(108, 35);
            this.btnAceptarAlta.TabIndex = 7;
            this.btnAceptarAlta.Text = "Aceptar";
            this.btnAceptarAlta.UseVisualStyleBackColor = true;
            this.btnAceptarAlta.Click += new System.EventHandler(this.btnAceptarAlta_Click);
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.AccessibleName = "btnCancelarAlta";
            this.btnCancelarAlta.Location = new System.Drawing.Point(21, 314);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(108, 35);
            this.btnCancelarAlta.TabIndex = 8;
            this.btnCancelarAlta.Text = "Cancelar";
            this.btnCancelarAlta.UseVisualStyleBackColor = true;
            this.btnCancelarAlta.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(95, 231);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(195, 21);
            this.cboMarca.TabIndex = 4;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(95, 268);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(195, 21);
            this.cboCategoria.TabIndex = 5;
            // 
            // urlImagenTextBox
            // 
            this.urlImagenTextBox.AccessibleName = "urlImagenTextBox";
            this.urlImagenTextBox.Location = new System.Drawing.Point(95, 191);
            this.urlImagenTextBox.Name = "urlImagenTextBox";
            this.urlImagenTextBox.Size = new System.Drawing.Size(195, 20);
            this.urlImagenTextBox.TabIndex = 6;
            this.urlImagenTextBox.TextChanged += new System.EventHandler(this.urlImagenTextBox_TextChanged);
            this.urlImagenTextBox.Leave += new System.EventHandler(this.urlImagenTextBox_Leave);
            // 
            // urlImagenLabel
            // 
            this.urlImagenLabel.AccessibleName = "urlImagenLabel";
            this.urlImagenLabel.AutoSize = true;
            this.urlImagenLabel.Location = new System.Drawing.Point(28, 194);
            this.urlImagenLabel.Name = "urlImagenLabel";
            this.urlImagenLabel.Size = new System.Drawing.Size(58, 13);
            this.urlImagenLabel.TabIndex = 15;
            this.urlImagenLabel.Text = "Imagen Url";
            // 
            // imgAltaPicBox
            // 
            this.imgAltaPicBox.AccessibleName = "imgAltaPicBox";
            this.imgAltaPicBox.Location = new System.Drawing.Point(349, 23);
            this.imgAltaPicBox.Name = "imgAltaPicBox";
            this.imgAltaPicBox.Size = new System.Drawing.Size(342, 340);
            this.imgAltaPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgAltaPicBox.TabIndex = 19;
            this.imgAltaPicBox.TabStop = false;
            // 
            // frmAltaArticulo
            // 
            this.AccessibleName = "frmAltaArticulo";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 568);
            this.Controls.Add(this.imgAltaPicBox);
            this.Controls.Add(this.urlImagenTextBox);
            this.Controls.Add(this.urlImagenLabel);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.btnCancelarAlta);
            this.Controls.Add(this.btnAceptarAlta);
            this.Controls.Add(this.idCatLabel);
            this.Controls.Add(this.idMarcaLabel);
            this.Controls.Add(this.precTextBox);
            this.Controls.Add(this.precLabel);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.codTextBox);
            this.Controls.Add(this.codigoLabel);
            this.Name = "frmAltaArticulo";
            this.Text = "Alta Articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAltaPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.TextBox codTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.TextBox precTextBox;
        private System.Windows.Forms.Label precLabel;
        private System.Windows.Forms.Label idMarcaLabel;
        private System.Windows.Forms.Label idCatLabel;
        private System.Windows.Forms.Button btnAceptarAlta;
        private System.Windows.Forms.Button btnCancelarAlta;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox urlImagenTextBox;
        private System.Windows.Forms.Label urlImagenLabel;
        private System.Windows.Forms.PictureBox imgAltaPicBox;
    }
}