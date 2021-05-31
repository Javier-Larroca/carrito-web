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
    public partial class VistaMarcas : Form
    {
        public VistaMarcas()
        {
            InitializeComponent();
        }

        private void cargarGrillaMarcas()
        {
            MarcaNegocio marcaN = new MarcaNegocio();
            try
            {
                List<Marca> lista = marcaN.listar();
                dgvMarcas.DataSource = lista;
                //dGVMarcas.Columns["Nombre"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void VistaMarcas_Load(object sender, EventArgs e)
        {
            cargarGrillaMarcas();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarMarca_Click(object sender, EventArgs e)
        {
            FormMarca formMarca = new FormMarca();
            formMarca.ShowDialog();

            cargarGrillaMarcas();
        }

        private void EditarMarca_Click(object sender, EventArgs e)
        {
            Marca seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            FormMarca formMarca = new FormMarca(seleccionado);
            formMarca.ShowDialog();

            cargarGrillaMarcas();
        }

        private void EliminarMarca_Click(object sender, EventArgs e)
        {
            Marca seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            MarcaNegocio marcaN = new MarcaNegocio();
            
            if(MessageBox.Show("Esta seguro que sea desea eliminar la marca: " + seleccionado.Nombre + ".", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                marcaN.eliminar(seleccionado);
            }

            cargarGrillaMarcas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
