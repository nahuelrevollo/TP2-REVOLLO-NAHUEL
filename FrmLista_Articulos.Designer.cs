namespace TP_2_REVOLLO_NAHUEL
{
    partial class FrmLista_Articulos
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
            this.DgvLista_Articulos = new System.Windows.Forms.DataGridView();
            this.pic_Articulo = new System.Windows.Forms.PictureBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista_Articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Articulo)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLista_Articulos
            // 
            this.DgvLista_Articulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvLista_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista_Articulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvLista_Articulos.Location = new System.Drawing.Point(12, 12);
            this.DgvLista_Articulos.MinimumSize = new System.Drawing.Size(848, 221);
            this.DgvLista_Articulos.MultiSelect = false;
            this.DgvLista_Articulos.Name = "DgvLista_Articulos";
            this.DgvLista_Articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista_Articulos.Size = new System.Drawing.Size(848, 221);
            this.DgvLista_Articulos.TabIndex = 0;
            this.DgvLista_Articulos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvLista_Articulos_MouseClick);
            // 
            // pic_Articulo
            // 
            this.pic_Articulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Articulo.Location = new System.Drawing.Point(521, 250);
            this.pic_Articulo.Name = "pic_Articulo";
            this.pic_Articulo.Size = new System.Drawing.Size(339, 205);
            this.pic_Articulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Articulo.TabIndex = 1;
            this.pic_Articulo.TabStop = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(21, 332);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(132, 48);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(192, 332);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(132, 48);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(367, 332);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(132, 48);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(34, 267);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(449, 20);
            this.TxtBusqueda.TabIndex = 5;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            
            // 
            // FrmLista_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 456);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.pic_Articulo);
            this.Controls.Add(this.DgvLista_Articulos);
            this.Name = "FrmLista_Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de articulos";
            this.Load += new System.EventHandler(this.FrmLista_Articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista_Articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Articulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLista_Articulos;
        private System.Windows.Forms.PictureBox pic_Articulo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TxtBusqueda;
    }
}