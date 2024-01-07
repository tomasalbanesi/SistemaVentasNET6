using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasNET6.Entity
{
    public class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public string MarcaProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public string CategoriaProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }

        // Relación con Venta
        public Venta Venta { get; set; }

        // Relación con Producto
        public Producto Producto { get; set; }
    }
}
