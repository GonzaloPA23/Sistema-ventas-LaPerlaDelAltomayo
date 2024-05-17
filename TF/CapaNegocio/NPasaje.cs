using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NPasaje
    {
        private DPasaje dPasaje = new DPasaje();
        // Listar todos los pasajes
        public List<Pasaje> ListarPasajes(int idUsuario)
        {
           return dPasaje.ListarPasajes(idUsuario);
        }
        // Registrar un pasaje nuevo
        public int RegistrarPasaje(Pasaje pasaje, out string mensaje)
        {
            return dPasaje.RegistrarPasaje(pasaje, out mensaje);
        }
    }
}
