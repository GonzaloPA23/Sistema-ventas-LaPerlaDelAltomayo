using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaPresentacion.Modales;
namespace CapaPresentacion
{
    public partial class frmBus : Form
    {
        private NChofer nChofer = new NChofer();
        private NBus nBus = new NBus();
        public frmBus()
        {
            InitializeComponent();
            MostrarChoferes(nChofer.ListarChoferes());
            MostrarBuses(nBus.ListarBuses());
            MostrarOpcionesCombo();
        }

        private void MostrarOpcionesCombo()
        {
            foreach (DataGridViewColumn columna in dgBuses.Columns)
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

        private void MostrarChoferes(List<Chofer> choferes)
        {
            cbDniChofer.DataSource = new List<Chofer>();
            cbDniChofer.DataSource = choferes;
            cbDniChofer.DisplayMember = "Dni";
            cbDniChofer.ValueMember = "Id";
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
            lblTotalBuses.Text = buses.Count.ToString();
        }

        private void LimpiarCampos()
        {
            txtMatricula.Text = "";
            nudCantidadAsientos.Value = nudCantidadAsientos.Minimum;
            cbTipoBus.SelectedIndex = 0;
            dtpFechaSalida.Value = DateTime.Now;
            dtpFechaLlegada.Value = DateTime.Now;
            cbDestino.SelectedIndex = 0;
            cbPuntoSalida.SelectedIndex = 0;
            cbDniChofer.SelectedIndex = 0;          
        }

        private void btnCancelarBus_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVerChoferes_Click(object sender, EventArgs e)
        {
            mdChofer mdChofer = new mdChofer();
            mdChofer.Show();
        }

        private void dgBuses_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return; // cabezera del datagridview
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgBuses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgBuses.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtMatricula.Text = dgBuses.Rows[indice].Cells["Matricula"].Value.ToString();
                    nudCantidadAsientos.Value = Convert.ToInt32(dgBuses.Rows[indice].Cells["CantidadAsiento"].Value);
                    cbTipoBus.Text = dgBuses.Rows[indice].Cells["Tipo"].Value.ToString();
                    cbPuntoSalida.Text = dgBuses.Rows[indice].Cells["PuntoSalida"].Value.ToString();
                    cbDestino.Text = dgBuses.Rows[indice].Cells["Destino"].Value.ToString();
                    dtpFechaSalida.Text = dgBuses.Rows[indice].Cells["FechaSalida"].Value.ToString();
                    dtpFechaLlegada.Text = dgBuses.Rows[indice].Cells["FechaLlegada"].Value.ToString();
                    cbDniChofer.SelectedValue = Convert.ToInt32(dgBuses.Rows[indice].Cells["ChoferId"].Value);
                }
            }
        }

        private void btnRegistrarBus_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Bus bus = new Bus()
            {
                ChoferId = Convert.ToInt32(cbDniChofer.SelectedValue),
                Matricula = txtMatricula.Text.Trim().ToUpper(),
                Tipo = cbTipoBus.Text.Trim(),
                CantidadAsiento = Convert.ToInt32(nudCantidadAsientos.Value),
                PuntoSalida = cbPuntoSalida.Text.Trim(),
                Destino = cbDestino.Text.Trim(),
                FechaSalida = dtpFechaSalida.Value,
                FechaLlegada = dtpFechaLlegada.Value,
                PrecioAsiento = nudPrecio.Value,
                AsientosDisponibles = Convert.ToInt32(nudCantidadAsientos.Value)             
            };

            int idbusgenerado = nBus.RegistrarBus(bus, out mensaje);
            if (idbusgenerado > 0)
            {
                MessageBox.Show("Bus registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                MostrarBuses(nBus.ListarBuses());
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = ((OpcionCombo)cbBusqueda.SelectedItem).Valor.ToString();
            if (dgBuses.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgBuses.Rows)
                {
                    if (fila.Cells[filtro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                    {
                        fila.Visible = true;
                    }
                    else fila.Visible = false;
                }
                lblTotalBuses.Text = dgBuses.Rows.Cast<DataGridViewRow>().Count(x => x.Visible).ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            cbBusqueda.SelectedIndex = 0;
            LimpiarCampos();
            MostrarBuses(nBus.ListarBuses());
        }

        private void btnEliminarBus_Click(object sender, EventArgs e)
        {
            // si ha seleccionado el boton de la columna llamado btnSeleccionar, entonces elimina el bus
            if (dgBuses.Columns[dgBuses.CurrentCell.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = dgBuses.CurrentCell.RowIndex;
                if (indice >= 0)
                {
                    int idBus = Convert.ToInt32(dgBuses.Rows[indice].Cells["Id"].Value);
                    nBus.EliminarBus(idBus);
                    MessageBox.Show("Bus eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    MostrarBuses(nBus.ListarBuses());
                }
            }
        }
    }
}
