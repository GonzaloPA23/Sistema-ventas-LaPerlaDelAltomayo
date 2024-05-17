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

namespace CapaPresentacion
{
    public partial class frmHistorialPasaje : Form
    {
        private Usuario usuario;
        private NPasaje nPasaje = new NPasaje();
        private NBus nBus = new NBus();
        public frmHistorialPasaje(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            MostrarHistorialPasajes(nPasaje.ListarPasajes(usuario.Id));
            MostrarBuses(nBus.ListarBuses());
            MostrarOpcionesCombo();
        }

        private void MostrarOpcionesCombo()
        {
            foreach (DataGridViewColumn columna in dgPasajes.Columns)
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

        private void frmHistorialPasaje_Load(object sender, EventArgs e)
        {

        }

        private void MostrarHistorialPasajes(List<Pasaje> pasajes)
        {
            dgPasajes.Rows.Clear();
            foreach (Pasaje pasaje in pasajes)
            {
                dgPasajes.Rows.Add(new object[] { "00" + pasaje.Id, pasaje.UsuarioId, pasaje.BusId, pasaje.Asiento, pasaje.Piso, pasaje.FechaCompra });
            }
            lblTotalPasajes.Text = pasajes.Count.ToString();
        }

        private void MostrarBuses(List<Bus> buses)
        {
            dgBuses.Rows.Clear();
            foreach (Bus bus in buses)
            {
                dgBuses.Rows.Add(new object[] { "", bus.Id, bus.ChoferId, bus.Matricula,bus.Tipo,bus.CantidadAsiento, bus.AsientosDisponibles,
                    bus.PuntoSalida, bus.Destino, bus.FechaSalida.ToString("yyyy-MM-dd HH:mm"),
                    bus.FechaLlegada.ToString("yyyy-MM-dd HH:mm"),"S/." + bus.PrecioAsiento});
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpiar filtros de búsqueda y mostrar todos los pasajes
            MostrarHistorialPasajes(nPasaje.ListarPasajes(usuario.Id));
            cbBusqueda.SelectedIndex = -1;
            tbBusqueda.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Validacion del textbox vacio
            if (tbBusqueda.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un valor para buscar", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filtro = ((OpcionCombo)cbBusqueda.SelectedItem).Valor.ToString();
            if (dgPasajes.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgPasajes.Rows)
                {
                    if (fila.Cells[filtro].Value.ToString().Trim().ToUpper().Contains(tbBusqueda.Text.Trim().ToUpper()))
                    {
                        fila.Visible = true;
                    }
                    else fila.Visible = false;
                }
                lblTotalPasajes.Text = dgPasajes.Rows.Cast<DataGridViewRow>().Count(x => x.Visible).ToString();
            }
        }
    }    
}

