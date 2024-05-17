using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciarSesionMP_Click(object sender, EventArgs e)
        {
            frmIniciarSesion frmIniciarSesion = new frmIniciarSesion();
            frmIniciarSesion.Show();
            this.Hide();
            frmIniciarSesion.FormClosing += FrmClosing;
        }

        private void btnRegistrarseMP_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Show();
            this.Hide();
            frmRegistro.FormClosing += FrmClosing;
        }

        private void FrmClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
