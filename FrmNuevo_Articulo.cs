using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TP_2_REVOLLO_NAHUEL
{
    public partial class FrmNuevo_Articulo : Form
    {

        private Articulo Articulo = null;

        public FrmNuevo_Articulo()
        {
            InitializeComponent();
        }

        public FrmNuevo_Articulo(Articulo Articulo)
        
        {
            InitializeComponent();
            this.Articulo = Articulo;
        }

            private void BtnCancelar_Click(object sender, EventArgs e)
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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
           

            Negocio_articulo neg_art = new Negocio_articulo();


            try 
            {
                if (Articulo == null)
                    Articulo = new Articulo();


                Articulo.Codigo = TxtCodigo.Text.Trim();
                Articulo.Nombre = TxtNombre.Text.Trim();
                Articulo.Descripcion = TxtDescripcion.Text.Trim();
                Articulo.Marca = (Marca)CboMarca.SelectedItem;
                Articulo.Categoria = (Categoria)CboCategoria.SelectedItem;                
                Articulo.Imagen_Url = TxtImagenUrl.Text.Trim();
                Articulo.Precio = Convert.ToDecimal(TxtPrecio.Text.Trim());

                if (Articulo.ID != 0)

                { neg_art.Modificar(Articulo);

                    if(MessageBox.Show("Articulo modifficado con exito", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information)==DialogResult.OK)

                    {

                        Dispose();

                    }
                
                
                }

                else

                {
                    neg_art.Agregar(Articulo);



                    if (MessageBox.Show("Articulo agregado con exito. Desea agregar otro articulo", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {

                        Dispose();
                    }

                    else
                    {
                        Dispose();
                        FrmNuevo_Articulo Nuevo = new FrmNuevo_Articulo();

                        Nuevo.ShowDialog();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmNuevo_Articulo_Load(object sender, EventArgs e)
        {
            Negocio_Marca marca = new Negocio_Marca();
            Negocio_Categoria categoria = new Negocio_Categoria();

            try
            {                
                    CboMarca.DataSource = marca.Listar();
                    CboMarca.ValueMember = "Id";
                    CboMarca.DisplayMember = "Descripcion";
                    CboMarca.SelectedIndex = -1;                   

                    CboCategoria.DataSource = categoria.Listar();
                    CboCategoria.ValueMember = "Id";
                    CboCategoria.DisplayMember = "Descripcion";
                    CboCategoria.SelectedIndex = -1;

                if (Articulo != null)
                {

                    Text = "Modificar";
                    TxtCodigo.Text = Articulo.Codigo;
                    TxtNombre.Text = Articulo.Nombre;
                    TxtDescripcion.Text = Articulo.Descripcion;
                    TxtImagenUrl.Text = Articulo.Imagen_Url;
                    TxtPrecio.Text = Convert.ToString(Articulo.Precio);

                     CboMarca.SelectedValue = Articulo.Marca.ID; 
                     CboCategoria.SelectedValue = Articulo.Categoria.ID; 

                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        
        

        private void TxtPrecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if(!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            { MessageBox.Show("Por favor ingrese solo numeros", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar))&& (e.KeyChar != (char)Keys.Back))

            {

                { MessageBox.Show("Por favor ingrese solo letras", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }
        }
       
        //ACA INTENTE VALIDAR EL COMBO BOX PERO NO PUDE
       /* private void CboMarca_KeyUp(object sender, KeyEventArgs e)

        {

        if  (CboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("por favor elija una opcion");
                CboMarca.BackColor = Color.Red; }
        else
            { CboMarca.BackColor = Color.White; }
        }*/
    }
}
