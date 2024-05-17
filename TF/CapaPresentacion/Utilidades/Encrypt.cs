using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Utilidades
{
    public class Encrypt
    {
        public static string EncriptarClave(string clave)
        {
            string claveEncriptada = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(clave);
            claveEncriptada = Convert.ToBase64String(encryted);
            return claveEncriptada;
        }
    }
}
