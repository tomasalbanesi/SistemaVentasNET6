using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasNET6.Entity
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public string NumeroVenta { get; set; }
        public int IdTipoDocumentoVenta { get; set; }
        public int IdUsuario { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ImpuestoTotal { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Relación con Usuario
        public Usuario Usuario { get; set; }

        // Relación con TipoDocumentoVenta
        public TipoDocumentoVenta TipoDocumentoVenta { get; set; }

        // Relación con DetalleVenta
        public List<DetalleVenta> DetallesVentas { get; set; }
    }
}
