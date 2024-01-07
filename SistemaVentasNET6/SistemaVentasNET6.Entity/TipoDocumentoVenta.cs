using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasNET6.Entity
{
    public class TipoDocumentoVenta
    {
        public int IdTipoDocumentoVenta { get; set; }
        public string Descripcion { get; set; }
        public bool EsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Relación con Venta
        public List<Venta> Ventas { get; set; }
    }
}
