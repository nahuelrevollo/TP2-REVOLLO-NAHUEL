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
    public partial class FrmNueva_Marca : Form
    {
        private Marca Marca = null;
        public FrmNueva_Marca()
        {
            InitializeComponent();
        }

        public FrmNueva_Marca(Marca marca)
        {
            InitializeComponent();

            this.Marca = marca;
        }

        private void BtnCancelar_Marca_Click(object sender, EventArgs e)
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

        private void BtnAceptar_Marca_Click(object sender, EventArgs e)
        {

            Negocio_Marca neg_marca = new Negocio_Marca();

            try
            {
                if(Marca==null)

                Marca = new Marca();

                    Marca.Descripcion = TxtNombre_Marca.Text;

                if(Marca.ID!=0)
                {
                    neg_marca.Modificar(Marca);

                    if(MessageBox.Show("Marca modifficada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Dispose();
                    }

                }

                else 
                
                {
                    neg_marca.Agregar(Marca);

                    if (MessageBox.Show("Marca agregada con exito. Desea agregar otro articulo", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
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

        private void FrmNueva_Marca_Load(object sender, EventArgs e)
        {
            try
            {
                

                if (Marca !=null)

                {
                    Text = "Modificar";
                    TxtNombre_Marca.SelectedText = Marca.Descripcion;
                    

                    



                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void TxtNombre_Marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {

                { MessageBox.Show("Por favor ingrese solo letras", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }
        }
    }
}
