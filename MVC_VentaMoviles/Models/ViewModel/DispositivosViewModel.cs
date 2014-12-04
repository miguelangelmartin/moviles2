using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_VentaMoviles.Models.ViewModel
{
    public class DispositivosViewModel
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string foto { get; set; }
        public string descripcion { get; set; }

    }
}