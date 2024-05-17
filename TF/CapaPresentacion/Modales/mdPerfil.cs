using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion.Modales
{
    public partial class mdPerfil : Form
    {
        private Usuario usuario;
        private NUsuario nUsuario = new NUsuario();
        private frmInicio frmInicio;

        public mdPerfil(Usuario usuario, frmInicio inicio)
        {
            this.usuario = usuario;
            this.frmInicio = inicio;
            InitializeComponent();
        }

        private Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void mdPerfil_Load(object sender, EventArgs e)
        {
            if (usuario.Foto != null)
            {
                bool obtenido = true;
                byte[] foto = nUsuario.ObtenerFoto(out obtenido, usuario.Id);

                if (obtenido)
                {
                    pbFotoPerfil.Image = ByteToImage(foto);
                    pbFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                }                 
            }
           
            tbNombre.Text = usuario.Nombre;
            tbApellido.Text = usuario.Apellido;
            tbCorreo.Text = usuario.Correo;
            tbDNI.Text = usuario.Dni;
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {

                byte[] byteimage = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = nUsuario.ActualizarFoto(usuario.Id,byteimage, out mensaje);

                if (respuesta)
                {
                    pbFotoPerfil.Image = ByteToImage(byteimage);
                    pbFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            this.frmInicio.ActualizarFotoPerfil();
            this.frmInicio.Show();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            nUsuario.ActualizarUsuario(new Usuario()
            {
                Id = usuario.Id,
                Dni = tbDNI.Text.Trim(),
                Nombre = tbNombre.Text.Trim(),
                Apellido = tbApellido.Text.Trim(),
                Correo = tbCorreo.Text.Trim()
            });

            MessageBox.Show("Usuario actualizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
