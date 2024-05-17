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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty; 
            
            // Validación del textbox clave que tenga al menos 8 caracteres, una mayuscula y un numero
            if (txtClave.Text.Length < 8 || !txtClave.Text.Any(char.IsUpper) || !txtClave.Text.Any(char.IsDigit))
            {
                MessageBox.Show("La clave debe tener al menos 8 caracteres, una mayuscula y un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Creacion del objeto usuario
            Usuario usuario = new Usuario()
            {
                Dni = txtDni.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Clave = Utilidades.Encrypt.EncriptarClave(txtClave.Text),
                //Clave = txtClave.Text,
                Correo = txtCorreo.Text
            };
            int idUsuarioGenerado = new NUsuario().RegistrarUsuario(usuario, out mensaje);
            if (idUsuarioGenerado != 0)
            {
                MessageBox.Show("Usuario registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                frmIniciarSesion frmIniciarSesion = new frmIniciarSesion();
                frmIniciarSesion.Show();
                this.Hide();
                frmIniciarSesion.FormClosing += Form_Closing;
            }else MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmIniciarSesion frmIniciarSesion = new frmIniciarSesion();
            frmIniciarSesion.Show();
            this.Hide();
            frmIniciarSesion.FormClosing += Form_Closing;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtDni.Clear();
            txtClave.Clear();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            LimpiarCampos();
            this.Show();
        }
    }
}
