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
    
    public partial class VW_VerListaVehiculos
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Descripción { get; set; }
        public string Matricula { get; set; }
        public string Seguro { get; set; }
        public string Fecha_Emisión_Seguro { get; set; }
        public string Fecha_Vencimiento_Seguro { get; set; }
        public string Estatus { get; set; }
        public Nullable<int> Capacidad { get; set; }
    }
}
