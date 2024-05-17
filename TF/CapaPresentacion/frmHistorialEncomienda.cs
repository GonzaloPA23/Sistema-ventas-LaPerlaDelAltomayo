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

namespace CapaPresentacion
{
    public partial class frmHistorialEncomienda : Form
    {
        private Usuario usuario;
        private NEncomienda nEncomienda = new NEncomienda();
        public frmHistorialEncomienda(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            MostraristorialEncomiendas(nEncomienda.ListarEncomiendas(usuario.Id)); 
            
        }

        private void MostraristorialEncomiendas(List<Encomienda> encomiendas)
        {
            dgHistorialEncomiendas.Rows.Clear();
            foreach (Encomienda enc in encomiendas)
            {                
                dgHistorialEncomiendas.Rows.Add(new object[] {"","00"+enc.Id,enc.UsuarioId, enc.Destino, enc.PuntoSalida, enc.FechaEnvio, enc.FechaLlegada, enc.TipoProducto,
                    enc.Peso,enc.Largo, enc.Alto, enc.Ancho, "S/."+enc.Precio, enc.FechaPedido});                               
            }
            lblTotalEncomiendas.Text = encomiendas.Count.ToString();
        }

        private void dgHistorialEncomiendas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbDestino.SelectedIndex = -1;
            cbFechaPedido.SelectedIndex = -1;
            MostraristorialEncomiendas(nEncomienda.ListarEncomiendas(usuario.Id));
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un destino o una fecha de pedido
            if (cbDestino.SelectedIndex == -1 && cbFechaPedido.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un destino o una fecha de pedido", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbDestino.SelectedIndex != -1 && cbFechaPedido.SelectedIndex != -1)
            {
                MessageBox.Show("Debe seleccionar solo un destino o una fecha de pedido", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbDestino.SelectedIndex != -1)MostraristorialEncomiendas(nEncomienda.ListarEncomiendasPorDestino(usuario.Id, cbDestino.SelectedItem.ToString()));
            else MostraristorialEncomiendas(nEncomienda.ListarEncomiendasPorFechaPedido(usuario.Id, cbFechaPedido.SelectedItem.ToString()));            
        }
    }
}
