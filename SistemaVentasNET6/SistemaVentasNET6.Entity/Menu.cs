using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasNET6.Entity
{
    public class Menu
    {
        public int IdMenu { get; set; }
        public string Descripcion { get; set; }
        public int? IdMenuPadre { get; set; }
        public string Icono { get; set; }
        public string Controlador { get; set; }
        public string PaginaAccion { get; set; }
        public bool EsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Relación con RolMenu
        public List<RolMenu> RolesMenus { get; set; }
    }
}
