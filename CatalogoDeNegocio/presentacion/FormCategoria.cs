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
    public partial class FormCategoria : Form
    {
        private Categoria backupCategoria = null;

        public FormCategoria()
        {
            InitializeComponent();
        }

        public FormCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.backupCategoria = categoria;
            Text = "Editar Categoria";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                if (backupCategoria!= null)
                {
                    txtCategoria.Text = backupCategoria.Nombre;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FormCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backupCategoria == null)
            {
                if ((MessageBox.Show("Si cancela el alta se perderán todos los datos", "Cancelar alta de categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                if (txtCategoria.Text != "")
                {
                    if (backupCategoria == null)
                    {
                        backupCategoria = new Categoria();
                    }
                    backupCategoria.Nombre = txtCategoria.Text;
                    if (backupCategoria.CodigoCategoria == 0)
                    {
                        categoriaNegocio.agregar(backupCategoria);
                        MessageBox.Show("La categoria: " + backupCategoria.Nombre + " se agrego correctamente.");
                    }
                    else
                    {
                        categoriaNegocio.modificar(backupCategoria);
                        MessageBox.Show("La categoria: " + backupCategoria.Nombre + " se modifico correctamente.");
                    }
                    Close();

                }
                else
                {
                    MessageBox.Show("Debe ingresar un nombre correcto.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
