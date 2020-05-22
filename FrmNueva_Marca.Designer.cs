namespace TP_2_REVOLLO_NAHUEL
{
    partial class FrmNueva_Marca
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
            this.LblNombre_Marca = new System.Windows.Forms.Label();
            this.TxtNombre_Marca = new System.Windows.Forms.TextBox();
            this.BtnAceptar_Marca = new System.Windows.Forms.Button();
            this.BtnCancelar_Marca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNombre_Marca
            // 
            this.LblNombre_Marca.AutoSize = true;
            this.LblNombre_Marca.Location = new System.Drawing.Point(125, 88);
            this.LblNombre_Marca.Name = "LblNombre_Marca";
            this.LblNombre_Marca.Size = new System.Drawing.Size(44, 13);
            this.LblNombre_Marca.TabIndex = 0;
            this.LblNombre_Marca.Text = "Nombre";
            // 
            // TxtNombre_Marca
            // 
            this.TxtNombre_Marca.Location = new System.Drawing.Point(238, 85);
            this.TxtNombre_Marca.Name = "TxtNombre_Marca";
            this.TxtNombre_Marca.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre_Marca.TabIndex = 1;
            this.TxtNombre_Marca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_Marca_KeyPress);
            // 
            // BtnAceptar_Marca
            // 
            this.BtnAceptar_Marca.Location = new System.Drawing.Point(90, 157);
            this.BtnAceptar_Marca.Name = "BtnAceptar_Marca";
            this.BtnAceptar_Marca.Size = new System.Drawing.Size(95, 43);
            this.BtnAceptar_Marca.TabIndex = 2;
            this.BtnAceptar_Marca.Text = "Aceptar";
            this.BtnAceptar_Marca.UseVisualStyleBackColor = true;
            this.BtnAceptar_Marca.Click += new System.EventHandler(this.BtnAceptar_Marca_Click);
            // 
            // BtnCancelar_Marca
            // 
            this.BtnCancelar_Marca.Location = new System.Drawing.Point(270, 157);
            this.BtnCancelar_Marca.Name = "BtnCancelar_Marca";
            this.BtnCancelar_Marca.Size = new System.Drawing.Size(95, 43);
            this.BtnCancelar_Marca.TabIndex = 3;
            this.BtnCancelar_Marca.Text = "Cancelar";
            this.BtnCancelar_Marca.UseVisualStyleBackColor = true;
            this.BtnCancelar_Marca.Click += new System.EventHandler(this.BtnCancelar_Marca_Click);
            // 
            // FrmNueva_Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 271);
            this.Controls.Add(this.BtnCancelar_Marca);
            this.Controls.Add(this.BtnAceptar_Marca);
            this.Controls.Add(this.TxtNombre_Marca);
            this.Controls.Add(this.LblNombre_Marca);
            this.MinimumSize = new System.Drawing.Size(502, 310);
            this.Name = "FrmNueva_Marca";
            this.Text = "Nueva Marca";
            this.Load += new System.EventHandler(this.FrmNueva_Marca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre_Marca;
        private System.Windows.Forms.TextBox TxtNombre_Marca;
        private System.Windows.Forms.Button BtnAceptar_Marca;
        private System.Windows.Forms.Button BtnCancelar_Marca;
    }
}