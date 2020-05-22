namespace TP_2_REVOLLO_NAHUEL
{
    partial class FrmLista_Marca
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
            this.DgvLista_Marcas = new System.Windows.Forms.DataGridView();
            this.BtnAgregar_M = new System.Windows.Forms.Button();
            this.BtnModificar_Marca = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtBusqueda_Marca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista_Marcas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLista_Marcas
            // 
            this.DgvLista_Marcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvLista_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista_Marcas.Location = new System.Drawing.Point(256, 86);
            this.DgvLista_Marcas.Name = "DgvLista_Marcas";
            this.DgvLista_Marcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista_Marcas.Size = new System.Drawing.Size(283, 179);
            this.DgvLista_Marcas.TabIndex = 0;
            // 
            // BtnAgregar_M
            // 
            this.BtnAgregar_M.Location = new System.Drawing.Point(89, 292);
            this.BtnAgregar_M.Name = "BtnAgregar_M";
            this.BtnAgregar_M.Size = new System.Drawing.Size(153, 43);
            this.BtnAgregar_M.TabIndex = 1;
            this.BtnAgregar_M.Text = "Agregar";
            this.BtnAgregar_M.UseVisualStyleBackColor = true;
            this.BtnAgregar_M.Click += new System.EventHandler(this.BtnAgregar_M_Click);
            // 
            // BtnModificar_Marca
            // 
            this.BtnModificar_Marca.Location = new System.Drawing.Point(315, 292);
            this.BtnModificar_Marca.Name = "BtnModificar_Marca";
            this.BtnModificar_Marca.Size = new System.Drawing.Size(153, 43);
            this.BtnModificar_Marca.TabIndex = 2;
            this.BtnModificar_Marca.Text = "Modificar";
            this.BtnModificar_Marca.UseVisualStyleBackColor = true;
            this.BtnModificar_Marca.Click += new System.EventHandler(this.BtnModificar_Marca_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(546, 292);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(153, 43);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtBusqueda_Marca
            // 
            this.TxtBusqueda_Marca.Location = new System.Drawing.Point(134, 35);
            this.TxtBusqueda_Marca.Name = "TxtBusqueda_Marca";
            this.TxtBusqueda_Marca.Size = new System.Drawing.Size(510, 20);
            this.TxtBusqueda_Marca.TabIndex = 4;
            this.TxtBusqueda_Marca.TextChanged += new System.EventHandler(this.TxtBusqueda_Marca_TextChanged);
            // 
            // FrmLista_Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBusqueda_Marca);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar_Marca);
            this.Controls.Add(this.BtnAgregar_M);
            this.Controls.Add(this.DgvLista_Marcas);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmLista_Marca";
            this.Text = "Listado de marcas";
            this.Load += new System.EventHandler(this.FrmLista_Marca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista_Marcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLista_Marcas;
        private System.Windows.Forms.Button BtnAgregar_M;
        private System.Windows.Forms.Button BtnModificar_Marca;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TxtBusqueda_Marca;
    }
}