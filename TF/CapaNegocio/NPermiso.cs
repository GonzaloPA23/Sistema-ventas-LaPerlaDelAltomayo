using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class NPermiso
    {
        private DPermiso dPermiso = new DPermiso();
        // constructor
        public NPermiso() { }
        public List<Permiso> ListarPermisos(int idUsuario)
        {
            return dPermiso.ListarPermisos(idUsuario);
        }
    }
}
