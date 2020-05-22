using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TP_2_REVOLLO_NAHUEL
{
    public partial class FrmLista_Articulos : Form
    {
        private List<Articulo> Lista;
        public FrmLista_Articulos()
        {
            InitializeComponent();
        }

        private void FrmLista_Articulos_Load(object sender, EventArgs e)
        {

            CargarGrilla();

        }

        private void CargarGrilla()
        {
         Negocio_articulo negocio = new Negocio_articulo();
            try
            {

                Lista = negocio.listar();

                DgvLista_Articulos.DataSource = Lista;


                DgvLista_Articulos.Columns[6].Visible = false;



                DgvLista_Articulos.Columns[8].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());


            }

            //finally { Dispose(); }

        }

        private void DgvLista_Articulos_MouseClick(object sender, MouseEventArgs e)
        {
            
                Articulo art = new Articulo();

                art = (Articulo)DgvLista_Articulos.CurrentRow.DataBoundItem;
                pic_Articulo.Load(art.Imagen_Url);
            
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                FrmNuevo_Articulo Nuevo = new FrmNuevo_Articulo();

                Nuevo.ShowDialog();

                CargarGrilla();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            Articulo Modificar;

            Modificar = (Articulo)DgvLista_Articulos.CurrentRow.DataBoundItem;

            FrmNuevo_Articulo FrmModificar = new FrmNuevo_Articulo(Modificar);
            FrmModificar.Text = "Modificar Articulo";

            FrmModificar.ShowDialog();

            CargarGrilla();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Negocio_articulo Negocio = new Negocio_articulo();


            try
            {
                
                int ID = ((Articulo)DgvLista_Articulos.CurrentRow.DataBoundItem).ID;

                if (MessageBox.Show("¿Esta seguro que quiere eliminar el articulo seleccionado?", "ATENCION!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                {
                    Negocio.EliminarArticulo_Logica(ID);

                    if (MessageBox.Show("Se elimino de forma correcta el Articulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)

                    { CargarGrilla(); }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        
        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {

            List<Articulo>  ListaFiltrada;

            try
            {
                if(TxtBusqueda.Text == "")
                {
                    ListaFiltrada = Lista;

                }
                else
                {

                 ListaFiltrada = Lista.FindAll(k => k.Nombre.ToLower().Contains(TxtBusqueda.Text.ToLower()) 
                 || k.Marca.Descripcion.ToLower().Contains(TxtBusqueda.Text.ToLower()) 
                 || k.Categoria.Descripcion.ToLower().Contains(TxtBusqueda.Text.ToLower()));
                    DgvLista_Articulos.DataSource = ListaFiltrada;

                }

                    DgvLista_Articulos.DataSource = ListaFiltrada;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            } 

        }
    }
}
