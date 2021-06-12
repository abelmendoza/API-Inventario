using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInventario.Models
{
    public class Inventario
    {
        [Key]
        public int id { get; set; }
        public string dimensionAncho { get; set; }
        public string dimensionLargo { get; set; }
        public string tipoTela { get; set; }
        public string color { get; set; }
        public string procedencia { get; set; }
        public string marca { get; set; }
        public bool estado { get; set; }
    }
}
