using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class NBus
    {
        private DBus dBus = new DBus();
        // Constructor vacío
        public NBus() { }
        // Metodo para listar los buses
        public List<Bus> ListarBuses()
        {
            return dBus.ListarBuses();
        }
        public int RegistrarBus(Bus bus, out string mensaje)
        {
            mensaje = string.Empty;
            // validacion de campos vacios
            if (bus.Matricula == string.Empty || bus.PuntoSalida == string.Empty || bus.Destino == string.Empty || 
                bus.Tipo == string.Empty)
            {
                mensaje = "Debe completar todos los campos";
                return 0;
            }
            // Validacion que la matricula sea de 6 caracteres y que tenga un - en el medio
            if (bus.Matricula.Length != 7 || !bus.Matricula.Contains("-"))
            {
                mensaje = "La matricula debe tener 6 caracteres y un - en el medio";
                return 0;
            }
            // Validacion que el punto de salida y destino sean diferentes
            if (bus.PuntoSalida == bus.Destino)
            {
                mensaje = "El punto de salida y destino deben ser diferentes";
                return 0;
            }
            // Validacion que la fecha de llegada sea mayor a la fecha de salida
            if (bus.FechaLlegada <= bus.FechaSalida)
            {
                mensaje = "La fecha de llegada debe ser mayor a la fecha de salida";
                return 0;
            }

            if(mensaje != string.Empty) return 0;
            else return dBus.RegistrarBus(bus, out mensaje);
        }
        public void EliminarBus(int idBus)
        {           
            dBus.EliminarBus(idBus);
        }
        public List<Bus> ListarBusesPorPuntoSalida(string puntoSalida)
        {
            return dBus.ListarBusesPorPuntoSalida(puntoSalida);
        }
        // Metodo para listar los buses por destino
        public List<Bus> ListarBusesPorDestino(string destino)
        {
            return dBus.ListarBusesPorDestino(destino);
        }
        // Metodo para listar los buses por fecha de salida
        public List<Bus> ListarBusesPorFechaSalida(DateTime fechaSalida)
        {
            return dBus.ListarBusesPorFechaSalida(fechaSalida);
        }
        // Metodo para listar por el tipo de bus
        public List<Bus> ListarBusesPorTipo(string tipo)
        {
            return dBus.ListarBusesPorTipo(tipo);
        }
        // Metodo para actualizar los asientos disponibles
        public void ActualizarBus(int idBus)
        {
            dBus.ActualizarBus(idBus);
        }

    }
}
