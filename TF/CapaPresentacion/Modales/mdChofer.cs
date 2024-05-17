using CapaDatos;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdChofer : Form
    {
        private NChofer nChofer = new NChofer();
        public mdChofer()
        {
            InitializeComponent();
            MostrarChoferes(nChofer.ListarChoferes());
            MostrarOpcionesCombo();
        }
        private void MostrarChoferes(List<Chofer> choferes)
        {
            dgChoferes.Rows.Clear();
            foreach (Chofer chofer in choferes)
            {
                dgChoferes.Rows.Add(new object[] { "", chofer.Id, chofer.Dni, chofer.Nombre,
                    chofer.Apellido, chofer.Celular, chofer.Correo,
                    chofer.FechaNacimiento.ToString("yyyy-MM-dd") });
            }           
        }

        private void MostrarOpcionesCombo()
        {
            foreach (DataGridViewColumn columna in dgChoferes.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cbBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbBusqueda.DisplayMember = "Texto"; // Lo que se muestra
            cbBusqueda.ValueMember = "Valor"; // Lo que vale
            cbBusqueda.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = ((OpcionCombo)cbBusqueda.SelectedItem).Valor.ToString();
            if (dgChoferes.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgChoferes.Rows)
                {
                    if (fila.Cells[filtro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                    {
                        fila.Visible = true;
                    }
                    else fila.Visible = false;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            cbBusqueda.SelectedIndex = 0;
            foreach (DataGridViewRow fila in dgChoferes.Rows)
            {
                fila.Visible = true;
            }
        }
    }
}
