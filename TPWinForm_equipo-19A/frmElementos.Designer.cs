namespace TPWinForm_equipo_19A
{
    partial class frmElementos
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
            this.lblNomElemento = new System.Windows.Forms.Label();
            this.txtBoxAgregar = new System.Windows.Forms.TextBox();
            this.labelElementoTxt = new System.Windows.Forms.Label();
            this.cboElemento = new System.Windows.Forms.ComboBox();
            this.btnAceptarElemento = new System.Windows.Forms.Button();
            this.btnCancelarElemento = new System.Windows.Forms.Button();
            this.cboEliminarElemento = new System.Windows.Forms.ComboBox();
            this.lblElemento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomElemento
            // 
            this.lblNomElemento.AutoSize = true;
            this.lblNomElemento.Location = new System.Drawing.Point(44, 103);
            this.lblNomElemento.Name = "lblNomElemento";
            this.lblNomElemento.Size = new System.Drawing.Size(44, 13);
            this.lblNomElemento.TabIndex = 0;
            this.lblNomElemento.Text = "Nombre";
            // 
            // txtBoxAgregar
            // 
            this.txtBoxAgregar.Location = new System.Drawing.Point(98, 100);
            this.txtBoxAgregar.Name = "txtBoxAgregar";
            this.txtBoxAgregar.Size = new System.Drawing.Size(256, 20);
            this.txtBoxAgregar.TabIndex = 1;
            // 
            // labelElementoTxt
            // 
            this.labelElementoTxt.AutoSize = true;
            this.labelElementoTxt.Location = new System.Drawing.Point(41, 49);
            this.labelElementoTxt.Name = "labelElementoTxt";
            this.labelElementoTxt.Size = new System.Drawing.Size(51, 13);
            this.labelElementoTxt.TabIndex = 2;
            this.labelElementoTxt.Text = "Elemento";
            // 
            // cboElemento
            // 
            this.cboElemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboElemento.FormattingEnabled = true;
            this.cboElemento.Location = new System.Drawing.Point(102, 46);
            this.cboElemento.Name = "cboElemento";
            this.cboElemento.Size = new System.Drawing.Size(256, 21);
            this.cboElemento.TabIndex = 3;
            this.cboElemento.SelectedIndexChanged += new System.EventHandler(this.cboElemento_SelectedIndexChanged);
            // 
            // btnAceptarElemento
            // 
            this.btnAceptarElemento.Location = new System.Drawing.Point(311, 175);
            this.btnAceptarElemento.Name = "btnAceptarElemento";
            this.btnAceptarElemento.Size = new System.Drawing.Size(89, 33);
            this.btnAceptarElemento.TabIndex = 4;
            this.btnAceptarElemento.Text = "Aceptar";
            this.btnAceptarElemento.UseVisualStyleBackColor = true;
            this.btnAceptarElemento.Click += new System.EventHandler(this.btnAceptarElemento_Click);
            // 
            // btnCancelarElemento
            // 
            this.btnCancelarElemento.Location = new System.Drawing.Point(24, 175);
            this.btnCancelarElemento.Name = "btnCancelarElemento";
            this.btnCancelarElemento.Size = new System.Drawing.Size(89, 33);
            this.btnCancelarElemento.TabIndex = 5;
            this.btnCancelarElemento.Text = "Cancelar";
            this.btnCancelarElemento.UseVisualStyleBackColor = true;
            // 
            // cboEliminarElemento
            // 
            this.cboEliminarElemento.AccessibleName = "cboEliminarElemento";
            this.cboEliminarElemento.FormattingEnabled = true;
            this.cboEliminarElemento.Location = new System.Drawing.Point(102, 73);
            this.cboEliminarElemento.Name = "cboEliminarElemento";
            this.cboEliminarElemento.Size = new System.Drawing.Size(252, 21);
            this.cboEliminarElemento.TabIndex = 6;
            this.cboEliminarElemento.SelectedIndexChanged += new System.EventHandler(this.cboEliminarElemento_SelectedIndexChanged);
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Location = new System.Drawing.Point(49, 76);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(43, 13);
            this.lblElemento.TabIndex = 7;
            this.lblElemento.Text = "Eliminar";
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 273);
            this.Controls.Add(this.lblElemento);
            this.Controls.Add(this.cboEliminarElemento);
            this.Controls.Add(this.btnCancelarElemento);
            this.Controls.Add(this.btnAceptarElemento);
            this.Controls.Add(this.cboElemento);
            this.Controls.Add(this.labelElementoTxt);
            this.Controls.Add(this.txtBoxAgregar);
            this.Controls.Add(this.lblNomElemento);
            this.Name = "frmAgregar";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomElemento;
        private System.Windows.Forms.TextBox txtBoxAgregar;
        private System.Windows.Forms.Label labelElementoTxt;
        private System.Windows.Forms.ComboBox cboElemento;
        private System.Windows.Forms.Button btnAceptarElemento;
        private System.Windows.Forms.Button btnCancelarElemento;
        private System.Windows.Forms.ComboBox cboEliminarElemento;
        private System.Windows.Forms.Label lblElemento;
    }
}