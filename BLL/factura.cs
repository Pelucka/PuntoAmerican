using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public class factura
    {
        public string Departamento { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Ubicacion { get; set; }
        public int Desc { get; set; }
        public int Impuesto_1 { get; set; }
        public int Total { get; set; }
        public int Cod_Articulo1 { get; set; }
        public int Unidad_Medida1 { get; set; }
    }
}
