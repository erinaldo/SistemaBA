﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BACotizacionesEntities : DbContext
    {
        public BACotizacionesEntities()
            : base("name=BACotizacionesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<VW_VerUltimoNumeroCotizacion> VW_VerUltimoNumeroCotizacion { get; set; }
    
        public virtual int SP_InsertarCotizacion(Nullable<int> idCliente, Nullable<decimal> descuento, Nullable<decimal> subTotalCotizacion, Nullable<decimal> iTBIS, Nullable<decimal> totalCotizacion, Nullable<System.DateTime> fechaCotizacion, Nullable<System.DateTime> horaCotizacion, Nullable<int> iDUsuario)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            var descuentoParameter = descuento.HasValue ?
                new ObjectParameter("Descuento", descuento) :
                new ObjectParameter("Descuento", typeof(decimal));
    
            var subTotalCotizacionParameter = subTotalCotizacion.HasValue ?
                new ObjectParameter("SubTotalCotizacion", subTotalCotizacion) :
                new ObjectParameter("SubTotalCotizacion", typeof(decimal));
    
            var iTBISParameter = iTBIS.HasValue ?
                new ObjectParameter("ITBIS", iTBIS) :
                new ObjectParameter("ITBIS", typeof(decimal));
    
            var totalCotizacionParameter = totalCotizacion.HasValue ?
                new ObjectParameter("TotalCotizacion", totalCotizacion) :
                new ObjectParameter("TotalCotizacion", typeof(decimal));
    
            var fechaCotizacionParameter = fechaCotizacion.HasValue ?
                new ObjectParameter("FechaCotizacion", fechaCotizacion) :
                new ObjectParameter("FechaCotizacion", typeof(System.DateTime));
    
            var horaCotizacionParameter = horaCotizacion.HasValue ?
                new ObjectParameter("HoraCotizacion", horaCotizacion) :
                new ObjectParameter("HoraCotizacion", typeof(System.DateTime));
    
            var iDUsuarioParameter = iDUsuario.HasValue ?
                new ObjectParameter("IDUsuario", iDUsuario) :
                new ObjectParameter("IDUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertarCotizacion", idClienteParameter, descuentoParameter, subTotalCotizacionParameter, iTBISParameter, totalCotizacionParameter, fechaCotizacionParameter, horaCotizacionParameter, iDUsuarioParameter);
        }
    
        public virtual int SP_InsertarDetallesCotizacion(Nullable<int> cantidad, Nullable<int> idMedida, Nullable<int> idProducto, string desProducto, Nullable<decimal> costo, Nullable<decimal> subTotalProducto)
        {
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var idMedidaParameter = idMedida.HasValue ?
                new ObjectParameter("idMedida", idMedida) :
                new ObjectParameter("idMedida", typeof(int));
    
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("idProducto", idProducto) :
                new ObjectParameter("idProducto", typeof(int));
    
            var desProductoParameter = desProducto != null ?
                new ObjectParameter("DesProducto", desProducto) :
                new ObjectParameter("DesProducto", typeof(string));
    
            var costoParameter = costo.HasValue ?
                new ObjectParameter("Costo", costo) :
                new ObjectParameter("Costo", typeof(decimal));
    
            var subTotalProductoParameter = subTotalProducto.HasValue ?
                new ObjectParameter("SubTotalProducto", subTotalProducto) :
                new ObjectParameter("SubTotalProducto", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertarDetallesCotizacion", cantidadParameter, idMedidaParameter, idProductoParameter, desProductoParameter, costoParameter, subTotalProductoParameter);
        }
    }
}
