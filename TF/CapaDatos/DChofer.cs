using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DChofer
    {
        // Constructor vacío
        public DChofer() { }
        // Metodo para listar los choferes
        public List<Chofer> ListarChoferes()
        {
            using(var context = new DB_PerlaAltomayoEntities())
            {
                try
                {
                    return context.Chofer.ToList();
                }
                catch (Exception e)
                {
                    return new List<Chofer>();
                }
            }
        }
        // Metodo para registrar un chofer mediante stored procedure
        public int RegistrarChofer(Chofer chofer, out string mensaje)
        {
            int idchofergenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (var context = new DB_PerlaAltomayoEntities())
                {
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Dni", chofer.Dni),
                        new SqlParameter("@Nombre", chofer.Nombre),
                        new SqlParameter("@Apellido", chofer.Apellido),
                        new SqlParameter("@FechaNacimiento", chofer.FechaNacimiento),
                        new SqlParameter("@Celular", chofer.Celular),
                        new SqlParameter("@Correo", chofer.Correo),
                        new SqlParameter("@IdResultado", System.Data.SqlDbType.Int) { Direction = System.Data.ParameterDirection.Output },
                        new SqlParameter("@Mensaje", System.Data.SqlDbType.VarChar, 200) { Direction = System.Data.ParameterDirection.Output }
                    };
                    context.Database.ExecuteSqlCommand("EXEC SP_RegistrarChofer @Dni, @Nombre, @Apellido, @FechaNacimiento, @Celular, @Correo, @IdResultado OUTPUT, @Mensaje OUTPUT", parameters);
                    idchofergenerado = Convert.ToInt32(parameters.Single(p => p.ParameterName == "@IdResultado").Value);
                    mensaje = parameters.Single(p => p.ParameterName == "@Mensaje").Value.ToString();
                }
            }catch (Exception ex)
            {
                idchofergenerado = 0;
                mensaje = ex.Message;
            }
            return idchofergenerado;
        }
        // Metodo para eliminar un chofer
        public void EliminarChofer(int idChofer)
        {
            using (var context = new DB_PerlaAltomayoEntities())
            {
                try
                {
                    Chofer chofer = context.Chofer.Single(c => c.Id == idChofer);
                    context.Chofer.Remove(chofer);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        // Metodo para editar un chofer mediante stored procedure
        public bool EditarChofer(Chofer chofer, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using(var context = new DB_PerlaAltomayoEntities())
                {
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Id", chofer.Id),
                        new SqlParameter("@Correo", chofer.Correo),
                        new SqlParameter("@Celular", chofer.Celular),
                        new SqlParameter("@Respuesta", System.Data.SqlDbType.Bit) { Direction = System.Data.ParameterDirection.Output },
                        new SqlParameter("@Mensaje", System.Data.SqlDbType.VarChar, 200) { Direction = System.Data.ParameterDirection.Output }
                    };
                    context.Database.ExecuteSqlCommand("EXEC SP_EditarChofer @Id, @Correo, @Celular, @Respuesta OUTPUT, @Mensaje OUTPUT", parameters);
                    respuesta = Convert.ToBoolean(parameters.Single(p => p.ParameterName == "@Respuesta").Value);
                    mensaje = parameters.Single(p => p.ParameterName == "@Mensaje").Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;
        }
    }
}
