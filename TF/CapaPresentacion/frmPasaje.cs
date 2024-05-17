using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;
using CapaPresentacion.Utilidades;
using System.Windows.Documents;

namespace CapaPresentacion
{
    public partial class frmPasaje : Form
    {
        private NBus nBus = new NBus();
        private Usuario usuario;
        private NPasaje nPasaje = new NPasaje();

        public frmPasaje(Usuario usuario)
        {
            InitializeComponent();
            MostrarBuses(nBus.ListarBuses());
            this.usuario = usuario;
        }

        private void frmPasaje_Load(object sender, EventArgs e)
        {

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

        private void dgBuses_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgBuses.Columns[dgBuses.CurrentCell.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = dgBuses.CurrentCell.RowIndex;
                if (indice >= 0)
                {
                    int cantAsientos = Convert.ToInt32(dgBuses.Rows[indice].Cells[5].Value);
                    if (cantAsientos == 64)
                    {
                        // lo tengo en una carpeta imagenes dentro de la capaPresentacion osea la actual capa
                        pbAsientos.BackgroundImage = global::CapaPresentacion.Properties.Resources.asientos_columnas81;
                        pbAsientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        // cada vez que se selecciona un bus se elimnara el valor 9 del combobox si es que existe
                        if (cbColumnaAsiento.Items.Contains("9"))
                        {
                            cbColumnaAsiento.Items.Remove("9");
                        }
                    }
                    else
                    {
                        pbAsientos.BackgroundImage = global::CapaPresentacion.Properties.Resources.asientos_columnas9;
                        pbAsientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        // cada vez que se selecciona un bus se añadira el valor 9 del combobox si es que no existe
                        if (!cbColumnaAsiento.Items.Contains("9"))
                        {
                            cbColumnaAsiento.Items.Add("9");
                        }
                    }
                }
                lblPrecioPasaje.Text = dgBuses.Rows[indice].Cells[11].Value.ToString();
            }
        }

        private void dgBuses_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void cbPuntoSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPuntoSalida.SelectedIndex != -1)
            {
                cbDestino.Enabled = false;
                cbTipoBus.Enabled = false;
                dtpFechaSalida.Enabled = false;
                MostrarBuses(nBus.ListarBusesPorPuntoSalida(cbPuntoSalida.SelectedItem.ToString()));
            }else
            {
                cbDestino.Enabled = true;
                cbTipoBus.Enabled = true;
                dtpFechaSalida.Enabled = true;
                MostrarBuses(nBus.ListarBuses());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbPuntoSalida.SelectedIndex = -1;
            cbDestino.SelectedIndex = -1;
            dtpFechaSalida.Value = DateTime.Now;
            cbTipoBus.SelectedIndex = -1;
            MostrarBuses(nBus.ListarBuses());
            cbPuntoSalida.Enabled = true;
            cbDestino.Enabled = true;
            cbTipoBus.Enabled = true;
            dtpFechaSalida.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarBuses(nBus.ListarBuses());
            nudPiso.Value = 1;
            cbFilaAsiento.SelectedIndex = -1;
            cbColumnaAsiento.SelectedIndex = -1;
            lblPrecioPasaje.Text = "S/. 0.00";
        }

        private void cbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDestino.SelectedIndex == -1)
            {
                cbPuntoSalida.Enabled = true;
                cbTipoBus.Enabled = true;
                dtpFechaSalida.Enabled = true;
                MostrarBuses(nBus.ListarBuses());
            }
            else {         
                cbPuntoSalida.Enabled = false;
                cbTipoBus.Enabled = false;
                dtpFechaSalida.Enabled = false;
                MostrarBuses(nBus.ListarBusesPorDestino(cbDestino.SelectedItem.ToString()));
            }
        }

        private void cbTipoBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoBus.SelectedIndex == -1)
            {
                cbPuntoSalida.Enabled = true;
                cbDestino.Enabled = true;
                dtpFechaSalida.Enabled = true;
                MostrarBuses(nBus.ListarBuses());
            }
            else
            {
                cbPuntoSalida.Enabled = false;
                cbDestino.Enabled = false;
                dtpFechaSalida.Enabled = false;
                MostrarBuses(nBus.ListarBusesPorTipo(cbTipoBus.SelectedItem.ToString()));
            }
        }

        private void dtpFechaSalida_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaSalida.Value == DateTime.Now)
            {
                cbPuntoSalida.Enabled = true;
                cbDestino.Enabled = true;
                cbTipoBus.Enabled = true;
                MostrarBuses(nBus.ListarBuses());
            }
            else
            {
                cbPuntoSalida.Enabled = false;
                cbDestino.Enabled = false;
                cbTipoBus.Enabled = false;
                MostrarBuses(nBus.ListarBusesPorFechaSalida(dtpFechaSalida.Value));
            }
        }

        private void btnConfirmarViaje_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Validar que se haya seleccionado la celda btnSeleccionar de un bus
            if (dgBuses.Columns[dgBuses.CurrentCell.ColumnIndex].Name != "btnSeleccionar")
            {
                MessageBox.Show("Seleccione un bus", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int indice = dgBuses.CurrentCell.RowIndex;
            // Validar que se seleccione el piso, la fila y la columna del asiento
            if (cbFilaAsiento.SelectedIndex == -1 || cbColumnaAsiento.SelectedIndex == -1 || nudPiso.Value == 0)
            {
                MessageBox.Show("Seleccione un asiento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Crear el objeto pasaje
            Pasaje pasaje = new Pasaje()
            {
                UsuarioId = usuario.Id,
                BusId = Convert.ToInt32(dgBuses.Rows[indice].Cells[1].Value),
                Asiento = cbFilaAsiento.SelectedItem.ToString() + cbColumnaAsiento.SelectedItem.ToString(),
                Piso = Convert.ToInt32(nudPiso.Value)
            };
            int idPasaje = nPasaje.RegistrarPasaje(pasaje, out mensaje);
            if (idPasaje > 0)
            {
                MessageBox.Show("Pasaje registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nBus.ActualizarBus(Convert.ToInt32(dgBuses.Rows[indice].Cells[1].Value));
                MostrarBuses(nBus.ListarBuses());
                nudPiso.Value = 1;
                cbFilaAsiento.SelectedIndex = -1;
                cbColumnaAsiento.SelectedIndex = -1;
                lblPrecioPasaje.Text = "S/. 0.00";
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
