//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_de_Gestión.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class VW_VerReportesFacturasPendientesCredito
    {
        public string NumFactura { get; set; }
        public string NCF { get; set; }
        public string Empresa { get; set; }
        public string Contacto { get; set; }
        public string RNC { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public Nullable<decimal> TotalFactura { get; set; }
        public Nullable<System.DateTime> FechaFactura { get; set; }
        public Nullable<System.DateTime> FechaVencimientoFactura { get; set; }
        public Nullable<decimal> MontoPendiente { get; set; }
        public Nullable<decimal> MontoPagado { get; set; }
    }
}
