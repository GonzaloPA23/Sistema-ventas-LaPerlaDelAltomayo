using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DUsuario
    {
        // Constructor vacío
        public DUsuario() { }
        // Metodo para listar los usuarios
        public List<Usuario> ListarUsuarios()
        {
            using(var context = new DB_PerlaAltomayoEntities())
            {
                try
                {
                    return context.Usuario.ToList();
                }
                catch (Exception e)
                {
                    return new List<Usuario>();
                }
            }
        }
        // Metodo para registrar un usuario mediante stored procedure
        public int RegistrarUsuario(Usuario usuario, out string mensaje)
        {
            int idusuariogenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (var context = new DB_PerlaAltomayoEntities())
                {
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Dni", usuario.Dni),
                        new SqlParameter("@Nombre", usuario.Nombre),
                        new SqlParameter("@Apellido", usuario.Apellido),
                        new SqlParameter("@Clave", usuario.Clave),
                        new SqlParameter("@Correo", usuario.Correo),
                        new SqlParameter("@IdResultado", SqlDbType.Int) { Direction = ParameterDirection.Output },
                        new SqlParameter("@Mensaje", SqlDbType.VarChar, 200) { Direction = ParameterDirection.Output }
                    };
                    context.Database.ExecuteSqlCommand("EXEC SP_RegistrarUsuario @Dni, @Nombre, @Apellido, @Clave, @Correo, @IdResultado OUTPUT, @Mensaje OUTPUT", parameters);
                    idusuariogenerado = Convert.ToInt32(parameters.Single(p => p.ParameterName == "@IdResultado").Value);
                    mensaje = parameters.Single(p => p.ParameterName == "@Mensaje").Value.ToString();
                }
            }catch (Exception ex)
            {
                idusuariogenerado = 0;
                mensaje = ex.Message;
            }
            return idusuariogenerado;
        }
        // Metodo para obtener la Foto
        public byte[] ObtenerFoto(out bool obtenido, int idUsuario)
        {
            obtenido = true;
            byte[] FotoBytes = new byte[0];
            try
            {
                using (var context = new DB_PerlaAltomayoEntities())
                {
                    FotoBytes = context.Usuario.Where(user => user.Id == idUsuario).Select(user => user.Foto).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                obtenido = false;
                FotoBytes = new byte[0];
            }

            return FotoBytes;
        }
        // Actualizar la Foto del Usuario
        public bool ActualizarFoto(int idUsuario, byte[] bytes, out string mensaje)
        {
            mensaje = string.Empty;
            bool actualizado = true;
            try
            {
                using (var context = new DB_PerlaAltomayoEntities())
                {
                    var usuario = context.Usuario.Where(user => user.Id == idUsuario).FirstOrDefault();
                    usuario.Foto = bytes;
                    context.Entry(usuario).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                actualizado = false;
                mensaje = ex.Message;
            }
            return actualizado;
        }
        // Metodo para actualizar un usuario
        public String ActualizarUsuario(Usuario usuario)
        {   
            string mensake = string.Empty;
            try
            {
                using (var context = new DB_PerlaAltomayoEntities())
                {
                    var user = context.Usuario.Where(u => u.Id == usuario.Id).FirstOrDefault();
                    user.Dni = usuario.Dni;
                    user.Nombre = usuario.Nombre;
                    user.Apellido = usuario.Apellido;
                    user.Correo = usuario.Correo;
                    context.Entry(user).State = EntityState.Modified;
                    context.SaveChanges();
                    return mensake = "Usuario actualizado correctamente";
                }
            }
            catch (Exception ex)
            {
                return mensake = ex.Message;
            }
        }
    }
}