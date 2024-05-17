using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NEncomienda
    {
        private DEncomienda dEncomienda = new DEncomienda();
        //Constructor vacío
        public NEncomienda() { }
        // Metodo para listar todas las encomiendas
        public List<Encomienda> ListarEncomiendas(int idUsuario)
        {
            return dEncomienda.ListarEncomiendas(idUsuario);
        }
        // Metodo para listar todas las encomiendas por destino
        public List<Encomienda> ListarEncomiendasPorDestino(int idUsuario, string destino)
        {
            return dEncomienda.ListarEncomiendasPorDestino(idUsuario, destino);
        }
        // Metoo para listar todas las encomiendas por fecha de pedido (Mas antiguo, mas reciente)
        public List<Encomienda> ListarEncomiendasPorFechaPedido(int idUsuario, string fechaPedido)
        {
            return dEncomienda.ListarEncomiendasPorFechaPedido(idUsuario, fechaPedido);
        }
        // Metodo para registrar una encomienda
        public int RegistrarEncomienda(Encomienda encomienda, out string mensaje)
        {
            mensaje = string.Empty;
            // Validacion de campos vacios
            if (encomienda.Destino == string.Empty || encomienda.PuntoSalida == string.Empty || encomienda.TipoProducto == string.Empty ||
                               encomienda.Peso == 0 || encomienda.Largo == 0 || encomienda.Alto == 0 || encomienda.Ancho == 0)
            {
                mensaje = "Debe completar todos los campos";
                return 0;
            }
            // Validacion que el punto de salida y destino sean diferentes
            if (encomienda.PuntoSalida == encomienda.Destino)
            {
                mensaje = "El punto de salida y destino deben ser diferentes";
                return 0;
            }
            // Establecer la fecha de llegada después de 7 días de la fecha de envio
            encomienda.FechaLlegada = encomienda.FechaEnvio.AddDays(7);
            // Establecer el precio de la encomienda según el peso y el tipo de producto (Fragil, No Fragil, Ropa, Muebles)
            switch(encomienda.TipoProducto)
            {
                case "Fragil":
                    encomienda.Precio = (decimal)(encomienda.Peso * 1.5);
                    break;
                case "No Fragil":
                    encomienda.Precio = (decimal)(encomienda.Peso * 0.8);
                    break;
                case "Ropa":
                    encomienda.Precio = (decimal)(encomienda.Peso * 0.6);
                    break;
                case "Muebles":
                    encomienda.Precio = (decimal)(encomienda.Peso * 0.4);
                    break;
            }
            if (mensaje != string.Empty) return 0;
            else return dEncomienda.RegistrarEncomienda(encomienda, out mensaje);           
        }
    }
}
