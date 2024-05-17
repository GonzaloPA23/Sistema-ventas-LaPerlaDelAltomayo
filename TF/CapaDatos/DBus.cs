using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DBus
    {
        // Constructor vacío
        public DBus() { }
        // Metodo para listar los buses
        public List<Bus> ListarBuses()
        {
            using (var context = new DB_PerlaAltomayoEntities())
            {
                try
                {
                    return context.Bus.ToList();
                }
                catch (Exception ex) 
                {
                    return new List<Bus>();
                }
            }
        }
        // Metodo para registrar un bus
        public int RegistrarBus(Bus bus, out string mensaje)
        {
            int idbusgenerado = 0;
            mensaje = string.Empty;
                
            try
            {
                using(var context = new DB_PerlaAltomayoEntities())
                {
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ChoferId", bus.ChoferId),
                        new SqlParameter("@Matricula", bus.Matricula),
                        new SqlParameter("@Tipo", bus.Tipo),
                        new SqlParameter("@CantidadAsiento", bus.CantidadAsiento),
                        new SqlParameter("@PuntoSalida", bus.PuntoSalida),
                        new SqlParameter("@Destino", bus.Destino),
                        new SqlParameter("@FechaSalida", bus.FechaSalida),
                        new SqlParameter("@FechaLlegada", bus.FechaLlegada),
                        new SqlParameter("@PrecioAsiento", bus.PrecioAsiento),
                        new SqlParameter("@AsientosDisponibles",bus.AsientosDisponibles),
                        new SqlParameter("@IdResultado", System.Data.SqlDbType.Int) { Direction = System.Data.ParameterDirection.Output },
                        new SqlParameter("@Mensaje", System.Data.SqlDbType.VarChar, 200) { Direction = System.Data.ParameterDirection.Output }
                    };
                    context.Database.ExecuteSqlCommand("EXEC SP_RegistrarBus @ChoferId, @Matricula, @Tipo, @CantidadAsiento, @PuntoSalida, @Destino, @FechaSalida, @FechaLlegada, @PrecioAsiento, @AsientosDisponibles , @IdResultado OUTPUT, @Mensaje OUTPUT", parameters);
                    idbusgenerado = Convert.ToInt32(parameters.Single(p => p.ParameterName == "@IdResultado").Value);
                    mensaje = parameters.Single(p => p.ParameterName == "@Mensaje").Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idbusgenerado = 0;
                mensaje = ex.Message;
            }
            return idbusgenerado;
        }
        // Metodo para eliminar un bus
        public void EliminarBus(int idBus)
        {
            using(var context = new DB_PerlaAltomayoEntities())
            {
                try
                {
                    Bus bus = context.Bus.Single(b => b.Id == idBus);
                    context.Bus.Remove(bus);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        // Metodo para listar los buses por punto de salida
        public List<Bus> ListarBusesPorPuntoSalida(string puntoSalida)
        {
            using (var context = new DB_PerlaAltomayoEntities())
            {
                try
                {
                    return context.Bus.Where(b => b.PuntoSalida == puntoSalida).ToList();
                }
                catch (Exception ex)
                {
                    return new List<Bus>();
                }
            }
        }
        // Metodo para listar los buses por destino
        public List<Bus> ListarBusesPorDestino(string destino)
        {
            using (var context = new DB_PerlaAltomayoEntities())
            {
                try
                {
                    return context.Bus.Where(b => b.Destino == destino).ToList();
                }
                catch (Exception ex)
                {
                    return new List<Bus>();
                }
            }
        }
        // Metodo para listar los buses por fecha de salida
        public List<Bus> ListarBusesPorFechaSalida(DateTime fechaSalida)
        {
            using (var context = new DB_PerlaAltomayoEntities())
            {
                try
                {
                    return context.Bus.Where(b => b.FechaSalida >= fechaSalida).ToList();
                }
                catch (Exception ex)
                {
                    return new List<Bus>();
                }
            }
        }
        // Metodo para listar por el tipo de bus
        public List<Bus> ListarBusesPorTipo(string tipo)
        {
            using (var context = new DB_PerlaAltomayoEntities())
            {
                try
                {
                    return context.Bus.Where(b => b.Tipo == tipo).ToList();
                }
                catch (Exception ex)
                {
                    return new List<Bus>();
                }
            }
        }
        // Actualizar asientos disponibles de un bus al registrar un pasaje , se le resta 1 al asiento disponible
        public void ActualizarBus(int idBus)
        {
            try
            {
                using(var context = new DB_PerlaAltomayoEntities())
                {
                    Bus bus = context.Bus.Single(b => b.Id == idBus);
                    bus.AsientosDisponibles -= 1;
                    context.SaveChanges();
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
    }
}
