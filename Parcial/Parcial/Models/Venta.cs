//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Parcial.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        public int VentaID { get; set; }
        public int ClienteID { get; set; }
        public int ViviendaID { get; set; }
        [JsonIgnore]
        public System.DateTime FechaVenta { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Vivienda Vivienda { get; set; }
    }
}
