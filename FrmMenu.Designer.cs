namespace TP_2_REVOLLO_NAHUEL
{
    partial class FrmMenu
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnListaMarcas = new System.Windows.Forms.Button();
            this.BtnLista_Categorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(288, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(144, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SELECCIONE UNA OPCION";
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(273, 140);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(170, 37);
            this.BtnListar.TabIndex = 1;
            this.BtnListar.Text = "Lista de articulos";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnListaMarcas
            // 
            this.BtnListaMarcas.Location = new System.Drawing.Point(273, 209);
            this.BtnListaMarcas.Name = "BtnListaMarcas";
            this.BtnListaMarcas.Size = new System.Drawing.Size(170, 37);
            this.BtnListaMarcas.TabIndex = 2;
            this.BtnListaMarcas.Text = "Lista de Marcas";
            this.BtnListaMarcas.UseVisualStyleBackColor = true;
            this.BtnListaMarcas.Click += new System.EventHandler(this.BtnListaMarcas_Click);
            // 
            // BtnLista_Categorias
            // 
            this.BtnLista_Categorias.Location = new System.Drawing.Point(273, 281);
            this.BtnLista_Categorias.Name = "BtnLista_Categorias";
            this.BtnLista_Categorias.Size = new System.Drawing.Size(170, 37);
            this.BtnLista_Categorias.TabIndex = 3;
            this.BtnLista_Categorias.Text = "Lista de Categorias";
            this.BtnLista_Categorias.UseVisualStyleBackColor = true;
            this.BtnLista_Categorias.Click += new System.EventHandler(this.BtnLista_Categorias_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLista_Categorias);
            this.Controls.Add(this.BtnListaMarcas);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnListaMarcas;
        private System.Windows.Forms.Button BtnLista_Categorias;
    }
}