using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmEncomienda : Form
    {
        private NEncomienda nEncomienda = new NEncomienda();
        private Usuario usuario;
        public frmEncomienda(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void LimpiarCampos()       
        { 
            cbPuntoSalida.SelectedIndex = -1;
            cbDestino.SelectedIndex = -1;
            dtpFechaEnvio.Value = DateTime.Now;
            cbTipoEncomienda.SelectedIndex = -1;
            nudPeso.Value = nudPeso.Minimum;
            nudAncho.Value = nudAncho.Minimum;
            nudAlto.Value = nudAlto.Minimum;
            nudLargo.Value = nudLargo.Minimum;
            checkbAutorizacion1.Checked = false;
            checkbAutorizacion2.Checked = false;
        }

        private void btnCancelarEncomienda_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnConfirmarEncomienda_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            // Validar que se hayan seleccionado ambos checkbox
            if (!checkbAutorizacion1.Checked || !checkbAutorizacion2.Checked)
            {
                MessageBox.Show("Debe aceptar los términos y condiciones", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Creacion de objeto encomienda
            Encomienda encomienda = new Encomienda()
            {
                UsuarioId = usuario.Id,
                PuntoSalida = cbPuntoSalida.SelectedItem.ToString(),
                Destino = cbDestino.SelectedItem.ToString(),
                FechaEnvio = dtpFechaEnvio.Value,
                TipoProducto = cbTipoEncomienda.SelectedItem.ToString(),
                Peso = (float)nudPeso.Value,
                Largo = (float)nudLargo.Value,
                Alto = (float)nudAlto.Value,
                Ancho = (float)nudAncho.Value,
            };
            int idEncomienda = nEncomienda.RegistrarEncomienda(encomienda, out mensaje);
            if (idEncomienda > 0)
            {
                MessageBox.Show("Encomienda registrada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarDinamicamentePrecio()
        {
            // Validar que se hayan ingresado todos los campos
            if (cbTipoEncomienda.SelectedIndex == -1 || nudPeso.Value == 0 || nudLargo.Value == 0 || nudAlto.Value == 0 || nudAncho.Value == 0)
            {
                lblPrecioCalculado.Text = "S/. 0.00";
                return;
            }
            // Calcular el precio de la encomienda según el peso y el tipo de producto (Fragil, No Fragil, Ropa, Muebles)
            switch (cbTipoEncomienda.SelectedItem.ToString())
            {
                case "Fragil":
                    lblPrecioCalculado.Text = "S/. " + ((float)(nudPeso.Value) * 1.5).ToString();
                    break;
                case "No Fragil":
                    lblPrecioCalculado.Text = "S/. " + ((float)(nudPeso.Value) * 0.8).ToString();
                    break;                            
                case "Ropa":                          
                    lblPrecioCalculado.Text = "S/. " + ((float)(nudPeso.Value) * 0.6).ToString();
                    break;                             
                case "Muebles":                        
                    lblPrecioCalculado.Text = "S/. " + ((float)(nudPeso.Value) * 0.4).ToString();
                    break;
            }
        }

        private void cbTipoEncomienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDinamicamentePrecio();
        }

        private void nudPeso_ValueChanged(object sender, EventArgs e)
        {
            MostrarDinamicamentePrecio();
        }
    }
}
