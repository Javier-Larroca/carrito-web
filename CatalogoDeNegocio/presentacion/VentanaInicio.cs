using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class VentanaInicio : Form
    {
        public int tiempoRestante { get; set; }
        public VentanaInicio()
        {
            InitializeComponent();
        }

        private void VentanaInicio_Load(object sender, EventArgs e)
        {
            tiempoRestante = 3;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante > 0)
                tiempoRestante = tiempoRestante - 1;
            else
            {
                timer1.Stop();
                new VentanaPrincipal().Show();
                this.Hide();
            }

        }
    }
}
