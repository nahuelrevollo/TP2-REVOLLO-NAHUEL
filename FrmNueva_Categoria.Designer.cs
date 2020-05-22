namespace TP_2_REVOLLO_NAHUEL
{
    partial class FrmNueva_Categoria
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
            this.LblNombre_Categoria = new System.Windows.Forms.Label();
            this.BtnAceptar_Categoria = new System.Windows.Forms.Button();
            this.BtnCancelar_Categoria = new System.Windows.Forms.Button();
            this.TxtNombre_Categoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblNombre_Categoria
            // 
            this.LblNombre_Categoria.AutoSize = true;
            this.LblNombre_Categoria.Location = new System.Drawing.Point(144, 61);
            this.LblNombre_Categoria.Name = "LblNombre_Categoria";
            this.LblNombre_Categoria.Size = new System.Drawing.Size(44, 13);
            this.LblNombre_Categoria.TabIndex = 0;
            this.LblNombre_Categoria.Text = "Nombre";
            // 
            // BtnAceptar_Categoria
            // 
            this.BtnAceptar_Categoria.Location = new System.Drawing.Point(114, 166);
            this.BtnAceptar_Categoria.Name = "BtnAceptar_Categoria";
            this.BtnAceptar_Categoria.Size = new System.Drawing.Size(125, 42);
            this.BtnAceptar_Categoria.TabIndex = 1;
            this.BtnAceptar_Categoria.Text = "Aceptar";
            this.BtnAceptar_Categoria.UseVisualStyleBackColor = true;
            this.BtnAceptar_Categoria.Click += new System.EventHandler(this.BtnAceptar_Categoria_Click);
            // 
            // BtnCancelar_Categoria
            // 
            this.BtnCancelar_Categoria.Location = new System.Drawing.Point(356, 166);
            this.BtnCancelar_Categoria.Name = "BtnCancelar_Categoria";
            this.BtnCancelar_Categoria.Size = new System.Drawing.Size(125, 42);
            this.BtnCancelar_Categoria.TabIndex = 2;
            this.BtnCancelar_Categoria.Text = "Cancelar";
            this.BtnCancelar_Categoria.UseVisualStyleBackColor = true;
            this.BtnCancelar_Categoria.Click += new System.EventHandler(this.BtnCancelar_Categoria_Click);
            // 
            // TxtNombre_Categoria
            // 
            this.TxtNombre_Categoria.Location = new System.Drawing.Point(211, 58);
            this.TxtNombre_Categoria.Name = "TxtNombre_Categoria";
            this.TxtNombre_Categoria.Size = new System.Drawing.Size(175, 20);
            this.TxtNombre_Categoria.TabIndex = 3;
            this.TxtNombre_Categoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_Categoria_KeyPress);
            // 
            // FrmNueva_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 301);
            this.Controls.Add(this.TxtNombre_Categoria);
            this.Controls.Add(this.BtnCancelar_Categoria);
            this.Controls.Add(this.BtnAceptar_Categoria);
            this.Controls.Add(this.LblNombre_Categoria);
            this.MinimumSize = new System.Drawing.Size(632, 340);
            this.Name = "FrmNueva_Categoria";
            this.Text = "Nueva Categoria";
            this.Load += new System.EventHandler(this.FrmNueva_Categoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre_Categoria;
        private System.Windows.Forms.Button BtnAceptar_Categoria;
        private System.Windows.Forms.Button BtnCancelar_Categoria;
        private System.Windows.Forms.TextBox TxtNombre_Categoria;
    }
}