using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class FormMarca : Form
    {
        private Marca backupMarca = null;

        public FormMarca()
        {
            InitializeComponent();
        }
        public FormMarca(Marca marca)
        {
            InitializeComponent();
            this.backupMarca = marca;
            Text = "Editar Marca";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void formMarca_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                if (backupMarca != null)
                {
                    txtMarca.Text = backupMarca.Nombre;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void formMarca_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backupMarca == null)
            {
                if ((MessageBox.Show("Si cancela el alta se perderán todos los datos", "Cancelar alta de marca", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                if (txtMarca.Text != "")
                {
                    if (backupMarca == null)
                    {
                        backupMarca = new Marca();
                    }
                    backupMarca.Nombre = txtMarca.Text;
                    if (backupMarca.CodigoMarca == 0)
                    {
                        marcaNegocio.agregar(backupMarca);
                        MessageBox.Show("La marca: " + backupMarca.Nombre + " se agrego correctamente.");
                    }
                    else
                    {
                        marcaNegocio.modificar(backupMarca);
                        MessageBox.Show("La marca: " + backupMarca.Nombre + " se modifico correctamente.");
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
