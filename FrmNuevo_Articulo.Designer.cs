namespace TP_2_REVOLLO_NAHUEL
{
    partial class FrmNuevo_Articulo
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
            this.LblCodigo_Art = new System.Windows.Forms.Label();
            this.LblNombre_Art = new System.Windows.Forms.Label();
            this.LblDescripcion_Art = new System.Windows.Forms.Label();
            this.Lbl_IdMarca = new System.Windows.Forms.Label();
            this.LblCategoria_Art = new System.Windows.Forms.Label();
            this.Lbl_ImagenUrl = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.CboMarca = new System.Windows.Forms.ComboBox();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.TxtImagenUrl = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblCodigo_Art
            // 
            this.LblCodigo_Art.AutoSize = true;
            this.LblCodigo_Art.Location = new System.Drawing.Point(277, 64);
            this.LblCodigo_Art.Name = "LblCodigo_Art";
            this.LblCodigo_Art.Size = new System.Drawing.Size(40, 13);
            this.LblCodigo_Art.TabIndex = 0;
            this.LblCodigo_Art.Text = "Codigo";
            // 
            // LblNombre_Art
            // 
            this.LblNombre_Art.AutoSize = true;
            this.LblNombre_Art.Location = new System.Drawing.Point(277, 105);
            this.LblNombre_Art.Name = "LblNombre_Art";
            this.LblNombre_Art.Size = new System.Drawing.Size(44, 13);
            this.LblNombre_Art.TabIndex = 1;
            this.LblNombre_Art.Text = "Nombre";
            // 
            // LblDescripcion_Art
            // 
            this.LblDescripcion_Art.AutoSize = true;
            this.LblDescripcion_Art.Location = new System.Drawing.Point(277, 147);
            this.LblDescripcion_Art.Name = "LblDescripcion_Art";
            this.LblDescripcion_Art.Size = new System.Drawing.Size(63, 13);
            this.LblDescripcion_Art.TabIndex = 2;
            this.LblDescripcion_Art.Text = "Descripcion";
            // 
            // Lbl_IdMarca
            // 
            this.Lbl_IdMarca.AutoSize = true;
            this.Lbl_IdMarca.Location = new System.Drawing.Point(277, 185);
            this.Lbl_IdMarca.Name = "Lbl_IdMarca";
            this.Lbl_IdMarca.Size = new System.Drawing.Size(37, 13);
            this.Lbl_IdMarca.TabIndex = 3;
            this.Lbl_IdMarca.Text = "Marca";
            // 
            // LblCategoria_Art
            // 
            this.LblCategoria_Art.AutoSize = true;
            this.LblCategoria_Art.Location = new System.Drawing.Point(277, 226);
            this.LblCategoria_Art.Name = "LblCategoria_Art";
            this.LblCategoria_Art.Size = new System.Drawing.Size(52, 13);
            this.LblCategoria_Art.TabIndex = 4;
            this.LblCategoria_Art.Text = "Categoria";
            // 
            // Lbl_ImagenUrl
            // 
            this.Lbl_ImagenUrl.AutoSize = true;
            this.Lbl_ImagenUrl.Location = new System.Drawing.Point(277, 266);
            this.Lbl_ImagenUrl.Name = "Lbl_ImagenUrl";
            this.Lbl_ImagenUrl.Size = new System.Drawing.Size(67, 13);
            this.Lbl_ImagenUrl.TabIndex = 5;
            this.Lbl_ImagenUrl.Text = "Imagen URL";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(277, 315);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(37, 13);
            this.LblPrecio.TabIndex = 6;
            this.LblPrecio.Text = "Precio";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(386, 57);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(163, 20);
            this.TxtCodigo.TabIndex = 7;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(386, 98);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(163, 20);
            this.TxtNombre.TabIndex = 8;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(386, 140);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(163, 20);
            this.TxtDescripcion.TabIndex = 9;
            // 
            // CboMarca
            // 
            this.CboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMarca.FormattingEnabled = true;
            this.CboMarca.Location = new System.Drawing.Point(386, 177);
            this.CboMarca.Name = "CboMarca";
            this.CboMarca.Size = new System.Drawing.Size(163, 21);
            this.CboMarca.TabIndex = 10;
            
            // 
            // CboCategoria
            // 
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(386, 218);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(163, 21);
            this.CboCategoria.TabIndex = 11;
            // 
            // TxtImagenUrl
            // 
            this.TxtImagenUrl.Location = new System.Drawing.Point(386, 259);
            this.TxtImagenUrl.Name = "TxtImagenUrl";
            this.TxtImagenUrl.Size = new System.Drawing.Size(163, 20);
            this.TxtImagenUrl.TabIndex = 12;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(386, 308);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(163, 20);
            this.TxtPrecio.TabIndex = 13;
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress_1);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(250, 366);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(116, 37);
            this.BtnAceptar.TabIndex = 14;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(521, 366);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(116, 37);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmNuevo_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtImagenUrl);
            this.Controls.Add(this.CboCategoria);
            this.Controls.Add(this.CboMarca);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.Lbl_ImagenUrl);
            this.Controls.Add(this.LblCategoria_Art);
            this.Controls.Add(this.Lbl_IdMarca);
            this.Controls.Add(this.LblDescripcion_Art);
            this.Controls.Add(this.LblNombre_Art);
            this.Controls.Add(this.LblCodigo_Art);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmNuevo_Articulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.FrmNuevo_Articulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodigo_Art;
        private System.Windows.Forms.Label LblNombre_Art;
        private System.Windows.Forms.Label LblDescripcion_Art;
        private System.Windows.Forms.Label Lbl_IdMarca;
        private System.Windows.Forms.Label LblCategoria_Art;
        private System.Windows.Forms.Label Lbl_ImagenUrl;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.ComboBox CboMarca;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.TextBox TxtImagenUrl;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}