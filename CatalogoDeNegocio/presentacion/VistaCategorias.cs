using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace presentacion
{
    public partial class VistaCategorias : Form
    {
        public VistaCategorias()
        {
            InitializeComponent();
        }

        private void cargarGrillaCategorias()
        {
            CategoriaNegocio categoriaN = new CategoriaNegocio();
            try
            {
                List<Categoria> lista = categoriaN.listar();
                dgvCategorias.DataSource = lista;
                //dGVMarcas.Columns["Nombre"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void VistaCategorias_Load(object sender, EventArgs e)
        {
            cargarGrillaCategorias();
        }

        private void AgregarMarca_Click(object sender, EventArgs e)
        {
            FormCategoria formCategoria = new FormCategoria();
            formCategoria.ShowDialog();

            cargarGrillaCategorias();

        }

        private void EliminarMarca_Click(object sender, EventArgs e)
        {
            Categoria seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            CategoriaNegocio categoriaN = new CategoriaNegocio();

            if (MessageBox.Show("Esta seguro que sea desea eliminar la categoria: " + seleccionado.Nombre + ".", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                categoriaN.eliminar(seleccionado);
            }

            cargarGrillaCategorias();
        }

        private void EditarMarca_Click(object sender, EventArgs e)
        {
            Categoria seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            FormCategoria formCategoria = new FormCategoria(seleccionado);
            formCategoria.ShowDialog();

            cargarGrillaCategorias();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
