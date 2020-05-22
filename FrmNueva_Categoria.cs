using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace TP_2_REVOLLO_NAHUEL
{
    public partial class FrmNueva_Categoria : Form
    {
        private Categoria Categoria = null;
        public FrmNueva_Categoria()
        {
            InitializeComponent();
        }

        public FrmNueva_Categoria(Categoria categoria)
        {
            InitializeComponent();

            this.Categoria = categoria;
        }

        private void BtnCancelar_Categoria_Click(object sender, EventArgs e)
        {
            try
            {

                Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void BtnAceptar_Categoria_Click(object sender, EventArgs e)
        {
            
            Negocio_Categoria neg_cat = new Negocio_Categoria();

            try
            {
                if (Categoria == null)

                    Categoria = new Marca();

                Categoria.Descripcion = TxtNombre_Categoria.Text;

                if (Categoria.ID != 0)
                {
                    neg_cat.Modificar(Categoria);

                    if (MessageBox.Show("Categoria modificada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Dispose();
                    }

                }

                else

                {
                    neg_cat.Agregar(Categoria);

                    if (MessageBox.Show("Categoria agregada con exito. Desea agregar otro Categoria", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {

                        Dispose();
                    }

                    else
                    {
                        Dispose();
                        FrmNueva_Marca Nuevo = new FrmNueva_Marca();

                        Nuevo.ShowDialog();
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }


        private void FrmNueva_Categoria_Load(object sender, EventArgs e)
        {


            try
            {
                if (Categoria != null)

                {
                    Text = "Modificar";
                    TxtNombre_Categoria.SelectedText = Categoria.Descripcion;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void TxtNombre_Categoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {

                { MessageBox.Show("Por favor ingrese solo letras", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }
        }


        
    }
}
