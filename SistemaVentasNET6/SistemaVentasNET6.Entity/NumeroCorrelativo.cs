using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasNET6.Entity
{
    public class NumeroCorrelativo
    {
        public int IdNumeroCorrelativo { get; set; }
        public int UltimoNumero { get; set; }
        public int CantidadDigitos { get; set; }
        public string Gestion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
