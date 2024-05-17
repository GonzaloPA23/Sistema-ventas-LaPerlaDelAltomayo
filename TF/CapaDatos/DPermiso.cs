using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPermiso
    {
        // Constructor vacío
        public DPermiso() { }
        // Metodo para listar los permisos de un usuario
        public List<Permiso> ListarPermisos(int idUsuario)
        {
            using (var context = new DB_PerlaAltomayoEntities())
            {
                try
                {
                    string query = "SELECT Permiso.Id, Permiso.RolId, NombreMenu " +
                                   "FROM Permiso " +
                                   "JOIN Rol r2 ON r2.id = Permiso.RolId " +
                                   "JOIN Usuario u ON r2.id = u.RolId " +
                                   "WHERE u.id = @idUsuario";

                    SqlParameter parametro = new SqlParameter("@idUsuario", idUsuario);

                    return context.Database.SqlQuery<Permiso>(query, parametro)
                        .Select(resultado => new Permiso
                        {
                            Id = resultado.Id,
                            Rol = new Rol { Id = resultado.RolId },
                            NombreMenu = resultado.NombreMenu
                        })
                        .ToList();
                }
                catch (Exception e)
                {
                    // Manejo de excepciones, si es necesario
                    return new List<Permiso>();
                }
            }
        }
    }
}
