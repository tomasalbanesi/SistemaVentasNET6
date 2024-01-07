using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasNET6.Entity
{
    public class Rol
    {
        public int IdRol { get; set; }
        public string Descripcion { get; set; }
        public bool EsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Relación con Usuario
        public List<Usuario> Usuarios { get; set; }

        // Relación con RolMenu
        public List<RolMenu> RolesMenus { get; set; }
    }
}
