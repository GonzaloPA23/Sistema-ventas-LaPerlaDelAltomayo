using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NChofer
    {
        private DChofer dChofer = new DChofer();
        public List<Chofer> ListarChoferes()
        {
            return dChofer.ListarChoferes();
        }
        public int RegistrarChofer(Chofer chofer, out string mensaje)
        {
            mensaje = string.Empty;
            // Validacion de campos vacios
            if (chofer.Dni == string.Empty || chofer.Nombre == string.Empty || chofer.Apellido == string.Empty || chofer.Celular == string.Empty || chofer.Correo == string.Empty)
            {
                mensaje = "Debe completar todos los campos";
                return 0;
            }
            // Validacion de que el DNI sea un número y tenga 8 dígitos
            if (!int.TryParse(chofer.Dni, out int dni) || chofer.Dni.Length != 8)
            {
                mensaje = "El DNI debe ser un número de 8 dígitos";
                return 0;
            }
            // Validacion de que el celular sea un número y tenga 9 dígitos
            if (!int.TryParse(chofer.Celular, out int celular) || chofer.Celular.Length != 9)
            {
                mensaje = "El celular debe ser un número de 9 dígitos";
                return 0;
            }
            // Validacion de que el correo sea un correo válido
            if (!chofer.Correo.Contains("@") || !chofer.Correo.Contains("."))
            {
                mensaje = "El correo debe ser un correo válido";
                return 0;
            }
            if (mensaje != string.Empty) return 0;
            else return dChofer.RegistrarChofer(chofer, out mensaje);
        }
        public void EliminarChofer(int idChofer)
        {
            dChofer.EliminarChofer(idChofer);
        }
        public bool EditarChofer(Chofer chofer, out string mensaje)
        {
            mensaje = string.Empty;
            // Validacion de que no haya seleccionado un chofer
            if (chofer.Id == 0)
            {
                mensaje = "Debe seleccionar un chofer";
                return false;
            }
            // Validacion que el correo sea un correo válido
            if (!chofer.Correo.Contains("@") || !chofer.Correo.Contains("."))
            {
                mensaje = "El correo debe ser un correo válido";
                return false;
            }  
            // Validacion de que el celular sea un número y tenga 9 dígitos
            if (!int.TryParse(chofer.Celular, out int celular) || chofer.Celular.Length != 9)
            {
                mensaje = "El celular debe ser un número de 9 dígitos";
                return false;
            }
            if (mensaje != string.Empty) return false;
            else return dChofer.EditarChofer(chofer, out mensaje);
        }
    }
}
