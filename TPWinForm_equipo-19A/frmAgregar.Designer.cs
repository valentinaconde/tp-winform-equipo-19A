namespace TPWinForm_equipo_19A
{
    partial class frmAgregar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxAgregar = new System.Windows.Forms.TextBox();
            this.labelElemento = new System.Windows.Forms.Label();
            this.cboElemento = new System.Windows.Forms.ComboBox();
            this.btnAceptarElemento = new System.Windows.Forms.Button();
            this.btnCancelarElemento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtBoxAgregar
            // 
            this.txtBoxAgregar.Location = new System.Drawing.Point(102, 80);
            this.txtBoxAgregar.Name = "txtBoxAgregar";
            this.txtBoxAgregar.Size = new System.Drawing.Size(256, 20);
            this.txtBoxAgregar.TabIndex = 1;
            this.txtBoxAgregar.TextChanged += new System.EventHandler(this.txtBoxAgregar_TextChanged);
            // 
            // labelElemento
            // 
            this.labelElemento.AutoSize = true;
            this.labelElemento.Location = new System.Drawing.Point(41, 49);
            this.labelElemento.Name = "labelElemento";
            this.labelElemento.Size = new System.Drawing.Size(51, 13);
            this.labelElemento.TabIndex = 2;
            this.labelElemento.Text = "Elemento";
            // 
            // cboElemento
            // 
            this.cboElemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboElemento.FormattingEnabled = true;
            this.cboElemento.Location = new System.Drawing.Point(102, 46);
            this.cboElemento.Name = "cboElemento";
            this.cboElemento.Size = new System.Drawing.Size(256, 21);
            this.cboElemento.TabIndex = 3;
            // 
            // btnAceptarElemento
            // 
            this.btnAceptarElemento.Location = new System.Drawing.Point(316, 119);
            this.btnAceptarElemento.Name = "btnAceptarElemento";
            this.btnAceptarElemento.Size = new System.Drawing.Size(89, 33);
            this.btnAceptarElemento.TabIndex = 4;
            this.btnAceptarElemento.Text = "Aceptar";
            this.btnAceptarElemento.UseVisualStyleBackColor = true;
            this.btnAceptarElemento.Click += new System.EventHandler(this.btnAceptarElemento_Click);
            // 
            // btnCancelarElemento
            // 
            this.btnCancelarElemento.Location = new System.Drawing.Point(29, 119);
            this.btnCancelarElemento.Name = "btnCancelarElemento";
            this.btnCancelarElemento.Size = new System.Drawing.Size(89, 33);
            this.btnCancelarElemento.TabIndex = 5;
            this.btnCancelarElemento.Text = "Cancelar";
            this.btnCancelarElemento.UseVisualStyleBackColor = true;
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 160);
            this.Controls.Add(this.btnCancelarElemento);
            this.Controls.Add(this.btnAceptarElemento);
            this.Controls.Add(this.cboElemento);
            this.Controls.Add(this.labelElemento);
            this.Controls.Add(this.txtBoxAgregar);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregar";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxAgregar;
        private System.Windows.Forms.Label labelElemento;
        private System.Windows.Forms.ComboBox cboElemento;
        private System.Windows.Forms.Button btnAceptarElemento;
        private System.Windows.Forms.Button btnCancelarElemento;
    }
}