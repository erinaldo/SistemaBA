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
    
    public partial class SP_VerFacturaID_Result
    {
        public int id_Factura { get; set; }
        public string Num_Factura { get; set; }
        public string TipoFactura { get; set; }
        public string NCF { get; set; }
        public string Empresa { get; set; }
        public string Proyecto { get; set; }
        public string Nom_Contacto { get; set; }
        public string Telefonos { get; set; }
        public string RNC { get; set; }
        public string Correo { get; set; }
        public string Dirección { get; set; }
        public string Nom_Estatus { get; set; }
        public Nullable<decimal> SubTotalFactura { get; set; }
        public Nullable<decimal> TotalFactura { get; set; }
        public string MetodoPago { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<decimal> ITBIS { get; set; }
        public Nullable<System.DateTime> FechaFactura { get; set; }
        public Nullable<System.TimeSpan> HoraFactura { get; set; }
        public Nullable<System.DateTime> FechaVencimientoFactura { get; set; }
        public string NotaFactura { get; set; }
        public string NombreUsuario { get; set; }
    }
}
