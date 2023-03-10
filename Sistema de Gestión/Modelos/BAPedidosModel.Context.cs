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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BAPedidosEntities : DbContext
    {
        public BAPedidosEntities()
            : base("name=BAPedidosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<VW_VerUltimoNumeroPedido> VW_VerUltimoNumeroPedido { get; set; }
        public virtual DbSet<VW_EmpleadosFactura> VW_EmpleadosFactura { get; set; }
        public virtual DbSet<VW_ListarVehiculos> VW_ListarVehiculos { get; set; }
        public virtual DbSet<VW_ListarMedidas> VW_ListarMedidas { get; set; }
        public virtual DbSet<VW_ProductosFactura> VW_ProductosFactura { get; set; }
    
        public virtual int SP_InsertarDetallesPedido(Nullable<int> idProducto, Nullable<int> id_Medida, Nullable<int> cantidad, Nullable<decimal> precio, Nullable<decimal> subtotal, string descripcion)
        {
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("idProducto", idProducto) :
                new ObjectParameter("idProducto", typeof(int));
    
            var id_MedidaParameter = id_Medida.HasValue ?
                new ObjectParameter("id_Medida", id_Medida) :
                new ObjectParameter("id_Medida", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("precio", precio) :
                new ObjectParameter("precio", typeof(decimal));
    
            var subtotalParameter = subtotal.HasValue ?
                new ObjectParameter("subtotal", subtotal) :
                new ObjectParameter("subtotal", typeof(decimal));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertarDetallesPedido", idProductoParameter, id_MedidaParameter, cantidadParameter, precioParameter, subtotalParameter, descripcionParameter);
        }
    
        public virtual int SP_InsertarPedido(Nullable<int> idCliente, Nullable<int> idEstatusPedido, Nullable<decimal> subtotalPedido, Nullable<decimal> totalPedido, Nullable<decimal> iTBISPedido, Nullable<decimal> descuentoPedido)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            var idEstatusPedidoParameter = idEstatusPedido.HasValue ?
                new ObjectParameter("idEstatusPedido", idEstatusPedido) :
                new ObjectParameter("idEstatusPedido", typeof(int));
    
            var subtotalPedidoParameter = subtotalPedido.HasValue ?
                new ObjectParameter("SubtotalPedido", subtotalPedido) :
                new ObjectParameter("SubtotalPedido", typeof(decimal));
    
            var totalPedidoParameter = totalPedido.HasValue ?
                new ObjectParameter("totalPedido", totalPedido) :
                new ObjectParameter("totalPedido", typeof(decimal));
    
            var iTBISPedidoParameter = iTBISPedido.HasValue ?
                new ObjectParameter("ITBISPedido", iTBISPedido) :
                new ObjectParameter("ITBISPedido", typeof(decimal));
    
            var descuentoPedidoParameter = descuentoPedido.HasValue ?
                new ObjectParameter("DescuentoPedido", descuentoPedido) :
                new ObjectParameter("DescuentoPedido", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertarPedido", idClienteParameter, idEstatusPedidoParameter, subtotalPedidoParameter, totalPedidoParameter, iTBISPedidoParameter, descuentoPedidoParameter);
        }
    
        public virtual ObjectResult<SP_BuscarClienteCodigo_Result> SP_BuscarClienteCodigo(string codigo_Cliente)
        {
            var codigo_ClienteParameter = codigo_Cliente != null ?
                new ObjectParameter("Codigo_Cliente", codigo_Cliente) :
                new ObjectParameter("Codigo_Cliente", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_BuscarClienteCodigo_Result>("SP_BuscarClienteCodigo", codigo_ClienteParameter);
        }
    
        public virtual int SP_InsertarConduces(Nullable<int> id_Empleado, Nullable<int> num_Conduce, Nullable<int> id_producto, Nullable<int> id_vehiculo, Nullable<int> id_medida, Nullable<int> cantidadViajes)
        {
            var id_EmpleadoParameter = id_Empleado.HasValue ?
                new ObjectParameter("id_Empleado", id_Empleado) :
                new ObjectParameter("id_Empleado", typeof(int));
    
            var num_ConduceParameter = num_Conduce.HasValue ?
                new ObjectParameter("num_Conduce", num_Conduce) :
                new ObjectParameter("num_Conduce", typeof(int));
    
            var id_productoParameter = id_producto.HasValue ?
                new ObjectParameter("id_producto", id_producto) :
                new ObjectParameter("id_producto", typeof(int));
    
            var id_vehiculoParameter = id_vehiculo.HasValue ?
                new ObjectParameter("id_vehiculo", id_vehiculo) :
                new ObjectParameter("id_vehiculo", typeof(int));
    
            var id_medidaParameter = id_medida.HasValue ?
                new ObjectParameter("id_medida", id_medida) :
                new ObjectParameter("id_medida", typeof(int));
    
            var cantidadViajesParameter = cantidadViajes.HasValue ?
                new ObjectParameter("CantidadViajes", cantidadViajes) :
                new ObjectParameter("CantidadViajes", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertarConduces", id_EmpleadoParameter, num_ConduceParameter, id_productoParameter, id_vehiculoParameter, id_medidaParameter, cantidadViajesParameter);
        }
    
        public virtual int SP_InsertarConducesPedidos(Nullable<int> id_Empleado, Nullable<int> num_Conduce, Nullable<int> id_producto, Nullable<int> id_vehiculo, Nullable<int> id_medida, Nullable<int> cantidadViajes)
        {
            var id_EmpleadoParameter = id_Empleado.HasValue ?
                new ObjectParameter("id_Empleado", id_Empleado) :
                new ObjectParameter("id_Empleado", typeof(int));
    
            var num_ConduceParameter = num_Conduce.HasValue ?
                new ObjectParameter("num_Conduce", num_Conduce) :
                new ObjectParameter("num_Conduce", typeof(int));
    
            var id_productoParameter = id_producto.HasValue ?
                new ObjectParameter("id_producto", id_producto) :
                new ObjectParameter("id_producto", typeof(int));
    
            var id_vehiculoParameter = id_vehiculo.HasValue ?
                new ObjectParameter("id_vehiculo", id_vehiculo) :
                new ObjectParameter("id_vehiculo", typeof(int));
    
            var id_medidaParameter = id_medida.HasValue ?
                new ObjectParameter("id_medida", id_medida) :
                new ObjectParameter("id_medida", typeof(int));
    
            var cantidadViajesParameter = cantidadViajes.HasValue ?
                new ObjectParameter("CantidadViajes", cantidadViajes) :
                new ObjectParameter("CantidadViajes", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertarConducesPedidos", id_EmpleadoParameter, num_ConduceParameter, id_productoParameter, id_vehiculoParameter, id_medidaParameter, cantidadViajesParameter);
        }
    }
}
