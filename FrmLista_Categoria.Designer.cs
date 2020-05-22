namespace TP_2_REVOLLO_NAHUEL
{
    partial class FrmLista_Categoria
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
            this.dgvLista_Categoria = new System.Windows.Forms.DataGridView();
            this.BtaAgregar_Categoria = new System.Windows.Forms.Button();
            this.BtnModificar_Categoria = new System.Windows.Forms.Button();
            this.BtnEliminar_Categoria = new System.Windows.Forms.Button();
            this.TxtBusqueda_Categoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista_Categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista_Categoria
            // 
            this.dgvLista_Categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista_Categoria.Location = new System.Drawing.Point(288, 92);
            this.dgvLista_Categoria.Name = "dgvLista_Categoria";
            this.dgvLista_Categoria.Size = new System.Drawing.Size(254, 166);
            this.dgvLista_Categoria.TabIndex = 0;
            // 
            // BtaAgregar_Categoria
            // 
            this.BtaAgregar_Categoria.Location = new System.Drawing.Point(111, 304);
            this.BtaAgregar_Categoria.Name = "BtaAgregar_Categoria";
            this.BtaAgregar_Categoria.Size = new System.Drawing.Size(142, 46);
            this.BtaAgregar_Categoria.TabIndex = 1;
            this.BtaAgregar_Categoria.Text = "Agregar";
            this.BtaAgregar_Categoria.UseVisualStyleBackColor = true;
            this.BtaAgregar_Categoria.Click += new System.EventHandler(this.BtaAgregar_Categoria_Click);
            // 
            // BtnModificar_Categoria
            // 
            this.BtnModificar_Categoria.Location = new System.Drawing.Point(347, 304);
            this.BtnModificar_Categoria.Name = "BtnModificar_Categoria";
            this.BtnModificar_Categoria.Size = new System.Drawing.Size(142, 46);
            this.BtnModificar_Categoria.TabIndex = 2;
            this.BtnModificar_Categoria.Text = "Modificar ";
            this.BtnModificar_Categoria.UseVisualStyleBackColor = true;
            this.BtnModificar_Categoria.Click += new System.EventHandler(this.BtnModificar_Categoria_Click);
            // 
            // BtnEliminar_Categoria
            // 
            this.BtnEliminar_Categoria.Location = new System.Drawing.Point(559, 304);
            this.BtnEliminar_Categoria.Name = "BtnEliminar_Categoria";
            this.BtnEliminar_Categoria.Size = new System.Drawing.Size(142, 46);
            this.BtnEliminar_Categoria.TabIndex = 3;
            this.BtnEliminar_Categoria.Text = "Eliminar";
            this.BtnEliminar_Categoria.UseVisualStyleBackColor = true;
            this.BtnEliminar_Categoria.Click += new System.EventHandler(this.BtnEliminar_Categoria_Click);
            // 
            // TxtBusqueda_Categoria
            // 
            this.TxtBusqueda_Categoria.Location = new System.Drawing.Point(98, 29);
            this.TxtBusqueda_Categoria.Name = "TxtBusqueda_Categoria";
            this.TxtBusqueda_Categoria.Size = new System.Drawing.Size(615, 20);
            this.TxtBusqueda_Categoria.TabIndex = 4;
            this.TxtBusqueda_Categoria.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // FrmLista_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBusqueda_Categoria);
            this.Controls.Add(this.BtnEliminar_Categoria);
            this.Controls.Add(this.BtnModificar_Categoria);
            this.Controls.Add(this.BtaAgregar_Categoria);
            this.Controls.Add(this.dgvLista_Categoria);
            this.Name = "FrmLista_Categoria";
            this.Text = "Listado de Categorias";
            this.Load += new System.EventHandler(this.FrmLista_Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista_Categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista_Categoria;
        private System.Windows.Forms.Button BtaAgregar_Categoria;
        private System.Windows.Forms.Button BtnModificar_Categoria;
        private System.Windows.Forms.Button BtnEliminar_Categoria;
        private System.Windows.Forms.TextBox TxtBusqueda_Categoria;
    }
}