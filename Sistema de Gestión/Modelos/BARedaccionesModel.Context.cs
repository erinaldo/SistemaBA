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
    
    public partial class BARedaccionesEntities : DbContext
    {
        public BARedaccionesEntities()
            : base("name=BARedaccionesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<SP_VerDetalleRedaccion_Result> SP_VerDetalleRedaccion(Nullable<int> iDPedidos)
        {
            var iDPedidosParameter = iDPedidos.HasValue ?
                new ObjectParameter("IDPedidos", iDPedidos) :
                new ObjectParameter("IDPedidos", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_VerDetalleRedaccion_Result>("SP_VerDetalleRedaccion", iDPedidosParameter);
        }
    
        public virtual ObjectResult<SP_VerRedaccionClienteID_Result> SP_VerRedaccionClienteID(Nullable<int> iDCliente)
        {
            var iDClienteParameter = iDCliente.HasValue ?
                new ObjectParameter("IDCliente", iDCliente) :
                new ObjectParameter("IDCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_VerRedaccionClienteID_Result>("SP_VerRedaccionClienteID", iDClienteParameter);
        }
    
        public virtual ObjectResult<SP_VerConducesPedidos_Result> SP_VerConducesPedidos(Nullable<int> iDPedido)
        {
            var iDPedidoParameter = iDPedido.HasValue ?
                new ObjectParameter("IDPedido", iDPedido) :
                new ObjectParameter("IDPedido", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_VerConducesPedidos_Result>("SP_VerConducesPedidos", iDPedidoParameter);
        }
    }
}
