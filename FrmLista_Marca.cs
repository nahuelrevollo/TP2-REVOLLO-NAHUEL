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
    public partial class FrmLista_Marca : Form
    {
        private List<Marca> Lista_m;
        public FrmLista_Marca()
        {
            InitializeComponent();
        }

        private void CargarGrilla_M()

        {
            Negocio_Marca Marca = new Negocio_Marca();

            try
            {

                Lista_m = Marca.Listar();

                DgvLista_Marcas.DataSource = Lista_m;

                DgvLista_Marcas.Columns[2].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        
        }

        private void FrmLista_Marca_Load(object sender, EventArgs e)
        {


            CargarGrilla_M();

        }

        private void BtnAgregar_M_Click(object sender, EventArgs e)
        {

            try
            {
            FrmNueva_Marca frmMarca = new FrmNueva_Marca();

            frmMarca.ShowDialog();

                CargarGrilla_M();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



        }

        private void BtnModificar_Marca_Click(object sender, EventArgs e)
        {
            Marca Modificar;

            Modificar = (Marca)DgvLista_Marcas.CurrentRow.DataBoundItem;

            FrmNueva_Marca FrmModificar = new FrmNueva_Marca(Modificar);
            FrmModificar.Text = "Modificar Marca";

            FrmModificar.ShowDialog();

            CargarGrilla_M();




        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Negocio_Marca neg_marca = new Negocio_Marca();

            try
            {
                int ID = ((Marca)DgvLista_Marcas.CurrentRow.DataBoundItem).ID;

                if (MessageBox.Show("¿Esta seguro que quiere eliminar la marca seleccionada?", "ATENCION!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                {
                    neg_marca.EliminarMarca_Logica(ID);

                    if (MessageBox.Show("La marca fue eliminadao de forma correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)

                    { CargarGrilla_M(); }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void TxtBusqueda_Marca_TextChanged(object sender, EventArgs e)
        {

            List<Marca> ListaFiltrada_M;

            try
            {
                if (TxtBusqueda_Marca.Text == "")
                {
                    ListaFiltrada_M = Lista_m;

                }
                else
                {

                    ListaFiltrada_M = Lista_m.FindAll(k => k.Descripcion.ToLower().Contains(TxtBusqueda_Marca.Text.ToLower()));
                    
                    DgvLista_Marcas.DataSource = ListaFiltrada_M;

                }

                DgvLista_Marcas.DataSource = ListaFiltrada_M;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
    }
}
