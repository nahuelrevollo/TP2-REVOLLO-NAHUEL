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
    public partial class FrmLista_Categoria : Form
    {

        private List<Categoria> Lista_c;
        public FrmLista_Categoria()
        {
            InitializeComponent();
        }


        private void CargarGrilla_C()

        {
            Negocio_Categoria Categoria = new Negocio_Categoria();

            try
            {

                Lista_c = Categoria.Listar();

                dgvLista_Categoria.DataSource = Lista_c;

                dgvLista_Categoria.Columns[2].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void FrmLista_Categoria_Load(object sender, EventArgs e)
        {
            CargarGrilla_C();
        }

        private void BtaAgregar_Categoria_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNueva_Categoria frmCategoria = new FrmNueva_Categoria();

                frmCategoria.ShowDialog();

                CargarGrilla_C();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnModificar_Categoria_Click(object sender, EventArgs e)
        {
            Categoria Modificar;

            Modificar = (Categoria)dgvLista_Categoria.CurrentRow.DataBoundItem;

            FrmNueva_Categoria FrmModificar = new FrmNueva_Categoria(Modificar);
            FrmModificar.Text = "Modificar Categoria";

            FrmModificar.ShowDialog();

            CargarGrilla_C();
        }

        private void BtnEliminar_Categoria_Click(object sender, EventArgs e)
        {
            Negocio_Categoria neg_cat = new Negocio_Categoria();

            try
            {
                int ID = ((Categoria)dgvLista_Categoria.CurrentRow.DataBoundItem).ID;

                if (MessageBox.Show("¿Esta seguro que quiere eliminar la categoria seleccionada?", "ATENCION!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                {
                    neg_cat.EliminarCategoria_Logica(ID);

                    if (MessageBox.Show("La Categoria fue eliminada de forma correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)

                    { CargarGrilla_C(); }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Categoria> ListaFiltrada_C;

            try
            {
                if (TxtBusqueda_Categoria.Text == "")
                {
                    ListaFiltrada_C = Lista_c;

                }
                else
                {

                    ListaFiltrada_C = Lista_c.FindAll(k => k.Descripcion.ToLower().Contains(TxtBusqueda_Categoria.Text.ToLower()));

                    dgvLista_Categoria.DataSource = ListaFiltrada_C;

                }

                dgvLista_Categoria.DataSource = ListaFiltrada_C;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }



}
