using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DPasaje
    {
        // Listar todos los pasajes
        public List<Pasaje> ListarPasajes(int idUsuario)
        {
            using (var context = new DB_PerlaAltomayoEntities())
            {
                try
                {
                    return context.Pasaje.Where(p => p.UsuarioId == idUsuario).ToList();
                }
                catch (Exception ex)
                {
                    return new List<Pasaje>();

                }
            }
        }
        // Registrar un pasaje nuevo
        public int RegistrarPasaje(Pasaje pasaje, out string mensaje)
        {
            int idPasaje = 0;
            mensaje = string.Empty;
            try
            {
                using (var context = new DB_PerlaAltomayoEntities())
                {
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@UsuarioId", pasaje.UsuarioId),
                        new SqlParameter("@BusId", pasaje.BusId),
                        new SqlParameter("@Asiento", pasaje.Asiento),
                        new SqlParameter("@Piso", pasaje.Piso),
                        new SqlParameter("@IdResultado",System.Data.SqlDbType.Int){Direction = System.Data.ParameterDirection.Output},
                        new SqlParameter("@Mensaje",System.Data.SqlDbType.VarChar,200){Direction = System.Data.ParameterDirection.Output}
                    };
                    context.Database.ExecuteSqlCommand("EXEC SP_RegistrarPasaje @UsuarioId, @BusId, @Asiento, @Piso, @IdResultado OUTPUT, @Mensaje OUTPUT", parameters);
                    idPasaje = Convert.ToInt32(parameters.Single(p => p.ParameterName == "@IdResultado").Value);
                    mensaje = parameters.Single(p => p.ParameterName == "@Mensaje").Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idPasaje = 0;
                mensaje = ex.Message;
            }
            return idPasaje;
        }
    }
}
