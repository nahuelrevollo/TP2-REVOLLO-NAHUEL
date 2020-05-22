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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {

            try
            {

                

            FrmLista_Articulos lista = new FrmLista_Articulos();

            lista.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a REV-SOLUTION", "HOLA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnListaMarcas_Click(object sender, EventArgs e)
        {

            try
            {

            FrmLista_Marca Lista_marca = new FrmLista_Marca();

            Lista_marca.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void BtnLista_Categorias_Click(object sender, EventArgs e)
        {
            try
            {

                FrmLista_Categoria Lista_Categoria = new FrmLista_Categoria();

                Lista_Categoria.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



        }
    }
}
