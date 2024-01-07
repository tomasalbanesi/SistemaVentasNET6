using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasNET6.Entity
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int IdRol { get; set; }
        public string UrlFoto { get; set; }
        public string NombreFoto { get; set; }
        public string Clave { get; set; }
        public bool EsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Relación con Rol
        public Rol Rol { get; set; }

        // Relación con Venta
        public List<Venta> Ventas { get; set; }
    }
}
