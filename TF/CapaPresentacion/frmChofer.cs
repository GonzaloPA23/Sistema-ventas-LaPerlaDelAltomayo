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
    public partial class frmChofer : Form
    {
        private NChofer nChofer = new NChofer();
        public frmChofer()
        {
            InitializeComponent();
            MostrarChoferes(nChofer.ListarChoferes());
        }

        private void frmChofer_Load(object sender, EventArgs e)
        {
            MostrarOpcionesCombo();
        }
        private void LimpiarCampos()
        {
            txtIndice.Text = "-1";
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpFechaNacimiento.Text = DateTime.Now.ToString();
            txtCelular.Text = "";
            txtCorreo.Text = "";
            txtId.Text = "0";
            txtActualizarCelular.Text = "";
            txtActualizarCorreo.Text = "";
        }
        private void MostrarChoferes(List<Chofer> choferes)
        {
            dgChoferes.Rows.Clear();
            foreach(Chofer chofer in choferes)
            {
                dgChoferes.Rows.Add(new object[] { "", chofer.Id, chofer.Dni, chofer.Nombre, 
                    chofer.Apellido, chofer.Celular, chofer.Correo, 
                    chofer.FechaNacimiento.ToString("yyyy-MM-dd") });
            }
            lblTotalChoferes.Text = choferes.Count.ToString();
        }
        private void btnCancelarChofer_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void btnRegistrarChofer_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Chofer chofer = new Chofer()
            {
                Dni = txtDni.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Celular = txtCelular.Text,
                Correo = txtCorreo.Text
            };

            int idchofergenerado = nChofer.RegistrarChofer(chofer, out mensaje);

            if(idchofergenerado != 0)
            {
                MessageBox.Show("Chofer registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                MostrarChoferes(nChofer.ListarChoferes());
            }else MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MostrarOpcionesCombo()
        {
            foreach(DataGridViewColumn columna in dgChoferes.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cbBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText});
                }
            }
            cbBusqueda.DisplayMember = "Texto"; // Lo que se muestra
            cbBusqueda.ValueMember = "Valor"; // Lo que vale
            cbBusqueda.SelectedIndex = 0;
        }
        private void dgChoferes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
        private void dgChoferes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgChoferes.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgChoferes.Rows[indice].Cells["Id"].Value.ToString();
                    txtDni.Text = dgChoferes.Rows[indice].Cells["Dni"].Value.ToString();
                    txtNombre.Text = dgChoferes.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtApellido.Text = dgChoferes.Rows[indice].Cells["Apellido"].Value.ToString();
                    txtCelular.Text = dgChoferes.Rows[indice].Cells["Celular"].Value.ToString();
                    txtCorreo.Text = dgChoferes.Rows[indice].Cells["Correo"].Value.ToString();
                    dtpFechaNacimiento.Text = dgChoferes.Rows[indice].Cells["FechaNacimiento"].Value.ToString();
                    txtActualizarCelular.Text = dgChoferes.Rows[indice].Cells["Celular"].Value.ToString();
                    txtActualizarCorreo.Text = dgChoferes.Rows[indice].Cells["Correo"].Value.ToString();
                }
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            cbBusqueda.SelectedIndex = 0;
            LimpiarCampos();
            MostrarChoferes(nChofer.ListarChoferes());
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = ((OpcionCombo)cbBusqueda.SelectedItem).Valor.ToString();
            if (dgChoferes.Rows.Count > 0)
            {
                foreach(DataGridViewRow fila in dgChoferes.Rows)
                {
                    if (fila.Cells[filtro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                    {
                        fila.Visible = true;
                    }
                    else fila.Visible = false;
                }
                lblTotalChoferes.Text = dgChoferes.Rows.Cast<DataGridViewRow>().Count(x => x.Visible).ToString();
            }
        }

        private void btnEliminarChofer_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "0")
            {
                if (MessageBox.Show("¿Está seguro de eliminar el chofer?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    nChofer.EliminarChofer(Convert.ToInt32(txtId.Text));
                    MessageBox.Show("Chofer eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    MostrarChoferes(nChofer.ListarChoferes());
                }
            }
            else MessageBox.Show("Debe seleccionar un chofer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Chofer chofer = new Chofer()
            {
                Id = Convert.ToInt32(txtId.Text),
                Dni = txtDni.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Celular = txtActualizarCelular.Text,
                Correo = txtActualizarCorreo.Text
            };

            bool resultado = nChofer.EditarChofer(chofer, out mensaje);
         
            if (resultado)
            {
                MessageBox.Show("Chofer actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                MostrarChoferes(nChofer.ListarChoferes());
            } else MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
