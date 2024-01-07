using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasNET6.Entity
{
    public class RolMenu
    {
        public int IdRolMenu { get; set; }
        public int IdRol { get; set; }
        public int IdMenu { get; set; }
        public bool EsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Relación con Rol
        public Rol Rol { get; set; }

        // Relación con Menu
        public Menu Menu { get; set; }
    }
}
