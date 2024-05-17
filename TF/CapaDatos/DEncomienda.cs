using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DEncomienda
    {
        // Constructor vacío
        public DEncomienda() { }
        // Metodo para listar todas las encomiendas
        public List<Encomienda> ListarEncomiendas(int idUsuario)
        {
            using (var context = new DB_PerlaAltomayoEntities())
            {
                try
                {
                    return context.Encomienda.Where(e => e.UsuarioId == idUsuario).ToList();
                }
                catch (Exception ex)
                {
                    return new List<Encomienda>();
                }
            }
        }
        // Metodo para listar todas las encomiendas por destino
        public List<Encomienda> ListarEncomiendasPorDestino(int idUsuario, string destino)
        {
            using (var context = new DB_PerlaAltomayoEntities())
            {
                try
                {
                    return context.Encomienda.Where(e => e.UsuarioId == idUsuario && e.Destino == destino).ToList();
                }
                catch (Exception ex)
                {
                    return new List<Encomienda>();
                }
            }
        }
        // Metoo para listar todas las encomiendas por fecha de pedido (Mas antiguo, mas reciente)
        public List<Encomienda> ListarEncomiendasPorFechaPedido(int idUsuario, string fechaPedido)
        {
            using (var context = new DB_PerlaAltomayoEntities())
            {
                try
                {
                    if (fechaPedido == "Más antiguos")
                    {
                        return context.Encomienda.Where(e => e.UsuarioId == idUsuario).OrderBy(e => e.FechaPedido).ToList();
                    }
                    else
                    {
                        return context.Encomienda.Where(e => e.UsuarioId == idUsuario).OrderByDescending(e => e.FechaPedido).ToList();
                    }
                }
                catch (Exception ex)
                {
                    return new List<Encomienda>();
                }
            }
        }
        // Metodo para Registrar una encomienda
        public int RegistrarEncomienda(Encomienda encomienda, out string mensaje)
        {
            int idResultado = 0;
            mensaje = "";

            try
            {
                using(var context = new DB_PerlaAltomayoEntities())
                {
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@UsuarioId",encomienda.UsuarioId),
                        new SqlParameter("@Destino",encomienda.Destino),
                        new SqlParameter("@PuntoSalida",encomienda.PuntoSalida),
                        new SqlParameter("@FechaEnvio",encomienda.FechaEnvio),
                        new SqlParameter("@FechaLlegada",encomienda.FechaLlegada),
                        new SqlParameter("@TipoProducto",encomienda.TipoProducto),
                        new SqlParameter("@Peso",encomienda.Peso),
                        new SqlParameter("@Largo",encomienda.Largo),
                        new SqlParameter("@Alto",encomienda.Alto),
                        new SqlParameter("@Ancho",encomienda.Ancho),
                        new SqlParameter("@Precio",encomienda.Precio),
                        new SqlParameter("@IdResultado",System.Data.SqlDbType.Int){Direction = System.Data.ParameterDirection.Output},
                        new SqlParameter("@Mensaje",System.Data.SqlDbType.VarChar,200){Direction = System.Data.ParameterDirection.Output}
                    };
                    context.Database.ExecuteSqlCommand("EXEC SP_RegistrarEncomienda @UsuarioId, @Destino, @PuntoSalida, @FechaEnvio, @FechaLlegada, @TipoProducto, @Peso, @Largo, @Alto, @Ancho, @Precio, @IdResultado OUTPUT, @Mensaje OUTPUT", parameters);
                    idResultado = Convert.ToInt32(parameters.Single(p => p.ParameterName == "@IdResultado").Value);
                    mensaje = parameters.Single(p => p.ParameterName == "@Mensaje").Value.ToString();
                }   
            }
            catch (Exception ex)
            {
                idResultado = 0;
                mensaje = ex.Message;
            }
            return idResultado;
        }
    }
}
