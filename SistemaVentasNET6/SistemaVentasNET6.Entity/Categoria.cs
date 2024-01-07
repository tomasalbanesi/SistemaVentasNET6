using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasNET6.Entity
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public bool EsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Relación con Producto
        public List<Producto> Productos { get; set; }
    }
}
