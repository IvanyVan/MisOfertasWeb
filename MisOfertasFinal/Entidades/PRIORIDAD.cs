//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MisOfertasFinal.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRIORIDAD
    {
        public decimal ID_PRIORIDAD { get; set; }
        public decimal PRODUCTO_1 { get; set; }
        public decimal PRODUCTO_2 { get; set; }
        public string RUT_USUARIO { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
    }
}
