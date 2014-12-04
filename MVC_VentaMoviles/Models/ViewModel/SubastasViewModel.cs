using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_VentaMoviles.Models.ViewModel
{
    public class SubastasViewModel
    {
        public int idSubasta { get; set; }
        public int idDispositivo { get; set; }
        public decimal precioInicial { get; set; }
        public System.DateTime fin { get; set; }

    }
}